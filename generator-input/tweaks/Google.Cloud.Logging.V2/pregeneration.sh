#!/bin/bash

set -e

# LoggingConfig has methods UpdateBucket and UpdateBucketAsync,
# and CreateBucket and CreateBucketAsync... which causes conflicts
# in both GAPIC and gRPC-generated code.
# We rename the "XyzAsync" versions to "XyzLongRunning", in line with
# https://google.aip.dev/136#rpc-name
sed -i 's/rpc UpdateBucketAsync/rpc UpdateBucketLongRunning/g' $GOOGLEAPIS/google/logging/v2/logging_config.proto
sed -i 's/rpc CreateBucketAsync/rpc CreateBucketLongRunning/g' $GOOGLEAPIS/google/logging/v2/logging_config.proto
