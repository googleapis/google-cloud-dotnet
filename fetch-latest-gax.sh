#!/bin/bash

echo "Fetching and building GAX"

git clone -q https://github.com/googleapis/gax-dotnet.git
(cd gax-dotnet && dotnet pack -v quiet -c Release -o $PWD/nuget Gax.sln)
