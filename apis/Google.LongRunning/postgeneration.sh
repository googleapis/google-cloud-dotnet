#!/bin/bash

set -e

# Undo the change made in pregeneration.sh
git -C ../../googleapis checkout google/longrunning/longrunning_gapic.yaml
