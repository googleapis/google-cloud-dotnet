#!/bin/bash

# Rename the services to {Publisher/Subscriber}ServiceApi
sed -i 's/service Publisher/service PublisherServiceApi/g' ../../googleapis/google/pubsub/v1/pubsub.proto
sed -i 's/v1.Publisher/v2.PublisherServiceApi/g' ../../googleapis/google/pubsub/v1/pubsub_grpc_service_config.json

sed -i 's/service Subscriber/service SubscriberServiceApi/g' ../../googleapis/google/pubsub/v1/pubsub.proto
sed -i 's/v1.Subscriber/v2.SubscriberServiceApi/g' ../../googleapis/google/pubsub/v1/pubsub_grpc_service_config.json
