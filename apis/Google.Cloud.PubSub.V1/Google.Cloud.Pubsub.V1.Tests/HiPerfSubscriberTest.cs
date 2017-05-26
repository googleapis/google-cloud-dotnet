using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using System.Threading;
using Google.Api.Gax;
using Google.Cloud.PubSub.V1.Tasks;
using Google.Protobuf;
using Xunit;
using Google.Cloud.PubSub.V1.Tests.Testing;
using Grpc.Core;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class HiPerfSubscriberTest
    {
        private struct TimedId
        {
            public TimedId(DateTime time, string id) => (Time, Id) = (time, id);

            public DateTime Time { get; }
            public string Id { get; }

            public override string ToString() => $"{{Time:{Time}; Id:{Id}}}";
        }

        private class ServerAction
        {
            public static ServerAction Data(TimeSpan preInterval, IEnumerable<string> msgs) => new ServerAction(preInterval, msgs, null, null);
            public static ServerAction Inf() => new ServerAction(TimeSpan.FromDays(100), null, null, null);
            public static ServerAction BadMoveNext(TimeSpan preInterval, RpcException ex) => new ServerAction(preInterval, null, ex, null);
            public static ServerAction BadCurrent(TimeSpan preInterval, RpcException ex) => new ServerAction(preInterval, null, null, ex);

            private ServerAction(TimeSpan preInterval, IEnumerable<string> msgs, RpcException moveNextEx, RpcException currentEx) =>
                (PreInterval, Msgs, MoveNextEx, CurrentEx) = (preInterval, msgs, moveNextEx, currentEx);

            public TimeSpan PreInterval { get; }
            public IEnumerable<string> Msgs { get; }
            public RpcException MoveNextEx { get; }
            public RpcException CurrentEx { get; }
        }

        private class FakeSubscriber : SubscriberClient
        {
            public static ReceivedMessage MakeReceivedMessage(string msgId, string content) =>
                new ReceivedMessage
                {
                    AckId = msgId,
                    Message = new PubsubMessage
                    {
                        MessageId = msgId,
                        Data = ByteString.CopyFromUtf8(content)
                    }
                };

            private class En : IAsyncEnumerator<StreamingPullResponse>
            {
                public En(IEnumerable<ServerAction> msgs, IScheduler scheduler, TaskHelper taskHelper)
                {
                    _msgsEn = msgs.Select((x, i) => (i, x)).GetEnumerator();
                    _scheduler = scheduler;
                    _taskHelper = taskHelper;
                }

                private readonly IScheduler _scheduler;
                private readonly TaskHelper _taskHelper;

                private readonly IEnumerator<(int Index, ServerAction Action)> _msgsEn;

                public async Task<bool> MoveNext(CancellationToken cancellationToken)
                {
                    if (_msgsEn.MoveNext())
                    {
                        await _taskHelper.ConfigureAwait(_scheduler.Delay(_msgsEn.Current.Action.PreInterval, cancellationToken));
                        if (_msgsEn.Current.Action.MoveNextEx != null)
                        {
                            throw _msgsEn.Current.Action.MoveNextEx;
                        }
                        return true;
                    }
                    return false;
                }

                public StreamingPullResponse Current
                {
                    get
                    {
                        if (_msgsEn.Current.Action.CurrentEx != null)
                        {
                            throw _msgsEn.Current.Action.CurrentEx;
                        }
                        return new StreamingPullResponse
                        {
                            ReceivedMessages = {
                                _msgsEn.Current.Action.Msgs.Select((s, i) => MakeReceivedMessage($"{_msgsEn.Current.Index:D4}.{i:D4}", s))
                            }
                        };
                    }
                }

                public void Dispose()
                {
                }
            }

            private class PullStream : StreamingPullStream
            {
                public PullStream(IEnumerable<ServerAction> msgs, List<TimedId> extends, List<TimedId> acks, List<DateTime> writeCompletes,
                    IScheduler scheduler, IClock clock, TaskHelper taskHelper) =>
                    (_en, _clock, _extends, _acks, _writeCompletes) = (new En(msgs, scheduler, taskHelper), clock, extends, acks, writeCompletes);

                private readonly object _lock = new object();
                private readonly IAsyncEnumerator<StreamingPullResponse> _en;
                private readonly IClock _clock;
                private readonly List<TimedId> _extends;
                private readonly List<TimedId> _acks;
                private readonly List<DateTime> _writeCompletes;

                public override IAsyncEnumerator<StreamingPullResponse> ResponseStream => _en;

                public override Task WriteAsync(StreamingPullRequest message)
                {
                    lock (_lock)
                    {
                        _extends.AddRange(message.ModifyDeadlineAckIds.Select(id => new TimedId(_clock.GetCurrentDateTimeUtc(), id)));
                        _acks.AddRange(message.AckIds.Select(id => new TimedId(_clock.GetCurrentDateTimeUtc(), id)));
                        return Task.FromResult(0);
                    }
                }

                public override Task WriteCompleteAsync()
                {
                    lock (_lock)
                    {
                        _writeCompletes.Add(_clock.GetCurrentDateTimeUtc());
                        return Task.FromResult(0);
                    }
                }
            }

            public FakeSubscriber(IEnumerable<ServerAction> msgs, IScheduler scheduler, IClock clock, TaskHelper taskHelper) =>
                (_msgs, _scheduler, _clock, _taskHelper) = (msgs, scheduler, clock, taskHelper);

            private readonly IEnumerable<ServerAction> _msgs;
            private readonly IScheduler _scheduler;
            private readonly IClock _clock;
            private readonly TaskHelper _taskHelper;

            private readonly List<TimedId> _extends = new List<TimedId>();
            private readonly List<TimedId> _acks = new List<TimedId>();
            private readonly List<DateTime> _writeCompletes = new List<DateTime>();

            public IReadOnlyList<TimedId> Extends => _extends;
            public IReadOnlyList<TimedId> Acks => _acks;
            public IReadOnlyList<DateTime> WriteCompletes => _writeCompletes;

            public override StreamingPullStream StreamingPull(CallSettings callSettings = null, BidirectionalStreamingSettings streamingSettings = null) =>
                new PullStream(_msgs, _extends, _acks, _writeCompletes, _scheduler, _clock, _taskHelper);
        }

        private class Fake : IDisposable
        {
            public TestScheduler Scheduler { get; set; }
            public DateTime Time0 { get; set; }
            public TaskHelper TaskHelper { get; set; }
            public List<FakeSubscriber> Subscribers { get; set; }
            public List<DateTime> ClientShutdowns { get; set; }
            public HiPerfSubscriberImpl Subscriber { get; set; }

            public static Fake Create(IList<IEnumerable<ServerAction>> msgs,
                TimeSpan? ackDeadline = null, TimeSpan? ackExtendWindow = null,
                int? flowMaxElements = null, int? flowMaxBytes = null,
                int clientCount = 1, int threadCount = 1)
            {
                var scheduler = new TestScheduler(threadCount: threadCount);
                TaskHelper taskHelper = scheduler.TaskHelper;
                List<FakeSubscriber> subscribers = new List<FakeSubscriber>();
                List<DateTime> clientShutdowns = new List<DateTime>();
                int msgIndex = -1;
                Task<HiPerfSubscriber.ProvidedSubscriber> SubscriberProvider(CancellationToken ct)
                {
                    var i = Interlocked.Increment(ref msgIndex);
                    if (i >= msgs.Count)
                    {
                        throw new InvalidOperationException("Test subscriber creation failed. Out of (fake) data");
                    }
                    var subscriber = new FakeSubscriber(msgs[i], scheduler, scheduler.Clock, taskHelper);
                    subscribers.Locked(() => subscribers.Add(subscriber));
                    Task Shutdown()
                    {
                        clientShutdowns.Locked(() => clientShutdowns.Add(scheduler.Clock.GetCurrentDateTimeUtc()));
                        return Task.FromResult(0);
                    }
                    return Task.FromResult(new HiPerfSubscriber.ProvidedSubscriber(subscriber, Shutdown));
                }
                var settings = new HiPerfSubscriber.Settings
                {
                    Scheduler = scheduler,
                    StreamAckDeadline = ackDeadline,
                    AckExtensionWindow = ackExtendWindow,
                    FlowControlSettings = new FlowControlSettings
                    {
                        MaxOutstandingElementCount = flowMaxElements,
                        MaxOutstandingRequestBytes = flowMaxBytes,
                    },
                    SubscriberProvider = SubscriberProvider,
                    ClientCount = clientCount,
                };
                var subs = new HiPerfSubscriberImpl(new SubscriptionName("projectid", "subscriptionid"), settings, taskHelper);
                return new Fake
                {
                    Scheduler = scheduler,
                    Time0 = scheduler.Clock.GetCurrentDateTimeUtc(),
                    TaskHelper = taskHelper,
                    Subscribers = subscribers,
                    ClientShutdowns = clientShutdowns,
                    Subscriber = subs,
                };
            }

            public void Dispose()
            {
                Scheduler.Dispose();
            }
        }

        [Theory, CombinatorialData]
        public void ImmediateStop(
            [CombinatorialValues(false, true)] bool hardStop)
        {
            using (var fake = Fake.Create(new[] { new[] { ServerAction.Inf() } }))
            {
                fake.Scheduler.Run(async () =>
                {
                    var doneTask = fake.Subscriber.StartAsync((msg, ct) =>
                    {
                        throw new Exception("Should never get here");
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), CancellationToken.None));
                    var isCancelled = await fake.TaskHelper.ConfigureAwaitHideCancellation(fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(hardStop, isCancelled);
                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Empty(fake.Subscribers[0].Acks);
                    Assert.Empty(fake.Subscribers[0].Extends);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(1) }, fake.Subscribers[0].WriteCompletes);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(1) }, fake.ClientShutdowns);
                });
            }
        }

        [Theory, PairwiseData]
        public void RecvManyMsgsNoErrors(
            [CombinatorialValues(false, true)] bool hardStop,
            [CombinatorialValues(2, 5, 6, 9, 10)] int batchCount,
            [CombinatorialValues(1, 10, 13, 44, 45)] int batchSize,
            [CombinatorialValues(0, 1, 4, 6, 60)] int interBatchIntervalSeconds,
            [CombinatorialValues(0, 1, 5, 8, 21)] int handlerDelaySeconds,
            [CombinatorialValues(2, 8, 11, 34, 102)] int stopAfterSeconds,
            [CombinatorialValues(1, 2, 3, 4, 5, 7, 13)] int threadCount,
            [CombinatorialValues(1, 2, 3, 4, 8, 16, 33)] int clientCount)
        {
            var expectedCompletedBatches = interBatchIntervalSeconds == 0
                ? (hardStop && stopAfterSeconds < handlerDelaySeconds ? 0 : batchCount)
                : Math.Max(0, stopAfterSeconds - (hardStop ? handlerDelaySeconds : 0)) / interBatchIntervalSeconds;
            var expectedMsgCount = Math.Min(expectedCompletedBatches, batchCount) * batchSize * clientCount;

            var msgss = Enumerable.Range(0, batchCount)
                .Select(batchIndex =>
                    ServerAction.Data(TimeSpan.FromSeconds(interBatchIntervalSeconds), Enumerable.Range(0, batchSize).Select(i => (batchIndex * batchSize + i).ToString())))
                .Concat(new[] { ServerAction.Inf() });
            using (var fake = Fake.Create(Enumerable.Repeat(msgss, clientCount).ToList(), clientCount: clientCount, threadCount: threadCount))
            {
                fake.Scheduler.Run(async () =>
                {
                    List<string> handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(handlerDelaySeconds), ct));
                        lock (handledMsgs)
                        {
                            handledMsgs.Add(msg.Data.ToStringUtf8());
                        }
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(stopAfterSeconds) + TimeSpan.FromSeconds(0.5), CancellationToken.None));
                    var isCancelled = await fake.TaskHelper.ConfigureAwaitHideCancellation(fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(hardStop, isCancelled);
                    Assert.Equal(clientCount, fake.Subscribers.Count);
                    Assert.Equal(expectedMsgCount, handledMsgs.Locked(() => handledMsgs.Count));
                    Assert.Equal(expectedMsgCount, fake.Subscribers.Sum(x => x.Acks.Count));
                    Assert.Equal(Enumerable.Repeat(1, clientCount).ToArray(), fake.Subscribers.Select(x => x.WriteCompletes.Count).ToArray());
                    Assert.Equal(clientCount, fake.ClientShutdowns.Count);
                });
            }
        }

        [Theory, PairwiseData]
        public void FlowControlElements(
            [CombinatorialValues(false, true)] bool hardStop,
            [CombinatorialValues(1, 2, 3)] int clientCount,
            [CombinatorialValues(2, 9, 25, 600)] int stopAfterSeconds,
            [CombinatorialValues(1, 2, 3, 4, 5, 10, 21, 99, 148)] int flowMaxElements,
            [CombinatorialValues(1, 10, 14, 18, 25, 39, 81, 255)] int flowMaxBytes)
        {
            const int msgsPerClient = 100;
            var oneMsgByteCount = FakeSubscriber.MakeReceivedMessage("0000.0000", "0000").CalculateSize();
            var combinedFlowMaxElements = Math.Min(flowMaxElements, flowMaxBytes / oneMsgByteCount + 1);
            var expectedMsgCount = Math.Min(msgsPerClient * clientCount, combinedFlowMaxElements * stopAfterSeconds + (hardStop ? 0 : combinedFlowMaxElements));
            var msgss = Enumerable.Range(0, msgsPerClient).Select(i => ServerAction.Data(TimeSpan.Zero, new[] { i.ToString("D4") }));
            using (var fake = Fake.Create(Enumerable.Repeat(msgss, clientCount).ToList(), flowMaxElements: flowMaxElements, flowMaxBytes: flowMaxBytes, clientCount: clientCount, threadCount: 3))
            {
                fake.Scheduler.Run(async () =>
                {
                    List<string> handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        lock (handledMsgs)
                        {
                            handledMsgs.Add(msg.Data.ToStringUtf8());
                        }
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(stopAfterSeconds) + TimeSpan.FromSeconds(0.5), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(expectedMsgCount, handledMsgs.Count);
                });
            }
        }

        [Fact]
        public void UserHandlerFaults()
        {
            var msgs = Enumerable.Repeat(ServerAction.Data(TimeSpan.Zero, new[] { "m" }), 10);
            using (var fake = Fake.Create(new[] { msgs }))
            {
                fake.Scheduler.Run(async () =>
                {
                    var handledMsgs = new List<string>();
                    int count = 0;
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        if (Interlocked.Increment(ref count) % 2 == 0)
                        {
                            throw new NotSupportedException("User handler fault!");
                        }
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(Enumerable.Repeat("m", 5), handledMsgs);
                });
            }
        }

        [Fact]
        public void ServerFaultsRecoverable()
        {
            var zero = TimeSpan.Zero;
            var recoverableEx = new RpcException(new Status(StatusCode.DeadlineExceeded, ""), "");
            var msgs = new[]
            {
                new[] { ServerAction.Data(zero, new[] { "1" }), ServerAction.BadMoveNext(zero, recoverableEx) },
                new[] { ServerAction.Data(zero, new[] { "2" }), ServerAction.BadCurrent(zero, recoverableEx) },
                new[] { ServerAction.Data(zero, new[] { "3" }), ServerAction.Inf() }
            };
            using (var fake = Fake.Create(msgs))
            {
                fake.Scheduler.Run(async () =>
                {
                    var handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(new[] { "1", "2", "3" }, handledMsgs);
                });
            }
        }

        [Theory, PairwiseData]
        public void ServerFaultsUnrecoverable(
            [CombinatorialValues(true, false)] bool badMoveNext,
            [CombinatorialValues(1, 2, 3, 4, 10)] int clientCount,
            [CombinatorialValues(1, 3, 9, 14)] int threadCount)
        {
            var zero = TimeSpan.Zero;
            var unrecoverableEx = new RpcException(new Status(StatusCode.Unimplemented, ""), "");
            var failure = badMoveNext ? ServerAction.BadMoveNext(zero, unrecoverableEx) : ServerAction.BadCurrent(zero, unrecoverableEx);
            // Client 1 will recv "1", then crash unrecoverably
            // Client(s) 2(+) will just block; this tests that non-crashed clients are shutdown
            var msgs = new[] { new[] { ServerAction.Data(zero, new[] { "1" }), failure } }
                .Concat(Enumerable.Repeat<IEnumerable<ServerAction>>(new[] { ServerAction.Inf() }, clientCount - 1))
                .ToList();
            using (var fake = Fake.Create(msgs, clientCount: clientCount, threadCount: threadCount))
            {
                fake.Scheduler.Run(async () =>
                {
                    var handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(unrecoverableEx, ex.InnerException ?? ex);
                    Assert.Equal(new[] { "1" }, handledMsgs);
                    Assert.Equal(clientCount, fake.ClientShutdowns.Count);
                });
            }
        }

        [Fact]
        public void OnlyOneStart()
        {
            var msgs = new[] { new[] { ServerAction.Inf() } };
            using (var fake = Fake.Create(msgs))
            {
                fake.Scheduler.Run(() =>
                {
                    fake.Subscriber.StartAsync((msg, ct) => throw new Exception());
                    // Only allowed to start a HiPerfSubscriber once.
                    Assert.Throws<InvalidOperationException>((Action)(() => fake.Subscriber.StartAsync((msg, ct) => Task.FromResult(HiPerfSubscriber.Reply.Ack))));
                });
            }
        }

        [Fact]
        public void LeaseExtension()
        {
            var msgs = new[] { new[] {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.FromSeconds(10), new[] { "2" }),
                ServerAction.Inf()
            } };
            using (var fake = Fake.Create(msgs, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10)))
            {
                fake.Scheduler.Run(async () =>
                {
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                        Task unusedTask = fake.Subscriber.StopAsync(CancellationToken.None);
                        return HiPerfSubscriber.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(doneTask);
                    var t0 = fake.Time0;
                    TimeSpan S(int seconds) => TimeSpan.FromSeconds(seconds);
                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Equal(new[] { t0 + S(20), t0 + S(30), t0 + S(40), t0 + S(50), t0 + S(60), t0 + S(70) }, fake.Subscribers[0].Extends.Select(x => x.Time));
                    Assert.Equal(new[] { t0 + S(70), t0 + S(80) }, fake.Subscribers[0].Acks.Select(x => x.Time));
                });
            }

        }
    }
}
