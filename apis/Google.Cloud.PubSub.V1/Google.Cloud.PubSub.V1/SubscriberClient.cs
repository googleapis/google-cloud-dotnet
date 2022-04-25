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
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable CAC001
#pragma warning disable CAC002

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
        private static readonly GrpcChannelOptions s_unlimitedSendReceiveChannelOptions = GrpcChannelOptions.Empty
            .WithMaxReceiveMessageSize(int.MaxValue)
            .WithMaxSendMessageSize(int.MaxValue)
            // Set max metadata size to 4 MB i.e., 4194304 bytes.
            .WithCustomOption("grpc.max_metadata_size", 4194304);

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
                AckDeadline = other.AckDeadline;
                AckExtensionWindow = other.AckExtensionWindow;
                Scheduler = other.Scheduler;
                MaxTotalAckExtension = other.MaxTotalAckExtension;
            }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// If set to true, disables enforcing flow control settings at the Cloud PubSub server
            /// and uses the less accurate method of only enforcing flow control at the client side.
            /// </summary>
            public bool UseLegacyFlowControl { get; set; } = false;

            /// <summary>
            /// The lease time before which a message must either be ACKed
            /// or have its lease extended. This is truncated to the nearest second.
            /// If <c>null</c>, uses the default of <see cref="DefaultAckDeadline"/>.
            /// </summary>
            public TimeSpan? AckDeadline { get; set; }

            /// <summary>
            /// Duration before <see cref="AckDeadline"/> at which the message ACK deadline
            /// is automatically extended.
            /// If <c>null</c>, uses the default of <see cref="DefaultAckExtensionWindow"/>.
            /// </summary>
            public TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// Maximum duration for which a message ACK deadline will be extended.
            /// If <c>null</c>, uses the default of <see cref="DefaultMaxTotalAckExtension"/>.
            /// </summary>
            public TimeSpan? MaxTotalAckExtension { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> used to schedule delays.
            /// If <c>null</c>, the default <see cref="SystemScheduler"/> is used.
            /// This is usually only used for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            internal void Validate()
            {
                GaxPreconditions.CheckArgumentRange(AckDeadline, nameof(AckDeadline), MinimumAckDeadline, MaximumAckDeadline);
                var maxAckExtension = TimeSpan.FromTicks((AckDeadline ?? DefaultAckDeadline).Ticks / 2);
                GaxPreconditions.CheckArgumentRange(AckExtensionWindow, nameof(AckExtensionWindow), MinimumAckExtensionWindow, maxAckExtension);
                if (MaxTotalAckExtension is TimeSpan maxTotalAckExtension)
                {
                    GaxPreconditions.CheckNonNegativeDelay(maxTotalAckExtension, nameof(MaxTotalAckExtension));
                }
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
                string serviceEndpoint = null)
                : this(clientCount, subscriberServiceApiSettings, credentials, serviceEndpoint, EmulatorDetection.None)
            {
            }

            private ClientCreationSettings(
                int? clientCount,
                SubscriberServiceApiSettings subscriberServiceApiSettings,
                ChannelCredentials credentials,
                string serviceEndpoint,
                EmulatorDetection emulatorDetection)
            {
                ClientCount = clientCount;
                SubscriberServiceApiSettings = subscriberServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
                EmulatorDetection = emulatorDetection;
            }

            /// <summary>
            /// Specifies how to respond to the presence of emulator environment variables.
            /// </summary>
            /// <remarks>
            /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
            /// environment variables are ignored.
            /// </remarks>
            public EmulatorDetection EmulatorDetection { get; }

            /// <summary>
            /// Creates a new instance of this type with the specified emulator detection value.
            /// </summary>
            /// <param name="emulatorDetection">Determines how and whether to detect the emulator.</param>
            /// <returns>The new instance</returns>
            public ClientCreationSettings WithEmulatorDetection(EmulatorDetection emulatorDetection)
            {
                GaxPreconditions.CheckEnumValue(emulatorDetection, nameof(emulatorDetection));
                return new ClientCreationSettings(ClientCount, SubscriberServiceApiSettings, Credentials, ServiceEndpoint, emulatorDetection);
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
            /// The endpoint to use when creating <see cref="SubscriberServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="SubscriberServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public string ServiceEndpoint { get; }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.
        /// Allows 1,000 outstanding messages; and 100Mb outstanding bytes.
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="SubscriberClient"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings { get; } = new FlowControlSettings(1_000, 100_000_000);

        /// <summary>
        /// The service-defined minimum message ACKnowledgement deadline of 10 seconds.
        /// </summary>
        public static TimeSpan MinimumAckDeadline { get; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// The service-defined maximum message ACKnowledgement deadline of 10 minutes.
        /// </summary>
        public static TimeSpan MaximumAckDeadline { get; } = TimeSpan.FromMinutes(10);

        /// <summary>
        /// The default message ACKnowledgement deadline of 60 seconds.
        /// </summary>
        public static TimeSpan DefaultAckDeadline { get; } = TimeSpan.FromSeconds(60);

        /// <summary>
        /// The minimum message ACKnowledgement extension window of 50 milliseconds.
        /// </summary>
        public static TimeSpan MinimumAckExtensionWindow { get; } = TimeSpan.FromMilliseconds(50);

        /// <summary>
        /// The default message ACKnowledgement extension window of 15 seconds.
        /// </summary>
        public static TimeSpan DefaultAckExtensionWindow { get; } = TimeSpan.FromSeconds(15);

        /// <summary>
        /// The enforced 5 second minimum duration between obtaining a lease on a message and when a lease extension can be requested.
        /// </summary>
        public static TimeSpan MinimumLeaseExtensionDelay { get; } = TimeSpan.FromSeconds(5);

        /// <summary>
        /// The default maximum total ACKnowledgement extension of 60 minutes.
        /// </summary>
        public static TimeSpan DefaultMaxTotalAckExtension { get; } = TimeSpan.FromMinutes(60);

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially <see cref="Settings.AckDeadline"/>.
        /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
        /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="SubscriberClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static SubscriberClient Create(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            CreateMaybeAsync(subscriptionName, clientCreationSettings, settings, isAsync: false).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially <see cref="Settings.AckDeadline"/>.
        /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
        /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="SubscriberClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="SubscriberClient"/>.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            CreateMaybeAsync(subscriptionName, clientCreationSettings, settings, isAsync: true);

        private static async Task<SubscriberClient> CreateMaybeAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings, Settings settings, bool isAsync)
        {
            GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName));
            clientCreationSettings?.Validate();
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            var clientCount = clientCreationSettings?.ClientCount ?? Environment.ProcessorCount;

            // Create the channels and clients, and register shutdown functions for each channel
            var clients = new SubscriberServiceApiClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            for (int i = 0; i < clientCount; i++)
            {
                // Use a random arg to prevent sub-channel re-use in gRPC, so each channel uses its own connection.
                var grpcChannelOptions = s_unlimitedSendReceiveChannelOptions
                    .WithCustomOption("sub-channel-separator", Guid.NewGuid().ToString());

                // First builder to handle any endpoint detection etc. We build a gRPC channel
                // with this.
                var builder = new SubscriberServiceApiClientBuilder
                {
                    EmulatorDetection = clientCreationSettings?.EmulatorDetection ?? EmulatorDetection.None,
                    Endpoint = clientCreationSettings?.ServiceEndpoint,
                    ChannelCredentials = clientCreationSettings?.Credentials,
                    Settings = clientCreationSettings?.SubscriberServiceApiSettings,
                    ChannelOptions = grpcChannelOptions
                };
                var channel = isAsync ?
                    (await builder.CreateChannelAsync(cancellationToken: default).ConfigureAwait(false)) :
                    builder.CreateChannel();

                // Second builder doesn't need to do much, as we can build a call invoker from the channel.
                clients[i] = new SubscriberServiceApiClientBuilder
                {
                    CallInvoker = channel.CreateCallInvoker(),
                    Settings = clientCreationSettings?.SubscriberServiceApiSettings
                }.Build();
                shutdowns[i] = channel.ShutdownAsync;
            }
            Task Shutdown() => Task.WhenAll(shutdowns.Select(x => x()));
            return new SubscriberClientImpl(subscriptionName, clients, settings, Shutdown);
        }

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

        internal const string DeliveryAttemptAttrKey = "googclient_deliveryattempt";

        /// <summary>
        /// Instantiate a <see cref="SubscriberClientImpl"/> associated with the specified <see cref="SubscriptionName"/>.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <param name="clients">The <see cref="SubscriberServiceApiClient"/>s to use in a <see cref="SubscriberClient"/>.
        /// For high performance, these should all use distinct <see cref="ChannelBase"/>s.</param>
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
            // These values are validated in Settings.Validate() above, so no need to re-validate here.
            _modifyDeadlineSeconds = (int)((settings.AckDeadline ?? DefaultAckDeadline).TotalSeconds);
            var autoExtendInterval = TimeSpan.FromSeconds(_modifyDeadlineSeconds) - (settings.AckExtensionWindow ?? DefaultAckExtensionWindow);
            // Ensure the duration between lease extensions is at least MinimumLeaseExtensionDelay (5 seconds).
            // The minimum allowable lease duration is 10 seconds, so this will always be reasonable.
            _autoExtendInterval = TimeSpan.FromTicks(Math.Max(autoExtendInterval.Ticks, MinimumLeaseExtensionDelay.Ticks));
            _maxExtensionDuration = settings.MaxTotalAckExtension ?? DefaultMaxTotalAckExtension;
            _shutdown = shutdown;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings;
            _useLegacyFlowControl = settings.UseLegacyFlowControl;
            _maxAckExtendQueue = (int)Math.Min(_flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, 20_000);
        }

        private readonly object _lock = new object();
        private readonly SubscriberServiceApiClient[] _clients;
        private readonly Func<Task> _shutdown;
        private readonly TimeSpan _autoExtendInterval; // Interval between message lease auto-extends
        private readonly TimeSpan _maxExtensionDuration; // Maximum duration for which a message lease will be extended.
        private readonly int _modifyDeadlineSeconds; // Value to use as new deadline when lease auto-extends
        private readonly int _maxAckExtendQueue; // Maximum count of acks/extends to push to server in a single messages
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly FlowControlSettings _flowControlSettings;
        private readonly bool _useLegacyFlowControl;

        private TaskCompletionSource<int> _mainTcs;
        private CancellationTokenSource _globalSoftStopCts; // soft-stop is guarenteed to occur before hard-stop.
        private CancellationTokenSource _globalHardStopCts;

        // This property only exists for testing.
        // This is the interval between obtaining a lease on a message and then further extending the lease on that message
        // (assuming it hasn't been handled).
        // This is calculated from the AckDeadline, AckExtensionWindow, and MinimumLeaseExtensionDelay
        internal TimeSpan AutoExtendInterval => _autoExtendInterval;

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
                Action<Task> unregisterTask = t => registeredTasks.Locked(() => registeredTasks.Remove(t));
                task.ContinueWith(unregisterTask, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, _taskHelper.TaskScheduler);
            };
            Flow flow = new Flow(_flowControlSettings.MaxOutstandingByteCount ?? long.MaxValue,
                _flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, registerTask, _taskHelper);
            // Start all subscribers
            var subscriberTasks = _clients.Select(client =>
            {
                var singleChannel = new SingleChannel(this, client, handlerAsync, flow, _useLegacyFlowControl, registerTask);
                return _taskHelper.Run(() => singleChannel.StartAsync());
            }).ToArray();
            // Set up finish task; code that executes when this subscriber is being shutdown (for whatever reason).
            _taskHelper.Run(async () => await StopCompletionAsync(subscriberTasks, registeredTasks));
            return _mainTcs.Task;
        }

        private async Task StopCompletionAsync(Task[] subscriberTasks, HashSet<Task> registeredTasks)
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
            private struct FnInfo
            {
                internal FnInfo(Func<Task> fn, long byteCount)
                {
                    Fn = fn;
                    ByteCount = byteCount;
                }
                internal Func<Task> Fn { get; }
                internal long ByteCount { get; }
            }

            internal Flow(long maxOutstandingByteCount, long maxOutstandingElementCount, Action<Task> registerTaskFn, TaskHelper taskHelper)
            {
                MaxOutstandingByteCount = maxOutstandingByteCount;
                MaxOutstandingElementCount = maxOutstandingElementCount;
                _registerTaskFn = registerTaskFn;
                _taskHelper = taskHelper;
                _event = new AsyncAutoResetEvent(taskHelper);
            }

            private readonly object _lock = new object();
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;
            private readonly AsyncAutoResetEvent _event;
            // Tracking of messages with ordering-keys.
            private readonly Dictionary<string, Queue<FnInfo>> _keyedTaskQs = new Dictionary<string, Queue<FnInfo>>();

            private long _byteCount;
            private long _elementCount;

            internal long MaxOutstandingByteCount { get; }
            internal long MaxOutstandingElementCount { get; }

            /// <summary>
            /// Is flow-control currently within limits. Pre-condition: must be locked.
            /// </summary>
            private bool IsFlowOk() => _byteCount < MaxOutstandingByteCount && _elementCount < MaxOutstandingElementCount;

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
            /// <param name="orderingKey">The ordering key for this message. Empty string if no ordering key.</param>
            /// <param name="fn">The function to execute.</param>
            /// <returns>A Task that completes once <paramref name="fn"/> has been scheduled for execution.</returns>
            internal async Task Process(long byteCount, string orderingKey, Func<Task> fn)
            {
                while (true)
                {
                    lock (_lock)
                    {
                        if (IsFlowOk())
                        {
                            // Flow is OK, so stop waiting.
                            // Add to stats for this element.
                            _byteCount += byteCount;
                            _elementCount += 1;
                            // If there's no ordering-key then the user callback function can always immediately be executed
                            // because there's no ordering constraint to meet.
                            // If there is an ordering-key then the user callback function must be executed sequentially per
                            // ordering-key.
                            if (orderingKey.Length > 0)
                            {
                                // Ordering-key is set on this message.
                                if (_keyedTaskQs.TryGetValue(orderingKey, out var taskQ))
                                {
                                    // This ordering-key is already inflight; add to queue.
                                    if (taskQ == null)
                                    {
                                        taskQ = new Queue<FnInfo>();
                                        _keyedTaskQs[orderingKey] = taskQ;
                                    }
                                    taskQ.Enqueue(new FnInfo(fn, byteCount));
                                    // Return immediately, the enqueued task will be executed by previous task with same key.
                                    return;
                                }
                                // Mark this ordering-key inflight, and allow user code for this first message to be executed.
                                // Set the queue to null to save allocation.
                                // It'll be created on-demand if more than one message with the same key are queued.
                                _keyedTaskQs.Add(orderingKey, null);
                            }
                            break;
                        }
                    }
                    // Flow not OK, wait until a previous fn completes.
                    // CancellationToken not required, as the fn() will always drain on cancellation.
                    await _taskHelper.ConfigureAwait(_event.WaitAsync(CancellationToken.None));
                }
                // Execute the user code for this message.
                ExecuteFunction(orderingKey, byteCount, fn);
            }

            private void ExecuteFunction(string orderingKey, long byteCount, Func<Task> fn)
            {
                // Execute fn, and schedule the following code to execute once it has completed.
                // Register the function, so we can be sure it's completed during shutdown.
                Task task = _taskHelper.Run(async () => await _taskHelper.ConfigureAwaitWithFinally(fn, () =>
                {
                    bool setEvent;
                    FnInfo nextFn = default;
                    lock (_lock)
                    {
                        if (orderingKey.Length > 0)
                        {
                            var taskQ = _keyedTaskQs[orderingKey];
                            if (taskQ != null && taskQ.Count > 0)
                            {
                                // More fn(s) to execute with this same ordering-key; execute the next fn.
                                nextFn = taskQ.Dequeue();
                            }
                            else
                            {
                                // All fns executed for this ordering-key; remove the key.
                                _keyedTaskQs.Remove(orderingKey);
                            }
                        }
                        bool preIsFlowOk = IsFlowOk();
                        _byteCount -= byteCount;
                        _elementCount -= 1;
                        // If moving from flow-bad to flow-OK, then trigger the next execution.
                        setEvent = !preIsFlowOk && IsFlowOk();
                    }
                    if (nextFn.Fn != null)
                    {
                        // Execute user code for the next message of this ordering-key;
                        // this is not a recursive call, as this code is within a `Task.Run` :)
                        ExecuteFunction(orderingKey, nextFn.ByteCount, nextFn.Fn);
                    }
                    if (setEvent)
                    {
                        _event.Set();
                    }
                }));
                _registerTaskFn(task);
            }
        }

        // internal for testing.
        /// <summary>
        /// A queue that allows data to be requeued at the front of the queue.
        /// Requeued items are queued after previously requeued items, but before queued items.
        /// </summary>
        internal class RequeueableQueue<T>
        {
            private readonly Queue<T> _q = new Queue<T>();
            private readonly LinkedList<Queue<T>> _qs = new LinkedList<Queue<T>>();
            private int _requeueCount = 0;

            internal void Enqueue(T item) => _q.Enqueue(item);

            internal void Enqueue(IEnumerable<T> items)
            {
                foreach (var item in items)
                {
                    _q.Enqueue(item);
                }
            }

            internal void Requeue(IEnumerable<T> items)
            {
                var q = new Queue<T>(items);
                _qs.AddLast(q);
                _requeueCount += q.Count;
            }

            internal int Count => _q.Count + _requeueCount;

            /// <summary>
            /// Dequeue up to maxCount items.
            /// Any items that are not included in the return value due to <c>includeFn</c> are discarded.
            /// </summary>
            /// <param name="maxCount">Maximum count of items to dequeue.</param>
            /// <param name="includeFn">If not null, must return <c>true</c> for the item to be included.</param>
            /// <returns></returns>
            internal List<T> Dequeue(int maxCount, Predicate<T> includeFn)
            {
                List<T> result = new List<T>();
                Queue<T> q = _qs.First?.Value;
                if (q != null)
                {
                    while (result.Count < maxCount)
                    {
                        if (q.Count > 0)
                        {
                            var item = q.Dequeue();
                            _requeueCount -= 1;
                            if (includeFn == null || includeFn(item))
                            {
                                result.Add(item);
                            }
                        }
                        else
                        {
                            _qs.RemoveFirst();
                            q = _qs.First?.Value;
                            if (q == null)
                            {
                                break;
                            }
                        }
                    }
                }
                while (result.Count < maxCount && _q.Count > 0)
                {
                    var item = _q.Dequeue();
                    if (includeFn == null || includeFn(item))
                    {
                        result.Add(item);
                    }
                }
                return result;
            }

            internal bool TryPeek(out T value)
            {
                var qsNode = _qs.First;
                while (qsNode != null)
                {
                    if (qsNode.Value.Count > 0)
                    {
                        value = qsNode.Value.Peek();
                        return true;
                    }
                    qsNode = qsNode.Next;
                }
                if (_q.Count > 0)
                {
                    value = _q.Peek();
                    return true;
                }
                value = default(T);
                return false;
            }
        }

        internal class AsyncSingleRecvQueue<T>
        {
            internal AsyncSingleRecvQueue(TaskHelper taskHelper) => _taskHelper = taskHelper;

            private readonly TaskHelper _taskHelper;
            private readonly object _lock = new object();
            private readonly Queue<T> _queue = new Queue<T>();
            private TaskCompletionSource<int> _tcs = null;

            // Thread-safe.
            internal void Enqueue(T item)
            {
                TaskCompletionSource<int> tcs;
                lock (_lock)
                {
                    _queue.Enqueue(item);
                    tcs = _tcs;
                }
                if (tcs != null)
                {
                    // Don't run in lock, as it may execute continuations synchronously.
                    // Use TrySetResult as this can be called multiple times on the same tcs instance
                    tcs.TrySetResult(0);
                }
            }

            // Thread-safe to use concurrently with Enqueue(),
            // but this DequeueAsync() method must *not* be called concurrently.
            internal async Task<T> DequeueAsync()
            {
                lock (_lock)
                {
                    if (_queue.Count > 0)
                    {
                        return _queue.Dequeue();
                    }
                    _tcs = new TaskCompletionSource<int>();
                }
                await _taskHelper.ConfigureAwait(_tcs.Task);
                lock (_lock)
                {
                    _tcs = null;
                    return _queue.Dequeue();
                }
            }
        }

        /// <summary>
        /// Controls a single <see cref="ChannelBase"/>/<see cref="SubscriberClient"/> within this
        /// <see cref="SubscriberClientImpl"/>. This class controls the pulling of messages, and
        /// the pushing of message acks and lease-extensions back to the server.
        /// It also manages error conditions within the channel, restarting RPCs as required.
        /// </summary>
        private class SingleChannel
        {
            private struct NextAction
            {
                internal NextAction(bool isPull, Action action)
                {
                    IsPull = isPull;
                    Action = action;
                }
                internal bool IsPull { get; }
                internal Action Action { get; }
            }

            private struct TaskNextAction
            {
                internal TaskNextAction(Task task, NextAction nextAction)
                {
                    Task = task;
                    NextAction = nextAction;
                }
                internal Task Task { get; }
                internal NextAction NextAction { get; }
            }

            private struct TimedId // "Time" is abstract, a monotonic incrementing counter is used.
            {
                internal TimedId(long time, string id)
                {
                    Time = time;
                    Id = id;
                }
                internal long Time { get; }
                internal string Id { get; }
            }

            internal SingleChannel(SubscriberClientImpl subscriber,
                SubscriberServiceApiClient client, Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync,
                Flow flow, bool useLegacyFlowControl,
                Action<Task> registerTaskFn)
            {
                _registerTaskFn = registerTaskFn;
                _taskHelper = subscriber._taskHelper;
                _scheduler = subscriber._scheduler;
                _client = client;
                _handlerAsync = handlerAsync;
                _hardStopCts = subscriber._globalHardStopCts;
                _pushStopCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                _softStopCts = subscriber._globalSoftStopCts;
                _subscriptionName = subscriber.SubscriptionName;
                _modifyDeadlineSeconds = subscriber._modifyDeadlineSeconds;
                _maxAckExtendQueueSize = subscriber._maxAckExtendQueue;
                _autoExtendInterval = subscriber._autoExtendInterval;
                _maxExtensionDuration = subscriber._maxExtensionDuration;
                _extendQueueThrottleInterval = TimeSpan.FromTicks((long)((TimeSpan.FromSeconds(_modifyDeadlineSeconds) - _autoExtendInterval).Ticks * 0.5));
                _maxAckExtendSendCount = Math.Max(10, subscriber._maxAckExtendQueue / 4);
                _maxConcurrentPush = 3; // Fairly arbitrary.
                _flow = flow;
                _useLegacyFlowControl = useLegacyFlowControl;
                _eventPush = new AsyncAutoResetEvent(subscriber._taskHelper);
                _continuationQueue = new AsyncSingleRecvQueue<TaskNextAction>(subscriber._taskHelper);
            }

            private readonly object _lock = new object(); // For: _ackQueue, _nackQueue, _userHandlerInFlight
            private readonly Action<Task> _registerTaskFn;
            private readonly TaskHelper _taskHelper;
            private readonly IScheduler _scheduler;
            private readonly SubscriberServiceApiClient _client;
            private readonly Func<PubsubMessage, CancellationToken, Task<Reply>> _handlerAsync;
            private readonly CancellationTokenSource _hardStopCts;
            private readonly CancellationTokenSource _pushStopCts;
            private readonly CancellationTokenSource _softStopCts;
            private readonly SubscriptionName _subscriptionName;
            private readonly int _modifyDeadlineSeconds; // Seconds to add to deadling on lease extension.
            private readonly TimeSpan _autoExtendInterval; // Delay between auto-extends.
            private readonly TimeSpan _maxExtensionDuration; // Maximum duration for which a message lease will be extended.
            private readonly TimeSpan _extendQueueThrottleInterval; // Throttle pull if items in the extend queue are older than this.
            private readonly int _maxAckExtendQueueSize; // Soft limit on push queue sizes. Used to throttle pulls.
            private readonly int _maxAckExtendSendCount; // Maximum number of ids to include in an ack/nack/extend push RPC.
            private readonly int _maxConcurrentPush; // Mamimum number (slightly soft) of concurrent ack/nack/extend push RPCs.

            private readonly Flow _flow;
            private readonly bool _useLegacyFlowControl;
            private readonly AsyncAutoResetEvent _eventPush;
            private readonly AsyncSingleRecvQueue<TaskNextAction> _continuationQueue;
            private readonly RequeueableQueue<TimedId> _extendQueue = new RequeueableQueue<TimedId>();
            private readonly RequeueableQueue<string> _ackQueue = new RequeueableQueue<string>();
            private readonly RequeueableQueue<string> _nackQueue = new RequeueableQueue<string>();

            private int _pushInFlight = 0;
            private int _userHandlerInFlight = 0;
            private SubscriberServiceApiClient.StreamingPullStream _pull = null;
            private int _concurrentPushCount = 0;
            private bool _pullComplete = false;
            private long _extendThrottleHigh = 0; // Incremented on extension, and put on extend queue items.
            private long _extendThrottleLow = 0; // Incremented after _extendQueueThrottleInterval, checked when throttling.

            private readonly static RetrySettings s_pullBackoff = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(0.5),
                maxBackoff: TimeSpan.FromSeconds(30),
                backoffMultiplier: 2.0,
                retryFilter: _ => false // Ignored
                );
            private TimeSpan? _pullBackoff = null;

            // Stream shutdown occurs after 1 minute, so ensure we're always before that.
            private readonly static TimeSpan s_streamPingPeriod = TimeSpan.FromSeconds(25);

            internal async Task StartAsync()
            {
                // Start pull.
                StartStreamingPull();
                // Start push.
                HandlePush();
                // Start stream-keep-alive ping
                HandleStreamPing();
                // Start event loop.
                // This loop exits by an action throwing a error or cancellation exception.
                while (!(_pullComplete && IsPushComplete()))
                {
                    // Wait for, then process next continuation.
                    TaskNextAction nextContinuation = await _taskHelper.ConfigureAwait(_continuationQueue.DequeueAsync());
                    // On hardstop just immediately stop this event loop.
                    // The registered-task code ensures that all currently-active tasks finish before
                    // return to user code.
                    if (_hardStopCts.IsCancellationRequested)
                    {
                        StopStreamingPull();
                        throw new OperationCanceledException();
                    }
                    var task = nextContinuation.Task;
                    var next = nextContinuation.NextAction;
                    if (next.IsPull && (task.IsCanceled || (task.IsFaulted && (task.Exception.IsCancellation() || task.Exception.IsRpcCancellation()))))
                    {
                        // Pull has been cancelled by user, shutdown pull stream and don't run continuation.
                        // RPC exceptions are dealt with in the relevant handlers.
                        StopStreamingPull();
                        // Pull process has been stopped, wait for push process to complete.
                        _pullComplete = true;
                    }
                    else
                    {
                        next.Action();
                    }
                }
                // Stop waiting for data to push.
                _pushStopCts.Cancel();
            }

            private bool IsPushComplete()
            {
                // extend-queue not included, as these have no effect after shutdown.
                // Lock required for ackQueue and nackQueue.
                lock (_lock)
                {
                    return _ackQueue.Count == 0 && _nackQueue.Count == 0 && _pushInFlight == 0 && _userHandlerInFlight == 0;
                }
            }

            private NextAction Next(bool isPull, Action action) => new NextAction(isPull, action);

            private void Add(Task task, NextAction next)
            {
                _registerTaskFn(task);
                var taskNext = new TaskNextAction(task, next);
                task.ContinueWith(_ => _continuationQueue.Enqueue(taskNext),
                    CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, _taskHelper.TaskScheduler);
            }

            private void StopStreamingPull()
            {
                if (_pull != null)
                {
                    // Ignore all errors; the stream may be in any state.
                    try
                    {
                        _registerTaskFn(_pull.WriteCompleteAsync());
                    }
                    catch { }
                    _pull = null;
                }
            }

            // Open streaming-pull, and send initial request to start message stream.
            // If backoff is non-zero delay before opening streaming-pull.
            private void StartStreamingPull()
            {
                if (_pullBackoff is TimeSpan backoff)
                {
                    // Delay, then start the streaming-pull.
                    Task delayTask = _scheduler.Delay(backoff, _softStopCts.Token);
                    Add(delayTask, Next(true, HandleStartStreamingPullWithoutBackoff));
                }
                else
                {
                    HandleStartStreamingPullWithoutBackoff();
                }
            }

            // Open streaming-pull, and send initial request to start message stream.
            // Backoff delay (if present) has already been done; no need to delay here.
            private void HandleStartStreamingPullWithoutBackoff()
            {
                _pull = _client.StreamingPull(CallSettings.FromCancellationToken(_softStopCts.Token));
                // Cancellation not needed in this WriteAsync call. The StreamingPull() cancellation
                // (above) will cause this call to cancel if _softStopCts is cancelled.
                Task initTask = _pull.WriteAsync(new StreamingPullRequest
                {
                    SubscriptionAsSubscriptionName = _subscriptionName,
                    StreamAckDeadlineSeconds = _modifyDeadlineSeconds,
                    MaxOutstandingMessages = _useLegacyFlowControl ? 0 : _flow.MaxOutstandingElementCount,
                    MaxOutstandingBytes = _useLegacyFlowControl ? 0 : _flow.MaxOutstandingByteCount
                });
                Add(initTask, Next(true, () => HandlePullMoveNext(initTask)));
            }

            private bool HandleRpcFailure(Exception e)
            {
                if (e != null)
                {
                    if (e.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable RPC error, stop and restart pull.
                        StopStreamingPull();
                        // Increase backoff internal and start stream again.
                        // If stream-pull fails repeatly, increase the delay, up to a maximum of 30 seconds.
                        _pullBackoff = s_pullBackoff.NextBackoff(_pullBackoff ?? TimeSpan.Zero);
                        StartStreamingPull();
                        return true;
                    }
                    else
                    {
                        // Unrecoverable error; throw it.
                        throw e.FlattenIfPossible();
                    }
                }
                return false;
            }

            // Pull-stream is ready; call MoveNext to wait for messages.
            private void HandlePullMoveNext(Task initTask)
            {
                // Check if the init write failed.
                if (initTask != null && HandleRpcFailure(initTask.Exception))
                {
                    return;
                }
                // Check if pulls need throttling due to push queues being too full, or too slow to push.
                bool throttle = _extendQueue.TryPeek(out var qItem) && _extendThrottleLow >= qItem.Time;
                if (!throttle)
                {
                    int totalQueueCount = _pushInFlight + _extendQueue.Count;
                    lock (_lock)
                    {
                        totalQueueCount += _ackQueue.Count + _nackQueue.Count;
                    }
                    throttle = totalQueueCount > _maxAckExtendQueueSize;
                }
                if (throttle)
                {
                    // Too many queued ack/nack/extend ids. Loop until the queue has drained a bit.
                    Add(_scheduler.Delay(TimeSpan.FromMilliseconds(100), _softStopCts.Token), Next(true, () => HandlePullMoveNext(null)));
                }
                else
                {
                    // Call MoveNext to receive more messages.
                    // Cancellation is handled by the cancellation-token passed when the stream is created.
                    var moveNextTask = _pull.GrpcCall.ResponseStream.MoveNext(CancellationToken.None);
                    Add(moveNextTask, Next(true, () => HandlePullMessageData(moveNextTask)));
                }
            }

            // Message-stream has messages (or not, depending on moveNextResult)
            private void HandlePullMessageData(Task<bool> moveNextTask)
            {
                if (HandleRpcFailure(moveNextTask.Exception))
                {
                    return;
                }
                if (moveNextTask.Result)
                {
                    // Successful receive. Reset pull backoff to zero.
                    _pullBackoff = null;
                    // Copy msgs to list, and clear original proto repeatedfield; to remove refs to large messages as soon as possible.
                    // It is not possible to set RepeatedField elements to null, so messages need transfering to a List.
                    StreamingPullResponse current;
                    try
                    {
                        current = _pull.GrpcCall.ResponseStream.Current;
                    }
                    catch (Exception e) when (e.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        HandleRpcFailure(e);
                        return;
                    }
                    var receivedMessages = current.ReceivedMessages;
                    var msgs = receivedMessages.ToList();
                    receivedMessages.Clear();
                    // Get all ack-ids, used to extend leases as required.
                    var msgIds = new HashSet<string>(msgs.Select(x => x.AckId));
                    // Send an initial "lease-extension"; which starts the server timer.
                    HandleExtendLease(msgIds, null);
                    // Asynchonously start message processing. Handles flow, and calls the user-supplied message handler.
                    // Uses Task.Run(), so not to clog up this "master" thread with per-message processing.
                    Task messagesTask = _taskHelper.Run(() => ProcessPullMessagesAsync(msgs, msgIds));
                    // Once all received messages have been queued for processing, read the stream for more messages.
                    Add(messagesTask, Next(true, () => HandlePullMoveNext(null)));
                }
                else
                {
                    StopStreamingPull();
                    // Always a short pause on server disconnect.
                    _pullBackoff = TimeSpan.FromSeconds(0.5);
                    StartStreamingPull();
                }
            }

            private async Task ProcessPullMessagesAsync(List<ReceivedMessage> msgs, HashSet<string> msgIds)
            {
                // Running async. Common data needs locking
                for (int msgIndex = 0; msgIndex < msgs.Count; msgIndex++)
                {
                    _softStopCts.Token.ThrowIfCancellationRequested();
                    var msg = msgs[msgIndex];
                    msgs[msgIndex] = null;
                    // Prepare to call user message handler, _flow.Process(...) enforces the user-handler concurrency constraints.
                    await _taskHelper.ConfigureAwait(_flow.Process(msg.CalculateSize(), msg.Message.OrderingKey ?? "", async () =>
                    {
                        // Running async. Common data needs locking
                        lock (_lock)
                        {
                            _softStopCts.Token.ThrowIfCancellationRequested();
                            _userHandlerInFlight += 1;
                        }
                        if (msg.DeliveryAttempt > 0)
                        {
                            msg.Message.Attributes[DeliveryAttemptAttrKey] = msg.DeliveryAttempt.ToString(CultureInfo.InvariantCulture);
                        }
                        // Call user message handler
                        var reply = await _taskHelper.ConfigureAwaitHideErrors(() => _handlerAsync(msg.Message, _hardStopCts.Token), Reply.Nack);
                        // Lock msgsIds, this is accessed concurrently here and in HandleExtendLease().
                        lock (msgIds)
                        {
                            msgIds.Remove(msg.AckId);
                        }
                        // Lock ack/nack-queues, this is accessed concurrently here and in "master" thread.
                        lock (_lock)
                        {
                            _userHandlerInFlight -= 1;
                            var queue = reply == Reply.Ack ? _ackQueue : _nackQueue;
                            queue.Enqueue(msg.AckId);
                        }
                        // Ids have been added to ack/nack-queue, so trigger a push.
                        _eventPush.Set();
                    }));
                }
            }

            private class LeaseCancellation
            {
                public LeaseCancellation(CancellationTokenSource softStopCts) =>
                    _cts = CancellationTokenSource.CreateLinkedTokenSource(softStopCts.Token);

                private readonly object _lock = new object();
                private CancellationTokenSource _cts;

                public CancellationToken Token
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _cts?.Token ?? CancellationToken.None;
                        }
                    }
                }

                public void Dispose()
                {
                    lock (_lock)
                    {
                        _cts.Dispose();
                        _cts = null;
                    }
                }

                public bool IsDisposed
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _cts == null;
                        }
                    }
                }

                public void Cancel()
                {
                    CancellationTokenSource cts2;
                    lock (_lock)
                    {
                        cts2 = _cts;
                    }
                    // Cancel outside of lock, as continuations may be executed synchronously.
                    cts2?.Cancel();
                    // No need to dispose of `_cts` here, as `Dispose()` will always be called.
                }
            }

            private void HandleExtendLease(HashSet<string> msgIds, LeaseCancellation cancellation)
            {
                if (_softStopCts.IsCancellationRequested)
                {
                    // No further lease extensions once stop is requested.
                    return;
                }
                // The first call to this method happens as soon as messages in this chunk start to be processed.
                // This triggers the server to start its lease timer.
                if (cancellation == null)
                {
                    // Create a task to cancel lease-extension once `_maxExtensionDuration` has been reached.
                    // This set up once for each chunk of received messages, and passed through to each future call to this method.
                    cancellation = new LeaseCancellation(_softStopCts);
                    Add(_scheduler.Delay(_maxExtensionDuration, cancellation.Token), Next(false, () =>
                    {
                        // This is executed when `_maxExtensionDuration` has expired, or when `cancellation` is cancelled,
                        // Which ensures `cancellation` is aways disposed of.
                        cancellation.Dispose();
                        lock (msgIds)
                        {
                            msgIds.Clear();
                        }
                    }));
                }
                if (!cancellation.IsDisposed)
                {
                    // If `_maxExtensionDuration` has not expired, then schedule a further lease extension.
                    bool anyMsgIds;
                    lock (msgIds)
                    {
                        anyMsgIds = msgIds.Count > 0;
                        if (anyMsgIds)
                        {
                            lock (_lock)
                            {
                                _extendQueue.Enqueue(msgIds.Select(x => new TimedId(_extendThrottleHigh + 1, x)));
                            }
                        }
                    }
                    if (anyMsgIds)
                    {
                        // Ids have been added to _extendQueue, so trigger a push.
                        _eventPush.Set();
                        // Some ids still exist, schedule another extension.
                        // The overall `_maxExtensionDuration` is maintained by passing through the existing `cancellation`.
                        Add(_scheduler.Delay(_autoExtendInterval, _softStopCts.Token), Next(false, () => HandleExtendLease(msgIds, cancellation)));
                        // Increment _extendThrottles.
                        _extendThrottleHigh += 1;
                        Add(_scheduler.Delay(_extendQueueThrottleInterval, _softStopCts.Token), Next(false, () => _extendThrottleLow += 1));
                    }
                    else
                    {
                        // All messages have been handled in this chunk, so cancel the max-lease-time monitoring.
                        // This will also cause `cancellation` to be disposed in the anonymous function above.
                        cancellation.Cancel();
                    }
                }
            }

            private void HandlePush()
            {
                // Always re-listen for push events.
                Add(_eventPush.WaitAsync(_pushStopCts.Token), Next(false, HandlePush));
                // Send data, if there is any to send.
                StartPush();
            }

            private void StartPush()
            {
                // Send data, if there is any to send.
                if (_concurrentPushCount >= _maxConcurrentPush)
                {
                    // Too many existing concurrent pushes; do nothing.
                    return;
                }
                List<string> acks;
                List<TimedId> extends;
                List<string> nacks;
                lock (_lock)
                {
                    // Priority of sending: Acks, Extends, Nacks.
                    // This code can cause the number of concurrent pushes to go over _maxConcurrentPush
                    // by 2. Allow this, to ensure all queues get fairly sent.
                    acks = _ackQueue.Dequeue(_maxAckExtendSendCount, null);
                    nacks = _nackQueue.Dequeue(_maxAckExtendSendCount, null);
                    var ackSet = new HashSet<string>(acks);
                    var nackSet = new HashSet<string>(nacks);
                    // Only send extends for ids that aren't also about to ack or nack.
                    extends = _extendQueue.Dequeue(_maxAckExtendSendCount, x => !ackSet.Contains(x.Id) && !nackSet.Contains(x.Id));
                }
                if (acks.Count > 0)
                {
                    _pushInFlight += acks.Count;
                    _concurrentPushCount += 1;
                    Task ackTask = _client.AcknowledgeAsync(_subscriptionName, acks, _hardStopCts.Token);
                    Add(ackTask, Next(false, () => HandleAckResponse(ackTask, acks, null, null)));
                }
                if (extends.Count > 0)
                {
                    _pushInFlight += extends.Count;
                    _concurrentPushCount += 1;
                    Task extendTask = _client.ModifyAckDeadlineAsync(_subscriptionName, extends.Select(x => x.Id), _modifyDeadlineSeconds, _hardStopCts.Token);
                    Add(extendTask, Next(false, () => HandleAckResponse(extendTask, null, null, extends)));
                }
                if (nacks.Count > 0)
                {
                    _pushInFlight += nacks.Count;
                    _concurrentPushCount += 1;
                    Task nackTask = _client.ModifyAckDeadlineAsync(_subscriptionName, nacks, 0, _hardStopCts.Token);
                    Add(nackTask, Next(false, () => HandleAckResponse(nackTask, null, nacks, null)));
                }
            }

            private void HandleAckResponse(Task writeTask, List<string> ackIds, List<string> nackIds, List<TimedId> extendIds)
            {
                _concurrentPushCount -= 1;
                _pushInFlight -= ackIds?.Count ?? 0 + nackIds?.Count ?? 0 + extendIds?.Count ?? 0;
                if (writeTask.IsFaulted)
                {
                    if (writeTask.Exception.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable write error, requeue data and continue.
                        // ackIds and nackIds are never both set in the same call, so no need to share a lock.
                        if (ackIds != null && ackIds.Count > 0)
                        {
                            lock (_lock)
                            {
                                _ackQueue.Requeue(ackIds);
                            }
                        }
                        if (nackIds != null && nackIds.Count > 0)
                        {
                            lock (_lock)
                            {
                                _nackQueue.Requeue(nackIds);
                            }
                        }
                        if (extendIds != null && extendIds.Count > 0)
                        {
                            _extendQueue.Requeue(extendIds);
                        }
                        // TODO: Backoff
                    }
                    else
                    {
                        // Check if it's an RpcException. If it is, then ignore it and continue. We may want to log it later. 
                        // Other non-gRPC unrecoverable errors will continue to be thrown.
                        if (writeTask.Exception.As<RpcException>() is null)
                        {
                            // It is a non-gRPC unrecoverable error; throw exception.
                            throw writeTask.Exception.FlattenIfPossible();
                        }
                    }
                }
                // Immediately send more data if there is any to send.
                StartPush();
            }

            private void HandleStreamPing()
            {
                // Need to explicitly check this, as the continuation passed to Add() may be executed
                // regardless of the fault/cancellation state of the Task.
                if (_softStopCts.IsCancellationRequested)
                {
                    // No more pings when subscriber stopping.
                    return;
                }
                // Schedule next ping, this never stops whilst this subscriber as active
                Add(_scheduler.Delay(s_streamPingPeriod, _softStopCts.Token), Next(false, HandleStreamPing));
                // If messages are currently being processed, then ping the stream periodically;
                // this ensures the stream isn't closed.
                // If the stream is closed, then all gRPC-buffered messages have their server-side
                // expiry timers started, when the client hasn't yet started processing these messages.
                // This can lead to unncessarily duplicated messages.
                if (!IsPushComplete() && _pull != null)
                {
                    // Write an empty message to the stream.
                    // Don't wait for this to complete, it doesn't matter if or when it completes.
                    // This is only a best-effort attempt to reduce duplicate messages.
                    try
                    {
                        _pull.WriteAsync(new StreamingPullRequest());
                    }
                    catch
                    {
                        // Ignore any errors.
                    }
                }
            }
        }
    }
}
