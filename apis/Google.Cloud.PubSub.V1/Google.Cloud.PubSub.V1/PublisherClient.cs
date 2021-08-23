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
using Google.Protobuf;
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
#pragma warning disable CAC001
#pragma warning disable CAC002

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// A PubSub publisher that is associated with a specific <see cref="TopicName"/>.
    /// </summary>
    public abstract class PublisherClient
    {
        private static readonly GrpcChannelOptions s_unlimitedSendReceiveChannelOptions = GrpcChannelOptions.Empty
            .WithMaxReceiveMessageSize(-1)
            .WithMaxSendMessageSize(-1);

        // TODO: Logging

        /// <summary>
        /// Settings for the <see cref="PublisherClient"/>.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Create a new instance.
            /// </summary>
            public Settings() { }

            internal Settings(Settings other)
            {
                BatchingSettings = other.BatchingSettings;
                Scheduler = other.Scheduler;
                EnableMessageOrdering = other.EnableMessageOrdering;
            }

            /// <summary>
            /// <see cref="BatchingSettings"/> that control how messages are batched when sending.
            /// If <c>null</c>, defaults to <see cref="DefaultBatchingSettings"/>.
            /// </summary>
            public BatchingSettings BatchingSettings { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> to use.
            /// If <c>null</c>, defaults to <see cref="SystemScheduler"/>. Usually only useful for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            /// <summary>
            /// Enable message ordering. It is invalid to set <see cref="PubsubMessage.OrderingKey"/> in a message
            /// if this has not been set to <c>true</c>.
            /// </summary>
            public bool EnableMessageOrdering { get; set; }

            internal void Validate()
            {
                if (BatchingSettings != null)
                {
                    GaxPreconditions.CheckArgumentRange(BatchingSettings.ElementCountThreshold,
                        $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.ElementCountThreshold)}", 1, ApiMaxBatchingSettings.ElementCountThreshold.Value);
                    GaxPreconditions.CheckArgumentRange(BatchingSettings.ByteCountThreshold,
                        $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.ByteCountThreshold)}", 1, ApiMaxBatchingSettings.ByteCountThreshold.Value);
                    GaxPreconditions.CheckArgument((BatchingSettings.DelayThreshold ?? TimeSpan.FromSeconds(1)) > TimeSpan.Zero,
                        $"{nameof(BatchingSettings)}.{nameof(BatchingSettings.DelayThreshold)}", "Must be positive");
                }
            }

            /// <summary>
            /// Create a clone of this object.
            /// </summary>
            /// <returns>A clone of this object.</returns>
            public Settings Clone() => new Settings(this);
        }

        /// <summary>
        /// Settings for creating <see cref="PublisherServiceApiClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="PublisherServiceApiClient"/>s to create and use within a <see cref="PublisherClient"/> instance.</param>
            /// <param name="publisherServiceApiSettings">Optional. The settings to use when creating <see cref="PublisherServiceApiClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="PublisherServiceApiClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The endpoint to use when creating <see cref="PublisherServiceApiClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                PublisherServiceApiSettings publisherServiceApiSettings = null,
                ChannelCredentials credentials = null,
                string serviceEndpoint = null)
                : this(clientCount, publisherServiceApiSettings, credentials, serviceEndpoint, EmulatorDetection.None)
            {
            }

            private ClientCreationSettings(
                int? clientCount,
                PublisherServiceApiSettings publisherServiceApiSettings,
                ChannelCredentials credentials,
                string serviceEndpoint,
                EmulatorDetection emulatorDetection)
            {
                ClientCount = clientCount;
                PublisherServiceApiSettings = publisherServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
                EmulatorDetection = emulatorDetection;
            }

            /// <summary>
            /// Creates a new instance of this type with the specified emulator detection value.
            /// </summary>
            /// <param name="emulatorDetection">Determines how and whether to detect the emulator.</param>
            /// <returns>The new instance</returns>
            public ClientCreationSettings WithEmulatorDetection(EmulatorDetection emulatorDetection)
            {
                GaxPreconditions.CheckEnumValue(emulatorDetection, nameof(emulatorDetection));
                return new ClientCreationSettings(ClientCount, PublisherServiceApiSettings, Credentials, ServiceEndpoint, emulatorDetection);
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
            /// The number of <see cref="PublisherServiceApiClient"/>s to create and use within a <see cref="PublisherClient"/> instance.
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="PublisherServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="PublisherServiceApiSettings.GetDefault"/>.
            /// </summary>
            public PublisherServiceApiSettings PublisherServiceApiSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="PublisherServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The endpoint to use when creating <see cref="PublisherServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="PublisherServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public string ServiceEndpoint { get; }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }

        /// <summary>
        /// Default <see cref="BatchingSettings"/> for <see cref="PublisherClient"/>.
        /// Default values are:
        /// <see cref="BatchingSettings.ElementCountThreshold"/> = 100;
        /// <see cref="BatchingSettings.ByteCountThreshold"/> = 1,000,000;
        /// <see cref="BatchingSettings.DelayThreshold"/> = 10 milliseconds;
        /// </summary>
        public static BatchingSettings DefaultBatchingSettings { get; } = new BatchingSettings(100L, 1_000_000L, TimeSpan.FromMilliseconds(10));

        /// <summary>
        /// The absolute maximum <see cref="BatchingSettings"/> supported by the service.
        /// Maximum values are:
        /// <see cref="BatchingSettings.ElementCountThreshold"/> = 1,000;
        /// <see cref="BatchingSettings.ByteCountThreshold"/> = 10,000,000;
        /// </summary>
        public static BatchingSettings ApiMaxBatchingSettings { get; } = new BatchingSettings(1000L, 10_000_000L, null);

        /// <summary>
        /// Create a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially
        /// <see cref="ClientCreationSettings.PublisherServiceApiSettings"/>.<see cref="PublisherServiceApiSettings.PublishSettings"/>.<see cref="CallSettings.Retry"/>.
        /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
        /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="PublisherServiceApiClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="PublisherClient"/>.</param>
        /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
        public static PublisherClient Create(TopicName topicName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            // With isAsync set to false, the returned task will already be completed (either successfully or faulted),
            // so .ResultWithUnwrappedExceptions() will always return immediately.
            CreateMaybeAsync(topicName, clientCreationSettings, settings, isAsync: false).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Create a <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.
        /// The default <paramref name="settings"/> and <paramref name="clientCreationSettings"/> are suitable for machines with
        /// high network bandwidth (e.g. Google Compute Engine instances). If running with more limited network bandwidth, some
        /// settings may need changing; especially
        /// <see cref="ClientCreationSettings.PublisherServiceApiSettings"/>.<see cref="PublisherServiceApiSettings.PublishSettings"/>.<see cref="CallSettings.Retry"/>.
        /// By default this method generates a gRPC channel per CPU core; if using a high-core-count machine and using many
        /// clients concurrently then this may need reducing; use the setting <see cref="ClientCreationSettings.ClientCount"/>.
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="clientCreationSettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="PublisherServiceApiClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="PublisherClient"/>.</param>
        /// <returns>A <see cref="PublisherClient"/> instance associated with the specified <see cref="TopicName"/>.</returns>
        public static Task<PublisherClient> CreateAsync(TopicName topicName, ClientCreationSettings clientCreationSettings = null, Settings settings = null) =>
            // With isAsync set to true, the returned task will complete asynchronously (if required) as expected.
            CreateMaybeAsync(topicName, clientCreationSettings, settings, isAsync: true);

        /// <summary>
        /// Creates a <see cref="PublisherClient"/>.
        /// <paramref name="isAsync"/> controls whether the returned task will complete synchronously or asynchronously, allowing this
        /// method to be used by both <see cref="Create"/> and <see cref="CreateAsync"/>.
        /// </summary>
        private static async Task<PublisherClient> CreateMaybeAsync(TopicName topicName, ClientCreationSettings clientCreationSettings, Settings settings, bool isAsync)
        {
            clientCreationSettings?.Validate();
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            var clientCount = clientCreationSettings?.ClientCount ?? Environment.ProcessorCount;

            // Create the channels and clients, and register shutdown functions for each channel
            var clients = new PublisherServiceApiClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            for (int i = 0; i < clientCount; i++)
            {
                // Use a random arg to prevent sub-channel re-use in gRPC, so each channel uses its own connection.
                var grpcChannelOptions = s_unlimitedSendReceiveChannelOptions
                    .WithCustomOption("sub-channel-separator", Guid.NewGuid().ToString());

                // First builder to handle any endpoint detection etc. We build a gRPC channel
                // with this.
                var builder = new PublisherServiceApiClientBuilder
                {
                    EmulatorDetection = clientCreationSettings?.EmulatorDetection ?? EmulatorDetection.None,
                    Endpoint = clientCreationSettings?.ServiceEndpoint,
                    ChannelCredentials = clientCreationSettings?.Credentials,
                    Settings = clientCreationSettings?.PublisherServiceApiSettings,
                    ChannelOptions = grpcChannelOptions
                };
                var channel = isAsync ?
                    await builder.CreateChannelAsync(cancellationToken: default).ConfigureAwait(false) :
                    builder.CreateChannel();

                // Second builder doesn't need to do much, as we can build a call invoker from the channel.
                clients[i] = new PublisherServiceApiClientBuilder
                {
                    CallInvoker = channel.CreateCallInvoker(),
                    Settings = clientCreationSettings?.PublisherServiceApiSettings
                }.Build();
                shutdowns[i] = channel.ShutdownAsync;
            }
            Func<Task> shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));
            return new PublisherClientImpl(topicName, clients, settings, shutdown);
        }

        /// <summary>
        /// The associated <see cref="TopicName"/>. 
        /// </summary>
        public virtual TopicName TopicName => throw new NotImplementedException();

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(PubsubMessage message) => throw new NotImplementedException();

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="orderingKey">The ordering key to use for this message.</param>
        /// <param name="message">The string to publish.</param>
        /// <param name="encoding">The encoding for string to byte conversion.
        /// If <c>null</c>, defaults to <see cref="System.Text.Encoding.UTF8"/>.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string orderingKey, string message, System.Text.Encoding encoding = null) =>
            PublishAsync(new PubsubMessage
            {
                OrderingKey = orderingKey ?? "",
                Data = encoding == null ? ByteString.CopyFromUtf8(message) : ByteString.CopyFrom(encoding.GetBytes(message))
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The string to publish.</param>
        /// <param name="encoding">The encoding for string to byte conversion.
        /// If <c>null</c>, defaults to <see cref="System.Text.Encoding.UTF8"/>.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string message, System.Text.Encoding encoding = null) => PublishAsync("", message, encoding);

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="orderingKey">The ordering key to use for this message.</param>
        /// <param name="message">The message to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string orderingKey, IMessage message) =>
            PublishAsync(new PubsubMessage
            {
                OrderingKey = orderingKey ?? "",
                Data = message.ToByteString()
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The message to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(IMessage message) => PublishAsync("", message);

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="orderingKey">The ordering key to use for this message.</param>
        /// <param name="message">The <see cref="ByteString"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string orderingKey, ByteString message) =>
            PublishAsync(new PubsubMessage
            {
                OrderingKey = orderingKey ?? "",
                Data = message
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="ByteString"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(ByteString message) => PublishAsync("", message);

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="orderingKey">The ordering key to use for this message.</param>
        /// <param name="message">The message to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string orderingKey, byte[] message) =>
            PublishAsync(new PubsubMessage
            {
                OrderingKey = orderingKey ?? "",
                Data = ByteString.CopyFrom(message)
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The message to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(byte[] message) => PublishAsync("", message);

        /// <summary>
        /// Re-enable publishing the the given ordering key, after an error has caused the ordering key to be disabled.
        /// </summary>
        /// <param name="orderingKey">The ordering key to re-enable.</param>
        public virtual void ResumePublish(string orderingKey) => throw new NotImplementedException();

        /// <summary>
        /// Shutdown this <see cref="PublisherClient"/>. Cancelling <paramref name="hardStopToken"/> aborts the
        /// clean shutdown process, and may leave some locally queued messages unsent.
        /// The returned <see cref="Task"/> completes when all queued messages have been published.
        /// The returned <see cref="Task"/> cancels if <paramref name="hardStopToken"/> is cancelled.
        /// </summary>
        /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort publishing queued messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if
        /// <paramref name="hardStopToken"/> is cancelled.</returns>
        public virtual Task ShutdownAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// Shutdown this <see cref="PublisherClient"/>. If <paramref name="timeout"/> expires, the clean shutdown process will
        /// abort; leaving some locally queued messages unsent.
        /// The returned <see cref="Task"/> completes when all queued messages have been published.
        /// The returned <see cref="Task"/> cancels if the <paramref name="timeout"/> expires before all messages are published.
        /// </summary>
        /// <param name="timeout">After this period, abort publishing queued messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if
        /// <paramref name="timeout"/> expires.</returns>
        public virtual Task ShutdownAsync(TimeSpan timeout) => ShutdownAsync(new CancellationTokenSource(timeout).Token);
    }

    /// <summary>
    /// Implementation of PubSub publisher that is associated with a specific <see cref="TopicName"/>.
    /// </summary>
    public sealed class PublisherClientImpl : PublisherClient
    {
        /// <summary>
        /// A batch of messages that all have the same ordering-key (or no ordering-key), and will be
        /// sent to the server in a single network call.
        /// A batch has been "processed" when it can no longer be changed. This will mean it has either been inserted into
        /// the queue for sending to the server, or has an ordering-key and is queued behind another batch with the same ordering-key.
        /// </summary>
        private class Batch
        {
            public TaskCompletionSource<IList<string>> BatchCompletion { get; } = new TaskCompletionSource<IList<string>>();
            public List<PubsubMessage> Messages { get; private set; } = new List<PubsubMessage>();
            public CancellationTokenSource ProcessedCts { get; } = new CancellationTokenSource();
            public long ByteCount { get; private set; }

            public bool IsProcessed => ProcessedCts.IsCancellationRequested;

            public int AddMessage(PubsubMessage message, int byteCount)
            {
                // Pre-condition: Must be locked
                Messages.Add(message);
                ByteCount += byteCount;
                return Messages.Count - 1;
            }
        }

        private enum OrderingKeyState
        {
            /// <summary>
            /// No batches in-flight for this key, and key is not in an error state.
            /// The empty ordering-key (meaning no ordering) is always in this state.
            /// </summary>
            Normal = 0,

            /// <summary>
            /// This key has a batch in the "batches-ready" queue, or actually in-flight to/from server.
            /// </summary>
            InFlight,

            /// <summary>
            /// This ordering-key is in an error state, so reject all messages.
            /// </summary>
            Error,
        };

        private class KeyState
        {
            public KeyState(string orderingKey) => OrderingKey = orderingKey;
            public string OrderingKey { get; } // Never null.
            public LinkedList<Batch> Batches { get; } = new LinkedList<Batch>(); // First: Currently-filling batch; Last: Next batch to send.
            public OrderingKeyState State { get; private set; } = OrderingKeyState.Normal;

            public bool HasOrderingKey => OrderingKey.Length > 0;

            public void SetState(OrderingKeyState state)
            {
                // The state of ordering-key "" (ie no ordering key) is always `Normal`.
                if (HasOrderingKey)
                {
                    State = state;
                }
            }
        }

        private struct ReadyBatch
        {
            public ReadyBatch(KeyState state, Batch batch)
            {
                State = state;
                Batch = batch;
            }
            public KeyState State { get; }
            public Batch Batch { get; }
        }

        // TODO: Logging

        /// <summary>
        /// Instantiate a <see cref="PublisherClientImpl"/> associated with the specified <see cref="TopicName"/>.
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="clients">The <see cref="PublisherClient"/>s to use.</param>
        /// <param name="settings"><see cref="PublisherClient.Settings"/> to use in this <see cref="PublisherClientImpl"/>.</param>
        /// <param name="shutdown">Function to call on this <see cref="PublisherClientImpl"/> shutdown.</param>
        public PublisherClientImpl(TopicName topicName, IEnumerable<PublisherServiceApiClient> clients, Settings settings, Func<Task> shutdown)
            : this(topicName, clients, settings, shutdown, TaskHelper.Default) { }

        internal PublisherClientImpl(TopicName topicName, IEnumerable<PublisherServiceApiClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
        {
            TopicName = GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            GaxPreconditions.CheckNotNull(clients, nameof(clients));
            _idleClients = new Queue<PublisherServiceApiClient>(clients);
            GaxPreconditions.CheckArgument(_idleClients.Count > 0, nameof(clients), "Must contain at least one client");
            GaxPreconditions.CheckArgument(_idleClients.All(x => x != null), nameof(clients), "All elements must be non-null");
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            settings.Validate();
            _shutdown = shutdown;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _enableMessageOrdering = settings.EnableMessageOrdering;

            // Initialise batching settings. Use ApiMax settings for components not given.
            var batchingSettings = settings.BatchingSettings ?? DefaultBatchingSettings;
            _batchElementCountThreshold = batchingSettings.ElementCountThreshold ?? ApiMaxBatchingSettings.ElementCountThreshold.Value;
            _batchByteCountThreshold = batchingSettings.ByteCountThreshold ?? ApiMaxBatchingSettings.ByteCountThreshold.Value;
            _batchDelayThreshold = batchingSettings.DelayThreshold;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;

            // Initialise internal state
            _batchesReady = new Queue<ReadyBatch>();
            _keyedState = new Dictionary<string, KeyState>();
            _softStopCts = new CancellationTokenSource();
            _hardStopCts = new CancellationTokenSource();
            _shutdownTcs = new TaskCompletionSource<int>();
        }

        private readonly object _lock = new object();
        private readonly object _shutdownLock = new object();
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly Func<Task> _shutdown;
        private readonly bool _enableMessageOrdering;

        // Batching settings
        private readonly long _batchElementCountThreshold;
        private readonly long _batchByteCountThreshold;
        private readonly TimeSpan? _batchDelayThreshold;

        // Internal state. All potential concurrent access guarded by `_lock`.
        // Clients idle, ready to be used.
        private readonly Queue<PublisherServiceApiClient> _idleClients;
        // Batches ready to send. Will only ever include at most one batch per ordering-key.
        private readonly Queue<ReadyBatch> _batchesReady;
        // For each ordering-key (including empty), the OrderingKeyState and batch(es) of messages.
        private readonly Dictionary<string, KeyState> _keyedState;
        private int _batchesInFlightCount;
        // Cancellation/shutdown state
        private bool _shutdownStarted;
        private readonly CancellationTokenSource _softStopCts;
        private readonly CancellationTokenSource _hardStopCts;
        private readonly TaskCompletionSource<int> _shutdownTcs;

        /// <inheritdoc/>
        public override TopicName TopicName { get; }

        /// <inheritdoc/>
        public override async Task<string> PublishAsync(PubsubMessage message)
        {
            string orderingKey = message.OrderingKey ?? "";
            if (!_enableMessageOrdering && orderingKey.Length > 0)
            {
                throw new InvalidOperationException($"Message ordering must be enabled in settings before using {nameof(message.OrderingKey)}");
            }
            Task<IList<string>> batchTask;
            int index;
            int messageByteCount = message.CalculateSize();
            lock (_lock)
            {
                // Check for shutdown in the lock, to avoid a race-condition.
                CheckShutdown();
                // Get existing state for this ordering-key
                var hasState = _keyedState.TryGetValue(orderingKey, out var state);
                // Check for an error condition for the ordering-key.
                if (hasState && state.State == OrderingKeyState.Error)
                {
                    throw new OrderingKeyInErrorStateException(orderingKey);
                }

                // Possible states:
                // * No existing batches with the given ordering-key.
                // * Existing batches, with one that is not yet full.
                // * Existing batches, but all are full or in-flight.
                if (hasState)
                {
                    // Batches for this ordering-key already exist.
                    // Queue the current batch if this message would cause the batch to go over-byte-size
                    // (unless this would be the only message in the batch, then it's allowed).
                    ProcessBatchIfFull(state, messageByteCount);
                }
                else
                {
                    // Batches for this ordering-key do not exist; so create an empty list of batches.
                    state = new KeyState(orderingKey);
                    _keyedState.Add(orderingKey, state);
                }
                var batches = state.Batches;
                if (batches.Count == 0 || batches.First.Value.IsProcessed)
                {
                    // Create a new batch; and prepare to send it after the user-configured delay.
                    var newBatch = new Batch();
                    batches.AddFirst(newBatch);
                    DelaySendBatch(state, newBatch);
                }
                var currentBatch = batches.First.Value;
                batchTask = currentBatch.BatchCompletion.Task;
                // Add message to current batch, and record the message index for later ID retrieval.
                index = currentBatch.AddMessage(message, messageByteCount);
                // Queue the current batch if this message has caused the batch to be over-count or over-byte-size.
                ProcessBatchIfFull(state, 0);
            }
            // Awaits until batch is sent and response received.
            IList<string> ids = await _taskHelper.ConfigureAwait(batchTask);
            // Return the message ID sent from the server.
            return ids[index];
        }

        /// <inheritdoc/>
        public override void ResumePublish(string orderingKey)
        {
            GaxPreconditions.CheckNotNullOrEmpty(orderingKey, nameof(orderingKey));
            lock (_lock)
            {
                if (_keyedState.TryGetValue(orderingKey, out var state))
                {
                    if (state.State == OrderingKeyState.Error)
                    {
                        // Remove ordering-key, which signals this ordering-key is in Normal state.
                        _keyedState.Remove(orderingKey);
                    }
                }
            }
        }

        /// <inheritdoc/>
        public override Task ShutdownAsync(CancellationToken hardStopToken)
        {
            lock (_lock)
            {
                CheckShutdown();
                _softStopCts.Cancel();
                foreach (var state in _keyedState.Values)
                {
                    if (state.Batches.Count > 0 && !state.Batches.First.Value.IsProcessed)
                    {
                        ProcessBatch(state);
                    }
                }
                var registration = hardStopToken.Register(() =>
                {
                    _hardStopCts.Cancel();
                    ShutdownIfCompleted();
                });
                _taskHelper.Run(async () =>
                {
                    await _taskHelper.ConfigureAwaitHideErrors(() => _shutdownTcs.Task);
                    registration.Dispose();
                });
                ShutdownIfCompleted();
            }
            return _shutdownTcs.Task;
        }

        private void CheckShutdown() => GaxPreconditions.CheckState(!_softStopCts.IsCancellationRequested, "Publisher already shutdown, cannot use");

        private void ShutdownIfCompleted()
        {
            // Pre-condition: Must be locked if not a hard stop
            if (_hardStopCts.IsCancellationRequested || (_softStopCts.IsCancellationRequested && _batchesInFlightCount == 0 && _batchesReady.Count == 0))
            {
                lock (_shutdownLock)
                {
                    if (_shutdownStarted)
                    {
                        return;
                    }
                    _shutdownStarted = true;
                }
                if (_hardStopCts.IsCancellationRequested)
                {
                    // Cancel any remaining batches. Only relevant if hard-stopped.
                    List<Batch> batchesToCancel;
                    lock (_lock)
                    {
                        batchesToCancel = _batchesReady.Select(x => x.Batch)
                            .Concat(_keyedState.Values.SelectMany(state => state.Batches))
                            .ToList();
                    }
                    foreach (var batch in batchesToCancel)
                    {
                        batch.BatchCompletion.SetCanceled();
                    }
                }
                // All batches sent and shutdown requested, so signal shutdown completed successfully.
                _taskHelper.Run(async () =>
                {
                    if (_shutdown != null)
                    {
                        await _taskHelper.ConfigureAwaitHideErrors(_shutdown);
                    }
                    if (_hardStopCts.IsCancellationRequested)
                    {
                        _shutdownTcs.SetCanceled();
                    }
                    else
                    {
                        _shutdownTcs.SetResult(0);
                    }
                });
            }
        }

        private void DelaySendBatch(KeyState state, Batch batch)
        {
            // Pre-condition: Must be locked.
            if (_batchDelayThreshold is TimeSpan batchDelayThreshold)
            {
                _taskHelper.Run(async () =>
                {
                    using (var timerCancellation = CancellationTokenSource.CreateLinkedTokenSource(batch.ProcessedCts.Token, _hardStopCts.Token))
                    {
                        var cancelled = await _taskHelper.ConfigureAwaitHideCancellation(() => _scheduler.Delay(batchDelayThreshold, timerCancellation.Token));
                        if (!cancelled)
                        {
                            // If batch has already been processed, ProcessedCts will have been cancelled.
                            lock (_lock)
                            {
                                // Check for cancellation inside lock to avoid race-condition.
                                if (!timerCancellation.IsCancellationRequested)
                                {
                                    // Force queuing of the current batch, whatever the size.
                                    // There will always be at least one message in the batch.
                                    ProcessBatch(state);
                                }
                            }
                        }
                    }
                });
            }
        }

        private void ProcessBatchIfFull(KeyState state, int extraByteCount)
        {
            // Pre-condition: Must be locked
            if (state.Batches.Count == 0)
            {
                return;
            }
            var currentBatch = state.Batches.First.Value;
            // Current batch is full if either:
            // * The number of messages in the batch >= the maximum number of messages allowed; or
            // * The byte-count in the batch >= the maximum number of messages allowed.
            // Special cases:
            // * Before a message is queued, this method is called with the message byte-count;
            //   If this message would cause the batch to exceed the maxmium byte-count, then this
            //   batch is considered already full.
            // * But if that is the first message in the batch, then that one message only is allowed
            //   to make the batch go over its maximum allowed byte-count.
            bool currentBatchIsFull = currentBatch.Messages.Count >= _batchElementCountThreshold ||
                (currentBatch.Messages.Count > 0 && currentBatch.ByteCount + extraByteCount >= _batchByteCountThreshold);
            if (currentBatchIsFull)
            {
                ProcessBatch(state);
            }
        }

        private void ProcessBatch(KeyState state)
        {
            // Pre-condition: Must be locked.
            // Pre-condition: batches.Count > 0
            // Pre-condition: First batch must not already be processed.
            // Mark first batch as full, and cancel its send timeout.
            var first = state.Batches.First.Value;
            first.ProcessedCts.Cancel();
            // If key is not in-flight, then move the last batch to the ready queue.
            if (state.State == OrderingKeyState.Normal)
            {
                QueueReadyBatch(state);
                // Trigger a send.
                TriggerSend();
            }
        }

        private void QueueReadyBatch(KeyState state)
        {
            // Pre-condition: Must be locked.
            // Pre-condition: The last batch in this state must already be processed.
            // Pre-condition: This state must be "Normal".
            _batchesReady.Enqueue(new ReadyBatch(state, state.Batches.Last.Value));
            state.Batches.RemoveLast();
            // Mark this ordering-key as inflight.
            state.SetState(OrderingKeyState.InFlight);
        }

        private void TriggerSend()
        {
            // Pre-condition: Must be locked.
            // Start sending a batch if there's a batch to send, and a client to use to send it.
            if (_batchesReady.Count == 0 || _idleClients.Count == 0)
            {
                return;
            }
            // Remove client and batch from relevant queues.
            var client = _idleClients.Dequeue();
            var readyBatch = _batchesReady.Dequeue();
            var batch = readyBatch.Batch;
            var state = readyBatch.State;
            _batchesInFlightCount += 1;
            // Send the batch
            _taskHelper.Run(Send);

            async Task Send()
            {
                // Perform the RPC to server, catching exceptions.
                var publishTask = client.PublishAsync(TopicName, batch.Messages, CallSettings.FromCancellationToken(_hardStopCts.Token));
                var response = await _taskHelper.ConfigureAwaitHideErrors(() => publishTask, null);
                Action postLockAction;
                lock (_lock)
                {
                    _batchesInFlightCount -= 1;
                    _idleClients.Enqueue(client);
                    ShutdownIfCompleted();
                    state.SetState(OrderingKeyState.Normal);
                    var batches = state.Batches;
                    switch (publishTask.Status)
                    {
                        case TaskStatus.RanToCompletion:
                            postLockAction = () => batch.BatchCompletion.SetResult(response.MessageIds);
                            break;
                        case TaskStatus.Canceled:
                            postLockAction = () => batch.BatchCompletion.SetCanceled();
                            break;
                        case TaskStatus.Faulted:
                            // If an ordering-key is present:
                            // * A recoverable error is retried forever.
                            // * A non-recoverable error fails all queued unsent messages that have the same ordering-key,
                            //   and then refuses any more messages for that ordering-key until `ResumePublish()` is called.
                            // If an ordering-key is not present:
                            // * Standard gRPC retry behaviour within the underlying client is used.
                            //   On failure just the single batch fails, and further messages are accepted.
                            if (state.HasOrderingKey)
                            {
                                if (publishTask.Exception.As<RpcException>()?.IsRecoverable() ?? false)
                                {
                                    // Rebatch failed messages.
                                    batches.AddLast(batch);
                                    postLockAction = () => { };
                                }
                                else
                                {
                                    // Prepare to fail all batches, clear all batches, and mark ordering-key as in error state.
                                    var batchesToFail = new List<Batch>(batches) { batch };
                                    postLockAction = () =>
                                    {
                                        foreach (var batchToFail in batchesToFail)
                                        {
                                            batchToFail.BatchCompletion.SetException(publishTask.Exception.InnerExceptions);
                                        }
                                    };
                                    batches.Clear();
                                    state.SetState(OrderingKeyState.Error);
                                }
                            }
                            else
                            {
                                // No ordering-key, just fail the batch.
                                postLockAction = () => batch.BatchCompletion.SetException(publishTask.Exception.InnerExceptions);
                            }
                            break;
                        default:
                            throw new InvalidOperationException("Invalid TaskStatus");
                    }
                    // Queue the next batch with the ordering-key of the batch just sent; if one exists.
                    if (batches.Count > 0 && batches.Last.Value.IsProcessed)
                    {
                        QueueReadyBatch(state);
                    }
                    // Trigger a new send, if there is any more data ready to send.
                    TriggerSend();
                }
                postLockAction();
            }
        }
    }
}
