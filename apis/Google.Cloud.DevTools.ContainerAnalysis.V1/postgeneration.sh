#!/bin/bash

set -e

# Just add a using directive in a single file; it's not worth
# using the source manipulation code for this.
sed -i '19 i \ \ \ \ using Grafeas.V1;' Google.Cloud.DevTools.ContainerAnalysis.V1.Snippets/ContainerAnalysisClientSnippets.g.cs

