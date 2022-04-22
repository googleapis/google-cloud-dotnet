#!/bin/bash

# Assumption: everything has been built already, and if you're asking for
# coverage, you've already installed the relevant package.

set -e
source toolversions.sh

SCRIPT=$(readlink -f "$0")
ROOT_DIR=$(dirname "$SCRIPT")

APIS=()
RETRY_ARG=
COVERAGE_ARG=
SMOKE_ARG=
EXCLUDED_APIS=()
DRY_RUN_ARG=

while (( "$#" )); do
  if [[ "$1" == "--retry" ]]
  then 
    RETRY_ARG=yes
  elif [[ "$1" == "--coverage" ]]
  then
    install_dotcover
    mkdir -p coverage
    COVERAGE_ARG=yes
  elif [[ "$1" == "--smoke" ]]
  then
    SMOKE_ARG=yes
  elif [[ "$1" == "--dry-run" ]]
  then
    DRY_RUN_ARG=yes
  elif [[ "$1" == "--exclude" ]]
  then
    shift
    if [[ "$#" == 0 ]]
    then
      echo "Error: specify the file containing excluded API names"
      exit 1
    fi
    for exclusion in $(cat $1 | sed 's/\r//g')
    do
      EXCLUDED_APIS+=($exclusion)
    done
  else 
    APIS+=($1)
  fi
  shift
done

if [[ ${#APIS[@]} != 0 && "$RETRY_ARG" == "yes" ]]
then
  echo "The --retry flag cannot be used when specifying projects to test."
  exit 1
fi

# We only overwrite integration-test-failures.txt at the very end,
# so that if we abort tests early, we don't assume there's nothing to retry.
FAILURE_FILE=$ROOT_DIR/integration-test-failures.txt
FAILURE_TEMP_FILE=${FAILURE_FILE}.tmp

rm -f $FAILURE_TEMP_FILE
touch $FAILURE_TEMP_FILE

cd apis

# There are three separate ways of determining the tests to run:
# - If APIs have been specified on the command line, test those
# - If --retry has been specified, run the previously-failed tests
# - Otherwise, fine all potential tests
if [[ ${#APIS[@]} != 0 ]]
then
  temp_testdirs=()
  for api in ${APIS[*]}
  do
    int_dir="${api}/${api}.IntegrationTests"
    if [[ -d "$int_dir" && "$SMOKE_ARG" != "yes" ]]
    then
      temp_testdirs+=($int_dir)
    fi
    
    snip_dir="${api}/${api}.Snippets"
    if [[ -d "$snip_dir" && "$SMOKE_ARG" != "yes" ]]
    then
      temp_testdirs+=($snip_dir)
    fi 

    smoke_dir="${api}/${api}.SmokeTests"
    if [[ -d "$smoke_dir" ]]
    then
      temp_testdirs+=($smoke_dir)
    fi
    smoke_file="${api}/smoketests.json"
    if [[ -f "$smoke_file" ]]
    then
      temp_testdirs+=($smoke_file)
    fi 
  done
  declare -r testdirs=${temp_testdirs[*]}
elif [[ "$RETRY_ARG" == "yes" && (-f "$FAILURE_FILE")]]
then
  declare -r testdirs=$(cat $FAILURE_FILE)
elif [[ "$SMOKE_ARG" == "yes" ]]
then
  declare -r testdirs=$(echo */*.SmokeTests */smoketests.json)
else
  declare -r testdirs=$(echo */*.IntegrationTests */*.Snippets */*.SmokeTests */smoketests.json)
fi

log_build_action "(Start) Integration tests"
for testdir in $testdirs
do
  # Skip excluded APIs
  api=$(echo $testdir | cut -d/ -f1)
  for exclusion in ${EXCLUDED_APIS[*]}
  do
    if [[ $api == $exclusion ]]
    then
      log_build_action "Skipping $testdir for excluded API $api"
      continue 2
    fi
  done

  # If we just want to see what we would test, log it and continue
  if [[ "$DRY_RUN_ARG" == "yes" ]]
  then
    log_build_action "Dry-run; would test $testdir"
    continue
  fi
  
  log_build_action "Testing $testdir"
  
  if [[ "$testdir" =~ smoketests.json ]]
  then
    # If we've found a smoketests.json file (which really isn't a "test directory" of course),
    # run it via ReleaseManager
    echo "Running $testdir"
    dotnet run --project ../tools/Google.Cloud.Tools.ReleaseManager -- \
      smoke-test $(dirname $testdir) \
      || echo "$testdir" >> $FAILURE_TEMP_FILE
  elif [[ "$testdir" =~ SmokeTests ]]
  then
    # Smoke tests aren't unit tests - we just run them as console apps,
    # passing in the project ID
    echo "Running $testdir"
    dotnet run --project $testdir -- $TEST_PROJECT || echo "$testdir" >> $FAILURE_TEMP_FILE
  elif [[ "$COVERAGE_ARG" == "yes" && -f "$testdir/coverage.xml" ]]
  then
    (cd $testdir; $DOTCOVER cover "coverage.xml" -ReturnTargetExitCode || echo "$testdir" >> $FAILURE_TEMP_FILE)
  else
    (cd $testdir; dotnet test -nologo -c Release --no-build || echo "$testdir" >> $FAILURE_TEMP_FILE)
  fi
done
log_build_action "(End) Integration tests"

mv -f $FAILURE_TEMP_FILE $FAILURE_FILE

# Print status of this run including any failed tests.
declare -r failed=$(cat $FAILURE_FILE | wc -l)
if [ $failed == '0' ] 
then
  echo "All tests passed!"
else 
  echo "Number of Failed Tests: $failed"
  cat $FAILURE_FILE
  exit 1
fi
