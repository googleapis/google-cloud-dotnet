// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Api.Gax;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using static Google.Pubsub.V1.PublisherClient;

namespace Google.Pubsub.V1
{
    /// <summary>
    /// A topic within a project, with methods to make publishing messages simpler than with the full API.
    /// </summary>
    public sealed class SimpleTopic
    {
        /// <summary>
        /// The ID of the project this subscription is part of.
        /// </summary>        
        public string ProjectId => Parent.ProjectId;

        /// <summary>
        /// The topic ID within the project.
        /// </summary>
        public string TopicId { get; }

        /// <summary>
        /// The full resource name of this topic, including project ID.
        /// </summary>
        public string ResourceName { get; }

        /// <summary>
        /// The parent object of this subscription.
        /// </summary>
        public SimplePubsub Parent { get; }

        /// <summary>
        /// Constructs an instance with the given parent, for the given subscription ID which is expected to
        /// subscribed to the given topic ID in the same parent project.
        /// </summary>
        /// <remarks>
        /// This constructor does not validate that the subscription exists, or that it is actually subscribed to
        /// the given topic.
        /// </remarks>
        /// <param name="parent">The parent object, usually used to create the new instance. Must not be null.</param>
        /// <param name="topicId">The ID of the topic within the parent project. Must not be null.</param>
        public SimpleTopic(SimplePubsub parent, string topicId)
        {
            Parent = GaxPreconditions.CheckNotNull(parent, nameof(parent));
            TopicId = topicId;
            ResourceName = GetTopicName(parent.ProjectId, topicId);
        }

        /// <summary>
        /// Retrieves or creates a subscription to this topic.
        /// </summary>
        /// <remarks>
        /// This is a convenient shortcut for calling <see cref="SimplePubsub.GetOrCreateSubscription(string, string, TimeSpan?)"/>. See the documentation
        /// of that method for more details.
        /// </remarks>
        /// <param name="subscriptionId">The subscription ID to fetch or create. Must not be null.</param>
        /// <param name="ackDeadline">The deadline for clients to acknowledge pulled messages before they may be pulled again.</param>
        /// <exception cref="ResourceMismatchException">The specified subscription exists, but for a different topic.</exception>
        /// <returns>The subscription identified by <paramref name="subscriptionId"/>.</returns>
        public SimpleSubscription GetOrCreateSubscription(string subscriptionId, TimeSpan? ackDeadline = null) =>
            Parent.GetOrCreateSubscription(GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId)), TopicId, ackDeadline);

        /// <summary>
        /// Asynchronously retrieves or creates a subscription to this topic.
        /// </summary>
        /// <remarks>
        /// This is a convenient shortcut for calling <see cref="SimplePubsub.GetOrCreateSubscriptionAsync(string, string, TimeSpan?, CancellationToken)"/>. See the documentation
        /// of that method for more details.
        /// </remarks>
        /// <param name="subscriptionId">The subscription ID to fetch or create. Must not be null.</param>
        /// <param name="ackDeadline">The deadline for clients to acknowledge pulled messages before they may be pulled again.</param>
        /// <exception cref="ResourceMismatchException">The specified subscription exists, but for a different topic.</exception>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task is the subscription identified by <paramref name="subscriptionId"/>.</returns>
        public Task<SimpleSubscription> GetOrCreateSubscriptionAsync(string subscriptionId, TimeSpan? ackDeadline = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            Parent.GetOrCreateSubscriptionAsync(GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId)), TopicId, ackDeadline, cancellationToken);

        /// <summary>
        /// Publishes a given Protobuf message to the topic, with optional attributes.
        /// </summary>
        /// <param name="message">The message to publish. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>The message ID of the published message</returns>
        public string Publish(IMessage message, IDictionary<string, string> attributes = null) =>
            Publish(GaxPreconditions.CheckNotNull(message, nameof(message)).ToByteString(), attributes);

        /// <summary>
        /// Publishes a given text message to the topic by encoding it as UTF-8, with optional attributes.
        /// </summary>
        /// <param name="messageText">The text of the message to publish. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>The message ID of the published message</returns>
        public string Publish(string messageText, IDictionary<string, string> attributes = null) =>
            Publish(ByteString.CopyFromUtf8(GaxPreconditions.CheckNotNull(messageText, nameof(messageText))), attributes);

        /// <summary>
        /// Publishes a message containing the given <see cref="ByteString"/> data, with optional attributes.
        /// </summary>
        /// <param name="data">The bytestring containing the data to publish in the message. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>The message ID of the published message</returns>
        public string Publish(ByteString data, IDictionary<string, string> attributes = null)
        {
            GaxPreconditions.CheckNotNull(data, nameof(data));
            var message = new PubsubMessage { Data = data };
            if (attributes != null)
            {
                message.Attributes.Add(attributes);
            }
            var response = Parent.Publisher.Publish(ResourceName, new[] { message });
            return response.MessageIds[0];
        }

        /// <summary>
        /// Asynchronously publishes a given Protobuf message to the topic, with optional attributes.
        /// </summary>
        /// <param name="message">The message to publish. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// message ID of the published message.</returns>
        public Task<string> PublishAsync(IMessage message, IDictionary<string, string> attributes = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PublishAsync(GaxPreconditions.CheckNotNull(message, nameof(message)).ToByteString(), attributes, cancellationToken);

        /// <summary>
        /// Asynchronously publishes a given text message to the topic by encoding it as UTF-8, with optional attributes.
        /// </summary>
        /// <param name="messageText">The text of the message to publish. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// message ID of the published message.</returns>
        public Task<string> PublishAsync(string messageText, IDictionary<string, string> attributes = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PublishAsync(ByteString.CopyFromUtf8(GaxPreconditions.CheckNotNull(messageText, nameof(messageText))), attributes, cancellationToken);

        /// <summary>
        /// Asynchronously publishes a message containing the given <see cref="ByteString"/> data, with optional attributes.
        /// </summary>
        /// <param name="data">The bytestring containing the data to publish in the message. Must not be null.</param>
        /// <param name="attributes">The key/value dictionary of attributes to attach to the message.
        /// May be null, in which case no attributes are added.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// message ID of the published message.</returns>
        public async Task<string> PublishAsync(ByteString data, IDictionary<string, string> attributes = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(data, nameof(data));
            var message = new PubsubMessage { Data = data };
            if (attributes != null)
            {
                message.Attributes.Add(attributes);
            }
            var response = await Parent.Publisher.PublishAsync(ResourceName, new[] { message }, cancellationToken);
            return response.MessageIds[0];
        }
    }
}
