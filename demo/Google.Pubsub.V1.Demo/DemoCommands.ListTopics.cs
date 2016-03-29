// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System;

namespace Google.Pubsub.V1.Demo
{
    public partial class DemoCommands
    {
        /// <summary>
        /// Lists the topics in a Google Cloud Platform project.
        /// </summary>
        public static void ListTopics(string projectId)
        {
            // This creates a client (actually an instance of PublisherClientImpl) synchronously, using the
            // application default credentials, and connecting to the default endpoint. Optional parameters allow
            // an alternative endpoint to be specified, as well as general client settings and credentials. Most
            // applications can simply omit these.
            // This method completes synchronously; use CreateAsync for an asynchronous equivalent.
            var client = PublisherClient.Create();

            // The full resource name of a project is "projects/{project-id}". The GetProjectName method
            // converts the project ID into a resource name.
            // Some applications may wish to use resource names throughout the code;
            // other applications may want to use IDs and convert to resource names where required.
            string projectName = PublisherClient.GetProjectName(projectId);

            // This lists the topics by converting the project name into a ListTopicsRequest and passing it on to the
            // underlying gRPC client. Each ListTopicsRequest call only returns a page of results, but the
            // ListTopics method lazily requests pages, so you can just iterate over the returned sequence - more
            // results will be fetched when you reach the end of a page.
            // The asynchronous equivalent of this call is ListTopicsAsync, which returns an IAsyncEnumerable<Topic>
            // using the Ix-Async package: https://www.nuget.org/packages/Ix-Async
            var topics = client.ListTopics(projectName);

            Console.WriteLine($"Topics in {projectId}");
            foreach (var topic in topics)
            {
                Console.WriteLine($"  {topic.Name}");
            }
        }
    }
}
