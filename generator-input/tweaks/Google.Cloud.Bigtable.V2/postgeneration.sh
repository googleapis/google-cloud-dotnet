#!/bin/bash

set -e

BIGTABLE_OUTPUT=$GENERATOR_OUTPUT_DIR/apis/Google.Cloud.Bigtable.V2

# Generate BigtableClient
dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient -- \
  $BIGTABLE_OUTPUT/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
