#!/bin/bash

set -e

# The fleetengine.v1 gRPC service config contains entries for fleetengine.delivery.v1
# as well. We expect the API to be self-contained, so copy the config.
cp $GOOGLEAPIS/google/maps/fleetengine/v1/fleetengine_grpc_service_config.json \
  $GOOGLEAPIS/google/maps/fleetengine/delivery/v1/fleetengine_delivery_grpc_service_config.json
