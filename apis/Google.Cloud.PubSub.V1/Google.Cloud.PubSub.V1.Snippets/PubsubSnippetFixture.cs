// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Grpc.Core;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.PubSub.V1.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// Topics and subscriptions are created with specific prefixes, and deleted in tear-down.
    /// </summary>
    [CollectionDefinition(nameof(PubsubSnippetFixture))]
    public sealed class PubsubSnippetFixture : CloudProjectFixtureBase, ICollectionFixture<PubsubSnippetFixture>
    {
        private const string TopicPrefix = "snippet-topic-";
        private const string SubscriptionPrefix = "snippet-sub-";

        /// <summary>
        /// Create a topic ID with a prefix which is used to check which topics to delete at the end of the test.
        /// </summary>
        internal string CreateTopicId() => TopicPrefix + Guid.NewGuid().ToString().ToLowerInvariant();

        /// <summary>
        /// Create a subscription ID with a prefix which is used to check which subscriptions to delete at the end of the test.
        /// </summary>
        internal string CreateSubscriptionId() => SubscriptionPrefix + Guid.NewGuid().ToString().ToLowerInvariant();

        public override void Dispose()
        {
            var subscriber = SubscriberServiceApiClient.Create();
            var subscriptions = subscriber.ListSubscriptions(new ProjectName(ProjectId))
                .Where(sub => sub.SubscriptionName.SubscriptionId.StartsWith(SubscriptionPrefix))
                .ToList();
            foreach (var sub in subscriptions)
            {
                try
                {
                    subscriber.DeleteSubscription(sub.SubscriptionName);
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.NotFound)
                {
                    // There is a race condition such that if the test itself deletes a subscription
                    // it can still be returned from ListSubscriptions(), but be gone by the time
                    // DeleteSubscription() here is called.
                }

            }

            var publisher = PublisherServiceApiClient.Create();
            var topics = publisher.ListTopics(new ProjectName(ProjectId))
                .Where(topic => topic.TopicName.TopicId.StartsWith(TopicPrefix))
                .ToList();
            foreach (var topic in topics)
            {
                try
                {
                    publisher.DeleteTopic(topic.TopicName);
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.NotFound)
                {
                    // There is a race condition such that if the test itself deletes a topic
                    // it can still be returned from ListTopics(), but be gone by the time
                    // DeleteTopic() here is called.
                }
            }
        }
    }
}
