#!/bin/bash

# Assumption: everything has been built already, and if you're asking for
# coverage, you've already installed the relevant package.

set -e
source toolversions.sh

CONTINUE_ARG=
COVERAGE_ARG=

for arg in "$@"
do
  case $arg in
  --continue)
    CONTINUE_ARG=yes
    ;;
  --coverage)
    install_dotcover
    COVERAGE_ARG=yes
    ;;
  *)
    echo "Unknown argument: $arg. Supported arguments: --coverage --continue"
    exit 1
    ;;
  esac
done

PROGRESS_FILE=`realpath integrationprogress.txt`

[[ "$CONTINUE_ARG" == "yes" ]] || rm -f $PROGRESS_FILE
touch $PROGRESS_FILE

cd apis

for testdir in */*.IntegrationTests */*.Snippets
do
  if [[ "$testdir" =~ Metadata ]]
  then
    echo "Skipping $testdir; test not supported yet."
  elif echo "$testdir" | grep --quiet -F -f $PROGRESS_FILE
  then
    echo "Skipping $testdir; test already run"
  elif [[ "$COVERAGE_ARG" == "yes" && -f "$testdir/coverage.xml" ]]
  then
    echo "Running coverage for $testdir"
    (cd $testdir; $DOTCOVER cover "coverage.xml" /ReturnTargetExitCode)
    echo "$testdir" >> $PROGRESS_FILE
  else
    # For a non-coverage run, just run dotnet with the same arugments that we would have run
    # for coverage.
    (cd $testdir;
     dotnetargs=$(grep TargetArguments coverage.xml | sed -E 's/<\/?TargetArguments>//g');
     dotnet $dotnetargs)
    
    echo "$testdir" >> $PROGRESS_FILE
  fi
done
