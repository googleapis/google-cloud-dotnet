#!/bin/sh

# Rename the Schema message to OpenApiSchema to avoid a conflict with the
# namespace called Schema.
sed -i 's/^\( *\)Schema/\1OpenApiSchema/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/^message Schema/message OpenApiSchema/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/map<string, Schema>/map<string, OpenApiSchema>/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/ optional Schema / optional OpenApiSchema /g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/ repeated Schema / repeated OpenApiSchema /g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto

# Remove the pre-deprecated field in QueryDeployedModelsResponse
sed -i '/repeated DeployedModel deployed_models = 1 \[deprecated = true\]/d' \
  $GOOGLEAPIS/google/cloud/aiplatform/v1/deployment_resource_pool_service.proto
