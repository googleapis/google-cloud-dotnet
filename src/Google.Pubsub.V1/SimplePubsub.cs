// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using static Google.Pubsub.V1.PublisherClient;
using static Google.Pubsub.V1.SubscriberClient;

// TODOs for this, SimpleSubscription and SimpleTopic:
// - Naming (the "simple" prefix isn't great)
// - Consider cancellation for synchronous methods (already in PullAndAcknowledge and Poll)
// - More tests
// - Validate PullAndAcknowledge behaviour; should that take an action?
// - Validate that using the IDs instead of resource names is useful
// - Convert demo code to use it

namespace Google.Pubsub.V1
{
    /// <summary>
    /// Simplified wrapper around the Google Pubsub API.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class composes the publisher and subscriber clients, as well as having an associated project ID.
    /// Whereas the full API uses resource names such as <c>projects/my-project/subscriptions/my-subscription</c>,
    /// the simplified API uses the same project ID for all resources, and constructs resource names from that
    /// project ID and topic or subscription IDs. The full resource names are available via
    /// <see cref="SimpleSubscription.ResourceName"/> and <see cref="SimpleTopic.ResourceName"/> to allow simple
    /// interoperability between the simplified API and the full API.
    /// </para>
    /// <para>
    /// While the simplified API is particularly useful in cases where the subscriptions and topics belong to the same
    /// project, it can still be used in scenarios where they're in different projects. The subscription would have to be
    /// created with the full API, but can then be retrieved using <see cref="GetSubscription"/> or
    /// <see cref="GetSubscriptionAsync"/>. At that point the normal operations of <see cref="SimpleSubscription"/> such
    /// as polling are available. Topics can be retrieved or created without any knowledge of which projects will own the
    /// subscriptions, and then <see cref="SimpleTopic"/> can be used to publish messages.
    /// </para>
    /// </remarks>
    public class SimplePubsub
    {
        private static readonly string SubscriptionParameterName = SubscriptionTemplate.ParameterNames.Last();
        private static readonly string TopicParameterName = TopicTemplate.ParameterNames.Last();

        // The default ack deadline to use when creating subscriptions.
        private static readonly TimeSpan s_defaultAckDeadline = TimeSpan.FromSeconds(60);

        /// <summary>
        /// The ID of the project containing all the topics and subscriptions this instance works with.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The full subscriber client, exposed to allow easy access to the underlying API.
        /// </summary>
        public SubscriberClient Subscriber { get; }

        /// <summary>
        /// The full publisher client, exposed to allow easy access to the underlying API.
        /// </summary>
        public PublisherClient Publisher { get; }

