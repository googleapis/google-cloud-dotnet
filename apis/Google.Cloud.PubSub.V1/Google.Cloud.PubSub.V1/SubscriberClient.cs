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
            UpdateSubscriptionSettings = existing.UpdateSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            ModifyAckDeadlineSettings = existing.ModifyAckDeadlineSettings;
            AcknowledgeSettings = existing.AcknowledgeSettings;
            PullSettings = existing.PullSettings;
            StreamingPullSettings = existing.StreamingPullSettings;
            StreamingPullStreamingSettings = existing.StreamingPullStreamingSettings;
            ModifyPushConfigSettings = existing.ModifyPushConfigSettings;
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            CreateSnapshotSettings = existing.CreateSnapshotSettings;
            UpdateSnapshotSettings = existing.UpdateSnapshotSettings;
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            SeekSettings = existing.SeekSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SubscriberSettings existing);

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
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Pull" <see cref="SubscriberClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Pull" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> PullRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Cancelled, StatusCode.DeadlineExceeded, StatusCode.ResourceExhausted, StatusCode.Internal, StatusCode.Unavailable);

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
        /// <c>SubscriberClient.UpdateSubscription</c> and <c>SubscriberClient.UpdateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.UpdateSubscription</c> and
        /// <c>SubscriberClient.UpdateSubscriptionAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateSubscriptionSettings { get; set; } = CallSettings.FromCallTiming(
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
        /// <item><description><see cref="StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings PullSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: PullRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for calls to <c>SubscriberClient.StreamingPull</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings StreamingPullSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromTimeout(TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="BidirectionalStreamingSettings"/> for calls to
        /// <c>SubscriberClient.StreamingPull</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public BidirectionalStreamingSettings StreamingPullStreamingSettings { get; set; } =
            new BidirectionalStreamingSettings(100);

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
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.ListSnapshots</c> and <c>SubscriberClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.ListSnapshots</c> and
        /// <c>SubscriberClient.ListSnapshotsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListSnapshotsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.CreateSnapshot</c> and <c>SubscriberClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.CreateSnapshot</c> and
        /// <c>SubscriberClient.CreateSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.UpdateSnapshot</c> and <c>SubscriberClient.UpdateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.UpdateSnapshot</c> and
        /// <c>SubscriberClient.UpdateSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.DeleteSnapshot</c> and <c>SubscriberClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.DeleteSnapshot</c> and
        /// <c>SubscriberClient.DeleteSnapshotAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteSnapshotSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.Seek</c> and <c>SubscriberClient.SeekAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.Seek</c> and
        /// <c>SubscriberClient.SeekAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings SeekSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberClient.SetIamPolicy</c> and <c>SubscriberClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.SetIamPolicy</c> and
        /// <c>SubscriberClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        /// <c>SubscriberClient.GetIamPolicy</c> and <c>SubscriberClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.GetIamPolicy</c> and
        /// <c>SubscriberClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        /// <c>SubscriberClient.TestIamPermissions</c> and <c>SubscriberClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberClient.TestIamPermissions</c> and
        /// <c>SubscriberClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
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
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        /// The name of the topic from which this subscription is receiving messages.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// The minimum custom deadline you can specify is 10 seconds.
        /// The maximum custom deadline you can specify is 600 seconds (10 minutes).
        /// If this parameter is 0, a default value of 10 seconds is used.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName name,
            TopicName topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            CallSettings callSettings = null) => CreateSubscriptionAsync(
                new Subscription
                {
                    SubscriptionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TopicAsTopicNameOneof = TopicNameOneof.From(GaxPreconditions.CheckNotNull(topic, nameof(topic))),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        /// The name of the topic from which this subscription is receiving messages.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// The minimum custom deadline you can specify is 10 seconds.
        /// The maximum custom deadline you can specify is 600 seconds (10 minutes).
        /// If this parameter is 0, a default value of 10 seconds is used.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName name,
            TopicName topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            CancellationToken cancellationToken) => CreateSubscriptionAsync(
                name,
                topic,
                pushConfig,
                ackDeadlineSeconds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        /// The name of the topic from which this subscription is receiving messages.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// The minimum custom deadline you can specify is 10 seconds.
        /// The maximum custom deadline you can specify is 600 seconds (10 minutes).
        /// If this parameter is 0, a default value of 10 seconds is used.
        ///
        /// For push delivery, this value is also used to set the request timeout for
        /// the call to the push endpoint.
        ///
        /// If the subscriber never acknowledges the message, the Pub/Sub
        /// system will eventually redeliver the message.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Subscription CreateSubscription(
            SubscriptionName name,
            TopicName topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            CallSettings callSettings = null) => CreateSubscription(
                new Subscription
                {
                    SubscriptionName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TopicAsTopicNameOneof = TopicNameOneof.From(GaxPreconditions.CheckNotNull(topic, nameof(topic))),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public virtual Task<Subscription> CreateSubscriptionAsync(
            Subscription request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public virtual Subscription CreateSubscription(
            Subscription request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription to get.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscription,
            CallSettings callSettings = null) => GetSubscriptionAsync(
                new GetSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription to get.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscription,
            CancellationToken cancellationToken) => GetSubscriptionAsync(
                subscription,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription to get.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Subscription GetSubscription(
            SubscriptionName subscription,
            CallSettings callSettings = null) => GetSubscription(
                new GetSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Gets the configuration details of a subscription.
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
        public virtual Task<Subscription> GetSubscriptionAsync(
            GetSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
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
        public virtual Subscription GetSubscription(
            GetSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
        /// NOTE:  The style guide requires body: "subscription" instead of body: "*".
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
        public virtual Task<Subscription> UpdateSubscriptionAsync(
            UpdateSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
        /// NOTE:  The style guide requires body: "subscription" instead of body: "*".
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
        public virtual Subscription UpdateSubscription(
            UpdateSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that subscriptions belong to.
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
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSubscriptionsAsync(
                new ListSubscriptionsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that subscriptions belong to.
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
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSubscriptions(
                new ListSubscriptionsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">
        /// The subscription to delete.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSubscriptionAsync(
            SubscriptionName subscription,
            CallSettings callSettings = null) => DeleteSubscriptionAsync(
                new DeleteSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">
        /// The subscription to delete.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSubscriptionAsync(
            SubscriptionName subscription,
            CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                subscription,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
        /// </summary>
        /// <param name="subscription">
        /// The subscription to delete.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSubscription(
            SubscriptionName subscription,
            CallSettings callSettings = null) => DeleteSubscription(
                new DeleteSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
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
        public virtual Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
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
        public virtual void DeleteSubscription(
            DeleteSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// List of acknowledgment IDs.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyAckDeadlineAsync(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => ModifyAckDeadlineAsync(
                new ModifyAckDeadlineRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// List of acknowledgment IDs.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyAckDeadlineAsync(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                subscription,
                ackIds,
                ackDeadlineSeconds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// List of acknowledgment IDs.
        /// </param>
        /// <param name="ackDeadlineSeconds">
        /// The new ack deadline with respect to the time this request was sent to
        /// the Pub/Sub system. For example, if the value is 10, the new
        /// ack deadline will expire 10 seconds after the `ModifyAckDeadline` call
        /// was made. Specifying zero may immediately make the message available for
        /// another pull request.
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void ModifyAckDeadline(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            CallSettings callSettings = null) => ModifyAckDeadline(
                new ModifyAckDeadlineRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
                    AckDeadlineSeconds = ackDeadlineSeconds,
                },
                callSettings);

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
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
        public virtual Task ModifyAckDeadlineAsync(
            ModifyAckDeadlineRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
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
        public virtual void ModifyAckDeadline(
            ModifyAckDeadlineRequest request,
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
        /// <param name="subscription">
        /// The subscription whose message is being acknowledged.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task AcknowledgeAsync(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => AcknowledgeAsync(
                new AcknowledgeRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// <param name="subscription">
        /// The subscription whose message is being acknowledged.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task AcknowledgeAsync(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            CancellationToken cancellationToken) => AcknowledgeAsync(
                subscription,
                ackIds,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acknowledges the messages associated with the `ack_ids` in the
        /// `AcknowledgeRequest`. The Pub/Sub system can remove the relevant messages
        /// from the subscription.
        ///
        /// Acknowledging a message whose ack deadline has expired may succeed,
        /// but such a message may be redelivered later. Acknowledging a message more
        /// than once will not result in an error.
        /// </summary>
        /// <param name="subscription">
        /// The subscription whose message is being acknowledged.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="ackIds">
        /// The acknowledgment ID for the messages being acknowledged that was returned
        /// by the Pub/Sub system in the `Pull` response. Must not be empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void Acknowledge(
            SubscriptionName subscription,
            IEnumerable<string> ackIds,
            CallSettings callSettings = null) => Acknowledge(
                new AcknowledgeRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task AcknowledgeAsync(
            AcknowledgeRequest request,
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void Acknowledge(
            AcknowledgeRequest request,
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
        /// <param name="subscription">
        /// The subscription from which messages should be pulled.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="returnImmediately">
        /// If this field set to true, the system will respond immediately even if
        /// it there are no messages available to return in the `Pull` response.
        /// Otherwise, the system may wait (for a bounded amount of time) until at
        /// least one message is available, rather than returning no messages. The
        /// client may cancel the request if it does not wish to wait any longer for
        /// the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PullResponse> PullAsync(
            SubscriptionName subscription,
            bool? returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => PullAsync(
                new PullRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">
        /// The subscription from which messages should be pulled.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="returnImmediately">
        /// If this field set to true, the system will respond immediately even if
        /// it there are no messages available to return in the `Pull` response.
        /// Otherwise, the system may wait (for a bounded amount of time) until at
        /// least one message is available, rather than returning no messages. The
        /// client may cancel the request if it does not wish to wait any longer for
        /// the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<PullResponse> PullAsync(
            SubscriptionName subscription,
            bool? returnImmediately,
            int maxMessages,
            CancellationToken cancellationToken) => PullAsync(
                subscription,
                returnImmediately,
                maxMessages,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="subscription">
        /// The subscription from which messages should be pulled.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="returnImmediately">
        /// If this field set to true, the system will respond immediately even if
        /// it there are no messages available to return in the `Pull` response.
        /// Otherwise, the system may wait (for a bounded amount of time) until at
        /// least one message is available, rather than returning no messages. The
        /// client may cancel the request if it does not wish to wait any longer for
        /// the response.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages returned for this request. The Pub/Sub
        /// system may return fewer than the number specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PullResponse Pull(
            SubscriptionName subscription,
            bool? returnImmediately,
            int maxMessages,
            CallSettings callSettings = null) => Pull(
                new PullRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
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
        public virtual Task<PullResponse> PullAsync(
            PullRequest request,
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PullResponse Pull(
            PullRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// (EXPERIMENTAL) StreamingPull is an experimental feature. This RPC will
        /// respond with UNIMPLEMENTED errors unless you have been invited to test
        /// this feature. Contact cloud-pubsub@google.com with any questions.
        ///
        /// Establishes a stream with the server, which sends messages down to the
        /// client. The client streams acknowledgements and ack deadline modifications
        /// back to the server. The server will close the stream and return the status
        /// on any error. The server may close the stream with status `OK` to reassign
        /// server-side resources, in which case, the client should re-establish the
        /// stream. `UNAVAILABLE` may also be returned in the case of a transient error
        /// (e.g., a server restart). These should also be retried by the client. Flow
        /// control can be achieved by configuring the underlying RPC channel.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public virtual StreamingPullStream StreamingPull(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingPull</c>.
        /// </summary>
        public abstract class StreamingPullStream : BidirectionalStreamingBase<StreamingPullRequest, StreamingPullResponse>
        {
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyPushConfigAsync(
            SubscriptionName subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null) => ModifyPushConfigAsync(
                new ModifyPushConfigRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    PushConfig = GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyPushConfigAsync(
            SubscriptionName subscription,
            PushConfig pushConfig,
            CancellationToken cancellationToken) => ModifyPushConfigAsync(
                subscription,
                pushConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
        /// </summary>
        /// <param name="subscription">
        /// The name of the subscription.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="pushConfig">
        /// The push configuration for future deliveries.
        ///
        /// An empty `pushConfig` indicates that the Pub/Sub system should
        /// stop pushing messages from the given subscription and allow
        /// messages to be pulled and acknowledged - effectively pausing
        /// the subscription if `Pull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void ModifyPushConfig(
            SubscriptionName subscription,
            PushConfig pushConfig,
            CallSettings callSettings = null) => ModifyPushConfig(
                new ModifyPushConfigRequest
                {
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    PushConfig = GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task ModifyPushConfigAsync(
            ModifyPushConfigRequest request,
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void ModifyPushConfig(
            ModifyPushConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that snapshots belong to.
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
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="project">
        /// The name of the cloud project that snapshots belong to.
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
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    ProjectAsProjectName = GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="subscription">
        /// The subscription whose backlog the snapshot retains.
        /// Specifically, the created snapshot is guaranteed to retain:
        ///  (a) The existing backlog on the subscription. More precisely, this is
        ///      defined as the messages in the subscription's backlog that are
        ///      unacknowledged upon the successful completion of the
        ///      `CreateSnapshot` request; as well as:
        ///  (b) Any messages published to the subscription's topic following the
        ///      successful completion of the CreateSnapshot request.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Snapshot> CreateSnapshotAsync(
            SnapshotName name,
            SubscriptionName subscription,
            CallSettings callSettings = null) => CreateSnapshotAsync(
                new CreateSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="subscription">
        /// The subscription whose backlog the snapshot retains.
        /// Specifically, the created snapshot is guaranteed to retain:
        ///  (a) The existing backlog on the subscription. More precisely, this is
        ///      defined as the messages in the subscription's backlog that are
        ///      unacknowledged upon the successful completion of the
        ///      `CreateSnapshot` request; as well as:
        ///  (b) Any messages published to the subscription's topic following the
        ///      successful completion of the CreateSnapshot request.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Snapshot> CreateSnapshotAsync(
            SnapshotName name,
            SubscriptionName subscription,
            CancellationToken cancellationToken) => CreateSnapshotAsync(
                name,
                subscription,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="subscription">
        /// The subscription whose backlog the snapshot retains.
        /// Specifically, the created snapshot is guaranteed to retain:
        ///  (a) The existing backlog on the subscription. More precisely, this is
        ///      defined as the messages in the subscription's backlog that are
        ///      unacknowledged upon the successful completion of the
        ///      `CreateSnapshot` request; as well as:
        ///  (b) Any messages published to the subscription's topic following the
        ///      successful completion of the CreateSnapshot request.
        /// Format is `projects/{project}/subscriptions/{sub}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Snapshot CreateSnapshot(
            SnapshotName name,
            SubscriptionName subscription,
            CallSettings callSettings = null) => CreateSnapshot(
                new CreateSnapshotRequest
                {
                    SnapshotName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    SubscriptionAsSubscriptionName = GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public virtual Task<Snapshot> CreateSnapshotAsync(
            CreateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public virtual Snapshot CreateSnapshot(
            CreateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing snapshot. Note that certain properties of a snapshot
        /// are not modifiable.
        /// NOTE:  The style guide requires body: "snapshot" instead of body: "*".
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
        public virtual Task<Snapshot> UpdateSnapshotAsync(
            UpdateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an existing snapshot. Note that certain properties of a snapshot
        /// are not modifiable.
        /// NOTE:  The style guide requires body: "snapshot" instead of body: "*".
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
        public virtual Snapshot UpdateSnapshot(
            UpdateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="snapshot">
        /// The name of the snapshot to delete.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSnapshotAsync(
            SnapshotName snapshot,
            CallSettings callSettings = null) => DeleteSnapshotAsync(
                new DeleteSnapshotRequest
                {
                    SnapshotAsSnapshotName = GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="snapshot">
        /// The name of the snapshot to delete.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteSnapshotAsync(
            SnapshotName snapshot,
            CancellationToken cancellationToken) => DeleteSnapshotAsync(
                snapshot,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="snapshot">
        /// The name of the snapshot to delete.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteSnapshot(
            SnapshotName snapshot,
            CallSettings callSettings = null) => DeleteSnapshot(
                new DeleteSnapshotRequest
                {
                    SnapshotAsSnapshotName = GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
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
        public virtual Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
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
        public virtual void DeleteSnapshot(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request.
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
        public virtual Task<SeekResponse> SeekAsync(
            SeekRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request.
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
        public virtual SeekResponse Seek(
            SeekRequest request,
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
    /// Subscriber client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SubscriberClientImpl : SubscriberClient
    {
        private readonly ApiCall<Subscription, Subscription> _callCreateSubscription;
        private readonly ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;
        private readonly ApiCall<UpdateSubscriptionRequest, Subscription> _callUpdateSubscription;
        private readonly ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;
        private readonly ApiCall<DeleteSubscriptionRequest, Empty> _callDeleteSubscription;
        private readonly ApiCall<ModifyAckDeadlineRequest, Empty> _callModifyAckDeadline;
        private readonly ApiCall<AcknowledgeRequest, Empty> _callAcknowledge;
        private readonly ApiCall<PullRequest, PullResponse> _callPull;
        private readonly ApiBidirectionalStreamingCall<StreamingPullRequest, StreamingPullResponse> _callStreamingPull;
        private readonly ApiCall<ModifyPushConfigRequest, Empty> _callModifyPushConfig;
        private readonly ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;
        private readonly ApiCall<CreateSnapshotRequest, Snapshot> _callCreateSnapshot;
        private readonly ApiCall<UpdateSnapshotRequest, Snapshot> _callUpdateSnapshot;
        private readonly ApiCall<DeleteSnapshotRequest, Empty> _callDeleteSnapshot;
        private readonly ApiCall<SeekRequest, SeekResponse> _callSeek;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Subscriber service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SubscriberSettings"/> used within this client </param>
        public SubscriberClientImpl(Subscriber.SubscriberClient grpcClient, SubscriberSettings settings)
        {
            this.GrpcClient = grpcClient;
            SubscriberSettings effectiveSettings = settings ?? SubscriberSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            var grpcIAMPolicyClient = grpcClient.CreateIAMPolicyClient();
            _callCreateSubscription = clientHelper.BuildApiCall<Subscription, Subscription>(
                GrpcClient.CreateSubscriptionAsync, GrpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings);
            _callGetSubscription = clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>(
                GrpcClient.GetSubscriptionAsync, GrpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings);
            _callUpdateSubscription = clientHelper.BuildApiCall<UpdateSubscriptionRequest, Subscription>(
                GrpcClient.UpdateSubscriptionAsync, GrpcClient.UpdateSubscription, effectiveSettings.UpdateSubscriptionSettings);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>(
                GrpcClient.ListSubscriptionsAsync, GrpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, Empty>(
                GrpcClient.DeleteSubscriptionAsync, GrpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings);
            _callModifyAckDeadline = clientHelper.BuildApiCall<ModifyAckDeadlineRequest, Empty>(
                GrpcClient.ModifyAckDeadlineAsync, GrpcClient.ModifyAckDeadline, effectiveSettings.ModifyAckDeadlineSettings);
            _callAcknowledge = clientHelper.BuildApiCall<AcknowledgeRequest, Empty>(
                GrpcClient.AcknowledgeAsync, GrpcClient.Acknowledge, effectiveSettings.AcknowledgeSettings);
            _callPull = clientHelper.BuildApiCall<PullRequest, PullResponse>(
                GrpcClient.PullAsync, GrpcClient.Pull, effectiveSettings.PullSettings);
            _callStreamingPull = clientHelper.BuildApiCall<StreamingPullRequest, StreamingPullResponse>(
                GrpcClient.StreamingPull, effectiveSettings.StreamingPullSettings, effectiveSettings.StreamingPullStreamingSettings);
            _callModifyPushConfig = clientHelper.BuildApiCall<ModifyPushConfigRequest, Empty>(
                GrpcClient.ModifyPushConfigAsync, GrpcClient.ModifyPushConfig, effectiveSettings.ModifyPushConfigSettings);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(
                GrpcClient.ListSnapshotsAsync, GrpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotRequest, Snapshot>(
                GrpcClient.CreateSnapshotAsync, GrpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings);
            _callUpdateSnapshot = clientHelper.BuildApiCall<UpdateSnapshotRequest, Snapshot>(
                GrpcClient.UpdateSnapshotAsync, GrpcClient.UpdateSnapshot, effectiveSettings.UpdateSnapshotSettings);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, Empty>(
                GrpcClient.DeleteSnapshotAsync, GrpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings);
            _callSeek = clientHelper.BuildApiCall<SeekRequest, SeekResponse>(
                GrpcClient.SeekAsync, GrpcClient.Seek, effectiveSettings.SeekSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                grpcIAMPolicyClient.SetIamPolicyAsync, grpcIAMPolicyClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                grpcIAMPolicyClient.GetIamPolicyAsync, grpcIAMPolicyClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                grpcIAMPolicyClient.TestIamPermissionsAsync, grpcIAMPolicyClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Subscriber.SubscriberClient grpcClient, SubscriberSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Subscriber client.
        /// </summary>
        public override Subscriber.SubscriberClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_Subscription(ref Subscription request, ref CallSettings settings);
        partial void Modify_GetSubscriptionRequest(ref GetSubscriptionRequest request, ref CallSettings settings);
        partial void Modify_UpdateSubscriptionRequest(ref UpdateSubscriptionRequest request, ref CallSettings settings);
        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref CallSettings settings);
        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref CallSettings settings);
        partial void Modify_ModifyAckDeadlineRequest(ref ModifyAckDeadlineRequest request, ref CallSettings settings);
        partial void Modify_AcknowledgeRequest(ref AcknowledgeRequest request, ref CallSettings settings);
        partial void Modify_PullRequest(ref PullRequest request, ref CallSettings settings);
        partial void Modify_StreamingPullRequestCallSettings(ref CallSettings settings);
        partial void Modify_StreamingPullRequestRequest(ref StreamingPullRequest request);
        partial void Modify_ModifyPushConfigRequest(ref ModifyPushConfigRequest request, ref CallSettings settings);
        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref CallSettings settings);
        partial void Modify_CreateSnapshotRequest(ref CreateSnapshotRequest request, ref CallSettings settings);
        partial void Modify_UpdateSnapshotRequest(ref UpdateSnapshotRequest request, ref CallSettings settings);
        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref CallSettings settings);
        partial void Modify_SeekRequest(ref SeekRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public override Task<Subscription> CreateSubscriptionAsync(
            Subscription request,
            CallSettings callSettings = null)
        {
            Modify_Subscription(ref request, ref callSettings);
            return _callCreateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a subscription to a given topic.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Subscription object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public override Subscription CreateSubscription(
            Subscription request,
            CallSettings callSettings = null)
        {
            Modify_Subscription(ref request, ref callSettings);
            return _callCreateSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
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
        public override Task<Subscription> GetSubscriptionAsync(
            GetSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
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
        public override Subscription GetSubscription(
            GetSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
        /// NOTE:  The style guide requires body: "subscription" instead of body: "*".
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
        public override Task<Subscription> UpdateSubscriptionAsync(
            UpdateSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
        /// NOTE:  The style guide requires body: "subscription" instead of body: "*".
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
        public override Subscription UpdateSubscription(
            UpdateSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Subscription"/> resources.
        /// </returns>
        public override PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
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
        public override Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing subscription. All messages retained in the subscription
        /// are immediately dropped. Calls to `Pull` after deletion will return
        /// `NOT_FOUND`. After a subscription is deleted, a new one may be created with
        /// the same name, but the new one has no association with the old
        /// subscription or its topic unless the same topic is specified.
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
        public override void DeleteSubscription(
            DeleteSubscriptionRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            _callDeleteSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
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
        public override Task ModifyAckDeadlineAsync(
            ModifyAckDeadlineRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyAckDeadlineRequest(ref request, ref callSettings);
            return _callModifyAckDeadline.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies the ack deadline for a specific message. This method is useful
        /// to indicate that more time is needed to process a message by the
        /// subscriber, or to make the message available for redelivery if the
        /// processing was interrupted. Note that this does not modify the
        /// subscription-level `ackDeadlineSeconds` used for subsequent messages.
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
        public override void ModifyAckDeadline(
            ModifyAckDeadlineRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyAckDeadlineRequest(ref request, ref callSettings);
            _callModifyAckDeadline.Sync(request, callSettings);
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task AcknowledgeAsync(
            AcknowledgeRequest request,
            CallSettings callSettings = null)
        {
            Modify_AcknowledgeRequest(ref request, ref callSettings);
            return _callAcknowledge.Async(request, callSettings);
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void Acknowledge(
            AcknowledgeRequest request,
            CallSettings callSettings = null)
        {
            Modify_AcknowledgeRequest(ref request, ref callSettings);
            _callAcknowledge.Sync(request, callSettings);
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
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
        public override Task<PullResponse> PullAsync(
            PullRequest request,
            CallSettings callSettings = null)
        {
            Modify_PullRequest(ref request, ref callSettings);
            return _callPull.Async(request, callSettings);
        }

        /// <summary>
        /// Pulls messages from the server. Returns an empty list if there are no
        /// messages available in the backlog. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
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
        public override PullResponse Pull(
            PullRequest request,
            CallSettings callSettings = null)
        {
            Modify_PullRequest(ref request, ref callSettings);
            return _callPull.Sync(request, callSettings);
        }

        /// <summary>
        /// (EXPERIMENTAL) StreamingPull is an experimental feature. This RPC will
        /// respond with UNIMPLEMENTED errors unless you have been invited to test
        /// this feature. Contact cloud-pubsub@google.com with any questions.
        ///
        /// Establishes a stream with the server, which sends messages down to the
        /// client. The client streams acknowledgements and ack deadline modifications
        /// back to the server. The server will close the stream and return the status
        /// on any error. The server may close the stream with status `OK` to reassign
        /// server-side resources, in which case, the client should re-establish the
        /// stream. `UNAVAILABLE` may also be returned in the case of a transient error
        /// (e.g., a server restart). These should also be retried by the client. Flow
        /// control can be achieved by configuring the underlying RPC channel.
        /// </summary>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <param name="streamingSettings">
        /// If not null, applies streaming overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The client-server stream.
        /// </returns>
        public override StreamingPullStream StreamingPull(
            CallSettings callSettings = null,
            BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingPullRequestCallSettings(ref callSettings);
            BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callStreamingPull.StreamingSettings;
            AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> call =
                _callStreamingPull.Call(callSettings);
            BufferedClientStreamWriter<StreamingPullRequest> writeBuffer =
                new BufferedClientStreamWriter<StreamingPullRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingPullStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingPull</c>.
        /// </summary>
        public sealed class StreamingPullStreamImpl : StreamingPullStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamingPull</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="BufferedClientStreamWriter{StreamingPullRequest}"/>
            /// instance associated with this streaming call.</param>
            public StreamingPullStreamImpl(
                SubscriberClientImpl service,
                AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> call,
                BufferedClientStreamWriter<StreamingPullRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SubscriberClientImpl _service;
            private BufferedClientStreamWriter<StreamingPullRequest> _writeBuffer;

            private StreamingPullRequest ModifyRequest(StreamingPullRequest request)
            {
                _service.Modify_StreamingPullRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override Task TryWriteAsync(StreamingPullRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task WriteAsync(StreamingPullRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override Task TryWriteAsync(StreamingPullRequest message, WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task WriteAsync(StreamingPullRequest message, WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();

            /// <inheritdoc/>
            public override IAsyncEnumerator<StreamingPullResponse> ResponseStream =>
                GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
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
        public override Task ModifyPushConfigAsync(
            ModifyPushConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyPushConfigRequest(ref request, ref callSettings);
            return _callModifyPushConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies the `PushConfig` for a specified subscription.
        ///
        /// This may be used to change a push subscription to a pull one (signified by
        /// an empty `PushConfig`) or vice versa, or change the endpoint URL and other
        /// attributes of a push subscription. Messages will accumulate for delivery
        /// continuously through the call regardless of changes to the `PushConfig`.
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
        public override void ModifyPushConfig(
            ModifyPushConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_ModifyPushConfigRequest(ref request, ref callSettings);
            _callModifyPushConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Lists the existing snapshots.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Snapshot"/> resources.
        /// </returns>
        public override PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public override Task<Snapshot> CreateSnapshotAsync(
            CreateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return _callCreateSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription.
        /// If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name format](https://cloud.google.com/pubsub/docs/overview#names).
        /// The generated name is populated in the returned Snapshot object.
        /// Note that for REST API requests, you must specify a name in the request.
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
        public override Snapshot CreateSnapshot(
            CreateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return _callCreateSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing snapshot. Note that certain properties of a snapshot
        /// are not modifiable.
        /// NOTE:  The style guide requires body: "snapshot" instead of body: "*".
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
        public override Task<Snapshot> UpdateSnapshotAsync(
            UpdateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return _callUpdateSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing snapshot. Note that certain properties of a snapshot
        /// are not modifiable.
        /// NOTE:  The style guide requires body: "snapshot" instead of body: "*".
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
        public override Snapshot UpdateSnapshot(
            UpdateSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return _callUpdateSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
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
        public override Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Removes an existing snapshot. All messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
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
        public override void DeleteSnapshot(
            DeleteSnapshotRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            _callDeleteSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request.
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
        public override Task<SeekResponse> SeekAsync(
            SeekRequest request,
            CallSettings callSettings = null)
        {
            Modify_SeekRequest(ref request, ref callSettings);
            return _callSeek.Async(request, callSettings);
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request.
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
        public override SeekResponse Seek(
            SeekRequest request,
            CallSettings callSettings = null)
        {
            Modify_SeekRequest(ref request, ref callSettings);
            return _callSeek.Sync(request, callSettings);
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

    public partial class ListSnapshotsRequest : IPageRequest { }
    public partial class ListSnapshotsResponse : IPageResponse<Snapshot>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
