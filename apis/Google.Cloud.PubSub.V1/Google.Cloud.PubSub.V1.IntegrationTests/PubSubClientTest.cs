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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

// Tests create quite a few tasks that don't need awaiting.
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

namespace Google.Cloud.PubSub.V1.IntegrationTests
{
    // Notes:
    // * These tests output progress to the console, as they can take minutes to run.
    // * These send/recv considerable amounts of network data.
    //   Only test with a machine and cloud account that can handle this.
    [Collection(nameof(PubsubFixture))]
    public class PubSubClientTest
    {
        public PubSubClientTest(PubsubFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly PubsubFixture _fixture;

        // Factory methods for clients, as a centralized place to apply default settings.
        private static Task<PublisherServiceApiClient> CreatePublisherServiceApiClientAsync() =>
            new PublisherServiceApiClientBuilder { EmulatorDetection = EmulatorDetection.EmulatorOrProduction }.BuildAsync();

        private static Task<SubscriberServiceApiClient> CreateSubscriberServiceApiClientAsync() =>
            new SubscriberServiceApiClientBuilder { EmulatorDetection = EmulatorDetection.EmulatorOrProduction }.BuildAsync();

        private async Task CreateTopicAndSubscription(TopicName topicName, SubscriptionName subscriptionName)
        {
            // Create topic
            var publisherApi = await CreatePublisherServiceApiClientAsync();
            await publisherApi.CreateTopicAsync(topicName);

            // Subscribe to the topic
            var subscriberApi = await CreateSubscriberServiceApiClientAsync();
            await subscriberApi.CreateSubscriptionAsync(subscriptionName, topicName, null, 60);
        }

        private async Task RunBulkMessaging(
            int messageCount, int minMessageSize, int maxMessageSize, int maxMessagesInFlight, int initialNackCount,
            TimeSpan? timeouts = null, int? cancelAfterRecvCount = null, TimeSpan? interPublishDelay = null,
            TimeSpan? debugOutputPeriod = null, int? publisherChannelCount = null, int? clientCount = null)
        {
            // Force messages to be at least 4 bytes long, so an int ID can be used.
            minMessageSize = Math.Max(4, minMessageSize);
            var topicId = _fixture.CreateTopicId();
            var subscriptionId = _fixture.CreateSubscriptionId();

            Console.WriteLine("BulkMessaging test");
            Console.WriteLine($"ProjectID: {_fixture.ProjectId}");
            Console.WriteLine($"Topic ID: {topicId}");
            Console.WriteLine($"Subscription ID: {subscriptionId}");
            Console.WriteLine($"{messageCount} messages; of size [{minMessageSize}, {maxMessageSize}]; " +
                $"max in-flight: {maxMessagesInFlight}, initialNacks: {initialNackCount}, " +
                $"cancelAfterRecvCount: {cancelAfterRecvCount}, interPublishDelay: {interPublishDelay}, " +
                $"clientCount: {clientCount?.ToString() ?? $"UsingDefault:{Environment.ProcessorCount}"}");

            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, subscriptionId);

            await CreateTopicAndSubscription(topicName, subscriptionName);
            await RunBulkMessagingImpl(topicName, subscriptionName, messageCount, minMessageSize, maxMessageSize,
                maxMessagesInFlight, initialNackCount, timeouts, cancelAfterRecvCount, interPublishDelay,
                debugOutputPeriod, publisherChannelCount, clientCount);
        }

