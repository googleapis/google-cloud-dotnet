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
using Google.Protobuf;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// A PubSub publisher that is associated with a specific <see cref="TopicName"/>.
    /// </summary>
    public abstract class HiPerfPublisher
    {
        // TODO: Logging

        /// <summary>
        /// Settings for the <see cref="HiPerfPublisher"/>.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Instantiate settings with pre-created <see cref="PublisherClient"/>s.
            /// </summary>
            /// <param name="clients">The <see cref="PublisherClient"/>s to use in a <see cref="HiPerfPublisher"/>"/>.</param>
            public Settings(IList<PublisherClient> clients) => Clients = clients;

            /// <summary>
            /// Instantiate settings, optionally specifying client creation parameters.
            /// </summary>
            /// <param name="clientCount">Optional. The number of clients to create.
            /// Defaults to the CPU count on the machine this is being executed on.</param>
            /// <param name="publisherSettings">Optional. The settings to use when creating <see cref="Publisher"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use then creating <see cref="Publisher"/> instances.
            /// Defaults to using the default credentials.</param>
            public Settings(int? clientCount = null, PublisherSettings publisherSettings = null, ChannelCredentials credentials = null)
            {
                ClientCount = clientCount;
                PublisherSettings = publisherSettings;
                Credentials = credentials;
            }

            internal Settings(Settings other)
            {
                Clients = other.Clients != null ? new List<PublisherClient>(other.Clients) : null;
                ClientCount = other.ClientCount;
                PublisherSettings = other.PublisherSettings?.Clone();
                Credentials = other.Credentials;
                BatchingSettings = other.BatchingSettings?.Clone();
                Scheduler = other.Scheduler;
                BatchMaxElementCount = other.BatchMaxElementCount;
                BatchMaxByteCount = other.BatchMaxByteCount;
            }

            /// <summary>
            /// The clients to use within a <see cref="HiPerfPublisher"/>.
            /// </summary>
            public IList<PublisherClient> Clients { get; }

            /// <summary>
            /// The number of <see cref="PublisherClient"/> to create and use within a <see cref="HiPerfPublisher"/> instance.
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="Publisher"/> instances.
            /// If <c>null</c>, defaults to <see cref="PublisherSettings.GetDefault"/>.
            /// </summary>
            public PublisherSettings PublisherSettings { get; }

            /// <summary>
            /// Credentials to use then creating <see cref="Publisher"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

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
            /// The absolute maximum element count in a pubsub Publish.
            /// If <c>null</c>, defaults to <see cref="ApiMaxRequestElementCount"/>. Usually leave this unset.
            /// </summary>
            public long? BatchMaxElementCount { get; set; }

            /// <summary>
            /// The absolute maximum byte count in a pubsub Publish.
            /// If <c>null</c>, defaults to <see cref="ApiMaxRequestByteCount"/>. Usually leave this unset.
            /// </summary>
            public long? BatchMaxByteCount { get; set; }

            internal void Validate()
            {
                if (Clients != null)
                {
                    GaxPreconditions.CheckArgument(Clients.Count > 0, nameof(Clients), "If non-null, then must contain at least one element");
                    GaxPreconditions.CheckArgument(Clients.All(x => x != null), nameof(Clients), "If non-null, then all elements must be non-null");
                }
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
                if (BatchingSettings != null)
                {
                    GaxPreconditions2.CheckArgumentRange(BatchingSettings.ElementCountThreshold ?? 1, nameof(BatchingSettings.ElementCountThreshold), 1, ApiMaxRequestElementCount);
                    GaxPreconditions2.CheckArgumentRange(BatchingSettings.RequestByteThreshold ?? 1, nameof(BatchingSettings.RequestByteThreshold), 1, ApiMaxRequestByteCount);
                    GaxPreconditions.CheckArgument((BatchingSettings.DelayThreshold ?? TimeSpan.FromSeconds(1)) > TimeSpan.Zero, nameof(BatchingSettings.DelayThreshold), "Must be positive");
                }
                GaxPreconditions2.CheckArgumentRange(BatchMaxElementCount ?? 1, nameof(BatchMaxElementCount), 1, ApiMaxRequestElementCount);
                GaxPreconditions2.CheckArgumentRange(BatchMaxByteCount ?? 1, nameof(BatchMaxByteCount), 1, ApiMaxRequestByteCount);
            }

            /// <summary>
            /// Create a deep clone of this object.
            /// </summary>
            /// <returns>A deep clone of this object.</returns>
            public Settings Clone() => new Settings(this);
        }

        /// <summary>
        /// A snapshot of the flow state of a <see cref="HiPerfPublisher"/>.
        /// </summary>
        public struct FlowState
        {
            /// <summary>
            /// Instantiate a <see cref="FlowState"/>.
            /// </summary>
            /// <param name="elementCount">The number of elements (messages) currently queued.</param>
            /// <param name="byteCount">The number of bytes currently queued.</param>
            public FlowState(long elementCount, long byteCount)
            {
                ElementCount = elementCount;
                ByteCount = byteCount;
            }

            /// <summary>
            /// The number of elements (messages) currently queued.
            /// </summary>
            public long ElementCount { get; }

            /// <summary>
            /// The number of bytes currently queued.
            /// </summary>
            public long ByteCount { get; }
        }

        // All defaults taken from Java (reference) implementation.

        /// <summary>
        /// The maximum number of messages in one request; set to 1000 messages. Defined by the API.
        /// </summary>
        public static long ApiMaxRequestElementCount => 1000L;

        /// <summary>
        /// The maximum number of bytes in one request; set to 10 megabytes. Defined by the API.
        /// </summary>
        public static long ApiMaxRequestByteCount => 10_000_000L;

        /// <summary>
        /// The default batch delay threshold; set to 1 millisecond.
        /// </summary>
        public static TimeSpan DefaultBatchingDelayThreshold => TimeSpan.FromMilliseconds(1);

        /// <summary>
        /// The default batch element count; set to 100 messages.
        /// </summary>
        public static long DefaultBatchingElementCountThreshold => 100L;

        /// <summary>
        /// The default batch byte count; set to 1000 bytes (1 kilobyte).
        /// </summary>
        public static long DefaultBatchingRequestByteThreshold => 1000L;

        /// <summary>
        /// Default <see cref="BatchingSettings"/> for <see cref="HiPerfPublisher"/>.
        /// Default values are: <see cref="BatchingSettings.DelayThreshold"/> = 1 millisecond;
        /// <see cref="BatchingSettings.ElementCountThreshold"/> = 100;
        /// <see cref="BatchingSettings.RequestByteThreshold"/> = 1000
        /// </summary>
        /// <returns>Default <see cref="BatchingSettings"/> for <see cref="HiPerfPublisher"/>.</returns>
        public static BatchingSettings DefaultBatchingSettings() => new BatchingSettings
        {
            DelayThreshold = DefaultBatchingDelayThreshold,
            ElementCountThreshold = DefaultBatchingElementCountThreshold,
            RequestByteThreshold = DefaultBatchingRequestByteThreshold,
        };

        /// <summary>
        /// Create a <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>.  
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="settings">Optional <see cref="Settings"/> for this instance.</param>
        /// <returns>A <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>.</returns>
        public static async Task<HiPerfPublisher> CreateAsync(TopicName topicName, Settings settings = null)
        {
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            Func<Task> shutdown = null;
            if (settings.Clients == null)
            {
                // Clients not given, so create default clients.
                var clientCount = settings?.ClientCount ?? Environment.ProcessorCount;
                var channelCredentials = settings?.Credentials;
                // Use default credentials if none given.
                if (channelCredentials == null)
                {
                    var credentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
                    if (credentials.IsCreateScopedRequired)
                    {
                        credentials = credentials.CreateScoped(PublisherClient.DefaultScopes);
                    }
                    channelCredentials = credentials.ToChannelCredentials();
                }
                // Create the channels and clients, and register shutdown functions for each channel
                var clients = new PublisherClient[clientCount];
                var shutdowns = new Func<Task>[clientCount];
                for (int i = 0; i < clientCount; i += 1)
                {
                    var channel = new Channel(PublisherClient.DefaultEndpoint.Host, PublisherClient.DefaultEndpoint.Port, channelCredentials);
                    clients[i] = PublisherClient.Create(channel, settings?.PublisherSettings);
                    shutdowns[i] = channel.ShutdownAsync;
                }
                shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));
                // Create new settings with the created clients, and clone the non-client settings
                settings = new Settings(clients)
                {
                    BatchingSettings = settings.BatchingSettings,
                    Scheduler = settings.Scheduler,
                    BatchMaxElementCount = settings.BatchMaxElementCount,
                    BatchMaxByteCount = settings.BatchMaxByteCount,
                };
            }
            // Instantiate the publisher
            return new HiPerfPublisherImpl(topicName, settings, shutdown, TaskHelper.Default);
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
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <param name="encoding">The encoding for string to byte conversion.
        /// If <c>null</c>, defaults to <see cref="Encoding.UTF8"/>.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(string message, Encoding encoding = null) =>
            PublishAsync(new PubsubMessage
            {
                Data = encoding == null ? ByteString.CopyFromUtf8(message) : ByteString.CopyFrom(encoding.GetBytes(message))
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(IMessage message) =>
            PublishAsync(new PubsubMessage
            {
                Data = message.ToByteString()
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(ByteString message) =>
            PublishAsync(new PubsubMessage
            {
                Data = message
            });

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(byte[] message) =>
            PublishAsync(new PubsubMessage
            {
                Data = ByteString.CopyFrom(message)
            });

        /// <summary>
        /// Retrieve a snapshot of the flow state.
        /// </summary>
        /// <returns></returns>
        public virtual FlowState GetCurrentFlowState() => throw new NotImplementedException();

        /// <summary>
        /// Shutdown this <see cref="HiPerfPublisher"/>.
        /// The returned <see cref="Task"/> completes when all queued messages have been published.
        /// The returned <see cref="Task"/> cancels if the passed <see cref="CancellationToken"/> is cancelled.
        /// Cancelling the passed <see cref="CancellationToken"/> aborts publishing, and cancels the returned
        /// <see cref="Task"/> as quickly as possible.
        /// </summary>
        /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort publishing queued messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if the
        /// passed <see cref="CancellationToken"/> is cancelled.</returns>
        public virtual Task ShutdownAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// Shutdown this <see cref="HiPerfPublisher"/>.
        /// The returned <see cref="Task"/> completes when all queued messages have been published.
        /// The returned <see cref="Task"/> cancels if the passed timeout expires before all messages are published.
        /// </summary>
        /// <param name="timeout">After this period, abort publishing queued messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if the
        /// passed timeout expires.</returns>
        public virtual Task ShutdownAsync(TimeSpan timeout) => ShutdownAsync(new CancellationTokenSource(timeout).Token);
    }

    /// <summary>
    /// Implementation of PubSub publisher that is associated with a specific <see cref="TopicName"/>.
    /// </summary>
    public sealed class HiPerfPublisherImpl : HiPerfPublisher
    {
        private class Batch
        {
            public TaskCompletionSource<IList<string>> BatchCompletion { get; } = new TaskCompletionSource<IList<string>>();
            public List<PubsubMessage> Messages { get; } = new List<PubsubMessage>();
            public CancellationTokenSource TimerCts { get; } = new CancellationTokenSource();
            public long ByteCount { get; private set; }

            public int AddMessage(PubsubMessage message, int byteCount)
            {
                // Pre-condition: Must be locked
                Messages.Add(message);
                ByteCount += byteCount;
                return Messages.Count - 1;
            }
        }

        // TODO: Logging

        /// <summary>
        /// Instantiate a <see cref="HiPerfPublisherImpl"/> associated with the specified <see cref="TopicName"/>.
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="settings"><see cref="HiPerfPublisher.Settings"/> to use in this <see cref="HiPerfPublisherImpl"/>.</param>
        /// <param name="shutdown">Function to call on publisher shutdown.</param>
        public HiPerfPublisherImpl(TopicName topicName, Settings settings, Func<Task> shutdown)
            : this(topicName, settings, shutdown, TaskHelper.Default) { }

        internal HiPerfPublisherImpl(TopicName topicName, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
        {
            TopicName = GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            GaxPreconditions.CheckNotNull(settings.Clients, nameof(settings.Clients));
            settings.Validate();
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));
            _shutdown = shutdown;

            // Initialise settings
            var batchingSettings = settings.BatchingSettings ?? DefaultBatchingSettings();
            _batchElementCountThreshold = batchingSettings.ElementCountThreshold ?? ApiMaxRequestElementCount;
            _batchRequestByteThreshold = batchingSettings.RequestByteThreshold ?? ApiMaxRequestByteCount;
            _batchDelayThreshold = batchingSettings.DelayThreshold ?? TimeSpan.FromHours(1);
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            _batchMaxElementCount = settings.BatchMaxElementCount ?? ApiMaxRequestElementCount;
            _batchMaxByteCount = settings.BatchMaxByteCount ?? ApiMaxRequestByteCount;

            // Initialise internal state
            _batchesReady = new Queue<Batch>();
            _idleClients = new Queue<PublisherClient>(settings.Clients);
            _softStopCts = new CancellationTokenSource();
            _hardStopCts = new CancellationTokenSource();
            _shutdownTcs = new TaskCompletionSource<int>();
        }

        private readonly object _lock = new object();
        private readonly object _shutdownLock = new object();
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly Func<Task> _shutdown;

        // Batching settings
        private readonly long _batchElementCountThreshold;
        private readonly long _batchRequestByteThreshold;
        private readonly TimeSpan _batchDelayThreshold;

        // Absolute maximum batch values
        private readonly long _batchMaxElementCount;
        private readonly long _batchMaxByteCount;

        //Internal state
        private readonly Queue<PublisherClient> _idleClients;
        private readonly Queue<Batch> _batchesReady;
        private Batch _currentBatch;
        private long _queueElementCount;
        private long _queueByteCount;
        private int _batchesInFlightCount;
        private CancellationTokenSource _softStopCts;
        private CancellationTokenSource _hardStopCts;
        private TaskCompletionSource<int> _shutdownTcs;
        private bool _shutdownStarted;

        /// <inheritdoc/>
        public override TopicName TopicName { get; }

        /// <inheritdoc/>
        public override async Task<string> PublishAsync(PubsubMessage message)
        {
            CheckShutdown();
            Task<IList<string>> batchTask;
            int index;
            int messageByteCount = message.CalculateSize();
            lock (_lock)
            {
                // Update flow-control counts.
                _queueElementCount += 1;
                _queueByteCount += messageByteCount;
                // Queue the current batch if this message would cause the batch to go over-byte-size
                // (unless this would be the only message in the batch, then it's allowed).
                QueueCurrentBatchIfRequired(false, messageByteCount);
                if (_currentBatch == null)
                {
                    // Create a new batch if this is the first ever batch, or a batch has just been queued.
                    Task unusedTimeoutTask = CreateBatch();
                }
                batchTask = _currentBatch.BatchCompletion.Task;
                // Add message to current batch, and record the message index for later ID retrieval.
                index = _currentBatch.AddMessage(message, messageByteCount);
                // Queue the current batch if this message has caused the batch to be over-count or over-byte-size.
                QueueCurrentBatchIfRequired(false, 0);
            }
            // Awaits until batch is sent and response received.
            IList<string> ids = await _taskHelper.ConfigureAwait(batchTask);
            // Return the message ID sent from the server.
            return ids[index];
        }

        /// <inheritdoc/>
        public override FlowState GetCurrentFlowState() => _lock.Locked(() => new FlowState(_queueElementCount, _queueByteCount));

        /// <inheritdoc/>
        public override Task ShutdownAsync(CancellationToken hardStopToken)
        {
            lock (_lock)
            {
                CheckShutdown();
                _softStopCts.Cancel();
                QueueCurrentBatchIfRequired(true, 0);
                var registration = hardStopToken.Register(() =>
                {
                    _hardStopCts.Cancel();
                    ShutdownIfCompleted();
                });
                _taskHelper.Run(async () =>
                {
                    await _taskHelper.ConfigureAwaitHideErrors(_shutdownTcs.Task);
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
                if (_shutdownLock.Locked(() => {
                    var shutdownStarted = _shutdownStarted;
                    _shutdownStarted = true;
                    return !shutdownStarted;
                }))
                {
                    // All batches sent and shutdown requested, so signal shutdown completed successfully.
                    _taskHelper.Run(async () =>
                    {
                        if (_shutdown != null)
                        {
                            await _taskHelper.ConfigureAwaitHideErrors(_shutdown());
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
        }

        // Not "async void" to gain standard async exeption handling
        private async Task CreateBatch()
        {
            // Pre-condition: Must be locked - lock active up until first 'await'.
            _currentBatch = new Batch();
            var timerToken = _currentBatch.TimerCts.Token;
            // After time-delay threshold, send the batch regardless of fullness.
            await _taskHelper.ConfigureAwait(_scheduler.Delay(_batchDelayThreshold, timerToken));
            // If batch has already moved to queue, timerToken will have been cancelled.
            lock (_lock)
            {
                // Check for cancellation inside lock to avoid race-condition.
                if (!timerToken.IsCancellationRequested)
                {
                    // Force queuing of the current batch, whatever the size.
                    // There will always be at least one message in the batch.
                    QueueCurrentBatchIfRequired(true, 0);
                }
            }
        }

        private void QueueCurrentBatchIfRequired(bool force, int extraByteCount)
        {
            // Pre-condition: Must be locked
            if (_currentBatch != null && (force || CurrentBatchIsFull(_idleClients.Count == 0, extraByteCount)))
            {
                // Cancel the timeout for this batch.
                _currentBatch.TimerCts.Cancel();
                // Queue the batch ready for sending.
                _batchesReady.Enqueue(_currentBatch);
                // Mark that there is no current batch.
                _currentBatch = null;
                // Trigger send to server.
                Task unusedSendTask = TriggerSend();
            }
        }

        // Pre-condition: Must be locked
        // Allow one message that is larger than requestByteThreshold
        private bool CurrentBatchIsFull(bool isQueuing, int extraByteCount) => isQueuing ?
                _currentBatch.Messages.Count >= _batchMaxElementCount || (_currentBatch.Messages.Count > 0 && _currentBatch.ByteCount >= _batchMaxByteCount) :
                _currentBatch.Messages.Count >= _batchElementCountThreshold || (_currentBatch.Messages.Count > 0 && _currentBatch.ByteCount >= _batchRequestByteThreshold);

        // Not "async void" to gain standard async exeption handling
        private async Task TriggerSend()
        {
            // Pre-condition: Must be locked - lock active up until first 'await'
            // Start sending a batch if there's a batch to send, and a client to use to send it.
            if (_batchesReady.Count > 0 && _idleClients.Count > 0)
            {
                // Remove client and batch from relevant queues.
                var client = _idleClients.Dequeue();
                var batch = _batchesReady.Dequeue();
                _batchesInFlightCount += 1;
                // Update flow-control counts.
                _queueElementCount -= batch.Messages.Count;
                _queueByteCount -= batch.ByteCount;
                // Perform the RPC to server, catching exceptions.
                try
                {
                    var response = await _taskHelper.ConfigureAwait(client.PublishAsync(TopicName, batch.Messages, CallSettings.FromCancellationToken(_hardStopCts.Token)));
                    batch.BatchCompletion.SetResult(response.MessageIds);
                }
                catch (Exception e)
                {
                    batch.BatchCompletion.SetException(e);
                }
                // A client is now idle. Record it, and see if a further batch is ready to send.
                lock (_lock)
                {
                    _batchesInFlightCount -= 1;
                    _idleClients.Enqueue(client);
                    ShutdownIfCompleted();
                    if (_batchesReady.Count > 0)
                    {
                        // Already a batch in the ready-queue, so just send it.
                        Task unusedSendTask = TriggerSend();
                    }
                    else
                    {
                        // If nothing queued to send, check to see if current batch is ready.
                        QueueCurrentBatchIfRequired(false, 0);
                    }
                }
            }
        }

    }
}
