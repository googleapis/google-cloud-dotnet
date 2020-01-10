#!/bin/bash

set -e

dotnet run -p Grafeas.V1.FixGeneratedCode

# Undo the changes made in pregeneration.sh
git -C ../../googleapis checkout grafeas/v1
