#!/bin/bash

set -e

# Undo the changes in googleapis
git -C $GOOGLEAPIS checkout google/cloud/recommendationengine/v1beta1/recommendationengine_resources.proto
