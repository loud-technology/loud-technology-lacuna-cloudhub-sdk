using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Loud.Technology.Lacuna.Cloudhub.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndApiKeyAuthentication()
    {
        using var client = new CloudhubClient("test-api-key");

        client.BaseUri.Should().Be(new Uri("https://cloudhub.lacunasoftware.com/"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("ApiKey");
        authorization.Location.Should().Be("Header");
        authorization.Name.Should().Be("X-Api-Key");
        authorization.Value.Should().Be("test-api-key");
    }

    [TestMethod]
    public async Task GetServices_SendsApiKeyAndTypedQueryParameters()
    {
        using var handler = new RecordingHandler(JsonResponse("[]"));
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var services = await client.GetServicesAsync(
            identifier: "12345678901",
            identifierType: IdentifierTypes.Cpf);

        services.Should().BeEmpty();
        handler.Method.Should().Be(HttpMethod.Get);
        handler.RequestUri.Should().Be(
            new Uri("https://cloudhub.example/api/sessions/services?identifier=12345678901&identifierType=CPF"));
        handler.ApiKey.Should().Be("test-api-key");
    }

    [TestMethod]
    public async Task CreateSession_SerializesRequestAndReturnsTypedResponse()
    {
        const string responseJson =
            """
            {
              "services": [
                {
                  "serviceInfo": {
                    "serviceName": "ExampleService",
                    "provider": "Example Provider"
                  },
                  "authUrl": "https://identity.example/authorize"
                }
              ]
            }
            """;
        using var handler = new RecordingHandler(JsonResponse(responseJson));
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var response = await client.CreateSessionAsync(
            redirectUri: "https://app.example/callback",
            identifierType: IdentifierTypes.Cpf,
            identifier: "12345678901",
            type: TrustServiceSessionTypes.SingleSignature,
            lifetimeInSeconds: 300,
            customState: "order-42",
            discover: true);

        handler.Method.Should().Be(HttpMethod.Post);
        handler.RequestUri.Should().Be(new Uri("https://cloudhub.example/api/sessions"));
        handler.ApiKey.Should().Be("test-api-key");

        using var body = JsonDocument.Parse(handler.Body!);
        var root = body.RootElement;
        root.GetProperty("redirectUri").GetString().Should().Be("https://app.example/callback");
        root.GetProperty("identifierType").GetString().Should().Be("CPF");
        root.GetProperty("type").GetString().Should().Be("SingleSignature");
        root.GetProperty("lifetimeInSeconds").GetInt32().Should().Be(300);
        root.GetProperty("customState").GetString().Should().Be("order-42");
        root.GetProperty("discover").GetBoolean().Should().BeTrue();

        response.Services.Should().ContainSingle();
        response.Services![0].ServiceInfo!.ServiceName.Should().Be("ExampleService");
        response.Services[0].AuthUrl.Should().Be("https://identity.example/authorize");
    }

    [TestMethod]
    public async Task SignHash_SerializesBytesAsBase64AndReturnsSignature()
    {
        var signature = new byte[] { 9, 8, 7 };
        using var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(signature),
            });
        using var httpClient = new HttpClient(handler);
        using var client = CreateClient(httpClient);

        var result = await client.SignHashAsync(
            session: "session-token",
            hash: new byte[] { 1, 2, 3 },
            digestAlgorithm: "SHA256");

        handler.RequestUri.Should().Be(new Uri("https://cloudhub.example/api/sessions/sign-hash"));
        handler.ApiKey.Should().Be("test-api-key");
        handler.Body.Should().Contain("\"session\":\"session-token\"");
        handler.Body.Should().Contain($"\"hash\":\"{Convert.ToBase64String([1, 2, 3])}\"");
        result.Should().Equal(signature);
    }

    [TestMethod]
    public void SessionRequest_ValidatesRequiredRedirectUri()
    {
        var request = new SessionCreateRequest { RedirectUri = string.Empty };
        var results = new List<ValidationResult>();

        Validator.TryValidateObject(request, new ValidationContext(request), results, validateAllProperties: true)
            .Should().BeFalse();
        results.Should().Contain(result => result.MemberNames.Contains(nameof(SessionCreateRequest.RedirectUri)));
    }

    private static CloudhubClient CreateClient(HttpClient httpClient) =>
        new(
            apiKey: "test-api-key",
            httpClient: httpClient,
            baseUri: new Uri("https://cloudhub.example"),
            disposeHttpClient: false);

    private static HttpResponseMessage JsonResponse(string json) =>
        new(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler, IDisposable
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public string? ApiKey { get; private set; }
        public string? Body { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            ApiKey = request.Headers.TryGetValues("X-Api-Key", out var values)
                ? values.Single()
                : null;
            Body = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);
            response.RequestMessage = request;
            return response;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                response.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
