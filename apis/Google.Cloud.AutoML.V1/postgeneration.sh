#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh and pregeneration.patch
git -C ../../googleapis checkout google/cloud/automl
