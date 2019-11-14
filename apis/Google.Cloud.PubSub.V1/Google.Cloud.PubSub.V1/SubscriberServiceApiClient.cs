// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxres = Google.Api.Gax.ResourceNames;
using iam = Google.Cloud.Iam.V1;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>
    /// Settings for a <see cref="SubscriberServiceApiClient"/>.
    /// </summary>
    public sealed partial class SubscriberServiceApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SubscriberServiceApiSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SubscriberServiceApiSettings"/>.
        /// </returns>
        public static SubscriberServiceApiSettings GetDefault() => new SubscriberServiceApiSettings();

        /// <summary>
        /// Constructs a new <see cref="SubscriberServiceApiSettings"/> object with default settings.
        /// </summary>
        public SubscriberServiceApiSettings() { }

        private SubscriberServiceApiSettings(SubscriberServiceApiSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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

        partial void OnCopy(SubscriberServiceApiSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "StreamingPull" <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "StreamingPull" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> StreamingPullRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// "Messaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetMessagingRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Messaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 5000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.3</description></item>
        /// <item><description>Maximum timeout: 600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetMessagingTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(600000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "StreamingMessaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "StreamingMessaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "StreamingMessaging" retry backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetStreamingMessagingRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "StreamingMessaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "StreamingMessaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "StreamingMessaging" timeout backoff for <see cref="SubscriberServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetStreamingMessagingTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.CreateSubscription</c> and <c>SubscriberServiceApiClient.CreateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.CreateSubscription</c> and
        /// <c>SubscriberServiceApiClient.CreateSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.GetSubscription</c> and <c>SubscriberServiceApiClient.GetSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.GetSubscription</c> and
        /// <c>SubscriberServiceApiClient.GetSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.UpdateSubscription</c> and <c>SubscriberServiceApiClient.UpdateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.UpdateSubscription</c> and
        /// <c>SubscriberServiceApiClient.UpdateSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.ListSubscriptions</c> and <c>SubscriberServiceApiClient.ListSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.ListSubscriptions</c> and
        /// <c>SubscriberServiceApiClient.ListSubscriptionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSubscriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.DeleteSubscription</c> and <c>SubscriberServiceApiClient.DeleteSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.DeleteSubscription</c> and
        /// <c>SubscriberServiceApiClient.DeleteSubscriptionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.ModifyAckDeadline</c> and <c>SubscriberServiceApiClient.ModifyAckDeadlineAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.ModifyAckDeadline</c> and
        /// <c>SubscriberServiceApiClient.ModifyAckDeadlineAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ModifyAckDeadlineSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.Acknowledge</c> and <c>SubscriberServiceApiClient.AcknowledgeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.Acknowledge</c> and
        /// <c>SubscriberServiceApiClient.AcknowledgeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 5000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.3</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings AcknowledgeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.Pull</c> and <c>SubscriberServiceApiClient.PullAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.Pull</c> and
        /// <c>SubscriberServiceApiClient.PullAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 5000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.3</description></item>
        /// <item><description>Timeout maximum delay: 600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PullSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>SubscriberServiceApiClient.StreamingPull</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StreamingPullSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>SubscriberServiceApiClient.StreamingPull</c>.
        /// </summary>
        /// <remarks>
        /// The default local send queue size is 100.
        /// </remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingPullStreamingSettings { get; set; } =
            new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.ModifyPushConfig</c> and <c>SubscriberServiceApiClient.ModifyPushConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.ModifyPushConfig</c> and
        /// <c>SubscriberServiceApiClient.ModifyPushConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ModifyPushConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.ListSnapshots</c> and <c>SubscriberServiceApiClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.ListSnapshots</c> and
        /// <c>SubscriberServiceApiClient.ListSnapshotsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.CreateSnapshot</c> and <c>SubscriberServiceApiClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.CreateSnapshot</c> and
        /// <c>SubscriberServiceApiClient.CreateSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.UpdateSnapshot</c> and <c>SubscriberServiceApiClient.UpdateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.UpdateSnapshot</c> and
        /// <c>SubscriberServiceApiClient.UpdateSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.DeleteSnapshot</c> and <c>SubscriberServiceApiClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.DeleteSnapshot</c> and
        /// <c>SubscriberServiceApiClient.DeleteSnapshotAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.Seek</c> and <c>SubscriberServiceApiClient.SeekAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.Seek</c> and
        /// <c>SubscriberServiceApiClient.SeekAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SeekSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.SetIamPolicy</c> and <c>SubscriberServiceApiClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.SetIamPolicy</c> and
        /// <c>SubscriberServiceApiClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.GetIamPolicy</c> and <c>SubscriberServiceApiClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.GetIamPolicy</c> and
        /// <c>SubscriberServiceApiClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceApiClient.TestIamPermissions</c> and <c>SubscriberServiceApiClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SubscriberServiceApiClient.TestIamPermissions</c> and
        /// <c>SubscriberServiceApiClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SubscriberServiceApiSettings"/> object.</returns>
        public SubscriberServiceApiSettings Clone() => new SubscriberServiceApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SubscriberServiceApiClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SubscriberServiceApiClientBuilder : gaxgrpc::ClientBuilderBase<SubscriberServiceApiClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public SubscriberServiceApiSettings Settings { get; set; }

        /// <inheritdoc/>
        public override SubscriberServiceApiClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SubscriberServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<SubscriberServiceApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SubscriberServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => SubscriberServiceApiClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SubscriberServiceApiClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => SubscriberServiceApiClient.ChannelPool;
    }

    /// <summary>
    /// Subscriber client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SubscriberServiceApiClient
    {
        /// <summary>
        /// The default endpoint for the Subscriber service, which is a host of "pubsub.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("pubsub.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/pubsub",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="SubscriberServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.PubSub.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SubscriberServiceApiClient client = await SubscriberServiceApiClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.PubSub.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SubscriberServiceApiClient.DefaultEndpoint.Host, SubscriberServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SubscriberServiceApiClient client = SubscriberServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SubscriberServiceApiSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SubscriberServiceApiClient"/>.</returns>
        public static async stt::Task<SubscriberServiceApiClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SubscriberServiceApiSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SubscriberServiceApiClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.PubSub.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SubscriberServiceApiClient client = SubscriberServiceApiClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.PubSub.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SubscriberServiceApiClient.DefaultEndpoint.Host, SubscriberServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SubscriberServiceApiClient client = SubscriberServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SubscriberServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberServiceApiClient"/>.</returns>
        public static SubscriberServiceApiClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SubscriberServiceApiSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SubscriberServiceApiClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SubscriberServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberServiceApiClient"/>.</returns>
        public static SubscriberServiceApiClient Create(grpccore::Channel channel, SubscriberServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SubscriberServiceApiClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SubscriberServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberServiceApiClient"/>.</returns>
        public static SubscriberServiceApiClient Create(grpccore::CallInvoker callInvoker, SubscriberServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Subscriber.SubscriberClient grpcClient = new Subscriber.SubscriberClient(callInvoker);
            return new SubscriberServiceApiClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SubscriberServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SubscriberServiceApiSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SubscriberServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SubscriberServiceApiSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Subscriber client.
        /// </summary>
        public virtual Subscriber.SubscriberClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName name,
            TopicName topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => CreateSubscriptionAsync(
                new Subscription
                {
                    SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TopicAsTopicNameOneof = TopicNameOneof.From(gax::GaxPreconditions.CheckNotNull(topic, nameof(topic))),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            SubscriptionName name,
            TopicName topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            st::CancellationToken cancellationToken) => CreateSubscriptionAsync(
                name,
                topic,
                pushConfig,
                ackDeadlineSeconds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
            gaxgrpc::CallSettings callSettings = null) => CreateSubscription(
                new Subscription
                {
                    SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TopicAsTopicNameOneof = TopicNameOneof.From(gax::GaxPreconditions.CheckNotNull(topic, nameof(topic))),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => CreateSubscriptionAsync(
                new Subscription
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            string name,
            string topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            st::CancellationToken cancellationToken) => CreateSubscriptionAsync(
                name,
                topic,
                pushConfig,
                ackDeadlineSeconds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must
        /// start with a letter, and contain only letters (`[A-Za-z]`), numbers
        /// (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters
        /// in length, and it must not start with `"goog"`
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
        /// The approximate amount of time (on a best-effort basis) Pub/Sub waits for
        /// the subscriber to acknowledge receipt before resending the message. In the
        /// interval after the message is delivered and before it is acknowledged, it
        /// is considered to be &lt;i&gt;outstanding&lt;/i&gt;. During that time period, the
        /// message will not be redelivered (on a best-effort basis).
        ///
        /// For pull subscriptions, this value is used as the initial value for the ack
        /// deadline. To override this value for a given message, call
        /// `ModifyAckDeadline` with the corresponding `ack_id` if using
        /// non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull.
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
            string name,
            string topic,
            PushConfig pushConfig,
            int? ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => CreateSubscription(
                new Subscription
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    PushConfig = pushConfig, // Optional
                    AckDeadlineSeconds = ackDeadlineSeconds ?? 0, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
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
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            Subscription request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(
            Subscription request,
            st::CancellationToken cancellationToken) => CreateSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscription,
            gaxgrpc::CallSettings callSettings = null) => GetSubscriptionAsync(
                new GetSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            SubscriptionName subscription,
            st::CancellationToken cancellationToken) => GetSubscriptionAsync(
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetSubscription(
                new GetSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

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
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => GetSubscriptionAsync(
                new GetSubscriptionRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            string subscription,
            st::CancellationToken cancellationToken) => GetSubscriptionAsync(
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => GetSubscription(
                new GetSubscriptionRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
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
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            GetSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration details of a subscription.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(
            GetSubscriptionRequest request,
            st::CancellationToken cancellationToken) => GetSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
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
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(
            UpdateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(
            UpdateSubscriptionRequest request,
            st::CancellationToken cancellationToken) => UpdateSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list subscriptions.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptionsAsync(
                new ListSubscriptionsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list subscriptions.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptions(
                new ListSubscriptionsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list subscriptions.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptionsAsync(
                new ListSubscriptionsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching subscriptions.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list subscriptions.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSubscriptions(
                new ListSubscriptionsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
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
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            SubscriptionName subscription,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscriptionAsync(
                new DeleteSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            SubscriptionName subscription,
            st::CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteSubscription(
            SubscriptionName subscription,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscription(
                new DeleteSubscriptionRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscriptionAsync(
                new DeleteSubscriptionRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            string subscription,
            st::CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteSubscription(
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => DeleteSubscription(
                new DeleteSubscriptionRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            st::CancellationToken cancellationToken) => DeleteSubscriptionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteSubscription(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => ModifyAckDeadlineAsync(
                new ModifyAckDeadlineRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            st::CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                subscription,
                ackIds,
                ackDeadlineSeconds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void ModifyAckDeadline(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => ModifyAckDeadline(
                new ModifyAckDeadlineRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            string subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => ModifyAckDeadlineAsync(
                new ModifyAckDeadlineRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            string subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            st::CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                subscription,
                ackIds,
                ackDeadlineSeconds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// was made. Specifying zero might immediately make the message available for
        /// delivery to another subscriber client. This typically results in an
        /// increase in the rate of message redeliveries (that is, duplicates).
        /// The minimum deadline you can specify is 0 seconds.
        /// The maximum deadline you can specify is 600 seconds (10 minutes).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void ModifyAckDeadline(
            string subscription,
            scg::IEnumerable<string> ackIds,
            int ackDeadlineSeconds,
            gaxgrpc::CallSettings callSettings = null) => ModifyAckDeadline(
                new ModifyAckDeadlineRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            ModifyAckDeadlineRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyAckDeadlineAsync(
            ModifyAckDeadlineRequest request,
            st::CancellationToken cancellationToken) => ModifyAckDeadlineAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void ModifyAckDeadline(
            ModifyAckDeadlineRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            gaxgrpc::CallSettings callSettings = null) => AcknowledgeAsync(
                new AcknowledgeRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            st::CancellationToken cancellationToken) => AcknowledgeAsync(
                subscription,
                ackIds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void Acknowledge(
            SubscriptionName subscription,
            scg::IEnumerable<string> ackIds,
            gaxgrpc::CallSettings callSettings = null) => Acknowledge(
                new AcknowledgeRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            string subscription,
            scg::IEnumerable<string> ackIds,
            gaxgrpc::CallSettings callSettings = null) => AcknowledgeAsync(
                new AcknowledgeRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            string subscription,
            scg::IEnumerable<string> ackIds,
            st::CancellationToken cancellationToken) => AcknowledgeAsync(
                subscription,
                ackIds,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void Acknowledge(
            string subscription,
            scg::IEnumerable<string> ackIds,
            gaxgrpc::CallSettings callSettings = null) => Acknowledge(
                new AcknowledgeRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    AckIds = { gax::GaxPreconditions.CheckNotNull(ackIds, nameof(ackIds)) },
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            AcknowledgeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task AcknowledgeAsync(
            AcknowledgeRequest request,
            st::CancellationToken cancellationToken) => AcknowledgeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void Acknowledge(
            AcknowledgeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PullResponse> PullAsync(
            SubscriptionName subscription,
            bool? returnImmediately,
            int maxMessages,
            gaxgrpc::CallSettings callSettings = null) => PullAsync(
                new PullRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PullResponse> PullAsync(
            SubscriptionName subscription,
            bool? returnImmediately,
            int maxMessages,
            st::CancellationToken cancellationToken) => PullAsync(
                subscription,
                returnImmediately,
                maxMessages,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
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
            gaxgrpc::CallSettings callSettings = null) => Pull(
                new PullRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PullResponse> PullAsync(
            string subscription,
            bool? returnImmediately,
            int maxMessages,
            gaxgrpc::CallSettings callSettings = null) => PullAsync(
                new PullRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PullResponse> PullAsync(
            string subscription,
            bool? returnImmediately,
            int maxMessages,
            st::CancellationToken cancellationToken) => PullAsync(
                subscription,
                returnImmediately,
                maxMessages,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        /// least one message is available, rather than returning no messages.
        /// </param>
        /// <param name="maxMessages">
        /// The maximum number of messages to return for this request. Must be a
        /// positive integer. The Pub/Sub system may return fewer than the number
        /// specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual PullResponse Pull(
            string subscription,
            bool? returnImmediately,
            int maxMessages,
            gaxgrpc::CallSettings callSettings = null) => Pull(
                new PullRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    ReturnImmediately = returnImmediately ?? false, // Optional
                    MaxMessages = maxMessages,
                },
                callSettings);

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        public virtual stt::Task<PullResponse> PullAsync(
            PullRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
        /// there are too many concurrent pull requests pending for the given
        /// subscription.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PullResponse> PullAsync(
            PullRequest request,
            st::CancellationToken cancellationToken) => PullAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Establishes a stream with the server, which sends messages down to the
        /// client. The client streams acknowledgements and ack deadline modifications
        /// back to the server. The server will close the stream and return the status
        /// on any error. The server may close the stream with status `UNAVAILABLE` to
        /// reassign server-side resources, in which case, the client should
        /// re-establish the stream. Flow control can be achieved by configuring the
        /// underlying RPC channel.
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
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Bidirectional streaming methods for <c>StreamingPull</c>.
        /// </summary>
        public abstract partial class StreamingPullStream : gaxgrpc::BidirectionalStreamingBase<StreamingPullRequest, StreamingPullResponse>
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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            SubscriptionName subscription,
            PushConfig pushConfig,
            gaxgrpc::CallSettings callSettings = null) => ModifyPushConfigAsync(
                new ModifyPushConfigRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    PushConfig = gax::GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            SubscriptionName subscription,
            PushConfig pushConfig,
            st::CancellationToken cancellationToken) => ModifyPushConfigAsync(
                subscription,
                pushConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void ModifyPushConfig(
            SubscriptionName subscription,
            PushConfig pushConfig,
            gaxgrpc::CallSettings callSettings = null) => ModifyPushConfig(
                new ModifyPushConfigRequest
                {
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                    PushConfig = gax::GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            gaxgrpc::CallSettings callSettings = null) => ModifyPushConfigAsync(
                new ModifyPushConfigRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    PushConfig = gax::GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            string subscription,
            PushConfig pushConfig,
            st::CancellationToken cancellationToken) => ModifyPushConfigAsync(
                subscription,
                pushConfig,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// the subscription if `Pull` or `StreamingPull` is not called.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void ModifyPushConfig(
            string subscription,
            PushConfig pushConfig,
            gaxgrpc::CallSettings callSettings = null) => ModifyPushConfig(
                new ModifyPushConfigRequest
                {
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                    PushConfig = gax::GaxPreconditions.CheckNotNull(pushConfig, nameof(pushConfig)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            ModifyPushConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task ModifyPushConfigAsync(
            ModifyPushConfigRequest request,
            st::CancellationToken cancellationToken) => ModifyPushConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void ModifyPushConfig(
            ModifyPushConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list snapshots.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list snapshots.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list snapshots.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshotsAsync(
                new ListSnapshotsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list snapshots.
        /// Format is `projects/{project-id}`.
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSnapshots(
                new ListSnapshotsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            SnapshotName name,
            SubscriptionName subscription,
            gaxgrpc::CallSettings callSettings = null) => CreateSnapshotAsync(
                new CreateSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            SnapshotName name,
            SubscriptionName subscription,
            st::CancellationToken cancellationToken) => CreateSnapshotAsync(
                name,
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            gaxgrpc::CallSettings callSettings = null) => CreateSnapshot(
                new CreateSnapshotRequest
                {
                    SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    SubscriptionAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            string name,
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => CreateSnapshotAsync(
                new CreateSnapshotRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            string name,
            string subscription,
            st::CancellationToken cancellationToken) => CreateSnapshotAsync(
                name,
                subscription,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="name">
        /// Optional user-provided name for this snapshot.
        /// If the name is not provided in the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription.
        /// Note that for REST API requests, you must specify a name.  See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            string name,
            string subscription,
            gaxgrpc::CallSettings callSettings = null) => CreateSnapshot(
                new CreateSnapshotRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Subscription = gax::GaxPreconditions.CheckNotNullOrEmpty(subscription, nameof(subscription)),
                },
                callSettings);

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
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
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            CreateSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> CreateSnapshotAsync(
            CreateSnapshotRequest request,
            st::CancellationToken cancellationToken) => CreateSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public virtual stt::Task<Snapshot> UpdateSnapshotAsync(
            UpdateSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Snapshot> UpdateSnapshotAsync(
            UpdateSnapshotRequest request,
            st::CancellationToken cancellationToken) => UpdateSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            SnapshotName snapshot,
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshotAsync(
                new DeleteSnapshotRequest
                {
                    SnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="snapshot">
        /// The name of the snapshot to delete.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            SnapshotName snapshot,
            st::CancellationToken cancellationToken) => DeleteSnapshotAsync(
                snapshot,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        public virtual void DeleteSnapshot(
            SnapshotName snapshot,
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshot(
                new DeleteSnapshotRequest
                {
                    SnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            string snapshot,
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshotAsync(
                new DeleteSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="snapshot">
        /// The name of the snapshot to delete.
        /// Format is `projects/{project}/snapshots/{snap}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            string snapshot,
            st::CancellationToken cancellationToken) => DeleteSnapshotAsync(
                snapshot,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        public virtual void DeleteSnapshot(
            string snapshot,
            gaxgrpc::CallSettings callSettings = null) => DeleteSnapshot(
                new DeleteSnapshotRequest
                {
                    Snapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshot, nameof(snapshot)),
                },
                callSettings);

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
        /// are immediately dropped. After a snapshot is deleted, a new one may be
        /// created with the same name, but the new one has no association with the old
        /// snapshot or its subscription, unless the same subscription is specified.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            st::CancellationToken cancellationToken) => DeleteSnapshotAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        public virtual void DeleteSnapshot(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot. Note that both the subscription and the snapshot
        /// must be on the same topic.
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
        public virtual stt::Task<SeekResponse> SeekAsync(
            SeekRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot. Note that both the subscription and the snapshot
        /// must be on the same topic.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SeekResponse> SeekAsync(
            SeekRequest request,
            st::CancellationToken cancellationToken) => SeekAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot. Note that both the subscription and the snapshot
        /// must be on the same topic.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::Policy SetIamPolicy(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Subscriber client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SubscriberServiceApiClientImpl : SubscriberServiceApiClient
    {
        private readonly gaxgrpc::ApiCall<Subscription, Subscription> _callCreateSubscription;
        private readonly gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;
        private readonly gaxgrpc::ApiCall<UpdateSubscriptionRequest, Subscription> _callUpdateSubscription;
        private readonly gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;
        private readonly gaxgrpc::ApiCall<DeleteSubscriptionRequest, pbwkt::Empty> _callDeleteSubscription;
        private readonly gaxgrpc::ApiCall<ModifyAckDeadlineRequest, pbwkt::Empty> _callModifyAckDeadline;
        private readonly gaxgrpc::ApiCall<AcknowledgeRequest, pbwkt::Empty> _callAcknowledge;
        private readonly gaxgrpc::ApiCall<PullRequest, PullResponse> _callPull;
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingPullRequest, StreamingPullResponse> _callStreamingPull;
        private readonly gaxgrpc::ApiCall<ModifyPushConfigRequest, pbwkt::Empty> _callModifyPushConfig;
        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;
        private readonly gaxgrpc::ApiCall<CreateSnapshotRequest, Snapshot> _callCreateSnapshot;
        private readonly gaxgrpc::ApiCall<UpdateSnapshotRequest, Snapshot> _callUpdateSnapshot;
        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, pbwkt::Empty> _callDeleteSnapshot;
        private readonly gaxgrpc::ApiCall<SeekRequest, SeekResponse> _callSeek;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Subscriber service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SubscriberServiceApiSettings"/> used within this client </param>
        public SubscriberServiceApiClientImpl(Subscriber.SubscriberClient grpcClient, SubscriberServiceApiSettings settings)
        {
            GrpcClient = grpcClient;
            SubscriberServiceApiSettings effectiveSettings = settings ?? SubscriberServiceApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            iam::IAMPolicy.IAMPolicyClient grpcIAMPolicyClient = grpcClient.CreateIAMPolicyClient();
            _callCreateSubscription = clientHelper.BuildApiCall<Subscription, Subscription>(
                GrpcClient.CreateSubscriptionAsync, GrpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetSubscription = clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>(
                GrpcClient.GetSubscriptionAsync, GrpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callUpdateSubscription = clientHelper.BuildApiCall<UpdateSubscriptionRequest, Subscription>(
                GrpcClient.UpdateSubscriptionAsync, GrpcClient.UpdateSubscription, effectiveSettings.UpdateSubscriptionSettings)
                .WithGoogleRequestParam("subscription.name", request => request.Subscription?.Name);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>(
                GrpcClient.ListSubscriptionsAsync, GrpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings)
                .WithGoogleRequestParam("project", request => request.Project);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, pbwkt::Empty>(
                GrpcClient.DeleteSubscriptionAsync, GrpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callModifyAckDeadline = clientHelper.BuildApiCall<ModifyAckDeadlineRequest, pbwkt::Empty>(
                GrpcClient.ModifyAckDeadlineAsync, GrpcClient.ModifyAckDeadline, effectiveSettings.ModifyAckDeadlineSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callAcknowledge = clientHelper.BuildApiCall<AcknowledgeRequest, pbwkt::Empty>(
                GrpcClient.AcknowledgeAsync, GrpcClient.Acknowledge, effectiveSettings.AcknowledgeSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callPull = clientHelper.BuildApiCall<PullRequest, PullResponse>(
                GrpcClient.PullAsync, GrpcClient.Pull, effectiveSettings.PullSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callStreamingPull = clientHelper.BuildApiCall<StreamingPullRequest, StreamingPullResponse>(
                GrpcClient.StreamingPull, effectiveSettings.StreamingPullSettings, effectiveSettings.StreamingPullStreamingSettings);
            _callModifyPushConfig = clientHelper.BuildApiCall<ModifyPushConfigRequest, pbwkt::Empty>(
                GrpcClient.ModifyPushConfigAsync, GrpcClient.ModifyPushConfig, effectiveSettings.ModifyPushConfigSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(
                GrpcClient.ListSnapshotsAsync, GrpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings)
                .WithGoogleRequestParam("project", request => request.Project);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotRequest, Snapshot>(
                GrpcClient.CreateSnapshotAsync, GrpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateSnapshot = clientHelper.BuildApiCall<UpdateSnapshotRequest, Snapshot>(
                GrpcClient.UpdateSnapshotAsync, GrpcClient.UpdateSnapshot, effectiveSettings.UpdateSnapshotSettings)
                .WithGoogleRequestParam("snapshot.name", request => request.Snapshot?.Name);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, pbwkt::Empty>(
                GrpcClient.DeleteSnapshotAsync, GrpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings)
                .WithGoogleRequestParam("snapshot", request => request.Snapshot);
            _callSeek = clientHelper.BuildApiCall<SeekRequest, SeekResponse>(
                GrpcClient.SeekAsync, GrpcClient.Seek, effectiveSettings.SeekSettings)
                .WithGoogleRequestParam("subscription", request => request.Subscription);
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.SetIamPolicyAsync, grpcIAMPolicyClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.GetIamPolicyAsync, grpcIAMPolicyClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                grpcIAMPolicyClient.TestIamPermissionsAsync, grpcIAMPolicyClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callCreateSubscription);
            Modify_CreateSubscriptionApiCall(ref _callCreateSubscription);
            Modify_ApiCall(ref _callGetSubscription);
            Modify_GetSubscriptionApiCall(ref _callGetSubscription);
            Modify_ApiCall(ref _callUpdateSubscription);
            Modify_UpdateSubscriptionApiCall(ref _callUpdateSubscription);
            Modify_ApiCall(ref _callListSubscriptions);
            Modify_ListSubscriptionsApiCall(ref _callListSubscriptions);
            Modify_ApiCall(ref _callDeleteSubscription);
            Modify_DeleteSubscriptionApiCall(ref _callDeleteSubscription);
            Modify_ApiCall(ref _callModifyAckDeadline);
            Modify_ModifyAckDeadlineApiCall(ref _callModifyAckDeadline);
            Modify_ApiCall(ref _callAcknowledge);
            Modify_AcknowledgeApiCall(ref _callAcknowledge);
            Modify_ApiCall(ref _callPull);
            Modify_PullApiCall(ref _callPull);
            Modify_ApiCall(ref _callStreamingPull);
            Modify_StreamingPullApiCall(ref _callStreamingPull);
            Modify_ApiCall(ref _callModifyPushConfig);
            Modify_ModifyPushConfigApiCall(ref _callModifyPushConfig);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            Modify_ApiCall(ref _callCreateSnapshot);
            Modify_CreateSnapshotApiCall(ref _callCreateSnapshot);
            Modify_ApiCall(ref _callUpdateSnapshot);
            Modify_UpdateSnapshotApiCall(ref _callUpdateSnapshot);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
            Modify_ApiCall(ref _callSeek);
            Modify_SeekApiCall(ref _callSeek);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateSubscriptionApiCall(ref gaxgrpc::ApiCall<Subscription, Subscription> call);
        partial void Modify_GetSubscriptionApiCall(ref gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> call);
        partial void Modify_UpdateSubscriptionApiCall(ref gaxgrpc::ApiCall<UpdateSubscriptionRequest, Subscription> call);
        partial void Modify_ListSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> call);
        partial void Modify_DeleteSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSubscriptionRequest, pbwkt::Empty> call);
        partial void Modify_ModifyAckDeadlineApiCall(ref gaxgrpc::ApiCall<ModifyAckDeadlineRequest, pbwkt::Empty> call);
        partial void Modify_AcknowledgeApiCall(ref gaxgrpc::ApiCall<AcknowledgeRequest, pbwkt::Empty> call);
        partial void Modify_PullApiCall(ref gaxgrpc::ApiCall<PullRequest, PullResponse> call);
        partial void Modify_StreamingPullApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingPullRequest, StreamingPullResponse> call);
        partial void Modify_ModifyPushConfigApiCall(ref gaxgrpc::ApiCall<ModifyPushConfigRequest, pbwkt::Empty> call);
        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);
        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotRequest, Snapshot> call);
        partial void Modify_UpdateSnapshotApiCall(ref gaxgrpc::ApiCall<UpdateSnapshotRequest, Snapshot> call);
        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, pbwkt::Empty> call);
        partial void Modify_SeekApiCall(ref gaxgrpc::ApiCall<SeekRequest, SeekResponse> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(Subscriber.SubscriberClient grpcClient, SubscriberServiceApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Subscriber client.
        /// </summary>
        public override Subscriber.SubscriberClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_Subscription(ref Subscription request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSubscriptionRequest(ref GetSubscriptionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSubscriptionRequest(ref UpdateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ModifyAckDeadlineRequest(ref ModifyAckDeadlineRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_AcknowledgeRequest(ref AcknowledgeRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PullRequest(ref PullRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingPullRequestCallSettings(ref gaxgrpc::CallSettings settings);
        partial void Modify_StreamingPullRequestRequest(ref StreamingPullRequest request);
        partial void Modify_ModifyPushConfigRequest(ref ModifyPushConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateSnapshotRequest(ref CreateSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSnapshotRequest(ref UpdateSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SeekRequest(ref SeekRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
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
        public override stt::Task<Subscription> CreateSubscriptionAsync(
            Subscription request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Subscription(ref request, ref callSettings);
            return _callCreateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a subscription to a given topic. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
        /// If the subscription already exists, returns `ALREADY_EXISTS`.
        /// If the corresponding topic doesn't exist, returns `NOT_FOUND`.
        ///
        /// If the name is not provided in the request, the server will assign a random
        /// name for this subscription on the same project as the topic, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Subscription object. Note that
        /// for REST API requests, you must specify a name in the request.
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<Subscription> GetSubscriptionAsync(
            GetSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
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
        public override stt::Task<Subscription> UpdateSubscriptionAsync(
            UpdateSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing subscription. Note that certain properties of a
        /// subscription, such as its topic, are not modifiable.
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
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
        public override gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(
            ListSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteSubscriptionAsync(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void DeleteSubscription(
            DeleteSubscriptionRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task ModifyAckDeadlineAsync(
            ModifyAckDeadlineRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void ModifyAckDeadline(
            ModifyAckDeadlineRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task AcknowledgeAsync(
            AcknowledgeRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void Acknowledge(
            AcknowledgeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AcknowledgeRequest(ref request, ref callSettings);
            _callAcknowledge.Sync(request, callSettings);
        }

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
        public override stt::Task<PullResponse> PullAsync(
            PullRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PullRequest(ref request, ref callSettings);
            return _callPull.Async(request, callSettings);
        }

        /// <summary>
        /// Pulls messages from the server. The server may return `UNAVAILABLE` if
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PullRequest(ref request, ref callSettings);
            return _callPull.Sync(request, callSettings);
        }

        /// <summary>
        /// Establishes a stream with the server, which sends messages down to the
        /// client. The client streams acknowledgements and ack deadline modifications
        /// back to the server. The server will close the stream and return the status
        /// on any error. The server may close the stream with status `UNAVAILABLE` to
        /// reassign server-side resources, in which case, the client should
        /// re-establish the stream. Flow control can be achieved by configuring the
        /// underlying RPC channel.
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
            gaxgrpc::CallSettings callSettings = null,
            gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingPullRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings =
                streamingSettings ?? _callStreamingPull.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> call =
                _callStreamingPull.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingPullRequest> writeBuffer =
                new gaxgrpc::BufferedClientStreamWriter<StreamingPullRequest>(
                    call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingPullStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class StreamingPullStreamImpl : StreamingPullStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamingPull</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingPullRequest}"/>
            /// instance associated with this streaming call.</param>
            public StreamingPullStreamImpl(
                SubscriberServiceApiClientImpl service,
                grpccore::AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> call,
                gaxgrpc::BufferedClientStreamWriter<StreamingPullRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SubscriberServiceApiClientImpl _service;
            private gaxgrpc::BufferedClientStreamWriter<StreamingPullRequest> _writeBuffer;

            private StreamingPullRequest ModifyRequest(StreamingPullRequest request)
            {
                _service.Modify_StreamingPullRequestRequest(ref request);
                return request;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncDuplexStreamingCall<StreamingPullRequest, StreamingPullResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingPullRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingPullRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            /// <inheritdoc/>
            public override stt::Task TryWriteAsync(StreamingPullRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task WriteAsync(StreamingPullRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            /// <inheritdoc/>
            public override stt::Task TryWriteCompleteAsync() =>
                _writeBuffer.TryWriteCompleteAsync();

            /// <inheritdoc/>
            public override stt::Task WriteCompleteAsync() =>
                _writeBuffer.WriteCompleteAsync();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task ModifyPushConfigAsync(
            ModifyPushConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void ModifyPushConfig(
            ModifyPushConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyPushConfigRequest(ref request, ref callSettings);
            _callModifyPushConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public override gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Lists the existing snapshots. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public override gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(
            ListSnapshotsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
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
        public override stt::Task<Snapshot> CreateSnapshotAsync(
            CreateSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return _callCreateSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a snapshot from the requested subscription. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
        /// &lt;br&gt;&lt;br&gt;If the snapshot already exists, returns `ALREADY_EXISTS`.
        /// If the requested subscription doesn't exist, returns `NOT_FOUND`.
        /// If the backlog in the subscription is too old -- and the resulting snapshot
        /// would expire in less than 1 hour -- then `FAILED_PRECONDITION` is returned.
        /// See also the `Snapshot.expire_time` field. If the name is not provided in
        /// the request, the server will assign a random
        /// name for this snapshot on the same project as the subscription, conforming
        /// to the
        /// [resource name
        /// format](https://cloud.google.com/pubsub/docs/admin#resource_names). The
        /// generated name is populated in the returned Snapshot object. Note that for
        /// REST API requests, you must specify a name in the request.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return _callCreateSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
        public override stt::Task<Snapshot> UpdateSnapshotAsync(
            UpdateSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return _callUpdateSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return _callUpdateSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteSnapshotAsync(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Removes an existing snapshot. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot.&lt;br&gt;&lt;br&gt;
        /// When the snapshot is deleted, all messages retained in the snapshot
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
        public override void DeleteSnapshot(
            DeleteSnapshotRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            _callDeleteSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot. Note that both the subscription and the snapshot
        /// must be on the same topic.
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
        public override stt::Task<SeekResponse> SeekAsync(
            SeekRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SeekRequest(ref request, ref callSettings);
            return _callSeek.Async(request, callSettings);
        }

        /// <summary>
        /// Seeks an existing subscription to a point in time or to a given snapshot,
        /// whichever is provided in the request. Snapshots are used in
        /// &lt;a href="https://cloud.google.com/pubsub/docs/replay-overview"&gt;Seek&lt;/a&gt;
        /// operations, which allow
        /// you to manage message acknowledgments in bulk. That is, you can set the
        /// acknowledgment state of messages in an existing subscription to the state
        /// captured by a snapshot. Note that both the subscription and the snapshot
        /// must be on the same topic.
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        ///
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSubscriptionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest { }
    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable iam::IAMPolicy.IAMPolicyClient client creation
    public static partial class Subscriber
    {
        public partial class SubscriberClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="iam::IAMPolicy.IAMPolicyClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new iam::IAMPolicy.IAMPolicyClient for the same target as this client.</returns>
            public virtual iam::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() => new iam::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }


}
