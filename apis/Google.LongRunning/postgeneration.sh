#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh
git -C ../../googleapis checkout google/longrunning
