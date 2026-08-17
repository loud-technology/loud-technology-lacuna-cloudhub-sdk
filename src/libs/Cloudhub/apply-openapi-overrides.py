#!/usr/bin/env python3
"""Apply deterministic generation fixes to Cloudhub's published OpenAPI document."""

from __future__ import annotations

import json
import sys
from pathlib import Path
from typing import Any


OPERATION_IDS = {
    ("/api/sessions/services", "get"): "GetServices",
    ("/api/sessions/services/{name}/availability", "get"): "GetServiceAvailability",
    ("/api/sessions", "post"): "CreateSession",
    ("/api/sessions/services/{name}", "post"): "CreateServiceSession",
    ("/api/sessions/certificate", "get"): "GetCertificate",
    ("/api/v2/sessions/certificate", "get"): "GetCertificateV2",
    ("/api/sessions/sign-hash", "post"): "SignHash",
    ("/api/sessions/custom-state", "get"): "GetCustomState",
}


def apply_overrides(spec: dict[str, Any]) -> None:
    schemes = spec.setdefault("components", {}).setdefault("securitySchemes", {})
    api_key = schemes.get("ApiKey")
    expected = {"type": "apiKey", "name": "X-Api-Key", "in": "header"}
    if not isinstance(api_key, dict) or any(api_key.get(key) != value for key, value in expected.items()):
        raise RuntimeError("Cloudhub OpenAPI no longer defines ApiKey as X-Api-Key header authentication")

    spec["servers"] = [{"url": "https://cloudhub.lacunasoftware.com"}]
    spec["security"] = [{"ApiKey": []}]

    for (path, method), operation_id in OPERATION_IDS.items():
        try:
            operation = spec["paths"][path][method]
        except KeyError as exception:
            raise RuntimeError(f"Cloudhub OpenAPI no longer exposes {method.upper()} {path}") from exception
        operation["operationId"] = operation_id
        operation["security"] = [{"ApiKey": []}]
        if method == "post" and "requestBody" in operation:
            operation["requestBody"]["required"] = True


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_FILE")

    path = Path(sys.argv[1])
    with path.open(encoding="utf-8") as stream:
        spec = json.load(stream)

    apply_overrides(spec)

    with path.open("w", encoding="utf-8") as stream:
        json.dump(spec, stream, ensure_ascii=False, indent=2)
        stream.write("\n")


if __name__ == "__main__":
    main()
