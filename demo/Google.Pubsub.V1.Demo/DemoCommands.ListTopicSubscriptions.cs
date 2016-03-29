// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;

namespace Google.Pubsub.V1.Demo
{
    public partial class DemoCommands
    {
        /// <summary>
        /// Lists the subscriptions to a particular topic in a Google Cloud Platform project.
        /// It is assumed that the topic exists before this is called.
        /// </summary>
        public static void ListTopicSubscriptions(string projectId, string topicId)
        {
            // This creates a client (actually an instance of PublisherClientImpl) synchronously, using the
            // application default credentials, and connecting to the default endpoint. Optional parameters allow
            // an alternative endpoint to be specified, as well as general client settings and credentials. Most
            // applications can simply omit these.
            // This method completes synchronously; use CreateAsync for an asynchronous equivalent.
            var client = PublisherClient.Create();

            // The full resource name of a topic is "projects/{project-id}/topics/{topic-id}". The GetTopicName method
            // converts the project ID and topic ID pair into a resource name.
            // Some applications may wish to use resource names throughout the code;
            // other applications may want to use IDs and convert to resource names where required.
            string topicName = PublisherClient.GetTopicName(projectId, topicId);

            // This lists the subscriptions to a particular otpic by converting the project name into a
            // ListTopicSubscriptionsRequest and passing it on to the
            // underlying gRPC client. Each ListTopicSubscriptionsRequest call only returns a page of results, but the
            // ListTopicSubscriptions method lazily requests pages, so you can just iterate over the returned sequence - more
            // results will be fetched when you reach the end of a page.
            // The asynchronous equivalent of this call is ListTopicSubscriptionsAsync, which returns an IAsyncEnumerable<string>
            // using the Ix-Async package: https://www.nuget.org/packages/Ix-Async
            var subscriptions = client.ListTopicSubscriptions(topicName);

            Console.WriteLine($"Subscriptions to {topicName}");
            foreach (var subscription in subscriptions)
            {
                Console.WriteLine($"  {subscription}");
            }
        }
    }
}
