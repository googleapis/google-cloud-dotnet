using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    // class name still to be decided, but can't be Subscriber
    public abstract class HiPerfSubscriber : IDisposable
    {
        private static TimeSpan DefaultStopTimeout = TimeSpan.FromSeconds(15);

        public enum AckReply
        {
            Nack = 0,
            Ack = 1,
        }

        // All entries will use defaults if null
        public sealed class Settings
        {
            Func<Channel> ChannelProvider { get; set; }
            SubscriberSettings SubscriberSettings { get; set; }
            FlowControlSettings FlowControlSettings { get; set; }
            TimeSpan? AckExtensionWindow { get; set; }
            TaskFactory TaskFactory { get; set; }
        }

        public static HiPerfSubscriber Create(SubscriptionName subscriptionName, Settings settings = null) =>
            new HiPerfSubscriberImpl(subscriptionName, settings ?? new Settings());

        public SubscriptionName SubscriptionName { get { throw new NotImplementedException(); } }

        // TODO: Should this accept a CancellationToken?
        public virtual Task StartAsync(Func<PubsubMessage, Task<AckReply>> handler)
        {
            throw new NotImplementedException();
        }

        public virtual void Start(Func<PubsubMessage, AckReply> handler) =>
            StartAsync(msg => Task.FromResult(handler(msg))).WaitWithUnwrappedExceptions();

        public virtual Task<IEnumerable<string>> StopAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<string> Stop(TimeSpan? timeout = null)
        {
            var cancellationToken = new CancellationTokenSource(timeout ?? DefaultStopTimeout).Token;
            return StopAsync(cancellationToken).ResultWithUnwrappedExceptions();
        }

        public virtual void Dispose() => Stop();
    }

    public sealed class HiPerfSubscriberImpl : HiPerfSubscriber
    {
        public HiPerfSubscriberImpl(SubscriptionName subscriptionName, Settings settings)
        {
            // TODO
        }

        // TODO: Implementation
    }
}
