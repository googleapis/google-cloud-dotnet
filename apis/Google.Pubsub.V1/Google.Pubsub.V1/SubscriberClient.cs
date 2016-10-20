// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="SubscriberClient"/>.
    /// </summary>
    public static partial class SubscriberExtensions
    {
        /// <summary>
        /// Wrap a GRPC Subscriber client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="SubscriberSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="SubscriberClient"/> that wraps the specified GRPC client.</returns>
        public static SubscriberClient ToClient(
            this Subscriber.SubscriberClient grpcClient,
            SubscriberSettings settings = null
        ) => new SubscriberClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Subscriber wrapper.
    /// </summary>
    public sealed partial class SubscriberSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SubscriberSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default SubscriberSettings.</returns>
        public static SubscriberSettings GetDefault() => new SubscriberSettings();

        /// <summary>
        /// Constructs a new SubscriberSettings object with default settings.
        /// </summary>
        public SubscriberSettings() { }

        private SubscriberSettings(SubscriberSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSubscriptionSettings = existing.CreateSubscriptionSettings?.Clone();
            GetSubscriptionSettings = existing.GetSubscriptionSettings?.Clone();
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings?.Clone();
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings?.Clone();
            ModifyAckDeadlineSettings = existing.ModifyAckDeadlineSettings?.Clone();
            AcknowledgeSettings = existing.AcknowledgeSettings?.Clone();
            PullSettings = existing.PullSettings?.Clone();
            ModifyPushConfigSettings = existing.ModifyPushConfigSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="SubscriberClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(60000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetMessagingRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 12000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 12000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetMessagingTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(12000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(12000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.CreateSubscription"/> and <see cref="SubscriberClient.CreateSubscriptionAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.CreateSubscription"/> and
        /// <see cref="SubscriberClient.CreateSubscriptionAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateSubscriptionSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.GetSubscription"/> and <see cref="SubscriberClient.GetSubscriptionAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.GetSubscription"/> and
        /// <see cref="SubscriberClient.GetSubscriptionAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetSubscriptionSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.ListSubscriptions"/> and <see cref="SubscriberClient.ListSubscriptionsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.ListSubscriptions"/> and
        /// <see cref="SubscriberClient.ListSubscriptionsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListSubscriptionsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.DeleteSubscription"/> and <see cref="SubscriberClient.DeleteSubscriptionAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.DeleteSubscription"/> and
        /// <see cref="SubscriberClient.DeleteSubscriptionAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteSubscriptionSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.ModifyAckDeadline"/> and <see cref="SubscriberClient.ModifyAckDeadlineAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.ModifyAckDeadline"/> and
        /// <see cref="SubscriberClient.ModifyAckDeadlineAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ModifyAckDeadlineSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.Acknowledge"/> and <see cref="SubscriberClient.AcknowledgeAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.Acknowledge"/> and
        /// <see cref="SubscriberClient.AcknowledgeAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 12000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 12000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AcknowledgeSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetMessagingRetryBackoff(),
                TimeoutBackoff = GetMessagingTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.Pull"/> and <see cref="SubscriberClient.PullAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.Pull"/> and
        /// <see cref="SubscriberClient.PullAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 12000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 12000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings PullSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetMessagingRetryBackoff(),
                TimeoutBackoff = GetMessagingTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="SubscriberClient.ModifyPushConfig"/> and <see cref="SubscriberClient.ModifyPushConfigAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="SubscriberClient.ModifyPushConfig"/> and
        /// <see cref="SubscriberClient.ModifyPushConfigAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ModifyPushConfigSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Subscriber settings.</returns>
        public SubscriberSettings Clone() => new SubscriberSettings(this);
    }

    /// <summary>
    /// Subscriber client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SubscriberClient
    {
        /// <summary>
        /// The default endpoint for the Subscriber service, which is a host of "pubsub.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("pubsub.googleapis.com", 443);

        /// <summary>
        /// The default Subscriber scopes
        /// </summary>
        /// <remarks>
        /// The default Subscriber scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/pubsub"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/pubsub",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="SubscriberClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SubscriberClient"/>.</returns>
        public static async Task<SubscriberClient> CreateAsync(ServiceEndpoint endpoint = null, SubscriberSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SubscriberClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberClient"/>.</returns>
        public static SubscriberClient Create(ServiceEndpoint endpoint = null, SubscriberSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SubscriberClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SubscriberSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberClient"/>.</returns>
        public static SubscriberClient Create(Channel channel, SubscriberSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Subscriber.SubscriberClient grpcClient = new Subscriber.SubscriberClient(channel);
            return new SubscriberClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, SubscriberSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SubscriberSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, SubscriberSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, SubscriberSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC Subscriber client.
        /// </summary>
        public virtual Subscriber.SubscriberClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="subscriptionName">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topicName">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="pushConfig">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName subscriptionName,
            TopicName topicName,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="subscriptionName">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topicName">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="pushConfig">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName subscriptionName,
            TopicName topicName,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken) => CreateSubscriptionAsync(
                subscriptionName,
                topicName,
                pushConfig,
                ackDeadlineSeconds,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="subscriptionName">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topicName">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="pushConfig">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription CreateSubscription(
            SubscriptionName subscriptionName,
            TopicName topicName,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription to get.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscriptionName,
            CancellationToken cancellationToken) => GetSubscriptionAsync(
                subscriptionName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="projectName">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Subscription resources.</returns>
        public virtual IPagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ProjectName projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="projectName">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Subscription resources.</returns>
        public virtual IPagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ProjectName projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscriptionName">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSubscriptionAsync(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscriptionName">The subscription to delete.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteSubscriptionAsync(
            SubscriptionName subscriptionName,
            CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                subscriptionName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscriptionName">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSubscription(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="ackIds">List of acknowledgment IDs.</param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyAckDeadlineAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="ackIds">List of acknowledgment IDs.</param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyAckDeadlineAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                subscriptionName,
                ackIds,
                ackDeadlineSeconds,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="ackIds">List of acknowledgment IDs.</param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ModifyAckDeadline(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscriptionName">The subscription whose message is being acknowledged.</param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task AcknowledgeAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscriptionName">The subscription whose message is being acknowledged.</param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task AcknowledgeAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            CancellationToken cancellationToken) => AcknowledgeAsync(
                subscriptionName,
                ackIds,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscriptionName">The subscription whose message is being acknowledged.</param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Acknowledge(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscriptionName">The subscription from which messages should be pulled.</param>
        /// <param name="returnImmediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<PullResponse> PullAsync(
            SubscriptionName subscriptionName,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscriptionName">The subscription from which messages should be pulled.</param>
        /// <param name="returnImmediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<PullResponse> PullAsync(
            SubscriptionName subscriptionName,
            bool returnImmediately,
            int maxMessages,
            CancellationToken cancellationToken) => PullAsync(
                subscriptionName,
                returnImmediately,
                maxMessages,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscriptionName">The subscription from which messages should be pulled.</param>
        /// <param name="returnImmediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PullResponse Pull(
            SubscriptionName subscriptionName,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyPushConfigAsync(
            SubscriptionName subscriptionName,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task ModifyPushConfigAsync(
            SubscriptionName subscriptionName,
            PushConfig pushConfig,
            CancellationToken cancellationToken) => ModifyPushConfigAsync(
                subscriptionName,
                pushConfig,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ModifyPushConfig(
            SubscriptionName subscriptionName,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class SubscriberClientImpl : SubscriberClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<Subscription, Subscription> _callCreateSubscription;
        private readonly ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;
        private readonly ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;
        private readonly ApiCall<DeleteSubscriptionRequest, Empty> _callDeleteSubscription;
        private readonly ApiCall<ModifyAckDeadlineRequest, Empty> _callModifyAckDeadline;
        private readonly ApiCall<AcknowledgeRequest, Empty> _callAcknowledge;
        private readonly ApiCall<PullRequest, PullResponse> _callPull;
        private readonly ApiCall<ModifyPushConfigRequest, Empty> _callModifyPushConfig;

        public SubscriberClientImpl(Subscriber.SubscriberClient grpcClient, SubscriberSettings settings)
        {
            this.GrpcClient = grpcClient;
            SubscriberSettings effectiveSettings = settings ?? SubscriberSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callCreateSubscription = _clientHelper.BuildApiCall<Subscription, Subscription>(
                GrpcClient.CreateSubscriptionAsync, GrpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings);
            _callGetSubscription = _clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>(
                GrpcClient.GetSubscriptionAsync, GrpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings);
            _callListSubscriptions = _clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>(
                GrpcClient.ListSubscriptionsAsync, GrpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings);
            _callDeleteSubscription = _clientHelper.BuildApiCall<DeleteSubscriptionRequest, Empty>(
                GrpcClient.DeleteSubscriptionAsync, GrpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings);
            _callModifyAckDeadline = _clientHelper.BuildApiCall<ModifyAckDeadlineRequest, Empty>(
                GrpcClient.ModifyAckDeadlineAsync, GrpcClient.ModifyAckDeadline, effectiveSettings.ModifyAckDeadlineSettings);
            _callAcknowledge = _clientHelper.BuildApiCall<AcknowledgeRequest, Empty>(
                GrpcClient.AcknowledgeAsync, GrpcClient.Acknowledge, effectiveSettings.AcknowledgeSettings);
            _callPull = _clientHelper.BuildApiCall<PullRequest, PullResponse>(
                GrpcClient.PullAsync, GrpcClient.Pull, effectiveSettings.PullSettings);
            _callModifyPushConfig = _clientHelper.BuildApiCall<ModifyPushConfigRequest, Empty>(
                GrpcClient.ModifyPushConfigAsync, GrpcClient.ModifyPushConfig, effectiveSettings.ModifyPushConfigSettings);
        }

        public override Subscriber.SubscriberClient GrpcClient { get; }

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="subscriptionName">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topicName">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="pushConfig">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName subscriptionName,
            TopicName topicName,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callCreateSubscription.Async(
                new Subscription
                {
                    Name = subscriptionName.ToString(),
                    Topic = topicName.ToString(),
                    PushConfig = pushConfig,
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic for a given subscriber.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic.
        /// </summary>
        /// <param name="subscriptionName">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topicName">
        /// The name of the topic from which this subscription is receiving messages.
        /// The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.
        /// </param>
        /// <param name="pushConfig">
        /// If push delivery is used with this subscription, this field is
        /// used to configure it. An empty `pushConfig` signifies that the subscriber
        /// will pull and ack messages using API methods.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// This value is the maximum time after a subscriber receives a message
        /// before the subscriber should acknowledge the message. After message
        /// delivery but before the ack deadline expires and before the message is
        /// acknowledged, it is an outstanding message and will not be delivered
        /// again during that time (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// pull.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        ///
        /// If this parameter is not set, the default value of 10 seconds is used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription CreateSubscription(
            SubscriptionName subscriptionName,
            TopicName topicName,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callCreateSubscription.Sync(
                new Subscription
                {
                    Name = subscriptionName.ToString(),
                    Topic = topicName.ToString(),
                    PushConfig = pushConfig,
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null) => _callGetSubscription.Async(
                new GetSubscriptionRequest
                {
                    Subscription = subscriptionName.ToString(),
                },
                callSettings);

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription GetSubscription(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null) => _callGetSubscription.Sync(
                new GetSubscriptionRequest
                {
                    Subscription = subscriptionName.ToString(),
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="projectName">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of Subscription resources.</returns>
        public override IPagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ProjectName projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(
                _callListSubscriptions,
                new ListSubscriptionsRequest
                {
                    Project = projectName.ToString(),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="projectName">The name of the cloud project that subscriptions belong to.</param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of Subscription resources.</returns>
        public override IPagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ProjectName projectName,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(
                _callListSubscriptions,
                new ListSubscriptionsRequest
                {
                    Project = projectName.ToString(),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscriptionName">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteSubscriptionAsync(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null) => _callDeleteSubscription.Async(
                new DeleteSubscriptionRequest
                {
                    Subscription = subscriptionName.ToString(),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription. All pending messages in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription, or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscriptionName">The subscription to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSubscription(
            SubscriptionName subscriptionName,
            CallSettings callSettings = null) => _callDeleteSubscription.Sync(
                new DeleteSubscriptionRequest
                {
                    Subscription = subscriptionName.ToString(),
                },
                callSettings);

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="ackIds">List of acknowledgment IDs.</param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task ModifyAckDeadlineAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callModifyAckDeadline.Async(
                new ModifyAckDeadlineRequest
                {
                    Subscription = subscriptionName.ToString(),
                    AckIds = { ackIds },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="ackIds">List of acknowledgment IDs.</param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. Must be >= 0. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ModifyAckDeadline(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callModifyAckDeadline.Sync(
                new ModifyAckDeadlineRequest
                {
                    Subscription = subscriptionName.ToString(),
                    AckIds = { ackIds },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscriptionName">The subscription whose message is being acknowledged.</param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task AcknowledgeAsync(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => _callAcknowledge.Async(
                new AcknowledgeRequest
                {
                    Subscription = subscriptionName.ToString(),
                    AckIds = { ackIds },
                },
                callSettings);

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscriptionName">The subscription whose message is being acknowledged.</param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void Acknowledge(
            SubscriptionName subscriptionName,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => _callAcknowledge.Sync(
                new AcknowledgeRequest
                {
                    Subscription = subscriptionName.ToString(),
                    AckIds = { ackIds },
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscriptionName">The subscription from which messages should be pulled.</param>
        /// <param name="returnImmediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<PullResponse> PullAsync(
            SubscriptionName subscriptionName,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => _callPull.Async(
                new PullRequest
                {
                    Subscription = subscriptionName.ToString(),
                    ReturnImmediately = returnImmediately,
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscriptionName">The subscription from which messages should be pulled.</param>
        /// <param name="returnImmediately">
        /// If this is specified as true the system will respond immediately even if
        /// it is not able to return a message in the `Pull` response. Otherwise the
        /// system is allowed to wait until at least one message is available rather
        /// than returning no messages. The client may cancel the request if it does
        /// not wish to wait any longer for the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PullResponse Pull(
            SubscriptionName subscriptionName,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => _callPull.Sync(
                new PullRequest
                {
                    Subscription = subscriptionName.ToString(),
                    ReturnImmediately = returnImmediately,
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task ModifyPushConfigAsync(
            SubscriptionName subscriptionName,
            PushConfig pushConfig,
            CallSettings callSettings = null) => _callModifyPushConfig.Async(
                new ModifyPushConfigRequest
                {
                    Subscription = subscriptionName.ToString(),
                    PushConfig = pushConfig,
                },
                callSettings);

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscriptionName">The name of the subscription.</param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ModifyPushConfig(
            SubscriptionName subscriptionName,
            PushConfig pushConfig,
            CallSettings callSettings = null) => _callModifyPushConfig.Sync(
                new ModifyPushConfigRequest
                {
                    Subscription = subscriptionName.ToString(),
                    PushConfig = pushConfig,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListSubscriptionsRequest : IPageRequest { }
    public partial class ListSubscriptionsResponse : IPageResponse<Subscription>
    {
        public IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}