using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    // class name still to be decided, but can't be Publisher
    public abstract class HiPerfPublisher
    {
        // All entries will use defaults if null
        public sealed class Settings
        {
            Func<Channel> ChannelProvider { get; set; }
            PublisherSettings PublisherSettings { get; set; }
            BatchingSettings BatchSettings { get; set; }
            FlowControlSettings FlowControlSettings { get; set; }
        }

        public static HiPerfPublisher Create(TopicName topicName, Settings settings = null) =>
            new HiPerfPublisherImpl(topicName, settings ?? new Settings());

        public virtual TopicName TopicName { get { throw new NotImplementedException(); } }

        public Task<string> Publish(PubsubMessage message)
        {
            throw new NotImplementedException();
        }
    }

    public sealed class HiPerfPublisherImpl : HiPerfPublisher
    {
        public HiPerfPublisherImpl(TopicName topicName, Settings settings)
        {
            // TODO
        }

        // TODO: Implmentation
    }

}
