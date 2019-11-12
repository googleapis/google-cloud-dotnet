#!/bin/bash

# Fix links such as [zones](/compute/docs/zones) to include the full URL
# Note: using | instead of / to avoid worrying about escaping.

sed -i 's|](/|](https://cloud.google.com/|g' ../../googleapis/google/container/v1/*.proto
