#!/bin/bash

# Temporary fix for broken namespaces. This is being fixed internally.
sed -i 's/Google\.Cloud\.Retail\.V2beta/Google.Cloud.Retail.V2Beta/g' $GOOGLEAPIS/google/cloud/retail/v2beta/*.proto
