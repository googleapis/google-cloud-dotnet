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

// This class uses TaskHelper.ConfigureAwait, rather than directly calling .ConfigureAwait().
// When running in a non-test environment this indirectly calls .ConfigureAwait(false).
// Disable the ConfigureAwaitChecker warning:
#pragma warning disable ConfigureAwaitChecker // CAC001

namespace Google.Cloud.PubSub.V1
{
    // TODO: See if we want a better name than "HiPerfPublisher"
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
            /// Create a new instance.
            /// </summary>
            public Settings() { }

            internal Settings(Settings other)
            {
                BatchingSettings = other.BatchingSettings;
                MaxBatchingSettings = other.MaxBatchingSettings;
                Scheduler = other.Scheduler;
            }

            /// <summary>
            /// <see cref="BatchingSettings"/> that control how messages are batched when sending.
            /// If <c>null</c>, defaults to <see cref="DefaultBatchingSettings"/>.
            /// </summary>
            public BatchingSettings BatchingSettings { get; set; }

            /// <summary>
            /// <see cref="BatchingSettings"/> that control how messages are batched when a batch
            /// cannot be immediately sent (because all clients are already busy sending batches).
            /// <see cref="BatchingSettings.DelayThreshold"/> is not relevant in this context.
            /// If <c>null</c>, defaults to <see cref="ApiMaxBatchingSettings"/>.
            /// </summary>
            public BatchingSettings MaxBatchingSettings { get; set; }

            /// <summary>
            /// The <see cref="IScheduler"/> to use.
            /// If <c>null</c>, defaults to <see cref="SystemScheduler"/>. Usually only useful for testing.
            /// </summary>
            public IScheduler Scheduler { get; set; }

            internal void Validate()
            {
                void ValidateBatchingSettings(BatchingSettings batchingSettings, string name)
                {
                    if (batchingSettings != null)
                    {
                        GaxPreconditions2.CheckArgumentRange(batchingSettings.ElementCountThreshold,
                            $"{name}.{nameof(BatchingSettings.ElementCountThreshold)}", 1, ApiMaxBatchingSettings.ElementCountThreshold.Value);
                        GaxPreconditions2.CheckArgumentRange(batchingSettings.RequestByteThreshold,
                            $"{name}.{nameof(BatchingSettings.RequestByteThreshold)}", 1, ApiMaxBatchingSettings.RequestByteThreshold.Value);
                        GaxPreconditions.CheckArgument((batchingSettings.DelayThreshold ?? TimeSpan.FromSeconds(1)) > TimeSpan.Zero,
                            $"{name}.{nameof(BatchingSettings.DelayThreshold)}", "Must be positive");
                    }
                }
                ValidateBatchingSettings(BatchingSettings, nameof(BatchingSettings));
                ValidateBatchingSettings(MaxBatchingSettings, nameof(MaxBatchingSettings));
            }

