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
using Google.Cloud.PubSub.V1.Tasks;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
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
    /// <para>To receive messages, the <see cref="StartAsync(SubscriptionHandler)"/> method must be called,
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
                AckDeadline = other.AckDeadline;
                AckExtensionWindow = other.AckExtensionWindow;
                Scheduler = other.Scheduler;
                Clock = other.Clock;
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

            /// <summary>
            /// The <see cref="IClock"/> used for timeouts and retries.
            /// If <c>null</c>, the default <see cref="SystemClock"/> is used.
            /// This is usually only used for testing.
            /// </summary>
            /// <remarks>
            /// This is used only in exactly once delivery flow as we need to retry temporary failures.
            /// </remarks>
            public IClock Clock { get; set; }

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
        /// This type is now obsolete; please use <see cref="SubscriberClientBuilder"/> which provides an
        /// API surface consistent with other clients (as well as additional Pub/Sub-specific properties such as <see cref="SubscriberClientBuilder.ClientCount"/>).
        /// </summary>
        [Obsolete("Use PublisherClientBuilder to customize client settings.")]
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
        /// The minimum message acknowledgement extension window of 60 seconds for exactly once delivery subscriptions.
        /// </summary>
        public static TimeSpan MinimumAckExtensionWindowForExactlyOnceDelivery { get; } = TimeSpan.FromSeconds(60);

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
        /// Create a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>, using default settings.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static SubscriberClient Create(SubscriptionName subscriptionName) =>
            CreateBuilder(subscriptionName, null, null).Build();

        /// <summary>
        /// Creates a <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>, using default settings.
        /// </summary>
        /// <param name="subscriptionName">The <see cref="SubscriptionName"/> to receive messages from.</param>
        /// <returns>A <see cref="SubscriberClient"/> instance associated with the specified <see cref="SubscriptionName"/>.</returns>
        public static Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName) =>
            CreateBuilder(subscriptionName, null, null).BuildAsync();

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
        [Obsolete("Use SubscriberClient.Create(SubscriptionName) to use the default settings, or SubscriberClientBuilder for customization.")]
        public static SubscriberClient Create(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            CreateBuilder(subscriptionName, clientCreationSettings, settings).Build();

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
        [Obsolete("Use SubscriberClient.Create(SubscriptionName) to use the default settings, or SubscriberClientBuilder for customization.")]
        public static Task<SubscriberClient> CreateAsync(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            CreateBuilder(subscriptionName, clientCreationSettings, settings).BuildAsync();

#pragma warning disable CS0618 // Type or member is obsolete
        private static SubscriberClientBuilder CreateBuilder(SubscriptionName subscriptionName, ClientCreationSettings clientCreationSettings, Settings settings) =>
            new SubscriberClientBuilder
            {
                SubscriptionName = GaxPreconditions.CheckNotNull(subscriptionName, nameof(subscriptionName)),
                Settings = settings,
                EmulatorDetection = clientCreationSettings?.EmulatorDetection ?? EmulatorDetection.None,
                ClientCount = clientCreationSettings?.ClientCount,
                ChannelCredentials = clientCreationSettings?.Credentials,
                Endpoint = clientCreationSettings?.ServiceEndpoint,
                ApiSettings = clientCreationSettings?.SubscriberServiceApiSettings
            };
#pragma warning restore CS0618 // Type or member is obsolete

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
        public virtual Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) =>
            StartAsync(new SimpleSubscriptionHandler(handlerAsync));

        /// <summary>
        /// Starts receiving messages. The returned <see cref="Task"/> completes when either <see cref="StopAsync(CancellationToken)"/> is called
        /// or if an unrecoverable fault occurs. See <see cref="StopAsync(CancellationToken)"/> for more details.
        /// This method cannot be called more than once per <see cref="SubscriberClient"/> instance.
        /// </summary>
        /// <param name="handler">The handler that is passed all received messages and acknowledgement results.</param>
        /// <returns>A <see cref="Task"/> that completes when the subscriber is stopped, or if an unrecoverable error occurs.</returns>
        public virtual Task StartAsync(SubscriptionHandler handler) => throw new NotImplementedException();

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
            var autoExtendIntervalForExactlyOnceDelivery = settings.AckExtensionWindow ?? MinimumAckExtensionWindowForExactlyOnceDelivery;
            // For exactly once delivery subscription, minimum ack extension window value should be the default value of 60 seconds or the user provided value.
            // Ensure the duration between lease extensions is at least MinimumLeaseExtensionDelay (5 seconds).
            // The minimum allowable lease duration is 10 seconds, so this will always be reasonable.
            _autoExtendInterval = TimeSpan.FromTicks(Math.Max(autoExtendInterval.Ticks, MinimumLeaseExtensionDelay.Ticks));
            _autoExtendIntervalForExactlyOnceDelivery = TimeSpan.FromTicks(Math.Max(autoExtendIntervalForExactlyOnceDelivery.Ticks, MinimumLeaseExtensionDelay.Ticks));
            _maxExtensionDuration = settings.MaxTotalAckExtension ?? DefaultMaxTotalAckExtension;
            _shutdown = shutdown;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            _clock = settings.Clock ?? SystemClock.Instance;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _flowControlSettings = settings.FlowControlSettings ?? DefaultFlowControlSettings;
            _useLegacyFlowControl = settings.UseLegacyFlowControl;
            _maxAckExtendQueue = (int)Math.Min(_flowControlSettings.MaxOutstandingElementCount ?? long.MaxValue, 20_000);
        }

        private readonly object _lock = new object();
        private readonly SubscriberServiceApiClient[] _clients;
        private readonly Func<Task> _shutdown;
        private readonly TimeSpan _autoExtendInterval; // Interval between message lease auto-extends for non-exactly once delivery subscriptions.
        private readonly TimeSpan _autoExtendIntervalForExactlyOnceDelivery; // Interval between message lease auto-extends for exactly once delivery subscriptions.
        private readonly TimeSpan _maxExtensionDuration; // Maximum duration for which a message lease will be extended.
        private readonly int _modifyDeadlineSeconds; // Value to use as new deadline when lease auto-extends
        private readonly int _maxAckExtendQueue; // Maximum count of acks/extends to push to server in a single messages
        private readonly IScheduler _scheduler;
        private readonly IClock _clock;
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
        public override Task StartAsync(Func<PubsubMessage, CancellationToken, Task<Reply>> handlerAsync) =>
            StartAsync(new SimpleSubscriptionHandler(handlerAsync));

        /// <inheritdoc />
        public override Task StartAsync(SubscriptionHandler handler)
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
                var singleChannel = new SingleChannel(this, client, handler, flow, _useLegacyFlowControl, registerTask);
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

            /// <summary>
            /// This struct contains the retry information for a temporary failed AckId/NackId/ExtendId.
            /// The AckId/NackId/ExtendId is stored in a dictionary as a key and mapped to <see cref="RetryInfo"/>.
            /// This struct is only used in exactly once delivery mode.
            /// </summary>
            private readonly struct RetryInfo
            {
                /// <summary>
                /// Gets the first time of failure in UTC when the Acknowledge/ModifyAckDeadline RPC call failed with a temporary error for a given message id.
                /// </summary>
                internal DateTime FirstTimeOfFailureInUtc { get; }

                /// <summary>
                /// Gets the latest backoff that was used to retry Acknowledge/ModifyAckDeadline RPC call.
                /// </summary>
                internal TimeSpan? Backoff { get; }

                /// <summary>
                /// Initializes a new instance of the <see cref="RetryInfo"/> struct.
                /// </summary>
                /// <param name="firstTimeOfFailureInUtc">The first time of failure in UTC.</param>
                /// <param name="backoff">The latest backoff that was used, which is null at the time of first temporary failure.</param>
                internal RetryInfo(DateTime firstTimeOfFailureInUtc, TimeSpan? backoff = null)
                {
                    FirstTimeOfFailureInUtc = firstTimeOfFailureInUtc;
                    Backoff = backoff;
                }

                internal RetryInfo WithBackoff(TimeSpan? backoff) => new RetryInfo(FirstTimeOfFailureInUtc, backoff);
            }

            internal SingleChannel(SubscriberClientImpl subscriber,
                SubscriberServiceApiClient client, SubscriptionHandler handler,
                Flow flow, bool useLegacyFlowControl,
                Action<Task> registerTaskFn)
            {
                _registerTaskFn = registerTaskFn;
                _taskHelper = subscriber._taskHelper;
                _scheduler = subscriber._scheduler;
                _clock = subscriber._clock;
                _client = client;
                _handler = handler;
                _hardStopCts = subscriber._globalHardStopCts;
                _pushStopCts = CancellationTokenSource.CreateLinkedTokenSource(_hardStopCts.Token);
                _softStopCts = subscriber._globalSoftStopCts;
                _subscriptionName = subscriber.SubscriptionName;
                _modifyDeadlineSeconds = subscriber._modifyDeadlineSeconds;
                _maxAckExtendQueueSize = subscriber._maxAckExtendQueue;
                _autoExtendInterval = subscriber._autoExtendInterval;
                _autoExtendIntervalForExactlyOnceDelivery = subscriber._autoExtendIntervalForExactlyOnceDelivery;
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
            private readonly IClock _clock;
            private readonly SubscriberServiceApiClient _client;
            private readonly SubscriptionHandler _handler;
            private readonly CancellationTokenSource _hardStopCts;
            private readonly CancellationTokenSource _pushStopCts;
            private readonly CancellationTokenSource _softStopCts;
            private readonly SubscriptionName _subscriptionName;
            private readonly int _modifyDeadlineSeconds; // Seconds to add to deadling on lease extension.
            private readonly TimeSpan _autoExtendInterval; // Delay between auto-extends for non-exactly once delivery subscriptions.
            private readonly TimeSpan _autoExtendIntervalForExactlyOnceDelivery; // Delay between auto-extends for exactly once delivery subscriptions.
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
            private bool _exactlyOnceDeliveryEnabled = false; // True if subscription is exactly once, else false.

            // This dictionary will only have ids that can be retried for temporary errors while calling Acknowledgement or ModifyAckDeadline RPCs.
            // We store the first time of error corresponding to the AckId, so that we retry only for specified duration
            // which is a requirement for exactly once delivery subscription.
            private readonly ConcurrentDictionary<string, RetryInfo> _retryableIds = new ConcurrentDictionary<string, RetryInfo>();

            private static readonly RetrySettings s_pullBackoff = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(0.5),
                maxBackoff: TimeSpan.FromSeconds(30),
                backoffMultiplier: 2.0,
                retryFilter: _ => false // Ignored
                );

            private static readonly RetrySettings s_ackBackoff = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromSeconds(1),
                maxBackoff: TimeSpan.FromSeconds(64),
                backoffMultiplier: 2.0,
                retryFilter: _ => false // Ignored
                );

            private TimeSpan? _pullBackoff = null;

            // Stream shutdown occurs after 1 minute, so ensure we're always before that.
            private static readonly TimeSpan s_streamPingPeriod = TimeSpan.FromSeconds(25);

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
                        _exactlyOnceDeliveryEnabled = current.SubscriptionProperties?.ExactlyOnceDeliveryEnabled ?? false;
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
                        var reply = await _taskHelper.ConfigureAwaitHideErrors(() => _handler.HandleMessage(msg.Message, _hardStopCts.Token), Reply.Nack);
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
                        Add(_scheduler.Delay(_exactlyOnceDeliveryEnabled ? _autoExtendIntervalForExactlyOnceDelivery : _autoExtendInterval, _softStopCts.Token), Next(false, () => HandleExtendLease(msgIds, cancellation)));
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

            /// <summary>
            /// This method is called when the acknowledgement request completes.
            /// This method handles the response from an acknowledgement request for exactly once delivery subscriptions only.
            /// For non-exactly once delivery subscriptions, <see cref="HandleAckResponse(Task, List{string}, List{string}, List{TimedId})"/> is called.
            /// </summary>
            /// <param name="writeTask">The task containing the response of Acknowledge/ModifyAckDeadline RPC.</param>
            /// <param name="ackIds">The list of ids that were sent to the Acknowledge RPC for acknowledgement
            /// that the message associated with these ids shouldn't be redelivered.</param>
            /// <param name="nackIds">The list of ids that were sent to the ModifyAckDeadline RPC to indicate that
            /// the message associated with these ids should be redelivered.</param>
            /// <param name="extendIds">The list of ids that were sent to the ModifyAckDeadline RPC to modify their ack deadline.</param>
            /// <remarks>
            /// Only one of ackIds, nackIds and extendIds will be non-null and based on that we determine if we are handling acks, nacks or extends.
            /// This method is used for exactly once delivery subscriptions only. To keep the logic of exactly once delivery subscription in one place,
            /// this method has a few local methods that are used only in exactly once delivery flow and not in non-exactly once delivery flow, so the method
            /// is pretty long.
            /// </remarks>
            private void HandleAckResponseForExactlyOnceDelivery(Task writeTask, List<string> ackIds, List<string> nackIds, List<TimedId> extendIds)
            {
                _concurrentPushCount -= 1;
                _pushInFlight -= (ackIds?.Count ?? 0) + (nackIds?.Count ?? 0) + (extendIds?.Count ?? 0);
                
                bool hasAckIds = ackIds?.Count > 0;
                bool hasNackIds = nackIds?.Count > 0;
                bool hasExtendIds = extendIds?.Count > 0;
                // In one call, we'll have one of acks or nacks or extends, not all.
                GaxPreconditions.CheckArgument((hasAckIds ? 1 : 0) + (hasNackIds ? 1 : 0) + (hasExtendIds ? 1 : 0) <= 1, nameof(ackIds), "At most one of ackIds, nackIds or extendIds should be non-empty.");
                var ids = hasAckIds ? ackIds
                    : hasNackIds ? nackIds : extendIds.Select(j => j.Id);

                if (writeTask.IsFaulted)
                {
                    // There may be few successes and few failures or all failures.
                    var rpcException = writeTask.Exception.As<RpcException>();
                    if (rpcException != null)
                    {
                        var ackError = AckError.ForRpcException(rpcException, ids);
                        // Only temporary failures should be retried. Mark them as retryable if not already.
                        UpdateRetryableIds(ids, ackError);

                        if (hasAckIds)
                        {
                            RetryAcks(ackError);
                        }

                        if (hasNackIds)
                        {
                            RetryNacks(ackError);
                        }

                        if (hasExtendIds)
                        {
                            RetryExtends(extendIds, ackError);
                        }
                    }
                    else
                    {
                        // Throw it.
                        throw writeTask.Exception.FlattenIfPossible();
                    }
                }
                else
                {
                    // Everything succeeded. Update _retryableIds dictionary.
                    UpdateRetryableIds(ids, default);
                }

                // Perform push so that other messages can be processed.
                StartPush();
                return;

                // All methods below are local methods applicable to exactly once delivery subscriptions only.
                // They are not used in non-exactly once delivery subscriptions.

                // This local method used for exactly once delivery only, schedules the retry of ackIds with temporary errors.
                void RetryAcks(AckError ackError) =>
                    // ack = true implies acks.
                    RetryAcksAndNacks(true, ackError);

                // This local method used for exactly once delivery only, schedules the retry of nackIds with temporary errors.
                void RetryNacks(AckError ackError) =>
                    // ack = false implies nacks.
                    RetryAcksAndNacks(false, ackError);

                // This local method used for exactly once delivery only, schedules the retry of ackIds/nackIds with temporary errors.
                void RetryAcksAndNacks(bool ack, AckError ackError)
                {
                    // ack = true implies acks. ack = false implies nacks.
                    // We have acks or nacks.
                    var idsToRetry = ackError.TemporaryFailureIds;
                    var queue = ack ? _ackQueue : _nackQueue;
                    if (idsToRetry.Any())
                    {
                        // Retry for 600 seconds.
                        RetryTemporaryFailures(idsToRetry, acksToRetry => queue.Locked(() => queue.Requeue(acksToRetry)), Enumerable.Empty<TimedId>(), null, 600);
                    }
                }

                // This local method used for exactly once delivery only, schedules the retry of extendIds with temporary errors.
                void RetryExtends(IEnumerable<TimedId> extendIds, AckError ackError)
                {
                    var extendIdsToRetry = extendIds.Where(j => ackError.TemporaryFailureIds.Contains(j.Id));
                    if (extendIdsToRetry.Any())
                    {
                        // Retry for 10 seconds or 3 attempts only.
                        RetryTemporaryFailures(Enumerable.Empty<string>(), null, extendIdsToRetry, extendsToRetry => _extendQueue.Locked(() => _extendQueue.Requeue(extendsToRetry)), 10);
                    }
                }

                // This local method used for exactly once delivery only, retries the ackIds/nackIds with temporary failures for Acknowledge RPC or extendIds with temporary failures for ModifyAckDeadline RPC.
                // This method checks if the id exists in _retryableIds dictionary and has not been tried, or not been successful for the specified timeout since the first time of failure.
                // If so, it retries those ids by adding them to the appropriate queue and calls the StartPush() method.
                // For acks and nacks, ackOrNackIds must be non-null. For extends, extendIds must be non-null.
                // For acks and nacks, ackActionToRetry must be non-null and specify the right queue (_ackQueue or _nackQueue).
                // For extends, extendActionToRetry must be non-null and specify the right queue,i.e, _extendQueue.
                void RetryTemporaryFailures(
                    IEnumerable<string> ackOrNackIds,
                    Action<IEnumerable<string>> ackActionToRetry,
                    IEnumerable<TimedId> extendIds,
                    Action<IEnumerable<TimedId>> extendActionToRetry = default,
                    int timeoutInSeconds = 600)
                {
                    // ackOrNackIds may be empty but will never be null, so null check is not needed.
                    // By design, only items in ackOrNackIds that exist in _retryableIds will be retried.
                    // If id is not in _retryableIds dictionary, it is either already succeeded or not retryable.
                    // Failure may be non-retryable due to exceeded time duration or that failure may have become permanent.

                    bool hasAcksOrNacks = ackOrNackIds.Any();
                    bool hasExtends = extendIds.Any();
                    if (!hasAcksOrNacks && !hasExtends)
                    {
                        return;
                    }

                    var idsToRetry = hasAcksOrNacks ? ackOrNackIds : extendIds.Select(j => j.Id);
                    var retriesToSchedule = new List<(string id, RetryInfo info)>();

                    foreach (var candidateRetryId in idsToRetry)
                    {
                        if (!_retryableIds.TryGetValue(candidateRetryId, out var retryInfo))
                        {
                            continue;
                        }
                        var backoff = s_ackBackoff.NextBackoff(retryInfo.Backoff ?? TimeSpan.Zero);
                        // We should retry only for specified timeout.
                        if (_clock.GetCurrentDateTimeUtc() > retryInfo.FirstTimeOfFailureInUtc + TimeSpan.FromSeconds(timeoutInSeconds) - backoff)
                        {
                            // We are past the retry timeout. This id is not retryable.
                            // Remove this id from _retryableIds dictionary and continue.
                            _ = _retryableIds.TryRemove(candidateRetryId, out _);
                            continue;
                        }

                        retryInfo = retryInfo.WithBackoff(backoff);

                        // Update the backoff for this ID in the _retryableIds dictionary.
                        _retryableIds[candidateRetryId] = retryInfo;
                        // Add it to the list of retries we need to attempt after grouping.
                        retriesToSchedule.Add((candidateRetryId, retryInfo));
                    }

                    // We can have ids with different backoff values.
                    // Group on the backoff and add them to the corresponding queue in the increasing order of backoff.
                    var retryGroups = retriesToSchedule.GroupBy(info => info.info.Backoff).OrderBy(group => group.Key);

                    foreach (var retryGroup in retryGroups)
                    {
                        var backoff = retryGroup.Key ?? TimeSpan.Zero;
                        var retryIds = retryGroup.Select(j => j.id);
                        Task delayTask = _scheduler.Delay(backoff, _softStopCts.Token);
                        Add(delayTask, new NextAction(false, hasAcksOrNacks
                            ? () => { ackActionToRetry(retryIds); StartPush(); }
                            : () => { extendActionToRetry(extendIds.Where(j => retryIds.Contains(j.Id))); StartPush(); }));
                    }
                }

                // This local method used for exactly once delivery only, updates the _retryableIds dictionary. Ensures that the ids that should be re-tried exist in the dictionary.
                // By design, only ids that are in _retryableIds dictionary will be retried with exponential backoff.
                // Removes the ids that are either successful or become permanent failures as they should not be retried.
                // allIds - All the ids for which Acknowledge/ModifyAckDeadline request was sent.
                // ackError - The AckError that occurred in the response.
                void UpdateRetryableIds(IEnumerable<string> allIds, AckError ackError)
                {
                    var temporaryFailureIds = ackError?.TemporaryFailureIds ?? Enumerable.Empty<string>();
                    var permanentFailureIds = ackError?.PermanentFailureIds ?? Enumerable.Empty<string>();
                    // Successful Ids = AllIds - (TemporaryFailures + Permanent failures)
                    // TODO: Check if there is an impact due to lazy loading of IEnumerable<T>.
                    var successfulIds = allIds.Except(temporaryFailureIds).Except(permanentFailureIds);
                    // Some ids may have permanent failures and some may have succeeded. Those ids shouldn't be retried. 
                    var nonRetryableIds = permanentFailureIds.Concat(successfulIds);

                    foreach (var item in temporaryFailureIds)
                    {
                        // If the id to be retried is already in _retryableIds dictionary we are good,
                        // else add the id to _retryableIds dictionary with first time of failure as CurrentDateTimeUtc,
                        // so that we can retry for specific duration.
                        _ = _retryableIds.TryAdd(item, new RetryInfo(_clock.GetCurrentDateTimeUtc()));
                    }

                    // Remove non-retryable ids from _retryableIds dictionary.
                    foreach (var item in nonRetryableIds)
                    {
                        _ = _retryableIds.TryRemove(item, out _);
                    }
                }
            }

            private void HandleAckResponse(Task writeTask, List<string> ackIds, List<string> nackIds, List<TimedId> extendIds)
            {
                bool hasAckIds = ackIds?.Count > 0;
                bool hasNackIds = nackIds?.Count > 0;
                var ids = hasAckIds ? ackIds
                    : hasNackIds ? nackIds
                    : new List<string>();
                // Subscription users can only request to ACK/NACK the message,
                // so fetch the status of ACK-ed/NACK-ed message only (not extends).
                // The handlers will be invoked only when ACK/NACK response is being processed.
                var ackNackResponses = ids.Count > 0
                    ? GetAckNackResponses(ids, writeTask)
                    : new List<AckNackResponse>();
                if (hasAckIds)
                {
                    // Invoke the handler for ACKs.
                    // Any uncaught exception in the handler will terminate the client.
                    _handler.HandleAckResponses(ackNackResponses);
                }
                else if (hasNackIds)
                {
                    // Invoke the handler for NACKs.
                    // Any uncaught exception in the handler will terminate the client.
                    _handler.HandleNackResponses(ackNackResponses);
                }
                
                if (_exactlyOnceDeliveryEnabled)
                {
                    HandleAckResponseForExactlyOnceDelivery(writeTask, ackIds, nackIds, extendIds);
                    return;
                }

                _concurrentPushCount -= 1;
                _pushInFlight -= (ackIds?.Count ?? 0) + (nackIds?.Count ?? 0) + (extendIds?.Count ?? 0);
                if (writeTask.IsFaulted)
                {
                    if (writeTask.Exception.As<RpcException>()?.IsRecoverable() ?? false)
                    {
                        // Recoverable write error, requeue data and continue.
                        // ackIds and nackIds are never both set in the same call, so no need to share a lock.
                        if (hasAckIds)
                        {
                            lock (_lock)
                            {
                                _ackQueue.Requeue(ackIds);
                            }
                        }
                        if (hasNackIds)
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
                return;

                // This local method gets the status of ACK/NACK response for the successful and permanently failed ids as the sequence of AckNackResponse.
                // ids - The list of all the ids being ACK-ed/NACK-ed for which the AckNackResponse is required.
                // writeTask - The task that contains the result of ACK/NACK request for the given ids.
                // Returns the status of ACK/NACK response for the successful and permanently failed ids as the sequence of AckNackResponse.
                IReadOnlyList<AckNackResponse> GetAckNackResponses(List<string> ids, Task writeTask)
                {
                    // Either the task would have succeeded or faulted. Let's check for faults.
                    if (writeTask.IsFaulted)
                    {
                        // There may be few successes and few failures or all failures.
                        var rpcException = writeTask.Exception.As<RpcException>();
                        if (rpcException != null && _exactlyOnceDeliveryEnabled)
                        {
                            // Exactly once delivery scenario.
                            // Populate AckNackResponse with success and permanent failed ids only.
                            // Temporary errors are deliberately ignored for maintaining consistency with the other client libraries.
                            // Temporary errors will eventually become successful or fail permanently. Their status would be shared then.
                            var ackError = AckError.ForRpcException(rpcException, ids);
                            return ackError.GetAckNackResponses().ToList();
                        }
                        else if (rpcException != null)
                        {
                            // Non-exactly once delivery scenario with RpcException.
                            // All RpcExceptions are either recoverable or ignored. Non-RpcException would throw.
                            // As a requirement from Pub/Sub team, all RpcExceptions in non-exactly once delivery scenario should be treated as fire and forget,
                            // so we always treat them as successful (even when they are not). If there are recoverable errors, the ACK/NACK operation
                            // will be retried, so the message may be sent multiple times with success status.
                            return GetSuccessResponses(ids);
                        }
                        else
                        {
                            // Non-gRPC error will throw exception eventually, so don't return those IDs as success. Return an empty list.
                            return new List<AckNackResponse>();
                        }
                    }

                    // If we are here, it means every ID succeeded in the request.
                    // Create successful AckNackResponse for every ID and return the list.
                    return GetSuccessResponses(ids);

                    // This method is local to GetAckNackResponses and gets the successful AckNackResponse for every given ID.
                    // It takes the list of IDs that are deemed to be successfully ACK-ed or NACK-ed.
                    // The corresponding AckNackResponse with success status is created for every ID and returned.
                    static IReadOnlyList<AckNackResponse> GetSuccessResponses(List<string> successfulIds) =>
                        successfulIds.ConvertAll(item => new AckNackResponse(item, AcknowledgementStatus.Success, default));
                }
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
