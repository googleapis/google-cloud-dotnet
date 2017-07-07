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

using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Snippets
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
            TopicName topicName = new TopicName(projectId, topicId);
            publisher.CreateTopic(topicName);

            // Subscribe to the topic.
            SubscriberClient subscriber = SubscriberClient.Create();
            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);
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
        public async Task SimpleOverview()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            // Sample: SimpleOverview
            // First create a topic.
            PublisherClient publisher = await PublisherClient.CreateAsync();
            TopicName topicName = new TopicName(projectId, topicId);
            publisher.CreateTopic(topicName);

            // Subscribe to the topic.
            SubscriberClient subscriber = await SubscriberClient.CreateAsync();
            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);
            subscriber.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: 60);

            // Publish a message to the topic using SimplePublisher.
            SimplePublisher simplePublisher = await SimplePublisher.CreateAsync(topicName);
            // PublishAsync() has various overloads. Here we're using the string overload.
            string messageId = await simplePublisher.PublishAsync("Hello, Pubsub");
            // SimplePublisher should be shutdown after use.
            // The TimeSpan specifies for how long to attempt to publish locally queued messages.
            await simplePublisher.ShutdownAsync(TimeSpan.FromSeconds(15));

            // Pull messages from the subscription using SimpleSubscriber.
            SimpleSubscriber simpleSubscriber = await SimpleSubscriber.CreateAsync(subscriptionName);
            List<PubsubMessage> receivedMessages = new List<PubsubMessage>();
            // Start the subscriber listening for messages.
            await simpleSubscriber.StartAsync((msg, cancellationToken) =>
            {
                receivedMessages.Add(msg);
                Console.WriteLine($"Received message {msg.MessageId} published at {msg.PublishTime.ToDateTime()}");
                Console.WriteLine($"Text: '{msg.Data.ToStringUtf8()}'");
                // Stop this subscriber after one message is received.
                // This is non-blocking, and the returned Task may be awaited.
                simpleSubscriber.StopAsync(TimeSpan.FromSeconds(15));
                // Return Reply.Ack to indicate this message has been handled.
                return Task.FromResult(SimpleSubscriber.Reply.Ack);
            });

            // Tidy up by deleting the subscription and the topic.
            subscriber.DeleteSubscription(subscriptionName);
            publisher.DeleteTopic(topicName);
            // End sample

            Assert.Equal(1, receivedMessages.Count);
            Assert.Equal("Hello, Pubsub", receivedMessages[0].Data.ToStringUtf8());
        }

        [Fact]
        public void ListSubscriptions()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListSubscriptions(*,*,*,*)
            SubscriberClient client = SubscriberClient.Create();

            ProjectName projectName = new ProjectName(projectId);
            foreach (Subscription subscription in client.ListSubscriptions(projectName))
            {
                Console.WriteLine($"{subscription.Name} subscribed to {subscription.Topic}");
            }
            // End snippet
        }

        [Fact]
        public async Task ListSubscriptionsAsync()
        {
            string projectId = _fixture.ProjectId;

            // Snippet: ListSubscriptionsAsync(*,*,*,*)
            SubscriberClient client = SubscriberClient.Create();

            ProjectName projectName = new ProjectName(projectId);
            IAsyncEnumerable<Subscription> subscriptions = client.ListSubscriptionsAsync(projectName);
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

            PublisherClient.Create().CreateTopic(new TopicName(projectId, topicId));

            // Snippet: CreateSubscription(*,*,*,*,*)
            SubscriberClient client = SubscriberClient.Create();

            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);
            TopicName topicName = new TopicName(projectId, topicId);
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

            PublisherClient.Create().CreateTopic(new TopicName(projectId, topicId));

            // Snippet: CreateSubscriptionAsync(SubscriptionName,TopicName,*,*,CallSettings)
            // Additional: CreateSubscriptionAsync(SubscriptionName,TopicName,*,*,CancellationToken)
            SubscriberClient client = SubscriberClient.Create();

            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);
            TopicName topicName = new TopicName(projectId, topicId);
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
            TopicName topicName = new TopicName(projectId, topicId);
            publisher.CreateTopic(topicName);
            PubsubMessage newMessage = new PubsubMessage { Data = ByteString.CopyFromUtf8("Simple text") };
            SubscriberClient.Create().CreateSubscription(new SubscriptionName(projectId, subscriptionId), topicName, null, 60);
            publisher.Publish(topicName, new[] { newMessage });

            // Snippet: Pull(*,*,*,*)
            SubscriberClient client = SubscriberClient.Create();

            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);

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
            TopicName topicName = new TopicName(projectId, topicId);
            publisher.CreateTopic(topicName);
            PubsubMessage newMessage = new PubsubMessage { Data = ByteString.CopyFromUtf8("Simple text") };
            SubscriberClient.Create().CreateSubscription(new SubscriptionName(projectId, subscriptionId), topicName, null, 60);
            publisher.Publish(topicName, new[] { newMessage });

            // Snippet: PullAsync(SubscriptionName,*,*,CallSettings)
            // Additional: PullAsync(SubscriptionName,*,*,CancellationToken)
            SubscriberClient client = SubscriberClient.Create();

            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);

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

        [Fact]
        public async Task StreamingPull()
        {
            string projectId = _fixture.ProjectId;
            string topicId = _fixture.CreateTopicId();
            string subscriptionId = _fixture.CreateSubscriptionId();

            // Snippet: StreamingPull(*, *)
            PublisherClient publisher = PublisherClient.Create();
            TopicName topicName = new TopicName(projectId, topicId);
            publisher.CreateTopic(topicName);
            SubscriberClient subscriber = SubscriberClient.Create();
            SubscriptionName subscriptionName = new SubscriptionName(projectId, subscriptionId);
            subscriber.CreateSubscription(subscriptionName, topicName, null, 60);

            // If we don't see all the messages we expect in 10 seconds, we'll cancel the call.
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            CallSettings callSettings = CallSettings.FromCancellationToken(cancellationTokenSource.Token);
            SubscriberClient.StreamingPullStream stream = subscriber.StreamingPull(callSettings);

            // The first request must include the subscription name and the stream ack deadline
            await stream.WriteAsync(new StreamingPullRequest { SubscriptionAsSubscriptionName = subscriptionName, StreamAckDeadlineSeconds = 20 });

            Task pullingTask = Task.Run(async () =>
            {
                int messagesSeen = 0;
                IAsyncEnumerator<StreamingPullResponse> responseStream = stream.ResponseStream;

                // Handle responses as we see them.
                while (await responseStream.MoveNext())
                {
                    StreamingPullResponse response = responseStream.Current;
                    Console.WriteLine("Received streaming response");
                    foreach (ReceivedMessage message in response.ReceivedMessages)
                    {
                        // Messages can contain any data. We'll assume that we know this
                        // topic publishes UTF-8-encoded text.
                        Console.WriteLine($"Message text: {message.Message.Data.ToStringUtf8()}");
                    }
                    // Acknowledge the messages we've just seen
                    await stream.WriteAsync(new StreamingPullRequest { AckIds = { response.ReceivedMessages.Select(rm => rm.AckId) } });

                    // If we've seen all the messages we expect, we can complete the streaming call,
                    // and our next MoveNext call will return false.
                    messagesSeen += response.ReceivedMessages.Count;
                    if (messagesSeen == 3)
                    {
                        await stream.WriteCompleteAsync();
                    }
                }
            });

            publisher.Publish(topicName, new[] { new PubsubMessage { Data = ByteString.CopyFromUtf8("Message 1") } });
            publisher.Publish(topicName, new[] { new PubsubMessage { Data = ByteString.CopyFromUtf8("Message 2") } });
            publisher.Publish(topicName, new[] { new PubsubMessage { Data = ByteString.CopyFromUtf8("Message 3") } });

            await pullingTask;
            // End snippet
        }
    }
}