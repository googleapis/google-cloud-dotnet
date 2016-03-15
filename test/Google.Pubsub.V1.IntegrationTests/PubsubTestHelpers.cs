// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using System;
using System.Linq;

namespace Google.Pubsub.V1.IntegrationTests
{
    internal static class PubsubTestHelpers
    {
        private const string Prefix = "integration-test-";

        internal static string CreateRandomTopic(SimplePubsub pubsub)
        {
            string topicId = CreateRandomId();
            pubsub.Publisher.CreateTopic(PublisherClient.GetTopicName(pubsub.ProjectId, topicId));
            return topicId;
        }

        internal static string CreateRandomSubscription(SimplePubsub pubsub, string topicId, int ackDeadlineSeconds = 60)
        {
            string subscriptionId = CreateRandomId();
            pubsub.Subscriber.CreateSubscription(
                SubscriberClient.GetSubscriptionName(pubsub.ProjectId, subscriptionId),
                PublisherClient.GetTopicName(pubsub.ProjectId, topicId),
                pushConfig: null,
                ackDeadlineSeconds: ackDeadlineSeconds);
            return subscriptionId;
        }

        internal static string CreateRandomId() => Prefix + Guid.NewGuid();
    }
}
