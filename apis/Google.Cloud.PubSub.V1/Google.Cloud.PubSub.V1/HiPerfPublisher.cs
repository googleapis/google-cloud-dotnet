using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Func<Channel> ChannelProvider { get; set; }

            /// <summary>
            /// <see cref="PublisherSettings"/> used when creating <see cref="PublisherClient"/>
            /// instances.
            /// If <c>null</c>, uses default settings from <see cref="PublisherSettings.GetDefault"/>.
            /// </summary>
            PublisherSettings PublisherSettings { get; set; }

            /// <summary>
            /// Batch settings.
            /// If <c>null</c>, uses batch settings from <see cref="DefaultBatchingSettings"/>. 
            /// </summary>
            BatchingSettings BatchSettings { get; set; }

            /// <summary>
            /// Flow control settings.
            /// If <c>null</c>, uses flow control settings from <see cref="DefaultFlowControlSettings"/>. 
            /// </summary>
            FlowControlSettings FlowControlSettings { get; set; }
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
        public static HiPerfPublisher Create(TopicName topicName, Settings settings = null) =>
            new HiPerfPublisherImpl(topicName, settings ?? new Settings());

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
        public Task<string> PublishAsync(PubsubMessage message)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Implementation of <see cref="HiPerfPublisher"/>. 
    /// </summary>
    public sealed class HiPerfPublisherImpl : HiPerfPublisher
    {
        /// <summary>
        /// TODO...
        /// </summary>
        /// <param name="topicName"></param>
        /// <param name="settings"></param>
        public HiPerfPublisherImpl(TopicName topicName, Settings settings)
        {
            // TODO
        }

        // TODO: Implmentation
    }

}
