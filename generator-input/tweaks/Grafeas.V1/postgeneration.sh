#!/bin/bash

set -e

# TODO: Remove this when we move the generator code
cd ../../../apis/Grafeas.V1

dotnet run --project Grafeas.V1.FixGeneratedCode
