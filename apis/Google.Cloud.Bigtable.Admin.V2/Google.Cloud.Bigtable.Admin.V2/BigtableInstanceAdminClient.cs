// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>
    /// Settings for a <see cref="BigtableInstanceAdminClient"/>.
    /// </summary>
    public sealed partial class BigtableInstanceAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BigtableInstanceAdminSettings"/>.
        /// </returns>
        public static BigtableInstanceAdminSettings GetDefault() => new BigtableInstanceAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="BigtableInstanceAdminSettings"/> object with default settings.
        /// </summary>
        public BigtableInstanceAdminSettings() { }

        private BigtableInstanceAdminSettings(BigtableInstanceAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings?.Clone();
            GetInstanceSettings = existing.GetInstanceSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            PartialUpdateInstanceSettings = existing.PartialUpdateInstanceSettings;
            PartialUpdateInstanceOperationsSettings = existing.PartialUpdateInstanceOperationsSettings?.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings?.Clone();
            GetClusterSettings = existing.GetClusterSettings;
            ListClustersSettings = existing.ListClustersSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings?.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            CreateAppProfileSettings = existing.CreateAppProfileSettings;
            GetAppProfileSettings = existing.GetAppProfileSettings;
            ListAppProfilesSettings = existing.ListAppProfilesSettings;
            UpdateAppProfileSettings = existing.UpdateAppProfileSettings;
            UpdateAppProfileOperationsSettings = existing.UpdateAppProfileOperationsSettings?.Clone();
            DeleteAppProfileSettings = existing.DeleteAppProfileSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableInstanceAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "NonIdempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.Unavailable);

        /// <summary>
        /// "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 2.0</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(5),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 2.0
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BigtableInstanceAdminClient"/> RPC methods is defined as:
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
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateInstance</c> and <c>BigtableInstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateInstance</c> and
        /// <c>BigtableInstanceAdminClient.CreateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateInstanceOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetInstance</c> and <c>BigtableInstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetInstance</c> and
        /// <c>BigtableInstanceAdminClient.GetInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings GetInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListInstances</c> and <c>BigtableInstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListInstances</c> and
        /// <c>BigtableInstanceAdminClient.ListInstancesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings ListInstancesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.PartialUpdateInstance</c> and
        /// <c>BigtableInstanceAdminClient.PartialUpdateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings PartialUpdateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.PartialUpdateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings PartialUpdateInstanceOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteInstance</c> and <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteInstance</c> and
        /// <c>BigtableInstanceAdminClient.DeleteInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings DeleteInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateCluster</c> and <c>BigtableInstanceAdminClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateCluster</c> and
        /// <c>BigtableInstanceAdminClient.CreateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.CreateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetCluster</c> and <c>BigtableInstanceAdminClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetCluster</c> and
        /// <c>BigtableInstanceAdminClient.GetClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings GetClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListClusters</c> and <c>BigtableInstanceAdminClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListClusters</c> and
        /// <c>BigtableInstanceAdminClient.ListClustersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings ListClustersSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateCluster</c> and <c>BigtableInstanceAdminClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateCluster</c> and
        /// <c>BigtableInstanceAdminClient.UpdateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings UpdateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateCluster</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateClusterOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(500L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteCluster</c> and <c>BigtableInstanceAdminClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteCluster</c> and
        /// <c>BigtableInstanceAdminClient.DeleteClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings DeleteClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.CreateAppProfile</c> and <c>BigtableInstanceAdminClient.CreateAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.CreateAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.CreateAppProfileAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateAppProfileSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetAppProfile</c> and <c>BigtableInstanceAdminClient.GetAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.GetAppProfileAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings GetAppProfileSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.ListAppProfiles</c> and <c>BigtableInstanceAdminClient.ListAppProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.ListAppProfiles</c> and
        /// <c>BigtableInstanceAdminClient.ListAppProfilesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings ListAppProfilesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.UpdateAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.UpdateAppProfileAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings UpdateAppProfileSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableInstanceAdminClient.UpdateAppProfile</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateAppProfileOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(300000L)),
                TimeSpan.FromMilliseconds(5L),
                1.5,
                TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.DeleteAppProfile</c> and <c>BigtableInstanceAdminClient.DeleteAppProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.DeleteAppProfile</c> and
        /// <c>BigtableInstanceAdminClient.DeleteAppProfileAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteAppProfileSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableInstanceAdminClient.GetIamPolicy</c> and <c>BigtableInstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.GetIamPolicy</c> and
        /// <c>BigtableInstanceAdminClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        /// <c>BigtableInstanceAdminClient.SetIamPolicy</c> and <c>BigtableInstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.SetIamPolicy</c> and
        /// <c>BigtableInstanceAdminClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
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
        /// <c>BigtableInstanceAdminClient.TestIamPermissions</c> and <c>BigtableInstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableInstanceAdminClient.TestIamPermissions</c> and
        /// <c>BigtableInstanceAdminClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 2.0</description></item>
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
        public CallSettings TestIamPermissionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BigtableInstanceAdminSettings"/> object.</returns>
        public BigtableInstanceAdminSettings Clone() => new BigtableInstanceAdminSettings(this);
    }

    /// <summary>
    /// BigtableInstanceAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BigtableInstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableInstanceAdmin service, which is a host of "bigtableadmin.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("bigtableadmin.googleapis.com", 443);

        /// <summary>
        /// The default BigtableInstanceAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default BigtableInstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.instance"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.cluster"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-bigtable.admin.table"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.cluster",
            "https://www.googleapis.com/auth/bigtable.admin.instance",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.cluster",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static async Task<BigtableInstanceAdminClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableInstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(ServiceEndpoint endpoint = null, BigtableInstanceAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BigtableInstanceAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableInstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableInstanceAdminClient"/>.</returns>
        public static BigtableInstanceAdminClient Create(Channel channel, BigtableInstanceAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient = new BigtableInstanceAdmin.BigtableInstanceAdminClient(channel);
            return new BigtableInstanceAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableInstanceAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BigtableInstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, BigtableInstanceAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public virtual BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                clusters,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an instance within a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project in which to create the new instance.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// The ID to be used when referring to the new instance within its project,
        /// e.g., just `myinstance` rather than
        /// `projects/myproject/instances/myinstance`.
        /// </param>
        /// <param name="instance">
        /// The instance to create.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="clusters">
        /// The clusters to be created within the instance, mapped by desired
        /// cluster ID, e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// Fields marked `OutputOnly` must be left blank.
        /// Currently exactly one cluster must be specified.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            ProjectName parent,
            string instanceId,
            Instance instance,
            IDictionary<string, Cluster> clusters,
            CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    Clusters = { GaxPreconditions.CheckNotNull(clusters, nameof(clusters)) },
                },
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Create an instance within a project.
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
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public virtual OperationsClient CreateInstanceOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance GetInstance(
            InstanceName name,
            CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about an instance.
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
        public virtual Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about an instance.
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
        public virtual Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ProjectName parent,
            CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ProjectName parent,
            CancellationToken cancellationToken) => ListInstancesAsync(
                parent,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about instances in a project.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the project for which a list of instances is requested.
        /// Values are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInstancesResponse ListInstances(
            ProjectName parent,
            CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public virtual ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            Instance instance,
            FieldMask updateMask,
            CallSettings callSettings = null) => PartialUpdateInstanceAsync(
                new PartialUpdateInstanceRequest
                {
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            Instance instance,
            FieldMask updateMask,
            CancellationToken cancellationToken) => PartialUpdateInstanceAsync(
                instance,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Partially updates an instance within a project.
        /// </summary>
        /// <param name="instance">
        /// The Instance which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of Instance fields which should be replaced.
        /// Must be explicitly set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            Instance instance,
            FieldMask updateMask,
            CallSettings callSettings = null) => PartialUpdateInstance(
                new PartialUpdateInstanceRequest
                {
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
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
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            PartialUpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> PollOncePartialUpdateInstanceAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PartialUpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Partially updates an instance within a project.
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
        public virtual Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            PartialUpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>PartialUpdateInstance</c>.
        /// </summary>
        public virtual OperationsClient PartialUpdateInstanceOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PartialUpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Instance, UpdateInstanceMetadata> PollOncePartialUpdateInstance(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PartialUpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="name">
        /// The unique name of the instance to be deleted.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInstance(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete an instance from a project.
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
        public virtual Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CancellationToken cancellationToken) => CreateClusterAsync(
                parent,
                clusterId,
                cluster,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new cluster.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="clusterId">
        /// The ID to be used when referring to the new cluster within its instance,
        /// e.g., just `mycluster` rather than
        /// `projects/myproject/instances/myinstance/clusters/mycluster`.
        /// </param>
        /// <param name="cluster">
        /// The cluster to be created.
        /// Fields marked `OutputOnly` must be left blank.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Cluster, CreateClusterMetadata> CreateCluster(
            InstanceName parent,
            string clusterId,
            Cluster cluster,
            CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, CreateClusterMetadata>> PollOnceCreateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, CreateClusterMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a cluster within an instance.
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
        public virtual Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public virtual OperationsClient CreateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, CreateClusterMetadata> PollOnceCreateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, CreateClusterMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            ClusterName name,
            CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            ClusterName name,
            CancellationToken cancellationToken) => GetClusterAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a cluster.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested cluster. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            ClusterName name,
            CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public virtual Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            InstanceName parent,
            CancellationToken cancellationToken) => ListClustersAsync(
                parent,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about clusters in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of clusters is requested.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// Use `&lt;instance&gt; = '-'` to list Clusters for all Instances in a project,
        /// e.g., `projects/myproject/instances/-`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListClustersResponse ListClusters(
            InstanceName parent,
            CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                },
                callSettings);

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public virtual ListClustersResponse ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateClusterAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Cluster, UpdateClusterMetadata>> PollOnceUpdateClusterAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, UpdateClusterMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Updates a cluster within an instance.
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
        public virtual Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public virtual OperationsClient UpdateClusterOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Cluster, UpdateClusterMetadata> PollOnceUpdateCluster(
            string operationName,
            CallSettings callSettings = null) => Operation<Cluster, UpdateClusterMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateClusterOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteClusterAsync(
            ClusterName name,
            CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteClusterAsync(
            ClusterName name,
            CancellationToken cancellationToken) => DeleteClusterAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the cluster to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/clusters/&lt;cluster&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCluster(
            ClusterName name,
            CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    ClusterName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public virtual Task DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AppProfile> CreateAppProfileAsync(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            CallSettings callSettings = null) => CreateAppProfileAsync(
                new CreateAppProfileRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    AppProfileId = GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AppProfile> CreateAppProfileAsync(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            CancellationToken cancellationToken) => CreateAppProfileAsync(
                parent,
                appProfileId,
                appProfile,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance in which to create the new app profile.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// The ID to be used when referring to the new app profile within its
        /// instance, e.g., just `myprofile` rather than
        /// `projects/myproject/instances/myinstance/appProfiles/myprofile`.
        /// </param>
        /// <param name="appProfile">
        /// The app profile to be created.
        /// Fields marked `OutputOnly` will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile CreateAppProfile(
            InstanceName parent,
            string appProfileId,
            AppProfile appProfile,
            CallSettings callSettings = null) => CreateAppProfile(
                new CreateAppProfileRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    AppProfileId = GaxPreconditions.CheckNotNullOrEmpty(appProfileId, nameof(appProfileId)),
                    AppProfile = GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
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
        public virtual Task<AppProfile> CreateAppProfileAsync(
            CreateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
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
        public virtual AppProfile CreateAppProfile(
            CreateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AppProfile> GetAppProfileAsync(
            AppProfileName name,
            CallSettings callSettings = null) => GetAppProfileAsync(
                new GetAppProfileRequest
                {
                    AppProfileName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AppProfile> GetAppProfileAsync(
            AppProfileName name,
            CancellationToken cancellationToken) => GetAppProfileAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
        /// </summary>
        /// <param name="name">
        /// The unique name of the requested app profile. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AppProfile GetAppProfile(
            AppProfileName name,
            CallSettings callSettings = null) => GetAppProfile(
                new GetAppProfileRequest
                {
                    AppProfileName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
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
        public virtual Task<AppProfile> GetAppProfileAsync(
            GetAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
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
        public virtual AppProfile GetAppProfile(
            GetAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListAppProfilesAsync(
                new ListAppProfilesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="parent">
        /// The unique name of the instance for which a list of app profiles is
        /// requested. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
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
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            InstanceName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListAppProfiles(
                new ListAppProfilesRequest
                {
                    ParentAsInstanceName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            ListAppProfilesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            ListAppProfilesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            AppProfile appProfile,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateAppProfileAsync(
                new UpdateAppProfileRequest
                {
                    AppProfile = GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            AppProfile appProfile,
            FieldMask updateMask,
            CancellationToken cancellationToken) => UpdateAppProfileAsync(
                appProfile,
                updateMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
        /// </summary>
        /// <param name="appProfile">
        /// The app profile which will (partially) replace the current value.
        /// </param>
        /// <param name="updateMask">
        /// The subset of app profile fields which should be replaced.
        /// If unset, all fields will be replaced.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            AppProfile appProfile,
            FieldMask updateMask,
            CallSettings callSettings = null) => UpdateAppProfile(
                new UpdateAppProfileRequest
                {
                    AppProfile = GaxPreconditions.CheckNotNull(appProfile, nameof(appProfile)),
                    UpdateMask = GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
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
        public virtual Task<Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            UpdateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppProfileAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<AppProfile, UpdateAppProfileMetadata>> PollOnceUpdateAppProfileAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateAppProfileOperationsClient,
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
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
        public virtual Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            UpdateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateAppProfile</c>.
        /// </summary>
        public virtual OperationsClient UpdateAppProfileOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAppProfile</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<AppProfile, UpdateAppProfileMetadata> PollOnceUpdateAppProfile(
            string operationName,
            CallSettings callSettings = null) => Operation<AppProfile, UpdateAppProfileMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateAppProfileOperationsClient,
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteAppProfileAsync(
            AppProfileName name,
            CallSettings callSettings = null) => DeleteAppProfileAsync(
                new DeleteAppProfileRequest
                {
                    AppProfileName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteAppProfileAsync(
            AppProfileName name,
            CancellationToken cancellationToken) => DeleteAppProfileAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="name">
        /// The unique name of the app profile to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/appProfiles/&lt;app_profile&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAppProfile(
            AppProfileName name,
            CallSettings callSettings = null) => DeleteAppProfile(
                new DeleteAppProfileRequest
                {
                    AppProfileName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
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
        public virtual Task DeleteAppProfileAsync(
            DeleteAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAppProfile(
            DeleteAppProfileRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
    /// BigtableInstanceAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BigtableInstanceAdminClientImpl : BigtableInstanceAdminClient
    {
        private readonly ApiCall<CreateInstanceRequest, Operation> _callCreateInstance;
        private readonly ApiCall<GetInstanceRequest, Instance> _callGetInstance;
        private readonly ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;
        private readonly ApiCall<PartialUpdateInstanceRequest, Operation> _callPartialUpdateInstance;
        private readonly ApiCall<DeleteInstanceRequest, Empty> _callDeleteInstance;
        private readonly ApiCall<CreateClusterRequest, Operation> _callCreateCluster;
        private readonly ApiCall<GetClusterRequest, Cluster> _callGetCluster;
        private readonly ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;
        private readonly ApiCall<Cluster, Operation> _callUpdateCluster;
        private readonly ApiCall<DeleteClusterRequest, Empty> _callDeleteCluster;
        private readonly ApiCall<CreateAppProfileRequest, AppProfile> _callCreateAppProfile;
        private readonly ApiCall<GetAppProfileRequest, AppProfile> _callGetAppProfile;
        private readonly ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> _callListAppProfiles;
        private readonly ApiCall<UpdateAppProfileRequest, Operation> _callUpdateAppProfile;
        private readonly ApiCall<DeleteAppProfileRequest, Empty> _callDeleteAppProfile;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the BigtableInstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableInstanceAdminSettings"/> used within this client </param>
        public BigtableInstanceAdminClientImpl(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableInstanceAdminSettings effectiveSettings = settings ?? BigtableInstanceAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            PartialUpdateInstanceOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.PartialUpdateInstanceOperationsSettings);
            CreateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings);
            UpdateClusterOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings);
            UpdateAppProfileOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAppProfileOperationsSettings);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, Operation>(
                GrpcClient.CreateInstanceAsync, GrpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(
                GrpcClient.GetInstanceAsync, GrpcClient.GetInstance, effectiveSettings.GetInstanceSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(
                GrpcClient.ListInstancesAsync, GrpcClient.ListInstances, effectiveSettings.ListInstancesSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callPartialUpdateInstance = clientHelper.BuildApiCall<PartialUpdateInstanceRequest, Operation>(
                GrpcClient.PartialUpdateInstanceAsync, GrpcClient.PartialUpdateInstance, effectiveSettings.PartialUpdateInstanceSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"instance.name={request.Instance.Name}"));
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, Empty>(
                GrpcClient.DeleteInstanceAsync, GrpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, Operation>(
                GrpcClient.CreateClusterAsync, GrpcClient.CreateCluster, effectiveSettings.CreateClusterSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(
                GrpcClient.GetClusterAsync, GrpcClient.GetCluster, effectiveSettings.GetClusterSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(
                GrpcClient.ListClustersAsync, GrpcClient.ListClusters, effectiveSettings.ListClustersSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateCluster = clientHelper.BuildApiCall<Cluster, Operation>(
                GrpcClient.UpdateClusterAsync, GrpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, Empty>(
                GrpcClient.DeleteClusterAsync, GrpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateAppProfile = clientHelper.BuildApiCall<CreateAppProfileRequest, AppProfile>(
                GrpcClient.CreateAppProfileAsync, GrpcClient.CreateAppProfile, effectiveSettings.CreateAppProfileSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetAppProfile = clientHelper.BuildApiCall<GetAppProfileRequest, AppProfile>(
                GrpcClient.GetAppProfileAsync, GrpcClient.GetAppProfile, effectiveSettings.GetAppProfileSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callListAppProfiles = clientHelper.BuildApiCall<ListAppProfilesRequest, ListAppProfilesResponse>(
                GrpcClient.ListAppProfilesAsync, GrpcClient.ListAppProfiles, effectiveSettings.ListAppProfilesSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateAppProfile = clientHelper.BuildApiCall<UpdateAppProfileRequest, Operation>(
                GrpcClient.UpdateAppProfileAsync, GrpcClient.UpdateAppProfile, effectiveSettings.UpdateAppProfileSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"app_profile.name={request.AppProfile.Name}"));
            _callDeleteAppProfile = clientHelper.BuildApiCall<DeleteAppProfileRequest, Empty>(
                GrpcClient.DeleteAppProfileAsync, GrpcClient.DeleteAppProfile, effectiveSettings.DeleteAppProfileSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            Modify_ApiCall(ref _callPartialUpdateInstance);
            Modify_PartialUpdateInstanceApiCall(ref _callPartialUpdateInstance);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            Modify_ApiCall(ref _callCreateAppProfile);
            Modify_CreateAppProfileApiCall(ref _callCreateAppProfile);
            Modify_ApiCall(ref _callGetAppProfile);
            Modify_GetAppProfileApiCall(ref _callGetAppProfile);
            Modify_ApiCall(ref _callListAppProfiles);
            Modify_ListAppProfilesApiCall(ref _callListAppProfiles);
            Modify_ApiCall(ref _callUpdateAppProfile);
            Modify_UpdateAppProfileApiCall(ref _callUpdateAppProfile);
            Modify_ApiCall(ref _callDeleteAppProfile);
            Modify_DeleteAppProfileApiCall(ref _callDeleteAppProfile);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateInstanceApiCall(ref ApiCall<CreateInstanceRequest, Operation> call);
        partial void Modify_GetInstanceApiCall(ref ApiCall<GetInstanceRequest, Instance> call);
        partial void Modify_ListInstancesApiCall(ref ApiCall<ListInstancesRequest, ListInstancesResponse> call);
        partial void Modify_PartialUpdateInstanceApiCall(ref ApiCall<PartialUpdateInstanceRequest, Operation> call);
        partial void Modify_DeleteInstanceApiCall(ref ApiCall<DeleteInstanceRequest, Empty> call);
        partial void Modify_CreateClusterApiCall(ref ApiCall<CreateClusterRequest, Operation> call);
        partial void Modify_GetClusterApiCall(ref ApiCall<GetClusterRequest, Cluster> call);
        partial void Modify_ListClustersApiCall(ref ApiCall<ListClustersRequest, ListClustersResponse> call);
        partial void Modify_UpdateClusterApiCall(ref ApiCall<Cluster, Operation> call);
        partial void Modify_DeleteClusterApiCall(ref ApiCall<DeleteClusterRequest, Empty> call);
        partial void Modify_CreateAppProfileApiCall(ref ApiCall<CreateAppProfileRequest, AppProfile> call);
        partial void Modify_GetAppProfileApiCall(ref ApiCall<GetAppProfileRequest, AppProfile> call);
        partial void Modify_ListAppProfilesApiCall(ref ApiCall<ListAppProfilesRequest, ListAppProfilesResponse> call);
        partial void Modify_UpdateAppProfileApiCall(ref ApiCall<UpdateAppProfileRequest, Operation> call);
        partial void Modify_DeleteAppProfileApiCall(ref ApiCall<DeleteAppProfileRequest, Empty> call);
        partial void Modify_GetIamPolicyApiCall(ref ApiCall<GetIamPolicyRequest, Policy> call);
        partial void Modify_SetIamPolicyApiCall(ref ApiCall<SetIamPolicyRequest, Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> call);
        partial void OnConstruction(BigtableInstanceAdmin.BigtableInstanceAdminClient grpcClient, BigtableInstanceAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BigtableInstanceAdmin client.
        /// </summary>
        public override BigtableInstanceAdmin.BigtableInstanceAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings);
        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings);
        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings);
        partial void Modify_PartialUpdateInstanceRequest(ref PartialUpdateInstanceRequest request, ref CallSettings settings);
        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings);
        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings);
        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings);
        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings);
        partial void Modify_Cluster(ref Cluster request, ref CallSettings settings);
        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings);
        partial void Modify_CreateAppProfileRequest(ref CreateAppProfileRequest request, ref CallSettings settings);
        partial void Modify_GetAppProfileRequest(ref GetAppProfileRequest request, ref CallSettings settings);
        partial void Modify_ListAppProfilesRequest(ref ListAppProfilesRequest request, ref CallSettings settings);
        partial void Modify_UpdateAppProfileRequest(ref UpdateAppProfileRequest request, ref CallSettings settings);
        partial void Modify_DeleteAppProfileRequest(ref DeleteAppProfileRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Create an instance within a project.
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
        public override async Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Create an instance within a project.
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
        public override Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                _callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public override OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Gets information about an instance.
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
        public override Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about an instance.
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
        public override Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override Task<ListInstancesResponse> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about instances in a project.
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
        public override ListInstancesResponse ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return _callListInstances.Sync(request, callSettings);
        }

        /// <summary>
        /// Partially updates an instance within a project.
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
        public override async Task<Operation<Instance, UpdateInstanceMetadata>> PartialUpdateInstanceAsync(
            PartialUpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, UpdateInstanceMetadata>(
                await _callPartialUpdateInstance.Async(request, callSettings).ConfigureAwait(false), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Partially updates an instance within a project.
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
        public override Operation<Instance, UpdateInstanceMetadata> PartialUpdateInstance(
            PartialUpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_PartialUpdateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, UpdateInstanceMetadata>(
                _callPartialUpdateInstance.Sync(request, callSettings), PartialUpdateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>PartialUpdateInstance</c>.
        /// </summary>
        public override OperationsClient PartialUpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Delete an instance from a project.
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
        public override Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an instance from a project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            _callDeleteInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override async Task<Operation<Cluster, CreateClusterMetadata>> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, CreateClusterMetadata>(
                await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster within an instance.
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
        public override Operation<Cluster, CreateClusterMetadata> CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new Operation<Cluster, CreateClusterMetadata>(
                _callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCluster</c>.
        /// </summary>
        public override OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Gets information about a cluster.
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
        public override Task<Cluster> GetClusterAsync(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a cluster.
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
        public override Cluster GetCluster(
            GetClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override Task<ListClustersResponse> ListClustersAsync(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about clusters in an instance.
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
        public override ListClustersResponse ListClusters(
            ListClustersRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override async Task<Operation<Cluster, UpdateClusterMetadata>> UpdateClusterAsync(
            Cluster request,
            CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new Operation<Cluster, UpdateClusterMetadata>(
                await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates a cluster within an instance.
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
        public override Operation<Cluster, UpdateClusterMetadata> UpdateCluster(
            Cluster request,
            CallSettings callSettings = null)
        {
            Modify_Cluster(ref request, ref callSettings);
            return new Operation<Cluster, UpdateClusterMetadata>(
                _callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateCluster</c>.
        /// </summary>
        public override OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a cluster from an instance.
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
        public override Task DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a cluster from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            _callDeleteCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
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
        public override Task<AppProfile> CreateAppProfileAsync(
            CreateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Creates an app profile within an instance.
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
        public override AppProfile CreateAppProfile(
            CreateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateAppProfileRequest(ref request, ref callSettings);
            return _callCreateAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
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
        public override Task<AppProfile> GetAppProfileAsync(
            GetAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Gets information about an app profile.
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
        public override AppProfile GetAppProfile(
            GetAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetAppProfileRequest(ref request, ref callSettings);
            return _callGetAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfilesAsync(
            ListAppProfilesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Lists information about app profiles in an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AppProfile"/> resources.
        /// </returns>
        public override PagedEnumerable<ListAppProfilesResponse, AppProfile> ListAppProfiles(
            ListAppProfilesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListAppProfilesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListAppProfilesRequest, ListAppProfilesResponse, AppProfile>(_callListAppProfiles, request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
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
        public override async Task<Operation<AppProfile, UpdateAppProfileMetadata>> UpdateAppProfileAsync(
            UpdateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new Operation<AppProfile, UpdateAppProfileMetadata>(
                await _callUpdateAppProfile.Async(request, callSettings).ConfigureAwait(false), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Updates an app profile within an instance.
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
        public override Operation<AppProfile, UpdateAppProfileMetadata> UpdateAppProfile(
            UpdateAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateAppProfileRequest(ref request, ref callSettings);
            return new Operation<AppProfile, UpdateAppProfileMetadata>(
                _callUpdateAppProfile.Sync(request, callSettings), UpdateAppProfileOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateAppProfile</c>.
        /// </summary>
        public override OperationsClient UpdateAppProfileOperationsClient { get; }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
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
        public override Task DeleteAppProfileAsync(
            DeleteAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            return _callDeleteAppProfile.Async(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// Deletes an app profile from an instance.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteAppProfile(
            DeleteAppProfileRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteAppProfileRequest(ref request, ref callSettings);
            _callDeleteAppProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Sets the access control policy on an instance resource. Replaces any
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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
        /// This is a private alpha release of Cloud Bigtable instance level
        /// permissions. This feature is not currently available to most Cloud Bigtable
        /// customers. This feature might be changed in backward-incompatible ways and
        /// is not recommended for production use. It is not subject to any SLA or
        /// deprecation policy.
        ///
        /// Returns permissions that the caller has on the specified instance resource.
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

    public partial class ListAppProfilesRequest : IPageRequest { }
    public partial class ListAppProfilesResponse : IPageResponse<AppProfile>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<AppProfile> GetEnumerator() => AppProfiles.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class BigtableInstanceAdmin
    {
        public partial class BigtableInstanceAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
