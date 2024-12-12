#!/bin/sh

# There are two gRPC JSON configs in google/devtools/artifactregistry/v1,
# which confuses the generator.
# Ideally this will be fixed upstream, but for the moment, delete the
# "new" one to be consistent with BUILD.bazel which uses the "old" one.
rm $GOOGLEAPIS/google/devtools/artifactregistry/v1/artifactregistry_v1_grpc_service_config.json
