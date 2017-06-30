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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class HiPerfPublisherTest
    {
        private class FakePublisher : PublisherClient
        {
            public FakePublisher(IScheduler scheduler, TaskHelper taskHelper, params TimeSpan[] delays)
            {
                _schduler = scheduler;
                _taskHelper = taskHelper;
                _delays = Enumerable.Repeat(delays.DefaultIfEmpty(), int.MaxValue).SelectMany(x => x).GetEnumerator();
                _handledIds = new List<string>();
            }

            private readonly object _lock = new object();
            private readonly IScheduler _schduler;
            private readonly TaskHelper _taskHelper;
            private readonly IEnumerator<TimeSpan> _delays;
            private readonly List<string> _handledIds;

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
                var msgIds = request.Messages.Select(x => x.Data.ToStringUtf8());
                lock (_lock)
                {
                    _handledIds.AddRange(msgIds);
                }
                return new PublishResponse { MessageIds = { msgIds } };
            }
        }

        private HiPerfPublisher.Settings MakeSettings(IScheduler scheduler, int batchElementCountThreshold = 1, int batchRequestByteThreshold = 1)
        {
            return new HiPerfPublisher.Settings
            {
                Scheduler = scheduler,
                BatchingSettings = new BatchingSettings(batchElementCountThreshold, batchRequestByteThreshold, TimeSpan.FromSeconds(10)),
            };

        }

        [Theory, CombinatorialData]
        public void OneMessage(
            [CombinatorialValues(false, true)] bool hardStop)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper);
            var settings = MakeSettings(scheduler);
            int shutdownCount = 0;
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var id = await taskHelper.ConfigureAwait(pub.PublishAsync("1"));
                bool isCancelled = await taskHelper.ConfigureAwaitHideCancellation(pub.ShutdownAsync(new CancellationToken(hardStop)));
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
            var clients = Enumerable.Range(0, clientCount).Select(_ => new FakePublisher(scheduler, taskHelper)).ToArray();
            var settings = MakeSettings(scheduler, batchElementCountThreshold: batchElementCountThreshold, batchRequestByteThreshold: 10000);
            int shutdownCount = 0;
            var pub = new HiPerfPublisherImpl(topicName, clients, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var tasks = Enumerable.Range(0, messageCount).Select(i => pub.PublishAsync(i.ToString())).ToArray();
                var ids = new HashSet<string>(await taskHelper.ConfigureAwait(taskHelper.WhenAll(tasks)));
                var isCancelled = await taskHelper.ConfigureAwaitHideCancellation(pub.ShutdownAsync(new CancellationToken(hardStop)));
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
            var client = new FakePublisher(scheduler, taskHelper, TimeSpan.FromSeconds(1));
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 2, batchRequestByteThreshold: 1000);
            int shutdownCount = 0;
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, () =>
            {
                Interlocked.Increment(ref shutdownCount);
                return Task.FromResult(0);
            }, taskHelper);
            scheduler.Run(async () =>
            {
                var pubTask = pub.PublishAsync("1");
                var isCancelled = await taskHelper.ConfigureAwaitHideCancellation(pub.ShutdownAsync(new CancellationToken(hardStop)));
                var pubResult = await taskHelper.ConfigureAwaitHideCancellation(pubTask, null);
                Assert.Equal(hardStop, pubTask.IsCanceled);
                Assert.Equal(hardStop, isCancelled);
                Assert.Equal(hardStop ? null : "1", pubResult);
                Assert.Equal(hardStop ? 0 : 1, client.HandledMessages.Count);
                Assert.Equal(1, shutdownCount);
            });
        }

        [Fact]
        public void FlowState()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper, TimeSpan.FromSeconds(1));
            var settings = MakeSettings(scheduler);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, null, taskHelper);
            var msgSize = new PubsubMessage { Data = ByteString.CopyFromUtf8("1") }.CalculateSize();
            scheduler.Run(async () =>
            {
                // Publish 2 msgs; 1st will be immediately sent, 2nd will stay in queue for 1 second.
                var pubTask = Task.WhenAll(pub.PublishAsync("1"), pub.PublishAsync("2"));
                Assert.Equal(1, pub.GetCurrentFlowState().ElementCount);
                Assert.Equal(msgSize, pub.GetCurrentFlowState().ByteCount);
                await taskHelper.ConfigureAwait(pubTask);
                Assert.Equal(0, pub.GetCurrentFlowState().ElementCount);
                Assert.Equal(0, pub.GetCurrentFlowState().ByteCount);
            });
        }

        [Fact]
        public void SettingsValidation()
        {
            new HiPerfPublisher.Settings().Validate();

            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.Zero) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.FromSeconds(-1)) }.Validate());
            new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, null, TimeSpan.FromMilliseconds(1)) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(0, null, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(HiPerfPublisher.ApiMaxBatchingSettings.ElementCountThreshold.Value + 1, null, null) }.Validate());
            new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(1, null, null) }.Validate();
            new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(HiPerfPublisher.ApiMaxBatchingSettings.ElementCountThreshold, null, null) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, 0, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, HiPerfPublisher.ApiMaxBatchingSettings.RequestByteThreshold + 1, null) }.Validate());
            new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, 1, null) }.Validate();
            new HiPerfPublisher.Settings { BatchingSettings = new BatchingSettings(null, HiPerfPublisher.ApiMaxBatchingSettings.RequestByteThreshold, null) }.Validate();

            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, null, TimeSpan.Zero) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, null, TimeSpan.FromSeconds(-1)) }.Validate());
            new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, null, TimeSpan.FromMilliseconds(1)) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(0, null, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(HiPerfPublisher.ApiMaxBatchingSettings.ElementCountThreshold.Value + 1, null, null) }.Validate());
            new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(1, null, null) }.Validate();
            new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(HiPerfPublisher.ApiMaxBatchingSettings.ElementCountThreshold, null, null) }.Validate();
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, 0, null) }.Validate());
            Assert.ThrowsAny<ArgumentException>(() => new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, HiPerfPublisher.ApiMaxBatchingSettings.RequestByteThreshold + 1, null) }.Validate());
            new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, 1, null) }.Validate();
            new HiPerfPublisher.Settings { MaxBatchingSettings = new BatchingSettings(null, HiPerfPublisher.ApiMaxBatchingSettings.RequestByteThreshold, null) }.Validate();
        }
    }
}
