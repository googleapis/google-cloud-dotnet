#!/bin/bash

set -e

# TODO: Use the appropriate output directory

GENERATOR_OUTPUT=../../..
COMPUTE_OUTPUT=$GENERATOR_OUTPUT/apis/Google.Cloud.Compute.V1

TFM=netstandard2.0

mkdir -p /tmp/compute
dotnet build $COMPUTE_OUTPUT/Google.Cloud.Compute.V1 -f $TFM -o /tmp/compute

# Generate enum constants
dotnet run --project Google.Cloud.Compute.V1.EnumConstantGenerator \
    /tmp/compute/Google.Cloud.Compute.V1.dll \
    > $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs
