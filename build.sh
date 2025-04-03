#!/bin/bash

set -e

cd $(dirname $0)

source toolversions.sh

# Disable automatic test reporting to AppVeyor.
# See https://github.com/googleapis/google-cloud-dotnet/issues/1232
unset APPVEYOR_API_URL

# Make it easier to handle globbing that doesn't
# match anything, e.g. when looking for tests.
shopt -s nullglob

# Enable testing for Storage.V2
export STORAGE_V2_IS_NOT_FOR_PRODUCTION_USE_IN_DOTNET=true

# Command line arguments are the APIs to build. Each argument
# should be the name of a directory, either relative to the location
# of this script, or under apis.
# Additional arguments:
# --notests: Just build, don't run the tests
# --diff: Detect which APIs to build based on a diff to the main branch
# --regex regex: Only build APIs that match the given regex
# --nobuild: Just list which APIs would be built; don't run the build
apis=()
runtests=true
apiregex=
nobuild=false
diff=false
while (( "$#" )); do
  if [[ "$1" == "--notests" ]]
  then 
    runtests=false
  elif [[ "$1" == "--diff" ]]
  then
    apis+=($(git diff main --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq))
    diff=true
  elif [[ "$1" == "--regex" ]]
  then
    shift
    apiregex=$1
  elif [[ "$1" == "--nobuild" ]]
  then
    nobuild=true
  else
    apis+=($1)
  fi
  shift
done

# If no APIs were specified explicitly, build all of them (and tools on Windows)
if [[ ${#apis[@]} -eq 0 && $diff == false ]]
then
  # Build and test the tools, but only on Windows
  [[ "$OS" == "Windows_NT" ]] && tools="tools" || tools=""

  # Build ReleaseManager first separately, so that we get any build messages
  # here rather than when we try to run it
  dotnet build tools/Google.Cloud.Tools.ReleaseManager
  apis=(${tools} $(dotnet run --no-build --no-restore --project tools/Google.Cloud.Tools.ReleaseManager -- query-api-catalog list))
fi

# If we were given an API filter regex, apply it now.
if [[ "$apiregex" != "" ]]
then
  filteredapis=()
  # This is a hack to allow ! to negate the regex.
  # Bash regular expressions don't allow for lookahead, so this is the
  # simplest way of doing it.
  if [[ $apiregex == !* ]]
  then
    apiregex=$(echo "$apiregex" | sed s/^!//g)
    for api in ${apis[*]}
    do
      if [[ ! "$api" =~ $apiregex ]]
      then
        filteredapis+=($api)
      fi
    done
  else
    for api in ${apis[*]}
    do    
      if [[ "$api" =~ $apiregex ]]
      then
        filteredapis+=($api)
      fi
    done
  fi
  unset apis
  apis=("${filteredapis[@]}")
  if [[ ${#apis[@]} -eq 0 ]]
  then
    echo "After regular expression filter, no projects left to build. Exiting."
    exit 0
  fi
fi

if [[ "$nobuild" == "true" ]]
then
  echo "APIs that would be built:"
  for api in ${apis[*]}
  do
    echo "$api"
  done
  exit 0
fi

log_build_action "(Start) build.sh"

log_build_action "(Start) Building"

# Then build the requested APIs, working out the test projects as we go.
> AllTests.txt
for api in ${apis[*]}
do
  [[ -d "$api" ]] && apidir=$api || apidir=apis/$api

  if [[ ! -d "$apidir" ]]
  then
    log_build_action "Skipping missing API $api; may be configured but not generated, or recently deleted"
    continue
  fi
  
  log_build_action "Building $apidir"
  dotnet build -nologo -clp:NoSummary -v quiet -c Release $apidir
  
  # The tools directory contains projects in the docs solution as well.
  # If we're not careful, we end up trying to run tests that haven't
  # been built.
  if [[ "$api" == "tools" ]]
  then
    dotnet build -nologo -clp:NoSummary -v quiet -c Release docs
  fi

  # On Linux, we don't have desktop .NET, so any projects which only
  # support desktop .NET are going to be broken. Just don't add them.
  for testproject in $apidir/*.Tests/*.csproj
  do
    if [[ "$OS" == "Windows_NT" ]] || ! grep -q -E '>net[0-9]+<' $testproject
    then
      echo "$testproject" >> AllTests.txt
    fi
  done
  
  # If we're not going to test the desktop .NET builds, let's remove them
  # entirely. This saves a huge amount of disk space, as the desktop framework
  # builds include copies of gRPC.
  if [[ ! "$OS" == "Windows_NT" ]]
  then
    rm -rf $apidir/*/bin/Release/net[0-9]*
  fi
done

log_build_action "(End) Building"

if [[ "$runtests" = true ]]
then
  log_build_action "(Start) Client creation tests"
  # TODO: allow a ReleaseManager binary to be passed in instead, if we've got one already.
  dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.ReleaseManager
  for api in ${apis[*]}
  do
    if [[ "$api" == "tools" ]]
    then
      continue
    fi
    dotnet run --no-build --project tools/Google.Cloud.Tools.ReleaseManager -- create-clients $api
  done
  log_build_action "(End) Client creation tests"

  log_build_action "(Start) Unit tests"
  # Could use xargs, but this is more flexible
  while read testproject
  do
    testdir=$(dirname $testproject)
    log_build_action "Testing $testdir"
    # Note that even though we should have built everything by now,
    # --no-build causes odd issues on GitHub CI.
    dotnet test -nologo -c Release $testproject
  done < AllTests.txt
  log_build_action "(End) Unit tests"
fi

log_build_action "(End) build.sh"
