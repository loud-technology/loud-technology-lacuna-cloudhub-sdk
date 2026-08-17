# Lacuna Cloudhub .NET SDK

A modern, strongly typed .NET client for the [Lacuna Cloudhub API](https://cloudhub.lacunasoftware.com/swagger/), maintained by loud-technology.

## Highlights

- Complete coverage of the published Cloudhub v1 Swagger surface.
- `X-Api-Key` authentication applied to every operation.
- Typed session, service, certificate, and signing contracts.
- Async APIs, cancellation, source-generated JSON, and typed HTTP exceptions.
- Deterministic regeneration from the official specification.

!!! note
    This is a community SDK and is not an official Lacuna Software package.

## First request

```csharp
using Loud.Technology.Lacuna.Cloudhub.Sdk;

using var client = CloudhubClient.CreateFromEnvironment();
var services = await client.GetServicesAsync(
    identifier: "12345678901",
    identifierType: IdentifierTypes.Cpf);
```

Continue with [Getting started](getting-started.md) for installation and session creation.
