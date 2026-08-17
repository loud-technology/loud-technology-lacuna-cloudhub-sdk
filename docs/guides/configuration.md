# Client configuration

## Environment-based setup

```bash
export LACUNA_CLOUDHUB_API_KEY="your-cloudhub-api-key"
export LACUNA_CLOUDHUB_BASE_URL="https://cloudhub.lacunasoftware.com"
```

```csharp
using Loud.Technology.Lacuna.Cloudhub.Sdk;

using var client = CloudhubClient.CreateFromEnvironment();
```

`CreateFromEnvironment()` throws `InvalidOperationException` when the key is missing or the configured URL is invalid.

## Explicit setup

```csharp
using var client = new CloudhubClient(
    apiKey: "your-cloudhub-api-key",
    baseUri: new Uri("https://cloudhub.lacunasoftware.com"));
```

The credential is sent in the `X-Api-Key` header, not as a bearer token or query parameter.

## Application-managed transport

```csharp
using var httpClient = new HttpClient
{
    Timeout = TimeSpan.FromSeconds(30),
};

using var client = new CloudhubClient(
    apiKey: Environment.GetEnvironmentVariable("LACUNA_CLOUDHUB_API_KEY")!,
    httpClient: httpClient,
    baseUri: new Uri("https://cloudhub.lacunasoftware.com"),
    disposeHttpClient: false);
```

Set `disposeHttpClient: false` when dependency injection or your application owns the `HttpClient` lifetime.

## Per-request options

Generated methods accept `AutoSDKRequestOptions` for additional headers, query parameters, timeout, retries, and response buffering. Avoid placing credentials in these options; use the client constructor so authentication remains consistent.
