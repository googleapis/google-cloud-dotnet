#!/bin/bash

set -e

if [[ -d "owl-bot-staging" ]]
then
  echo "OwlBot post-processor has not run: failing diff."
  exit 1
fi

ALLOW_BREAKING_CHANGES=
if [[ $1 == "--allow-breaking-changes" ]]
then
  ALLOW_BREAKING_CHANGES=true
  echo "(Breaking changes allowed during diff)"
fi


# Writes the argument to the console in bold magenta, to make it stand out.
log_header() {
  echo -e "\e[1;35m$1\e[0m"
}

# Fails the whole script (exit code 1) if and only if ALLOW_BREAKING_CHANGES isn't true
maybe_fail() {
  if [[ $ALLOW_BREAKING_CHANGES != "true" ]]
  then
    exit 1
  else
    echo -e "\e[1;31mWarning: breaking change detected, but the error has been suppressed by options.\e[0m"
  fi
}

# Find the APIs that have changed
apis=$(git diff main --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq)

if [[ "$apis" == "" ]]
then
  log_header "No APIs have changed in this PR. Exiting diff."
  exit 0
fi

git clone . tmpgit --no-local -q -b main --depth 1 --recursive

# Make sure all the tags are available for checking compatibility
git fetch --tags -q

# ReleaseManager does all the rest
dotnet run --project tools/Google.Cloud.Tools.ReleaseManager detect-pr-changes tmpgit $apis || maybe_fail
