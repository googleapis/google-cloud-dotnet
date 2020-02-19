#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh and pregeneration.patch
git -C $GOOGLEAPIS checkout google/cloud/automl
