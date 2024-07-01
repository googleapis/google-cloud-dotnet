#!/bin/bash

set -e
source ../toolversions.sh

dotnet tool restore > /dev/null

# Some versions of docfx fail if VSINSTALLDIR is set.
export VSINSTALLDIR=

# We don't need deterministic source paths in the docfx metadata build,
# and they don't seem to work out of the box with the rest of our build
# setup, so let's just disable them (with both of the environment variables
# that might have caused them to be turned on).
export ContinuousIntegrationBuild=false
export DeterministicSourcePaths=false

build_api_docs() {
  log_build_action "Building docs for $1"
  local api=$1

  if [[ ! -d "../apis/$api/docs" ]]
  then
    if [[ -d "../apis/$api" ]]
    then
      echo "No docs directory for $api; ignoring"
      return 0
    else
      echo "$api does not exist; aborting"
      return 1
    fi
  else
    dotnet run --no-build --no-restore --project ../tools/Google.Cloud.Tools.GenerateDocfxSources -- $api
  fi
  cp filterConfig.yml output/$api
  
  dotnet docfx metadata --logLevel Warning output/$api/docfx.json | tee errors.txt | grep -v "Invalid file link"
  (! grep --quiet 'Build failed.' errors.txt)
  # Remove references generated from SourceLink
  sed -E -i '/^\s+href: https:\/\/github.com\//d' output/$api/obj/api/*.yml

  # Build metadata for devsite
  dotnet docfx metadata --logLevel Warning output/$api/docfx-devsite.json | tee errors.txt | grep -v "Invalid file link"
  (! grep --quiet 'Build failed.' errors.txt)
  # Remove references generated from SourceLink
  sed -E -i '/^\s+href: https:\/\/github.com\//d' output/$api/obj/bareapi/*.yml

  # Generate the snippet markdown
  dotnet run --no-build --no-restore --project ../tools/Google.Cloud.Tools.GenerateSnippetMarkdown -- $api
  
  # Build for googleapis.dev
  # Note that the devsite build will happen elsewhere.
  dotnet docfx build --logLevel Warning --disableGitFeatures output/$api/docfx.json | tee errors.txt | grep -v "Invalid file link"
  (! grep --quiet 'Build failed.' errors.txt)
  
  # We need to make some changes to meet DevSite build expectations.
  dotnet run --no-build --no-restore --project ../tools/Google.Cloud.Tools.PostProcessDevSite -- $api
  
  echo Finished building docs for $api
}

rm -rf output
mkdir output

# Build the tools once, then we can run them without restoring/building each time
dotnet build Google.Cloud.DocTools.sln -v quiet -nologo -clp:NoSummary

apis=$@
if [ -z "$apis" ]
then
  # Build all APIs, which means every ../apis subdirectory with a "docs" subdirectory.
  apis="`/usr/bin/find ../apis -mindepth 2 -maxdepth 2 -name docs -type d | cut -d/ -f3`"
fi

log_build_action "(Start) Building docs"
for api in $apis
do 
  build_api_docs $api
done
log_build_action "(End) Building docs"
