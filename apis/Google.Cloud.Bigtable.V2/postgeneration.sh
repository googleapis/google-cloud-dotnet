#!/bin/bash

set -e

# Undo the changes in googleapis
# (Do this first so that if we have any failures in the remaining steps)
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable.proto
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable_grpc_service_config.json
git -C $GOOGLEAPIS checkout google/bigtable/v2/bigtable_v2.yaml

# Fix up the generated client for using Grpc.Gcp and other tweaks
sed -i -r -f BigtableServiceApiClient.sed Google.Cloud.Bigtable.V2/BigtableServiceApiClient.g.cs

# Fix up the unit test class too
sed -i s/BigtableServiceApi.BigtableServiceApiClient/Bigtable.BigtableClient/g Google.Cloud.Bigtable.V2.Tests/BigtableServiceApiClientTest.g.cs

# Fix up the metadata
sed -i 's/"BigtableServiceApi": {/"Bigtable": {/g' gapic_metadata.json

# Generate BigtableClient
dotnet run -p Google.Cloud.Bigtable.V2.GenerateClient \
  Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
