#!/bin/bash

set -e

# Modify the Grafeas protos to refer to grafeas.io/Project instead of
# cloudresourcemanager.googleapis.com/Project, and introduce a
# resource definition for the Project resource.
# This is a temporary measure until the protos are fixed in GitHub.

sed -i \
  s/cloudresourcemanager.googleapis.com/grafeas.io/g \
  ../../googleapis/grafeas/v1/*.proto

# Add the Project resource to common proto
sed -i '19 i import "google/api/resource.proto";' \
  ../../googleapis/grafeas/v1/common.proto

cat >> ../../googleapis/grafeas/v1/common.proto << END_OF_ADDITION
// Project resource. TODO: More docs.
option (google.api.resource_definition) = {
  type: "grafeas.io/Project"
  pattern: "projects/{project}"
};
END_OF_ADDITION
