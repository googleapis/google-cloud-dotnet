#!/bin/bash

set -e

echo "integration-tests-start" >> runintegrationtests.sh.result.txt

while (( "$#" )); do
  echo "$1" >> runintegrationtests.sh.result.txt
  # We always fail retries to test that we retry the right amount of attempts.
  if [[ "$1" == "Google.Fail.V1" || "$1" == "--retry" ]];
  then
    exit 1
  fi
  shift
done

echo "integration-tests-end" >> runintegrationtests.sh.result.txt
