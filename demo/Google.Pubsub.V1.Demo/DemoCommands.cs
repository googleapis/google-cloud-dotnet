// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using System.Threading.Tasks;

namespace Google.Pubsub.V1.Demo
{
    /// <summary>
    /// Demonstration code for the Pubsub API. Each individual API call is 
    /// in a separate method, in a different partial file so it's easy to focus on just that.
    /// (Each of these methods creates a separate client object. In real applications you would
    /// usually maintain a client object for multiple calls, possibly across the lifetime of the
    /// whole application.)
    /// This file contains a demo method showing how all of the commands can be chained together.
    /// </summary>
    public partial class DemoCommands
    {
        // General TODO: detect the default project ID, and use that so users never have to specify it...

        /// <summary>
        /// Runs through a full demo sequence, creating a topic and two subscriptions, then publishing
        /// messages to the topic and displaying the results 
        /// </summary>
        public static void FullDemo(string projectId)
        {
            // TODO: Generate these randomly?
            string topicId = "demo-topic";
            string subscriptionId1 = "xdemo-subscription1";
            string subscriptionId2 = "xdemo-subscription2";

            CreateTopic(projectId, topicId);
            CreateSubscription(projectId, subscriptionId1, topicId);
            CreateSubscription(projectId, subscriptionId2, topicId);

            var subscriberTask1 = Task.Run(() => PullAndAcknowledge(projectId, subscriptionId1));
            var subscriberTask2 = Task.Run(() => PullAndAcknowledge(projectId, subscriptionId2));

            Publish(projectId, topicId, "First message", "Second message", "Third message");

            // Wait for the two subscribers to finish.
            subscriberTask1.Wait();
            subscriberTask2.Wait();

            // TODO: Clean up
        }
    }
}
