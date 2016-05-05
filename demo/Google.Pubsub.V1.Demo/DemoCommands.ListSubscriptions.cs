// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;

namespace Google.Pubsub.V1.Demo
{
    public partial class DemoCommands
    {
        /// <summary>
        /// Lists the subscriptions in a Google Cloud Platform project.
        /// </summary>
        public static void ListSubscriptions(string projectId)
        {
            // This creates a client (actually an instance of SubscriberClientImpl) synchronously, using the
            // application default credentials, and connecting to the default endpoint. Optional parameters allow
            // an alternative endpoint to be specified, as well as general client settings and credentials. Most
            // applications can simply omit these.
            // This method completes synchronously; use CreateAsync for an asynchronous equivalent.
            var client = SubscriberClient.Create();

            // The full resource name of a project is "projects/{project-id}". The GetProjectName method
            // converts the project ID into a resource name.
            // Some applications may wish to use resource names throughout the code;
            // other applications may want to use IDs and convert to resource names where required.
            string projectName = SubscriberClient.GetProjectName(projectId);

            // This lists the subscriptions by converting the project name into a ListSubscriptionsRequest and passing it on to the
            // underlying gRPC client. Each ListTopicsRequest call only returns a page of results, but the
            // ListTopics method lazily requests pages, so you can just iterate over the returned sequence - more
            // results will be fetched when you reach the end of a page.
            // The asynchronous equivalent of this call is ListTopicsAsync, which returns an IAsyncEnumerable<Topic>
            // using the Ix-Async package: https://www.nuget.org/packages/Ix-Async
            var subscriptions = client.ListSubscriptions(projectName);

            Console.WriteLine($"Subscriptions in {projectId}");
            foreach (var subscription in subscriptions)
            {
                Console.WriteLine($"  {subscription.Name} (topic: {subscription.Topic})");
            }
        }
    }
}