        /// <summary>
        /// Constructs an instance from the given project ID and publisher/subscriber clients.
        /// </summary>
        /// <param name="projectId">The project ID to use for all operations. Must not be null.</param>
        /// <param name="publisher">The publisher client. Must not be null.</param>
        /// <param name="subscriber">The subscriber client. Must not be null.</param>
        public SimplePubsub(string projectId, PublisherClient publisher, SubscriberClient subscriber)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            Subscriber = GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber));
            Publisher = GaxPreconditions.CheckNotNull(publisher, nameof(publisher));
        }

        /// <summary>
        /// Creates an instance from the application default credentials.
        /// </summary>
        /// <param name="projectId">The project ID to use for all operations. Must not be null.</param>
        /// <returns>A <see cref="SimplePubsub"/> instance using <paramref name="projectId"/> as the project,
        /// and the application default credentials.</returns>
        public static SimplePubsub CreateFromDefaultCredentials(string projectId)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            return new SimplePubsub(projectId,
                PublisherClient.CreateFromDefaultCredentials(),
                SubscriberClient.CreateFromDefaultCredentials());
        }

        /// <summary>
        /// Asynchronously creates an instance from the application default credentials.
        /// </summary>
        /// <param name="projectId">The project ID to use for all operations. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the task
        /// will be a <see cref="SimplePubsub"/> instance using <paramref name="projectId"/> as the project,
        /// and the application default credentials.</returns>
        public static async Task<SimplePubsub> CreateFromDefaultCredentialsAsync(string projectId)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            return new SimplePubsub(projectId,
                await PublisherClient.CreateFromDefaultCredentialsAsync(),
                await SubscriberClient.CreateFromDefaultCredentialsAsync());
        }

        /// <summary>
        /// Fetches a topic by ID. The topic is checked for existence as part of this operation.
        /// </summary>
        /// <param name="topicId">The ID of the topic. Must not be null.</param>
        /// <returns>The topic identified by <paramref name="topicId"/> within the project identified
        /// by this instance.</returns>
        public SimpleTopic GetTopic(string topicId)
        {
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            // Just check existence...
            Publisher.GetTopic(GetTopicName(ProjectId, topicId));
            return new SimpleTopic(this, topicId);
        }

        /// <summary>
        /// Asynchronously fetches a topic by ID. The topic is checked for existence as part of this operation.
        /// </summary>
        /// <param name="topicId">The ID of the topic. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task will be the topic identified by <paramref name="topicId"/> within the project identified
        /// by this instance.</returns>
        public async Task<SimpleTopic> GetTopicAsync(string topicId, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            // Just check existence...
            await Publisher.GetTopicAsync(GetTopicName(ProjectId, topicId), cancellationToken);
            return new SimpleTopic(this, topicId);
        }

        /// <summary>
        /// Fetches a topic by ID, or creates it if it doesn't already exist.
        /// </summary>
        /// <param name="topicId">The ID of the topic to fetch or create. Must not be null.</param>
        /// <returns>The topic identified by <paramref name="topicId"/>.</returns>
        public SimpleTopic GetOrCreateTopic(string topicId)
        {
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            string topicName = GetTopicName(ProjectId, topicId);

            // Note that we don't actually use the returned resource, and there's no validation required.
            GetOrCreateHelper.GetOrCreate(
                () => Publisher.GetTopic(topicName),
                () => Publisher.CreateTopic(topicName));
            return new SimpleTopic(this, topicId);
        }

        /// <summary>
        /// Asynchronously fetches a topic by ID, or creates it if it doesn't already exist.
        /// </summary>
        /// <param name="topicId">The ID of the topic to fetch or create. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task will be the topic identified by <paramref name="topicId"/>.</returns>
        public async Task<SimpleTopic> GetOrCreateTopicAsync(string topicId, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            string topicName = GetTopicName(ProjectId, topicId);

            // Note that we don't actually use the returned resource, and there's no validation required.
            await GetOrCreateHelper.GetOrCreate(
                () => Publisher.GetTopicAsync(topicName, cancellationToken),
                () => Publisher.CreateTopicAsync(topicName, cancellationToken)).ConfigureAwait(false);
            return new SimpleTopic(this, topicId);
        }

        /// <summary>
        /// Fetches a subscription by ID. The topic is checked for existence as part of this operation.
        /// </summary>
        /// <param name="subscriptionId">The ID of the subscription. Must not be null.</param>
        /// <returns>The subscription identified by <paramref name="subscriptionId"/> within the project identified
        /// by this instance.</returns>
        public SimpleSubscription GetSubscription(string subscriptionId)
        {
            GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
            var subscription = Subscriber.GetSubscription(GetSubscriptionName(ProjectId, subscriptionId));
            return new SimpleSubscription(this,
                SubscriptionTemplate.ParseName(subscription.Name)[SubscriptionParameterName],
                TopicTemplate.ParseName(subscription.Topic)[TopicParameterName]);
        }

        /// <summary>
        /// Asynchronously fetches a subscription by ID. The subscription is checked for existence as part of this operation.
        /// </summary>
        /// <param name="subscriptionId">The ID of the subscription. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task will be the subscription identified by <paramref name="subscriptionId"/> within the project identified
        /// by this instance.</returns>
        public async Task<SimpleSubscription> GetSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
            var subscription = await Subscriber.GetSubscriptionAsync(GetSubscriptionName(ProjectId, subscriptionId)).ConfigureAwait(false);
            return new SimpleSubscription(this,
                SubscriptionTemplate.ParseName(subscription.Name)[SubscriptionParameterName],
                TopicTemplate.ParseName(subscription.Topic)[TopicParameterName]);
        }

        /// <summary>
        /// Fetches a subscription by ID, or creates it if it doesn't already exist.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The <paramref name="topicId"/> identifies the target topic of the subscription, within the same project. If the subscription
        /// already exists but has a different target, <see cref="ResourceMismatchException"/> is thrown.
        /// </para>
        /// <para>
        /// The <paramref name="ackDeadline"/> parameter specifies the deadline for clients to acknowledge messages they have
        /// successfully pulled and handled. This must be a positive number of seconds, and the range is further limited by the Pubsub
        /// service; consult the Pubsub documentation for more details. If a non-integer number of seconds is provided, it will be truncated
        /// down to an integer number of seconds. If no value is provided, a default deadline will be used. If the subscription already exists,
        /// this method does not validate that the actual deadline is the one that this method would have used when creating the subscription.
        /// </para>
        /// <para>
        /// This method does not specify a push configuration when it creates the subscription.
        /// </para>
        /// </remarks>
        /// <param name="subscriptionId">The ID of the subscription to fetch or create. Must not be null.</param>
        /// <param name="topicId">The ID of the topic to subscribe to if the subscription doesn't already exist. Must not be null.</param>
        /// <param name="ackDeadline">The deadline for clients to acknowledge pulled messages before they may be pulled again.</param>
        /// <exception cref="ResourceMismatchException">The specified subscription exists, but for a different topic.</exception>
        /// <returns>The subscription identified by <paramref name="subscriptionId"/>.</returns>
        public SimpleSubscription GetOrCreateSubscription(string subscriptionId, string topicId, TimeSpan? ackDeadline = null)
        {
            GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            int ackDeadlineSeconds = GetAckDeadlineSeconds(ackDeadline);

            string subscriptionName = GetSubscriptionName(ProjectId, subscriptionId);
            string topicName = GetTopicName(ProjectId, topicId);

            var subscription = GetOrCreateHelper.GetOrCreate(
                () => Subscriber.GetSubscription(subscriptionName),
                () => Subscriber.CreateSubscription(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: ackDeadlineSeconds),
                actual => actual.Topic == topicName ? null : $"Subscription {subscriptionName} is subscribed to topic {actual.Topic}; expected topic was {topicName}"
            );
            return new SimpleSubscription(this, subscriptionId, topicId);
        }

        /// <summary>
        /// Asynchronously fetches a subscription by ID, or creates it if it doesn't already exist.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The <paramref name="topicId"/> identifies the target topic of the subscription, within the same project. If the subscription
        /// already exists but has a different target, <see cref="ResourceMismatchException"/> is thrown.
        /// </para>
        /// <para>
        /// The <paramref name="ackDeadline"/> parameter specifies the deadline for clients to acknowledge messages they have
        /// successfully pulled and handled. This must be a positive number of seconds, and the range is further limited by the Pubsub
        /// service; consult the Pubsub documentation for more details. If a non-integer number of seconds is provided, it will be truncated
        /// down to an integer number of seconds. If no value is provided, a default deadline will be used. If the subscription already exists,
        /// this method does not validate that the actual deadline is the one that this method would have used when creating the subscription.
        /// </para>
        /// <para>
        /// This method does not specify a push configuration when it creates the subscription.
        /// </para>
        /// </remarks>
        /// <param name="subscriptionId">The ID of the subscription to fetch or create. Must not be null.</param>
        /// <param name="topicId">The ID of the topic to subscribe to if the subscription doesn't already exist. Must not be null.</param>
        /// <param name="ackDeadline">The deadline for clients to acknowledge pulled messages before they may be pulled again.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ResourceMismatchException">The specified subscription exists, but for a different topic.</exception>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task is the subscription identified by <paramref name="subscriptionId"/>.</returns>
        public async Task<SimpleSubscription> GetOrCreateSubscriptionAsync(
            string subscriptionId,
            string topicId,
            TimeSpan? ackDeadline = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
            GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            int ackDeadlineSeconds = GetAckDeadlineSeconds(ackDeadline);

            string subscriptionName = GetSubscriptionName(ProjectId, subscriptionId);
            string topicName = GetTopicName(ProjectId, topicId);

            var subscription = await GetOrCreateHelper.GetOrCreateAsync(
                () => Subscriber.GetSubscriptionAsync(subscriptionName, cancellationToken),
                () => Subscriber.CreateSubscriptionAsync(subscriptionName, topicName, pushConfig: null, ackDeadlineSeconds: ackDeadlineSeconds, cancellationToken: cancellationToken),
                actual => actual.Topic == topicName ? null : $"Subscription {subscriptionName} is subscribed to topic {actual.Topic}; expected topic was {topicName}"
            );
            return new SimpleSubscription(this, subscriptionId, topicId);
        }

        /// <summary>
        /// Common code to validate an ack deadline and apply the default.
        /// </summary>
        private static int GetAckDeadlineSeconds(TimeSpan? ackDeadline = null)
        {
            double seconds = (ackDeadline ?? s_defaultAckDeadline).TotalSeconds;
            // Note that the service will reject a huge ackDeadline anyway, but we're not building the service limits into the client.
            GaxPreconditions.CheckArgument(seconds > 0 && seconds < int.MaxValue, nameof(ackDeadline),
                "The ack deadline must be positive and in the range of an Int32 number of seconds");
            return (int) seconds;
        }
    }
}
