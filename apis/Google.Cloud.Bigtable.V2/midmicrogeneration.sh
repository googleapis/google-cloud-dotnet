#!/bin/bash

# Rename the service to BigtableServiceApi
sed -i 's/service Bigtable/service BigtableServiceApi/g' ../../googleapis/google/bigtable/v2/bigtable.proto
sed -i 's/v2.Bigtable/v2.BigtableServiceApi/g' ../../googleapis/google/bigtable/v2/bigtable_grpc_service_config.json
