using Google.Api.Gax;
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
    /// <para>To receive messages, The <see cref="Start(Func{PubsubMessage, Reply})"/>  or
    /// <see cref="StartAsync(Func{PubsubMessage, Task{Reply}})"/> method must be called,
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
            Func<Channel> ChannelProvider { get; set; }

            /// <summary>
            /// <see cref="SubscriberSettings"/> used when creating <see cref="SubscriberClient"/>
            /// instances.
            /// If <c>null</c>, uses default settings from <see cref="SubscriberSettings.GetDefault"/>.
            /// </summary>
            SubscriberSettings SubscriberSettings { get; set; }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            FlowControlSettings FlowControlSettings { get; set; }

            /// <summary>
            /// Duration before message expiration.
            /// If <c>null</c>, uses the default of TODO seconds.
            /// </summary>
            TimeSpan? AckExtensionWindow { get; set; }

            /// <summary>
            /// A custom <see cref="TaskFactory"/> used to execute message handlers.
            /// If <c>null</c>, the system default <see cref="Task.Factory"/> is used. 
            /// </summary>
            TaskFactory TaskFactory { get; set; }
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
        /// <summary>
        /// TODO...
        /// </summary>
        /// <param name="subscriptionName"></param>
        /// <param name="settings"></param>
        public HiPerfSubscriberImpl(SubscriptionName subscriptionName, Settings settings)
        {
            // TODO
        }

        // TODO: Implementation
    }
}
