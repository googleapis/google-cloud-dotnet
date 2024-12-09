#!/bin/bash

set -e

COMPUTE_OUTPUT=$GENERATOR_OUTPUT_DIR/apis/Google.Cloud.Compute.V1

TFM=netstandard2.0

# TODO: Try to eliminate some of this clunkiness. That could mean
# always generating into an empty output directory, or possibly moving the
# enum constant generator into the GAPIC generator.

# Build the production library in a temporary directory so that we don't depend on
# whether we're within a repo or not.
rm -rf /tmp/compute
mkdir -p /tmp/compute

# Even if we've got handwritten code available, we don't want it for this build.
cp -r $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/*.g.cs /tmp/compute
cp -r $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/*.csproj /tmp/compute

# Workarounds to get the generated code to compile.
# The project doesn't include Google.LongRunning due to the way DIREGAPIC works.
dotnet add /tmp/compute/Google.Cloud.Compute.V1.csproj \
    package Google.LongRunning
# We have a currently-handwritten class which is required by the generated
# code. We could eventually generate it, but it's not clear how much value that would have.
cat << EOF > /tmp/compute/OperationWorkaround.g.cs
using lro = Google.LongRunning;
namespace Google.Cloud.Compute.V1;
partial class Operation
{
    internal Google.LongRunning.Operation ToLroResponse(string name) => null;
}
EOF

# Build the code so we can access the descriptor
dotnet build /tmp/compute -f $TFM -c Debug

# Generate enum constants
dotnet run --project Google.Cloud.Compute.V1.EnumConstantGenerator \
    /tmp/compute/bin/Debug/$TFM/Google.Cloud.Compute.V1.dll \
    > $COMPUTE_OUTPUT/Google.Cloud.Compute.V1/ComputeEnumConstants.g.cs
