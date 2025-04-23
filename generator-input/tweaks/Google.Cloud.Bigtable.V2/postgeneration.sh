#!/bin/bash

set -e

BIGTABLE_OUTPUT=$GENERATOR_OUTPUT_DIR/apis/Google.Cloud.Bigtable.V2

# Generate BigtableClient, either using a pre-built version of our client
# generator if we're running in a container, or building-and-running otherwise.
if [ -d /app/Google.Cloud.Bigtable.V2.GenerateClient ]
then
  dotnet /app/Google.Cloud.Bigtable.V2.GenerateClient/Google.Cloud.Bigtable.V2.GenerateClient.dll \
    $BIGTABLE_OUTPUT/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
    BigtableServiceApiClient \
    BigtableClient
else
  dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient -- \
    $BIGTABLE_OUTPUT/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
    BigtableServiceApiClient \
    BigtableClient
fi
