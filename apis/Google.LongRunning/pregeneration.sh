#!/bin/bash

set -e

# The LongRunning API code is under the Apache licence for C#, but BSD for other languages.
sed -i \
  s/license-header-bsd-3-clause.txt/license-header-apache-2.0.txt/g \
  ../../googleapis/google/longrunning/longrunning_gapic.yaml

# The patch file is relative to the root; it looks like patch files don't like to specify
# parent directories.
(cd ../..; git apply apis/Google.LongRunning/pregeneration.patch)
