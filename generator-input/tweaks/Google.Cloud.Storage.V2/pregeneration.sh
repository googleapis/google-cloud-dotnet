#!/bin/bash

set -e

# Add the csharp_namespace option somewhere (anywhere) before the first protobuf element.
# Eventually this will addressed in the googleapis repo.
sed -i '20 i option csharp_namespace = "Google.Cloud.Storage.V2";' $GOOGLEAPIS/google/storage/v2/*.proto
