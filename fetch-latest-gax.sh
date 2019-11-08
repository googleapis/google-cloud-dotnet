#!/bin/bash

echo "Fetching and building GAX"

git clone -q https://github.com/googleapis/gax-dotnet.git
dotnet pack -v quiet -c Release -o $PWD/gax-dotnet/nuget gax-dotnet/Gax.sln
