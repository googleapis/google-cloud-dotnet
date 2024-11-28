#!/bin/bash

set -e

# Generate an additional proto file containing annotations for
# LROs. Ideally this would be in a common protos directory (or
# google.longrunning) but it's too late to fix that now.
cd ../../..
source toolversions.sh
install_protoc
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

$PROTOC \
  --csharp_out=apis/Google.LongRunning/Google.LongRunning \
  --csharp_opt=base_namespace=Google.Cloud,file_extension=.g.cs \
  -I $GOOGLEAPIS \
  -I $CORE_PROTOS_ROOT \
  $GOOGLEAPIS/google/cloud/extended_operations.proto