        private async Task RunBulkMessagingImpl(
            TopicName topicName, SubscriptionName subscriptionName,
            int messageCount, int minMessageSize, int maxMessageSize, int maxMessagesInFlight, int initialNackCount,
            TimeSpan? timeouts = null, int? cancelAfterRecvCount = null, TimeSpan? interPublishDelay = null,
            TimeSpan? debugOutputPeriod = null, int? publisherChannelCount = null, int? clientCount = null)
        {
            // Force messages to be at least 4 bytes long, so an int ID can be used.
            minMessageSize = Math.Max(4, minMessageSize);

            // Create PublisherClient and SubscriberClient
            var publisher = await new PublisherClientBuilder
            {
                TopicName = topicName,
                ClientCount = publisherChannelCount,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction,
                ApiSettings = timeouts == null ? null : new PublisherServiceApiSettings
                {
                    PublishSettings = CallSettings
                            .FromRetry(RetrySettings.FromExponentialBackoff(
                                maxAttempts: int.MaxValue,
                                initialBackoff: TimeSpan.FromMilliseconds(100),
                                maxBackoff: TimeSpan.FromSeconds(6),
                                backoffMultiplier: 1.3,
                                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable)))
                            .WithTimeout(timeouts.Value)
                }
            }.BuildAsync();
            var subscriber = await new SubscriberClientBuilder
            {
                SubscriptionName = subscriptionName,
                ClientCount = clientCount,
                Settings = new SubscriberClient.Settings
                {
                    AckDeadline = timeouts,
                    FlowControlSettings = new FlowControlSettings(maxMessagesInFlight, null)
                }
            }.BuildAsync();

            Console.WriteLine("Topic, Subscription, Publisher and Subscriber all created");

            // Subscribe
            int recvCount = 0; // Count of received messages
            int dupCount = 0; // Count of duplicate messages
            long recvSum = 0L; // Sum of bytes of received messages
            var recvedIds = new ConcurrentDictionary<int, bool>();
            var nackedIds = new HashSet<int>();
            Task subTask = subscriber.StartAsync((msg, ct) =>
            {
                int id = BitConverter.ToInt32(msg.Data.ToArray(), 0);
                lock (nackedIds)
                {
                    if (nackedIds.Count < initialNackCount)
                    {
                        if (nackedIds.Add(id))
                        {
                            // This ID not already nacked
                            Interlocked.Increment(ref recvCount);
                            return Task.FromResult(SubscriberClient.Reply.Nack);
                        }
                    }
                }
                bool wasAdded = recvedIds.TryAdd(id, false);
                if (wasAdded)
                {
                    var localRecvCount = Interlocked.Increment(ref recvCount);
                    Interlocked.Add(ref recvSum, msg.Data.Sum(x => (long)x));
                    if (localRecvCount == cancelAfterRecvCount || localRecvCount >= messageCount + initialNackCount)
                    {
                        // Test finished, so stop subscriber
                        Console.WriteLine("All msgs received, stopping subscriber.");
                        Task unused = subscriber.StopAsync(SubscriberClient.SubscriberShutdownSetting.NackImmediately, TimeSpan.FromSeconds(15));
                    }
                }
                else
                {
                    Interlocked.Add(ref dupCount, 1);
                }
                // ACK all messages
                return Task.FromResult(SubscriberClient.Reply.Ack);
            });

            // Publish
            var rnd = new Random(1234);
            var activePubs = new HashSet<Task>();
            int sentCount = 0;
            long sentSum = 0L; // Sum of bytes of sent messages

            // Watchdog to report progress and fail test on deadlock
            CancellationTokenSource watchdogCts = new CancellationTokenSource();
            Task.Run(async () =>
            {
                var debugOutputPeriod1 = debugOutputPeriod ?? TimeSpan.FromSeconds(1);
                int prevSentCount = -1;
                int prevRecvCount = -1;
                int noProgressCount = 0;
                while (true)
                {
                    await Task.Delay(debugOutputPeriod1, watchdogCts.Token);
                    var localSentCount = Interlocked.Add(ref sentCount, 0);
                    var localRecvCount = Interlocked.Add(ref recvCount, 0);
                    var localDupCount = Interlocked.Add(ref dupCount, 0);
                    if (prevSentCount == localSentCount && prevRecvCount == localRecvCount)
                    {
                        if (noProgressCount > 60)
                        {
                             // Deadlock, shutdown subscriber, and cancel
                             Console.WriteLine("Deadlock detected. Cancelling test");
                             subscriber.StopAsync(SubscriberClient.SubscriberShutdownSetting.NackImmediately, cancellationToken: new CancellationToken(true));
                             watchdogCts.Cancel();
                             break;
                        }
                        noProgressCount += 1;
                    }
                    else
                    {
                        noProgressCount = 0;
                    }
                    prevSentCount = localSentCount;
                    prevRecvCount = localRecvCount;
                    Console.WriteLine($"[{DateTime.Now}] Sent: {localSentCount} (in-flight: {activePubs.Locked(() => activePubs.Count)}); Recv: {localRecvCount} (dups: {localDupCount})");
                }
            });

