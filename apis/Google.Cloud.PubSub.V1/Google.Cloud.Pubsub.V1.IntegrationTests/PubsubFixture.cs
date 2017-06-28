using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
