// Copyright 2023 Google LLC
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
using Microsoft.Extensions.Logging;
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

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// Implementation of PubSub publisher that is associated with a specific <see cref="TopicName"/>.
/// </summary>
public sealed class PublisherClientImpl : PublisherClient
{
    private const string CompressionHeaderKey = "grpc-internal-encoding-request";
    private const string CompressionHeaderValue = "gzip";

    private static readonly CallSettings s_compressionCallSettings = CallSettings.FromHeader(CompressionHeaderKey, CompressionHeaderValue);

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

    private readonly struct ReadyBatch
    {
        public ReadyBatch(KeyState state, Batch batch)
        {
            State = state;
            Batch = batch;
        }
        public KeyState State { get; }
        public Batch Batch { get; }
    }

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
        _disposeTimeout = settings.DisposeTimeout ?? DefaultDisposeTimeout;
        _enableCompression = settings.EnableCompression;
        _compressionBytesThreshold = settings.CompressionBytesThreshold ?? DefaultCompressionBytesThreshold;
        _logger = settings.Logger;

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
    private readonly TimeSpan _disposeTimeout;
    private readonly bool _enableCompression;
    private readonly long _compressionBytesThreshold;

    private readonly ILogger _logger;

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

    /// <summary>
    /// The number of ordering keys that are being currently tracked by the publisher,
    /// which may include the empty string ordering key used for unordered messages.
    /// For testing purposes only.
    /// </summary>
    internal int PendingKeysCount
    {
        get
        {
            lock(_lock)
            {
                return _keyedState.Count;
            }
        }
    }

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
    public override ValueTask DisposeAsync() => new ValueTask(ShutdownAsync(_disposeTimeout));

    /// <inheritdoc/>
    public override Task ShutdownAsync(CancellationToken hardStopToken)
    {
        lock (_lock)
        {
            // If we come here for a second or subsequent time, this condition would always be true.
            // Note: If multiple shutdown requests are made, only the first cancellation token is observed.
            if (_softStopCts.IsCancellationRequested)
            {
                // No-op. We don't want to throw exceptions if DisposeAsync or ShutdownAsync is called a second time.
                return _shutdownTcs.Task;
            }

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
            var callSettings = CallSettings.FromCancellationToken(_hardStopCts.Token);

            // If compression is enabled, and the batch size is greater than or equal to the threshold, set the compression header.
            if (_enableCompression && batch.ByteCount >= _compressionBytesThreshold)
            {
                callSettings = callSettings.MergedWith(s_compressionCallSettings);
            }

            // Perform the RPC to server, catching exceptions.
            var publishTask = client.PublishAsync(TopicName, batch.Messages, callSettings);
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
                                _logger?.LogWarning(publishTask.Exception, "Recoverable error when publishing; will retry this batch.");
                                // Rebatch failed messages.
                                batches.AddLast(batch);
                                postLockAction = () => { };
                            }
                            else
                            {
                                _logger?.LogWarning(publishTask.Exception, "Unrecoverable error when publishing. Failing all current batches with the same ordering key.");
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
                            _logger?.LogWarning(publishTask.Exception, "Unrecoverable error when publishing without ordering key. Failing the current batch.");
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

                // For ordered messages we store the state on a dictionary by the ordering key.
                // Ordering keys are usually short lived, so we remove states from the dictionary that have no pending messages,
                // to avoid unbounded memory consumption.
                // If messages for a removed key are published again, the key and its state will be added back to the dictionary,
                // as if it were a new key.
                // Note that if unordered messages have been sent the state dictionary will forever contain the entry with empty string as a key.
                if (state.HasOrderingKey && state.State == OrderingKeyState.Normal && batches.Count == 0)
                {
                    _keyedState.Remove(state.OrderingKey);
                }
            }
            postLockAction();
        }
    }
}
