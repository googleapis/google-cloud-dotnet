#!/bin/bash

# Update the proto with LROs, after the gRPC layer has been generated.
dotnet run -p Google.Cloud.Compute.V1.ModifyProto \
   $GOOGLEAPIS_DISCOVERY/google/cloud/compute/v1/compute.proto
