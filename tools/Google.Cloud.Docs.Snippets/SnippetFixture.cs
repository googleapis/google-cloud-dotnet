// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using Google.Cloud.PubSub.V1;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Tools.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// </summary>
    [CollectionDefinition(nameof(SnippetFixture))]
    public sealed class SnippetFixture : CloudProjectFixtureBase, ICollectionFixture<SnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private const string NotificationUrlEnvironmentVariable = "TEST_PROJECT_NOTIFICATION_URL";
        private const string TopicPrefix = "snippet-topic-";
        private const string SubscriptionPrefix = "snippet-sub-";

        public SnippetFixture()
        {
        }

        /// <summary>
        /// Create a topic ID with a prefix which is used to check which topics to delete at the end of the test.
        /// </summary>
        internal string CreateTopicId() => IdGenerator.FromGuid(prefix: TopicPrefix);

        /// <summary>
        /// Create a subscription ID with a prefix which is used to check which subscriptions to delete at the end of the test.
        /// </summary>
        internal string CreateSubscriptionId() => IdGenerator.FromGuid(prefix: SubscriptionPrefix);

        internal string CreateTopic()
        {
            PublisherServiceApiClient client = PublisherServiceApiClient.Create();
            TopicName topicName = new TopicName(ProjectId, CreateTopicId());
            Topic topic = client.CreateTopic(topicName);
            return topic.Name;
        }

        public override void Dispose()
        {
            var subscriber = SubscriberServiceApiClient.Create();
            var subscriptions = subscriber.ListSubscriptions(new ProjectName(ProjectId))
                .Where(sub => sub.SubscriptionName.SubscriptionId.StartsWith(SubscriptionPrefix))
                .ToList();
            foreach (var sub in subscriptions)
            {
                subscriber.DeleteSubscription(sub.SubscriptionName);
            }

            var publisher = PublisherServiceApiClient.Create();
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
