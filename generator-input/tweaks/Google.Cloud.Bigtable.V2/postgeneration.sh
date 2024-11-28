#!/bin/bash

set -e

# TODO: Use the right output directory
GENERATOR_OUTPUT=../../..
BIGTABLE_OUTPUT=$GENERATOR_OUTPUT/apis/Google.Cloud.Bigtable.V2

# Generate BigtableClient
dotnet run --project Google.Cloud.Bigtable.V2.GenerateClient -- \
  $BIGTABLE_OUTPUT/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
  BigtableServiceApiClient \
  BigtableClient
