#!/bin/bash

# Temporary fix for broken namespaces. This is being fixed internally.
sed -i 's/Google\.Cloud\.Retail\.V2beta/Google.Cloud.Retail.V2Beta/g' $GOOGLEAPIS/google/cloud/retail/v2beta/*.proto

# Fix resource names for location - we should use the common Location resource
sed -i 's/retail\.googleapis\.com\/Location/locations\.googleapis.com\/Location/g' $GOOGLEAPIS/google/cloud/retail/v2beta/*.proto
sed -i '31,34d' $GOOGLEAPIS/google/cloud/retail/v2beta/catalog.proto