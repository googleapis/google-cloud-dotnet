// Copyright 2017, Google Inc. All rights reserved.
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

using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.PubSub.V1.IntegrationTests
{
    [CollectionDefinition(nameof(PubsubFixture))]
    public sealed class PubsubFixture : IDisposable, ICollectionFixture<PubsubFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private const string TopicPrefix = "integration-topic-";
        private const string SubscriptionPrefix = "integration-sub-";

        public string ProjectId { get; }

        public PubsubFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
        }

        internal string CreateTopicId() => TopicPrefix + Guid.NewGuid().ToString().ToLowerInvariant();

        internal string CreateSubscriptionId() => SubscriptionPrefix + Guid.NewGuid().ToString().ToLowerInvariant();

        public void Dispose()
        {
            var subscriber = SubscriberClient.Create();
            var subscriptions = subscriber.ListSubscriptions(new ProjectName(ProjectId))
                .Where(sub => sub.SubscriptionName.SubscriptionId.StartsWith(SubscriptionPrefix))
                .ToList();
            foreach (var sub in subscriptions)
            {
                subscriber.DeleteSubscription(sub.SubscriptionName);
            }

            var publisher = PublisherClient.Create();
            var topics = publisher.ListTopics(new ProjectName(ProjectId))
                .Where(topic => topic.TopicName.TopicId.StartsWith(TopicPrefix))
                .ToList();
            foreach (var topic in topics)
            {
                publisher.DeleteTopic(topic.TopicName);
            }
        }
    }
}
