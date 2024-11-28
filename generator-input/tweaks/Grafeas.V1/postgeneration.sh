#!/bin/bash

set -e

# TODO: Use the specified output directory
dotnet run --project Grafeas.V1.FixGeneratedCode ../../../apis/Grafeas.V1