            /// <summary>
            /// Create a clone of this object.
            /// </summary>
            /// <returns>A clone of this object.</returns>
            public Settings Clone() => new Settings(this);
        }

        /// <summary>
        /// Settings for creating <see cref="PublisherClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="PublisherClient"/>s to create and use within a <see cref="HiPerfPublisher"/> instance.</param>
            /// <param name="publisherSettings">Optional. The settings to use when creating <see cref="PublisherClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="PublisherClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="PublisherClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                PublisherSettings publisherSettings = null,
                ChannelCredentials credentials = null,
                ServiceEndpoint serviceEndpoint = null)
            {
                ClientCount = clientCount;
                PublisherSettings = publisherSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
            }

            /// <summary>
            /// The number of <see cref="PublisherClient"/>s to create and use within a <see cref="HiPerfPublisher"/> instance.
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="PublisherClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="PublisherSettings.GetDefault"/>.
            /// </summary>
            public PublisherSettings PublisherSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="PublisherClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="PublisherClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="PublisherClient.DefaultEndpoint"/>.
            /// </summary>
            public ServiceEndpoint ServiceEndpoint { get; }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
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
        /// Default <see cref="BatchingSettings"/> for <see cref="HiPerfPublisher"/>.
        /// Default values are:
        /// <see cref="BatchingSettings.ElementCountThreshold"/> = 100;
        /// <see cref="BatchingSettings.RequestByteThreshold"/> = 1,000;
        /// <see cref="BatchingSettings.DelayThreshold"/> = 1 millisecond;
        /// </summary>
        public static BatchingSettings DefaultBatchingSettings { get; } = new BatchingSettings(100L, 1000L, TimeSpan.FromMilliseconds(1));

        /// <summary>
        /// The absolute maximum <see cref="BatchingSettings"/> supported by the service.
        /// Maximum values are:
        /// <see cref="BatchingSettings.ElementCountThreshold"/> = 1,000;
        /// <see cref="BatchingSettings.RequestByteThreshold"/> = 10,000,000;
        /// </summary>
        public static BatchingSettings ApiMaxBatchingSettings { get; } = new BatchingSettings(1000L, 10_000_000L, null);

        /// <summary>
        /// Create a <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>,
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="clientCreationsettings">Optional. <see cref="ClientCreationSettings"/> specifying how to create
        /// <see cref="PublisherClient"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="HiPerfPublisher"/>.</param>
        /// <returns>A <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>.</returns>
        public static async Task<HiPerfPublisher> CreateAsync(TopicName topicName, ClientCreationSettings clientCreationsettings = null, Settings settings = null)
        {
            clientCreationsettings?.Validate();
            // Clone settings, just in case user modifies them and an await happens in this method
            settings = settings?.Clone() ?? new Settings();
            var clientCount = clientCreationsettings?.ClientCount ?? Environment.ProcessorCount;
            var channelCredentials = clientCreationsettings?.Credentials;
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
            var endpoint = clientCreationsettings?.ServiceEndpoint ?? PublisherClient.DefaultEndpoint;
            var clients = new PublisherClient[clientCount];
            var shutdowns = new Func<Task>[clientCount];
            for (int i = 0; i < clientCount; i++)
            {
                var channel = new Channel(endpoint.Host, endpoint.Port, channelCredentials);
                clients[i] = PublisherClient.Create(channel, clientCreationsettings?.PublisherSettings);
                shutdowns[i] = channel.ShutdownAsync;
            }
            Func<Task> shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));
            return new HiPerfPublisherImpl(topicName, clients, settings, shutdown);
        }

        /// <summary>
        /// Create a <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>,
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> to publish messages to.</param>
        /// <param name="clients">The <see cref="PublisherClient"/>s to use in a <see cref="HiPerfPublisher"/>.
        /// For high performance, these should all use distinct <see cref="Channel"/>s.</param>
        /// <param name="settings">Optional. <see cref="Settings"/> for creating a <see cref="HiPerfPublisher"/>.</param>
        /// <returns>A <see cref="HiPerfPublisher"/> instance associated with the specified <see cref="TopicName"/>.</returns>
        public static HiPerfPublisher Create(TopicName topicName, IEnumerable<PublisherClient> clients, Settings settings = null) =>
            // No need to clone clients, it's synchronously used to initialise a Queue<T> in the constructor
            new HiPerfPublisherImpl(topicName, clients, settings?.Clone() ?? new Settings(), null);

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
        /// Shutdown this <see cref="HiPerfPublisher"/>. Cancelling <paramref name="hardStopToken"/> aborts the
        /// clean shutdown process, and may leave some locally queued messages unsent.
        /// The returned <see cref="Task"/> completes when all queued messages have been published.
        /// The returned <see cref="Task"/> cancels if the passed <see cref="CancellationToken"/> is cancelled.
        /// <see cref="Task"/> as quickly as possible.
        /// </summary>
        /// <param name="hardStopToken">Cancel this <see cref="CancellationToken"/> to abort publishing queued messages.</param>
        /// <returns>A <see cref="Task"/> that completes when all queued messages have been published; or cancels if the
        /// passed <see cref="CancellationToken"/> is cancelled.</returns>
        public virtual Task ShutdownAsync(CancellationToken hardStopToken) => throw new NotImplementedException();

        /// <summary>
        /// Shutdown this <see cref="HiPerfPublisher"/>. If the timeout expires, the clean shutdown process will
        /// abort; leaving some locally queued messages unsent.
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
        /// <param name="clients">The <see cref="PublisherClient"/>s to use.</param>
        /// <param name="settings"><see cref="HiPerfPublisher.Settings"/> to use in this <see cref="HiPerfPublisherImpl"/>.</param>
        /// <param name="shutdown">Function to call on publisher shutdown.</param>
        public HiPerfPublisherImpl(TopicName topicName, IEnumerable<PublisherClient> clients, Settings settings, Func<Task> shutdown)
            : this(topicName, clients, settings, shutdown, TaskHelper.Default) { }

        internal HiPerfPublisherImpl(TopicName topicName, IEnumerable<PublisherClient> clients, Settings settings, Func<Task> shutdown, TaskHelper taskHelper)
        {
            TopicName = GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            GaxPreconditions.CheckNotNull(clients, nameof(clients));
            _idleClients = new Queue<PublisherClient>(clients);
            GaxPreconditions.CheckArgument(_idleClients.Count > 0, nameof(clients), "Must contain at least one client");
            GaxPreconditions.CheckArgument(_idleClients.All(x => x != null), nameof(clients), "All elements must be non-null");
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            settings.Validate();
            _shutdown = shutdown;
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));

            // Initialise batching settings. Use ApiMax settings for components not given.
            var batchingSettings = settings.BatchingSettings ?? DefaultBatchingSettings;
            _batchElementCountThreshold = batchingSettings.ElementCountThreshold ?? ApiMaxBatchingSettings.ElementCountThreshold.Value;
            _batchRequestByteThreshold = batchingSettings.RequestByteThreshold ?? ApiMaxBatchingSettings.RequestByteThreshold.Value;
            _batchDelayThreshold = batchingSettings.DelayThreshold;
            _scheduler = settings.Scheduler ?? SystemScheduler.Instance;
            var maxBatchingSettings = settings.MaxBatchingSettings ?? ApiMaxBatchingSettings;
            _batchMaxElementCount = maxBatchingSettings.ElementCountThreshold ?? ApiMaxBatchingSettings.ElementCountThreshold.Value;
            _batchMaxByteCount = maxBatchingSettings.RequestByteThreshold ?? ApiMaxBatchingSettings.RequestByteThreshold.Value;

            // Initialise internal state
            _batchesReady = new Queue<Batch>();
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
        private readonly TimeSpan? _batchDelayThreshold;

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
            Task<IList<string>> batchTask;
            int index;
            int messageByteCount = message.CalculateSize();
            lock (_lock)
            {
                // Check for shutdown in the lock, to avoid a race-condition.
                CheckShutdown();
                // Update flow-control counts.
                _queueElementCount += 1;
                _queueByteCount += messageByteCount;
                // Queue the current batch if this message would cause the batch to go over-byte-size
                // (unless this would be the only message in the batch, then it's allowed).
                QueueCurrentBatchIfRequired(messageByteCount);
                if (_currentBatch == null)
                {
                    // Create a new batch if this is the first ever batch, or a batch has just been queued.
                    _currentBatch = new Batch();
                    DelaySendCurrentBatch();
                }
                batchTask = _currentBatch.BatchCompletion.Task;
                // Add message to current batch, and record the message index for later ID retrieval.
                index = _currentBatch.AddMessage(message, messageByteCount);
                // Queue the current batch if this message has caused the batch to be over-count or over-byte-size.
                QueueCurrentBatchIfRequired();
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
                if (_currentBatch != null)
                {
                    QueueCurrentBatch();
                }
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
                    lock (_lock)
                    {
                        foreach (var batch in _batchesReady)
                        {
                            batch.BatchCompletion.SetCanceled();
                        }
                    }
                }
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

        private void DelaySendCurrentBatch()
        {
            // Pre-condition: Must be locked
            if (_batchDelayThreshold is TimeSpan batchDelayThreshold)
            {
                // read cancellation token here, in case the current batch changes before the task below starts.
                var timerCancellationToken =
                    CancellationTokenSource.CreateLinkedTokenSource(_currentBatch.TimerCts.Token, _hardStopCts.Token).Token;
                // Ignore result of this Task. If it's cancelled, it's because the batch has already been sent.
                _taskHelper.Run(async () =>
                {
                    await _taskHelper.ConfigureAwait(_scheduler.Delay(batchDelayThreshold, timerCancellationToken));
                    // If batch has already moved to queue, timerToken will have been cancelled.
                    lock (_lock)
                    {
                        // Check for cancellation inside lock to avoid race-condition.
                        if (!timerCancellationToken.IsCancellationRequested)
                        {
                            // Force queuing of the current batch, whatever the size.
                            // There will always be at least one message in the batch.
                            QueueCurrentBatch();
                        }
                    }
                });
            }
        }

        private void QueueCurrentBatchIfRequired(int extraByteCount = 0)
        {
            // Pre-condition: Must be locked
            if (_currentBatch == null)
            {
                return;
            }
            // Current batch is full if either:
            // * The number of messages in the batch >= the maximum number of messages allowed; or
            // * The byte-count in the batch >= the maximum number of messages allowed.
            // Special cases:
            // * Before a message is queued, this method is called with the message byte-count;
            //   If this message would cause the batch to exceed the maxmium byte-count, then this
            //   batch is considered already full.
            // * But if that is the first message in the batch, then that one message only is allowed
            //   to make the batch go over its maximum allowed byte-count.
            // The maximum size depends on whether local queueing is occuring.
            // If _idleClients is empty, then all clients are currently sending, so local queueing is occuring;
            // which means the current batch cannot be sent, even if it is full.
            bool currentBatchIsFull = _idleClients.Count == 0 ?
            _currentBatch.Messages.Count >= _batchMaxElementCount ||
                (_currentBatch.Messages.Count > 0 && _currentBatch.ByteCount + extraByteCount >= _batchMaxByteCount) :
            _currentBatch.Messages.Count >= _batchElementCountThreshold ||
                (_currentBatch.Messages.Count > 0 && _currentBatch.ByteCount + extraByteCount >= _batchRequestByteThreshold);
            if (currentBatchIsFull)
            {
                QueueCurrentBatch();
            }
        }

        private void QueueCurrentBatch()
        {
            // Pre-condition: Must be locked
            // Cancel the timeout for this batch.
            _currentBatch.TimerCts.Cancel();
            // Queue the batch ready for sending.
            _batchesReady.Enqueue(_currentBatch);
            // Mark that there is no current batch.
            _currentBatch = null;
            // Trigger send to server.
            TriggerSend();
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
            var batch = _batchesReady.Dequeue();
            _batchesInFlightCount += 1;
            // Update flow-control counts.
            _queueElementCount -= batch.Messages.Count;
            _queueByteCount -= batch.ByteCount;

            async Task Send()
            {
                // Perform the RPC to server, catching exceptions.
                var publishTask = client.PublishAsync(TopicName, batch.Messages, CallSettings.FromCancellationToken(_hardStopCts.Token));
                var response = await _taskHelper.ConfigureAwaitHideErrors(publishTask, null);
                // Propagate task result to batch.
                switch (publishTask.Status)
                {
                    case TaskStatus.RanToCompletion:
                        batch.BatchCompletion.SetResult(response.MessageIds);
                        break;
                    case TaskStatus.Canceled:
                        batch.BatchCompletion.SetCanceled();
                        break;
                    case TaskStatus.Faulted:
                        batch.BatchCompletion.SetException(publishTask.Exception.InnerExceptions);
                        break;
                    default:
                        throw new InvalidOperationException("Invalid TaskStatus");
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
                        TriggerSend();
                    }
                    else
                    {
                        // If nothing queued to send, check to see if current batch is ready.
                        QueueCurrentBatchIfRequired();
                    }
                }
            }

            // Send the batch
            _taskHelper.Run(Send);
        }

    }
}
