#!/bin/bash

set -e

# Rename resource types that would otherwise cause naming conflicts

sed -i 's/"datalabeling.googleapis.com\/Dataset"/"datalabeling.googleapis.com\/DataLabelingDataset"/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/"automl.googleapis.com\/Dataset"/"automl.googleapis.com\/AutoMLDataset"/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto
sed -i 's/"automl.googleapis.com\/Model"/"automl.googleapis.com\/AutoMLModel"/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/*.proto

# Temporary patch to add doc comments for DatasetService and EndpointService
sed -i 's/^service DatasetService/\/\/ Service for managing datasets.\nservice DatasetService/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/dataset_service.proto
sed -i 's/^service EndpointService/\/\/ Service for managing endpoints.\nservice EndpointService/g' $GOOGLEAPIS/google/cloud/aiplatform/v1/endpoint_service.proto
