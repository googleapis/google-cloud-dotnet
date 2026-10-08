#!/bin/bash

set -e

# In CapacityHistoryRequest, the enum is named Types, which clashes with the
# protoc-generated C# nested Types class (error CS0542: member names cannot be the same as their enclosing type).
# Protoc C# code generator conventionally mangles colliding identifiers by appending a trailing
# underscore. We follow this protoc convention here and rename enum Types to Types_.
sed -i '/message CapacityHistoryRequest {/,/message CapacityHistoryRequestInstanceProperties/ s/  enum Types {/  enum Types_ {/' \
  $GOOGLEAPIS/google/cloud/compute/v1/compute.proto
