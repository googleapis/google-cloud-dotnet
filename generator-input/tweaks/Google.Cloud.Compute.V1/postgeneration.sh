#!/bin/bash

set -e

# TODO: Remove this when we move the generator code
cd ../../../apis/Google.Cloud.Compute.V1

# Generate enum constants
dotnet build Google.Cloud.Compute.V1.EnumConstantGenerator
dotnet run --no-build --project Google.Cloud.Compute.V1.EnumConstantGenerator > Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs