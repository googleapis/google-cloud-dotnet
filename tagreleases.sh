#!/bin/bash

set -e 

if [ -z "$1" ]
then
  echo Please specify a github access token
  exit 1
fi

dotnet run -p tools/Google.Cloud.Tools.TagReleases -- $1
