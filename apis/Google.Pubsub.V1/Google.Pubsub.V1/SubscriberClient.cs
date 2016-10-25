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
using Google.Api.Gax.Grpc;
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
    /// Settings for a <see cref="SubscriberClient"/>.
    /// </summary>
    public sealed partial class SubscriberSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SubscriberSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SubscriberSettings"/>.
        /// </returns>
        public static SubscriberSettings GetDefault() => new SubscriberSettings();

        /// <summary>
        /// Constructs a new <see cref="SubscriberSettings"/> object with default settings.
        /// </summary>
        public SubscriberSettings() { }

        private SubscriberSettings(SubscriberSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSubscriptionSettings = existing.CreateSubscriptionSettings;
            GetSubscriptionSettings = existing.GetSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            ModifyAckDeadlineSettings = existing.ModifyAckDeadlineSettings;
            AcknowledgeSettings = existing.AcknowledgeSettings;
            PullSettings = existing.PullSettings;
            ModifyPushConfigSettings = existing.ModifyPushConfigSettings;
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
        /// <returns>
        /// The "Default" retry backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" retry backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetMessagingRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" timeout backoff for <see cref="SubscriberClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 12000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 12000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetMessagingTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(12000),
            maxDelay: TimeSpan.FromMilliseconds(12000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.CreateSubscription</c> and <c>SubscriberClient.CreateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.CreateSubscription</c> and
        /// <c>SubscriberClient.CreateSubscriptionAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateSubscriptionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.GetSubscription</c> and <c>SubscriberClient.GetSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.GetSubscription</c> and
        /// <c>SubscriberClient.GetSubscriptionAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetSubscriptionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.ListSubscriptions</c> and <c>SubscriberClient.ListSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.ListSubscriptions</c> and
        /// <c>SubscriberClient.ListSubscriptionsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListSubscriptionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.DeleteSubscription</c> and <c>SubscriberClient.DeleteSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.DeleteSubscription</c> and
        /// <c>SubscriberClient.DeleteSubscriptionAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteSubscriptionSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.ModifyAckDeadline</c> and <c>SubscriberClient.ModifyAckDeadlineAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.ModifyAckDeadline</c> and
        /// <c>SubscriberClient.ModifyAckDeadlineAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ModifyAckDeadlineSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.Acknowledge</c> and <c>SubscriberClient.AcknowledgeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.Acknowledge</c> and
        /// <c>SubscriberClient.AcknowledgeAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings AcknowledgeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.Pull</c> and <c>SubscriberClient.PullAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.Pull</c> and
        /// <c>SubscriberClient.PullAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings PullSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.ModifyPushConfig</c> and <c>SubscriberClient.ModifyPushConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.ModifyPushConfig</c> and
        /// <c>SubscriberClient.ModifyPushConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ModifyPushConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SubscriberSettings"/> object.</returns>
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
        /// The default Subscriber scopes.
        /// </summary>
        /// <remarks>
        /// The default Subscriber scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/pubsub"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/pubsub",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>
        /// The full project resource name.
        /// </returns>
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a subscription resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>subscription</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate SubscriptionTemplate { get; } = new PathTemplate("projects/{project}/subscriptions/{subscription}");

        /// <summary>
        /// Creates a subscription resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <returns>
        /// The full subscription resource name.
        /// </returns>
        public static string FormatSubscriptionName(string projectId, string subscriptionId) => SubscriptionTemplate.Expand(projectId, subscriptionId);

        /// <summary>
        /// Path template for a topic resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>topic</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate TopicTemplate { get; } = new PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// Creates a topic resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <returns>
        /// The full topic resource name.
        /// </returns>
        public static string FormatTopicName(string projectId, string topicId) => TopicTemplate.Expand(projectId, topicId);

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
        /// The underlying gRPC Subscriber client.
        /// </summary>
        public virtual Subscriber.SubscriberClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken) => CreateSubscriptionAsync(
                name,
                topic,
                pushConfig,
                ackDeadlineSeconds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken) => GetSubscriptionAsync(
                subscription,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Subscription GetSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="project">
        ///
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual IPagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            string project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="project">
        ///
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual IPagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            string project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSubscriptionAsync(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSubscriptionAsync(
            string subscription,
            CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                subscription,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSubscription(
            string subscription,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                subscription,
                ackIds,
                ackDeadlineSeconds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CancellationToken cancellationToken) => AcknowledgeAsync(
                subscription,
                ackIds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="returnImmediately">
        ///
        /// </param>
        /// <param name="maxMessages">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="returnImmediately">
        ///
        /// </param>
        /// <param name="maxMessages">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CancellationToken cancellationToken) => PullAsync(
                subscription,
                returnImmediately,
                maxMessages,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="returnImmediately">
        ///
        /// </param>
        /// <param name="maxMessages">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CancellationToken cancellationToken) => ModifyPushConfigAsync(
                subscription,
                pushConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Subscriber client wrapper implementation, for convenient use.
    /// </summary>
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

        /// <summary>
        /// Constructs a client wrapper for the Subscriber service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SubscriberSettings"/> used within this client </param>
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

        /// <summary>
        /// The underlying gRPC Subscriber client.
        /// </summary>
        public override Subscriber.SubscriberClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callCreateSubscription.Async(
                new Subscription
                {
                    Name = name,
                    Topic = topic,
                    PushConfig = pushConfig,
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`.
        /// </param>
        /// <param name="topic">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Subscription CreateSubscription(
            string name,
            string topic,
            PushConfig pushConfig,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callCreateSubscription.Sync(
                new Subscription
                {
                    Name = name,
                    Topic = topic,
                    PushConfig = pushConfig,
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Subscription> GetSubscriptionAsync(
            string subscription,
            CallSettings callSettings = null) => _callGetSubscription.Async(
                new GetSubscriptionRequest
                {
                    Subscription = subscription,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Subscription GetSubscription(
            string subscription,
            CallSettings callSettings = null) => _callGetSubscription.Sync(
                new GetSubscriptionRequest
                {
                    Subscription = subscription,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="project">
        ///
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override IPagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            string project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(
                _callListSubscriptions,
                new ListSubscriptionsRequest
                {
                    Project = project,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="project">
        ///
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override IPagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            string project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(
                _callListSubscriptions,
                new ListSubscriptionsRequest
                {
                    Project = project,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteSubscriptionAsync(
            string subscription,
            CallSettings callSettings = null) => _callDeleteSubscription.Async(
                new DeleteSubscriptionRequest
                {
                    Subscription = subscription,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteSubscription(
            string subscription,
            CallSettings callSettings = null) => _callDeleteSubscription.Sync(
                new DeleteSubscriptionRequest
                {
                    Subscription = subscription,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task ModifyAckDeadlineAsync(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callModifyAckDeadline.Async(
                new ModifyAckDeadlineRequest
                {
                    Subscription = subscription,
                    AckIds = { ackIds },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="ackDeadlineSeconds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void ModifyAckDeadline(
            string subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => _callModifyAckDeadline.Sync(
                new ModifyAckDeadlineRequest
                {
                    Subscription = subscription,
                    AckIds = { ackIds },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task AcknowledgeAsync(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => _callAcknowledge.Async(
                new AcknowledgeRequest
                {
                    Subscription = subscription,
                    AckIds = { ackIds },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="ackIds">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void Acknowledge(
            string subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => _callAcknowledge.Sync(
                new AcknowledgeRequest
                {
                    Subscription = subscription,
                    AckIds = { ackIds },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="returnImmediately">
        ///
        /// </param>
        /// <param name="maxMessages">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<PullResponse> PullAsync(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => _callPull.Async(
                new PullRequest
                {
                    Subscription = subscription,
                    ReturnImmediately = returnImmediately,
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="returnImmediately">
        ///
        /// </param>
        /// <param name="maxMessages">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override PullResponse Pull(
            string subscription,
            bool returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => _callPull.Sync(
                new PullRequest
                {
                    Subscription = subscription,
                    ReturnImmediately = returnImmediately,
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null) => _callModifyPushConfig.Async(
                new ModifyPushConfigRequest
                {
                    Subscription = subscription,
                    PushConfig = pushConfig,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="subscription">
        ///
        /// </param>
        /// <param name="pushConfig">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null) => _callModifyPushConfig.Sync(
                new ModifyPushConfigRequest
                {
                    Subscription = subscription,
                    PushConfig = pushConfig,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListSubscriptionsRequest : IPageRequest { }
    public partial class ListSubscriptionsResponse : IPageResponse<Subscription>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
