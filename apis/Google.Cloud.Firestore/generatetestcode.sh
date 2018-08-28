#!/bin/bash

# Fetches the Firestore automated tests from
# https://github.com/googleapis/google-cloud-common
# then copies the data into the right place and generates the
# C# code from the proto.

set -e
source ../../toolversions.sh

install_protoc

declare -r API_PROTO_ROOT=$REPO_ROOT/googleapis
declare -r LIB_ROOT=$(realpath $(dirname $0))
declare -r PROTO_TEST_ROOT=$LIB_ROOT/Google.Cloud.Firestore.Tests/Proto

cd $API_PROTO_ROOT
rm -rf tmp
git clone https://github.com/googleapis/google-cloud-common --depth 1 tmp
cp tmp/testing/firestore/proto/*.proto $PROTO_TEST_ROOT
cp tmp/testing/firestore/testdata/test-suite.binproto $PROTO_TEST_ROOT

$PROTOC \
  --csharp_out=$PROTO_TEST_ROOT \
  -I $API_PROTO_ROOT \
  -I $PROTO_TEST_ROOT \
  -I $PROTOBUF_TOOLS_ROOT/tools \
  $PROTO_TEST_ROOT/*.proto

rm -rf tmp
