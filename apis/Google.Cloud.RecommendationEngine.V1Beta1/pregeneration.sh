#!/bin/bash

set -e

# Add a csharp_namespace option to the resources proto. All other
# protos have the option already. We should be able to remove this
# change when the upstream proto has been fixed.
sed -i '21 i option csharp_namespace = "Google.Cloud.RecommendationEngine.V1Beta1";' \
    $GOOGLEAPIS/google/cloud/recommendationengine/v1beta1/recommendationengine_resources.proto
