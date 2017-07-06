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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.IntegrationTests
{
    // Notes:
    // * These tests output progress to the console, as they can take minutes to run.
    // * These send/recv considerable amounts of network data.
    //   Only test with a machine and cloud account that can handle this.
    [Collection(nameof(PubsubFixture))]
    public class HighPerformancePubSubTest
    {
        public HighPerformancePubSubTest(PubsubFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly PubsubFixture _fixture;

        private async Task RunBulkMessaging(int messageCount, int minMessagesize, int maxMessageSize, int maxMessagesInFlight, int initialNackCount)
        {
            var topicId = _fixture.CreateTopicId();
            var subscriptionId = _fixture.CreateSubscriptionId();

            Console.WriteLine("BulkMessaging test");
            Console.WriteLine($"{messageCount} messages; of size [{minMessagesize}, {maxMessageSize}]; max in-flight: {maxMessagesInFlight}");

            // Create topic
            var topicName = new TopicName(_fixture.ProjectId, topicId);
            var publisher = await PublisherClient.CreateAsync().ConfigureAwait(false);
            await publisher.CreateTopicAsync(topicName).ConfigureAwait(false);

            // Subscribe to the topic
            var subscriber = await SubscriberClient.CreateAsync().ConfigureAwait(false);
            var subscriptionName = new SubscriptionName(_fixture.ProjectId, subscriptionId);
            await subscriber.CreateSubscriptionAsync(subscriptionName, topicName, null, 60).ConfigureAwait(false);

            // Create high-performance Publisher and Subscriber
            var bulkPublisher = await HiPerfPublisher.CreateAsync(topicName).ConfigureAwait(false);
            var bulkSubscriber = await HiPerfSubscriber.CreateAsync(subscriptionName).ConfigureAwait(false);

            Console.WriteLine("Topic, Subscription, High-performance Publisher and Subscriber all created");

            // Subscribe
            object recvLock = new object();
            int recvCount = 0; // Count of received messages
            long recvSum = 0L; // Sum of bytes of received messages
            Task subTask = bulkSubscriber.StartAsync((msg, ct) =>
            {
                var localRecvCount = Interlocked.Increment(ref recvCount);
                if (localRecvCount <= initialNackCount)
                {
                    return Task.FromResult(HiPerfSubscriber.Reply.Nack);
                }
                Interlocked.Add(ref recvSum, msg.Data.Sum(x => (long)x));
                if (localRecvCount >= messageCount + initialNackCount)
                {
                    // Test finished, so stop subscriber
                    Task unused = bulkSubscriber.StopAsync(TimeSpan.FromSeconds(15));
                }
                // ACK all messages
                return Task.FromResult(HiPerfSubscriber.Reply.Ack);
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
                int prevSentCount = -1;
                int prevRecvCount = -1;
                while (!watchdogCts.IsCancellationRequested)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1), watchdogCts.Token).ConfigureAwait(false);
                    var localSentCount = Interlocked.Add(ref sentCount, 0);
                    var localRecvCount = Interlocked.Add(ref recvCount, 0);
                    if (prevSentCount == localSentCount && prevRecvCount == localRecvCount)
                    {
                        // Deadlock, shutdown subscriber, and cancel
                        Console.WriteLine("Deadlock detected. Cancelling test");
                        bulkSubscriber.StopAsync(new CancellationToken(true));
                        watchdogCts.Cancel();
                    }
                    prevSentCount = localSentCount;
                    prevRecvCount = localRecvCount;
                    Console.WriteLine($"Sent: {localSentCount}; Recv: {localRecvCount}");
                }
            });

            for (int i = 0; i < messageCount; i++)
            {
                if (watchdogCts.IsCancellationRequested)
                {
                    Assert.True(false, "Test cancelled by watchdog");
                }
                var msgSize = rnd.Next(minMessagesize, maxMessageSize + 1);
                var msg = new byte[msgSize];
                rnd.NextBytes(msg);
                sentSum += msg.Sum(x => (long)x);
                // Send message, and record Task
                var pubTask = bulkPublisher.PublishAsync(msg);
                Interlocked.Increment(ref sentCount);
                activePubs.Locked(() => activePubs.Add(pubTask));
                // Remove Task from active when the message has been sent to server
                pubTask.ContinueWith(t => activePubs.Locked(() => activePubs.Remove(pubTask)));
                // If too many messages are currently in flight, wait a bit
                while (activePubs.Locked(() => activePubs.Count) >= maxMessagesInFlight)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1)).ConfigureAwait(false);
                }
            }
            Console.WriteLine("Publishing complete");
            // Wait for all messages to be sent to server
            await Task.WhenAll(activePubs.Locked(() => activePubs.ToArray())).ConfigureAwait(false);
            Console.WriteLine("Publishing completed sending to server");

            // Wait for subscriber to finish shutdown
            await subTask.ConfigureAwait(false);
            watchdogCts.Cancel();
            Console.WriteLine("Subscriber finished shutdown");
            Console.WriteLine($"Sent: {sentCount}; Recv: {recvCount}");

            // Check that all messages are correctly received.
            // This isn't foolproof (we can get to the right sum with wrong values) but it's a pretty strong indicator.
            Assert.Equal(messageCount + initialNackCount, recvCount);
            Assert.Equal(sentSum, recvSum);
        }

        [Fact]
        public async Task BulkMessagingAcksOnly()
        {
            await RunBulkMessaging(100_000, 1, 20_000, 10_000, 0);
        }

        [Fact]
        public async Task BulkMessagingWithNacks()
        {
            await RunBulkMessaging(100_000, 1, 20_000, 10_000, 10_000);
        }
    }
}
