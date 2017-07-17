#!/bin/bash

set -e

cd $(dirname $0)

# Disable automatic test reporting to AppVeyor.
# See https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1232
unset APPVEYOR_API_URL

# Make it easier to handle globbing that doesn't
# match anything, e.g. when looking for tests.
shopt -s nullglob

echo "$(date +%T) Build started"

# First build the analyzers, for use in everything else.
dotnet restore tools/Google.Cloud.Tools.Analyzers/Google.Cloud.Tools.Analyzers.csproj
dotnet publish -c Release -f netstandard1.3 tools/Google.Cloud.Tools.Analyzers/Google.Cloud.Tools.Analyzers.csproj

# Command line arguments are the APIs to build. Each argument
# should be the name of a directory, either relative to the location
# of this script, or under apis.
apis=$@
if [ -z "$apis" ]
then
  apis="tools $(echo apis/Google.* | sed 's/apis\///g')"
fi

# First build up a solution file with all the projects, and a text
# file with paths to all the test project files.
> AllTests.txt
dotnet new sln --name AllProjects

if [[ "$OS" == "Windows_NT" ]]
then
  # On Windows, we can just add all the projects, unconditionally.
  # (And it's faster to add them all in one call to dotnet sln than
  # to do them one at a time.)
  for api in $apis
  do 
    [[ -d "$api" ]] && apidir=$api || apidir=apis/$api
    dotnet sln AllProjects.sln add $apidir/*/*.csproj

    for testproject in $apidir/*.Tests/*.csproj
    do
      echo "$testproject" >> AllTests.txt
    done
  done
else
  # On Linux, we don't have desktop .NET, so any projects which only
  # support desktop .NET are going to be broken. Just don't add them.
  for api in $apis
  do 
    [[ -d "$api" ]] && apidir=$api || apidir=apis/$api
    for project in $apidir/*/*.csproj
    do
      if ! grep -q -E '>net[0-9]+<' $project
      then
        dotnet sln AllProjects.sln add $project
      fi
    done
  
    for testproject in $apidir/*.Tests/*.csproj
    do
      if ! grep -q -E '>net[0-9]+<' $testproject
      then
        echo "$testproject" >> AllTests.txt
      fi
    done
  done
fi

# Restore, build, test.
echo "$(date +%T) Restoring solution"
dotnet restore AllProjects.sln
echo "$(date +%T) Building solution"
dotnet build -c Release AllProjects.sln

# Could use xargs, but this is more flexible
while read testproject
do  
  echo "$(date +%T) Testing $testproject"
  dotnet test -c Release $testproject
done < AllTests.txt
