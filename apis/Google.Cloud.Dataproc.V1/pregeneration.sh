#!/bin/bash

set -e

# The patch file is relative to the root; it looks like patch files don't like to specify
# parent directories.
(cd ../..; git apply apis/Google.Cloud.Dataproc.V1/pregeneration.patch)