            for (int i = 0; i < messageCount; i++)
            {
                if (watchdogCts.IsCancellationRequested)
                {
                    Assert.Fail("Test cancelled by watchdog");
                }
                if (subTask.IsCompleted)
                {
                    break;
                }
                if (i > 0 && interPublishDelay is TimeSpan delay)
                {
                    await Task.Delay(delay, watchdogCts.Token);
                }
                var msgSize = rnd.Next(minMessageSize, maxMessageSize + 1);
                var msg = new byte[msgSize];
                rnd.NextBytes(msg);
                // Insert an int ID into message
                Array.Copy(BitConverter.GetBytes(i), msg, 4);
                sentSum += msg.Sum(x => (long)x);
                // Send message, and record Task
                var pubTask = publisher.PublishAsync(msg);
                Interlocked.Increment(ref sentCount);
                activePubs.Locked(() => activePubs.Add(pubTask));
                // Remove Task from active when the message has been sent to server
                pubTask.ContinueWith(t => activePubs.Locked(() => activePubs.Remove(pubTask)));
                // If too many messages are currently in flight, wait a bit
                while (activePubs.Locked(() => activePubs.Count) >= maxMessagesInFlight)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1));
                }
            }
            Console.WriteLine("Publishing complete");
            // Wait for all messages to be sent to server
            await Task.WhenAll(activePubs.Locked(() => activePubs.ToArray()));
            Console.WriteLine("Publishing completed sending to server");

            // Wait for subscriber to finish shutdown
            await subTask;
            watchdogCts.Cancel();
            Console.WriteLine("Subscriber finished shutdown");
            Console.WriteLine($"Sent: {sentCount}; Recv: {recvCount}");

            if (cancelAfterRecvCount is int cancelAfter)
            {
                Assert.True(recvCount >= cancelAfter && recvCount <= cancelAfter + maxMessagesInFlight, $"Incorrect recvCount: {recvCount}");
            }
            else
            {
                // Check that all messages are correctly received.
                Assert.Equal(messageCount + initialNackCount, recvCount);
                // This isn't foolproof (we can get to the right sum with wrong values) but it's a pretty strong indicator.
                Assert.Equal(sentSum, recvSum);
            }
            Console.WriteLine("Test complete.");
        }

        [Theory, CombinatorialData]
        public async Task ManySmallMessages([CombinatorialValues(0, 1, 2)] int clientCount)
        {
            await RunBulkMessaging(1_000_000, 1, 10, 10_000, 0, clientCount: clientCount > 0 ? clientCount : (int?)null);
        }

        [Theory(Skip = "Very long-running test; takes 6 hours")]
        [InlineData(9, 15)]
        [InlineData(5, 30)]
        [InlineData(3, 60)]
        public async Task LongPause(int totalMsgs, int pauseMinutes)
        {
            await RunBulkMessaging(totalMsgs, 100, 100, 100, 0,
                interPublishDelay: TimeSpan.FromMinutes(pauseMinutes), debugOutputPeriod: TimeSpan.FromMinutes(2));
        }

        [Theory, CombinatorialData]
        public async Task BulkMessagingAcksOnly(
            [CombinatorialValues(1_000, 11_111, 100_000)] int msgCount,
            [CombinatorialValues(false, true)] bool cancelHalfway)
        {
            // Approx data for 100,000 messages: 500MB
            await RunBulkMessaging(msgCount, 1, 10_000, msgCount / 10, 0,
                cancelAfterRecvCount: cancelHalfway ? msgCount / 2 : (int?)null);
        }

        [Fact]
        public async Task BulkMessagingWithNacks()
        {
            // Approx data: 500MB
            await RunBulkMessaging(100_000, 1, 10_000, 10_000, 10_000);
        }

        [Fact]
        public async Task MaximumSizedMessages()
        {
            // Approx data: 500MB
            await RunBulkMessaging(50, 9_900_000, 9_990_000, 20, 0, timeouts: TimeSpan.FromMinutes(10), debugOutputPeriod: TimeSpan.FromSeconds(5));
        }

        [Fact]
        public async Task OversizedMessage()
        {
            var topicId = _fixture.CreateTopicId();
            // Create topic
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var publisherApi = await CreatePublisherServiceApiClientAsync();
            await publisherApi.CreateTopicAsync(topicName);
            // Create Publisher
            var publisher = await PublisherClient.CreateAsync(topicName);
            // Create oversized message
            Random rnd = new Random(1234);
            byte[] msg = new byte[10_000_001];
            rnd.NextBytes(msg);
            // Publish a few messages. They should all throw an exception due to size
            for (int i = 0; i < 5; i++)
            {
                var ex = await Assert.ThrowsAsync<RpcException>(() => publisher.PublishAsync(msg));
                Assert.Equal(StatusCode.InvalidArgument, ex.Status.StatusCode);
                Assert.Contains("too large", ex.Status.Detail);
            }
            await publisher.ShutdownAsync(TimeSpan.FromSeconds(15));
        }

        [Fact]
        public async Task MaxBatchSize()
        {
            // Test sending messages such that the maximum batch size is reached.
            var topicId = _fixture.CreateTopicId();
            // Create topic
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var publisherApi = await CreatePublisherServiceApiClientAsync();
            await publisherApi.CreateTopicAsync(topicName);
            // Create Publisher, with no retry
            var batchingSettings = new BatchingSettings(PublisherClient.ApiMaxBatchingSettings.ElementCountThreshold,
                PublisherClient.ApiMaxBatchingSettings.ByteCountThreshold, TimeSpan.FromSeconds(4));
            var publisherServiceApiSettings = PublisherServiceApiSettings.GetDefault();
            publisherServiceApiSettings.PublishSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromSeconds(60)));
            var publisher = await new PublisherClientBuilder
            {
                TopicName = topicName,
                ClientCount = 1,
                ApiSettings = publisherServiceApiSettings,
                Settings = new PublisherClient.Settings { BatchingSettings = batchingSettings }
            }.BuildAsync();
            var msgCount = PublisherClient.ApiMaxBatchingSettings.ElementCountThreshold.Value;
            var msgSize = PublisherClient.ApiMaxBatchingSettings.ByteCountThreshold.Value / msgCount;
            var rnd = new Random(1234);
            var publishTasks = new Task[msgCount];
            for (int i = 0; i < msgCount; i++)
            {
                var msg = new byte[msgSize];
                rnd.NextBytes(msg);
                publishTasks[i] = publisher.PublishAsync(msg);
            }
            for (int i = 0; i < msgCount; i++)
            {
                // Throws exception if there's a problem
                await publishTasks[i];
            }
        }

        [Theory]
        [InlineData(10_000, 1_000, 4)]
        [InlineData(2_000, 100, 6)]
        [InlineData(10, 0.1, 4)]
        public async Task StopStartSubscriber(int totalMessageCount, double publisherFrequencyHz, double subscriberLifetimeSeconds)
        {
            int publisherBatchSize = 1;
            if (publisherFrequencyHz > 50.0)
            {
                publisherBatchSize = (int)(publisherFrequencyHz / 50.0);
                publisherFrequencyHz /= publisherBatchSize;
            }
            TimeSpan publisherDelay = TimeSpan.FromSeconds(1.0 / publisherFrequencyHz);
            TimeSpan handlerDelay = TimeSpan.FromSeconds(0.5);
            TimeSpan subscriberLifetime = TimeSpan.FromSeconds(subscriberLifetimeSeconds);

            var topicId = _fixture.CreateTopicId();
            var subscriptionId = _fixture.CreateSubscriptionId();
            // Create topic
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var publisherApi = await CreatePublisherServiceApiClientAsync();
            await publisherApi.CreateTopicAsync(topicName);
            // Subscribe to the topic
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, subscriptionId);
            var subscriberApi = await CreateSubscriberServiceApiClientAsync();
            await subscriberApi.CreateSubscriptionAsync(subscriptionName, topicName, null, 60);
            // Create publisher, and start publishing messages
            var publisher = await PublisherClient.CreateAsync(topicName);
            var publishTask = Task.Run(async () =>
            {
                Console.WriteLine($"Starting to publish {totalMessageCount} messages.");
                for (int i = 0; i < totalMessageCount; i++)
                {
                    // Publish, but don't wait for returned task.
                    publisher.PublishAsync($"Message:{i}");
                    if ((i + 1) % publisherBatchSize == 0)
                    {
                        await Task.Delay(publisherDelay);
                    }
                }
                Console.WriteLine("Publishing complete.");
            });
            // Subscribe with start/stop subscriber
            var recvedMsgs = new HashSet<string>();
            var subscribeAllTask = Task.Run(async () =>
            {
                int prevRecvCount = -1;
                int noRecvCount = 0;
                while (recvedMsgs.Locked(() => recvedMsgs.Count) < totalMessageCount)
                {
                    Console.WriteLine("Starting subscriber");
                    var subscriber = await SubscriberClient.CreateAsync(subscriptionName);
                    var subscribeTask = subscriber.StartAsync(async (msg, ct) =>
                    {
                        recvedMsgs.Locked(() => recvedMsgs.Add(msg.Data.ToStringUtf8()));
                        await Task.Delay(handlerDelay, ct);
                        return SubscriberClient.Reply.Ack;
                    });
                    await Task.Delay(subscriberLifetime);
                    Console.WriteLine("Stopping subscriber");
                    Task stopTask = subscriber.StopAsync(SubscriberClient.SubscriberShutdownSetting.NackImmediately, TimeSpan.FromSeconds(15));
                    // If shutdown times-out then stopTask, and also Task.WhenAll will cancel, causing the test to fail.
                    await Task.WhenAll(subscribeTask, stopTask);
                    int recvCount = recvedMsgs.Locked(() => recvedMsgs.Count);
                    Console.WriteLine($"Stopped subscriber. Recv count: {recvCount}");
                    if (prevRecvCount == recvCount)
                    {
                        noRecvCount += 1;
                    }
                    else
                    {
                        prevRecvCount = recvCount;
                        noRecvCount = 0;
                    }
                    // It can take a while for the last few messages to be received.
                    Assert.True(noRecvCount < 50, $"No message has been received for too long; failing test. Received {recvCount} messages out of {totalMessageCount}");
                }
            });
            Console.WriteLine("Waiting for pub+sub to complete.");
            await Task.WhenAll(publishTask, subscribeAllTask);
            Console.WriteLine("pub+sub completed.");
        }

        [Fact]
        public async Task DeadLetterQueueAndDeliveryAttempt()
        {
            // Construct the pubsub service account name. This is required for setting IAM permissions.
            var projectNumber = await _fixture.GetProjectNumberAsync();
            var pubsubServiceAccount = $"service-{projectNumber}@gcp-sa-pubsub.iam.gserviceaccount.com";

            var topicId = _fixture.CreateTopicId();
            var dlqTopicId = _fixture.CreateTopicId();
            var subscriptionId = _fixture.CreateSubscriptionId();
            var dlqSubscriptionId = _fixture.CreateSubscriptionId();
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var dlqTopicName = new TopicName(_fixture.ProjectId, dlqTopicId);
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, subscriptionId);
            var dlqSubscriptionName = new SubscriptionName(_fixture.ProjectId, dlqSubscriptionId);

            // Create topics.
            var publisherApi = await CreatePublisherServiceApiClientAsync();
            await publisherApi.CreateTopicAsync(topicName);
            await publisherApi.CreateTopicAsync(dlqTopicName);
            // Allow pubsub-managed service account to publish to the DLQ topic.
            await publisherApi.IAMPolicyClient.SetIamPolicyAsync(new SetIamPolicyRequest
            {
                ResourceAsResourceName = dlqTopicName,
                Policy = new Policy
                {
                    Bindings =
                    {
                        new Binding
                        {
                            Members = { $"serviceAccount:{pubsubServiceAccount}" },
                            Role = "roles/pubsub.publisher",
                        },
                    }
                }
            });

            // Subscribe to the topics.
            var subscriberApi = await CreateSubscriberServiceApiClientAsync();
            await subscriberApi.CreateSubscriptionAsync(dlqSubscriptionName, dlqTopicName, null, 60);
            await subscriberApi.CreateSubscriptionAsync(new Subscription
            {
                SubscriptionName = subscriptionName,
                TopicAsTopicName = topicName,
                DeadLetterPolicy = new DeadLetterPolicy
                {
                    DeadLetterTopic = dlqTopicName.ToString(),
                    MaxDeliveryAttempts = 10,
                },
                AckDeadlineSeconds = 60,
            });
            // Allow pubsub-managed service account to ACK message in subscription (so it won't be sent to client again).
            await subscriberApi.IAMPolicyClient.SetIamPolicyAsync(new SetIamPolicyRequest
            {
                ResourceAsResourceName = subscriptionName,
                Policy = new Iam.V1.Policy
                {
                    Bindings =
                    {
                        new Iam.V1.Binding
                        {
                            Members = { $"serviceAccount:{pubsubServiceAccount}" },
                            Role = "roles/pubsub.subscriber",
                        }
                    }
                }
            });

            var pub = await new PublisherClientBuilder { TopicName = topicName, ClientCount = 1 }.BuildAsync();
            var sub = await new SubscriberClientBuilder { SubscriptionName = subscriptionName, ClientCount = 1 }.BuildAsync();
            var dlqSub = await new SubscriberClientBuilder { SubscriptionName = dlqSubscriptionName, ClientCount = 1 }.BuildAsync();

            var result = new List<(int? deliveryAttempt, bool isDlq)>();

            var taskSub = sub.StartAsync((msg, ct) =>
            {
                result.Add((msg.GetDeliveryAttempt(), false));
                return Task.FromResult(SubscriberClient.Reply.Nack);
            });

            var taskDlqSub = dlqSub.StartAsync((msg, ct) =>
            {
                result.Add((msg.GetDeliveryAttempt(), true));
                // Received DLQ message, so stop test.
                sub.StopAsync(SubscriberClient.SubscriberShutdownSetting.NackImmediately, TimeSpan.FromSeconds(10));
                dlqSub.StopAsync(SubscriberClient.SubscriberShutdownSetting.NackImmediately, TimeSpan.FromSeconds(10));
                return Task.FromResult(SubscriberClient.Reply.Ack);
            });

            // Publish one message. This should be delivered 10 times (NACKed each time), then to the DLQ subscription once.
            await pub.PublishAsync("m");

            // Cancel test if it takes too long.
            var timeoutTask = Task.Delay(TimeSpan.FromSeconds(60));

            await Task.WhenAny(timeoutTask, Task.WhenAll(taskSub, taskDlqSub));
            Assert.True(taskSub.Status == TaskStatus.RanToCompletion, "Subscription task did not complete.");
            Assert.True(taskDlqSub.Status == TaskStatus.RanToCompletion, "DLQ subscription task did not complete.");

            // result.Count should be 11, but DLQ is best-effort only, so may vary.
            Assert.True(result.Count >= 10 && result.Count <= 15,
                $"Unexpected count of messages received: should be 11, received {result.Count}");

            // Expected result is count-1 messages to normal subscription, followed by 1 message to DLQ.
            var expectedResult = Enumerable.Range(1, result.Count - 1).Select(i => ((int?)i, false))
                .Concat(new[] { ((int?)null, true) });
            Assert.Equal(expectedResult, result);
        }
    }
}
