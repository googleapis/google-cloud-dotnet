#!/bin/bash

set -e

# Fix up Grpc.Core parts
# We have a hand-written piece at the moment for the adapter.
sed -i 's/using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;//g' Google.Cloud.Compute.V1/*.g.cs
sed -i 's/=> gaxgrpccore::GrpcCoreAdapter.Instance/=> ComputeRestAdapter.ComputeAdapter/g' Google.Cloud.Compute.V1/*.g.cs

# Generate enum constants
dotnet build Google.Cloud.Compute.V1.EnumConstantGenerator
dotnet run --no-build -p Google.Cloud.Compute.V1.EnumConstantGenerator > Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs