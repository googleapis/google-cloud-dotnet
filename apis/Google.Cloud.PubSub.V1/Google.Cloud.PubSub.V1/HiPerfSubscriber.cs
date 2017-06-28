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
using Google.Apis.Auth.OAuth2;
using Google.Cloud.PubSub.V1.Tasks;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    // TODO: Class name still to be decided, but can't be Subscriber
    // TODO: Should this implement IDisposable?
    /// <summary>
    /// A PubSub subscriber that is associated with a specific <see cref="SubscriptionName"/>.
    /// </summary>
    /// <remarks>
    /// <para>To receive messages, the <see cref="StartAsync"/> method must be called,
    /// with a suitable message handler.</para>
    /// <para>This message handler <see cref="Reply"/> states whether to acknowledge the message;
    /// if acknowledged then it will not be received on this subscription again.</para>
    /// </remarks>
    public abstract class HiPerfSubscriber
    {
        public sealed class ObjWithShutdown<T> where T : class
        {
            public ObjWithShutdown(T obj, Func<Task> shutdown)
            {
                Obj = GaxPreconditions.CheckNotNull(obj, nameof(obj));
                Shutdown = GaxPreconditions.CheckNotNull(shutdown, nameof(shutdown));
            }

            public T Obj { get; }
            public Func<Task> Shutdown { get; }
        }

        /// <summary>
        /// Reply from a message handler; whether to <see cref="Ack"/>
        /// or <see cref="Nack"/> the message to the server. 
        /// </summary>
        public enum Reply
        {
            /// <summary>
            /// Message not handled successfully.
            /// </summary>
            Nack = 0,

            /// <summary>
            /// Message handled successfully.
            /// </summary>
            Ack = 1,
        }

        /// <summary>
        /// Settings for <see cref="HiPerfSubscriber"/>.
        /// Defaults will be used for <c>null</c> properties.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Used to create new channels.
            /// If <c>null</c>, creates channels using the default PubSub endpoint
            /// and default credentials.
            /// </summary>
            public Func<CancellationToken, Task<ObjWithShutdown<SubscriberClient>>> SubscriberProvider { get; set; }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// Back off settings for re-connecting clients with recoverable errors
            /// </summary>
            public BackoffSettings BackoffSettings { get; set; }

            /// <summary>
            /// The lease time before which a message must either be ACKed
            /// or have its lease extended. This is truncated to the nearest second.
            /// IF <c>null</c>, uses the default of TODO secods.
            /// </summary>
            public TimeSpan? StreamAckDeadline { get; set; }

            /// <summary>
            /// Duration before message expiration.
            /// If <c>null</c>, uses the default of TODO seconds.
            /// </summary>
            public TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> used to schedule delays.
            /// If <c>null</c>, the default <see cref="SystemScheduler"/> is used.
            /// This is usually only used for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            /// <summary>
            /// The number of clients/channels to create. Defaults to something sensible (TODO).
            /// </summary>
            public int? ClientCount { get; set; }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="HiPerfSubscriber"/>.  
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="HiPerfSubscriber"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings() => new FlowControlSettings
        {
            MaxOutstandingElementCount = 10_000,
            MaxOutstandingRequestBytes = 10_000_000,
        };

        /// <summary>
        /// Default <see cref="BackoffSettings"/> for reconnecting on recoverable errors.
        /// </summary>
        /// <returns>Default <see cref="BackoffSettings"/> for reconnecting on recoverable errors.</returns>
        public static BackoffSettings DefaultBackoffSettings() => new BackoffSettings(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(60), 1.5);

        private static Lazy<Task<ChannelCredentials>> s_credentials = new Lazy<Task<ChannelCredentials>>(async () =>
        {
            var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            if (credentials.IsCreateScopedRequired)
            {
                credentials = credentials.CreateScoped(SubscriberClient.DefaultScopes);
            }
            return credentials.ToChannelCredentials();
        });

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="cancellationToken">TODO</param>
        /// <returns>TODO</returns>
        protected static async Task<ObjWithShutdown<SubscriberClient>> DefaultSubscriberProvider(CancellationToken cancellationToken)
        {
            // TODO: Use settings passed by user, if present
            var credentials = await s_credentials.Value.ConfigureAwait(false);
            var channel = new Channel(SubscriberClient.DefaultEndpoint.Host, SubscriberClient.DefaultEndpoint.Port, credentials);
            var client = SubscriberClient.Create(channel);
            Task Shutdown()
            {
                // Delibrately don't wait for shutdown to complete.
                // Doing so would block a hard-stop of the subscriber.
                channel.ShutdownAsync();
                return Task.FromResult(0);
            }
            return new ObjWithShutdown<SubscriberClient>(client, Shutdown);
        }

        /// <summary>
        /// Create a <see cref="HiPerfSubscriber"/> instance
        /// associated with the specified <see cref="SubscriptionName"/>.  
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="settings">Optional <see cref="Settings"/> for this instance.</param>
        /// <returns>A <see cref="HiPerfSubscriber"/> instance
        /// associated with the specified <see cref="SubscriptionName"/></returns>
        public static HiPerfSubscriber Create(SubscriptionName subscriptionName, Settings settings = null) =>
            new HiPerfSubscriberImpl(subscriptionName, settings ?? new Settings());

        /// <summary>
        /// The associated <see cref="SubscriptionName"/>.
        /// </summary>
        public SubscriptionName SubscriptionName { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Starts receiving subscriptions. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
        /// or if an unrecoverable fault occurs. See the remarks section for more details.
        /// </summary>
        /// <remarks>
        /// TODO
        /// </remarks>
        /// <param name="handlerAsync">The handler function that is passed all received messages.
        /// This function may be called on multiple threads concurrently.</param>
        /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverble error occurs.
        /// </returns>
        public virtual Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) => throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="hardStopToken">TODO</param>
        /// <returns>TODO</returns>
        public virtual Task StopAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="timeout">TODO</param>
        /// <returns>TODO</returns>
        public virtual Task StopAsync(TimeSpan timeout) => StopAsync(new CancellationTokenSource(timeout).Token);
    }

    /// <summary>
    /// Implementation of <see cref="HiPerfSubscriber"/>. 
    /// </summary>
    public sealed class HiPerfSubscriberImpl : HiPerfSubscriber
    {
        public static int pushLoopCount = 0; // TODO: Remove
        public static int[] counts = new int[15]; // TODO: Remove
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="subscriptionName">TODO</param>
        /// <param name="settings">TODO</param>
        public HiPerfSubscriberImpl(SubscriptionName subscriptionName, Settings settings) :
            this(subscriptionName, settings, TaskHelper.Default)
        {
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="subscriptionName">TODO</param>
        /// <param name="settings">TODO</param>
        /// /// <param name="taskHelper">TODO</param>
        internal HiPerfSubscriberImpl(SubscriptionName subscriptionName, Settings settings, TaskHelper taskHelper)
        {
            // TODO: Check settings is not null
            _subscriptionName = subscriptionName; // TODO: Not null
            _subscriberCount = settings.ClientCount ?? 8; // TODO: what should the default be? 
            _subscriberProvider = settings.SubscriberProvider ?? DefaultSubscriberProvider;
            _modifyDeadlineSeconds = (int)(settings.StreamAckDeadline?.TotalSeconds ?? 60.0); // TODO: default, and verify value
            _autoExtendInterval = TimeSpan.FromSeconds(_modifyDeadlineSeconds) - settings.AckExtensionWindow ?? TimeSpan.FromSeconds(10); // TODO: default, and verify value
            _maxAckExtendCount = 1000; // TODO
            _scheduler = settings.Scheduler;
            _taskHelper = taskHelper;
            var flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings();
            _flowMaxByteCount = flowControlSettings.MaxOutstandingRequestBytes ?? long.MaxValue;
            _flowMaxElementCount = flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue;
            var backoffSettings = settings.BackoffSettings ?? DefaultBackoffSettings();
            _backoffDelay = backoffSettings.Delay;
            _backoffMaxDelay = backoffSettings.MaxDelay;
            _backoffMultiplier = backoffSettings.DelayMultiplier;
        }

        private readonly object _lock = new object();
        private readonly SubscriptionName _subscriptionName;
        private readonly int _subscriberCount;
        private readonly Func<CancellationToken, Task<ObjWithShutdown<SubscriberClient>>> _subscriberProvider;
        private readonly TimeSpan _autoExtendInterval; // Interval between message lease auto-extends
        private readonly int _modifyDeadlineSeconds; // Value to use as new deadline when lease auto-extends
        private readonly int _maxAckExtendCount; // Maximum count of acks/extends to push to server in a single messages
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;

        private readonly long _flowMaxByteCount;
        private readonly long _flowMaxElementCount;
        private readonly TimeSpan _backoffDelay;
        private readonly TimeSpan _backoffMaxDelay;
        private readonly double _backoffMultiplier;

        private TaskCompletionSource<int> _mainTcs;
        private StateManager _stateManager;

        /// <inheritdoc />
        public override Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync)
        {
            lock (_lock)
            {
                GaxPreconditions.CheckState(_mainTcs == null, "Can only an instance once.");
                _mainTcs = new TaskCompletionSource<int>();
            }
            _stateManager = new StateManager();
            var registeredTasks = new HashSet<Task>();
            void RegisterTask(Task task)
            {
                registeredTasks.Locked(() => registeredTasks.Add(task));
                _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(task, () => registeredTasks.Locked(() => registeredTasks.Remove(task))));
            }
            Flow flow = new Flow(_flowMaxByteCount, _flowMaxElementCount, RegisterTask, _taskHelper);
            // Start all subscribers
            var subscriberTasks = Enumerable.Range(0, _subscriberCount).Select(_ =>
            {
                var singleChannel = new SingleChannel(_subscriptionName, _subscriberProvider, handlerAsync,
                    _autoExtendInterval, _modifyDeadlineSeconds, _maxAckExtendCount, flow,
                    _backoffDelay, _backoffMaxDelay, _backoffMultiplier, RegisterTask, _scheduler, _taskHelper, _stateManager);
                return singleChannel.Go();
            }).ToArray();
            // Setup finsh task
            _taskHelper.Run(async () =>
            {
                // Wait for all subscribers to stop
                await _taskHelper.ConfigureAwaitHideErrors(_taskHelper.WhenAll(subscriberTasks));
                // Wait for all registered Tasks to stop
                await _taskHelper.ConfigureAwaitHideErrors(_taskHelper.WhenAll(registeredTasks.Locked(() => registeredTasks.ToArray())));
                // Return final result
                if (_stateManager.Exception != null)
                {
                    var ex = _stateManager.Exception;
                    _mainTcs.SetException((ex as AggregateException)?.Flatten().InnerException ?? ex);
                }
                else if (_stateManager.State == State.HardStop)
                {
                    Console.WriteLine("[StartAsync] Apparently this was a HARD-STOP");
                    _mainTcs.SetCanceled();
                }
                else
                {
                    _mainTcs.SetResult(0);
                }
            });
            return _mainTcs.Task;
        }

        /// <inheritdoc />
        public override Task StopAsync(CancellationToken hardStopToken)
        {
            lock (_lock)
            {
                if (_stateManager.IsRunning)
                {
                    _stateManager.Set(State.Stop);
                    if (hardStopToken.CanBeCanceled)
                    {
                        var registration = hardStopToken.Register(() => _stateManager.Set(State.HardStop));
                        // Do not register this Task, it completes *after* mainTask
                        _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(_mainTcs.Task, () => registration.Dispose()));
                    }
                }
                return _mainTcs.Task;
            }
        }

        private enum State
        {
            Running,
            Stop,
            HardStop
        }

        private class StateManager
        {
            private List<Action<State>> _stateChangeFns = new List<Action<State>>();
            private volatile State _state = State.Running;
            private volatile Exception _exception = null;
            public State State => _state;
            public bool IsRunning => State == State.Running;
            public Exception Exception => _exception;
            public void Set(State state)
            {
                Console.WriteLine($"[StateManager.Set] state={state}");
                _state = state;
                foreach (var fn in _stateChangeFns)
                {
                    fn(state);
                }
            }
            public void SetExceptionAndHardStop(Exception e)
            {
                Console.WriteLine($"[SetExceptionAndHardStop] {e}");
                _exception = e;
                Set(State.HardStop);
            }
            public void Register(Action<State> stateChangeFn) => _stateChangeFns.Add(stateChangeFn);
        }

        private class Flow
        {
            public Flow(long maxByteCount, long maxElementCount, Action<Task> registerTaskFn, TaskHelper taskHelper)
            {
                _maxByteCount = maxByteCount;
                _maxElementCount = maxElementCount;
                _registerTaskFn = registerTaskFn;
                _taskHelper = taskHelper;
            }

            private readonly object _lock = new object();
            private readonly long _maxByteCount;
            private readonly long _maxElementCount;
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;

            private long _byteCount;
            private long _elementCount;

            private TaskCompletionSource<int> _event = new TaskCompletionSource<int>();

            private bool IsFlowOk() => _byteCount < _maxByteCount && _elementCount < _maxElementCount;

            public async Task Process(long byteCount, Func<Task> fn)
            {
                Task prevEventTask = null;
                while (true)
                {
                    Task eventTask;
                    lock (_lock)
                    {
                        if (IsFlowOk())
                        {
                            _byteCount += byteCount;
                            _elementCount += 1;
                            break;
                        }
                        eventTask = _event.Task;
                    }
                    //if (prevEventTask == eventTask) counts[13] += 1;
                    prevEventTask = eventTask;
                    counts[8] += 1;
                    if (eventTask.IsCompleted) counts[10] += 1;
                    await _taskHelper.ConfigureAwait(eventTask);
                    counts[9] += 1;
                }
                _registerTaskFn(_taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn(), () =>
                {
                    lock (_lock)
                    {
                        bool preIsFlowOk = IsFlowOk();
                        _byteCount -= byteCount;
                        _elementCount -= 1;
                        counts[11] += 1;
                        if (!preIsFlowOk && IsFlowOk())
                        {
                            counts[12] += 1;
                            var ev = _event;
                            _event = new TaskCompletionSource<int>();
                            counts[13] += 1;
                            ev.SetResult(0);
                            counts[14] += 1;
                        }
                    }
                })));
            }
        }

        private class SingleChannel
        {
            public SingleChannel(SubscriptionName subscriptionName,
                Func<CancellationToken, Task<ObjWithShutdown<SubscriberClient>>> subscriberProvider, Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync,
                TimeSpan autoExtendInterval, int modifyDeadlineSeconds, int maxAckExtendCount, Flow flow,
                TimeSpan backoffDelay, TimeSpan backoffMaxDelay, double backoffMultiplier,
                Action<Task> registerTaskFn, IScheduler scheduler, TaskHelper taskHelper, StateManager stateManager)
            {
                _subscriptionName = subscriptionName;
                _subscriberProvider = subscriberProvider;
                _handlerAsync = handlerAsync;
                _autoExtendInterval = autoExtendInterval;
                _modifyDeadlineSeconds = modifyDeadlineSeconds;
                _maxAckExtendCount = maxAckExtendCount;
                _flow = flow;
                _backoffDelay = backoffDelay;
                _backoffMaxDelay = backoffMaxDelay;
                _backoffMultiplier = backoffMultiplier;
                _registerTaskFn = registerTaskFn;
                _scheduler = scheduler;
                _taskHelper = taskHelper;
                _stateManager = stateManager;
                _softStopCts = new CancellationTokenSource();
                _hardStopCts = new CancellationTokenSource();
                stateManager.Register(state =>
                {
                    _softStopCts.CancelIf(state == State.Stop || state == State.HardStop);
                    _hardStopCts.CancelIf(state == State.HardStop);
                    _qLock.Locked(() => _qEvent.TrySetResult(0));
                });
            }

            private SubscriptionName _subscriptionName;
            private readonly Func<CancellationToken, Task<ObjWithShutdown<SubscriberClient>>> _subscriberProvider;
            private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handlerAsync;
            private readonly TimeSpan _autoExtendInterval;
            private readonly int _modifyDeadlineSeconds;
            private readonly int _maxAckExtendCount;
            private readonly Flow _flow;
            private readonly Action<Task> _registerTaskFn;
            private readonly IScheduler _scheduler;
            private readonly TaskHelper _taskHelper;
            private readonly StateManager _stateManager;
            private readonly TimeSpan _backoffDelay;
            private readonly TimeSpan _backoffMaxDelay;
            private readonly double _backoffMultiplier;
            private readonly CancellationTokenSource _softStopCts;
            private readonly CancellationTokenSource _hardStopCts;

            private readonly object _qLock = new object();
            private readonly Queue<string> _ackQueue = new Queue<string>();
            private readonly Queue<string> _extendQueue = new Queue<string>();
            private int _unAckedMsgCount;
            private TaskCompletionSource<int> _qEvent = new TaskCompletionSource<int>();

            //private void M(string s) => Console.WriteLine(s);
            private void M(string s) { }

            private static int __tempId = 0;

            public async Task Go()
            {
                // The current backoff delay.
                var backoffDelay = _backoffDelay;
                // Loop to re-create subscriber if it fails.
                while (!_hardStopCts.IsCancellationRequested)
                {
                    var tempId = (char)('A' + Interlocked.Increment(ref __tempId) - 1);

                    M($"[Go:{tempId}] Start of outer loop");
                    // TODO: Log errors in _subscriberProvider
                    // If hard-cancelled, this cancels back to StartAsync().
                    ObjWithShutdown<SubscriberClient> subscriber = null;
                    SubscriberClient.StreamingPullStream pull = null;
                    try
                    {
                        M($"[Go:{tempId}] About to get a new subscriber");
                        subscriber = await _taskHelper.ConfigureAwait(_subscriberProvider(_hardStopCts.Token));
                        M($"[Go:{tempId}] About to pull");
                        pull = subscriber.Obj.StreamingPull(CallSettings.FromCancellationToken(_hardStopCts.Token), new BidirectionalStreamingSettings(/*1*/10));// TODO: Put back to 1 once bug fixed
                        M($"[Go:{tempId}] Got pull");
                        // Initial call to start subscribe messages
                        await _taskHelper.ConfigureAwait(pull.WriteAsync(new StreamingPullRequest
                        {
                            SubscriptionAsSubscriptionName = _subscriptionName,
                            StreamAckDeadlineSeconds = _modifyDeadlineSeconds
                        }));
                        // Start Push task which pushes acks and extends.
                        var faultOrSoftStopCts = CancellationTokenSource.CreateLinkedTokenSource(_softStopCts.Token);
                        Task pushTask = Push(pull, faultOrSoftStopCts, tempId);
                        // Read incoming messages whilst not stopped, and not in a fault condition.
                        M($"[Go:{tempId}] About to MoveNext()");
                        // TODO!! Sort out cancellation. ResponseStream.MoveNext does not accept a cancellationtoken :(
                        while (_stateManager.IsRunning && await _taskHelper.ConfigureAwaitHideCancellation(pull.ResponseStream.MoveNext(/*faultOrSoftStopCts.Token*/CancellationToken.None), false))
                        {
                            if (!_stateManager.IsRunning || faultOrSoftStopCts.IsCancellationRequested) // TODO: Tidy this up now we can't cancel MoveNext()
                            {
                                break;
                            }
                            var msgs = pull.ResponseStream.Current.ReceivedMessages;
                            M($"[Go:{tempId}] MoveNext() true. msg-count:{msgs.Count}");
                            var ackIds = new HashSet<string>(msgs.Select(x => x.AckId));
                            var allMsgsHandledCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                            _registerTaskFn(AutoExtend(ackIds, allMsgsHandledCts.Token));
                            foreach (var msg in msgs)
                            {
                                counts[6] += 1;
                                if (!_stateManager.IsRunning)
                                {
                                    break;
                                }
                                // Returned Task completes once flow-control is satisfied.
                                await _taskHelper.ConfigureAwaitHideCancellation(_flow.Process(msg.CalculateSize(), async () =>
                                {
                                    counts[0] += 1;
                                    // IsRunning check and _unAckedMsgCount must be atomic (or _unAckedMsgCount could be done before IsRunning check)
                                    // to avoid a Push() shutdown race condition.
                                    if (_qLock.Locked(() =>
                                    {
                                        counts[1] += 1;
                                        bool isRunning = _stateManager.IsRunning;
                                        _unAckedMsgCount += isRunning ? 1 : 0;
                                        return isRunning;
                                    }))
                                    {
                                        counts[2] += 1;
                                        // TODO: Log errors in user handler
                                        M($"[Go:{tempId}] About to user-handle msg '{msg.Message.Data.ToStringUtf8()}'");
                                        var reply = await _taskHelper.ConfigureAwaitHideErrors(_handlerAsync(msg.Message, _hardStopCts.Token), Reply.Nack);
                                        M($"[Go:{tempId}] User-handled msg '{msg.Message.Data.ToStringUtf8()}'. Reply:{reply}");
                                        counts[3] += 1;
                                        lock (_qLock)
                                        {
                                            counts[4] += 1;
                                            if (reply == Reply.Ack)
                                            {
                                                ackIds.Remove(msg.AckId);
                                                _ackQueue.Enqueue(msg.AckId);
                                                allMsgsHandledCts.CancelIf(ackIds.Count == 0);
                                                _qEvent.TrySetResult(0);
                                            }
                                            else
                                            {
                                                _unAckedMsgCount -= 1;
                                            }
                                        }
                                    }
                                    counts[5] += 1;
                                }));
                                counts[7] += 1;
                            }
                        }
                        M($"[Go:{tempId}] MoveNext() false (or stopped)");
                        _qLock.Locked(() => _qEvent.TrySetResult(0));
                        await _taskHelper.ConfigureAwaitHideErrors(pushTask);
                    }
                    catch (Exception e) when (e.As<RpcException>()?.Status.StatusCode == StatusCode.Cancelled && !_stateManager.IsRunning)
                    {
                        // Do nothing.
                        // MoveNext() has been cancelled as part of the shutdown process
                        M($"[Go:{tempId}] Controlled GRPC cancel");
                    }
                    catch (Exception e) when (e.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable exception, log and use backoff before re-trying connection.
                        // TODO: Log Exception
                        await _taskHelper.ConfigureAwait(_scheduler.Delay(backoffDelay, _hardStopCts.Token));
                        backoffDelay = new TimeSpan((long)(backoffDelay.Ticks * _backoffMultiplier));
                        if (backoffDelay > _backoffMaxDelay)
                        {
                            backoffDelay = _backoffMaxDelay;
                        }
                    }
                    catch (Exception e) when (!e.IsCancellation())
                    {
                        M($"[Go] EXCEPTION, not cancellation. {e}");
                        // Unrecoverable exception, log and stop the subscriber
                        // TODO: Log exception
                        // Hard-stop on unrecoverable error. This stops all other Tasks and subscribers.
                        _stateManager.SetExceptionAndHardStop(e);
                        break;
                    }
                    finally
                    {
                        M($"[Go:{tempId}] pull != null: {pull != null}; subscriber != null:{subscriber != null}");
                        // Try to cleanly shutdown the subscriber. This may or may not be possible
                        // depending on the state of the subscriber; ignore all errors.
                        if (pull != null)
                        {
                            // TODO: Log errors
                            try
                            {
                                _registerTaskFn(pull.WriteCompleteAsync());
                            }
                            catch { }
                        }
                        if (subscriber != null)
                        {
                            // TODO: Log errors
                            try
                            {
                                _registerTaskFn(subscriber.Shutdown());
                            }
                            catch { }
                        }
                    }
                }
            }

            private async Task AutoExtend(HashSet<string> ackIds, CancellationToken allMsgsHandledToken)
            {
                // Moves ackIds into the extend-queue as required for auto lease extension
                while (true)
                {
                    await _taskHelper.ConfigureAwait(_scheduler.Delay(_autoExtendInterval, allMsgsHandledToken));
                    lock (_qLock)
                    {
                        _extendQueue.EnqueueAll(ackIds);
                        _qEvent.TrySetResult(0);
                    }
                }
            }

            private async Task Push(SubscriberClient.StreamingPullStream pull, CancellationTokenSource faultCts, object tempId)
            {
                try
                {
                    while (true)
                    {
                        Interlocked.Increment(ref pushLoopCount);
                        await _taskHelper.ConfigureAwait(_qLock.Locked(() => _qEvent.Task));
                        Interlocked.Increment(ref pushLoopCount);
                        List<string> acks = new List<string>();
                        List<string> extends = new List<string>();
                        lock (_qLock)
                        {
                            // _qEvent must be re-created before any actual work is done.
                            // This ensures no work will be missed if a re-trigger occurs just after the _qEvent.Task await.
                            _qEvent = new TaskCompletionSource<int>();
                            // On hardStop, just exit immediately. No more extends/acks will be pushed.
                            // faultCts being cancelled means the Pull has faulted, so stop Pushing as soon as possible.
                            if (_hardStopCts.IsCancellationRequested)
                            {
                                break;
                            }
                            // Send acks that are waiting, but no more that _maxAckExtendCount
                            while (_ackQueue.Count > 0 && acks.Count < _maxAckExtendCount)
                            {
                                acks.Add(_ackQueue.Dequeue());
                            }
                            // Send extends that are waiting, but no more acks+extends than _maxAckExtendCount
                            while (_extendQueue.Count > 0 && (acks.Count + extends.Count) < _maxAckExtendCount)
                            {
                                extends.Add(_extendQueue.Dequeue());
                            }
                        }
                        M($"[Push:{tempId}] acks.Count:{acks.Count}, extends.Count:{extends.Count}");
                        // If anything to be sent, then send it now
                        if (acks.Count > 0 || extends.Count > 0)
                        {
                            M($"[Push:{tempId}] AA");
                            try
                            {
                                await _taskHelper.ConfigureAwait(pull.WriteAsync(new StreamingPullRequest
                                {
                                    AckIds = { acks },
                                    ModifyDeadlineAckIds = { extends },
                                    ModifyDeadlineSeconds = { extends.Select(_ => _modifyDeadlineSeconds) },
                                }));
                            }catch (Exception e)
                            {
                                M($"[Push:{tempId}] EXCEPTION {e}");
                                throw;
                            }
                            M($"[Push:{tempId}] BB");
                            // Decrement _unAckedMsgCount by the number of acks just successfully sent.
                            _qLock.Locked(() => _unAckedMsgCount -= acks.Count);
                            M($"[Push:{tempId}] CC");
                        }
                        M($"[Push:{tempId}] _stateManager.IsRunning:{_stateManager.IsRunning}  _unAckedMsgCount:{_qLock.Locked(() => _unAckedMsgCount)}");
                        if (!_stateManager.IsRunning && _qLock.Locked(() => _unAckedMsgCount == 0))
                        {
                            M($"[Push:{tempId}] not running, and all acks sent.");
                            // All acks sent and a soft-stop has been requested, so cancel _hardStopCts
                            // to signal this SingleChannel has completed; then exit Pusher
                            _hardStopCts.Cancel();
                            break;
                        }
                    }
                }
                catch (Exception e) when (!e.IsCancellation())
                {
                    // If there is a fault with the Push
                    // TODO: Log the fault
                    faultCts.Cancel();
                }
            }
        }
    }
}
