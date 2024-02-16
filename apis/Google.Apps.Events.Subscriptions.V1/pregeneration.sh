#!/bin/sh

# Temporary workaround for a method signature which redundantly includes pageToken and pageSize
# See b/325289454
sed -i 's/"page_size, page_token, filter"/"filter"/g' $GOOGLEAPIS/google/apps/events/subscriptions/v1/subscriptions_service.proto
