#!/bin/bash

set -e

dotnet run --project Grafeas.V1.FixGeneratedCode $GENERATOR_OUTPUT_DIR/apis/Grafeas.V1
