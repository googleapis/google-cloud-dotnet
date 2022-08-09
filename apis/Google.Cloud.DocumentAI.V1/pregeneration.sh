#!/bin/bash

set -e

# Delete the resource definition for the documentai.googleapis.com/Location type.
# It has the same pattern as the common location type, so we want to use that instead.
sed -i -z '/option (google.api.resource_definition) = {\n type: "documentai.googleapis.com\/Location"/I,+2 d' $GOOGLEAPIS/google/cloud/documentai/v1/*.proto
