#!/bin/bash

set -e

# Generate an additional proto file containing annotations for
# LROs. Ideally this would be in a common protos directory (or
# google.longrunning) but it's too late to fix that now.
# We expect that protoc is already installed, and that all the
# environment variables used below are present.
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

$PROTOC \
  --csharp_out=$GENERATOR_OUTPUT_DIR/apis/Google.LongRunning/Google.LongRunning \
  --csharp_opt=base_namespace=Google.Cloud,file_extension=.g.cs \
  -I $GOOGLEAPIS \
  -I $CORE_PROTOS_ROOT \
  $GOOGLEAPIS/google/cloud/extended_operations.proto
