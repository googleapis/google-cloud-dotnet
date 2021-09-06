#!/bin/bash

set -e

# Insert an extra import into assets.proto to resolve a resource name.
# It doesn't matter much where this goes; line 19 is the start of the
# import block.
sed -i '19 i import \"google/cloud/osconfig/v1/osconfig_service.proto\";' \
  $GOOGLEAPIS/google/cloud/asset/v1/assets.proto
