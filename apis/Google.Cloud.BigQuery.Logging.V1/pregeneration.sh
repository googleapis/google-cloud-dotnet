#!/bin/bash

set -e

# Add the C# namespace option to the proto, just before the Go option
sed -i '/^option go_package/i option csharp_namespace="Google.Cloud.BigQuery.Logging.V1";' $GOOGLEAPIS/google/cloud/bigquery/logging/v1/*.proto
