#!/bin/sh

set -e

# Temporary hack to add the C# namespace to the protos, until
# they're present in GitHub.
sed -i '/^option go_package/i option csharp_namespace = "Google.Cloud.DocumentAI.V1Beta2";' \
  $GOOGLEAPIS/google/cloud/documentai/v1beta2/*.proto
