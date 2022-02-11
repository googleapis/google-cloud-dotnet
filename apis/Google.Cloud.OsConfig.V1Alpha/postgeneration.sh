#!/bin/bash

set -e

# Suppress deprecation warnings in generated gRPC code.
# (If this becomes a common problem, we'll want a more robust fix.
# It'll do for now.)

sed -i 's/^#pragma warning disable 0414, 1591$/#pragma warning disable 0414, 1591, 0612/g' Google.Cloud.OsConfig.V1Alpha/OsconfigZonalServiceGrpc.g.cs
