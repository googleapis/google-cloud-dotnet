#!/bin/bash

# Assumption: everything has been built already, and if you're asking for
# coverage, you've already installed the relevant package.

set -e
source toolversions.sh

RETRY_ARG=
COVERAGE_ARG=

for arg in "$@"
do
  case $arg in
  --retry)
    RETRY_ARG=yes
    ;;
  --coverage)
    install_dotcover
    COVERAGE_ARG=yes
    ;;
  *)
    echo "Unknown argument: $arg. Supported arguments: --coverage --retry"
    exit 1
    ;;
  esac
done

# We only overwrite integration-test-failures.txt at the very end,
# so that if we abort tests early, we don't assume there's nothing to retry.
FAILURE_FILE=$(realpath integration-test-failures.txt)
FAILURE_TEMP_FILE=${FAILURE_FILE}.tmp

rm -f $FAILURE_TEMP_FILE
touch $FAILURE_TEMP_FILE

cd apis

if [[ "$RETRY_ARG" == "yes" ]]
then
  declare -r testdirs=$(cat $FAILURE_FILE)
else
  declare -r testdirs=$(echo */*.IntegrationTests */*.Snippets)
fi

for testdir in $testdirs
do
  if [[ "$testdir" =~ Metadata ]]
  then
    echo "Skipping $testdir; test not supported yet."
  elif [[ "$COVERAGE_ARG" == "yes" && -f "$testdir/coverage.xml" ]]
  then
    (cd $testdir; $DOTCOVER cover "coverage.xml" /ReturnTargetExitCode || echo "$testdir" >> $FAILURE_TEMP_FILE)
  else
    # For a non-coverage run, just run dotnet with the same arugments that we would have run
    # for coverage.
    (cd $testdir;
     dotnetargs=$(grep TargetArguments coverage.xml | sed -E 's/<\/?TargetArguments>//g');
     dotnet $dotnetargs || echo "$testdir" >> $FAILURE_TEMP_FILE)
  fi
done

mv -f $FAILURE_TEMP_FILE $FAILURE_FILE