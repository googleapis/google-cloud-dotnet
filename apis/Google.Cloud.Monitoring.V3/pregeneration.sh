#!/bin/bash

set -e

# Remove the csharp_namespace option from dropped_labels.proto
# The option is correct, but wasn't present earlier. When we take
# a major version bump, we should:
# - Delete pregeneration.sh
# - Delete postgeneration.sh
# - Edit generateapis.sh to remove the leniency on Monitoring for bad namespaces
sed -i '/csharp_namespace/d' ../../googleapis/google/monitoring/v3/dropped_labels.proto
