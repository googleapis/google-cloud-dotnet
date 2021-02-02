#!/bin/bash

# Fix a resource pattern typo
sed -i 's/{organization}constraints/{organization}\/constraints/g' $GOOGLEAPIS/google/cloud/orgpolicy/v2/constraint.proto
