#!/bin/bash

set -e

# Until we have transports in the generator itself, manually fix this up.
sed -i 's/ApiTransports.Grpc/ApiTransports.Rest/g' Google.Cloud.Compute.V1/*.g.cs

# Generate enum constants
dotnet build Google.Cloud.Compute.V1.EnumConstantGenerator
dotnet run --no-build --project Google.Cloud.Compute.V1.EnumConstantGenerator > Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs