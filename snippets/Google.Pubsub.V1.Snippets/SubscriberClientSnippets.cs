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

using Google.Api.Gax;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Pubsub.V1.Snippets
{
    [Collection(nameof(PubsubSnippetFixture))]
    public class SubscriberClientSnippets
    {
        private readonly PubsubSnippetFixture _fixture;

        public SubscriberClientSnippets(PubsubSnippetFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Overview()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            // Sample: Overview
            // First create a topic.
            PublisherClient publisher = PublisherClient.Create();
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            publisher.CreateTopic(topicName);

            // Subscribe to the topic.
            SubscriberClient subscriber = SubscriberClient.Create();
            string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);
            subscriber.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 60);

            // Publish a message to the topic.
            PubsubMessage message = new PubsubMessage
            {
                // The data is any arbitrary ByteString. Here, we're using text.
                Data = ByteString.CopyFromUtf8("Hello, Pubsub"),
                // The attributes provide metadata in a string-to-string dictionary.
                Attributes =
                {
                    { "description", "Simple text message" }
                }                
            };
            publisher.Publish(topicName, new[] { message });

            // Pull messages from the subscription. We're returning immediately, whether or not there
            // are messages; in other cases you'll want to allow the call to wait until a message arrives.
            PullResponse response = subscriber.Pull(subscriptionName, returnImmediately: true, maxMessages: 10);
            foreach (ReceivedMessage received in response.ReceivedMessages)
            {
                PubsubMessage msg = received.Message;
                Console.WriteLine($"Received message {msg.MessageId} published at {msg.PublishTime.ToDateTime()}");
                Console.WriteLine($"Text: '{msg.Data.ToStringUtf8()}'");
            }

            // Acknowledge that we've received the messages. If we don't do this within 60 seconds (as specified
            // when we created the subscription) we'll receive the messages again when we next pull.
            subscriber.Acknowledge(subscriptionName, response.ReceivedMessages.Select(m => m.AckId));

            // Tidy up by deleting the subscription and the topic.
            subscriber.DeleteSubscription(subscriptionName);
            publisher.DeleteTopic(topicName);
            // End sample

            Assert.Equal(1, response.ReceivedMessages.Count);
            Assert.Equal("Hello, Pubsub", response.ReceivedMessages[0].Message.Data.ToStringUtf8());
            Assert.Equal("Simple text message", response.ReceivedMessages[0].Message.Attributes["description"]);
        }

        [Fact]
        public void ListSubscriptions()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListSubscriptionsPageStream
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use a known project resource name:
            // "projects/{PROJECT_ID}"
            string projectName = SubscriberClient.FormatProjectName(projectId);
            foreach (Subscription subscription in client.ListSubscriptionsPageStream(projectName).Flatten())
            {
                Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
            }
            // End snippet
        }

        [Fact]
        public async Task ListSubscriptionsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListSubscriptionsPageStreamAsync
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use a known project resource name:
            // "projects/{PROJECT_ID}"
            string projectName = SubscriberClient.FormatProjectName(projectId);
            IAsyncEnumerable<Subscription> subscriptions = client.ListSubscriptionsPageStreamAsync(projectName).Flatten();
            await subscriptions.ForEachAsync(subscription =>
            {
                Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
            });
            // End snippet
        }

        [Fact]
        public void CreateSubscription()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            PublisherClient.Create().CreateTopic(PublisherClient.FormatTopicName(projectId, topicId));

            // Snippet: CreateSubscription
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use an existing subscription resource name:
            // "projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}"
            // Similarly for the topic name:
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            Subscription subscription = client.CreateSubscription(
                subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 30);
            Console.WriteLine($"Created {subscription.Name} subscribed to {subscription.Topic}");
            // End snippet
        }

        [Fact]
        public async Task CreateSubscriptionAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            PublisherClient.Create().CreateTopic(PublisherClient.FormatTopicName(projectId, topicId));

            // Snippet: CreateSubscriptionAsync(string,string,*,*,CallSettings)
            // Additional: CreateSubscriptionAsync(string,string,*,*,CancellationToken)
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use an existing subscription resource name:
            // "projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}"
            // Similarly for the topic name:
            // "projects/{PROJECT_ID}/topics/{TOPIC_ID}"
            string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            Subscription subscription = await client.CreateSubscriptionAsync(
                subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 30);
            Console.WriteLine($"Created {subscription.Name} subscribed to {subscription.Topic}");
            // End snippet
        }

        [Fact]
        public void Pull()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            PublisherClient publisher = PublisherClient.Create();
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            publisher.CreateTopic(topicName);
            PubsubMessage newMessage = new PubsubMessage { Data = ByteString.CopyFromUtf8("Simple text") };
            SubscriberClient.Create().CreateSubscription(SubscriberClient.FormatSubscriptionName(projectId, subscriptionId), topicName, null, 60);
            publisher.Publish(topicName, new[] { newMessage });

            // Snippet: Pull
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use an existing subscription resource name:
            // "projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}"
            string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);

            PullResponse pullResponse = client.Pull(subscriptionName, returnImmediately: false, maxMessages: 100);
            foreach (ReceivedMessage message in pullResponse.ReceivedMessages)
            {
                // Messages can contain any data. We'll assume that we know this
                // topic publishes UTF-8-encoded text.
                Console.WriteLine($"Message text: {message.Message.Data.ToStringUtf8()}");
            }

            // Acknowledge the messages after pulling them, so we don't pull them
            // a second time later. The ackDeadlineSeconds parameter specified when
            // the subscription is created determines how quickly you need to acknowledge
            // successfully-pulled messages before they will be redelivered.
            var ackIds = pullResponse.ReceivedMessages.Select(rm => rm.AckId);
            client.Acknowledge(subscriptionName, ackIds);
            // End snippet
        }

        [Fact]
        public async Task PullAsync()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            PublisherClient publisher = PublisherClient.Create();
            string topicName = PublisherClient.FormatTopicName(projectId, topicId);
            publisher.CreateTopic(topicName);
            PubsubMessage newMessage = new PubsubMessage { Data = ByteString.CopyFromUtf8("Simple text") };
            SubscriberClient.Create().CreateSubscription(SubscriberClient.FormatSubscriptionName(projectId, subscriptionId), topicName, null, 60);
            publisher.Publish(topicName, new[] { newMessage });

            // Snippet: PullAsync(string,*,*,CallSettings)
            // Additional: PullAsync(string,*,*,CancellationToken)
            SubscriberClient client = SubscriberClient.Create();

            // Alternative: use an existing subscription resource name:
            // "projects/{PROJECT_ID}/subscriptions/{SUBSCRIPTION_ID}"
            string subscriptionName = SubscriberClient.FormatSubscriptionName(projectId, subscriptionId);

            PullResponse pullResponse = await client.PullAsync(subscriptionName, returnImmediately: false, maxMessages: 100);
            foreach (ReceivedMessage message in pullResponse.ReceivedMessages)
            {
                // Messages can contain any data. We'll assume that we know this
                // topic publishes UTF-8-encoded text.
                Console.WriteLine($"Message text: {message.Message.Data.ToStringUtf8()}");
            }

            // Acknowledge the messages after pulling them, so we don't pull them
            // a second time later. The ackDeadlineSeconds parameter specified when
            // the subscription is created determines how quickly you need to acknowledge
            // successfully-pulled messages before they will be redelivered.
            var ackIds = pullResponse.ReceivedMessages.Select(rm => rm.AckId);
            await client.AcknowledgeAsync(subscriptionName, ackIds);
            // End snippet
        }
    }
}