#!/bin/bash

# Assumption: everything has been built already.

set -e
source toolversions.sh

# Enable testing for Storage.V2
export STORAGE_V2_IS_NOT_FOR_PRODUCTION_USE_IN_DOTNET=true

SCRIPT=$(readlink -f "$0")
ROOT_DIR=$(dirname "$SCRIPT")

APIS=()
RETRY_ARG=
SMOKE_ARG=
EXCLUDED_APIS=()
DRY_RUN_ARG=
RELEASEMANAGER_ARGS=

while (( "$#" )); do
  if [[ "$1" == "--retry" ]]
  then 
    RETRY_ARG=yes
  elif [[ "$1" == "--smoke" ]]
  then
    SMOKE_ARG=yes
  elif [[ "$1" == "--dry-run" ]]
  then
    DRY_RUN_ARG=yes
  elif [[ "$1" == "--no-build-releasemanager" ]]
  then
    RELEASEMANAGER_ARGS="--no-build --no-restore"
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
  declare -r testdirs=$(echo */smoketests.json)
else
  declare -r testdirs=$(echo */*.IntegrationTests */*.Snippets */smoketests.json)
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
    dotnet run $RELEASEMANAGER_ARGS --project ../tools/Google.Cloud.Tools.ReleaseManager -- \
      smoke-test $(dirname $testdir) \
      || echo "$testdir" >> $FAILURE_TEMP_FILE
  else
    if compgen -G "$testdir/*.cs" | grep -v '\.g\.cs' > /dev/null
    then
      (cd $testdir; dotnet test -nologo -c Release || echo "$testdir" >> $FAILURE_TEMP_FILE)
    else
      echo "Skipping $testdir; only generated code"
    fi
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
