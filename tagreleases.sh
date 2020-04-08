#!/bin/bash

set -e 

dotnet run -p tools/Google.Cloud.Tools.TagReleases -- $*
