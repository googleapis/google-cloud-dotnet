#!/bin/bash

# Rename the services to {Publisher/Subscriber}ServiceApi
sed -i 's/service Publisher/service PublisherServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub.proto
sed -i 's/v1.Publisher/v1.PublisherServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub_grpc_service_config.json
sed -i 's/v1.Publisher/v1.PublisherServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub_v1.yaml

sed -i 's/service Subscriber/service SubscriberServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub.proto
sed -i 's/v1.Subscriber/v1.SubscriberServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub_grpc_service_config.json
sed -i 's/v1.Subscriber/v1.SubscriberServiceApi/g' $GOOGLEAPIS/google/pubsub/v1/pubsub_v1.yaml
