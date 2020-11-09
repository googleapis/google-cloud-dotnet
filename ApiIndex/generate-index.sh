#!/bin/bash

set -e

# TODO: Install protoc instead of relying on it being installed
# already.

rm -rf tmp
mkdir tmp

PROTOBUF_BUILTIN=../packages/Google.Protobuf.Tools.3.13.0/tools
GOOGLEAPIS=../googleapis

echo "-I$PROTOBUF_BUILTIN" > tmp/protoc-options.txt
echo "-I$GOOGLEAPIS" >> tmp/protoc-options.txt
echo "--include_imports" >> tmp/protoc-options.txt
echo "--descriptor_set_out=tmp/all-protos.ds" >> tmp/protoc-options.txt
find $GOOGLEAPIS/google -name '*.proto' >> tmp/protoc-options.txt
find $GOOGLEAPIS/grafeas -name '*.proto' >> tmp/protoc-options.txt

echo "Generating descriptor set."
# Generate the descriptor set, but ignore import warnings (and
# ignore the exit code of grep).
$PROTOC @tmp/protoc-options.txt 2>&1 | \
  grep -v -E "Import [^ ]* is unused." || true

# Arguments to generator:
# - Descriptor set
# - googleapis directory to find service config files
# - Output directory
echo "Generating index."
dotnet run -- tmp/all-protos.ds ../googleapis tmp

echo "Done."
