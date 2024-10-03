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
using Google.Apis.Auth.OAuth2.Responses;
using Google.Cloud.PubSub.V1.Tasks;
using Google.Cloud.PubSub.V1.Tests.Tasks;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.PubSub.V1.Tests
{
    public class SubscriberClientTest
    {
        private struct TimedId
        {
            public TimedId(DateTime time, string id)
            {
                Time = time;
                Id = id;
            }

            public DateTime Time { get; }
            public string Id { get; }

            public override string ToString() => $"{{Time:{Time}; Id:{Id}}}";
        }

        private class ServerAction
        {
            public static ServerAction Data(TimeSpan preInterval, IEnumerable<string> msgs, int? deliveryAttempt = null) => new ServerAction(preInterval, msgs, null, null, deliveryAttempt);
            public static ServerAction Inf() => new ServerAction(TimeSpan.FromDays(365), null, null, null);
            public static ServerAction BadMoveNext(TimeSpan preInterval, RpcException ex) => new ServerAction(preInterval, null, ex, null);
            public static ServerAction BadCurrent(TimeSpan preInterval, RpcException ex) => new ServerAction(preInterval, null, null, ex);

            private ServerAction(TimeSpan preInterval, IEnumerable<string> msgs, RpcException moveNextEx, RpcException currentEx, int? deliveryAttempt = null)
            {
                PreInterval = preInterval;
                Msgs = msgs;
                MoveNextEx = moveNextEx;
                CurrentEx = currentEx;
                DeliveryAttempt = deliveryAttempt;
            }

            public TimeSpan PreInterval { get; }
            public IEnumerable<string> Msgs { get; }
            public RpcException MoveNextEx { get; }
            public RpcException CurrentEx { get; }
            public int? DeliveryAttempt { get; }

            /// <summary>
            /// Convenience method to create a sequence of server actions.
            /// The return type helps when this is passed into LINQ methods.
            /// </summary>
            public static IEnumerable<ServerAction> Sequence(params ServerAction[] actions) => actions;
        }

        // Class to simulate exceptions in Acknowledgement and/or ModifyAcknowledgementDeadline calls.
        private class AckModifyAckDeadlineAction
        {
            public static AckModifyAckDeadlineAction Data(Exception ex, int numberOfFailures, bool onAck, bool onNack, bool onExtend) => new AckModifyAckDeadlineAction(ex, numberOfFailures, onAck, onNack, onExtend);
            public static AckModifyAckDeadlineAction BadAck(Exception ex, int numberOfFailures) => new AckModifyAckDeadlineAction(ex, numberOfFailures, true, false, false);
            public static AckModifyAckDeadlineAction BadNack(Exception ex, int numberOfFailures) => new AckModifyAckDeadlineAction(ex, numberOfFailures, false, true, false);
            public static AckModifyAckDeadlineAction BadExtend(Exception ex, int numberOfFailures) => new AckModifyAckDeadlineAction(ex, numberOfFailures, false, false, true);

            /// <summary>
            /// The exception to be thrown in Ack/ModifyAckDeadline call.
            /// </summary>
            /// <value>
            /// The exception.
            /// </value>
            public Exception Exception { get; }

            /// <summary>
            /// The number of failures to be simulated in Ack/ModifyAckDeadline call.
            /// </summary>
            /// <value>
            /// The number of failures.
            /// </value>
            public int NumberOfFailures { get; }

            /// <summary>
            /// Gets a value indicating whether the exception should be thrown in Acknowledge call.
            /// </summary>
            /// <value>
            ///   <c>true</c> if [on ack]; otherwise, <c>false</c>.
            /// </value>
            public bool OnAck { get; }

            /// <summary>
            /// Gets a value indicating whether the exception should be thrown in Nack (Negative acknowledgement) call.
            /// </summary>
            /// <value>
            ///   <c>true</c> if [on nack]; otherwise, <c>false</c>.
            /// </value>
            public bool OnNack { get; }

            /// <summary>
            /// Gets a value indicating whether the exception should be thrown in ModifyAcknowledgementDeadline call for extends.
            /// </summary>
            /// <value>
            ///   <c>true</c> if [on extend]; otherwise, <c>false</c>.
            /// </value>
            public bool OnExtend { get; }

            private AckModifyAckDeadlineAction(Exception exception, int numberOfFailures, bool onAck, bool onNack, bool onExtend)
            {
                Exception = exception;
                NumberOfFailures = numberOfFailures;
                OnAck = onAck;
                OnNack = onNack;
                OnExtend = onExtend;
            }
        }

        private class FakeSubscriberServiceApiClient : SubscriberServiceApiClient
        {
            public static ReceivedMessage MakeReceivedMessage(string msgId, string content, int? deliveryAttempt = null) =>
                new ReceivedMessage
                {
                    AckId = msgId,
                    Message = new PubsubMessage
                    {
                        MessageId = msgId,
                        OrderingKey = content.Contains('|') ? content.Split('|')[0] : "",
                        Data = ByteString.CopyFromUtf8(content),
                    },
                    DeliveryAttempt = deliveryAttempt ?? 0,
                };

            public static string MakeMsgId(int batchIndex, int msgIndex) => $"{batchIndex:D4}.{msgIndex:D4}";

            private class En : IAsyncStreamReader<StreamingPullResponse>
            {
                public En(
                    IEnumerable<ServerAction> msgs, IScheduler scheduler, TaskHelper taskHelper, IClock clock,
                    bool useMsgAsId, CancellationToken? ct, bool isExactlyOnceDelivery, bool messageOrderingEnabled)
                {
                    _msgsEn = msgs.Select((x, i) => (i, x)).GetEnumerator();
                    _scheduler = scheduler;
                    _taskHelper = taskHelper;
                    _clock = clock;
                    _useMsgAsId = useMsgAsId;
                    _ct = ct ?? CancellationToken.None;
                    _isExactlyOnceDelivery = isExactlyOnceDelivery;
                    _messageOrderingEnabled = messageOrderingEnabled;
                }

                private readonly IScheduler _scheduler;
                private readonly TaskHelper _taskHelper;
                private readonly IClock _clock;
                private readonly bool _useMsgAsId;
                private readonly bool _isExactlyOnceDelivery;
                private readonly bool _messageOrderingEnabled;
                private readonly CancellationToken _ct;

                private readonly IEnumerator<(int Index, ServerAction Action)> _msgsEn;

                public async Task<bool> MoveNext(CancellationToken cancellationToken)
                {
                    if (_msgsEn.MoveNext())
                    {
                        // TODO: This is not correct. The real server cancels the entire call if this cancellationtoken is cancelled.
                        using (var cts = CancellationTokenSource.CreateLinkedTokenSource(_ct, cancellationToken))
                        {
                            var isCancelled = await _taskHelper.ConfigureAwaitHideCancellation(
                                () => _scheduler.Delay(_msgsEn.Current.Action.PreInterval, cts.Token));
                            if (isCancelled)
                            {
                                // This mimics behaviour of a real server
                                throw new RpcException(new Status(StatusCode.Cancelled, "Operation cancelled"));
                            }
                            if (_msgsEn.Current.Action.MoveNextEx != null)
                            {
                                throw _msgsEn.Current.Action.MoveNextEx;
                            }
                            return true;
                        }
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
                        var messages = _msgsEn.Current.Action.Msgs.Select((s, i) =>
                            MakeReceivedMessage(_useMsgAsId ? s : MakeMsgId(_msgsEn.Current.Index, i), s, _msgsEn.Current.Action.DeliveryAttempt));
                        return new StreamingPullResponse
                        {
                            ReceivedMessages = { messages },
                            SubscriptionProperties = new()
                            {
                                ExactlyOnceDeliveryEnabled = _isExactlyOnceDelivery,
                                MessageOrderingEnabled = _messageOrderingEnabled
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
                public PullStream(TimeSpan writeAsyncPreDelay,
                    IEnumerable<ServerAction> msgs, List<DateTime> writeCompletes, List<DateTime> streamPings,
                    IScheduler scheduler, IClock clock, TaskHelper taskHelper, bool useMsgAsId, CancellationToken? ct,
                    bool isExactlyOnceDelivery, bool messageOrderingEnabled)
                {
                    _taskHelper = taskHelper;
                    _scheduler = scheduler;
                    _writeAsyncPreDelay = writeAsyncPreDelay; // delay within the WriteAsync() method. Simulating network or server slowness.
                    var responseStream = new En(msgs, scheduler, taskHelper, clock, useMsgAsId, ct, isExactlyOnceDelivery, messageOrderingEnabled);
                    // Set disposeAction parameter of AsyncDuplexStreamingCall to No-op as it is called internally while disposing stream.
                    _call = new AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse>(null, responseStream, Task.FromResult(new Metadata()), null, null, () => { });
                    _clock = clock;
                    _writeCompletes = writeCompletes;
                    _streamPings = streamPings;
                    _isExactlyOnceDelivery = isExactlyOnceDelivery;
                }

                private readonly object _lock = new object();
                private readonly TaskHelper _taskHelper;
                private readonly IScheduler _scheduler;
                private readonly TimeSpan _writeAsyncPreDelay;
                private readonly AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> _call;
                private readonly IClock _clock;
                private readonly List<DateTime> _writeCompletes;
                private readonly List<DateTime> _streamPings;
                private readonly bool _isExactlyOnceDelivery;

                public override AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> GrpcCall => _call;

                public override Task WriteAsync(StreamingPullRequest message)
                {
                    if (message.ModifyDeadlineAckIds.Count != 0 || message.AckIds.Count != 0)
                    {
                        throw new InvalidOperationException("WriteAsync must not modify deadlines or send acks/nacks.");
                    }
                    if (Equals(message, new StreamingPullRequest()))
                    {
                        // An empty message is a ping
                        lock (_lock)
                        {
                            _streamPings.Add(_clock.GetCurrentDateTimeUtc());
                        }
                    }
                    return Task.FromResult(0);
                }

                public override Task WriteCompleteAsync()
                {
                    lock (_lock)
                    {
                        _writeCompletes.Add(_clock.GetCurrentDateTimeUtc());
                    }
                    return Task.FromResult(0);
                }
            }

            public FakeSubscriberServiceApiClient(
                IEnumerator<IEnumerable<ServerAction>> msgsEn, IScheduler scheduler, IClock clock,
                TaskHelper taskHelper, TimeSpan writeAsyncPreDelay, bool useMsgAsId,
                AckModifyAckDeadlineAction ackModifyAckDeadlineAction, bool isExactlyOnceDelivery, bool messageOrderingEnabled)
            {
                _msgsEn = msgsEn;
                _scheduler = scheduler;
                _clock = clock;
                _taskHelper = taskHelper;
                _writeAsyncPreDelay = writeAsyncPreDelay;
                _useMsgAsId = useMsgAsId;
                _ackModifyAckDeadlineAction = ackModifyAckDeadlineAction;
                _numberOfAckModifyAckDeadlineFailures = 0;
                _isExactlyOnceDelivery = isExactlyOnceDelivery;
                _messageOrderingEnabled = messageOrderingEnabled;
            }

            private readonly object _lock = new object();
            private readonly IEnumerator<IEnumerable<ServerAction>> _msgsEn;
            private readonly IScheduler _scheduler;
            private readonly IClock _clock;
            private readonly TaskHelper _taskHelper;
            private readonly TimeSpan _writeAsyncPreDelay; // Simulates slow network or server
            private readonly bool _useMsgAsId;
            private readonly AckModifyAckDeadlineAction _ackModifyAckDeadlineAction; // Simulates Ack ModifyAckDeadline errors.
            private readonly bool _isExactlyOnceDelivery;
            private readonly bool _messageOrderingEnabled;
            private int _numberOfAckModifyAckDeadlineFailures;

            private readonly List<TimedId> _extends = new List<TimedId>();
            private readonly List<TimedId> _acks = new List<TimedId>();
            private readonly List<TimedId> _nacks = new List<TimedId>();
            private readonly List<DateTime> _writeCompletes = new List<DateTime>();
            private readonly List<DateTime> _streamPings = new List<DateTime>();
            private readonly List<DateTime> _streamingPulls = new List<DateTime>();

            public IReadOnlyList<TimedId> Extends => _extends;
            public IReadOnlyList<TimedId> Acks => _acks;
            public IReadOnlyList<TimedId> Nacks => _nacks;
            public IReadOnlyList<DateTime> WriteCompletes => _writeCompletes;
            public IReadOnlyList<DateTime> StreamPings => _streamPings;
            public IReadOnlyList<DateTime> StreamingPulls => _streamingPulls;

            public override StreamingPullStream StreamingPull(
                CallSettings callSettings = null, BidirectionalStreamingSettings streamingSettings = null)
            {
                lock (_lock)
                {
                    _streamingPulls.Add(_clock.GetCurrentDateTimeUtc());
                }
                lock (_msgsEn)
                {
                    if (!_msgsEn.MoveNext())
                    {
                        throw new InvalidOperationException("Test subscriber creation failed. Run out of (fake) data");
                    }
                    var msgs = _msgsEn.Current;
                    return new PullStream(_writeAsyncPreDelay, msgs, _writeCompletes, _streamPings,
                        _scheduler, _clock, _taskHelper, _useMsgAsId, callSettings?.CancellationToken,
                        _isExactlyOnceDelivery, _messageOrderingEnabled);
                }
            }

            public override async Task AcknowledgeAsync(SubscriptionName subscription, IEnumerable<string> ackIds, CancellationToken cancellationToken)
            {
                if (_writeAsyncPreDelay != TimeSpan.Zero)
                {
                    await _taskHelper.ConfigureAwait(_scheduler.Delay(_writeAsyncPreDelay, CancellationToken.None));
                }

                // Simulate Ack failure if _ackModifyAckDeadlineAction is specified.
                // For non-exactly once delivery subscriptions, all gRPC exceptions from this method are fire and forget, so no exception should propagate to the caller.
                // For exactly once delivery, no exception is propagated to the caller.
                // Non-gRPC exceptions will propagate to the caller.
                if (_ackModifyAckDeadlineAction?.Exception != null && _ackModifyAckDeadlineAction.OnAck)
                {
                    MaybeThrowException(ackIds);
                }

                lock (_lock)
                {
                    _acks.AddRange(ackIds.Select(id => new TimedId(_clock.GetCurrentDateTimeUtc(), id)));
                }
            }

            public override async Task ModifyAckDeadlineAsync(SubscriptionName subscription, IEnumerable<string> ackIds, int ackDeadlineSeconds, CancellationToken cancellationToken)
            {
                if (_writeAsyncPreDelay != TimeSpan.Zero)
                {
                    await _taskHelper.ConfigureAwait(_scheduler.Delay(_writeAsyncPreDelay, CancellationToken.None));
                }

                // Simulate ModifyAckDeadline failure if _ackModifyAckDeadlineAction is specified.
                // For non-exactly once delivery subscriptions, all gRPC exceptions from this method are fire and forget, so no exception should propagate to the caller.
                // For exactly once delivery, no exception is propagated to the caller.
                // Non-gRPC exceptions will propagate to the caller.
                if (_ackModifyAckDeadlineAction?.Exception != null && ((ackDeadlineSeconds == 0 && _ackModifyAckDeadlineAction.OnNack)
                    || (ackDeadlineSeconds != 0 && _ackModifyAckDeadlineAction.OnExtend)))
                {
                    MaybeThrowException(ackIds);
                }

                lock (_lock)
                {
                    var ids = ackDeadlineSeconds == 0 ? _nacks : _extends;
                    ids.AddRange(ackIds.Select(id => new TimedId(_clock.GetCurrentDateTimeUtc(), id)));
                }
            }

            /// <summary>
            /// This method does the following:
            /// <list type="bullet">
            /// <item>
            /// If a non-gRPC exception is specified in <see cref="_ackModifyAckDeadlineAction.Exception"/>,
            /// it always throws exception for specified number of times.
            /// </item>
            /// <item>
            /// If subscription under test is exactly once delivery, it checks if there are temporary or permanent failures
            /// associated with given <paramref name="ackIds"/> in the specified exception <see cref="_ackModifyAckDeadlineAction.Exception"/>.
            /// If not, it returns. Otherwise, it throws the specified exception <see cref="_ackModifyAckDeadlineAction.Exception"/>
            /// for <see cref="_numberOfAckModifyAckDeadlineFailures"/> times.
            /// </item>
            /// <item>
            /// If subscription under test is not exactly once delivery, it will always throw the specified exception
            /// <see cref="_ackModifyAckDeadlineAction.Exception"/> for <see cref="_numberOfAckModifyAckDeadlineFailures"/> times.
            /// </item>
            /// </list>
            /// </summary>
            /// <param name="ackIds">The list of acknowledgement ids being processed.</param>
            private void MaybeThrowException(IEnumerable<string> ackIds)
            {
                // This method simulates exception thrown from AcknowledgeAsync or ModifyDeadlineAsync methods based on available test parameters.
                // For non exactly once delivery, this method always throws an exception for the specified number of times
                // as _numberOfAckModifyAckDeadlineFailures.
                // For exactly once delivery, this method should throw exception for following scenarios:
                //  1. If the entire request failed based on gRPC status code.
                //  2. There is a temporary or permanent failure associated with the message ID.
                //  3. There is a non-gRPC exception.
                if (_isExactlyOnceDelivery && _ackModifyAckDeadlineAction.Exception is RpcException rpcException)
                {
                    // Check for temporary errors.
                    var isTemporaryFailure = AckError.ShouldRetryAll(rpcException)
                        || (rpcException.GetErrorInfo()?.Metadata.Any(j => ackIds.Contains(j.Key) && j.Value.StartsWith("TRANSIENT_FAILURE_", StringComparison.Ordinal)) ?? false);

                    // Check for permanent errors.
                    var isPermanentFailure = (rpcException.StatusCode is StatusCode.FailedPrecondition or StatusCode.InvalidArgument or StatusCode.PermissionDenied)
                        || (rpcException.GetErrorInfo()?.Metadata.Any(j => ackIds.Contains(j.Key) && j.Value.StartsWith("PERMANENT_FAILURE_", StringComparison.Ordinal)) ?? false);
                    if (!isTemporaryFailure && !isPermanentFailure)
                    {
                        return;
                    }
                }

                // If we are here, we throw the specified exception.
                if (Interlocked.CompareExchange(ref _numberOfAckModifyAckDeadlineFailures, _ackModifyAckDeadlineAction.NumberOfFailures, _ackModifyAckDeadlineAction.NumberOfFailures) < _ackModifyAckDeadlineAction.NumberOfFailures)
                {
                    Interlocked.Increment(ref _numberOfAckModifyAckDeadlineFailures);
                    throw _ackModifyAckDeadlineAction.Exception;
                }
            }
        }

        /// <summary>
        /// Test implementation of <see cref="SubscriptionHandler"/>.
        /// This implementation is used to test the exactly once flow to get the acknowledgement status of successful and permanent failed messages.
        /// However, handler is backward compatible and can be used with non-exactly once delivery flow as well.
        /// </summary>
        internal sealed class TestSubscriptionHandler : SubscriptionHandler
        {
            private readonly bool _ackOrNack;

            internal List<AckNackResponse> Responses { get; }

            internal TestSubscriptionHandler(bool ackOrNack)
            {
                _ackOrNack = ackOrNack;
                Responses = new List<AckNackResponse>();
            }

            public override Task<SubscriberClient.Reply> HandleMessage(PubsubMessage message, CancellationToken cancellationToken) =>
                Task.FromResult(_ackOrNack ? SubscriberClient.Reply.Ack : SubscriberClient.Reply.Nack);

            public override void HandleAckResponses(IReadOnlyList<AckNackResponse> responses) =>
                // For exactly once delivery, only messages that succeed or fail permanently appear here, i.e., only messages whose status is finalized.
                // The messages with temporary failures whose status may change in future appear here only when they succeed or fail permanently.
                // In non exactly once delivery, we show status of every message as Success because every message acknowledgement is treated as fire and forget.
                Responses.Locked(() => Responses.AddRange(responses.Where(item => !Responses.Any(j => j.MessageId == item.MessageId))));

            public override void HandleNackResponses(IReadOnlyList<AckNackResponse> responses) =>
                // For exactly once delivery, only messages that succeed or fail permanently appear here, i.e., only messages whose status is finalized.
                // The messages with temporary failures whose status may change in future appear here only when they succeed or fail permanently.
                // In non exactly once delivery, we show status of every message as Success because every message acknowledgement is treated as fire and forget.
                Responses.Locked(() => Responses.AddRange(responses.Where(item => !Responses.Any(j => j.MessageId == item.MessageId))));
        }

        private class Fake : IDisposable
        {
            public TestScheduler Scheduler { get; set; }
            public DateTime Time0 { get; set; }
            public TaskHelper TaskHelper { get; set; }
            public List<FakeSubscriberServiceApiClient> Subscribers { get; set; }
            public List<DateTime> ClientShutdowns { get; set; }
            public SubscriberClientImpl Subscriber { get; set; }

            /// <summary>
            /// Convenience method to call <see cref="Create"/> with a client count of 1, and a single sequence
            /// of server actions.
            /// </summary>
            public static Fake CreateClientForSingleResponseStream(IEnumerable<ServerAction> msgs,
                TimeSpan? ackDeadline = null, TimeSpan? ackExtendWindow = null,
                int? flowMaxElements = null, int? flowMaxBytes = null,
                int threadCount = 1, TimeSpan? writeAsyncPreDelay = null,
                bool useMsgAsId = false, AckModifyAckDeadlineAction ackModifyAckDeadlineAction = null,
                bool isExactlyOnceDelivery = false, bool messageOrderingEnabled = false, TimeSpan? disposeTimeout = null) =>
                Create(new[] { msgs }, ackDeadline, ackExtendWindow, flowMaxElements, flowMaxBytes, clientCount: 1, threadCount,
                    writeAsyncPreDelay, useMsgAsId, ackModifyAckDeadlineAction, isExactlyOnceDelivery, messageOrderingEnabled, disposeTimeout);

            public static Fake Create(IReadOnlyList<IEnumerable<ServerAction>> msgs,
                TimeSpan? ackDeadline = null, TimeSpan? ackExtendWindow = null,
                int? flowMaxElements = null, int? flowMaxBytes = null,
                int clientCount = 1, int threadCount = 1, TimeSpan? writeAsyncPreDelay = null,
                bool useMsgAsId = false, AckModifyAckDeadlineAction ackModifyAckDeadlineAction = null,
                bool isExactlyOnceDelivery = false, bool messageOrderingEnabled = false, TimeSpan? disposeTimeout = null)
            {
                var scheduler = new TestScheduler(threadCount: threadCount);
                TaskHelper taskHelper = scheduler.TaskHelper;
                List<DateTime> clientShutdowns = new List<DateTime>();
                var msgEn = msgs.GetEnumerator();
                var clients = Enumerable.Range(0, clientCount)
                    .Select(_ => new FakeSubscriberServiceApiClient(
                        msgEn, scheduler, scheduler.Clock, taskHelper, writeAsyncPreDelay ?? TimeSpan.Zero, useMsgAsId,
                        ackModifyAckDeadlineAction, isExactlyOnceDelivery, messageOrderingEnabled))
                    .ToList();
                var settings = new SubscriberClient.Settings
                {
                    Clock = scheduler.Clock,
                    Scheduler = scheduler,
                    AckDeadline = ackDeadline,
                    AckExtensionWindow = ackExtendWindow,
                    FlowControlSettings = new FlowControlSettings(flowMaxElements, flowMaxBytes),
                    DisposeTimeout = disposeTimeout
                };
                Task Shutdown()
                {
                    clientShutdowns.Locked(() => clientShutdowns.Add(scheduler.Clock.GetCurrentDateTimeUtc()));
                    return Task.FromResult(0);
                }
                var subs = new SubscriberClientImpl(new SubscriptionName("projectid", "subscriptionid"), clients, settings, Shutdown, taskHelper);
                return new Fake
                {
                    Scheduler = scheduler,
                    Time0 = scheduler.Clock.GetCurrentDateTimeUtc(),
                    TaskHelper = taskHelper,
                    Subscribers = clients,
                    ClientShutdowns = clientShutdowns,
                    Subscriber = subs,
                };
            }

            public void Dispose()
            {
                Scheduler.Dispose();
            }
        }

        /// <summary>
        /// Gets the <see cref="RpcException"/> with temporary and permanent errors.
        /// </summary>
        /// <param name="errorInfo">The <see cref="Rpc.ErrorInfo"/> instance with metadata populated with message id and corresponding failure.
        /// Can be null, in which case the default <see cref="Rpc.ErrorInfo"/> initialized inside in this method is used,
        /// which marks message id 2 as temporary failure and message id 3 as permanent failure.</param>
        /// <returns>The <see cref="RpcException"/> with temporary and permanent errors.</returns>
        /// <remarks>
        /// This test method is useful to test exactly once subscription only.
        /// </remarks>
        private static RpcException GetExactlyOnceDeliveryMixedException(Rpc.ErrorInfo errorInfo = null)
        {
            // If caller has not initialized and sent the parameter, do it here (mostly for reuse in tests).
            errorInfo ??= new Rpc.ErrorInfo
            {
                Domain = "pubsub.googleapis.com",
                Reason = "broken",
                Metadata =
                {
                    // Message 2 is temporary failure, 3 is permanent failure.
                    { "2", "TRANSIENT_FAILURE_UNORDERED_ACK_ID" },
                    { "3", "PERMANENT_FAILURE_INVALID_ACK_ID" }
                }
            };

            var status = new Google.Rpc.Status { Details = { Any.Pack(errorInfo) } };
            var metadata = new Metadata { { "grpc-status-details-bin", status.ToByteArray() } };
            return new RpcException(new Status(StatusCode.OK, ""), metadata);
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
                    var isCancelled = await fake.TaskHelper.ConfigureAwaitHideCancellation(
                        () => fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(hardStop, isCancelled);
                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Empty(fake.Subscribers[0].Acks);
                    Assert.Empty(fake.Subscribers[0].Nacks);
                    Assert.Empty(fake.Subscribers[0].Extends);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(1) }, fake.Subscribers[0].WriteCompletes);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(3) }, fake.ClientShutdowns);
                });
            }
        }

        [Fact]
        public void StopBeforeStart()
        {
            using (var fake = Fake.Create(new[] { new[] { ServerAction.Inf() } }))
            {
                fake.Scheduler.Run(async () =>
                {
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), CancellationToken.None));
                    var exception = await Assert.ThrowsAsync<InvalidOperationException>(
                        async () => await fake.TaskHelper.ConfigureAwaitHideCancellation(
                            () => fake.Subscriber.StopAsync(TimeSpan.FromHours(1))));
                    Assert.Equal("Can only stop a started instance.", exception.Message);
                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Empty(fake.Subscribers[0].Acks);
                    Assert.Empty(fake.Subscribers[0].Nacks);
                    Assert.Empty(fake.Subscribers[0].Extends);
                    Assert.Equal(Array.Empty<DateTime>(), fake.Subscribers[0].WriteCompletes);
                    Assert.Equal(Array.Empty<DateTime>(), fake.ClientShutdowns);
                });
            }
        }

        // The test is similar to ImmediateStop but checks that calling DisposeAsync() instead of StopAsync() works.
        // It also tests that DisposeAsync() or StopAsync() can be called multiple times, without throwing exception.
        [Fact]
        public void Dispose()
        {
            using (var fake = Fake.CreateClientForSingleResponseStream(new[] { ServerAction.Inf() }))
            {
                fake.Scheduler.Run(async () =>
                {
                    var doneTask = fake.Subscriber.StartAsync((msg, ct) =>
                    {
                        throw new Exception("Should never get here");
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), CancellationToken.None));
                    // Dispose the subscriber.
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(
                        () => fake.Subscriber.DisposeAsync().AsTask());
                    // Call DisposeAsync again. It shouldn't throw an exception.
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(
                       () => fake.Subscriber.DisposeAsync().AsTask());
                    // Call StopAsync. It shouldn't throw an exception.
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(
                       () => fake.Subscriber.StopAsync(CancellationToken.None));

                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Empty(fake.Subscribers[0].Acks);
                    Assert.Empty(fake.Subscribers[0].Nacks);
                    Assert.Empty(fake.Subscribers[0].Extends);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(1) }, fake.Subscribers[0].WriteCompletes);
                    Assert.Equal(new[] { fake.Time0 + TimeSpan.FromSeconds(3) }, fake.ClientShutdowns);
                });
            }
        }

        [Fact]
        public void DisposeBeforeStart()
        {
            using (var fake = Fake.CreateClientForSingleResponseStream(new[] { ServerAction.Inf() }))
            {
                fake.Scheduler.Run(async () =>
                {
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), CancellationToken.None));
                    // Dispose the subscriber.
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(
                        () => fake.Subscriber.DisposeAsync().AsTask());
                    // Call DisposeAsync again. It shouldn't throw an exception.
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(
                       () => fake.Subscriber.DisposeAsync().AsTask());

                    Assert.Equal(1, fake.Subscribers.Count);
                    Assert.Empty(fake.Subscribers[0].Acks);
                    Assert.Empty(fake.Subscribers[0].Nacks);
                    Assert.Empty(fake.Subscribers[0].Extends);
                    Assert.Equal(Array.Empty<DateTime>(), fake.Subscribers[0].WriteCompletes);
                    Assert.Equal(Array.Empty<DateTime>(), fake.ClientShutdowns);
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
            var expectedAcks = Enumerable.Range(0, batchCount)
                .SelectMany(batchIndex => Enumerable.Range(0, batchSize).Select(msgIndex => FakeSubscriberServiceApiClient.MakeMsgId(batchIndex, msgIndex)))
                .Take(expectedMsgCount / clientCount)
                .OrderBy(x => x);

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
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(stopAfterSeconds) + TimeSpan.FromSeconds(0.5), CancellationToken.None));
                    var isCancelled = await fake.TaskHelper.ConfigureAwaitHideCancellation(
                        () => fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(hardStop, isCancelled);
                    Assert.Equal(clientCount, fake.Subscribers.Count);
                    Assert.Equal(expectedMsgCount, handledMsgs.Locked(() => handledMsgs.Count));
                    Assert.Equal(expectedMsgCount, fake.Subscribers.Sum(x => x.Acks.Count));
                    Assert.Equal(Enumerable.Repeat(expectedAcks, clientCount), fake.Subscribers.Select(x => x.Acks.Select(y => y.Id).OrderBy(y => y)));
                    Assert.Equal(Enumerable.Repeat(1, clientCount).ToArray(), fake.Subscribers.Select(x => x.WriteCompletes.Count).ToArray());
                    Assert.Equal(1, fake.ClientShutdowns.Count);
                });
            }
        }

        [Theory, CombinatorialData]
        public void OneClientManyMsgs([CombinatorialValues(1, 2, 3, 4, 5)] int rndSeed)
        {
            // Test sending a large quantity of messages
            const int maxStreamingPull = 14;
            const int maxMoveNext = 14;
            const int maxMsgCount = 80;
            var rnd = new Random(rndSeed);
            // Construct a sequence of sequences of batches of messages:
            // Outer sequence is for each invocation of StreamingPull().
            // Inner sequence is for each invocation of MoveNext() on the StreamingPull response stream.
            // And each call to MoveNext() returns a batch of messages.
            // All sizes vary, to test that are no size-specific dependencies.
            var streamingPullCount = rnd.Next(maxStreamingPull / 2, maxStreamingPull);
            var msgs = Enumerable.Range(0, streamingPullCount).Select(rpcId =>
            {
                var moveNextCount = rnd.Next(maxMoveNext / 2, maxMoveNext);
                return Enumerable.Range(0, moveNextCount).Select(moveNextId =>
                {
                    var msgCount = rnd.Next(1, maxMsgCount);
                    var preInterval = TimeSpan.FromMilliseconds(rnd.NextDouble() * 50.0);
                    return ServerAction.Data(preInterval, Enumerable.Range(0, msgCount).Select(i => $"{rpcId}:{moveNextId}:{i}").ToList());
                }).ToList();
            }).Concat(new[] { new[] { ServerAction.Inf() }.ToList() }).ToList();
            var allMsgIds = msgs.SelectMany(x => x.SelectMany(y => y.Msgs ?? new string[0])).ToList();
            var allMsgIdsSet = new HashSet<string>(allMsgIds);
            var totalMsgCount = allMsgIds.Count;
            using (var fake = Fake.Create(msgs, useMsgAsId: true))
            {
                fake.Scheduler.Run(async () =>
                {
                    var recvedMsgs = new List<string>();
                    var startTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        var delay = TimeSpan.FromSeconds(rnd.NextDouble() * 600.0);
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(delay, ct));
                        var msgString = msg.Data.ToStringUtf8();
                        lock (recvedMsgs)
                        {
                            recvedMsgs.Add(msgString);
                            if (recvedMsgs.Count == totalMsgCount)
                            {
                                Task unused = fake.Subscriber.StopAsync(CancellationToken.None);
                            }
                        }
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(startTask);
                    Assert.Equal(totalMsgCount, recvedMsgs.Count);
                    Assert.Equal(allMsgIdsSet, new HashSet<string>(recvedMsgs));
                    var sub = fake.Subscribers[0];
                    Assert.Equal(totalMsgCount, sub.Acks.Count);
                    Assert.Equal(allMsgIdsSet, new HashSet<string>(sub.Acks.Select(x => x.Id)));
                });
            }
        }

        [Theory, PairwiseData]
        public void FlowControl(
            [CombinatorialValues(false, true)] bool hardStop,
            [CombinatorialValues(1, 2, 3)] int clientCount,
            [CombinatorialValues(2, 9, 25, 600)] int stopAfterSeconds,
            [CombinatorialValues(1, 2, 3, 4, 5, 10, 21, 99, 148)] int flowMaxElements,
            [CombinatorialValues(1, 10, 14, 18, 25, 39, 81, 255)] int flowMaxBytes,
            [CombinatorialValues(1, 3, 9, 19)] int threadCount)
        {
            const int msgsPerClient = 100;
            var oneMsgByteCount = FakeSubscriberServiceApiClient.MakeReceivedMessage("0000.0000", "0000").CalculateSize();
            var combinedFlowMaxElements = Math.Min(flowMaxElements, flowMaxBytes / oneMsgByteCount + 1);
            var expectedMsgCount = Math.Min(msgsPerClient * clientCount, combinedFlowMaxElements * stopAfterSeconds + (hardStop ? 0 : combinedFlowMaxElements));
            var msgss = Enumerable.Range(0, msgsPerClient)
                .Select(i => ServerAction.Data(TimeSpan.Zero, new[] { i.ToString("D4") }))
                .Concat(new[] { ServerAction.Inf() });
            using (var fake = Fake.Create(Enumerable.Repeat(msgss, clientCount).ToList(),
                flowMaxElements: flowMaxElements, flowMaxBytes: flowMaxBytes, clientCount: clientCount, threadCount: threadCount))
            {
                fake.Scheduler.Run(async () =>
                {
                    List<string> handledMsgs = new List<string>();
                    int concurrentElementCount = 0;
                    int concurrentByteCount = 0;
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        var msgSize = msg.CalculateSize();
                        lock (handledMsgs)
                        {
                            Assert.True((concurrentElementCount += 1) <= flowMaxElements, "Flow has exceeded max elements.");
                            // Exceeding the flow byte limit is allowed for individual messages that exceed that size.
                            Assert.True((concurrentByteCount += msgSize) <= flowMaxBytes || concurrentElementCount == 1, "Flow has exceeded max bytes.");
                        }
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        lock (handledMsgs)
                        {
                            handledMsgs.Add(msg.Data.ToStringUtf8());
                            // Check just for sanity
                            Assert.True((concurrentElementCount -= 1) >= 0);
                            Assert.True((concurrentByteCount -= msgSize) >= 0);
                        }
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(stopAfterSeconds) + TimeSpan.FromSeconds(0.5), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwaitHideCancellation(() => fake.Subscriber.StopAsync(new CancellationToken(hardStop)));
                    Assert.Equal(expectedMsgCount, handledMsgs.Count);
                });
            }
        }

        [Fact]
        public void UserHandlerFaults()
        {
            var msgs = Enumerable.Repeat(ServerAction.Data(TimeSpan.Zero, new[] { "m" }), 10).Concat(new[] { ServerAction.Inf() });
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
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(Enumerable.Repeat("m", 5), handledMsgs);
                    Assert.Equal(5, fake.Subscribers[0].Acks.Count);
                    Assert.Equal(5, fake.Subscribers[0].Nacks.Count);
                });
            }
        }

        [Theory, PairwiseData]
        public void ServerFaultsRecoverable(
            [CombinatorialValues(1, 3, 9, 14)] int threadCount)
        {
            var zero = TimeSpan.Zero;
            var recoverableEx = new RpcException(new Status(StatusCode.DeadlineExceeded, ""), "");
            var msgs = new[]
            {
                new[] { ServerAction.Data(zero, new[] { "1" }), ServerAction.BadMoveNext(zero, recoverableEx) },
                new[] { ServerAction.Data(zero, new[] { "2" }), ServerAction.BadCurrent(zero, recoverableEx) },
                new[] { ServerAction.Data(zero, new[] { "3" }), ServerAction.Inf() }
            };
            using (var fake = Fake.Create(msgs, threadCount: threadCount))
            {
                fake.Scheduler.Run(async () =>
                {
                    var handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(new[] { "1", "2", "3" }, handledMsgs);
                    Assert.Equal(3, fake.Subscribers[0].Acks.Count);
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
            // Client 1 will recv ["1", "2"], then crash unrecoverably
            // Client(s) 2(+) will just block; this tests that shutdown occurs
            var msgs = new[] { new[] { ServerAction.Data(zero, new[] { "1", "2" }), failure } }
                .Concat(Enumerable.Repeat<IEnumerable<ServerAction>>(new[] { ServerAction.Inf() }, clientCount - 1))
                .ToList();
            // flowMaxElements must be 1, with at least 2 msgs. This ensures that at least one valid item
            // is handled before the server-fault triggers the client to shutdown.
            using (var fake = Fake.Create(msgs, clientCount: clientCount, threadCount: threadCount, flowMaxElements: 1))
            {
                fake.Scheduler.Run(async () =>
                {
                    var handledMsgs = new List<string>();
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1), ct));
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(unrecoverableEx, ex.AllExceptions().FirstOrDefault());
                    Assert.NotEmpty(handledMsgs);
                    Assert.True(handledMsgs[0] == "1" || handledMsgs[0] == "2");
                    Assert.Equal(1, fake.ClientShutdowns.Count);
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
                    // Only allowed to start a Subscriber once.
                    // Note: we want to validate that the exception is thrown synchronously.
                    // Separating out the action assignment from the Assert.Throws call fools the
                    // xUnit analyzer into understanding that this is okay.
                    Action action = () => fake.Subscriber.StartAsync((msg, ct) => throw new Exception());
                    Assert.Throws<InvalidOperationException>(action);
                });
            }
        }

        [Theory, CombinatorialData]
        public void LeaseExtension(bool isExactlyOnceDelivery)
        {
            var msgs = new[] { new[] {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.FromSeconds(5), new[] { "2" }),
                ServerAction.Inf()
            } };
            using (var fake = Fake.Create(msgs, isExactlyOnceDelivery: isExactlyOnceDelivery, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10)))
            {
                fake.Scheduler.Run(async () =>
                {
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(doneTask);
                    Assert.Equal(1, fake.Subscribers.Count);
                    DateTime S(int seconds) => fake.Time0 + TimeSpan.FromSeconds(seconds);
                    Assert.Equal(new[] { S(0), S(5), S(20), S(25), S(40), S(45), S(60), S(65) }, fake.Subscribers[0].Extends.Select(x => x.Time));
                    Assert.Equal(new[] { S(70), S(75) }, fake.Subscribers[0].Acks.Select(x => x.Time));
                });
            }
        }

        [Theory, CombinatorialData]
        public void LeaseMaxExtension(bool isExactlyOnceDelivery)
        {
            var msgs = new[] { new[] {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Inf()
            } };
            using (var fake = Fake.Create(msgs, isExactlyOnceDelivery: isExactlyOnceDelivery, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10)))
            {
                fake.Scheduler.Run(async () =>
                {
                    var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        // Emulate a hanging message-processing task.
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromHours(23), ct));
                        return SubscriberClient.Reply.Ack;
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromHours(12), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(doneTask);
                    Assert.Equal(1, fake.Subscribers.Count);
                    // Check that the lease was extended for 60 minutes only.
                    // +1 is due to initial lease extension at time=0
                    Assert.Equal((int) SubscriberClient.DefaultMaxTotalAckExtension.TotalSeconds / 20 + 1, fake.Subscribers[0].Extends.Count);
                });
            }
        }

        [Fact]
        public void SlowUplinkThrottlesPull()
        {
            const int msgCount = 20;
            const int flowMaxEls = 5;
            var preDelay = TimeSpan.FromSeconds(10);
            var msgs = new[] {
                Enumerable.Range(0, msgCount)
                    .Select(i => ServerAction.Data(TimeSpan.Zero, new[] { i.ToString() }))
                    .Concat(new[] { ServerAction.Inf() })
            };
            using (var fake = Fake.Create(msgs, flowMaxElements: flowMaxEls, writeAsyncPreDelay: preDelay))
            {
                fake.Scheduler.Run(async () =>
                {
                    var subTask = fake.Subscriber.StartAsync((msg, ct) => Task.FromResult(SubscriberClient.Reply.Ack));
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(1000), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(subTask);
                    var sub = fake.Subscribers[0];
                    Assert.True(sub.Extends.Count <= msgCount); // Difficult to predict, must be <= total message count
                    Assert.Equal(msgCount, sub.Acks.Count);
                    // Difficult to predict the exact timings, so check durations.
                    var expectedMinDuration = TimeSpan.FromTicks(preDelay.Ticks * msgCount / flowMaxEls);
                    var duration = sub.Acks.Last().Time - sub.Acks.First().Time;
                    Assert.True(duration >= expectedMinDuration, $"Pull not throttled (acks) {duration} should be >= {expectedMinDuration}");
                });
            }
        }

        [Fact]
        public void StreamPings()
        {
            const int pingPeriodSeconds = 25; // From SubscriberClient.
            const int pingCount = 10;
            var msgs = new[] { ServerAction.Data(TimeSpan.Zero, new[] { "1" }), ServerAction.Inf() };
            using (var fake = Fake.Create(new[] { msgs }))
            {
                var th = fake.TaskHelper;
                fake.Scheduler.Run(async () =>
                {
                    var incompleteTcs = new TaskCompletionSource<SubscriberClient.Reply>();
                    var subTask = fake.Subscriber.StartAsync((msg, ct) => incompleteTcs.Task);
                    // Wait for the time required for pingCount stream pings.
                    await th.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(pingPeriodSeconds * pingCount) + TimeSpan.FromSeconds(1), CancellationToken.None));
                    // Complete the handler task, which will cause pings to stop.
                    incompleteTcs.SetCanceled();
                    // Wait a bit longer, to check no more pings happen.
                    await th.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(pingPeriodSeconds * 4), CancellationToken.None));
                    // Stop subscriber.
                    await th.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    await th.ConfigureAwait(subTask);
                    var expectedPings = Enumerable.Range(0, pingCount).Select(i => fake.Time0 + TimeSpan.FromSeconds(pingPeriodSeconds * (i + 1)));
                    Assert.Equal(expectedPings, fake.Subscribers[0].StreamPings);
                });
            }
        }

        [Theory, PairwiseData]
        public void OrderingKeysManyMsgs(
            [CombinatorialValues(73, 100, 404, 1409, 5402)] int msgCount,
            [CombinatorialValues(1, 3, 6, 10, 55)] int orderingKeysCount,
            [CombinatorialValues(1, 2, 5, 11, 44)] int flowMaxElements,
            [CombinatorialValues(1, 2, 3, 9)] int threadCount,
            [CombinatorialValues(1, 2, 3, 4, 5)] int rndSeed
            )
        {
            var rnd = new Random(rndSeed);
            var msgs = ServerAction.Data(TimeSpan.Zero, Enumerable.Range(0, msgCount).Select(i => $"order{i % orderingKeysCount}|{i}").ToList());
            var recvedMsgs = new List<string>();
            using (var fake = Fake.Create(new[] { new[] { msgs, ServerAction.Inf() } }, flowMaxElements: flowMaxElements, threadCount: threadCount, messageOrderingEnabled: true))
            {
                var th = fake.TaskHelper;
                fake.Scheduler.Run(async () =>
                {
                    var recvCount = 0;
                    var startTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                    {
                        var delay = TimeSpan.FromMilliseconds(rnd.Next(1000));
                        await th.ConfigureAwait(fake.Scheduler.Delay(delay, default));
                        lock (recvedMsgs)
                        {
                            recvedMsgs.Add(msg.Data.ToStringUtf8());
                            recvCount += 1;
                            if (recvCount == msgCount)
                            {
                                var dummyTask = fake.Subscriber.StopAsync(CancellationToken.None);
                            }
                        }
                        return SubscriberClient.Reply.Ack;
                    });
                    await th.ConfigureAwait(startTask);
                });
            }
            var expected = msgs.Msgs.GroupBy(x => x.Split('|')[0]).OrderBy(x => x.Key).ToList();
            var actual = recvedMsgs.GroupBy(x => x.Split('|')[0]).OrderBy(x => x.Key).ToList();
            Assert.Equal(expected.Count, actual.Count);
            Assert.Equal(expected.Select(x => x.Key), actual.Select(x => x.Key));
            foreach (var pair in expected.Zip(actual, (e, a) => new { e, a }))
            {
                Assert.Equal(pair.e.ToList(), pair.a.ToList());
            }
        }

        // TODO: Test client behaviour when ack/nack/extend push RPCs fail.
        // TODO: Test client behaviour when extends taking too long to send.

        private class FakeEmptySubscriberServiceApiClient : SubscriberServiceApiClient
        {
        }

        [Fact]
        public void ValidParameters()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };

            var settingsDefault = new SubscriberClient.Settings();
            new SubscriberClientImpl(subscriptionName, clients, settingsDefault, null);

            var settingsAckDeadline1 = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.MinimumAckDeadline
            };
            new SubscriberClientImpl(subscriptionName, clients, settingsAckDeadline1, null);

            var settingsAckDeadline2 = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.MaximumAckDeadline
            };
            new SubscriberClientImpl(subscriptionName, clients, settingsAckDeadline2, null);

            var settingsAckExtension1 = new SubscriberClient.Settings
            {
                AckExtensionWindow = SubscriberClient.MinimumAckExtensionWindow
            };
            new SubscriberClientImpl(subscriptionName, clients, settingsAckExtension1, null);

            var settingsAckExtension2 = new SubscriberClient.Settings
            {
                AckExtensionWindow = TimeSpan.FromTicks(SubscriberClient.DefaultAckDeadline.Ticks / 2)
            };
            new SubscriberClientImpl(subscriptionName, clients, settingsAckExtension2, null);

            var settingsMaxExtension = new SubscriberClient.Settings
            {
                MaxTotalAckExtension = TimeSpan.FromMinutes(20)
            };
            new SubscriberClientImpl(subscriptionName, clients, settingsMaxExtension, null);
        }

        [Fact]
        public void MinimumDelayIsUsedWhenMinimumAckDeadlineIsSpecified()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };

            // Test that MinimumLeaseExtensionDelay is honoured when the ack-deadline is specified with the minimum possible value.
            var settingsAckDeadline = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.MinimumAckDeadline
            };

            var subscription = new SubscriberClientImpl(subscriptionName, clients, settingsAckDeadline, null);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay, subscription.AutoExtendDelay);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay, subscription.AutoExtendDelayForExactlyOnceDelivery);
        }

        [Fact]
        public void MinimumDelayIsUsedWhenAckDeadlineEqualsAckExtensionWindow()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };

            // Test that MinimumLeaseExtensionDelay is honoured when ack-deadline is set to be equal to the ack-extension window.
            var settingsAckDeadline = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.DefaultAckExtensionWindow
            };

            var subscription = new SubscriberClientImpl(subscriptionName, clients, settingsAckDeadline, null);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay, subscription.AutoExtendDelay);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay, subscription.AutoExtendDelayForExactlyOnceDelivery);
        }

        [Fact]
        public void AckExtensionWindowIsHonouredWhenAckDeadlineIsLarger()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };

            // Test that ack-extension-window is honoured when ack-deadline is a larger value than AckExtensionWindow.
            var settingsAckDeadline = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.DefaultAckExtensionWindow + SubscriberClient.MinimumLeaseExtensionDelay + TimeSpan.FromSeconds(1)
            };

            var subscription = new SubscriberClientImpl(subscriptionName, clients, settingsAckDeadline, null);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay + TimeSpan.FromSeconds(1), subscription.AutoExtendDelay);
            Assert.Equal(SubscriberClient.MinimumLeaseExtensionDelay + TimeSpan.FromSeconds(1), subscription.AutoExtendDelayForExactlyOnceDelivery);
        }

        [Fact]
        public void AckExtensionWindowIsHonouredWhenAckDeadlineAndAckExtensionWindowAreValid()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };

            // Test that ack-extension-window is honoured when both ack-deadline and ack-extension-window are set to valid values.
            var settings = new SubscriberClient.Settings
            {
                AckDeadline = TimeSpan.FromSeconds(60),
                AckExtensionWindow = TimeSpan.FromSeconds(1)
            };

            var subsciption = new SubscriberClientImpl(subscriptionName, clients, settings, null);
            Assert.Equal(TimeSpan.FromSeconds(59), subsciption.AutoExtendDelay);
            Assert.Equal(TimeSpan.FromSeconds(59), subsciption.AutoExtendDelayForExactlyOnceDelivery);
        }

        [Fact]
        public void InvalidParameters()
        {
            var subscriptionName = new SubscriptionName("project", "subscriptionId");
            var clients = new[] { new FakeEmptySubscriberServiceApiClient() };
            var settings = new SubscriberClient.Settings();

            var ex1 = Assert.Throws<ArgumentNullException>(() => new SubscriberClientImpl(null, clients, settings, null));
            Assert.Equal("subscriptionName", ex1.ParamName);

            var ex2 = Assert.Throws<ArgumentNullException>(() => new SubscriberClientImpl(subscriptionName, null, settings, null));
            Assert.Equal("clients", ex2.ParamName);

            var ex3 = Assert.Throws<ArgumentException>(() => new SubscriberClientImpl(subscriptionName, new SubscriberServiceApiClient[] { null }, settings, null));
            Assert.Equal("clients", ex3.ParamName);

            var ex4 = Assert.Throws<ArgumentNullException>(() => new SubscriberClientImpl(subscriptionName, clients, null, null));
            Assert.Equal("settings", ex4.ParamName);

            var settingsBadAckDeadline1 = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.MinimumAckDeadline - TimeSpan.FromMilliseconds(1)
            };
            var ex5 = Assert.Throws<ArgumentOutOfRangeException>(() => new SubscriberClientImpl(subscriptionName, clients, settingsBadAckDeadline1, null));
            Assert.Equal("AckDeadline", ex5.ParamName);

            var settingsBadAckDeadline2 = new SubscriberClient.Settings
            {
                AckDeadline = SubscriberClient.MaximumAckDeadline + TimeSpan.FromMilliseconds(1)
            };
            var ex6 = Assert.Throws<ArgumentOutOfRangeException>(() => new SubscriberClientImpl(subscriptionName, clients, settingsBadAckDeadline2, null));
            Assert.Equal("AckDeadline", ex6.ParamName);

            var settingsBadAckExtension1 = new SubscriberClient.Settings
            {
                AckExtensionWindow = SubscriberClient.MinimumAckExtensionWindow - TimeSpan.FromMilliseconds(1)
            };
            var ex7 = Assert.Throws<ArgumentOutOfRangeException>(() => new SubscriberClientImpl(subscriptionName, clients, settingsBadAckExtension1, null));
            Assert.Equal("AckExtensionWindow", ex7.ParamName);

            var settingsBadAckExtension2 = new SubscriberClient.Settings
            {
                // This is too large. The ack extension window must be less than half the ack deadline.
                AckExtensionWindow = TimeSpan.FromTicks(SubscriberClient.DefaultAckDeadline.Ticks / 2 + 1)
            };
            var ex8 = Assert.Throws<ArgumentOutOfRangeException>(() => new SubscriberClientImpl(subscriptionName, clients, settingsBadAckExtension2, null));
            Assert.Equal("AckExtensionWindow", ex8.ParamName);

            var settingsBadMaxExtension = new SubscriberClient.Settings
            {
                MaxTotalAckExtension = TimeSpan.FromMinutes(-20)
            };
            var ex9 = Assert.Throws<ArgumentOutOfRangeException>(() => new SubscriberClientImpl(subscriptionName, clients, settingsBadMaxExtension, null));
            //Assert.Equal("MaxTotalAckExtension", ex9.ParamName); There's a bug in GaxPreconditions.CheckNonNegativeDelay() which uses the wrong paramName
        }

        [Fact]
        public void DeliveryAttempt()
        {
            var msgs = new[] {
                ServerAction.Data(TimeSpan.Zero, new[] { "m" }, deliveryAttempt: null),
                ServerAction.Data(TimeSpan.Zero, new[] { "m" }, deliveryAttempt: 2),
                ServerAction.Inf()
            };
            using (var fake = Fake.CreateClientForSingleResponseStream(msgs))
            {
                fake.Scheduler.Run(async () =>
                {
                    List<int?> deliveryAttempts = new List<int?>();
                    var doneTask = fake.Subscriber.StartAsync((msg, ct) =>
                    {
                        deliveryAttempts.Add(msg.GetDeliveryAttempt());
                        return Task.FromResult(SubscriberClient.Reply.Ack);
                    });
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                    Assert.Equal(new int?[] { null, 2 }, deliveryAttempts);
                });
            }
        }

        // Acknowledge / ModifyAcknowledgeDeadline calls may throw RpcException. RpcExceptions should not be thrown to the client.
        [Theory, CombinatorialData]
        public void AckModifyAckDeadlineFault_NotThrown([CombinatorialValues(true, false, null)] bool? ackOrModifyAck)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.FromSeconds(5), new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Any RpcException thrown from Acknowledge and/ or ModifyAcknowledgementDeadline should not be thrown to the client.
            var rpcException = new RpcException(new Status(StatusCode.InvalidArgument, ""), "");
            // If ackOrModifyAck is null, then both Acknowledge and ModifyAcknowledgeDeadline will throw the supplied RpcException, total 2 times.
            // If ackOrModifyAck is true, then Acknowledge will throw the supplied RpcException 2 times.
            // If ackOrModifyAck is false, then ModifyAcknowledgementDeadline will throw the supplied RpcException 2 times.
            var ackModifyAckDeadlineAction =
                ackOrModifyAck == null ? AckModifyAckDeadlineAction.BadExtend(rpcException, 2)
                : ackOrModifyAck.Value ? AckModifyAckDeadlineAction.BadAck(rpcException, 2)
                : AckModifyAckDeadlineAction.BadNack(rpcException, 2);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10), ackModifyAckDeadlineAction: ackModifyAckDeadlineAction);
            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    // Add delay greater than ackDeadline to simulate the call to ModifyAcknowledgeDeadline.
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                    return SubscriberClient.Reply.Ack;
                });
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // Despite RpcException being thrown, all 4 messages should be handled.
                Assert.Equal(new[] { "1", "2", "3", "4" }, handledMsgs);
            });
        }

        // If Acknowledge / ModifyAcknowledgeDeadline calls throw exceptions other than RpcExceptions, they should be thrown to the client.
        [Theory, CombinatorialData]
        public void AckModifyAckDeadlineFault_Thrown([CombinatorialValues(true, false)] bool ackOrModifyAck)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.FromSeconds(5), new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Any non-RpcException thrown from Acknowledge and/ or ModifyAcknowledgeDeadline should be thrown to the client.
            var exception = new InvalidOperationException();
            // If ackOrModifyAck is true, then Acknowledge will throw the supplied Exception.
            // If ackOrModifyAck is false, then ModifyAcknowledgeDeadline will throw the supplied Exception.
            // Since exception is thrown, the client will shutdown, so exception count is specified as 1.
            var ackModifyAckDeadlineAction =
                ackOrModifyAck ? AckModifyAckDeadlineAction.BadAck(exception, 1)
                : AckModifyAckDeadlineAction.BadExtend(exception, 1);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10), ackModifyAckDeadlineAction: ackModifyAckDeadlineAction);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    // Add delay greater than ackDeadline to simulate the call to ModifyAcknowledgeDeadline.
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                    return SubscriberClient.Reply.Ack;
                });
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                Assert.Equal(exception, ex.AllExceptions().FirstOrDefault());
                Assert.Equal(1, fake.ClientShutdowns.Count);
            });
        }

        // Acknowledge / ModifyAcknowledgeDeadline calls may throw RpcException.
        // In non exactly once delivery, if we use the new SubscriptionHandler to see Ack/NackResponse,
        // the acknowledgement status should be returned as Success, they are treated as "fire and forget" operations.
        [Theory, CombinatorialData]
        public void AckModifyAckDeadlineFault_SubscriptionHandler([CombinatorialValues(true, false)] bool ackOrModifyAck)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Any RpcException thrown from Acknowledge and/ or ModifyAcknowledgementDeadline should not be thrown to the client.
            var rpcException = new RpcException(new Status(StatusCode.DeadlineExceeded, ""), "");
            // If ackOrModifyAck is true, then Acknowledge will throw the supplied RpcException 1 time.
            // If ackOrModifyAck is false, then ModifyAcknowledgementDeadline will throw the supplied RpcException 1 time.
            var ackModifyAckDeadlineAction = ackOrModifyAck
                ? AckModifyAckDeadlineAction.BadAck(rpcException, 1)
                : AckModifyAckDeadlineAction.BadNack(rpcException, 1);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, useMsgAsId: true, ackDeadline: TimeSpan.FromSeconds(30), ackExtendWindow: TimeSpan.FromSeconds(10), ackModifyAckDeadlineAction: ackModifyAckDeadlineAction);
            var testSubscriptionHandler = new TestSubscriptionHandler(ackOrModifyAck);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(testSubscriptionHandler);
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // All the 4 test messages have encountered a recoverable RpcException, but their status should be success.
                Assert.Equal(4, testSubscriptionHandler.Responses.Count(j => j.Status == AcknowledgementStatus.Success));
            });
        }

        [Theory, CombinatorialData]
        public void ExactlyOnceDelivery_TemporaryFault([CombinatorialValues(true, false, null)] bool? ackNackOrExtends)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Any temporary failure in ack/nack/extend request should not be thrown to the client. It should be retried.
            var exception = new RpcException(new Status(StatusCode.DeadlineExceeded, ""), "");
            // If ackNackOrExtends is null, then it is extend request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            // If ackNackOrExtends is true, then it is acknowledge request. Acknowledge RPC will throw the supplied exception.
            // If ackNackOrExtends is false, then it is nack request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            var ackModifyAckDeadlineAction =
                ackNackOrExtends == null ? AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: 3)
                : ackNackOrExtends.Value ? AckModifyAckDeadlineAction.BadAck(exception, numberOfFailures: 10)
                : AckModifyAckDeadlineAction.BadNack(exception, numberOfFailures: 10);

            using var fake = Fake.Create(new[] { msgs }, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);
            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    if (ackNackOrExtends == null)
                    {
                        // Add delay greater than ackDeadline to simulate extends.
                        await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                    }

                    return ackNackOrExtends == false ? SubscriberClient.Reply.Nack : SubscriberClient.Reply.Ack;
                });
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // Despite temporary failures, all 4 messages should be handled.
                Assert.Equal(new[] { "1", "2", "3", "4" }, handledMsgs);
            });
        }

        [Theory, CombinatorialData]
        public void ExactlyOnceDelivery_AckNack_PermanentFault([CombinatorialValues(true, false)] bool ackOrNack)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            var exception = new RpcException(new Status(StatusCode.FailedPrecondition, ""), "");
            // If ackOrNack is true, then it is acknowledge request. Acknowledge RPC will throw the supplied exception.
            // If ackOrNack is false, then it is nack request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            var ackModifyAckDeadlineAction =
                ackOrNack ? AckModifyAckDeadlineAction.BadAck(exception, numberOfFailures: 10)
                : AckModifyAckDeadlineAction.BadNack(exception, numberOfFailures: 10);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);
            var testSubscriptionHandler = new TestSubscriptionHandler(ackOrNack);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(testSubscriptionHandler);
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                // Exception should not be thrown.
                Assert.Null(ex);
                Assert.Equal(new[] { "1", "2", "3", "4" }, testSubscriptionHandler.Responses.Where(j => j.Status == AcknowledgementStatus.FailedPrecondition).Select(j => j.MessageId));
            });
        }

        [Fact]
        public void ExactlyOnceDelivery_Extends_PermanentFault()
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Any permanent failure in extend request should not be thrown to the client.
            var exception = new RpcException(new Status(StatusCode.FailedPrecondition, ""), "");
            // This is extend request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: 10);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    // Add delay greater than ackDeadline to simulate the extends.
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                    return SubscriberClient.Reply.Ack;
                });
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                // Exception shouldn't be thrown in case of permanent failure.
                Assert.Null(ex);
            });
        }

        [Theory, CombinatorialData]
        public void ExactlyOnceDelivery_AckNack_MixedFault([CombinatorialValues(true, false)] bool ackOrNack)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Inf()
            };

            // Message 1 is success, 2 is temporary failure and 3 is permanent failure.
            var exception = GetExactlyOnceDeliveryMixedException();
            // We have both temporary and permanent failures.
            // Temporary failure in ack/nack request should be retried.
            // If ackOrNack is true, then it is acknowledge request. Acknowledge RPC will throw the supplied exception.
            // If ackOrNack is false, then it is nack request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            var ackModifyAckDeadlineAction =
                ackOrNack ? AckModifyAckDeadlineAction.BadAck(exception, numberOfFailures: 1)
                : AckModifyAckDeadlineAction.BadNack(exception, numberOfFailures: 1);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);

            var testHandler = new TestSubscriptionHandler(ackOrNack);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(testHandler);
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                Assert.Null(ex);
                // "1" is success and "3" is permanent failure.
                Assert.Equal("1", testHandler.Responses.First(j => j.Status == AcknowledgementStatus.Success).MessageId);
                Assert.Equal("3", testHandler.Responses.First(j => j.Status == AcknowledgementStatus.InvalidAckId).MessageId);
            });
        }

        [Fact]
        public void ExactlyOnceDelivery_Extends_MixedFault()
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Message 1, 4 are success, 2 is temporary failure and 3 is permanent failure.
            var exception = GetExactlyOnceDeliveryMixedException();
            // This is an extend request. ModifyAcknowledgeDeadline RPC will throw the supplied exception.
            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: 2);

            using var fake = Fake.CreateClientForSingleResponseStream(msgs, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);
            fake.Scheduler.Run(async () =>
            {
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    // Add delay greater than ackDeadline to simulate the extends.
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(70), ct));
                    return SubscriberClient.Reply.Ack;
                });
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Exception ex = await fake.TaskHelper.ConfigureAwaitHideErrors(() => fake.Subscriber.StopAsync(CancellationToken.None));
                // Permanent exception shouldn't be thrown.
                // Extends are not user initiated, so we can't get the success and temporary failed status from the client.
                Assert.Null(ex);
            });
        }

        // All successful receipt ModAcks.
        [Fact]
        public void ExactlyOnceDelivery_ReceiptModAck()
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Receipt ModAck for message 1,2,3,4 is successful.
            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.Data(null, 0, false, false, true);

            using var fake = Fake.Create(new[] { msgs }, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);

            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), ct));
                    return SubscriberClient.Reply.Ack;
                });

                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // All 4 messages are handled.
                Assert.Equal(4, handledMsgs.Count);
                Assert.Equal(new[] { "1", "2", "3", "4" }, handledMsgs);
            });
        }

        [Theory, CombinatorialData]
        public void ExactlyOnceDelivery_ReceiptModAck_MixedFault([CombinatorialValues(true, false)] bool succeedOnRetry)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Message 1,4 is success, 2 is temporary failure and 3 is permanent failure.
            var exception = GetExactlyOnceDeliveryMixedException();
            // We have both temporary and permanent failures.
            // Temporary failure in extend request should be retried.
            // Based on succeedOnRetry parameter, message 2 should either succeed or fail.
            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: succeedOnRetry ? 2 : 10);

            using var fake = Fake.Create(new[] { msgs }, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);

            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), ct));
                    return SubscriberClient.Reply.Ack;
                });

                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // Permanently failed receipt ModAcks won't be passed to the user handler, so 3 is not handled.
                // Temporary failed ModAck for message 2 becomes successful or permanent failure based on succeedOnRetry flag.
                Assert.Equal(succeedOnRetry ? new[] { "1", "2", "4" } : new[] { "1", "4" }, handledMsgs);
            });
        }

        [Fact]
        public void ExactlyOnceDelivery_ReceiptModAck_PermanentFaults()
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Message 1,2,3,4 are all permanent failures.
            var ackError = new Rpc.ErrorInfo
            {
                Domain = "pubsub.googleapis.com",
                Reason = "broken",
                Metadata =
                {
                    { "1", "PERMANENT_FAILURE_INVALID_ACK_ID" },
                    { "2", "PERMANENT_FAILURE_INVALID_ACK_ID" },
                    { "3", "PERMANENT_FAILURE_INVALID_ACK_ID" },
                    { "4", "PERMANENT_FAILURE_INVALID_ACK_ID" }
                }
            };

            var exception = GetExactlyOnceDeliveryMixedException(ackError);

            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: 4);

            using var fake = Fake.Create(new[] { msgs }, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);

            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), ct));
                    return SubscriberClient.Reply.Ack;
                });

                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // Permanently failed receipt ModAcks won't be passed to the user handler, so all 4 messages are not handled.
                Assert.Equal(0, handledMsgs.Count);
            });
        }

        [Theory, CombinatorialData]
        public void ExactlyOnceDelivery_ReceiptModAck_TemporaryFaults([CombinatorialValues(true, false)] bool succeedOnRetry)
        {
            var msgs = new[]
            {
                ServerAction.Data(TimeSpan.Zero, new[] { "1" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "2" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "3" }),
                ServerAction.Data(TimeSpan.Zero, new[] { "4" }),
                ServerAction.Inf()
            };

            // Message 1,2,3,4 are all temporary failures.
            var ackError = new Rpc.ErrorInfo
            {
                Domain = "pubsub.googleapis.com",
                Reason = "broken",
                Metadata =
                {
                    { "1", "TRANSIENT_FAILURE_UNORDERED_ACK_ID" },
                    { "2", "TRANSIENT_FAILURE_UNORDERED_ACK_ID" },
                    { "3", "TRANSIENT_FAILURE_UNORDERED_ACK_ID" },
                    { "4", "TRANSIENT_FAILURE_UNORDERED_ACK_ID" }
                }
            };

            var exception = GetExactlyOnceDeliveryMixedException(ackError);

            // 400 is a large arbitrary number to ensure that the retry is not successful.
            var ackModifyAckDeadlineAction = AckModifyAckDeadlineAction.BadExtend(exception, numberOfFailures: succeedOnRetry ? 3 : 400);

            using var fake = Fake.Create(new[] { msgs }, useMsgAsId: true, ackModifyAckDeadlineAction: ackModifyAckDeadlineAction, isExactlyOnceDelivery: true);

            fake.Scheduler.Run(async () =>
            {
                var handledMsgs = new List<string>();
                var doneTask = fake.Subscriber.StartAsync(async (msg, ct) =>
                {
                    handledMsgs.Locked(() => handledMsgs.Add(msg.Data.ToStringUtf8()));
                    await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(10), ct));
                    return SubscriberClient.Reply.Ack;
                });

                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                // Temporary failed receipt ModAcks can succeed after 1 retry or stay failed, so based on the succeedOnRetry flag, 4 or 0 messages are handled.
                Assert.Equal(succeedOnRetry ? 4 : 0, handledMsgs.Count);
                Assert.Equal(succeedOnRetry ? new[] { "1", "2", "3", "4" } : Array.Empty<string>(), handledMsgs);
            });
        }

        [Fact]
        public void StreamingPullRetry_GrpcNetClientAuthRelatedFailuresEventuallyFail()
        {
            var rpcEx = new RpcException(new Status(StatusCode.Internal, "Bang", new TokenResponseException(new TokenErrorResponse())));
            TestAuthRelatedFailure(rpcEx);
        }

        [Fact]
        public void StreamingPullRetry_GrpcCoreAuthRelatedFailuresEventuallyFail()
        {
            var rpcEx = new RpcException(new Status(StatusCode.Unavailable, "Getting metadata from plugin failed with error: Exception occurred in metadata credentials plugin. It went bang."));
            TestAuthRelatedFailure(rpcEx);
        }

        private void TestAuthRelatedFailure(RpcException rpcEx)
        {
            using var fake = Fake.Create(CreateBadMoveNextSequence(TimeSpan.FromSeconds(1), rpcEx, 5, includeTrailing: false));

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                var subscriberEx = await Assert.ThrowsAsync<RpcException>(() => subscriberTask);
                Assert.Equal(rpcEx.Status, subscriberEx.Status);
            });
        }

        [Fact]
        public void StreamingPullRetry_NonRetriableException()
        {
            var rpcEx = new RpcException(new Status(StatusCode.NotFound, "No such topic"));
            using var fake = Fake.Create(CreateBadMoveNextSequence(TimeSpan.FromSeconds(0), rpcEx, 1, includeTrailing: false));
            var start = fake.Scheduler.Clock.GetCurrentDateTimeUtc();

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                var subscriberEx = await Assert.ThrowsAsync<RpcException>(() => subscriberTask);
                Assert.Equal(rpcEx.Status, subscriberEx.Status);
                // We should have failed immediately - but there's a two second delay in SubscriberClient.StopCompletionAsync
                // to avoid a race condition.
                Assert.Equal(start.AddSeconds(2), fake.Scheduler.Clock.GetCurrentDateTimeUtc());
            });
        }

        [Fact]
        public void StreamingPullRetry_InternalErrorContinuesRetrying()
        {
            // A regular internal failure that's not due to an auth error.
            var exception = new RpcException(new Status(StatusCode.Internal, "Bang"));

            using var fake = Fake.Create(CreateBadMoveNextSequence(TimeSpan.FromSeconds(1), exception, 5, includeTrailing: true));

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromSeconds(100), CancellationToken.None));
                Assert.False(subscriberTask.IsCompleted);
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                await subscriberTask;
            });
        }

        [Fact]
        public void StreamingPullRetry_RetriableErrorEventuallyFails()
        {
            // A regular internal failure that's not due to an auth error.
            var exception = new RpcException(new Status(StatusCode.Internal, "Bang"));

            // When we've reached a limit of the number of exceptions we're happy to retry, we'll eventually fail.
            // (This will take a long time, with all the backoffs involved...)
            using var fake = Fake.Create(CreateBadMoveNextSequence(TimeSpan.FromSeconds(1), exception, 100, includeTrailing: true));

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                var subscriberEx = await Assert.ThrowsAsync<RpcException>(() => subscriberTask);
                Assert.Equal(exception.Status, subscriberEx.Status);
            });
        }

        /// <summary>
        /// If the streaming pull call fails in MoveNext after a short time (e.g. 10 seconds)
        /// we should retry with backoff.
        /// </summary>
        [Fact]
        public void StreamingPullRetry_UnavailableAfterShortDelayTriggersRetryWithBackoff()
        {
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Stream terminated"));
            TimeSpan streamDuration = TimeSpan.FromSeconds(30);
            using var fake = Fake.Create(CreateBadMoveNextSequence(streamDuration, exception, 5, includeTrailing: true));
            var start = fake.Scheduler.Clock.GetCurrentDateTimeUtc();

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromMinutes(100), CancellationToken.None));
                Assert.False(subscriberTask.IsCompleted);
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                await subscriberTask;

                // Check the pull times indicate a backoff.
                var subscriber = fake.Subscribers.Single();
                var pullTimes = subscriber.StreamingPulls;
                Assert.Equal(6, subscriber.StreamingPulls.Count);
                Assert.Equal(start, pullTimes[0]);
                DateTime previousStart = start;
                // The second call should be more than this long after the first,
                // and each successive call should be delayed further.
                TimeSpan previousTimeBetweenCalls = streamDuration;
                foreach (var pullTime in pullTimes.Skip(1))
                {
                    var timeBetweenCalls = pullTime - previousStart;
                    Assert.True(timeBetweenCalls > previousTimeBetweenCalls);
                    previousTimeBetweenCalls = timeBetweenCalls;
                    previousStart = pullTime;
                }
            });
        }

        /// <summary>
        /// We *expect* the streaming pull to fail (in MoveNext) after about a minute... we should
        /// retry immediately each time.
        /// </summary>
        [Fact]
        public void StreamingPullRetry_UnavailableAfterLongDelayTriggersRetryWithoutBackoff()
        {
            var exception = new RpcException(new Status(StatusCode.Unavailable, "Stream terminated"));
            TimeSpan streamDuration = TimeSpan.FromSeconds(60);
            using var fake = Fake.Create(CreateBadMoveNextSequence(streamDuration, exception, 5, includeTrailing: true));

            var start = fake.Scheduler.Clock.GetCurrentDateTimeUtc();

            fake.Scheduler.Run(async () =>
            {
                var subscriberTask = fake.Subscriber.StartAsync((msg, ct) => throw new Exception("No messages should be provided"));
                await fake.TaskHelper.ConfigureAwait(fake.Scheduler.Delay(TimeSpan.FromMinutes(100), CancellationToken.None));
                Assert.False(subscriberTask.IsCompleted);
                await fake.TaskHelper.ConfigureAwait(fake.Subscriber.StopAsync(CancellationToken.None));
                await subscriberTask;

                // Check the pull times indicate no backoff.
                var subscriber = fake.Subscribers.Single();
                var expectedPullTimes = Enumerable.Range(0, 6).Select(index => start + TimeSpan.FromTicks(streamDuration.Ticks * index)).ToList();
                Assert.Equal(expectedPullTimes, subscriber.StreamingPulls);
            });
        }

        /// <summary>
        /// Creates a sequence of failing streaming pull responses, optionally followed by one "never responds" streaming pull.
        /// The nested aspect is because each streaming pull can (theoretically) consist of multiple responses.
        /// </summary>
        private static IReadOnlyList<IEnumerable<ServerAction>> CreateBadMoveNextSequence(TimeSpan timeBeforeFailure, RpcException exception, int count, bool includeTrailing) =>
            Enumerable.Repeat(ServerAction.Sequence(ServerAction.BadMoveNext(timeBeforeFailure, exception)), count)
                .Concat(Enumerable.Repeat(ServerAction.Sequence(ServerAction.Inf()), includeTrailing ? 1 : 0))
                .ToList();
    }
}
