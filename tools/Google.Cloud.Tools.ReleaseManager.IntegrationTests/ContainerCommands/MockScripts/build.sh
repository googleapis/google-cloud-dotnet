#!/bin/bash

set -e

echo "build-start" >> build.sh.result.txt

while (( "$#" )); do
  echo "$1" >> build.sh.result.txt
  shift
done

echo "build-end" >> build.sh.result.txt
