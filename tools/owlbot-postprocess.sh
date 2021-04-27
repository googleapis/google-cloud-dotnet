#!/bin/bash

set -e

# Note: we could do various parts of this globally from the top level,
# but doing it on a per-API level means we don't need to worry about
# overly long command lines etc

cd owlbot-staging
for api in *
do
  echo "Processing $api"  
  # Remove existing generated code from target directory
  rm -rf ../apis/*/*.g.cs
  
  # Rename any plain .cs files to .g.cs in staging directory
  for file in $(find $api -name *.cs | grep -v '\.g\.cs')
  do
    mv $file $(echo $file | sed -E 's/.cs$/.g.cs/g')    
  done
  
  # Remove standalone snippets (for now) from staging directory
  rm -rf $api/$api.StandaloneSnippets
  
  # Remove all C# project files
  rm -f $(find $api -name *.csproj)

  # Copy the files from staging to target
  cp -r $api ../apis
done
cd ..
