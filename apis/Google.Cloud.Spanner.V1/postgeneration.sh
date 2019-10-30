#!/bin/bash

set -e

sed -i 's/new Type/new V1.Type/g' Google.Cloud.Spanner.V1.Snippets/SpannerClientSnippets.g.cs
