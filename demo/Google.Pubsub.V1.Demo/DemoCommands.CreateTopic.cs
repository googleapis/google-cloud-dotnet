// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using System;

namespace Google.Pubsub.V1.Demo
{
    partial class DemoCommands
    {
        /// <summary>
        /// Creates a pubsub topic in a Google Cloud Platform project.
        /// </summary>
        public static void CreateTopic(string projectId, string topicId)
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

            // This creates a topic by converting the topic name into a CreateTopicRequest and passing it on to the
            // underlying gRPC client. This method completes synchronously; use CreateTopicAsync for an asynchronous equivalent.
            var topic = client.CreateTopic(topicName);

            // We expect the topic name in the response to be the same as the one we passed in, of course.
            Console.WriteLine($"Created topic {topic.Name}");
        }
    }
}
