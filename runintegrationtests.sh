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

[[ "$CONTINUE_ARG" == "yes" ]] || rm $PROGRESS_FILE
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
    api=`echo $testdir | cut -d/ -f1`
    generatedFiles=`$FIND $api/$api -name '*.cs' | xargs grep -l "// Generated" | sed 's/.*\/.*\//*\\\\*\\\\/g' | tr '\n' ';'`
    $OPENCOVER \
        -target:"c:\Program Files\dotnet\dotnet.exe" \
        -targetargs:"test -c Release --no-build -f net451 $DOTNET_TEST_ARGS $testdir" \
        -mergeoutput \
        -hideskipped:File \
        -output:../coverage/coverage.xml \
        -oldStyle \
        -filter:"+[$api]*" \
        -searchdirs:$testdir/bin/$CONFIG/net451/win7-x64 \
        -register:user \
        -excludebyfile:$generatedFiles
  else
    dotnet test -c Release --no-build -f netcoreapp1.0 $DOTNET_TEST_ARGS $testdir -xml $testdir/results.xml
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
