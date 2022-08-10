#!/bin/bash

set -e

# Delete the resource definition for the documentai.googleapis.com/Location type.
# It has the same pattern as the common location type, so we want to use that instead.

proto_files=$(dir $GOOGLEAPIS/google/cloud/documentai/v1beta3/*.proto)

for proto_file in $proto_files
do
  index=$(grep -n -h -- 'type: "documentai.googleapis.com\/Location"' $proto_file | sed 's/:.*//')
  if [[ $index != "" ]]
  then
    start="$(($index-1))"
    end="$(($index+2))"
    sed -i ""$start","$end"d" $proto_file
  fi
done
