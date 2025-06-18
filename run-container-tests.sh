#!/bin/bash

# Note: we could alternatively include this in runintegrationtests.sh

dotnet test tools/Google.Cloud.Tools.ReleaseManager.Tests
dotnet test tools/Google.Cloud.Tools.ReleaseManager.IntegrationTests
