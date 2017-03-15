#!/bin/bash

# Only push to coveralls when code is committed; secure variables
# aren't decoded in pull requests.
if [ -n "$COVERALLS_REPO_TOKEN" ]
then
  nuget install -OutputDirectory packages -Version 0.7.0 coveralls.net
  packages/coveralls.net.0.7.0/tools/csmacnz.Coveralls.exe --opencover -i coverage/coverage.xml --useRelativePaths
fi
