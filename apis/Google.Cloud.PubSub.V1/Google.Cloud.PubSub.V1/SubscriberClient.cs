// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
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

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable ConfigureAwaitChecker // CAC001

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// A PubSub subscriber that is associated with a specific <see cref="SubscriptionName"/>.
    /// </summary>
    /// <remarks>
    /// <para>To receive messages, the <see cref="StartAsync"/> method must be called,
    /// with a suitable message handler.</para>
    /// <para>The message handler <see cref="Reply"/> states whether to acknowledge the message;
    /// if acknowledged then (under normal conditions) it will not be received on this subscription again.</para>
    /// <para>But note that it is always possible to receive duplicate messages. This services
    /// guarantees "at least once" delivery, not "only once" delivery.</para>
    /// </remarks>
    public abstract class SubscriberClient
    {
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
        /// Settings for <see cref="SubscriberClient"/>.
        /// Defaults will be used for <c>null</c> properties.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Create a new instance.
            /// </summary>
            public Settings() { }

            internal Settings(Settings other)
            {
                FlowControlSettings = other.FlowControlSettings;
                StreamAckDeadline = other.StreamAckDeadline;
                AckExtensionWindow = other.AckExtensionWindow;
                Scheduler = other.Scheduler;
            }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// The lease time before which a message must either be ACKed
            /// or have its lease extended. This is truncated to the nearest second.
            /// If <c>null</c>, uses the default of <see cref="DefaultStreamAckDeadline"/>.
            /// </summary>
            public TimeSpan? StreamAckDeadline { get; set; }

            /// <summary>
            /// Duration before <see cref="StreamAckDeadline"/> at which the message ACK deadline
            /// is automatically extended.
            /// If <c>null</c>, uses the default of <see cref="DefaultAckExtensionWindow"/>.
            /// </summary>
            public TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> used to schedule delays.
            /// If <c>null</c>, the default <see cref="SystemScheduler"/> is used.
            /// This is usually only used for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            internal void Validate()
            {
                GaxPreconditions.CheckArgumentRange(StreamAckDeadline, nameof(StreamAckDeadline), MinimumStreamAckDeadline, MaximumStreamAckDeadline);
                var maxAckExtension = TimeSpan.FromTicks((StreamAckDeadline ?? DefaultStreamAckDeadline).Ticks / 2);
                GaxPreconditions.CheckArgumentRange(AckExtensionWindow, nameof(AckExtensionWindow), MinimumAckExtensionWindow, maxAckExtension);
            }

            /// <summary>
            /// Create a clone of this object.
            /// </summary>
            /// <returns>A clone of this object.</returns>
            public Settings Clone() => new Settings(this);
        }

        /// <summary>
        /// Settings for creating <see cref="SubscriberServiceApiClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.</param>
            /// <param name="subscriberServiceApiSettings">Optional. The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="SubscriberServiceApiClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                SubscriberServiceApiSettings subscriberServiceApiSettings = null,
                ChannelCredentials credentials = null,
                ServiceEndpoint serviceEndpoint = null)
            {
                ClientCount = clientCount;
                SubscriberServiceApiSettings = subscriberServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
            }

            /// <summary>
            /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.
            /// If set, must be in the range 1 to 256 (inclusive).
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiSettings.GetDefault"/>.
            /// </summary>
            public SubscriberServiceApiSettings SubscriberServiceApiSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public ServiceEndpoint ServiceEndpoint { get; }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.
        /// Allows 10,000 outstanding messages; and 20Mb outstanding bytes.
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings { get; } = new FlowControlSettings(10_000, 20_000_000);

        /// <summary>
        /// The service-defined minimum message ACKnowledgement deadline of 10 seconds.
        /// </summary>
        public static TimeSpan MinimumStreamAckDeadline { get; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// The service-defined maximum message ACKnowledgement deadline of 10 minutes.
        /// </summary>
        public static TimeSpan MaximumStreamAckDeadline { get; } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// The default message ACKnowledgement deadline of 60 seconds.
        /// </summary>
        public static TimeSpan DefaultStreamAckDeadline { get; } = TimeSpan.FromSeconds(60);

        /// <summary>
        /// The minimum message ACKnowledgement extension window of 50 milliseconds.
        /// </summary>
        public static TimeSpan MinimumAckExtensionWindow { get; } = TimeSpan.FromMilliseconds(50);

        /// <summary>
        /// The default message ACKnowlegdment extension window of 15 seconds.
        /// </summary>
        public static TimeSpan DefaultAckExtensionWindow { get; } = TimeSpan.FromSeconds(15);

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially <see cref="Settings.StreamAckDeadline"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="SubscriberClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static async Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            clientCreationSettings?.Validate();
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            var clientCount = clientCreationSettings?.ClientCount ?? Environment.ProcessorCount;
            var channelCredentials = clientCreationSettings?.Credentials;
            // Use default credentials if none given.
            if (channelCredentials == null)
            {
                var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                if (credentials.IsCreateScopedRequired)
                {
                    credentials = credentials.CreateScoped(SubscriberServiceApiClient.DefaultScopes);
                }
                channelCredentials = credentials.ToChannelCredentials();
            }
            // Create the channels and clients, and register shutdown functions for each channel
            var endpoint = clientCreationSettings?.ServiceEndpoint ?? SubscriberServiceApiClient.DefaultEndpoint;
            var clients = new SubscriberServiceApiClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            // Set channel send/recv message size to unlimited. It defaults to ~4Mb which causes failures.
            var channelOptions = new[]
            {
                new ChannelOption(ChannelOptions.MaxSendMessageLength, -1),
                new ChannelOption(ChannelOptions.MaxReceiveMessageLength, -1),
            };
            for (int i = 0; i < clientCount; i++)
            {
                var channel = new Channel(endpoint.Host, endpoint.Port, channelCredentials, channelOptions);
                clients[i] = SubscriberServiceApiClient.Create(channel, clientCreationSettings?.SubscriberServiceApiSettings);
                shutdowns[i] = channel.ShutdownAsync;
            }
            Task Shutdown() => Task.WhenAll(shutdowns.Select(x => x()));
            return new SubscriberClientImpl(subscriptionName, clients, settings, Shutdown);
        }

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The gRPC <see cref="Channel"/>s underlying the provided <see cref="SubscriberServiceApiClient"/>s must have their
        /// maximum send and maximum receive sizes set to unlimited, otherwise performance will be severly affected,
        /// possibly causing a deadlock.
        /// The default <paramref name="settings"/> are suitable for machines with high network bandwidth (e.g. Google
        /// Compute Engine instances). If running with more limited network bandwidth, some settings may need changing;
        /// especially <see cref="Settings.StreamAckDeadline"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
        /// For high performance, these should all use distinct <see cref="Channel"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static SubscriberClient Create(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings = null) =>
            new SubscriberClientImpl(subscriptionName, clients, settings?.Clone() ?? new Settings(), null);

        /// <summary>
        /// The associated <see cref="SubscriptionName"/>.
        /// </summary>
        public virtual SubscriptionName SubscriptionName => throw new NotImplementedException();

        /// <summary>
        /// Starts receiving messages. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
        /// or if an unrecoverable fault occurs. See <see cref="StopAsync(CancellationToken)"/> for more details.
        /// This method cannot be called more than once per <see cref="SubscriberClient"/> instance.
        /// </summary>
        /// <param name="handlerAsync">The handler function that is passed all received messages.
        /// This function may be called on multiple threads concurrently. Return <see cref="Reply.Ack"/> from this function
        /// to ACKnowledge this message (implying it won't be received again); or return <see cref="Reply.Nack"/> to Not
        /// ACKnowledge this message (implying it will be received again). If this function throws any Exception, then
        /// it behaves as if it returned <see cref="Reply.Nack"/>.</param>
        /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
        public virtual Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) => throw new NotImplementedException();

        /// <summary>
        /// Stop this <see cref="SubscriberClient"/>. Cancelling <paramref name="hardStopToken"/> aborts the
        /// clean stop process, and may leave some handled messages un-ACKnowledged.
        /// The returned <see cref="Task"/> completes when all handled messages have been ACKnowledged.
        /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
        /// The returned <see cref="Task"/> cancels if <paramref name="hardStopToken"/> is cancelled.
        /// </summary>
        /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort handlers and ACKnowledgement.</param>
        /// <returns>A <see cref="Task"/> that completes when all handled messages have been ACKnowledged;
        /// faults on unrecoverable service errors; or cancels if <paramref name="hardStopToken"/> is cancelled.</returns>
        public virtual Task StopAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// Stop this <see cref="SubscriberClient"/>. If <paramref name="timeout"/> expires, the
        /// clean stop process will be aborted, and may leave some handled messages un-ACKnowledged.
        /// The returned <see cref="Task"/> completes when all handled messages have been ACKnowledged.
        /// The returned <see cref="Task"/> faults if there is an unrecoverable error with the underlying service.
        /// The returned <see cref="Task"/> cancels if <paramref name="timeout"/> expires.
        /// </summary>
        /// <param name="timeout">After this period, abort handling and ACKnowledging messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all handled messages have been ACKnowledged;
        /// faults on unrecoverable service errors; or cancels if <paramref name="timeout"/> expires.</returns>
        public virtual Task StopAsync(TimeSpan timeout) => StopAsync(new CancellationTokenSource(timeout).Token);
    }

    /// <summary>
    /// Implementation of <see cref="SubscriberClient"/>. 
    /// </summary>
    public sealed class SubscriberClientImpl : SubscriberClient
    {
        // TODO: Logging

        /// <summary>
        /// Instantiate a <see cref="SubscriberClientImpl"/> associated with the specified <see cref="SubscriptionName"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
        /// For high performance, these should all use distinct <see cref="Channel"/>s.</param>
        /// <param name="settings"><see cref="SubscriberClient.Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <param name="shutdown">Function to call on this <see cref="SubscriberClientImpl"/> shutdown.</param>
        public SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown)
            : this(subscriptionName, clients, settings, shutdown, TaskHelper.Default) { }

        internal SubscriberClientImpl(SubscriptionName subscriptionName, IEnumerable<SubscriberServiceApiClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
        {
            SubscriptionName = GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            GaxPreconditions.CheckNotNull(clients, nameof(clients));
            _clients = clients.ToArray();
            GaxPreconditions.CheckArgument(_clients.Length > 0, nameof(clients), "Must contain at least one client");
            GaxPreconditions.CheckArgument(_clients.All(x => x != null), nameof(clients), "All elements must be non-null");
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            settings.Validate();
            _modifyDeadlineSeconds = (int)((settings.StreamAckDeadline ?? DefaultStreamAckDeadline).TotalSeconds);
            _autoExtendInterval = TimeSpan.FromSeconds(_modifyDeadlineSeconds) - (settings.AckExtensionWindow ?? DefaultAckExtensionWindow);
            _shutdown = shutdown;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings;
            _maxAckExtendQueue = (int)Math.Min(_flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, 20_000);
        }

        private readonly object _lock = new object();
        private readonly SubscriberServiceApiClient[] _clients;
        private readonly Func<Task> _shutdown;
        private readonly TimeSpan _autoExtendInterval; // Interval between message lease auto-extends
        private readonly int _modifyDeadlineSeconds; // Value to use as new deadline when lease auto-extends
        private readonly int _maxAckExtendQueue; // Maximum count of acks/extends to push to server in a single messages
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly FlowControlSettings _flowControlSettings;

        private TaskCompletionSource<int> _mainTcs;
        private CancellationTokenSource _globalSoftStopCts; // soft-stop is guarenteed to occur before hard-stop.
        private CancellationTokenSource _globalHardStopCts;

        /// <inheritdoc />
        public override SubscriptionName SubscriptionName { get; }

        /// <inheritdoc />
        public override Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync)
        {
            lock (_lock)
            {
                GaxPreconditions.CheckState(_mainTcs == null, "Can only start an instance once.");
                _mainTcs = new TaskCompletionSource<int>();
                _globalSoftStopCts = new CancellationTokenSource();
                _globalHardStopCts = new CancellationTokenSource();
            }
            var registeredTasks = new HashSet<Task>();
            Action<Task> registerTask = task =>
            {
                registeredTasks.Locked(() => registeredTasks.Add(task));
                Action unregisterTask = () => registeredTasks.Locked(() => registeredTasks.Remove(task));
                _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(() => task, unregisterTask));
            };
            Flow flow = new Flow(_flowControlSettings.MaxOutstandingByteCount ?? long.MaxValue,
                _flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, registerTask, _taskHelper);
            // Start all subscribers
            var subscriberTasks = _clients.Select(client =>
            {
                var singleChannel = new SingleChannel(this, client, handlerAsync, flow, registerTask);
                return singleChannel.StartAsync();
            }).ToArray();
            // Set up finish task
            _taskHelper.Run(async () =>
            {
                // WhenAny() always returns a non-faulted task, so the await will never throw.
                var task = await _taskHelper.ConfigureAwait(_taskHelper.WhenAny(subscriberTasks));
                if (task.IsFaulted)
                {
                    _globalSoftStopCts.Cancel();
                    _globalHardStopCts.Cancel();
                }
                // Wait for all subscribers to stop
                var exception = await _taskHelper.ConfigureAwaitHideErrors(() => _taskHelper.WhenAll(subscriberTasks));
                // Wait for all registered Tasks to stop
                await _taskHelper.ConfigureAwaitHideErrors(
                    () => _taskHelper.WhenAll(registeredTasks.Locked(() => registeredTasks.ToArray())));
                // Call shutdown function
                if (_shutdown != null)
                {
                    await _taskHelper.ConfigureAwaitHideErrors(_shutdown);
                }
                // Return final result
                var exceptions = ((exception as AggregateException)?.Flatten().InnerExceptions) ??
                    Enumerable.Repeat(exception, exception == null ? 0 : 1);
                if (exceptions.Any())
                {
                    _mainTcs.SetException(exceptions);
                }
                else if (_globalHardStopCts.IsCancellationRequested)
                {
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
                GaxPreconditions.CheckState(_mainTcs != null, "Can only stop a started instance.");
            }
            _globalSoftStopCts.Cancel();
            var registration = hardStopToken.Register(() => _globalHardStopCts.Cancel());
            // Do not register this Task to be awaited on at shutdown.
            // It completes *after* _mainTcs, and all registered tasks must complete before _mainTcs
            _taskHelper.Run(async () =>
                await _taskHelper.ConfigureAwaitWithFinally(() => _mainTcs.Task, () => registration.Dispose()));
            return _mainTcs.Task;
        }

        /// <summary>
        /// Implements flow control for received messages.
        /// Processes received messages so long as the current outstanding message-count and byte-count are below limits.
        /// </summary>
        private class Flow
        {
            public Flow(long maxByteCount, long maxElementCount, Action<Task> registerTaskFn, TaskHelper taskHelper)
            {
                _maxByteCount = maxByteCount;
                _maxElementCount = maxElementCount;
                _registerTaskFn = registerTaskFn;
                _taskHelper = taskHelper;
                _event = new AsyncAutoResetEvent(taskHelper);
            }

            private readonly object _lock = new object();
            private readonly long _maxByteCount;
            private readonly long _maxElementCount;
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;
            private readonly AsyncAutoResetEvent _event;

            private long _byteCount;
            private long _elementCount;

            /// <summary>
            /// Is flow-control currently within limits. Pre-condition: must be locked.
            /// </summary>
            private bool IsFlowOk() => _byteCount < _maxByteCount && _elementCount < _maxElementCount;

            /// <summary>
            /// Call <paramref name="fn"/> when allowed to do so by the flow-control limits.
            /// This will alter the current byte-count (by <paramref name="byteCount"/>) and
            /// element-count (by 1), and only call <paramref name="fn"/> once flow-control is
            /// within the limits.
            /// The returned Task will complete once <paramref name="fn"/> has been scheduled
            /// for execution on a Task; note this does not wait until <paramref name="fn"/>
            /// has completed.
            /// </summary>
            /// <param name="byteCount">The number of bytes in the element associated with <paramref name="fn"/>.</param>
            /// <param name="fn">The function to execute.</param>
            /// <returns>A Task that completes once <paramref name="fn"/> has been scheduled for execution.</returns>
            public async Task Process(long byteCount, Func<Task> fn)
            {
                while (true)
                {
                    lock (_lock)
                    {
                        if (IsFlowOk())
                        {
                            // Flow is OK, so add for this element, and execute.
                            _byteCount += byteCount;
                            _elementCount += 1;
                            break;
                        }
                    }
                    // Flow not OK, wait until a previous fn completes.
                    // CancellationToken not required, as the fn() will always drain on cancellation.
                    await _taskHelper.ConfigureAwait(_event.WaitAsync(CancellationToken.None));
                }
                // Execute fn, and schedule the following code to execute once it has completed.
                // Register the function, so we can be sure it's completed during shutdown.
                _registerTaskFn(_taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn, () =>
                {
                    bool setEvent;
                    lock (_lock)
                    {
                        bool preIsFlowOk = IsFlowOk();
                        _byteCount -= byteCount;
                        _elementCount -= 1;
                        // If moving from flow-bad to flow-OK, then trigger the next execution.
                        setEvent = !preIsFlowOk && IsFlowOk();
                    }
                    if (setEvent)
                    {
                        _event.Set();
                    }
                })));
            }
        }

        /// <summary>
        /// Controls a single <see cref="Channel"/>/<see cref="SubscriberClient"/> within this
        /// <see cref="SubscriberClientImpl"/>. This class controls the pulling of messages, and
        /// the pushing of message acks and lease-extensions back to the server.
        /// It also manages error conditions within the channel, restarting the StreamingPull()
        /// RPC as required.
        /// </summary>
        private class SingleChannel
        {
            public SingleChannel(SubscriberClientImpl subscriber,
                SubscriberServiceApiClient client, Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync,
                Flow flow,
                Action<Task> registerTaskFn)
            {
                _subscriptionName = subscriber.SubscriptionName;
                _client = client;
                _handlerAsync = handlerAsync;
                _autoExtendInterval = subscriber._autoExtendInterval;
                _modifyDeadlineSeconds = subscriber._modifyDeadlineSeconds;
                _maxAckExtendQueueSize = subscriber._maxAckExtendQueue;
                _flow = flow;
                _registerTaskFn = registerTaskFn;
                _scheduler = subscriber._scheduler;
                _taskHelper = subscriber._taskHelper;
                _softStopCts = subscriber._globalSoftStopCts;
                _hardStopCts = CancellationTokenSource.CreateLinkedTokenSource(subscriber._globalHardStopCts.Token);
                _qEvent = new AsyncAutoResetEvent(_taskHelper);
                subscriber._globalSoftStopCts.Token.Register(() => _qEvent.Set());
                subscriber._globalHardStopCts.Token.Register(() => _qEvent.Set());
            }

            private readonly SubscriptionName _subscriptionName;
            private readonly SubscriberServiceApiClient _client;
            private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handlerAsync;
            private readonly TimeSpan _autoExtendInterval;
            private readonly int _modifyDeadlineSeconds;
            private readonly int _maxAckExtendQueueSize;
            private readonly Flow _flow;
            private readonly Action<Task> _registerTaskFn;
            private readonly IScheduler _scheduler;
            private readonly TaskHelper _taskHelper;
            private readonly CancellationTokenSource _softStopCts;
            private readonly CancellationTokenSource _hardStopCts;

            private readonly object _qLock = new object();
            private readonly Queue<string> _ackQueue = new Queue<string>();
            private readonly Queue<string> _extendQueue = new Queue<string>();
            private int _unAckedMsgCount;
            private AsyncAutoResetEvent _qEvent;

            // States:
            // Push faulted: local immediate stop/restart streaming-pull request
            // - push task faults, which cancels streamingPullCts
            // Pull faulted: local immediate stop/restart streaming-pull request
            // - pull task faults, which cancels streamingPullCts
            // soft-stop requested: no more msg processing/receiving, stop pull; continue push, then local hard-stop when all acks done
            // - Pull task completes, which does not cancel streamingPullCts
            // hard-stop requested: immediate stop of pull and push
            // - Pull and Push fault, if they are still running
            // Pull call completes; ie MoveNext() returns false: immediate stop of Push, restart stream-pull request
            // - Pull and Push complete

            public async Task StartAsync()
            {
                // Loop to restart pull if it fails recoverably.
                while (!_hardStopCts.IsCancellationRequested)
                {
                    SubscriberServiceApiClient.StreamingPullStream pull = null;
                    // The CancellationTokenSource that reflects the state of the StreamingPull() RPC.
                    // This is cancelled once the StreamingPull() RPC has an error.
                    var streamingPullCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                    try
                    {
                        pull = _client.StreamingPull(CallSettings.FromCancellationToken(streamingPullCts.Token), new BidirectionalStreamingSettings(1));
                        // Initial call to start subscribe messages arriving.
                        await _taskHelper.ConfigureAwait(pull.WriteAsync(new StreamingPullRequest
                        {
                            SubscriptionAsSubscriptionName = _subscriptionName,
                            StreamAckDeadlineSeconds = _modifyDeadlineSeconds
                        }));
                        // Start Push task which pushes acks and extends.
                        var pushTask = _taskHelper.Run(() => Push(pull, streamingPullCts.Token));
                        // Read incoming messages whilst not stopped, and not in a fault condition.
                        var pullTask = _taskHelper.Run(() => Pull(pull, streamingPullCts.Token));
                        // Trigger _qEvent, to restart pushes with new streaming-pull
                        _qEvent.Set();
                        // Wait for either pull or push to complete. This will not throw on error or cancellation.
                        var completedTask = await _taskHelper.ConfigureAwait(_taskHelper.WhenAny(pushTask, pullTask));
                        // If fault: RPC is broken, need to cancel and restart
                        // If cancelled: Softstop or hardstop.
                        // * If hard-stop: Everything already cancelled, do nothing; or could cancel, it'll be a nop
                        // * If soft-stop: Need to allow push to continue, do nothing
                        // If completed OK: Server has terminated RPC, need to restart
                        if (completedTask.IsFaulted || !completedTask.IsCanceled)
                        {
                            streamingPullCts.Cancel();
                        }
                        _qEvent.Set();
                        // Await until pull and push have both stopped.
                        // If pull of push is faulted/cancelled, this will throw.
                        await _taskHelper.ConfigureAwait(_taskHelper.WhenAll(pushTask, pullTask));
                    }
                    catch (Exception e0) when (
                        e0.AllExceptions().All(e => e.IsCancellation() || (e.As<RpcException>()?.IsRecoverable() ?? false)))
                    {
                        // If all errors are recoverable, then do nothing here; restart pull on loop.
                    }
                    finally
                    {
                        // Try to cleanly shutdown the subscriber. This may or may not be possible
                        // depending on the state of the subscriber; ignore all errors.
                        if (pull != null)
                        {
                            _registerTaskFn(_taskHelper.Run(() => pull.WriteCompleteAsync()));
                        }
                        streamingPullCts.Dispose();
                    }
                }
            }

            private async Task Pull(SubscriberServiceApiClient.StreamingPullStream pull, CancellationToken streamingPullToken)
            {
                // This method returns normally on cancellation. The caller handles cancellation.
                using (var cts = CancellationTokenSource.CreateLinkedTokenSource(streamingPullToken, _softStopCts.Token))
                {
                    async Task<bool> MoveNext()
                    {
                        // Pause pulling more messages if too many msgs are locally queued for sending.
                        // The size of the extend queue is a reasonable proxy for push loading.
                        while (_qLock.Locked(() => _extendQueue.Count) >= _maxAckExtendQueueSize)
                        {
                            // A 100ms pause is fairly arbitrary, but should never cause problems.
                            // Using an event would be better, but this is simpler and easier to assure correctness.
                            await _taskHelper.ConfigureAwait(_scheduler.Delay(TimeSpan.FromMilliseconds(100), cts.Token));
                        }
                        // Don't use a cancellation-token here, as it will cancel the whole call.
                        // This isn't desirable, as push operations may still be ongoing.
                        return await pull.ResponseStream.MoveNext(CancellationToken.None);
                    }
                    while (await _taskHelper.ConfigureAwait(MoveNext()))
                    {
                        cts.Token.ThrowIfCancellationRequested();
                        var receivedMessages = pull.ResponseStream.Current.ReceivedMessages;
                        // Copy msgs to list, and clear original proto repeatedfield;
                        // to remove refs to large messages as soon as possible.
                        var msgs = receivedMessages.ToList();
                        receivedMessages.Clear();
                        var extendIds = new HashSet<string>(msgs.Select(x => x.AckId));
                        // Extend leases immediately. This is the receipt to the server that starts the server lease timeout.
                        QueueLeaseExtensions(extendIds);
                        var allMsgsHandledCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                        _registerTaskFn(_taskHelper.Run(() => AutoExtend(extendIds, allMsgsHandledCts)));
                        for (int msgIndex = 0; msgIndex < msgs.Count; msgIndex++)
                        {
                            var msg = msgs[msgIndex];
                            // Remove reference to message. In case a small number of messages from each
                            // pull take a long time to process. This ensures all other messages aren't still referenced.
                            msgs[msgIndex] = null;
                            // If stop requested, then don't start processing any further messages.
                            _softStopCts.Token.ThrowIfCancellationRequested();
                            // Returned Task completes once flow-control is satisfied.
                            await _taskHelper.ConfigureAwait(_flow.Process(msg.CalculateSize(), async () =>
                            {
                                // If stop requested, then don't start processing any further messages.
                                _softStopCts.Token.ThrowIfCancellationRequested();
                                lock (_qLock)
                                {
                                    _unAckedMsgCount += 1;
                                }
                                // Execute the user-provided message handler, and ignoring exceptions.
                                // And process the ACK/NACK response.
                                var reply = await _taskHelper.ConfigureAwaitHideErrors(
                                    () => _handlerAsync(msg.Message, _hardStopCts.Token), Reply.Nack);
                                bool triggerQEvent = false;
                                lock (_qLock)
                                {
                                    extendIds.Remove(msg.AckId);
                                    if (extendIds.Count == 0)
                                    {
                                        allMsgsHandledCts.Cancel();
                                    }
                                    if (reply == Reply.Ack)
                                    {
                                        _ackQueue.Enqueue(msg.AckId);
                                        triggerQEvent = true;
                                    }
                                    else
                                    {
                                        _unAckedMsgCount -= 1;
                                    }
                                }
                                if (triggerQEvent)
                                {
                                    // Unblock Push(), because now there is at least one ACK to push.
                                    _qEvent.Set();
                                }
                            }));
                        }
                    }
                }
            }

            private void QueueLeaseExtensions(IEnumerable<string> ackIds)
            {
                lock (_qLock)
                {
                    _extendQueue.EnqueueAll(ackIds);
                }
                _qEvent.Set();
            }

            private async Task AutoExtend(HashSet<string> ackIds, CancellationTokenSource allMsgsHandled)
            {
                // Moves ackIds into the extend-queue as required for auto lease extension
                // This loop is not infinite; it terminates when allMsgsHandledToken is cancelled.
                try
                {
                    while (true)
                    {
                        bool isCancelled = await _taskHelper.ConfigureAwaitHideCancellation(
                            () => _scheduler.Delay(_autoExtendInterval, allMsgsHandled.Token));
                        if (isCancelled)
                        {
                            return;
                        }
                        // Queue lease extensions on all not-yet-processed messages.
                        // It's OK if an ID is lease-extended and ACKed to the server concurrently.
                        // The ACK takes precedence on the server.
                        QueueLeaseExtensions(ackIds);
                    }
                }
                finally
                {
                    allMsgsHandled.Dispose();
                }
            }

            private async Task Push(SubscriberServiceApiClient.StreamingPullStream pull, CancellationToken streamingPullToken)
            {
                // Send ack/extends in smaller chunks than maximum ack/extend queue size.
                // This temporally smooths out server message receipt, which causes higher
                // sustained message delivery in high-bandwidth environments.
                var maxAckExtendSendCount = Math.Max(10, _maxAckExtendQueueSize / 4);
                // Pushing of acks and extends
                // If a Push call fails then this Task always ends, and the StreamingPull is cancelled.
                // If it's recoverable, then a new StreamingPull call is started.
                // If it's unrecoverable, then a global hard stop occurs.
                while (true)
                {
                    // Wait until there are acks or lease-extensions to push to server.
                    while (_qLock.Locked(() => _ackQueue.Count == 0 && _extendQueue.Count == 0))
                    {
                        if (_softStopCts.IsCancellationRequested && _qLock.Locked(() => _unAckedMsgCount == 0))
                        {
                            // All acks sent and a stop has been requested, so cancel local _hardStopCts
                            // to signal this SingleChannel has completed; then exit Pusher
                            _hardStopCts.Cancel();
                            return;
                        }
                        await _taskHelper.ConfigureAwait(_qEvent.WaitAsync(streamingPullToken));
                    }
                    // Get local copies of acks/extensions to send.
                    List<string> acks;
                    List<string> extends;
                    lock (_qLock)
                    {
                        acks = _ackQueue.Take(maxAckExtendSendCount).ToList();
                        extends = _extendQueue.Take(maxAckExtendSendCount - acks.Count).ToList();
                    }
                    var req = new StreamingPullRequest
                    {
                        AckIds = { acks },
                        // Don't lease-extend any msg that is also being acked.
                        ModifyDeadlineAckIds = { extends.Except(acks) }
                    };
                    req.ModifyDeadlineSeconds.AddRange(Enumerable.Repeat(_modifyDeadlineSeconds, req.ModifyDeadlineAckIds.Count));
                    // Send acks/extensions
                    await _taskHelper.ConfigureAwait(pull.WriteAsync(req));
                    // If the send didn't have errors, then dequeue the acks/extends that were just sent.
                    // Any error would have thrown an exception in the previous WriteAsync() call.
                    lock (_qLock)
                    {
                        _ackQueue.Dequeue(acks.Count);
                        _extendQueue.Dequeue(extends.Count);
                        _unAckedMsgCount -= acks.Count;
                    }
                }
            }
        }
    }
}
