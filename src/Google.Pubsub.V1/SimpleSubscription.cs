// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.
using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using static Google.Pubsub.V1.PublisherClient;
using static Google.Pubsub.V1.SubscriberClient;


namespace Google.Pubsub.V1
{
    /// <summary>
    /// A subscription within a project, with methods to make pulling messages simpler than with the full API.
    /// </summary>
    public class SimpleSubscription
    {
        private const int MaxMessages = 50;

        /// <summary>
        /// The ID of the project this subscription is part of.
        /// </summary>        
        public string ProjectId => Parent.ProjectId;

        /// <summary>
        /// The subscription ID within the project.
        /// </summary>
        public string SubscriptionId { get; }

        /// <summary>
        /// The ID of the topic that this subscription is subscribed to.
        /// </summary>
        public string TopicId { get; }

        /// <summary>
        /// The full resource name of this subscription, including project ID.
        /// </summary>
        public string ResourceName { get; }

        /// <summary>
        /// The full resource name of the topic this subscription is subscribed to.
        /// </summary>
        public string TopicResourceName { get; }

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
        /// <param name="subscriptionId">The ID of the subscription within the parent project. Must not be null.</param>
        /// <param name="topicId">The ID of the topic within the parent project. Must not be null.</param>
        public SimpleSubscription(SimplePubsub parent, string subscriptionId, string topicId)
        {
            Parent = GaxPreconditions.CheckNotNull(parent, nameof(parent));
            SubscriptionId = GaxPreconditions.CheckNotNull(subscriptionId, nameof(subscriptionId));
            TopicId = GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
            ResourceName = GetSubscriptionName(parent.ProjectId, subscriptionId);
            TopicResourceName = GetTopicName(parent.ProjectId, topicId);
        }

        // TODO:
        // - Do we actually want Poll? Unclear how much value it adds.
        // - Should PullAndAcknowledge take an action, and only acknowledge messages after acting on them?
        //   - If so, should it acknowledge in batches, or individually? If it does it in batches, should it
        //     acknowledge successful messages in a finally block if a later message failed?

        /// <summary>
        /// Polls the subscription until the specified cancellation token is cancelled, acknowledging
        /// messages automatically and executing the given callback for each one.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When the cancellation token is cancelled, this method returns without throwing an exception. It is
        /// possible that messages will already have been acknowledged but not processed when that occurs.
        /// </para>
        /// </remarks>
        /// <param name="action">The callback to execute for each message. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        public void Poll(Action<PubsubMessage> action, CancellationToken cancellationToken)
        {
            while (true)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
                try
                {
                    var messages = PullAndAcknowledge(cancellationToken);
                    foreach (var message in messages)
                    {
                        action(message);
                    }
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.Cancelled)
                {
                    return;
                }
                catch (OperationCanceledException)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Asynchronously the subscription until the specified cancellation token is cancelled, acknowledging
        /// messages automatically and executing the given callback for each one.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When the cancellation token is cancelled, the task returned by this method will be completed with
        /// a status of <see cref="TaskStatus.Canceled"/>. It is possible that messages will already have been
        /// acknowledged but not processed when that occurs.
        /// </para>
        /// </remarks>
        /// <param name="action">The callback to execute for each message. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task PollAsync(Action<PubsubMessage> action, CancellationToken cancellationToken)
        {
            while (true)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var messages = await PullAndAcknowledgeAsync(cancellationToken).ConfigureAwait(false);
                foreach (var message in messages)
                {
                    action(message);
                }
            }
        }

        /// <summary>
        /// Performs a single pull operation on the subscription, which will wait until a message has been published
        /// to the target topic or a timeout occurs before returning. All messages are acknowledged before this method returns.
        /// Up to 50 messages will be retrieved by a single call.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The list of messages returned by the pull operation.</returns>
        public IList<PubsubMessage> PullAndAcknowledge(CancellationToken cancellationToken = default(CancellationToken))
        {
            var callSettings = new CallSettings { CancellationToken = cancellationToken };
            PullResponse response = Parent.Subscriber.Pull(ResourceName, true, MaxMessages, callSettings);
            IEnumerable<string> ackIds = response.ReceivedMessages.Select(rm => rm.AckId);
            Parent.Subscriber.Acknowledge(ResourceName, ackIds, callSettings);
            return response.ReceivedMessages.Select(rm => rm.Message).ToList();
        }

        /// <summary>
        /// Asynchronously performs a single pull operation on the subscription, which will wait until a message has been published
        /// to the target topic or a timeout occurs before returning. All messages are acknowledged before the returned task completes.
        /// Up to 50 messages will be retrieved by a single call.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When completed, the result of the
        /// task is the list of messages returned by the pull operation.</returns>
        public async Task<IList<PubsubMessage>> PullAndAcknowledgeAsync(CancellationToken cancellationToken)
        {
            PullResponse response = await Parent.Subscriber.PullAsync(ResourceName, false, 10, cancellationToken).ConfigureAwait(false);
            IEnumerable<string> ackIds = response.ReceivedMessages.Select(rm => rm.AckId);
            await Parent.Subscriber.AcknowledgeAsync(ResourceName, ackIds, cancellationToken).ConfigureAwait(false);
            return response.ReceivedMessages.Select(rm => rm.Message).ToList();
        }
    }
}
