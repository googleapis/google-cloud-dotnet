#!/bin/bash

set -e

COMPUTE_OUTPUT=$GENERATOR_OUTPUT_DIR/apis/Google.Cloud.Compute.V1

TFM=netstandard2.0

mkdir -p /tmp/compute

# Workarounds to get the generated code to compile.
# The project doesn't include Google.LongRunning due to the way DIREGAPIC works.
dotnet add $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/Google.Cloud.Compute.V1.csproj \
    package Google.LongRunning
# We have a currently-handwritten class which is required by the generated
# code. We could eventually generate it, but it's not clear how much value that would have.
cat << EOF > $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/OperationWorkaround.g.cs
using lro = Google.LongRunning;
namespace Google.Cloud.Compute.V1;
partial class Operation
{
    internal Google.LongRunning.Operation ToLroResponse(string name) => null;
}
EOF

# Build the code so we can access the descriptor
dotnet build $COMPUTE_OUTPUT/Google.Cloud.Compute.V1 -f $TFM -o /tmp/compute

# Remove the temporary file.
rm $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/OperationWorkaround.g.cs

# Generate enum constants
dotnet run --project Google.Cloud.Compute.V1.EnumConstantGenerator \
    /tmp/compute/Google.Cloud.Compute.V1.dll \
    > $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs
