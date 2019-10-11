#!/bin/bash

set -e

# Undo the change made in pregeneration.sh
git -C ../../googleapis checkout google/monitoring/v3/dropped_labels.proto
