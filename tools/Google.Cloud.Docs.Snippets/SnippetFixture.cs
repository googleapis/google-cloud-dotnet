using Google.Cloud.PubSub.V1;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.Snippets
{
    /// <summary>
    /// Fixture which is set up at the start of the test run, and torn down at the end.
    /// </summary>
    [CollectionDefinition(nameof(SnippetFixture))]
    public sealed class SnippetFixture : IDisposable, ICollectionFixture<SnippetFixture>
    {
        private const string ProjectEnvironmentVariable = "TEST_PROJECT";
        private const string NotificationUrlEnvironmentVariable = "TEST_PROJECT_NOTIFICATION_URL";
        private const string TopicPrefix = "snippet-topic-";
        private const string SubscriptionPrefix = "snippet-sub-";

        public string ProjectId { get; }

        public SnippetFixture()
        {
            ProjectId = Environment.GetEnvironmentVariable(ProjectEnvironmentVariable);
            if (string.IsNullOrEmpty(ProjectId))
            {
                throw new InvalidOperationException(
                    $"Please set the {ProjectEnvironmentVariable} environment variable before running tests");
            }
        }

        /// <summary>
        /// Create a topic ID with a prefix which is used to check which topics to delete at the end of the test.
        /// </summary>
        internal string CreateTopicId() => TopicPrefix + Guid.NewGuid().ToString().ToLowerInvariant();

        /// <summary>
        /// Create a subscription ID with a prefix which is used to check which subscriptions to delete at the end of the test.
        /// </summary>
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
