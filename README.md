<div align="center">
  <img src="assets/nuget-icon.png" alt="Lacuna Cloudhub .NET SDK" width="112" />
  <h1>Lacuna Cloudhub .NET SDK</h1>
  <p><strong>Cloud certificate discovery, authentication, and signing through a strongly typed .NET client.</strong></p>
  <p>Use the Lacuna Cloudhub API without hand-written HTTP requests, with generated models, async methods, source-generated JSON serialization, and <code>X-Api-Key</code> authentication.</p>

  [![NuGet](https://img.shields.io/nuget/vpre/Lacuna.Cloudhub?logo=nuget&label=NuGet.org)](https://www.nuget.org/packages/Lacuna.Cloudhub/)
  [![CI](https://github.com/loud-technology/loud-technology-lacuna-cloudhub-sdk/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/loud-technology/loud-technology-lacuna-cloudhub-sdk/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

---

## Features

- **Complete v1 Swagger coverage** — service discovery, availability, session creation, certificate retrieval, hash signing, and custom state.
- **Strongly typed contracts** — request/response models and enums generated from Cloudhub's official OpenAPI document.
- **API key authentication** — every operation sends the credential in the `X-Api-Key` header.
- **Modern .NET** — async APIs, nullable annotations, source-generated `System.Text.Json`, trimming analysis, assembly signing, and reproducible packages.
- **Reproducible generation** — the pinned AutoSDK version plus deterministic OpenAPI overrides produce stable operation names and authentication metadata.

> [!NOTE]
> This community SDK is maintained by loud-technology and generated from Lacuna Software's public Cloudhub OpenAPI specification. It is not an official Lacuna Software SDK.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later to build
- A Lacuna Cloudhub API key

## Install  

```bash
dotnet add package Lacuna.Cloudhub
```

## Quick start

Keep the credential outside source control:

```bash
export LACUNA_CLOUDHUB_API_KEY="your-cloudhub-api-key"
```

Then discover available trust services for a CPF:

```csharp
using Loud.Technology.Lacuna.Cloudhub.Sdk;

using var client = CloudhubClient.CreateFromEnvironment();

var services = await client.GetServicesAsync(
    identifier: "12345678901",
    identifierType: IdentifierTypes.Cpf);

foreach (var service in services)
{
    Console.WriteLine($"{service.ServiceName} — {service.Provider}");
}
```

Create a single-signature session:

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

## Configure the client

### Explicit credential

```csharp
using var client = new CloudhubClient("your-cloudhub-api-key");
```

### Custom endpoint and application-managed `HttpClient`

```csharp
using var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(30) };
using var client = new CloudhubClient(
    apiKey: Environment.GetEnvironmentVariable("LACUNA_CLOUDHUB_API_KEY")!,
    httpClient: httpClient,
    baseUri: new Uri("https://cloudhub.lacunasoftware.com"),
    disposeHttpClient: false);
```

| Variable | Purpose | Default |
|---|---|---|
| `LACUNA_CLOUDHUB_API_KEY` | Value sent in the `X-Api-Key` header | Required by `CreateFromEnvironment()` |
| `LACUNA_CLOUDHUB_BASE_URL` | Cloudhub API base URL | `https://cloudhub.lacunasoftware.com` |

Never commit API keys. Use environment variables, .NET user secrets, or a cloud secret manager.

## API surface

| Method | Cloudhub endpoint |
|---|---|
| `GetServicesAsync` | `GET /api/sessions/services` |
| `GetServiceAvailabilityAsync` | `GET /api/sessions/services/{name}/availability` |
| `CreateSessionAsync` | `POST /api/sessions` |
| `CreateServiceSessionAsync` | `POST /api/sessions/services/{name}` |
| `GetCertificateAsync` | `GET /api/sessions/certificate` |
| `GetCertificateV2Async` | `GET /api/v2/sessions/certificate` |
| `SignHashAsync` | `POST /api/sessions/sign-hash` |
| `GetCustomStateAsync` | `GET /api/sessions/custom-state` |

Every method accepts a `CancellationToken`. Methods ending in `AsResponseAsync` expose status and headers. Non-success responses throw `ApiException`; generated typed subclasses include authentication, authorization, validation, rate-limit, and server exceptions.

## Regenerate

```bash
cd src/libs/Cloudhub
./generate.sh
```

The script downloads the [official Swagger document](https://cloudhub.lacunasoftware.com/swagger/v1/swagger.json), applies deterministic fixes for missing operation IDs and global security, and replaces `Generated/` using AutoSDK `0.30.2-dev.152`.

## Build and test

```bash
dotnet restore Loud.Technology.Lacuna.Cloudhub.Sdk.slnx
dotnet build Loud.Technology.Lacuna.Cloudhub.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.Lacuna.Cloudhub.Sdk.slnx --configuration Release --no-build
```

Network-free contract tests verify the default URL, `X-Api-Key` header, routes, enum/query serialization, typed responses, byte-array handling, and model validation.

## License

Licensed under the [MIT License](LICENSE).

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).