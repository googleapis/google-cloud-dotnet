#!/bin/bash

set -e

OLDPWD=$PWD

# The patch file is relative to googleapis; it looks like patch files don't like to specify
# parent directories.
(cd $GOOGLEAPIS; git apply $OLDPWD/pregeneration.patch)
