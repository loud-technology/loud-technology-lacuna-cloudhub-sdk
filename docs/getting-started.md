# Getting started

## 1. Install

```bash
dotnet add package Lacuna.Cloudhub
```

The SDK targets .NET 10.

## 2. Configure the API key

=== "macOS and Linux"

    ```bash
    export LACUNA_CLOUDHUB_API_KEY="your-cloudhub-api-key"
    ```

=== "PowerShell"

    ```powershell
    $env:LACUNA_CLOUDHUB_API_KEY = "your-cloudhub-api-key"
    ```

The SDK sends this value as `X-Api-Key` on every request. Never commit real credentials.

## 3. Discover services

```csharp
using Loud.Technology.Lacuna.Cloudhub.Sdk;

using var client = CloudhubClient.CreateFromEnvironment();
var services = await client.GetServicesAsync(
    identifier: "12345678901",
    identifierType: IdentifierTypes.Cpf);
```

Use `IdentifierTypes.Cnpj` for a CNPJ.

## 4. Create a session

```csharp
var session = await client.CreateSessionAsync(
    redirectUri: "https://app.example.com/cloudhub/callback",
    identifierType: IdentifierTypes.Cpf,
    identifier: "12345678901",
    type: TrustServiceSessionTypes.SingleSignature,
    lifetimeInSeconds: 300,
    customState: "order-42",
    discover: true);

var authorizationUrl = session.Services?.FirstOrDefault()?.AuthUrl;
```

Redirect the user to the returned authorization URL. After Cloudhub redirects to your callback, use the session token according to your signing flow.

## 5. Sign a hash

```csharp
byte[] signature = await client.SignHashAsync(
    session: "session-token",
    hash: digestBytes,
    digestAlgorithm: "SHA256");
```

The generated model serializes `byte[]` values using base64 as required by the OpenAPI `byte` format.

## Errors and cancellation

```csharp
using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var response = await client.GetCertificateV2AsResponseAsync(
        session: "session-token",
        cancellationToken: timeout.Token);
    Console.WriteLine($"HTTP {(int)response.StatusCode}: {response.Body.Alias}");
}
catch (AuthenticationException exception)
{
    Console.Error.WriteLine($"Cloudhub rejected the API key: {exception.Message}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"Cloudhub request failed: {exception.Message}");
}
```
