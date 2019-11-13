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
    /// Settings for a <see cref="PublisherServiceApiClient"/>.
    /// </summary>
    public sealed partial class PublisherServiceApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublisherServiceApiSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PublisherServiceApiSettings"/>.
        /// </returns>
        public static PublisherServiceApiSettings GetDefault() => new PublisherServiceApiSettings();

        /// <summary>
        /// Constructs a new <see cref="PublisherServiceApiSettings"/> object with default settings.
        /// </summary>
        public PublisherServiceApiSettings() { }

        private PublisherServiceApiSettings(PublisherServiceApiSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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

        partial void OnCopy(PublisherServiceApiSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PublisherServiceApiClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="PublisherServiceApiClient"/> RPC methods.
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
        /// for "None" <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "None" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NoneRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Publish" <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Publish" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> PublishRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown);

        /// <summary>
        /// "Default" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods is defined as:
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
        /// "Messaging" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" retry backoff for <see cref="PublisherServiceApiClient"/> RPC methods is defined as:
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
        /// "Messaging" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Messaging" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Messaging" timeout backoff for <see cref="PublisherServiceApiClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 5000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.3</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetMessagingTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.CreateTopic</c> and <c>PublisherServiceApiClient.CreateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.CreateTopic</c> and
        /// <c>PublisherServiceApiClient.CreateTopicAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateTopicSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.UpdateTopic</c> and <c>PublisherServiceApiClient.UpdateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.UpdateTopic</c> and
        /// <c>PublisherServiceApiClient.UpdateTopicAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateTopicSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.Publish</c> and <c>PublisherServiceApiClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.Publish</c> and
        /// <c>PublisherServiceApiClient.PublishAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 5000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.3</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.Aborted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Cancelled"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.ResourceExhausted"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unknown"/></description></item>
        /// </list>
        /// Default RPC expiration is 60000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PublishSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetMessagingRetryBackoff(),
                timeoutBackoff: GetMessagingTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)),
                retryFilter: PublishRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.GetTopic</c> and <c>PublisherServiceApiClient.GetTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.GetTopic</c> and
        /// <c>PublisherServiceApiClient.GetTopicAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetTopicSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.ListTopics</c> and <c>PublisherServiceApiClient.ListTopicsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.ListTopics</c> and
        /// <c>PublisherServiceApiClient.ListTopicsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListTopicsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.ListTopicSubscriptions</c> and <c>PublisherServiceApiClient.ListTopicSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.ListTopicSubscriptions</c> and
        /// <c>PublisherServiceApiClient.ListTopicSubscriptionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListTopicSubscriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.DeleteTopic</c> and <c>PublisherServiceApiClient.DeleteTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.DeleteTopic</c> and
        /// <c>PublisherServiceApiClient.DeleteTopicAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteTopicSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.SetIamPolicy</c> and <c>PublisherServiceApiClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.SetIamPolicy</c> and
        /// <c>PublisherServiceApiClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>PublisherServiceApiClient.GetIamPolicy</c> and <c>PublisherServiceApiClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.GetIamPolicy</c> and
        /// <c>PublisherServiceApiClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <c>PublisherServiceApiClient.TestIamPermissions</c> and <c>PublisherServiceApiClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PublisherServiceApiClient.TestIamPermissions</c> and
        /// <c>PublisherServiceApiClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <returns>A deep clone of this <see cref="PublisherServiceApiSettings"/> object.</returns>
        public PublisherServiceApiSettings Clone() => new PublisherServiceApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublisherServiceApiClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PublisherServiceApiClientBuilder : gaxgrpc::ClientBuilderBase<PublisherServiceApiClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public PublisherServiceApiSettings Settings { get; set; }

        /// <inheritdoc/>
        public override PublisherServiceApiClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublisherServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<PublisherServiceApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublisherServiceApiClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => PublisherServiceApiClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublisherServiceApiClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublisherServiceApiClient.ChannelPool;
    }

    /// <summary>
    /// Publisher client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PublisherServiceApiClient
    {
        /// <summary>
        /// The default endpoint for the Publisher service, which is a host of "pubsub.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("pubsub.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/pubsub",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherServiceApiClient"/>, applying defaults for all unspecified settings,
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
        /// PublisherServiceApiClient client = await PublisherServiceApiClient.CreateAsync();
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
        ///     PublisherServiceApiClient.DefaultEndpoint.Host, PublisherServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PublisherServiceApiClient client = PublisherServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherServiceApiSettings"/>.</param>
        /// <returns>The task representing the created <see cref="PublisherServiceApiClient"/>.</returns>
        public static async stt::Task<PublisherServiceApiClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, PublisherServiceApiSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PublisherServiceApiClient"/>, applying defaults for all unspecified settings,
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
        /// PublisherServiceApiClient client = PublisherServiceApiClient.Create();
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
        ///     PublisherServiceApiClient.DefaultEndpoint.Host, PublisherServiceApiClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PublisherServiceApiClient client = PublisherServiceApiClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="PublisherServiceApiClient"/>.</returns>
        public static PublisherServiceApiClient Create(gaxgrpc::ServiceEndpoint endpoint = null, PublisherServiceApiSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PublisherServiceApiClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PublisherServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="PublisherServiceApiClient"/>.</returns>
        public static PublisherServiceApiClient Create(grpccore::Channel channel, PublisherServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="PublisherServiceApiClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PublisherServiceApiSettings"/>.</param>
        /// <returns>The created <see cref="PublisherServiceApiClient"/>.</returns>
        public static PublisherServiceApiClient Create(grpccore::CallInvoker callInvoker, PublisherServiceApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(callInvoker);
            return new PublisherServiceApiClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, PublisherServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PublisherServiceApiSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, PublisherServiceApiSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PublisherServiceApiSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Publisher client.
        /// </summary>
        public virtual Publisher.PublisherClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Topic> CreateTopicAsync(
            TopicName name,
            gaxgrpc::CallSettings callSettings = null) => CreateTopicAsync(
                new Topic
                {
                    TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Topic> CreateTopicAsync(
            TopicName name,
            st::CancellationToken cancellationToken) => CreateTopicAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            gaxgrpc::CallSettings callSettings = null) => CreateTopic(
                new Topic
                {
                    TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Topic> CreateTopicAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => CreateTopicAsync(
                new Topic
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Topic> CreateTopicAsync(
            string name,
            st::CancellationToken cancellationToken) => CreateTopicAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            string name,
            gaxgrpc::CallSettings callSettings = null) => CreateTopic(
                new Topic
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Topic> CreateTopicAsync(
            Topic request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public virtual stt::Task<Topic> CreateTopicAsync(
            Topic request,
            st::CancellationToken cancellationToken) => CreateTopicAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
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
        public virtual stt::Task<Topic> UpdateTopicAsync(
            UpdateTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
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
        public virtual stt::Task<Topic> UpdateTopicAsync(
            UpdateTopicRequest request,
            st::CancellationToken cancellationToken) => UpdateTopicAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
        public virtual stt::Task<PublishResponse> PublishAsync(
            TopicName topic,
            scg::IEnumerable<PubsubMessage> messages,
            gaxgrpc::CallSettings callSettings = null) => PublishAsync(
                new PublishRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    Messages = { gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// The messages to publish.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PublishResponse> PublishAsync(
            TopicName topic,
            scg::IEnumerable<PubsubMessage> messages,
            st::CancellationToken cancellationToken) => PublishAsync(
                topic,
                messages,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
            scg::IEnumerable<PubsubMessage> messages,
            gaxgrpc::CallSettings callSettings = null) => Publish(
                new PublishRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    Messages = { gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
        public virtual stt::Task<PublishResponse> PublishAsync(
            string topic,
            scg::IEnumerable<PubsubMessage> messages,
            gaxgrpc::CallSettings callSettings = null) => PublishAsync(
                new PublishRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    Messages = { gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// The messages to publish.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<PublishResponse> PublishAsync(
            string topic,
            scg::IEnumerable<PubsubMessage> messages,
            st::CancellationToken cancellationToken) => PublishAsync(
                topic,
                messages,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
            string topic,
            scg::IEnumerable<PubsubMessage> messages,
            gaxgrpc::CallSettings callSettings = null) => Publish(
                new PublishRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    Messages = { gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)) },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
        public virtual stt::Task<PublishResponse> PublishAsync(
            PublishRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
        public virtual stt::Task<PublishResponse> PublishAsync(
            PublishRequest request,
            st::CancellationToken cancellationToken) => PublishAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Topic> GetTopicAsync(
            TopicName topic,
            gaxgrpc::CallSettings callSettings = null) => GetTopicAsync(
                new GetTopicRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Topic> GetTopicAsync(
            TopicName topic,
            st::CancellationToken cancellationToken) => GetTopicAsync(
                topic,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetTopic(
                new GetTopicRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                },
                callSettings);

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
        public virtual stt::Task<Topic> GetTopicAsync(
            string topic,
            gaxgrpc::CallSettings callSettings = null) => GetTopicAsync(
                new GetTopicRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Topic> GetTopicAsync(
            string topic,
            st::CancellationToken cancellationToken) => GetTopicAsync(
                topic,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string topic,
            gaxgrpc::CallSettings callSettings = null) => GetTopic(
                new GetTopicRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
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
        public virtual stt::Task<Topic> GetTopicAsync(
            GetTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration of a topic.
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
        public virtual stt::Task<Topic> GetTopicAsync(
            GetTopicRequest request,
            st::CancellationToken cancellationToken) => GetTopicAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list topics.
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
        /// A pageable asynchronous sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicsAsync(
                new ListTopicsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list topics.
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
        /// A pageable sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            gaxres::ProjectName project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopics(
                new ListTopicsRequest
                {
                    ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list topics.
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
        /// A pageable asynchronous sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicsAsync(
                new ListTopicsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// The name of the project in which to list topics.
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
        /// A pageable sequence of <see cref="Topic"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            string project,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopics(
                new ListTopicsRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
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
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            ListTopicsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            ListTopicsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            TopicName topic,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicSubscriptionsAsync(
                new ListTopicSubscriptionsRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            TopicName topic,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicSubscriptions(
                new ListTopicSubscriptionsRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            string topic,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicSubscriptionsAsync(
                new ListTopicSubscriptionsRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            string topic,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTopicSubscriptions(
                new ListTopicSubscriptionsRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            ListTopicSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            ListTopicSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            TopicName topic,
            gaxgrpc::CallSettings callSettings = null) => DeleteTopicAsync(
                new DeleteTopicRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            TopicName topic,
            st::CancellationToken cancellationToken) => DeleteTopicAsync(
                topic,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteTopic(
            TopicName topic,
            gaxgrpc::CallSettings callSettings = null) => DeleteTopic(
                new DeleteTopicRequest
                {
                    TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            string topic,
            gaxgrpc::CallSettings callSettings = null) => DeleteTopicAsync(
                new DeleteTopicRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            string topic,
            st::CancellationToken cancellationToken) => DeleteTopicAsync(
                topic,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteTopic(
            string topic,
            gaxgrpc::CallSettings callSettings = null) => DeleteTopic(
                new DeleteTopicRequest
                {
                    Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            DeleteTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteTopicAsync(
            DeleteTopicRequest request,
            st::CancellationToken cancellationToken) => DeleteTopicAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteTopic(
            DeleteTopicRequest request,
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
    /// Publisher client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PublisherServiceApiClientImpl : PublisherServiceApiClient
    {
        private readonly gaxgrpc::ApiCall<Topic, Topic> _callCreateTopic;
        private readonly gaxgrpc::ApiCall<UpdateTopicRequest, Topic> _callUpdateTopic;
        private readonly gaxgrpc::ApiCall<PublishRequest, PublishResponse> _callPublish;
        private readonly gaxgrpc::ApiCall<GetTopicRequest, Topic> _callGetTopic;
        private readonly gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;
        private readonly gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> _callListTopicSubscriptions;
        private readonly gaxgrpc::ApiCall<DeleteTopicRequest, pbwkt::Empty> _callDeleteTopic;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Publisher service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherServiceApiSettings"/> used within this client </param>
        public PublisherServiceApiClientImpl(Publisher.PublisherClient grpcClient, PublisherServiceApiSettings settings)
        {
            GrpcClient = grpcClient;
            PublisherServiceApiSettings effectiveSettings = settings ?? PublisherServiceApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            iam::IAMPolicy.IAMPolicyClient grpcIAMPolicyClient = grpcClient.CreateIAMPolicyClient();
            _callCreateTopic = clientHelper.BuildApiCall<Topic, Topic>(
                GrpcClient.CreateTopicAsync, GrpcClient.CreateTopic, effectiveSettings.CreateTopicSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>(
                GrpcClient.UpdateTopicAsync, GrpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings)
                .WithGoogleRequestParam("topic.name", request => request.Topic?.Name);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>(
                GrpcClient.PublishAsync, GrpcClient.Publish, effectiveSettings.PublishSettings)
                .WithGoogleRequestParam("topic", request => request.Topic);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>(
                GrpcClient.GetTopicAsync, GrpcClient.GetTopic, effectiveSettings.GetTopicSettings)
                .WithGoogleRequestParam("topic", request => request.Topic);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>(
                GrpcClient.ListTopicsAsync, GrpcClient.ListTopics, effectiveSettings.ListTopicsSettings)
                .WithGoogleRequestParam("project", request => request.Project);
            _callListTopicSubscriptions = clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>(
                GrpcClient.ListTopicSubscriptionsAsync, GrpcClient.ListTopicSubscriptions, effectiveSettings.ListTopicSubscriptionsSettings)
                .WithGoogleRequestParam("topic", request => request.Topic);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, pbwkt::Empty>(
                GrpcClient.DeleteTopicAsync, GrpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings)
                .WithGoogleRequestParam("topic", request => request.Topic);
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.SetIamPolicyAsync, grpcIAMPolicyClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.GetIamPolicyAsync, grpcIAMPolicyClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                grpcIAMPolicyClient.TestIamPermissionsAsync, grpcIAMPolicyClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callCreateTopic);
            Modify_CreateTopicApiCall(ref _callCreateTopic);
            Modify_ApiCall(ref _callUpdateTopic);
            Modify_UpdateTopicApiCall(ref _callUpdateTopic);
            Modify_ApiCall(ref _callPublish);
            Modify_PublishApiCall(ref _callPublish);
            Modify_ApiCall(ref _callGetTopic);
            Modify_GetTopicApiCall(ref _callGetTopic);
            Modify_ApiCall(ref _callListTopics);
            Modify_ListTopicsApiCall(ref _callListTopics);
            Modify_ApiCall(ref _callListTopicSubscriptions);
            Modify_ListTopicSubscriptionsApiCall(ref _callListTopicSubscriptions);
            Modify_ApiCall(ref _callDeleteTopic);
            Modify_DeleteTopicApiCall(ref _callDeleteTopic);
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

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateTopicApiCall(ref gaxgrpc::ApiCall<Topic, Topic> call);
        partial void Modify_UpdateTopicApiCall(ref gaxgrpc::ApiCall<UpdateTopicRequest, Topic> call);
        partial void Modify_PublishApiCall(ref gaxgrpc::ApiCall<PublishRequest, PublishResponse> call);
        partial void Modify_GetTopicApiCall(ref gaxgrpc::ApiCall<GetTopicRequest, Topic> call);
        partial void Modify_ListTopicsApiCall(ref gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> call);
        partial void Modify_ListTopicSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> call);
        partial void Modify_DeleteTopicApiCall(ref gaxgrpc::ApiCall<DeleteTopicRequest, pbwkt::Empty> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(Publisher.PublisherClient grpcClient, PublisherServiceApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Publisher client.
        /// </summary>
        public override Publisher.PublisherClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_Topic(ref Topic request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateTopicRequest(ref UpdateTopicRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PublishRequest(ref PublishRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTopicRequest(ref GetTopicRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTopicsRequest(ref ListTopicsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTopicSubscriptionsRequest(ref ListTopicSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteTopicRequest(ref DeleteTopicRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
        public override stt::Task<Topic> CreateTopicAsync(
            Topic request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Creates the given topic with the given name. See the
        /// &lt;a href="https://cloud.google.com/pubsub/docs/admin#resource_names"&gt;
        /// resource name rules&lt;/a&gt;.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
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
        public override stt::Task<Topic> UpdateTopicAsync(
            UpdateTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
        public override stt::Task<PublishResponse> PublishAsync(
            PublishRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Async(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<Topic> GetTopicAsync(
            GetTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(
            ListTopicsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
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
        public override gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(
            ListTopicsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public override gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptionsAsync(
            ListTopicSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, SubscriptionName>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the subscriptions on this topic.
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
        public override gax::PagedEnumerable<ListTopicSubscriptionsResponse, SubscriptionName> ListTopicSubscriptions(
            ListTopicSubscriptionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, SubscriptionName>(_callListTopicSubscriptions, request, callSettings);
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteTopicAsync(
            DeleteTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void DeleteTopic(
            DeleteTopicRequest request,
            gaxgrpc::CallSettings callSettings = null)
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

    public partial class ListTopicsRequest : gaxgrpc::IPageRequest { }
    public partial class ListTopicsResponse : gaxgrpc::IPageResponse<Topic>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Topic> GetEnumerator() => Topics.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicSubscriptionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListTopicSubscriptionsResponse : gaxgrpc::IPageResponse<SubscriptionName>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<SubscriptionName> GetEnumerator() => SubscriptionsAsSubscriptionNames.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable iam::IAMPolicy.IAMPolicyClient client creation
    public static partial class Publisher
    {
        public partial class PublisherClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="iam::IAMPolicy.IAMPolicyClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new iam::IAMPolicy.IAMPolicyClient for the same target as this client.</returns>
            public virtual iam::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() => new iam::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }


}
