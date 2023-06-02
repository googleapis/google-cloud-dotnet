#!/bin/bash

set -e

# Fix the gRPC generated code (for the grpc::Method instances) so it refers to the right server-side RPC
sed -i 's/"UpdateBucketLongRunning"/"UpdateBucketAsync"/g' Google.Cloud.Logging.V2/LoggingConfigGrpc.g.cs
sed -i 's/"CreateBucketLongRunning"/"CreateBucketAsync"/g' Google.Cloud.Logging.V2/LoggingConfigGrpc.g.cs

# Undo the changes made in pregeneration.sh
git -C $GOOGLEAPIS checkout google/logging/v2
