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
using Google.Cloud.PubSub.V1.Tasks;
using Google.Cloud.PubSub.V1.Tests.Tasks;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class PublisherClientTest
    {
        private class FakePublisherServiceApiClient : PublisherServiceApiClient
        {
            public FakePublisherServiceApiClient(IScheduler scheduler, TaskHelper taskHelper,
                TimeSpan[] delays = null, string orderingKeyErrorUnrecoverable = null, string orderingKeyErrorRecoverable = null)
            {
                _schduler = scheduler;
                _taskHelper = taskHelper;
                _delays = Enumerable.Repeat((delays ?? Enumerable.Empty<TimeSpan>()).DefaultIfEmpty(), int.MaxValue)
                    .SelectMany(x => x).GetEnumerator();
                _orderingKeyErrorUnrecoverable = orderingKeyErrorUnrecoverable;
                _orderingKeyErrorRecoverable = orderingKeyErrorRecoverable;
                _handledIds = new List<string>();
            }

            private readonly object _lock = new object();
            private readonly IScheduler _schduler;
            private readonly TaskHelper _taskHelper;
            private readonly IEnumerator<TimeSpan> _delays;
            private readonly List<string> _handledIds;

            private string _orderingKeyErrorUnrecoverable;
            private string _orderingKeyErrorRecoverable;

            public IReadOnlyList<string> HandledMessages
            {
                get
                {
                    lock (_lock)
                    {
                        return _handledIds.ToArray();
                    }
                }
            }

            public override async Task<PublishResponse> PublishAsync(PublishRequest request, CallSettings callSettings = null)
            {
                _delays.MoveNext();
                await _taskHelper.ConfigureAwait(_schduler.Delay(_delays.Current, callSettings?.CancellationToken ?? CancellationToken.None));
                var byOrderingKey = request.Messages.GroupBy(x => x.OrderingKey).ToList();
                if (byOrderingKey.Count > 1)
                {
                    throw new InvalidOperationException("Multiple ordering-keys should not be present within a single batch.");
                }
                var msgIds = request.Messages.Select(x => x.Data.ToStringUtf8());
                lock (_lock)
                {
                    if (byOrderingKey.Count > 0 && byOrderingKey[0].Key == _orderingKeyErrorUnrecoverable)
                    {
                        // Cause a one-off unrecoverable error.
                        _orderingKeyErrorUnrecoverable = null;
                        throw new RpcException(new Status(StatusCode.DataLoss, "Data loss"));
                    }
                    if (byOrderingKey.Count > 0 && byOrderingKey[0].Key == _orderingKeyErrorRecoverable)
                    {
                        // Cause a one-off recoverable error.
                        _orderingKeyErrorRecoverable = null;
                        throw new RpcException(new Status(StatusCode.Unavailable, "Unavailable"));
                    }
                    _handledIds.AddRange(msgIds);
                }
                return new PublishResponse { MessageIds = { msgIds } };
            }
        }

        private PublisherClient.Settings MakeSettings(IScheduler scheduler,
            int batchElementCountThreshold = 1, int batchRequestByteThreshold = 1, bool enableMessageOrdering = false, TimeSpan? disposeTimeout = null)
        {
            return new PublisherClient.Settings
            {
                Scheduler = scheduler,
                BatchingSettings = new BatchingSettings(batchElementCountThreshold, batchRequestByteThreshold, TimeSpan.FromSeconds(10)),
                EnableMessageOrdering = enableMessageOrdering,
                DisposeTimeout = disposeTimeout
            };

        }

        [Theory, CombinatorialData]
        public void OneMessage(
            [CombinatorialValues(false, true)] bool hardStop)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper);
            var settings = MakeSettings(scheduler);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var id = await taskHelper.ConfigureAwait(pub.PublishAsync("1"));
                bool isCancelled = await taskHelper.ConfigureAwaitHideCancellation(
                    () => pub.ShutdownAsync(new CancellationToken(hardStop)));
                Assert.Equal(hardStop, isCancelled);
                Assert.Equal("1", id);
                Assert.Equal(1, shutdownCount);
            });
        }

        [Theory, PairwiseData]
        public void ManyMessages(
            [CombinatorialValues(false, true)] bool hardStop,
            [CombinatorialValues(1, 2, 5, 7)] int clientCount,
            [CombinatorialValues(1, 2, 6, 13)] int threadCount,
            [CombinatorialValues(101, 2000, 9999)] int messageCount,
            [CombinatorialValues(1, 5, 50)] int batchElementCountThreshold)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler(threadCount);
            TaskHelper taskHelper = scheduler.TaskHelper;
            var clients = Enumerable.Range(0, clientCount).Select(_ => new FakePublisherServiceApiClient(scheduler, taskHelper)).ToArray();
            var settings = MakeSettings(scheduler, batchElementCountThreshold: batchElementCountThreshold, batchRequestByteThreshold: 10000);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, clients, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var tasks = Enumerable.Range(0, messageCount).Select(i => pub.PublishAsync(i.ToString())).ToArray();
                var ids = new HashSet<string>(await taskHelper.ConfigureAwait(taskHelper.WhenAll(tasks)));
                var isCancelled = await taskHelper.ConfigureAwaitHideCancellation(
                    () => pub.ShutdownAsync(new CancellationToken(hardStop)));
                Assert.Equal(hardStop, isCancelled);
                var expected = new HashSet<string>(Enumerable.Range(0, messageCount).Select(x => x.ToString()));
                Assert.Equal(expected, ids);
                Assert.Equal(1, shutdownCount);
            });
        }

        [Theory, CombinatorialData]
        public void Shutdown(
            [CombinatorialValues(false, true)] bool hardStop)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper, delays: new[] { TimeSpan.FromSeconds(1) });
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 2, batchRequestByteThreshold: 1000);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var pubTask = pub.PublishAsync("1");
                var isCancelled = await taskHelper.ConfigureAwaitHideCancellation(
                    () => pub.ShutdownAsync(new CancellationToken(hardStop)));
                var pubResult = await taskHelper.ConfigureAwaitHideCancellation(() => pubTask, null);
                Assert.Equal(hardStop, pubTask.IsCanceled);
                Assert.Equal(hardStop, isCancelled);
                Assert.Equal(hardStop ? null : "1", pubResult);
                Assert.Equal(hardStop ? 0 : 1, client.HandledMessages.Count);
                Assert.Equal(1, shutdownCount);
            });
        }

        // The test is similar to Shutdown but checks that calling DisposeAsync() instead of ShutdownAsync() works.
        // It also tests that DisposeAsync() or ShutdownAsync() can be called multiple times, without throwing exception.
        [Fact]
        public void Dispose()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper, delays: new[] { TimeSpan.FromSeconds(1) });
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 2, batchRequestByteThreshold: 1000);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                // Publish a message.
                var pubTask = pub.PublishAsync("1");
                // Dispose the publisher.
                await taskHelper.ConfigureAwaitHideCancellation(
                   () => pub.DisposeAsync().AsTask());
                // Call DisposeAsync again. It shouldn't throw an exception.
                await taskHelper.ConfigureAwaitHideCancellation(
                   () => pub.DisposeAsync().AsTask());
                // Call ShutdownAsync. It shouldn't throw an exception.
                await taskHelper.ConfigureAwaitHideCancellation(
                  () => pub.ShutdownAsync(CancellationToken.None));
                // Get the result of the publish task.
                var pubResult = await taskHelper.ConfigureAwaitHideCancellation(() => pubTask, null);
                Assert.Equal("1", pubResult);
                Assert.Equal(1, shutdownCount);
            });
        }

        // Disposing before publishing shouldn't throw.
        [Fact]
        public void DisposeBeforePublishing()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper, delays: new[] { TimeSpan.FromSeconds(1) });
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 2, batchRequestByteThreshold: 1000);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                // Dispose the publisher.
                await taskHelper.ConfigureAwaitHideCancellation(
                   () => pub.DisposeAsync().AsTask());
                // Call DisposeAsync again. It shouldn't throw an exception.
                await taskHelper.ConfigureAwaitHideCancellation(
                   () => pub.DisposeAsync().AsTask());
                // Call ShutdownAsync. It shouldn't throw an exception.
                await taskHelper.ConfigureAwaitHideCancellation(
                  () => pub.ShutdownAsync(CancellationToken.None));
                Assert.Equal(1, shutdownCount);
            });
        }

        [Fact]
        public void SettingsValidation()
        {
            new PublisherClient.Settings().Validate();

            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.Zero) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.FromSeconds(-1)) }.Validate());
            new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.FromMilliseconds(1)) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(0, null, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(PublisherClient.ApiMaxBatchingSettings.ElementCountThreshold.Value + 1, null, null) }.Validate());
            new PublisherClient.Settings { BatchingSettings = new BatchingSettings(1, null, null) }.Validate();
            new PublisherClient.Settings { BatchingSettings = new BatchingSettings(PublisherClient.ApiMaxBatchingSettings.ElementCountThreshold, null, null) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, 0, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, PublisherClient.ApiMaxBatchingSettings.ByteCountThreshold + 1, null) }.Validate());
            new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, 1, null) }.Validate();
            new PublisherClient.Settings { BatchingSettings = new BatchingSettings(null, PublisherClient.ApiMaxBatchingSettings.ByteCountThreshold, null) }.Validate();
        }

        [Fact]
        public void PublishingMessageWithOrderingKeyRequiresOrderingEnabled()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper);
            var settings = MakeSettings(scheduler);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                await taskHelper.ConfigureAwait(
                    Assert.ThrowsAsync<InvalidOperationException>(() => pub.PublishAsync("an ordering key", "1")));
            });
        }

        [Theory, PairwiseData]
        public void OrderingKeyManyMessages(
            [CombinatorialValues(1, 2, 5, 7)] int clientCount,
            [CombinatorialValues(1, 2, 6, 13)] int threadCount,
            [CombinatorialValues(101, 2000, 9999)] int messageCount,
            [CombinatorialValues(1, 2, 9, 51)] int orderingKeysCount,
            [CombinatorialValues(1, 5, 50)] int batchElementCountThreshold,
            [CombinatorialValues(0, 1, 59, 123, 1001)] int delayMs1,
            [CombinatorialValues(0, 2, 500)] int delayMs2)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler(threadCount);
            TaskHelper taskHelper = scheduler.TaskHelper;
            var clients = Enumerable.Range(0, clientCount)
                .Select(_ => new FakePublisherServiceApiClient(scheduler, taskHelper,
                    new[] { TimeSpan.FromMilliseconds(delayMs1), TimeSpan.FromMilliseconds(delayMs2) })).ToArray();
            var settings = MakeSettings(scheduler,
                batchElementCountThreshold: batchElementCountThreshold, batchRequestByteThreshold: 10000, enableMessageOrdering: true);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, clients, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var tasks = Enumerable.Range(0, messageCount)
                    .Select(i => pub.PublishAsync((i % orderingKeysCount).ToString(), $"{i % orderingKeysCount}:{i}")).ToArray();
                var ids = new HashSet<string>(await taskHelper.ConfigureAwait(taskHelper.WhenAll(tasks)));
                await taskHelper.ConfigureAwait(pub.ShutdownAsync(new CancellationToken()));
                Assert.Equal(messageCount, ids.Count);
                // This doesn't check the global ordering between clients, but that's OK here.
                // The emulator-based integration test checks are more thorough.
                foreach (var client in clients)
                {
                    var kv = client.HandledMessages.Select(x => x.Split(':')).Select(x => (key: x[0], value: x[1]));
                    foreach (var values in kv.GroupBy(x => x.key, x => x.value))
                    {
                        var errorMsg = $"Ordering-key '{values.Key}' out of order";
                        foreach (var pair in values.Zip(values.Skip(1), (a, b) => (a, b)))
                        {
                            Assert.True(int.Parse(pair.a) < int.Parse(pair.b), errorMsg);
                        }
                    }
                }
                Assert.Equal(ids, new HashSet<string>(clients.SelectMany(x => x.HandledMessages)));
                Assert.Equal(1, shutdownCount);
            });
        }

        [Fact]
        public void OrderingKeyResumePublish()
        {
            const string unrecoverableKey = "error-unrecoverable";
            const string recoverableKey = "error-recoverable";
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisherServiceApiClient(scheduler, taskHelper,
                orderingKeyErrorUnrecoverable: unrecoverableKey, orderingKeyErrorRecoverable: recoverableKey);
            var settings = MakeSettings(scheduler, enableMessageOrdering: true);
            int shutdownCount = 0;
            var pub = new PublisherClientImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                // First call will trigger an unrecoverable error.
                var ex = await taskHelper.ConfigureAwait(
                    Assert.ThrowsAsync<RpcException>(() => pub.PublishAsync(unrecoverableKey, "unrecoverable error")));
                Assert.Equal(StatusCode.DataLoss, ex.StatusCode);
                // Sending again will reject the message.
                await taskHelper.ConfigureAwait(
                    Assert.ThrowsAsync<OrderingKeyInErrorStateException>(() => pub.PublishAsync(unrecoverableKey, "key in error state")));
                // Other ordering-keys publish OK.
                await taskHelper.ConfigureAwait(pub.PublishAsync("ok-key", "ok"));
                // Including a recoverable error.
                await taskHelper.ConfigureAwait(pub.PublishAsync(recoverableKey, "recoverable error"));
                // Including a message without an ordering key.
                await taskHelper.ConfigureAwait(pub.PublishAsync("key not ordered"));
                // Resume publishing on the ordering key.
                pub.ResumePublish(unrecoverableKey);
                await taskHelper.ConfigureAwait(pub.PublishAsync(unrecoverableKey, "unrecoverable key resumed"));
                var expected = new HashSet<string>(new[] { "ok", "key not ordered", "recoverable error", "unrecoverable key resumed" });
                Assert.Equal(expected, new HashSet<string>(client.HandledMessages));
            });
        }
    }
}
