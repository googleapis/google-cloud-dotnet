// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;

namespace Google.Pubsub.V1.Demo
{
    public partial class DemoCommands
    {
        /// <summary>
        /// Creates a pubsub subscription to a topic in a Google Cloud Platform project.
        /// It is assumed that the topic exists before this is called.
        /// </summary>
        public static void CreateSubscription(string projectId, string subscriptionId, string topicId)
        {
            // This creates a client (actually an instance of SubscriberClientImpl) synchronously, using the
            // application default credentials, and connecting to the default endpoint. Optional parameters allow
            // an alternative endpoint to be specified, as well as general client settings and credentials. Most
            // applications can simply omit these.
            // This method completes synchronously; use CreateAsync for an asynchronous equivalent.
            var client = SubscriberClient.Create();

            // The full resource name of a topic is "projects/{project-id}/topics/{topic-id}".
            // The GetTopicName method converts the project ID and topic ID pair into a resource name.
            // Likewise, the full resource name of a subscription is "projects/{project-id}/subscriptions/{subscription-id}",
            // and can be obtained using GetSubscriptionName.
            // Some applications may wish to use resource names throughout the code;
            // other applications may want to use IDs and convert to resource names where required.
            // Note that the topic and subscription don't have to be in the same project; this demo code assumes they
            // are just for simplicity.
            string topicName = PublisherClient.GetTopicName(projectId, topicId);
            string subscriptionName = SubscriberClient.GetSubscriptionName(projectId, subscriptionId);

            // This creates a subscription by creating a CreateSubscriptionRequest and passing it on to the
            // underlying gRPC client.
            //
            // We're not providing a push configuration, which means that Google Cloud Pub/Sub will wait for a subscriber
            // to pull messages from the created subscription. We could instead provide a PushConfig object with a URL
            // to be requested whenever messages are published to the topic.
            //
            // The ackDeadlineSeconds parameter specifies how long the system should wait for a pulled message to be acknowledged
            // before assuming it wasn't processed successfully. After that, the message is effectively requeued, and will be
            // returned again when messages are pulled.
            //
            // This method completes synchronously; use CreateSubscriptionAsync for an asynchronous equivalent.
            var subscription = client.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 10);

            Console.WriteLine($"Created subscription {subscription.Name} for topic {subscription.Topic}");
        }
    }
}
