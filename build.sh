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

# Command line arguments are the APIs to build. Each argument
# should be the name of a directory, either relative to the location
# of this script, or under apis.
# Additional arguments:
# --notests: Just build, don't run the tests
# --diff: Detect which APIs to build based on a diff to the master branch
# --regex regex: Only build APIs that match the given regex
# --nobuild: Just list which APIs would be built; don't run the build
# --coverage: Run tests with coverage enabled
apis=()
runtests=true
runcoverage=false
apiregex=
nobuild=false
while (( "$#" )); do
  if [[ "$1" == "--notests" ]]
  then 
    echo "Not running tests..."
    runtests=false
  elif [[ "$1" == "--diff" ]]
  then
    apis+=($(git diff master --name-only | grep apis/Google | cut -d/ -f 2 | uniq))
  elif [[ "$1" == "--regex" ]]
  then
    shift
    apiregex=$1
  elif [[ "$1" == "--nobuild" ]]
  then
    nobuild=true
  elif [[ "$1" == "--coverage" ]]
  then
    runcoverage=true
    mkdir -p coverage
  else
    apis+=($1)
  fi
  shift
done

# Build and test the tools, but only on Windows
[[ "$OS" == "Windows_NT" ]] && tools="tools" || tools=""

# If no APIs were specified explicitly, build all of them (and tools on Windows)
if [[ ${#apis[@]} -eq 0 ]]
then
  apis=(${tools} $(echo apis/Google.* | sed 's/apis\///g'))
fi

# If we were given an API filter regex, apply it now.
if [[ "$apiregex" != "" ]]
then
  filteredapis=()
  for api in ${apis[*]}
  do
    if [[ "$api" =~ $apiregex ]]
    then
      filteredapis+=($api)
    fi
  done
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

# First build the analyzers, for use in everything else.
log_build_action "(Start) build.sh"
log_build_action "Building analyzers"

dotnet publish -c Release -f netstandard1.3 tools/Google.Cloud.Tools.Analyzers

# Then build the requested APIs, working out the test projects as we go.
> AllTests.txt
for api in ${apis[*]}
do
  [[ -d "$api" ]] && apidir=$api || apidir=apis/$api

  # Only build ASP.NET support on Windows
  if [[ "$OS" != "Windows_NT" ]] && [[ "$apidir" == "apis/Google.Cloud.Diagnostics.AspNet" ]]
  then
    continue
  fi

  log_build_action "Building $apidir"
  dotnet build -c Release $apidir

  # On Linux, we don't have desktop .NET, so any projects which only
  # support desktop .NET are going to be broken. Just don't add them.
  for testproject in $apidir/*.Tests/*.csproj
  do
    if [[ "$OS" == "Windows_NT" ]] || ! grep -q -E '>net[0-9]+<' $testproject
    then
      echo "$testproject" >> AllTests.txt
    fi
  done
done

log_build_action "(Start) Unit tests"
if [[ "$runtests" = true ]]
then
  # Could use xargs, but this is more flexible
  while read testproject
  do  
    testdir=$(dirname $testproject)
    log_build_action "Testing $testdir"
    if [[ "$runcoverage" = true && -f "$testdir/coverage.xml" ]]
    then
      echo "(Running with coverage)"
      (cd "$testdir"; dotnet dotcover test -c Release --no-build --dcXML=coverage.xml)    
    else
      dotnet test -c Release --no-build $testproject
    fi
  done < AllTests.txt
fi

log_build_action "(End) Unit tests"
log_build_action "(End) build.sh"
