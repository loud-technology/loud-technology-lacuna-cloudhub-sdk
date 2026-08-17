namespace Loud.Technology.Lacuna.Cloudhub.Sdk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CloudhubClient GetAuthenticatedClient()
    {
        var apiKey = Environment.GetEnvironmentVariable("LACUNA_CLOUDHUB_API_KEY") is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException(
                "LACUNA_CLOUDHUB_API_KEY environment variable is not set.");
        var baseUrl = Environment.GetEnvironmentVariable("LACUNA_CLOUDHUB_BASE_URL")
            ?? CloudhubClient.DefaultBaseUrl;

        return new CloudhubClient(apiKey: apiKey, baseUri: new Uri(baseUrl));
    }
}
