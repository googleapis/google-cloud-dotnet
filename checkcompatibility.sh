#!/bin/bash

set -e

if [[ -z "$1" || -z "$2" ]]
then
  echo Please specify old and new branches
  exit 1
fi

build_and_copy() {
  declare -r BRANCH=$1
  declare -r TARGET_DIR=$2
  rm -rf $TARGET_DIR
  mkdir -p $TARGET_DIR
  
  git checkout $BRANCH
  ./build.sh --notests

  for dir in apis/Google.*
  do 
    pkg=$(basename $dir)
    dll=apis/$pkg/$pkg/bin/Release/netstandard2.0/$pkg.dll
    if [[ -f $dll ]]
    then
      cp $dll $TARGET_DIR
    fi
  done  
}

# Build both branches and save the results
build_and_copy $1 tmp/old_dlls
build_and_copy $2 tmp/new_dlls

# Now run the compatibility checker
> tmp/compatibility.txt

for old_dll in tmp/old_dlls/*.dll
do
  base_dll=$(basename $old_dll)
  new_dll=tmp/new_dlls/$base_dll
  if [[ -f $new_dll ]]
  then
    echo "Comparing $base_dll"
    dotnet run --project tools/Google.Cloud.Tools.CompareVersions -- --file1=$old_dll --file2=$new_dll >> tmp/compatibility.txt
  else
    echo "$base_dll only exists in $OLD_DIR, not $NEW_DIR"
  fi
done
