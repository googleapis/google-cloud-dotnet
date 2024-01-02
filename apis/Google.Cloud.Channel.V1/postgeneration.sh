#!/bin/bash

set -e

# Suppress deprecation warnings in generated gRPC code.
# We should be able to remove this after upgrading to gRPC generator
# 2.56.0 or higher.

sed -i 's/^#pragma warning disable 0414, 1591, 8981$/#pragma warning disable 0414, 1591, 8981, 0612/g' Google.Cloud.Channel.V1/ReportsServiceGrpc.g.cs
