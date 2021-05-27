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
diff=false
while (( "$#" )); do
  if [[ "$1" == "--notests" ]]
  then 
    runtests=false
  elif [[ "$1" == "--diff" ]]
  then
    apis+=($(git diff master --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq))
    diff=true
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
    install_dotcover
    mkdir -p coverage
  else
    apis+=($1)
  fi
  shift
done

# Build and test the tools, but only on Windows
[[ "$OS" == "Windows_NT" ]] && tools="tools" || tools=""

# If no APIs were specified explicitly, build all of them (and tools on Windows)
if [[ ${#apis[@]} -eq 0 && $diff == false ]]
then
  apis=(${tools} $($PYTHON3 tools/listapis.py apis/apis.json))
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
    apiregex=$(echo $apiregex | sed s/^!//g)
    for api in ${apis[*]}
    do
      if [[ ! "$api" =~ $apiregex ]]
      then
        if [[ -d "apis/$api" ]]
        then
          filteredapis+=($api)
        else
          echo "Skipping missing API $api; recently deleted?"
        fi
      fi
    done
  else
    for api in ${apis[*]}
    do    
      if [[ "$api" =~ $apiregex ]]
      then
        if [[ -d "apis/$api" ]]
        then
          filteredapis+=($api)
        else
          echo "Skipping missing API $api; recently deleted?"
        fi
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

# If we are building Google.Cloud.Diagnostics.AspNetCore we also need to build
# Google.Cloud.Diagnostics.AspNetCore3 since they share code files.
hasCore=false
hasCore3=false
for api in ${apis[*]}
do
  if [[ "$api" == "Google.Cloud.Diagnostics.AspNetCore" ]]
  then
    hasCore=true
  elif [[ "$api" == "Google.Cloud.Diagnostics.AspNetCore3" ]]
  then
    hasCore3=true
  fi
done
if [[ "$hasCore" == "true" ]] && [[ "$hasCore3" == "false" ]]
then
  apis+=("Google.Cloud.Diagnostics.AspNetCore3")
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

dotnet publish -nologo -clp:NoSummary -v quiet -c Release -f netstandard1.3 tools/Google.Cloud.Tools.Analyzers

# Then build the requested APIs, working out the test projects as we go.
> AllTests.txt
for api in ${apis[*]}
do
  [[ -d "$api" ]] && apidir=$api || apidir=apis/$api

  # ServiceDirectory is in apis/ for the sake of autosynth, but doesn't really build.
  if [[ "$api" == "ServiceDirectory" ]]
  then
    continue
  fi

  log_build_action "Building $apidir"
  dotnet build -nologo -clp:NoSummary -v quiet -c Release $apidir

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

if [[ "$runtests" = true ]]
then
  log_build_action "(Start) Unit tests"
  # Could use xargs, but this is more flexible
  while read testproject
  do
    testdir=$(dirname $testproject)
    log_build_action "Testing $testdir"
    if [[ "$runcoverage" = true && -f "$testdir/coverage.xml" ]]
    then
      echo "(Running with coverage)"
      (cd "$testdir"; $DOTCOVER cover "coverage.xml" --ReturnTargetExitCode)
    else
      dotnet test -nologo -c Release --no-build $testproject
    fi
  done < AllTests.txt
  log_build_action "(End) Unit tests"
fi

log_build_action "(End) build.sh"
