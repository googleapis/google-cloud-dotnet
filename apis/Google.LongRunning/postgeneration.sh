#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh and pregeneration.patch
git -C ../../googleapis checkout google/longrunning/longrunning_gapic.yaml
