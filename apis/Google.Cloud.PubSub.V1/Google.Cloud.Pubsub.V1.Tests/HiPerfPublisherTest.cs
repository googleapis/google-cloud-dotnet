using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.PubSub.V1.Tasks;
using Google.Cloud.PubSub.V1.Tests.Testing;
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
        class FakePublisher : PublisherClient
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
                await _taskHelper.ConfigureAwait(_schduler.Delay(_delays.Current, CancellationToken.None));
                var msgIds = request.Messages.Select(x => x.Data.ToStringUtf8());
                lock (_lock)
                {
                    _handledIds.AddRange(msgIds);
                }
                return new PublishResponse { MessageIds = { msgIds } };
            }
        }

        private HiPerfPublisher.Settings MakeSettings(IScheduler scheduler, int batchElementCountThreshold = 1, int batchRequestByteThreshold = 1,
            int maxOutstandingElementCount = 10000, int maxOutstandingRequestBytes = 1000000, LimitExceededBehavior limitExceededBehavior = LimitExceededBehavior.ThrowException)
        {
            return new HiPerfPublisher.Settings
            {
                Scheduler = scheduler,
                FlowControlSettings = new FlowControlSettings
                {
                    LimitExceededBehavior = limitExceededBehavior,
                    MaxOutstandingElementCount = maxOutstandingElementCount,
                    MaxOutstandingRequestBytes = maxOutstandingRequestBytes
                },
                BatchingSettings = new BatchingSettings
                {
                    DelayThreshold = TimeSpan.FromMilliseconds(10000),
                    ElementCountThreshold = batchElementCountThreshold,
                    RequestByteThreshold = batchRequestByteThreshold
                }
            };

        }

        // TODO: Unit tests need tidying up, and expanding

        [Fact]
        public void TestOneMessage()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper);
            var settings = MakeSettings(scheduler);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, taskHelper);
            scheduler.Run(async () =>
            {
                var id = await taskHelper.ConfigureAwait(pub.PublishAsync("1"));
                Assert.Equal("1", id);
            });
        }

        [Theory, CombinatorialData]
        public void TestManyMessages(
            [CombinatorialValues(101, 2000, 9999)] int messageCount,
            [CombinatorialValues(1, 5, 50)] int batchElementCountThreshold)
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper);
            var settings = MakeSettings(scheduler, batchElementCountThreshold: batchElementCountThreshold, batchRequestByteThreshold: 10000);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, taskHelper);
            scheduler.Run(async () =>
            {
                Task<string>[] tasks = new Task<string>[messageCount];
                for (int i = 0; i < tasks.Length; i++)
                {
                    tasks[i] = pub.PublishAsync(i.ToString());
                }
                var ids = new HashSet<string>(await taskHelper.ConfigureAwait(Task.WhenAll(tasks)));
                var expected = new HashSet<string>(Enumerable.Range(0, tasks.Length).Select(x => x.ToString()));
                Assert.Equal(expected, ids);
            });
        }

        [Fact]
        public void BlockingSingleThreaded()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler(threadCount: 2);
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper, TimeSpan.FromMilliseconds(50));
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 1, batchRequestByteThreshold: 10000, maxOutstandingElementCount: 2, limitExceededBehavior: LimitExceededBehavior.Block);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, taskHelper);
            scheduler.Run(async () =>
            {
                var messageCount = 50;
                Task<string>[] tasks = new Task<string>[messageCount];
                for (int i = 0; i < tasks.Length; i++)
                {
                    tasks[i] = pub.PublishAsync(i.ToString());
                }
                string[] responseIds = await taskHelper.ConfigureAwait(Task.WhenAll(tasks));
                var ids = new HashSet<string>(responseIds);
                var expected = new HashSet<string>(Enumerable.Range(0, tasks.Length).Select(x => x.ToString()));
                Assert.Equal(expected, ids);
                Assert.Equal(messageCount / 2 - 1, scheduler.WaitCount); // Deterministic, all blocking occuring on one thread.
            });
        }

        [Fact]
        public void BlockingMultiThreaded()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler(threadCount: 11);
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client = new FakePublisher(scheduler, taskHelper, TimeSpan.FromMilliseconds(10));
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 1, batchRequestByteThreshold: 10000, maxOutstandingElementCount: 2, limitExceededBehavior: LimitExceededBehavior.Block);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client }, settings, taskHelper);
            scheduler.Run(async () =>
            {
                var threadCount = 10;
                var messageCountPerThread = 50;
                Task<string[]>[] outerTasks = new Task<string[]>[threadCount];
                for (int i = 0; i < threadCount; i++)
                {
                    int id0 = messageCountPerThread * i;
                    outerTasks[i] = taskHelper.Run(async () =>
                    {
                        Task<string>[] tasks = new Task<string>[messageCountPerThread];
                        for (int j = 0; j < messageCountPerThread; j++)
                        {
                            var id = id0 + j;
                            tasks[j] = pub.PublishAsync(id.ToString());
                        }
                        return await taskHelper.ConfigureAwait(Task.WhenAll(tasks));
                    });
                }
                string[][] allIdsNested = await taskHelper.ConfigureAwait(Task.WhenAll(outerTasks));
                var ids = new HashSet<string>(allIdsNested.SelectMany(x => x));
                var expected = new HashSet<string>(Enumerable.Range(0, threadCount * messageCountPerThread).Select(x => x.ToString()));
                Assert.Equal(expected, ids);
                Assert.InRange(scheduler.WaitCount, 1, int.MaxValue); // Non-deterministic, many threads blocking
            });
        }

        [Fact]
        public void MultipleClients()
        {
            var topicName = new TopicName("FakeProject", "FakeTopic");
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var client0 = new FakePublisher(scheduler, taskHelper, TimeSpan.FromMilliseconds(10));
            var client1 = new FakePublisher(scheduler, taskHelper, TimeSpan.FromMilliseconds(20));
            var settings = MakeSettings(scheduler, batchElementCountThreshold: 1, batchRequestByteThreshold: 10000);
            var pub = new HiPerfPublisherImpl(topicName, new[] { client0, client1 }, settings, taskHelper, 1);
            scheduler.Run(async () =>
            {
                var messageCount = 100;
                Task<string>[] tasks = new Task<string>[messageCount];
                for (int i = 0; i < messageCount; i++)
                {
                    tasks[i] = pub.PublishAsync(i.ToString());
                }
                string[] ids = await taskHelper.ConfigureAwait(Task.WhenAll(tasks));
                Assert.InRange(client0.HandledMessages.Count, client1.HandledMessages.Count * 2 - 1, client1.HandledMessages.Count * 2 + 1);
            });
        }
    }
}
