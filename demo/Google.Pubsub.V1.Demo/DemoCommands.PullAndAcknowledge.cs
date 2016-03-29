// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using System;
using System.Linq;

namespace Google.Pubsub.V1.Demo
{
    public partial class DemoCommands
    {
        /// <summary>
        /// Pulls messages from the given subscription, displays them, and acknowledges them
        /// to avoid them being pulled again for the same subscription.
        /// It is assumed that the subscription exists before this is called.
        /// </summary>
        public static void PullAndAcknowledge(string projectId, string subscriptionId)
        {
            // This creates a client (actually an instance of SubscriberClientImpl) synchronously, using the
            // application default credentials, and connecting to the default endpoint. Optional parameters allow
            // an alternative endpoint to be specified, as well as general client settings and credentials. Most
            // applications can simply omit these.
            // This method completes synchronously; use CreateAsync for an asynchronous equivalent.
            var client = SubscriberClient.Create();

            // The full resource name of a subscription is "projects/{project-id}/subscriptions/{subscription-id}".
            // The GetSubscriptionName method converts the project ID and topic ID pair into a resource name.
            // Some applications may wish to use resource names throughout the code;
            // other applications may want to use IDs and convert to resource names where required.
            string subscriptionName = SubscriberClient.GetSubscriptionName(projectId, subscriptionId);

            // This pulls messages from a subscription by creating a PullRequest and passing it on to the
            // underlying gRPC client. You can specify whether you want to return immediately whether or not there
            // are any messages waiting, as well as the maximum number of messages to retrieve in a single call.
            // This method completes synchronously; use PullAsync for an asynchronous equivalent.
            var response = client.Pull(subscriptionName, returnImmediately: false, maxMessages: 10);

            foreach (var receivedMessage in response.ReceivedMessages)
            {
                // Each received message has an ID to use when acknowledging it, and the actual
                // message. The message itself has a binary payload (Data), a string-to-string dictionary (Attributes),
                // a message ID, and a timestamp recording when it was published (PublishTime). We're going to assume
                // the payload is simply UTF-8-encoded text; in a real application the publisher and subscriber would need
                // to agree on the format. (It could be text as here, an encoded Protocol Buffer message, or something else.)
                var text = receivedMessage.Message.Data.ToStringUtf8();
                Console.WriteLine($"Received {text} from {subscriptionName}");
            }

            // Now that we've successfully processed the messages, we need to acknowledge them to prevent retransmission.
            // We're doing this all in one go, but an application could decide to send an acknowledgement each time it
            // successfully processes a message, or use a try/finally statement to batch-acknowledge only successfully-processed
            // messages even if processing of one message fails.
            // This method completes synchronously; use AcknowledgeAsync for an asynchronous equivalent.
            client.Acknowledge(subscriptionName, response.ReceivedMessages.Select(rm => rm.AckId));
        }
    }
}
