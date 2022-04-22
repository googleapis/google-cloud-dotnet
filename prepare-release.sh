#!/bin/bash

set -e

dotnet run --project tools/Google.Cloud.Tools.ReleaseManager -- "$@"
