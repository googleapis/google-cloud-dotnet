#!/bin/bash

set -e

dotnet run -f net461 -p Google.Cloud.Bigtable.V2.GenerateClient \
 Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.csproj \
 BigtableServiceApiClient \
 BigtableClient
