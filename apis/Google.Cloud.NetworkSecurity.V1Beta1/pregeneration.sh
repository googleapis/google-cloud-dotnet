#!/bin/bash

set -e

# Add a minimalist comment to the NetworkSecurity service so it will generate.
sed -i 's/service NetworkSecurity/\/\/ Network Security service.\nservice NetworkSecurity/g' \
  $GOOGLEAPIS/google/cloud/networksecurity/v1beta1/network_security.proto
