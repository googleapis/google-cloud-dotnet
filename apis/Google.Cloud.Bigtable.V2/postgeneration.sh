#!/bin/bash

set -e

# Generate BigtableClient
dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient \
  Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
