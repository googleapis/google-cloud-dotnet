// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Cloud.Iam.V1;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// Settings for a <see cref="PublisherClient"/>.
    /// </summary>
    public sealed partial class PublisherSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublisherSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PublisherSettings"/>.
        /// </returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>
        /// Constructs a new <see cref="PublisherSettings"/> object with default settings.
        /// </summary>
        public PublisherSettings() { }

        private PublisherSettings(PublisherSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTopicSettings = existing.CreateTopicSettings;
            UpdateTopicSettings = existing.UpdateTopicSettings;
            PublishSettings = existing.PublishSettings;
            GetTopicSettings = existing.GetTopicSettings;
            ListTopicsSettings = existing.ListTopicsSettings;
            ListTopicSubscriptionsSettings = existing.ListTopicSubscriptionsSettings;
            DeleteTopicSettings = existing.DeleteTopicSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublisherSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PublisherClient"/> RPC methods.
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
        /// for "OnePlusDelivery" <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "OnePlusDelivery" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="StatusCode.Unknown"/></description></item>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> OnePlusDeliveryRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Cancelled, StatusCode.Unknown, StatusCode.DeadlineExceeded, StatusCode.ResourceExhausted, StatusCode.Aborted, StatusCode.Internal, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PublisherClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PublisherClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods is defined as:
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
        /// "Messaging" retry backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" retry backoff for <see cref="PublisherClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" retry backoff for <see cref="PublisherClient"/> RPC methods is defined as:
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
        /// "Messaging" timeout backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" timeout backoff for <see cref="PublisherClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" timeout backoff for <see cref="PublisherClient"/> RPC methods is defined as:
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
        /// <c>PublisherClient.CreateTopic</c> and <c>PublisherClient.CreateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.CreateTopic</c> and
        /// <c>PublisherClient.CreateTopicAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTopicSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.UpdateTopic</c> and <c>PublisherClient.UpdateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.UpdateTopic</c> and
        /// <c>PublisherClient.UpdateTopicAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateTopicSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.Publish</c> and <c>PublisherClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.Publish</c> and
        /// <c>PublisherClient.PublishAsync</c> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="StatusCode.Unknown"/></description></item>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings PublishSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: OnePlusDeliveryRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.GetTopic</c> and <c>PublisherClient.GetTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.GetTopic</c> and
        /// <c>PublisherClient.GetTopicAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetTopicSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.ListTopics</c> and <c>PublisherClient.ListTopicsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.ListTopics</c> and
        /// <c>PublisherClient.ListTopicsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListTopicsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.ListTopicSubscriptions</c> and <c>PublisherClient.ListTopicSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.ListTopicSubscriptions</c> and
        /// <c>PublisherClient.ListTopicSubscriptionsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListTopicSubscriptionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.DeleteTopic</c> and <c>PublisherClient.DeleteTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.DeleteTopic</c> and
        /// <c>PublisherClient.DeleteTopicAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteTopicSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.SetIamPolicy</c> and <c>PublisherClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.SetIamPolicy</c> and
        /// <c>PublisherClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings SetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.GetIamPolicy</c> and <c>PublisherClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.GetIamPolicy</c> and
        /// <c>PublisherClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.TestIamPermissions</c> and <c>PublisherClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherClient.TestIamPermissions</c> and
        /// <c>PublisherClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings TestIamPermissionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="PublisherSettings"/> object.</returns>
        public PublisherSettings Clone() => new PublisherSettings(this);
    }

    /// <summary>
    /// Publisher client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PublisherClient
    {
        /// <summary>
        /// The default endpoint for the Publisher service, which is a host of "pubsub.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("pubsub.googleapis.com", 443);

        /// <summary>
        /// The default Publisher scopes.
        /// </summary>
        /// <remarks>
        /// The default Publisher scopes are:
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

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <returns>The task representing the created <see cref="PublisherClient"/>.</returns>
        public static async Task<PublisherClient> CreateAsync(ServiceEndpoint endpoint = null, PublisherSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PublisherClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient Create(ServiceEndpoint endpoint = null, PublisherSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PublisherClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient Create(Channel channel, PublisherSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(channel);
            return new PublisherClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, PublisherSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, PublisherSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, PublisherSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, PublisherSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Publisher client.
        /// </summary>
        public virtual Publisher.PublisherClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> CreateTopicAsync(
            TopicName name,
            CallSettings callSettings = null) => CreateTopicAsync(
                new Topic
                {
                    TopicName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> CreateTopicAsync(
            TopicName name,
            CancellationToken cancellationToken) => CreateTopicAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Topic CreateTopic(
            TopicName name,
            CallSettings callSettings = null) => CreateTopic(
                new Topic
                {
                    TopicName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> CreateTopicAsync(
            Topic request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Topic CreateTopic(
            Topic request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a topic are not
        /// modifiable.  Options settings follow the style guide:
        /// NOTE:  The style guide requires body: "topic" instead of body: "*".
        /// Keeping the latter for internal consistency in V1, however it should be
        /// corrected in V2.  See
        /// https://cloud.google.com/apis/design/standard_methods#update for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> UpdateTopicAsync(
            UpdateTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a topic are not
        /// modifiable.  Options settings follow the style guide:
        /// NOTE:  The style guide requires body: "topic" instead of body: "*".
        /// Keeping the latter for internal consistency in V1, however it should be
        /// corrected in V2.  See
        /// https://cloud.google.com/apis/design/standard_methods#update for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Topic UpdateTopic(
            UpdateTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">
        /// The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// The messages to publish.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PublishResponse> PublishAsync(
            TopicName topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null) => PublishAsync(
                new PublishRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    Messages = { GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">
        /// The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// The messages to publish.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PublishResponse> PublishAsync(
            TopicName topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken cancellationToken) => PublishAsync(
                topic,
                messages,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">
        /// The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// The messages to publish.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PublishResponse Publish(
            TopicName topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null) => Publish(
                new PublishRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    Messages = { GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PublishResponse> PublishAsync(
            PublishRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PublishResponse Publish(
            PublishRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> GetTopicAsync(
            TopicName topic,
            CallSettings callSettings = null) => GetTopicAsync(
                new GetTopicRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                },
                callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> GetTopicAsync(
            TopicName topic,
            CancellationToken cancellationToken) => GetTopicAsync(
                topic,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Topic GetTopic(
            TopicName topic,
            CallSettings callSettings = null) => GetTopic(
                new GetTopicRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                },
                callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Topic> GetTopicAsync(
            GetTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Topic GetTopic(
            GetTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that topics belong to.
        /// Format is `projects/{project}`.
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
        /// A pageable asynchronous sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTopicsAsync(
                new ListTopicsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that topics belong to.
        /// Format is `projects/{project}`.
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
        /// A pageable sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTopics(
                new ListTopicsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            ListTopicsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            ListTopicsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">
        /// The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            TopicName topic,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTopicSubscriptionsAsync(
                new ListTopicSubscriptionsRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">
        /// The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            TopicName topic,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTopicSubscriptions(
                new ListTopicSubscriptionsRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            ListTopicSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            ListTopicSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteTopicAsync(
            TopicName topic,
            CallSettings callSettings = null) => DeleteTopicAsync(
                new DeleteTopicRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                },
                callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteTopicAsync(
            TopicName topic,
            CancellationToken cancellationToken) => DeleteTopicAsync(
                topic,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteTopic(
            TopicName topic,
            CallSettings callSettings = null) => DeleteTopic(
                new DeleteTopicRequest
                {
                    TopicAsTopicName = GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                },
                callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteTopicAsync(
            DeleteTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteTopic(
            DeleteTopicRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => SetIamPolicyAsync(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy SetIamPolicy(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => SetIamPolicy(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null) => GetIamPolicyAsync(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null) => GetIamPolicy(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => TestIamPermissionsAsync(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => TestIamPermissions(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Publisher client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PublisherClientImpl : PublisherClient
    {
        private readonly ApiCall<Topic, Topic> _callCreateTopic;
        private readonly ApiCall<UpdateTopicRequest, Topic> _callUpdateTopic;
        private readonly ApiCall<PublishRequest, PublishResponse> _callPublish;
        private readonly ApiCall<GetTopicRequest, Topic> _callGetTopic;
        private readonly ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;
        private readonly ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> _callListTopicSubscriptions;
        private readonly ApiCall<DeleteTopicRequest, Empty> _callDeleteTopic;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Publisher service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherSettings"/> used within this client </param>
        public PublisherClientImpl(Publisher.PublisherClient grpcClient, PublisherSettings settings)
        {
            this.GrpcClient = grpcClient;
            PublisherSettings effectiveSettings = settings ?? PublisherSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            var grpcIAMPolicyClient = grpcClient.CreateIAMPolicyClient();
            _callCreateTopic = clientHelper.BuildApiCall<Topic, Topic>(
                GrpcClient.CreateTopicAsync, GrpcClient.CreateTopic, effectiveSettings.CreateTopicSettings);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>(
                GrpcClient.UpdateTopicAsync, GrpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>(
                GrpcClient.PublishAsync, GrpcClient.Publish, effectiveSettings.PublishSettings);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>(
                GrpcClient.GetTopicAsync, GrpcClient.GetTopic, effectiveSettings.GetTopicSettings);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>(
                GrpcClient.ListTopicsAsync, GrpcClient.ListTopics, effectiveSettings.ListTopicsSettings);
            _callListTopicSubscriptions = clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>(
                GrpcClient.ListTopicSubscriptionsAsync, GrpcClient.ListTopicSubscriptions, effectiveSettings.ListTopicSubscriptionsSettings);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, Empty>(
                GrpcClient.DeleteTopicAsync, GrpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                grpcIAMPolicyClient.SetIamPolicyAsync, grpcIAMPolicyClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                grpcIAMPolicyClient.GetIamPolicyAsync, grpcIAMPolicyClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                grpcIAMPolicyClient.TestIamPermissionsAsync, grpcIAMPolicyClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Publisher.PublisherClient grpcClient, PublisherSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Publisher client.
        /// </summary>
        public override Publisher.PublisherClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_Topic(ref Topic request, ref CallSettings settings);
        partial void Modify_UpdateTopicRequest(ref UpdateTopicRequest request, ref CallSettings settings);
        partial void Modify_PublishRequest(ref PublishRequest request, ref CallSettings settings);
        partial void Modify_GetTopicRequest(ref GetTopicRequest request, ref CallSettings settings);
        partial void Modify_ListTopicsRequest(ref ListTopicsRequest request, ref CallSettings settings);
        partial void Modify_ListTopicSubscriptionsRequest(ref ListTopicSubscriptionsRequest request, ref CallSettings settings);
        partial void Modify_DeleteTopicRequest(ref DeleteTopicRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Topic> CreateTopicAsync(
            Topic request,
            CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Topic CreateTopic(
            Topic request,
            CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a topic are not
        /// modifiable.  Options settings follow the style guide:
        /// NOTE:  The style guide requires body: "topic" instead of body: "*".
        /// Keeping the latter for internal consistency in V1, however it should be
        /// corrected in V2.  See
        /// https://cloud.google.com/apis/design/standard_methods#update for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Topic> UpdateTopicAsync(
            UpdateTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a topic are not
        /// modifiable.  Options settings follow the style guide:
        /// NOTE:  The style guide requires body: "topic" instead of body: "*".
        /// Keeping the latter for internal consistency in V1, however it should be
        /// corrected in V2.  See
        /// https://cloud.google.com/apis/design/standard_methods#update for details.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Topic UpdateTopic(
            UpdateTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<PublishResponse> PublishAsync(
            PublishRequest request,
            CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Async(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override PublishResponse Publish(
            PublishRequest request,
            CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Topic> GetTopicAsync(
            GetTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Topic GetTopic(
            GetTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Topic"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            ListTopicsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Topic"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            ListTopicsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            ListTopicSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, SubscriptionName>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            ListTopicSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, SubscriptionName>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteTopicAsync(
            DeleteTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            return _callDeleteTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteTopic(
            DeleteTopicRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            _callDeleteTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTopicsRequest : IPageRequest { }
    public partial class ListTopicsResponse : IPageResponse<Topic>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Topic> GetEnumerator() => Topics.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicSubscriptionsRequest : IPageRequest { }
    public partial class ListTopicSubscriptionsResponse : IPageResponse<SubscriptionName>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<SubscriptionName> GetEnumerator() => SubscriptionsAsSubscriptionNames.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
