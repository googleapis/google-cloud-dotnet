#!/bin/bash

set -e

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

# First update the submodule with the new tests/protos
git submodule update --remote conformance-tests


# Now regenerate C# from the protos

# Storage
$PROTOC \
  --csharp_out=apis/Google.Cloud.Storage.V1/Google.Cloud.Storage.V1.Tests/Conformance \
  -I conformance-tests \
  -I $CORE_PROTOS_ROOT \
  conformance-tests/storage/v1/proto/google/cloud/conformance/storage/v1/*.proto

# Firestore
$PROTOC \
  --csharp_out=apis/Google.Cloud.Firestore/Google.Cloud.Firestore.Tests/Proto \
  -I conformance-tests \
  -I $CORE_PROTOS_ROOT \
  -I googleapis \
  conformance-tests/firestore/v1/proto/google/cloud/conformance/firestore/v1/*.proto

# Bigtable
$PROTOC \
  --csharp_out=apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.Tests/Conformance \
  -I conformance-tests \
  -I $CORE_PROTOS_ROOT \
  -I googleapis \
  conformance-tests/bigtable/v2/proto/google/cloud/conformance/bigtable/v2/*.proto
