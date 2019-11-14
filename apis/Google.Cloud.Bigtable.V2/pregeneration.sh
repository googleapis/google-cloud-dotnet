#!/bin/bash

set -e

# Use the legacy GAPIC config for now. Our retry situation is really
# complicated.

cp ../../googleapis/google/bigtable/v2/bigtable_gapic.legacy.yaml ../../googleapis/google/bigtable/v2/bigtable_gapic.yaml
