#!/bin/bash

# Environment variables:
# - UTILITY_TYPE: a type accepted by docs/generate-devsite-utilities.sh
# - UTILITY_VERSION: the version of the utility to be fetched/built/documented

set -e

if [[ -z "$UTILITY_TYPE" || -z "$UTILITY_VERSION" ]]
then
  echo 'Both UTILITY_TYPE AND UTILITY_VERSION must be set'
  exit 1
fi

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

source $SCRIPT_DIR/populatesecrets.sh

# Only populate secrets if we have to.
# Else, we assume secrets have already been populated by the caller.
populatesecrets=true
if [[ "$#" -eq 1 ]] && [[ "$1" == "--skippopulatesecrets" ]]
then
    populatesecrets=false
    echo "Skipping populate secrets."
elif [[ "$#" -gt 0 ]]
then
    echo "Usage: $0 [--skippopulatesecrets]"
    exit 1
fi
if [[ "$populatesecrets" == "true" ]]
then
    populate_all_secrets
fi

PYTHON3=$(source toolversions.sh && echo $PYTHON3)

DOCS_CREDENTIALS="$SECRETS_LOCATION/docuploader_service_account"

cd docs
./generate-devsite-utilities.sh $UTILITY_TYPE $UTILITY_VERSION $DOCS_CREDENTIALS
