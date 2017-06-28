#!/bin/bash

set -e 

if [ -z "$1" ]
then
  echo Please specify a github access token
  exit 1
fi

dotnet restore tools > /dev/null
dotnet run -p tools/Google.Cloud.Tools.TagReleases/Google.Cloud.Tools.TagReleases.csproj $1
