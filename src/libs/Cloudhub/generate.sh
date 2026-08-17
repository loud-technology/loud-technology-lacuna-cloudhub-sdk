#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.30.2-dev.152"
readonly OPENAPI_URL="https://cloudhub.lacunasoftware.com/swagger/v1/swagger.json"
readonly DEFAULT_BASE_URL="https://cloudhub.lacunasoftware.com"

if ! command -v autosdk >/dev/null 2>&1; then
  dotnet tool install --global autosdk.cli --version "${AUTOSDK_VERSION}"
fi

curl --fail --silent --show-error "${OPENAPI_URL}" --output openapi.json
python3 apply-openapi-overrides.py openapi.json

rm -rf Generated

autosdk generate openapi.json \
  --namespace Loud.Technology.Lacuna.Cloudhub.Sdk \
  --clientClassName CloudhubClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env LACUNA_CLOUDHUB_BASE_URL \
  --security-scheme ApiKey:Header:X-Api-Key \
  --api-key-env LACUNA_CLOUDHUB_API_KEY \
  --validation \
  --generate-http-exception-hierarchy \
  --exclude-deprecated-operations
