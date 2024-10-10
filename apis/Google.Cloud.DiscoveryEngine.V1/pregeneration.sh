#!/bin/sh

# Ensure we use a consistent Location resource throughout the API.
# (It's unfortunate that it's a non-standard one, but we need that
# for compatibility at this point.)

sed -i 's/"locations.googleapis.com\/Location"/"discoveryengine.googleapis.com\/Location"'/g \
  $GOOGLEAPIS/google/cloud/discoveryengine/v1/*.proto
