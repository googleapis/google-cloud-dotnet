#!/bin/bash

set -e

if [ "$TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE" == "" ]
then
  export TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE="test-dotnet-image:$(date -u +%Y%m%dt%H%M%S)z"
  echo "Building Docker image $TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE"
  docker build -q -t $TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE -f Dockerfile.generator .
else
  echo "Using existing image $TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE"
fi

dotnet test tools/Google.Cloud.Tools.ReleaseManager.Tests
dotnet test tools/Google.Cloud.Tools.ReleaseManager.IntegrationTests
