#!/bin/bash

set -e

# TODO: Remove this when we move the client generator code
cd ../../../apis/Google.Cloud.Bigtable.V2

# Generate BigtableClient
dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient \
  Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
