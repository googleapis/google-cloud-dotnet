using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.PubSub.V1.Tasks;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections;
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
    /// <para>To receive messages, The <see cref="Start(Func{PubsubMessage, Reply})"/>  or
    /// <see cref="StartAsync(Func{PubsubMessage, Task{Reply}}, CancellationToken)"/> method must be called,
    /// with a suitable message handler.</para>
    /// <para>This message handler <see cref="Reply"/> states whether to acknowledge the message;
    /// if acknowledged then it will not be received on this subscription again.</para>
    /// </remarks>
    public abstract class HiPerfSubscriber : IDisposable
    {
        private static TimeSpan DefaultStopTimeout = TimeSpan.FromSeconds(15);

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
            public Func<Channel> ChannelProvider { get; set; }

            /// <summary>
            /// <see cref="SubscriberSettings"/> used when creating <see cref="SubscriberClient"/>
            /// instances.
            /// If <c>null</c>, uses default settings from <see cref="SubscriberSettings.GetDefault"/>.
            /// </summary>
            public SubscriberSettings SubscriberSettings { get; set; }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            public FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// Duration before message expiration.
            /// If <c>null</c>, uses the default of TODO seconds.
            /// </summary>
            public TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// A custom <see cref="TaskFactory"/> used to execute message handlers.
            /// If <c>null</c>, the system default <see cref="Task.Factory"/> is used. 
            /// </summary>
            public TaskFactory TaskFactory { get; set; }

            public IScheduler Scheduler { get; set; }
        }

        /// <summary>
        /// Default <see cref="FlowControlSettings"/> for <see cref="HiPerfSubscriber"/>.  
        /// </summary>
        /// <returns>Default <see cref="FlowControlSettings"/> for <see cref="HiPerfSubscriber"/>.</returns>
        public static FlowControlSettings DefaultFlowControlSettings() => new FlowControlSettings
        {
            // TODO
        };

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

        // TODO: Currently receives messages using a callback function (sync or async).
        //       We should also consider events, Rx, ...

        /// <summary>
        /// Start receiving messages, using the specified handler.
        /// The message receiver is fully operational once the returned <see cref="Task"/> has completed. 
        /// </summary>
        /// <param name="handler">The handler function for each message.
        /// This handler function must return a task, that once complete specifies whether to
        /// <see cref="Reply.Ack"/> or <see cref="Reply.Nack"/> the handled messages.
        /// If the task fails or the handler throws an exception, then the message will be
        /// <see cref="Reply.Nack"/>ed.</param>
        /// <param name="cancellationToken">Used to abort this operation.
        /// If cancelled, this resets this <see cref="HiPerfSubscriber"/> back to a fully
        /// stopped state, and the task returned will be faulted.</param>
        /// <returns>A task which completes once the message receiver is fully operational.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this <see cref="HiPerfSubscriber"/> has already been started.</exception>
        public virtual Task StartAsync(Func<PubsubMessage, Task<Reply>> handler, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start receiving messages, using the specified handler.
        /// </summary>
        /// <param name="handler">The handler function for each message.
        /// This handler function must return a value that specifies whether to
        /// <see cref="Reply.Ack"/> or <see cref="Reply.Nack"/> the handled messages.
        /// If the handler throws an exception then the message will be <see cref="Reply.Nack"/>ed.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this <see cref="HiPerfSubscriber"/> has already been started.</exception>
        public virtual void Start(Func<PubsubMessage, Reply> handler) =>
            StartAsync(msg => Task.FromResult(handler(msg))).WaitWithUnwrappedExceptions();

        /// <summary>
        /// Stop receiving messages.
        /// </summary>
        /// <remarks>
        /// Will wait for all messages already received to be handled, unless cancelled by the
        /// <paramref name="cancellationToken"/>. If all messages already received are not handled
        /// due to cancellation, then the message IDs of all unhandled messages will be returned.
        /// </remarks>
        /// <param name="cancellationToken">Used to abort handling of all messages already received.</param>
        /// <returns>Message IDs of all received but unhandled messages. If the Stop operation is not cancelled
        /// then no message IDs will be returned, as all will have been handled.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this <see cref="HiPerfSubscriber"/> is not currently started.</exception>
        public virtual Task<IEnumerable<string>> StopAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stop receiving mesages, with an optional timeout on handling messages already received.
        /// </summary>
        /// <param name="timeout">Time to wait to handle messages already received.
        /// If <c>null</c>, uses the default of 15 seconds.</param>
        /// <returns>Message IDs of all received but unhandled messages.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this <see cref="HiPerfSubscriber"/> is not currently started.</exception>
        public virtual IEnumerable<string> Stop(TimeSpan? timeout = null)
        {
            var cancellationToken = new CancellationTokenSource(timeout ?? DefaultStopTimeout).Token;
            return StopAsync(cancellationToken).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// <see cref="Stop(TimeSpan?)"/> receiving messages using the default timeout, and dispose of this <see cref="HiPerfSubscriber"/>.
        /// </summary>
        public virtual void Dispose() => Stop();
    }

    /// <summary>
    /// Implementation of <see cref="HiPerfSubscriber"/>. 
    /// </summary>
    public sealed class HiPerfSubscriberImpl : HiPerfSubscriber
    {
        private class SubscriberState
        {
            private SubscriberClient _client;

            private Queue<string> _queuedAckIds;
            private Queue<string> _queuedExtensionIds;
        }

        public HiPerfSubscriberImpl(SubscriptionName subscriptionName, Settings settings)
        {
        }

        internal HiPerfSubscriberImpl(SubscriptionName subscriptionName, Func<Task<SubscriberClient>> clientProvider, Settings settings, TaskHelper taskHelper)
        {
            _subscriptionName = subscriptionName;
            _scheduler = settings.Scheduler;
            _taskHelper = taskHelper;
            _clientProvider = clientProvider;
        }

        private readonly object _lock = new object();
        private readonly SubscriptionName _subscriptionName;
        private readonly IScheduler _scheduler;
        private readonly TaskHelper _taskHelper;
        private readonly Func<Task<SubscriberClient>> _clientProvider;
        private readonly int _clientCount;

        // Flow-control settings
        private readonly int _flowMaxOutstandingElementCount;
        private readonly int _flowMaxOutstandingRequestBytes;
        private readonly LimitExceededBehavior _flowLimitExceededBehavior;

        private IReadOnlyList<Task> _clientTasks;
        private CancellationTokenSource _runCts;
        //private int _unhandledMessages;
        private long _flowElementCount;
        private long _flowByteCount;

        public override Task StartAsync(Func<PubsubMessage, Task<Reply>> handler, CancellationToken cancellationToken = default(CancellationToken))
        {
            var startupTasks = new Task[_clientCount];
            lock (_lock)
            {
                if (_runCts != null)
                {
                    throw new Exception("Already started");
                }
                _flowElementCount = 0;
                _flowByteCount = 0;
                _runCts = new CancellationTokenSource();
                var clientTasks = new Task[_clientCount];
                for (int i = 0; i < _clientCount; i++)
                {
                    var startupTcs = new TaskCompletionSource<int>();
                    clientTasks[i] = RunOneClient(handler, startupTcs);
                    startupTasks[i] = startupTcs.Task;
                }
                _clientTasks = clientTasks;
            }
            return Task.WhenAll(startupTasks);
        }

        public override Task<IEnumerable<string>> StopAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            lock (_lock)
            {
                if (_runCts == null)
                {
                    throw new Exception("Not running can't stop");
                }
                _runCts.Cancel();
                _runCts = null;
            }
        }

        private async Task RunOneClient(Func<PubsubMessage, Task<Reply>> handler, TaskCompletionSource<int> startupTcs)
        {
            // Acks and deadline-extensions are required to use the same channel as received the message 
            SubscriberClient sub = null;
            while (true)
            {
                if (sub == null)
                {
                    sub = await _taskHelper.ConfigureAwait(_clientProvider());
                }
                var pull = sub.StreamingPull(streamingSettings: new BidirectionalStreamingSettings(1));
                // Start streaming
                await _taskHelper.ConfigureAwait(pull.WriteAsync(new StreamingPullRequest
                {
                    StreamAckDeadlineSeconds = 600, // TODO
                    SubscriptionAsSubscriptionName = _subscriptionName
                }));
                // Mark subscriber as operational, if not already done
                if (startupTcs != null)
                {
                    startupTcs.SetResult(0);
                    startupTcs = null;
                }
                // Start responding to received messages
                var ackQueue = new AsyncBlockingQueue<string>(_taskHelper);
                var extendQueue = new AsyncBlockingQueue<string>(_taskHelper);
                Task receiveTask = ReceiveMessages(pull.ResponseStream, handler, extendQueue);
                Task ackExtendTask = AckExtendMessages(sub, ackQueue, extendQueue);
            }
        }

        private class MessageSet
        {
            public HashSet<string> Ids { get; }
        }

        private async Task ReceiveMessages(IAsyncEnumerator<StreamingPullResponse> stream, Func<PubsubMessage, Task<Reply>> handler, AsyncBlockingQueue<string> extendQueue, CancellationToken ct)
        {
            while (await _taskHelper.ConfigureAwait(stream.MoveNext(ct)))
            {
                var messages = stream.Current.ReceivedMessages;
                // Prepare deadline-extension timers for all messages
                var idSet = new HashSet<string>(messages.Select(x => x.AckId));
                ExtendAfterDelay(idSet, extendQueue, ct);
                foreach (var message in messages)
                {
                    Task unusedExtendTask = ExtendAfterDelay(message.AckId, null, ct);
                }
                foreach (var message in messages)
                {
                    var messageByteCount = message.Message.CalculateSize();
                    lock (_lock)
                    {
                        _flowElementCount += 1;
                        _flowByteCount += messageByteCount;
                    }
                    Task task = _taskHelper.Run(async () =>
                    {
                        var reply = await _taskHelper.ConfigureAwait(handler(message.Message));
                        lock (_lock)
                        {
                            _flowElementCount -= 1;
                            _flowByteCount -= messageByteCount;
                        }
                    });
                }
            }
        }

        private async Task AckExtendMessages(SubscriberClient.StreamingPullStream pull, AsyncBlockingQueue<string> ackQueue, AsyncBlockingQueue<string> extendQueue, CancellationToken ct)
        {
            while (true)
            {
                ct.ThrowIfCancellationRequested();
                await _taskHelper.ConfigureAwait(Task.WhenAny(ackQueue.WaitAsync(ct), extendQueue.WaitAsync(ct)));
                ct.ThrowIfCancellationRequested();
                var extend = extendQueue.Dequeue(1000);
                var ack = ackQueue.Dequeue(1000 - extend.Count);
                if (extend.Count > 0 || ack.Count > 0)
                {
                    await pull.WriteAsync(new StreamingPullRequest {
                        ModifyDeadlineAckIds = { extend },
                        ModifyDeadlineSeconds = { Enumerable.Repeat(600, extend.Count) }, // TODO: extend time
                        AckIds = { ack },
                    });
                }
            }
        }

        private async Task ExtendAfterDelay(string messageId, AsyncBlockingQueue<string> extendQueue, CancellationToken ct)
        {
            while (true)
            {
                await _scheduler.Delay(TimeSpan.FromSeconds(600 - 10), ct); // TODO: Timeout
                extendQueue.Enqueue(messageId);
            }
        }
    }
}
