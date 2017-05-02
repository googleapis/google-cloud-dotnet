using Google.Api.Gax;
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
    // TODO: Class name still to be decided, but can't be Publisher
    /// <summary>
    /// A PubSub publisher that is associated with a specific <see cref="TopicName"/>.
    /// </summary>
    public abstract class HiPerfPublisher
    {
        /// <summary>
        /// Settings for <see cref="HiPerfPublisher"/>.
        /// Defaults will be used for <c>null</c> properties.
        /// </summary>
        public sealed class Settings
        {
            /// <summary>
            /// Used to create new channels.
            /// If <c>null</c>, creates channels using the default PubSub endpoint
            /// and default credentials.
            /// </summary>
            public Func<Channel> ChannelProvider { get; set; }

            /// <summary>
            /// <see cref="PublisherSettings"/> used when creating <see cref="PublisherClient"/>
            /// instances.
            /// If <c>null</c>, uses default settings from <see cref="PublisherSettings.GetDefault"/>.
            /// </summary>
            public PublisherSettings PublisherSettings { get; set; }

            /// <summary>
            /// Batch settings.
            /// If <c>null</c>, uses batch settings from <see cref="DefaultBatchingSettings"/>. 
            /// </summary>
            public BatchingSettings BatchingSettings { get; set; }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            public IScheduler Scheduler { get; set; }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="HiPerfPublisher"/>.  
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="HiPerfPublisher"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings() => new FlowControlSettings
        {
            // TODO
        };

        /// <summary>
        /// Default <see cref="BatchingSettings"/> for <see cref="HiPerfPublisher"/>.  
        /// </summary>
        /// <returns>Default <see cref="BatchingSettings"/> for <see cref="HiPerfPublisher"/>.</returns>
        public static BatchingSettings DefaultBatchingSettings() => new BatchingSettings
        {
            // TODO
        };

        /// <summary>
        /// Create a <see cref="HiPerfPublisher"/> associated with the specified <see cref="TopicName"/>.
        /// </summary>
        /// <param name="topicName">The <see cref="TopicName"/> with which to publish messages.</param>
        /// <param name="settings">Optional <see cref="Settings"/> for this instance.</param>
        /// <returns>A <see cref="HiPerfPublisher"/> associated with the specified <see cref="TopicName"/>.</returns>
        public static async Task<HiPerfPublisher> CreateAsync(TopicName topicName, Settings settings = null)
        {
            var channelProvider = settings?.ChannelProvider ?? await DefaultChannelProvider().ConfigureAwait(false);
            // TODO: What's the correct way to decide channelCount. Should it be user-settable?
            // It probably won't be CPU-throttled, so using ProcessorCount seems wrong.
            var channelCount = Environment.ProcessorCount;
            var channels = Enumerable.Range(0, channelCount).Select(_ => settings.ChannelProvider());
            return new HiPerfPublisherImpl(topicName, channels, settings ?? new Settings());
        }

        private static async Task<Func<Channel>> DefaultChannelProvider()
        {
            var ep = PublisherClient.DefaultEndpoint;
            var credentials = await Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            if (credentials.IsCreateScopedRequired)
            {
                credentials = credentials.CreateScoped(PublisherClient.DefaultScopes);
            }
            var grpcCredentials = credentials.ToChannelCredentials();
            return () => new Channel(ep.Host, ep.Port, grpcCredentials);
        }

        /// <summary>
        /// The associated <see cref="TopicName"/>. 
        /// </summary>
        public virtual TopicName TopicName { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Publish a message to the topic specified in <see cref="TopicName"/>.
        /// </summary>
        /// <param name="message">The <see cref="PubsubMessage"/> to publish.</param>
        /// <returns>A task which completes once the message has been published.
        /// The task <see cref="Task{String}.Result"/> contains the message ID.</returns>
        public virtual Task<string> PublishAsync(PubsubMessage message)
        {
            throw new NotImplementedException();
        }

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

        /// <summary>
        /// Construct a <see cref="HiPerfPublisherImpl"/>. 
        /// </summary>
        /// <param name="topicName">The topic name for all puplished messages.</param>
        /// <param name="channels">The channels to use for publishing messages.</param>
        /// <param name="settings">Settings; must not be <c>null</c>.</param>
        public HiPerfPublisherImpl(TopicName topicName, IEnumerable<Channel> channels, Settings settings) :
            this(topicName, channels.Select(channel => PublisherClient.Create(channel, settings.PublisherSettings)), settings, TaskHelper.Default)
        {
        }

        internal HiPerfPublisherImpl(TopicName topicName, IEnumerable<PublisherClient> clients, Settings settings, TaskHelper taskHelper,
            long batchMaxElementCount = 1000, long batchMaxByteCount = 10 * 1024 * 1024)
        {
            TopicName = GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            GaxPreconditions.CheckNotNull(settings, nameof(settings));
            _taskHelper = GaxPreconditions.CheckNotNull(taskHelper, nameof(taskHelper));

            // TODO: Validate all settings and provide defaults
            _scheduler = settings.Scheduler;
            _flowMaxOutstandingElementCount = settings.FlowControlSettings.MaxOutstandingElementCount.Value;
            _flowMaxOutstandingRequestBytes = settings.FlowControlSettings.MaxOutstandingRequestBytes.Value;
            _flowLimitExceededBehavior = settings.FlowControlSettings.LimitExceededBehavior;
            _batchElementCountThreshold = settings.BatchingSettings.ElementCountThreshold.Value;
            _batchRequestByteThreshold = settings.BatchingSettings.RequestByteThreshold.Value;
            _batchDelayThreshold = settings.BatchingSettings.DelayThreshold.Value;
            _batchMaxElementCount = batchMaxElementCount;
            _batchMaxByteCount = batchMaxByteCount;

            // Initialise internal state
            _idleClients = new Queue<PublisherClient>(clients);
            _batchesReady = new Queue<Batch>();
        }

        private readonly object _lock = new object();
        private TaskCompletionSource<int> _flowBlock;
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;

        // Flow-control settings
        private readonly int _flowMaxOutstandingElementCount;
        private readonly int _flowMaxOutstandingRequestBytes;
        private readonly LimitExceededBehavior _flowLimitExceededBehavior;

        // Batching settings
        private readonly long _batchElementCountThreshold;
        private readonly long _batchRequestByteThreshold;
        private readonly TimeSpan _batchDelayThreshold;

        private readonly long _batchMaxElementCount;
        private readonly long _batchMaxByteCount;

        //Internal state
        private readonly Queue<PublisherClient> _idleClients;
        private readonly Queue<Batch> _batchesReady;
        private Batch _currentBatch;
        private long _queueElementCount;
        private long _queueByteCount;

        /// <inheritdoc/>
        public override TopicName TopicName { get; }

        /// <inheritdoc/>
        public override Task<string> PublishAsync(PubsubMessage message)
        {
            int messageByteCount = message.CalculateSize();
            Task flowBlockTask;
            while (true)
            {
                flowBlockTask = null;
                lock (_lock)
                {
                    // Allow message of greater size than allowed by flow-control, if it's the only message 
                    if (_queueElementCount >= _flowMaxOutstandingElementCount ||
                        (_queueElementCount > 0 && _queueByteCount + messageByteCount > _flowMaxOutstandingRequestBytes))
                    {
                        switch (_flowLimitExceededBehavior)
                        {
                            case LimitExceededBehavior.Block:
                                // Need to block, create the blocking Task if another thread hasn't already done so.
                                if (_flowBlock == null)
                                {
                                    _flowBlock = new TaskCompletionSource<int>();
                                }
                                flowBlockTask = _flowBlock.Task;
                                break;
                            case LimitExceededBehavior.ThrowException:
                                throw new FlowLimitExceededException();
                            case LimitExceededBehavior.Ignore:
                                break;
                            default:
                                throw new InvalidOperationException($"Unexpected LimitExceededBehavior: '{_flowLimitExceededBehavior}'");
                        }
                    }
                    if (flowBlockTask == null)
                    {
                        // Not blocking, so increment flow-control queue counts.
                        // Done before lock is released, to ensure other threads correctly honour flow-control.
                        _queueElementCount += 1;
                        _queueByteCount += messageByteCount;
                        break;
                    }
                }
                if (flowBlockTask != null)
                {
                    // If blocking, then wait for the blocking Task to complete.
                    // This will complete when messages are removed from the queue for sending.
                    _taskHelper.Wait(flowBlockTask);
                }
            };
            return PublishAsyncPostFlow(message, messageByteCount);
        }

        private async Task<string> PublishAsyncPostFlow(PubsubMessage message, int messageByteCount)
        {
            Task<IList<string>> batchTask;
            int index;
            lock (_lock)
            {
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
            var ids = await _taskHelper.ConfigureAwait(batchTask);
            // Return the message ID sent from the server.
            return ids[index];
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
            if (force || (_currentBatch != null && CurrentBatchIsFull(_idleClients.Count == 0, extraByteCount)))
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
                // Update flow-control counts.
                _queueElementCount -= batch.Messages.Count;
                _queueByteCount -= batch.ByteCount;
                // If any threads are flow-control blocking, complete the blocking Task.
                if (_flowBlock != null)
                {
                    _flowBlock.SetResult(0);
                    _flowBlock = null;
                }
                // Perform the RPC to server, catching exceptions.
                try
                {
                    var response = await _taskHelper.ConfigureAwait(client.PublishAsync(TopicName, batch.Messages));
                    batch.BatchCompletion.SetResult(response.MessageIds);
                }
                catch (Exception e)
                {
                    batch.BatchCompletion.SetException(e);
                }
                // A client is now idle. Record it, and see if a further batch is ready to send.
                lock (_lock)
                {
                    _idleClients.Enqueue(client);
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
