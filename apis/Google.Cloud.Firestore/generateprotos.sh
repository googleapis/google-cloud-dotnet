#!/bin/bash

# Generates internal protos used by Google.Cloud.Firestore.
# Requires that the googleapis repo has already been 

set -e
source ../../toolversions.sh

install_protoc

rm -rf tmp
git clone https://github.com/googleapis/googleapis --depth 1 tmp

$PROTOC \
  --csharp_out=Google.Cloud.Firestore \
  --csharp_opt=internal_access=true \
  -I $PROTOBUF_TOOLS_ROOT/tools \
  -I Google.Cloud.Firestore \
  -I tmp \
  Google.Cloud.Firestore/*.proto

rm -rf tmp
