#!/bin/bash

set -e

# LoggingConfig has methods UpdateBucket and UpdateBucketAsync,
# and CreateBucket and CreateBucketAsync... which causes conflicts
# in both GAPIC and gRPC-generated code.
# For now, rename the "XyzAsync" versions to "BeginXyz".
# We'll revisit this naming before the next release.
# (AIPs will be updated to prohibit this and suggest a different name.)
sed -i 's/rpc UpdateBucketAsync/rpc BeginUpdateBucket/g' $GOOGLEAPIS/google/logging/v2/logging_config.proto
sed -i 's/rpc CreateBucketAsync/rpc BeginCreateBucket/g' $GOOGLEAPIS/google/logging/v2/logging_config.proto
