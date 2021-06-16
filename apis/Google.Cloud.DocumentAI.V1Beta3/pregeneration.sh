#!/bin/bash

set -e

# Delete the resource definition for the documentai.googleapis.com/Location type.
# It has the same pattern as the common location type, so we want to use that instead.
# Note that takes advantage of the fact that there's another resource definition
# immediately after it - so it removes the first line of *that* resource definition,
# but leaves the first line of the location definition, because sed doesn't backtrack.
sed -i '/ type: "documentai.googleapis.com\/Location"/I,+3 d' $GOOGLEAPIS/google/cloud/documentai/v1beta3/*.proto
