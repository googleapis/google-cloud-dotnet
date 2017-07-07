#!/bin/bash

# Assumption: everything has been built already.

set -e

CONTINUE_ARG=

for arg in "$@"
do
  case $arg in
  --continue)
    CONTINUE_ARG=yes
    ;;
  --coverage)
    OPENCOVER=$PWD/packages/OpenCover.4.6.519/tools/OpenCover.Console.exe
    REPORTGENERATOR=$PWD/packages/ReportGenerator.2.4.5.0/tools/ReportGenerator.exe
    ;;
  *)
    echo "Unknown argument: $arg. Supported arguments: --coverage --continue"
    exit 1
    ;;
  esac
done


PROGRESS_FILE=`realpath integrationprogress.txt`
FIND=/usr/bin/find

[[ "$CONTINUE_ARG" == "yes" ]] || rm -f $PROGRESS_FILE
touch $PROGRESS_FILE

cd apis

# Only run them for Core, for simplicity.
for testdir in */*.IntegrationTests */*.Snippets
do
  if [[ "$testdir" =~ (Metadata|AspNet|Log4Net) ]]
  then
    echo "Skipping $testdir; test not supported yet."
  elif echo "$testdir" | grep --quiet -F -f $PROGRESS_FILE
  then
    echo "Skipping $testdir; test already run"
  elif [ -n "$OPENCOVER" ]
  then
    # TODO: When coverage is working again, use it. No point in
    # having a non-working version here yet...
    echo "Coverage not yet supported in .NET Core SDK 1.0.0...."
    exit 1
  else
    dotnet test -c Release --no-build -f netcoreapp1.0 $DOTNET_TEST_ARGS $testdir/*.csproj
    echo "$testdir" >> $PROGRESS_FILE
  fi
done

if [ -n "$OPENCOVER" -a -n "REPORTGENERATOR" ]
then
  $REPORTGENERATOR \
    -reports:../coverage/coverage.xml \
    -targetdir:../coverage \
    -verbosity:Error
fi
