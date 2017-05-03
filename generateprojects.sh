#!/bin/bash

dotnet restore tools
dotnet run -p tools/Google.Cloud.Tools.ProjectGenerator/Google.Cloud.Tools.ProjectGenerator.csproj
