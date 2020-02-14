#!/bin/bash

set -e

# Undo the changes in googleapis
git -C ../../googleapis checkout google/pubsub/v1/pubsub.proto
git -C ../../googleapis checkout google/pubsub/v1/pubsub_grpc_service_config.json
