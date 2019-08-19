#!/bin/bash

set -e

# Undo the change made in pregeneration.sh
git -C ../../googleapis checkout google/cloud/kms/v1/cloudkms_gapic.yaml
