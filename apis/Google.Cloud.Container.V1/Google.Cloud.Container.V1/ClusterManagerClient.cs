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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Container.V1
{
    /// <summary>
    /// Settings for a <see cref="ClusterManagerClient"/>.
    /// </summary>
    public sealed partial class ClusterManagerSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ClusterManagerSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ClusterManagerSettings"/>.
        /// </returns>
        public static ClusterManagerSettings GetDefault() => new ClusterManagerSettings();

        /// <summary>
        /// Constructs a new <see cref="ClusterManagerSettings"/> object with default settings.
        /// </summary>
        public ClusterManagerSettings() { }

        private ClusterManagerSettings(ClusterManagerSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClustersSettings = existing.ListClustersSettings;
            GetClusterSettings = existing.GetClusterSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateNodePoolSettings = existing.UpdateNodePoolSettings;
            SetNodePoolAutoscalingSettings = existing.SetNodePoolAutoscalingSettings;
            SetLoggingServiceSettings = existing.SetLoggingServiceSettings;
            SetMonitoringServiceSettings = existing.SetMonitoringServiceSettings;
            SetAddonsConfigSettings = existing.SetAddonsConfigSettings;
            SetLocationsSettings = existing.SetLocationsSettings;
            UpdateMasterSettings = existing.UpdateMasterSettings;
            SetMasterAuthSettings = existing.SetMasterAuthSettings;
            DeleteClusterSettings = existing.DeleteClusterSettings;
            ListOperationsSettings = existing.ListOperationsSettings;
            GetOperationSettings = existing.GetOperationSettings;
            CancelOperationSettings = existing.CancelOperationSettings;
            GetServerConfigSettings = existing.GetServerConfigSettings;
            ListNodePoolsSettings = existing.ListNodePoolsSettings;
            GetNodePoolSettings = existing.GetNodePoolSettings;
            CreateNodePoolSettings = existing.CreateNodePoolSettings;
            DeleteNodePoolSettings = existing.DeleteNodePoolSettings;
            RollbackNodePoolUpgradeSettings = existing.RollbackNodePoolUpgradeSettings;
            SetNodePoolManagementSettings = existing.SetNodePoolManagementSettings;
            SetLabelsSettings = existing.SetLabelsSettings;
            SetLegacyAbacSettings = existing.SetLegacyAbacSettings;
            StartIPRotationSettings = existing.StartIPRotationSettings;
            CompleteIPRotationSettings = existing.CompleteIPRotationSettings;
            SetNodePoolSizeSettings = existing.SetNodePoolSizeSettings;
            SetNetworkPolicySettings = existing.SetNetworkPolicySettings;
            SetMaintenancePolicySettings = existing.SetMaintenancePolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ClusterManagerSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ClusterManagerClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ClusterManagerClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ClusterManagerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ClusterManagerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ClusterManagerClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ClusterManagerClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ClusterManagerClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ClusterManagerClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListClusters</c> and <c>ClusterManagerClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.ListClusters</c> and
        /// <c>ClusterManagerClient.ListClustersAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
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
        /// <c>ClusterManagerClient.GetCluster</c> and <c>ClusterManagerClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.GetCluster</c> and
        /// <c>ClusterManagerClient.GetClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
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
        /// <c>ClusterManagerClient.CreateCluster</c> and <c>ClusterManagerClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.CreateCluster</c> and
        /// <c>ClusterManagerClient.CreateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
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
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateCluster</c> and <c>ClusterManagerClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.UpdateCluster</c> and
        /// <c>ClusterManagerClient.UpdateClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateClusterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateNodePool</c> and <c>ClusterManagerClient.UpdateNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.UpdateNodePool</c> and
        /// <c>ClusterManagerClient.UpdateNodePoolAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateNodePoolSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolAutoscaling</c> and <c>ClusterManagerClient.SetNodePoolAutoscalingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetNodePoolAutoscaling</c> and
        /// <c>ClusterManagerClient.SetNodePoolAutoscalingAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetNodePoolAutoscalingSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLoggingService</c> and <c>ClusterManagerClient.SetLoggingServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetLoggingService</c> and
        /// <c>ClusterManagerClient.SetLoggingServiceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetLoggingServiceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMonitoringService</c> and <c>ClusterManagerClient.SetMonitoringServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetMonitoringService</c> and
        /// <c>ClusterManagerClient.SetMonitoringServiceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetMonitoringServiceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetAddonsConfig</c> and <c>ClusterManagerClient.SetAddonsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetAddonsConfig</c> and
        /// <c>ClusterManagerClient.SetAddonsConfigAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetAddonsConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLocations</c> and <c>ClusterManagerClient.SetLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetLocations</c> and
        /// <c>ClusterManagerClient.SetLocationsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetLocationsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateMaster</c> and <c>ClusterManagerClient.UpdateMasterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.UpdateMaster</c> and
        /// <c>ClusterManagerClient.UpdateMasterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateMasterSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMasterAuth</c> and <c>ClusterManagerClient.SetMasterAuthAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetMasterAuth</c> and
        /// <c>ClusterManagerClient.SetMasterAuthAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetMasterAuthSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.DeleteCluster</c> and <c>ClusterManagerClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.DeleteCluster</c> and
        /// <c>ClusterManagerClient.DeleteClusterAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
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
        /// <c>ClusterManagerClient.ListOperations</c> and <c>ClusterManagerClient.ListOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.ListOperations</c> and
        /// <c>ClusterManagerClient.ListOperationsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListOperationsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetOperation</c> and <c>ClusterManagerClient.GetOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.GetOperation</c> and
        /// <c>ClusterManagerClient.GetOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CancelOperation</c> and <c>ClusterManagerClient.CancelOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.CancelOperation</c> and
        /// <c>ClusterManagerClient.CancelOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CancelOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetServerConfig</c> and <c>ClusterManagerClient.GetServerConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.GetServerConfig</c> and
        /// <c>ClusterManagerClient.GetServerConfigAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetServerConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListNodePools</c> and <c>ClusterManagerClient.ListNodePoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.ListNodePools</c> and
        /// <c>ClusterManagerClient.ListNodePoolsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListNodePoolsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetNodePool</c> and <c>ClusterManagerClient.GetNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.GetNodePool</c> and
        /// <c>ClusterManagerClient.GetNodePoolAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetNodePoolSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CreateNodePool</c> and <c>ClusterManagerClient.CreateNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.CreateNodePool</c> and
        /// <c>ClusterManagerClient.CreateNodePoolAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateNodePoolSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.DeleteNodePool</c> and <c>ClusterManagerClient.DeleteNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.DeleteNodePool</c> and
        /// <c>ClusterManagerClient.DeleteNodePoolAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteNodePoolSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.RollbackNodePoolUpgrade</c> and <c>ClusterManagerClient.RollbackNodePoolUpgradeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.RollbackNodePoolUpgrade</c> and
        /// <c>ClusterManagerClient.RollbackNodePoolUpgradeAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings RollbackNodePoolUpgradeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolManagement</c> and <c>ClusterManagerClient.SetNodePoolManagementAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetNodePoolManagement</c> and
        /// <c>ClusterManagerClient.SetNodePoolManagementAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetNodePoolManagementSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLabels</c> and <c>ClusterManagerClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetLabels</c> and
        /// <c>ClusterManagerClient.SetLabelsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetLabelsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLegacyAbac</c> and <c>ClusterManagerClient.SetLegacyAbacAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetLegacyAbac</c> and
        /// <c>ClusterManagerClient.SetLegacyAbacAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetLegacyAbacSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.StartIPRotation</c> and <c>ClusterManagerClient.StartIPRotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.StartIPRotation</c> and
        /// <c>ClusterManagerClient.StartIPRotationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings StartIPRotationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CompleteIPRotation</c> and <c>ClusterManagerClient.CompleteIPRotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.CompleteIPRotation</c> and
        /// <c>ClusterManagerClient.CompleteIPRotationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CompleteIPRotationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolSize</c> and <c>ClusterManagerClient.SetNodePoolSizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetNodePoolSize</c> and
        /// <c>ClusterManagerClient.SetNodePoolSizeAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetNodePoolSizeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNetworkPolicy</c> and <c>ClusterManagerClient.SetNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetNetworkPolicy</c> and
        /// <c>ClusterManagerClient.SetNetworkPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetNetworkPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMaintenancePolicy</c> and <c>ClusterManagerClient.SetMaintenancePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ClusterManagerClient.SetMaintenancePolicy</c> and
        /// <c>ClusterManagerClient.SetMaintenancePolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetMaintenancePolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ClusterManagerSettings"/> object.</returns>
        public ClusterManagerSettings Clone() => new ClusterManagerSettings(this);
    }

    /// <summary>
    /// ClusterManager client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ClusterManagerClient
    {
        /// <summary>
        /// The default endpoint for the ClusterManager service, which is a host of "container.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("container.googleapis.com", 443);

        /// <summary>
        /// The default ClusterManager scopes.
        /// </summary>
        /// <remarks>
        /// The default ClusterManager scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
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
        /// Asynchronously creates a <see cref="ClusterManagerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ClusterManagerClient"/>.</returns>
        public static async Task<ClusterManagerClient> CreateAsync(ServiceEndpoint endpoint = null, ClusterManagerSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ClusterManagerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterManagerClient"/>.</returns>
        public static ClusterManagerClient Create(ServiceEndpoint endpoint = null, ClusterManagerSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ClusterManagerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterManagerClient"/>.</returns>
        public static ClusterManagerClient Create(Channel channel, ClusterManagerSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ClusterManager.ClusterManagerClient grpcClient = new ClusterManager.ClusterManagerClient(channel);
            return new ClusterManagerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ClusterManagerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ClusterManagerSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ClusterManagerSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ClusterManagerSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ClusterManager client.
        /// </summary>
        public virtual ClusterManager.ClusterManagerClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            string projectId,
            string zone,
            CallSettings callSettings = null) => ListClustersAsync(
                new ListClustersRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListClustersResponse> ListClustersAsync(
            string projectId,
            string zone,
            CancellationToken cancellationToken) => ListClustersAsync(
                projectId,
                zone,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListClustersResponse ListClusters(
            string projectId,
            string zone,
            CallSettings callSettings = null) => ListClusters(
                new ListClustersRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
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
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
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
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => GetClusterAsync(
                new GetClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to retrieve.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Cluster> GetClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            CancellationToken cancellationToken) => GetClusterAsync(
                projectId,
                zone,
                clusterId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Cluster GetCluster(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => GetCluster(
                new GetClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Gets the details of a specific cluster.
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
        /// Gets the details of a specific cluster.
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
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="cluster">
        /// A [cluster
        /// resource](/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateClusterAsync(
            string projectId,
            string zone,
            Cluster cluster,
            CallSettings callSettings = null) => CreateClusterAsync(
                new CreateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="cluster">
        /// A [cluster
        /// resource](/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateClusterAsync(
            string projectId,
            string zone,
            Cluster cluster,
            CancellationToken cancellationToken) => CreateClusterAsync(
                projectId,
                zone,
                cluster,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="cluster">
        /// A [cluster
        /// resource](/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation CreateCluster(
            string projectId,
            string zone,
            Cluster cluster,
            CallSettings callSettings = null) => CreateCluster(
                new CreateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    Cluster = GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                },
                callSettings);

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
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
        public virtual Task<Operation> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
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
        public virtual Operation CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="update">
        /// A description of the update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> UpdateClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            ClusterUpdate update,
            CallSettings callSettings = null) => UpdateClusterAsync(
                new UpdateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Update = GaxPreconditions.CheckNotNull(update, nameof(update)),
                },
                callSettings);

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="update">
        /// A description of the update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> UpdateClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            ClusterUpdate update,
            CancellationToken cancellationToken) => UpdateClusterAsync(
                projectId,
                zone,
                clusterId,
                update,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="update">
        /// A description of the update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation UpdateCluster(
            string projectId,
            string zone,
            string clusterId,
            ClusterUpdate update,
            CallSettings callSettings = null) => UpdateCluster(
                new UpdateClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Update = GaxPreconditions.CheckNotNull(update, nameof(update)),
                },
                callSettings);

        /// <summary>
        /// Updates the settings of a specific cluster.
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
        public virtual Task<Operation> UpdateClusterAsync(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
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
        public virtual Operation UpdateCluster(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the version and/or image type of a specific node pool.
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
        public virtual Task<Operation> UpdateNodePoolAsync(
            UpdateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the version and/or image type of a specific node pool.
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
        public virtual Operation UpdateNodePool(
            UpdateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the autoscaling settings of a specific node pool.
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
        public virtual Task<Operation> SetNodePoolAutoscalingAsync(
            SetNodePoolAutoscalingRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the autoscaling settings of a specific node pool.
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
        public virtual Operation SetNodePoolAutoscaling(
            SetNodePoolAutoscalingRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the logging service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="loggingService">
        /// The logging service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLoggingServiceAsync(
            string projectId,
            string zone,
            string clusterId,
            string loggingService,
            CallSettings callSettings = null) => SetLoggingServiceAsync(
                new SetLoggingServiceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    LoggingService = GaxPreconditions.CheckNotNullOrEmpty(loggingService, nameof(loggingService)),
                },
                callSettings);

        /// <summary>
        /// Sets the logging service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="loggingService">
        /// The logging service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLoggingServiceAsync(
            string projectId,
            string zone,
            string clusterId,
            string loggingService,
            CancellationToken cancellationToken) => SetLoggingServiceAsync(
                projectId,
                zone,
                clusterId,
                loggingService,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the logging service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="loggingService">
        /// The logging service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetLoggingService(
            string projectId,
            string zone,
            string clusterId,
            string loggingService,
            CallSettings callSettings = null) => SetLoggingService(
                new SetLoggingServiceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    LoggingService = GaxPreconditions.CheckNotNullOrEmpty(loggingService, nameof(loggingService)),
                },
                callSettings);

        /// <summary>
        /// Sets the logging service of a specific cluster.
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
        public virtual Task<Operation> SetLoggingServiceAsync(
            SetLoggingServiceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the logging service of a specific cluster.
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
        public virtual Operation SetLoggingService(
            SetLoggingServiceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="monitoringService">
        /// The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetMonitoringServiceAsync(
            string projectId,
            string zone,
            string clusterId,
            string monitoringService,
            CallSettings callSettings = null) => SetMonitoringServiceAsync(
                new SetMonitoringServiceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MonitoringService = GaxPreconditions.CheckNotNullOrEmpty(monitoringService, nameof(monitoringService)),
                },
                callSettings);

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="monitoringService">
        /// The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetMonitoringServiceAsync(
            string projectId,
            string zone,
            string clusterId,
            string monitoringService,
            CancellationToken cancellationToken) => SetMonitoringServiceAsync(
                projectId,
                zone,
                clusterId,
                monitoringService,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="monitoringService">
        /// The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        ///
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetMonitoringService(
            string projectId,
            string zone,
            string clusterId,
            string monitoringService,
            CallSettings callSettings = null) => SetMonitoringService(
                new SetMonitoringServiceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MonitoringService = GaxPreconditions.CheckNotNullOrEmpty(monitoringService, nameof(monitoringService)),
                },
                callSettings);

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
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
        public virtual Task<Operation> SetMonitoringServiceAsync(
            SetMonitoringServiceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
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
        public virtual Operation SetMonitoringService(
            SetMonitoringServiceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the addons of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="addonsConfig">
        /// The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetAddonsConfigAsync(
            string projectId,
            string zone,
            string clusterId,
            AddonsConfig addonsConfig,
            CallSettings callSettings = null) => SetAddonsConfigAsync(
                new SetAddonsConfigRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    AddonsConfig = GaxPreconditions.CheckNotNull(addonsConfig, nameof(addonsConfig)),
                },
                callSettings);

        /// <summary>
        /// Sets the addons of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="addonsConfig">
        /// The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetAddonsConfigAsync(
            string projectId,
            string zone,
            string clusterId,
            AddonsConfig addonsConfig,
            CancellationToken cancellationToken) => SetAddonsConfigAsync(
                projectId,
                zone,
                clusterId,
                addonsConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the addons of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="addonsConfig">
        /// The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetAddonsConfig(
            string projectId,
            string zone,
            string clusterId,
            AddonsConfig addonsConfig,
            CallSettings callSettings = null) => SetAddonsConfig(
                new SetAddonsConfigRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    AddonsConfig = GaxPreconditions.CheckNotNull(addonsConfig, nameof(addonsConfig)),
                },
                callSettings);

        /// <summary>
        /// Sets the addons of a specific cluster.
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
        public virtual Task<Operation> SetAddonsConfigAsync(
            SetAddonsConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the addons of a specific cluster.
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
        public virtual Operation SetAddonsConfig(
            SetAddonsConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the locations of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="locations">
        /// The desired list of Google Compute Engine
        /// [locations](/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        ///
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLocationsAsync(
            string projectId,
            string zone,
            string clusterId,
            IEnumerable<string> locations,
            CallSettings callSettings = null) => SetLocationsAsync(
                new SetLocationsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Locations = { GaxPreconditions.CheckNotNull(locations, nameof(locations)) },
                },
                callSettings);

        /// <summary>
        /// Sets the locations of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="locations">
        /// The desired list of Google Compute Engine
        /// [locations](/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        ///
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLocationsAsync(
            string projectId,
            string zone,
            string clusterId,
            IEnumerable<string> locations,
            CancellationToken cancellationToken) => SetLocationsAsync(
                projectId,
                zone,
                clusterId,
                locations,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the locations of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="locations">
        /// The desired list of Google Compute Engine
        /// [locations](/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        ///
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetLocations(
            string projectId,
            string zone,
            string clusterId,
            IEnumerable<string> locations,
            CallSettings callSettings = null) => SetLocations(
                new SetLocationsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Locations = { GaxPreconditions.CheckNotNull(locations, nameof(locations)) },
                },
                callSettings);

        /// <summary>
        /// Sets the locations of a specific cluster.
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
        public virtual Task<Operation> SetLocationsAsync(
            SetLocationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the locations of a specific cluster.
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
        public virtual Operation SetLocations(
            SetLocationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the master of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="masterVersion">
        /// The Kubernetes version to change the master to. The only valid value is the
        /// latest supported version. Use "-" to have the server automatically select
        /// the latest version.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> UpdateMasterAsync(
            string projectId,
            string zone,
            string clusterId,
            string masterVersion,
            CallSettings callSettings = null) => UpdateMasterAsync(
                new UpdateMasterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MasterVersion = GaxPreconditions.CheckNotNullOrEmpty(masterVersion, nameof(masterVersion)),
                },
                callSettings);

        /// <summary>
        /// Updates the master of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="masterVersion">
        /// The Kubernetes version to change the master to. The only valid value is the
        /// latest supported version. Use "-" to have the server automatically select
        /// the latest version.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> UpdateMasterAsync(
            string projectId,
            string zone,
            string clusterId,
            string masterVersion,
            CancellationToken cancellationToken) => UpdateMasterAsync(
                projectId,
                zone,
                clusterId,
                masterVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the master of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to upgrade.
        /// </param>
        /// <param name="masterVersion">
        /// The Kubernetes version to change the master to. The only valid value is the
        /// latest supported version. Use "-" to have the server automatically select
        /// the latest version.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation UpdateMaster(
            string projectId,
            string zone,
            string clusterId,
            string masterVersion,
            CallSettings callSettings = null) => UpdateMaster(
                new UpdateMasterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MasterVersion = GaxPreconditions.CheckNotNullOrEmpty(masterVersion, nameof(masterVersion)),
                },
                callSettings);

        /// <summary>
        /// Updates the master of a specific cluster.
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
        public virtual Task<Operation> UpdateMasterAsync(
            UpdateMasterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the master of a specific cluster.
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
        public virtual Operation UpdateMaster(
            UpdateMasterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used to set master auth materials. Currently supports :-
        /// Changing the admin password of a specific cluster.
        /// This can be either via password generation or explicitly set the password.
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
        public virtual Task<Operation> SetMasterAuthAsync(
            SetMasterAuthRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used to set master auth materials. Currently supports :-
        /// Changing the admin password of a specific cluster.
        /// This can be either via password generation or explicitly set the password.
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
        public virtual Operation SetMasterAuth(
            SetMasterAuthRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> DeleteClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => DeleteClusterAsync(
                new DeleteClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> DeleteClusterAsync(
            string projectId,
            string zone,
            string clusterId,
            CancellationToken cancellationToken) => DeleteClusterAsync(
                projectId,
                zone,
                clusterId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation DeleteCluster(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => DeleteCluster(
                new DeleteClusterRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
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
        public virtual Task<Operation> DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
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
        public virtual Operation DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for, or `-` for all zones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(
            string projectId,
            string zone,
            CallSettings callSettings = null) => ListOperationsAsync(
                new ListOperationsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for, or `-` for all zones.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListOperationsResponse> ListOperationsAsync(
            string projectId,
            string zone,
            CancellationToken cancellationToken) => ListOperationsAsync(
                projectId,
                zone,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for, or `-` for all zones.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListOperationsResponse ListOperations(
            string projectId,
            string zone,
            CallSettings callSettings = null) => ListOperations(
                new ListOperationsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
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
        public virtual Task<ListOperationsResponse> ListOperationsAsync(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
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
        public virtual ListOperationsResponse ListOperations(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> GetOperationAsync(
            string projectId,
            string zone,
            string operationId,
            CallSettings callSettings = null) => GetOperationAsync(
                new GetOperationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    OperationId = GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> GetOperationAsync(
            string projectId,
            string zone,
            string operationId,
            CancellationToken cancellationToken) => GetOperationAsync(
                projectId,
                zone,
                operationId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation GetOperation(
            string projectId,
            string zone,
            string operationId,
            CallSettings callSettings = null) => GetOperation(
                new GetOperationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    OperationId = GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
                },
                callSettings);

        /// <summary>
        /// Gets the specified operation.
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
        public virtual Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the specified operation.
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
        public virtual Operation GetOperation(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the operation resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task CancelOperationAsync(
            string projectId,
            string zone,
            string operationId,
            CallSettings callSettings = null) => CancelOperationAsync(
                new CancelOperationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    OperationId = GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
                },
                callSettings);

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the operation resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task CancelOperationAsync(
            string projectId,
            string zone,
            string operationId,
            CancellationToken cancellationToken) => CancelOperationAsync(
                projectId,
                zone,
                operationId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the operation resides.
        /// </param>
        /// <param name="operationId">
        /// The server-assigned `name` of the operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CancelOperation(
            string projectId,
            string zone,
            string operationId,
            CallSettings callSettings = null) => CancelOperation(
                new CancelOperationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    OperationId = GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
                },
                callSettings);

        /// <summary>
        /// Cancels the specified operation.
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
        public virtual Task CancelOperationAsync(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CancelOperation(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns configuration info about the Container Engine service.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ServerConfig> GetServerConfigAsync(
            string projectId,
            string zone,
            CallSettings callSettings = null) => GetServerConfigAsync(
                new GetServerConfigRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Returns configuration info about the Container Engine service.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ServerConfig> GetServerConfigAsync(
            string projectId,
            string zone,
            CancellationToken cancellationToken) => GetServerConfigAsync(
                projectId,
                zone,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns configuration info about the Container Engine service.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine [zone](/compute/docs/zones#available)
        /// to return operations for.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServerConfig GetServerConfig(
            string projectId,
            string zone,
            CallSettings callSettings = null) => GetServerConfig(
                new GetServerConfigRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                },
                callSettings);

        /// <summary>
        /// Returns configuration info about the Container Engine service.
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
        public virtual Task<ServerConfig> GetServerConfigAsync(
            GetServerConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns configuration info about the Container Engine service.
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
        public virtual ServerConfig GetServerConfig(
            GetServerConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListNodePoolsResponse> ListNodePoolsAsync(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => ListNodePoolsAsync(
                new ListNodePoolsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListNodePoolsResponse> ListNodePoolsAsync(
            string projectId,
            string zone,
            string clusterId,
            CancellationToken cancellationToken) => ListNodePoolsAsync(
                projectId,
                zone,
                clusterId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListNodePoolsResponse ListNodePools(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => ListNodePools(
                new ListNodePoolsRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Lists the node pools for a cluster.
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
        public virtual Task<ListNodePoolsResponse> ListNodePoolsAsync(
            ListNodePoolsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the node pools for a cluster.
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
        public virtual ListNodePoolsResponse ListNodePools(
            ListNodePoolsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the node pool requested.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NodePool> GetNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => GetNodePoolAsync(
                new GetNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the node pool requested.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NodePool> GetNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CancellationToken cancellationToken) => GetNodePoolAsync(
                projectId,
                zone,
                clusterId,
                nodePoolId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the node pool requested.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NodePool GetNodePool(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => GetNodePool(
                new GetNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Retrieves the node pool requested.
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
        public virtual Task<NodePool> GetNodePoolAsync(
            GetNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves the node pool requested.
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
        public virtual NodePool GetNodePool(
            GetNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePool">
        /// The node pool to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            NodePool nodePool,
            CallSettings callSettings = null) => CreateNodePoolAsync(
                new CreateNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePool = GaxPreconditions.CheckNotNull(nodePool, nameof(nodePool)),
                },
                callSettings);

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePool">
        /// The node pool to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CreateNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            NodePool nodePool,
            CancellationToken cancellationToken) => CreateNodePoolAsync(
                projectId,
                zone,
                clusterId,
                nodePool,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePool">
        /// The node pool to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation CreateNodePool(
            string projectId,
            string zone,
            string clusterId,
            NodePool nodePool,
            CallSettings callSettings = null) => CreateNodePool(
                new CreateNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePool = GaxPreconditions.CheckNotNull(nodePool, nameof(nodePool)),
                },
                callSettings);

        /// <summary>
        /// Creates a node pool for a cluster.
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
        public virtual Task<Operation> CreateNodePoolAsync(
            CreateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a node pool for a cluster.
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
        public virtual Operation CreateNodePool(
            CreateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> DeleteNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => DeleteNodePoolAsync(
                new DeleteNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> DeleteNodePoolAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CancellationToken cancellationToken) => DeleteNodePoolAsync(
                projectId,
                zone,
                clusterId,
                nodePoolId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation DeleteNodePool(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => DeleteNodePool(
                new DeleteNodePoolRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Deletes a node pool from a cluster.
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
        public virtual Task<Operation> DeleteNodePoolAsync(
            DeleteNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
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
        public virtual Operation DeleteNodePool(
            DeleteNodePoolRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to rollback.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to rollback.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> RollbackNodePoolUpgradeAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => RollbackNodePoolUpgradeAsync(
                new RollbackNodePoolUpgradeRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to rollback.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to rollback.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> RollbackNodePoolUpgradeAsync(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CancellationToken cancellationToken) => RollbackNodePoolUpgradeAsync(
                projectId,
                zone,
                clusterId,
                nodePoolId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to rollback.
        /// </param>
        /// <param name="nodePoolId">
        /// The name of the node pool to rollback.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation RollbackNodePoolUpgrade(
            string projectId,
            string zone,
            string clusterId,
            string nodePoolId,
            CallSettings callSettings = null) => RollbackNodePoolUpgrade(
                new RollbackNodePoolUpgradeRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NodePoolId = GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
                },
                callSettings);

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
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
        public virtual Task<Operation> RollbackNodePoolUpgradeAsync(
            RollbackNodePoolUpgradeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
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
        public virtual Operation RollbackNodePoolUpgrade(
            RollbackNodePoolUpgradeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
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
        public virtual Task<Operation> SetNodePoolManagementAsync(
            SetNodePoolManagementRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
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
        public virtual Operation SetNodePoolManagement(
            SetNodePoolManagementRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets labels on a cluster.
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
        public virtual Task<Operation> SetLabelsAsync(
            SetLabelsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets labels on a cluster.
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
        public virtual Operation SetLabels(
            SetLabelsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="enabled">
        /// Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLegacyAbacAsync(
            string projectId,
            string zone,
            string clusterId,
            bool enabled,
            CallSettings callSettings = null) => SetLegacyAbacAsync(
                new SetLegacyAbacRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Enabled = enabled,
                },
                callSettings);

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="enabled">
        /// Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetLegacyAbacAsync(
            string projectId,
            string zone,
            string clusterId,
            bool enabled,
            CancellationToken cancellationToken) => SetLegacyAbacAsync(
                projectId,
                zone,
                clusterId,
                enabled,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="enabled">
        /// Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetLegacyAbac(
            string projectId,
            string zone,
            string clusterId,
            bool enabled,
            CallSettings callSettings = null) => SetLegacyAbac(
                new SetLegacyAbacRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    Enabled = enabled,
                },
                callSettings);

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
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
        public virtual Task<Operation> SetLegacyAbacAsync(
            SetLegacyAbacRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
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
        public virtual Operation SetLegacyAbac(
            SetLegacyAbacRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> StartIPRotationAsync(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => StartIPRotationAsync(
                new StartIPRotationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Start master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> StartIPRotationAsync(
            string projectId,
            string zone,
            string clusterId,
            CancellationToken cancellationToken) => StartIPRotationAsync(
                projectId,
                zone,
                clusterId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation StartIPRotation(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => StartIPRotation(
                new StartIPRotationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Start master IP rotation.
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
        public virtual Task<Operation> StartIPRotationAsync(
            StartIPRotationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start master IP rotation.
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
        public virtual Operation StartIPRotation(
            StartIPRotationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CompleteIPRotationAsync(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => CompleteIPRotationAsync(
                new CompleteIPRotationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> CompleteIPRotationAsync(
            string projectId,
            string zone,
            string clusterId,
            CancellationToken cancellationToken) => CompleteIPRotationAsync(
                projectId,
                zone,
                clusterId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation CompleteIPRotation(
            string projectId,
            string zone,
            string clusterId,
            CallSettings callSettings = null) => CompleteIPRotation(
                new CompleteIPRotationRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                },
                callSettings);

        /// <summary>
        /// Completes master IP rotation.
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
        public virtual Task<Operation> CompleteIPRotationAsync(
            CompleteIPRotationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Completes master IP rotation.
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
        public virtual Operation CompleteIPRotation(
            CompleteIPRotationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the size of a specific node pool.
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
        public virtual Task<Operation> SetNodePoolSizeAsync(
            SetNodePoolSizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the size of a specific node pool.
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
        public virtual Operation SetNodePoolSize(
            SetNodePoolSizeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="networkPolicy">
        /// Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetNetworkPolicyAsync(
            string projectId,
            string zone,
            string clusterId,
            NetworkPolicy networkPolicy,
            CallSettings callSettings = null) => SetNetworkPolicyAsync(
                new SetNetworkPolicyRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NetworkPolicy = GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
                },
                callSettings);

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="networkPolicy">
        /// Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetNetworkPolicyAsync(
            string projectId,
            string zone,
            string clusterId,
            NetworkPolicy networkPolicy,
            CancellationToken cancellationToken) => SetNetworkPolicyAsync(
                projectId,
                zone,
                clusterId,
                networkPolicy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster.
        /// </param>
        /// <param name="networkPolicy">
        /// Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetNetworkPolicy(
            string projectId,
            string zone,
            string clusterId,
            NetworkPolicy networkPolicy,
            CallSettings callSettings = null) => SetNetworkPolicy(
                new SetNetworkPolicyRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    NetworkPolicy = GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
                },
                callSettings);

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
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
        public virtual Task<Operation> SetNetworkPolicyAsync(
            SetNetworkPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
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
        public virtual Operation SetNetworkPolicy(
            SetNetworkPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetMaintenancePolicyAsync(
            string projectId,
            string zone,
            string clusterId,
            MaintenancePolicy maintenancePolicy,
            CallSettings callSettings = null) => SetMaintenancePolicyAsync(
                new SetMaintenancePolicyRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MaintenancePolicy = GaxPreconditions.CheckNotNull(maintenancePolicy, nameof(maintenancePolicy)),
                },
                callSettings);

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation> SetMaintenancePolicyAsync(
            string projectId,
            string zone,
            string clusterId,
            MaintenancePolicy maintenancePolicy,
            CancellationToken cancellationToken) => SetMaintenancePolicyAsync(
                projectId,
                zone,
                clusterId,
                maintenancePolicy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// The name of the Google Compute Engine
        /// [zone](/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation SetMaintenancePolicy(
            string projectId,
            string zone,
            string clusterId,
            MaintenancePolicy maintenancePolicy,
            CallSettings callSettings = null) => SetMaintenancePolicy(
                new SetMaintenancePolicyRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Zone = GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                    ClusterId = GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                    MaintenancePolicy = GaxPreconditions.CheckNotNull(maintenancePolicy, nameof(maintenancePolicy)),
                },
                callSettings);

        /// <summary>
        /// Sets the maintenance policy for a cluster.
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
        public virtual Task<Operation> SetMaintenancePolicyAsync(
            SetMaintenancePolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
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
        public virtual Operation SetMaintenancePolicy(
            SetMaintenancePolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// ClusterManager client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ClusterManagerClientImpl : ClusterManagerClient
    {
        private readonly ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;
        private readonly ApiCall<GetClusterRequest, Cluster> _callGetCluster;
        private readonly ApiCall<CreateClusterRequest, Operation> _callCreateCluster;
        private readonly ApiCall<UpdateClusterRequest, Operation> _callUpdateCluster;
        private readonly ApiCall<UpdateNodePoolRequest, Operation> _callUpdateNodePool;
        private readonly ApiCall<SetNodePoolAutoscalingRequest, Operation> _callSetNodePoolAutoscaling;
        private readonly ApiCall<SetLoggingServiceRequest, Operation> _callSetLoggingService;
        private readonly ApiCall<SetMonitoringServiceRequest, Operation> _callSetMonitoringService;
        private readonly ApiCall<SetAddonsConfigRequest, Operation> _callSetAddonsConfig;
        private readonly ApiCall<SetLocationsRequest, Operation> _callSetLocations;
        private readonly ApiCall<UpdateMasterRequest, Operation> _callUpdateMaster;
        private readonly ApiCall<SetMasterAuthRequest, Operation> _callSetMasterAuth;
        private readonly ApiCall<DeleteClusterRequest, Operation> _callDeleteCluster;
        private readonly ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;
        private readonly ApiCall<GetOperationRequest, Operation> _callGetOperation;
        private readonly ApiCall<CancelOperationRequest, Empty> _callCancelOperation;
        private readonly ApiCall<GetServerConfigRequest, ServerConfig> _callGetServerConfig;
        private readonly ApiCall<ListNodePoolsRequest, ListNodePoolsResponse> _callListNodePools;
        private readonly ApiCall<GetNodePoolRequest, NodePool> _callGetNodePool;
        private readonly ApiCall<CreateNodePoolRequest, Operation> _callCreateNodePool;
        private readonly ApiCall<DeleteNodePoolRequest, Operation> _callDeleteNodePool;
        private readonly ApiCall<RollbackNodePoolUpgradeRequest, Operation> _callRollbackNodePoolUpgrade;
        private readonly ApiCall<SetNodePoolManagementRequest, Operation> _callSetNodePoolManagement;
        private readonly ApiCall<SetLabelsRequest, Operation> _callSetLabels;
        private readonly ApiCall<SetLegacyAbacRequest, Operation> _callSetLegacyAbac;
        private readonly ApiCall<StartIPRotationRequest, Operation> _callStartIPRotation;
        private readonly ApiCall<CompleteIPRotationRequest, Operation> _callCompleteIPRotation;
        private readonly ApiCall<SetNodePoolSizeRequest, Operation> _callSetNodePoolSize;
        private readonly ApiCall<SetNetworkPolicyRequest, Operation> _callSetNetworkPolicy;
        private readonly ApiCall<SetMaintenancePolicyRequest, Operation> _callSetMaintenancePolicy;

        /// <summary>
        /// Constructs a client wrapper for the ClusterManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ClusterManagerSettings"/> used within this client </param>
        public ClusterManagerClientImpl(ClusterManager.ClusterManagerClient grpcClient, ClusterManagerSettings settings)
        {
            GrpcClient = grpcClient;
            ClusterManagerSettings effectiveSettings = settings ?? ClusterManagerSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(
                GrpcClient.ListClustersAsync, GrpcClient.ListClusters, effectiveSettings.ListClustersSettings);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(
                GrpcClient.GetClusterAsync, GrpcClient.GetCluster, effectiveSettings.GetClusterSettings);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, Operation>(
                GrpcClient.CreateClusterAsync, GrpcClient.CreateCluster, effectiveSettings.CreateClusterSettings);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, Operation>(
                GrpcClient.UpdateClusterAsync, GrpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings);
            _callUpdateNodePool = clientHelper.BuildApiCall<UpdateNodePoolRequest, Operation>(
                GrpcClient.UpdateNodePoolAsync, GrpcClient.UpdateNodePool, effectiveSettings.UpdateNodePoolSettings);
            _callSetNodePoolAutoscaling = clientHelper.BuildApiCall<SetNodePoolAutoscalingRequest, Operation>(
                GrpcClient.SetNodePoolAutoscalingAsync, GrpcClient.SetNodePoolAutoscaling, effectiveSettings.SetNodePoolAutoscalingSettings);
            _callSetLoggingService = clientHelper.BuildApiCall<SetLoggingServiceRequest, Operation>(
                GrpcClient.SetLoggingServiceAsync, GrpcClient.SetLoggingService, effectiveSettings.SetLoggingServiceSettings);
            _callSetMonitoringService = clientHelper.BuildApiCall<SetMonitoringServiceRequest, Operation>(
                GrpcClient.SetMonitoringServiceAsync, GrpcClient.SetMonitoringService, effectiveSettings.SetMonitoringServiceSettings);
            _callSetAddonsConfig = clientHelper.BuildApiCall<SetAddonsConfigRequest, Operation>(
                GrpcClient.SetAddonsConfigAsync, GrpcClient.SetAddonsConfig, effectiveSettings.SetAddonsConfigSettings);
            _callSetLocations = clientHelper.BuildApiCall<SetLocationsRequest, Operation>(
                GrpcClient.SetLocationsAsync, GrpcClient.SetLocations, effectiveSettings.SetLocationsSettings);
            _callUpdateMaster = clientHelper.BuildApiCall<UpdateMasterRequest, Operation>(
                GrpcClient.UpdateMasterAsync, GrpcClient.UpdateMaster, effectiveSettings.UpdateMasterSettings);
            _callSetMasterAuth = clientHelper.BuildApiCall<SetMasterAuthRequest, Operation>(
                GrpcClient.SetMasterAuthAsync, GrpcClient.SetMasterAuth, effectiveSettings.SetMasterAuthSettings);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, Operation>(
                GrpcClient.DeleteClusterAsync, GrpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings);
            _callListOperations = clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>(
                GrpcClient.ListOperationsAsync, GrpcClient.ListOperations, effectiveSettings.ListOperationsSettings);
            _callGetOperation = clientHelper.BuildApiCall<GetOperationRequest, Operation>(
                GrpcClient.GetOperationAsync, GrpcClient.GetOperation, effectiveSettings.GetOperationSettings);
            _callCancelOperation = clientHelper.BuildApiCall<CancelOperationRequest, Empty>(
                GrpcClient.CancelOperationAsync, GrpcClient.CancelOperation, effectiveSettings.CancelOperationSettings);
            _callGetServerConfig = clientHelper.BuildApiCall<GetServerConfigRequest, ServerConfig>(
                GrpcClient.GetServerConfigAsync, GrpcClient.GetServerConfig, effectiveSettings.GetServerConfigSettings);
            _callListNodePools = clientHelper.BuildApiCall<ListNodePoolsRequest, ListNodePoolsResponse>(
                GrpcClient.ListNodePoolsAsync, GrpcClient.ListNodePools, effectiveSettings.ListNodePoolsSettings);
            _callGetNodePool = clientHelper.BuildApiCall<GetNodePoolRequest, NodePool>(
                GrpcClient.GetNodePoolAsync, GrpcClient.GetNodePool, effectiveSettings.GetNodePoolSettings);
            _callCreateNodePool = clientHelper.BuildApiCall<CreateNodePoolRequest, Operation>(
                GrpcClient.CreateNodePoolAsync, GrpcClient.CreateNodePool, effectiveSettings.CreateNodePoolSettings);
            _callDeleteNodePool = clientHelper.BuildApiCall<DeleteNodePoolRequest, Operation>(
                GrpcClient.DeleteNodePoolAsync, GrpcClient.DeleteNodePool, effectiveSettings.DeleteNodePoolSettings);
            _callRollbackNodePoolUpgrade = clientHelper.BuildApiCall<RollbackNodePoolUpgradeRequest, Operation>(
                GrpcClient.RollbackNodePoolUpgradeAsync, GrpcClient.RollbackNodePoolUpgrade, effectiveSettings.RollbackNodePoolUpgradeSettings);
            _callSetNodePoolManagement = clientHelper.BuildApiCall<SetNodePoolManagementRequest, Operation>(
                GrpcClient.SetNodePoolManagementAsync, GrpcClient.SetNodePoolManagement, effectiveSettings.SetNodePoolManagementSettings);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsRequest, Operation>(
                GrpcClient.SetLabelsAsync, GrpcClient.SetLabels, effectiveSettings.SetLabelsSettings);
            _callSetLegacyAbac = clientHelper.BuildApiCall<SetLegacyAbacRequest, Operation>(
                GrpcClient.SetLegacyAbacAsync, GrpcClient.SetLegacyAbac, effectiveSettings.SetLegacyAbacSettings);
            _callStartIPRotation = clientHelper.BuildApiCall<StartIPRotationRequest, Operation>(
                GrpcClient.StartIPRotationAsync, GrpcClient.StartIPRotation, effectiveSettings.StartIPRotationSettings);
            _callCompleteIPRotation = clientHelper.BuildApiCall<CompleteIPRotationRequest, Operation>(
                GrpcClient.CompleteIPRotationAsync, GrpcClient.CompleteIPRotation, effectiveSettings.CompleteIPRotationSettings);
            _callSetNodePoolSize = clientHelper.BuildApiCall<SetNodePoolSizeRequest, Operation>(
                GrpcClient.SetNodePoolSizeAsync, GrpcClient.SetNodePoolSize, effectiveSettings.SetNodePoolSizeSettings);
            _callSetNetworkPolicy = clientHelper.BuildApiCall<SetNetworkPolicyRequest, Operation>(
                GrpcClient.SetNetworkPolicyAsync, GrpcClient.SetNetworkPolicy, effectiveSettings.SetNetworkPolicySettings);
            _callSetMaintenancePolicy = clientHelper.BuildApiCall<SetMaintenancePolicyRequest, Operation>(
                GrpcClient.SetMaintenancePolicyAsync, GrpcClient.SetMaintenancePolicy, effectiveSettings.SetMaintenancePolicySettings);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            Modify_ApiCall(ref _callUpdateNodePool);
            Modify_UpdateNodePoolApiCall(ref _callUpdateNodePool);
            Modify_ApiCall(ref _callSetNodePoolAutoscaling);
            Modify_SetNodePoolAutoscalingApiCall(ref _callSetNodePoolAutoscaling);
            Modify_ApiCall(ref _callSetLoggingService);
            Modify_SetLoggingServiceApiCall(ref _callSetLoggingService);
            Modify_ApiCall(ref _callSetMonitoringService);
            Modify_SetMonitoringServiceApiCall(ref _callSetMonitoringService);
            Modify_ApiCall(ref _callSetAddonsConfig);
            Modify_SetAddonsConfigApiCall(ref _callSetAddonsConfig);
            Modify_ApiCall(ref _callSetLocations);
            Modify_SetLocationsApiCall(ref _callSetLocations);
            Modify_ApiCall(ref _callUpdateMaster);
            Modify_UpdateMasterApiCall(ref _callUpdateMaster);
            Modify_ApiCall(ref _callSetMasterAuth);
            Modify_SetMasterAuthApiCall(ref _callSetMasterAuth);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            Modify_ApiCall(ref _callListOperations);
            Modify_ListOperationsApiCall(ref _callListOperations);
            Modify_ApiCall(ref _callGetOperation);
            Modify_GetOperationApiCall(ref _callGetOperation);
            Modify_ApiCall(ref _callCancelOperation);
            Modify_CancelOperationApiCall(ref _callCancelOperation);
            Modify_ApiCall(ref _callGetServerConfig);
            Modify_GetServerConfigApiCall(ref _callGetServerConfig);
            Modify_ApiCall(ref _callListNodePools);
            Modify_ListNodePoolsApiCall(ref _callListNodePools);
            Modify_ApiCall(ref _callGetNodePool);
            Modify_GetNodePoolApiCall(ref _callGetNodePool);
            Modify_ApiCall(ref _callCreateNodePool);
            Modify_CreateNodePoolApiCall(ref _callCreateNodePool);
            Modify_ApiCall(ref _callDeleteNodePool);
            Modify_DeleteNodePoolApiCall(ref _callDeleteNodePool);
            Modify_ApiCall(ref _callRollbackNodePoolUpgrade);
            Modify_RollbackNodePoolUpgradeApiCall(ref _callRollbackNodePoolUpgrade);
            Modify_ApiCall(ref _callSetNodePoolManagement);
            Modify_SetNodePoolManagementApiCall(ref _callSetNodePoolManagement);
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            Modify_ApiCall(ref _callSetLegacyAbac);
            Modify_SetLegacyAbacApiCall(ref _callSetLegacyAbac);
            Modify_ApiCall(ref _callStartIPRotation);
            Modify_StartIPRotationApiCall(ref _callStartIPRotation);
            Modify_ApiCall(ref _callCompleteIPRotation);
            Modify_CompleteIPRotationApiCall(ref _callCompleteIPRotation);
            Modify_ApiCall(ref _callSetNodePoolSize);
            Modify_SetNodePoolSizeApiCall(ref _callSetNodePoolSize);
            Modify_ApiCall(ref _callSetNetworkPolicy);
            Modify_SetNetworkPolicyApiCall(ref _callSetNetworkPolicy);
            Modify_ApiCall(ref _callSetMaintenancePolicy);
            Modify_SetMaintenancePolicyApiCall(ref _callSetMaintenancePolicy);
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
        partial void Modify_ListClustersApiCall(ref ApiCall<ListClustersRequest, ListClustersResponse> call);
        partial void Modify_GetClusterApiCall(ref ApiCall<GetClusterRequest, Cluster> call);
        partial void Modify_CreateClusterApiCall(ref ApiCall<CreateClusterRequest, Operation> call);
        partial void Modify_UpdateClusterApiCall(ref ApiCall<UpdateClusterRequest, Operation> call);
        partial void Modify_UpdateNodePoolApiCall(ref ApiCall<UpdateNodePoolRequest, Operation> call);
        partial void Modify_SetNodePoolAutoscalingApiCall(ref ApiCall<SetNodePoolAutoscalingRequest, Operation> call);
        partial void Modify_SetLoggingServiceApiCall(ref ApiCall<SetLoggingServiceRequest, Operation> call);
        partial void Modify_SetMonitoringServiceApiCall(ref ApiCall<SetMonitoringServiceRequest, Operation> call);
        partial void Modify_SetAddonsConfigApiCall(ref ApiCall<SetAddonsConfigRequest, Operation> call);
        partial void Modify_SetLocationsApiCall(ref ApiCall<SetLocationsRequest, Operation> call);
        partial void Modify_UpdateMasterApiCall(ref ApiCall<UpdateMasterRequest, Operation> call);
        partial void Modify_SetMasterAuthApiCall(ref ApiCall<SetMasterAuthRequest, Operation> call);
        partial void Modify_DeleteClusterApiCall(ref ApiCall<DeleteClusterRequest, Operation> call);
        partial void Modify_ListOperationsApiCall(ref ApiCall<ListOperationsRequest, ListOperationsResponse> call);
        partial void Modify_GetOperationApiCall(ref ApiCall<GetOperationRequest, Operation> call);
        partial void Modify_CancelOperationApiCall(ref ApiCall<CancelOperationRequest, Empty> call);
        partial void Modify_GetServerConfigApiCall(ref ApiCall<GetServerConfigRequest, ServerConfig> call);
        partial void Modify_ListNodePoolsApiCall(ref ApiCall<ListNodePoolsRequest, ListNodePoolsResponse> call);
        partial void Modify_GetNodePoolApiCall(ref ApiCall<GetNodePoolRequest, NodePool> call);
        partial void Modify_CreateNodePoolApiCall(ref ApiCall<CreateNodePoolRequest, Operation> call);
        partial void Modify_DeleteNodePoolApiCall(ref ApiCall<DeleteNodePoolRequest, Operation> call);
        partial void Modify_RollbackNodePoolUpgradeApiCall(ref ApiCall<RollbackNodePoolUpgradeRequest, Operation> call);
        partial void Modify_SetNodePoolManagementApiCall(ref ApiCall<SetNodePoolManagementRequest, Operation> call);
        partial void Modify_SetLabelsApiCall(ref ApiCall<SetLabelsRequest, Operation> call);
        partial void Modify_SetLegacyAbacApiCall(ref ApiCall<SetLegacyAbacRequest, Operation> call);
        partial void Modify_StartIPRotationApiCall(ref ApiCall<StartIPRotationRequest, Operation> call);
        partial void Modify_CompleteIPRotationApiCall(ref ApiCall<CompleteIPRotationRequest, Operation> call);
        partial void Modify_SetNodePoolSizeApiCall(ref ApiCall<SetNodePoolSizeRequest, Operation> call);
        partial void Modify_SetNetworkPolicyApiCall(ref ApiCall<SetNetworkPolicyRequest, Operation> call);
        partial void Modify_SetMaintenancePolicyApiCall(ref ApiCall<SetMaintenancePolicyRequest, Operation> call);
        partial void OnConstruction(ClusterManager.ClusterManagerClient grpcClient, ClusterManagerSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ClusterManager client.
        /// </summary>
        public override ClusterManager.ClusterManagerClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref CallSettings settings);
        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref CallSettings settings);
        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref CallSettings settings);
        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref CallSettings settings);
        partial void Modify_UpdateNodePoolRequest(ref UpdateNodePoolRequest request, ref CallSettings settings);
        partial void Modify_SetNodePoolAutoscalingRequest(ref SetNodePoolAutoscalingRequest request, ref CallSettings settings);
        partial void Modify_SetLoggingServiceRequest(ref SetLoggingServiceRequest request, ref CallSettings settings);
        partial void Modify_SetMonitoringServiceRequest(ref SetMonitoringServiceRequest request, ref CallSettings settings);
        partial void Modify_SetAddonsConfigRequest(ref SetAddonsConfigRequest request, ref CallSettings settings);
        partial void Modify_SetLocationsRequest(ref SetLocationsRequest request, ref CallSettings settings);
        partial void Modify_UpdateMasterRequest(ref UpdateMasterRequest request, ref CallSettings settings);
        partial void Modify_SetMasterAuthRequest(ref SetMasterAuthRequest request, ref CallSettings settings);
        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref CallSettings settings);
        partial void Modify_ListOperationsRequest(ref ListOperationsRequest request, ref CallSettings settings);
        partial void Modify_GetOperationRequest(ref GetOperationRequest request, ref CallSettings settings);
        partial void Modify_CancelOperationRequest(ref CancelOperationRequest request, ref CallSettings settings);
        partial void Modify_GetServerConfigRequest(ref GetServerConfigRequest request, ref CallSettings settings);
        partial void Modify_ListNodePoolsRequest(ref ListNodePoolsRequest request, ref CallSettings settings);
        partial void Modify_GetNodePoolRequest(ref GetNodePoolRequest request, ref CallSettings settings);
        partial void Modify_CreateNodePoolRequest(ref CreateNodePoolRequest request, ref CallSettings settings);
        partial void Modify_DeleteNodePoolRequest(ref DeleteNodePoolRequest request, ref CallSettings settings);
        partial void Modify_RollbackNodePoolUpgradeRequest(ref RollbackNodePoolUpgradeRequest request, ref CallSettings settings);
        partial void Modify_SetNodePoolManagementRequest(ref SetNodePoolManagementRequest request, ref CallSettings settings);
        partial void Modify_SetLabelsRequest(ref SetLabelsRequest request, ref CallSettings settings);
        partial void Modify_SetLegacyAbacRequest(ref SetLegacyAbacRequest request, ref CallSettings settings);
        partial void Modify_StartIPRotationRequest(ref StartIPRotationRequest request, ref CallSettings settings);
        partial void Modify_CompleteIPRotationRequest(ref CompleteIPRotationRequest request, ref CallSettings settings);
        partial void Modify_SetNodePoolSizeRequest(ref SetNodePoolSizeRequest request, ref CallSettings settings);
        partial void Modify_SetNetworkPolicyRequest(ref SetNetworkPolicyRequest request, ref CallSettings settings);
        partial void Modify_SetMaintenancePolicyRequest(ref SetMaintenancePolicyRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
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
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
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
        /// Gets the details of a specific cluster.
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
        /// Gets the details of a specific cluster.
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
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
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
        public override Task<Operation> CreateClusterAsync(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return _callCreateCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        ///
        /// By default, the cluster is created in the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        ///
        /// One firewall is added for the cluster. After cluster creation,
        /// the cluster creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        ///
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range is being used by the cluster.
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
        public override Operation CreateCluster(
            CreateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return _callCreateCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
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
        public override Task<Operation> UpdateClusterAsync(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return _callUpdateCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
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
        public override Operation UpdateCluster(
            UpdateClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return _callUpdateCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the version and/or image type of a specific node pool.
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
        public override Task<Operation> UpdateNodePoolAsync(
            UpdateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateNodePoolRequest(ref request, ref callSettings);
            return _callUpdateNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the version and/or image type of a specific node pool.
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
        public override Operation UpdateNodePool(
            UpdateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateNodePoolRequest(ref request, ref callSettings);
            return _callUpdateNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the autoscaling settings of a specific node pool.
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
        public override Task<Operation> SetNodePoolAutoscalingAsync(
            SetNodePoolAutoscalingRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolAutoscalingRequest(ref request, ref callSettings);
            return _callSetNodePoolAutoscaling.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the autoscaling settings of a specific node pool.
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
        public override Operation SetNodePoolAutoscaling(
            SetNodePoolAutoscalingRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolAutoscalingRequest(ref request, ref callSettings);
            return _callSetNodePoolAutoscaling.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the logging service of a specific cluster.
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
        public override Task<Operation> SetLoggingServiceAsync(
            SetLoggingServiceRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLoggingServiceRequest(ref request, ref callSettings);
            return _callSetLoggingService.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the logging service of a specific cluster.
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
        public override Operation SetLoggingService(
            SetLoggingServiceRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLoggingServiceRequest(ref request, ref callSettings);
            return _callSetLoggingService.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
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
        public override Task<Operation> SetMonitoringServiceAsync(
            SetMonitoringServiceRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMonitoringServiceRequest(ref request, ref callSettings);
            return _callSetMonitoringService.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the monitoring service of a specific cluster.
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
        public override Operation SetMonitoringService(
            SetMonitoringServiceRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMonitoringServiceRequest(ref request, ref callSettings);
            return _callSetMonitoringService.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the addons of a specific cluster.
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
        public override Task<Operation> SetAddonsConfigAsync(
            SetAddonsConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetAddonsConfigRequest(ref request, ref callSettings);
            return _callSetAddonsConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the addons of a specific cluster.
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
        public override Operation SetAddonsConfig(
            SetAddonsConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetAddonsConfigRequest(ref request, ref callSettings);
            return _callSetAddonsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the locations of a specific cluster.
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
        public override Task<Operation> SetLocationsAsync(
            SetLocationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLocationsRequest(ref request, ref callSettings);
            return _callSetLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the locations of a specific cluster.
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
        public override Operation SetLocations(
            SetLocationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLocationsRequest(ref request, ref callSettings);
            return _callSetLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the master of a specific cluster.
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
        public override Task<Operation> UpdateMasterAsync(
            UpdateMasterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateMasterRequest(ref request, ref callSettings);
            return _callUpdateMaster.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the master of a specific cluster.
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
        public override Operation UpdateMaster(
            UpdateMasterRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateMasterRequest(ref request, ref callSettings);
            return _callUpdateMaster.Sync(request, callSettings);
        }

        /// <summary>
        /// Used to set master auth materials. Currently supports :-
        /// Changing the admin password of a specific cluster.
        /// This can be either via password generation or explicitly set the password.
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
        public override Task<Operation> SetMasterAuthAsync(
            SetMasterAuthRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMasterAuthRequest(ref request, ref callSettings);
            return _callSetMasterAuth.Async(request, callSettings);
        }

        /// <summary>
        /// Used to set master auth materials. Currently supports :-
        /// Changing the admin password of a specific cluster.
        /// This can be either via password generation or explicitly set the password.
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
        public override Operation SetMasterAuth(
            SetMasterAuthRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMasterAuthRequest(ref request, ref callSettings);
            return _callSetMasterAuth.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
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
        public override Task<Operation> DeleteClusterAsync(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        ///
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        ///
        /// Other Google Compute Engine resources that might be in use by the cluster
        /// (e.g. load balancer resources) will not be deleted if they weren't present
        /// at the initial create time.
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
        public override Operation DeleteCluster(
            DeleteClusterRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
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
        public override Task<ListOperationsResponse> ListOperationsAsync(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return _callListOperations.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
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
        public override ListOperationsResponse ListOperations(
            ListOperationsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return _callListOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified operation.
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
        public override Task<Operation> GetOperationAsync(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified operation.
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
        public override Operation GetOperation(
            GetOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels the specified operation.
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
        public override Task CancelOperationAsync(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            return _callCancelOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void CancelOperation(
            CancelOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            _callCancelOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns configuration info about the Container Engine service.
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
        public override Task<ServerConfig> GetServerConfigAsync(
            GetServerConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetServerConfigRequest(ref request, ref callSettings);
            return _callGetServerConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns configuration info about the Container Engine service.
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
        public override ServerConfig GetServerConfig(
            GetServerConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetServerConfigRequest(ref request, ref callSettings);
            return _callGetServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the node pools for a cluster.
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
        public override Task<ListNodePoolsResponse> ListNodePoolsAsync(
            ListNodePoolsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNodePoolsRequest(ref request, ref callSettings);
            return _callListNodePools.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the node pools for a cluster.
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
        public override ListNodePoolsResponse ListNodePools(
            ListNodePoolsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNodePoolsRequest(ref request, ref callSettings);
            return _callListNodePools.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the node pool requested.
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
        public override Task<NodePool> GetNodePoolAsync(
            GetNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNodePoolRequest(ref request, ref callSettings);
            return _callGetNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the node pool requested.
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
        public override NodePool GetNodePool(
            GetNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNodePoolRequest(ref request, ref callSettings);
            return _callGetNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a node pool for a cluster.
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
        public override Task<Operation> CreateNodePoolAsync(
            CreateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateNodePoolRequest(ref request, ref callSettings);
            return _callCreateNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a node pool for a cluster.
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
        public override Operation CreateNodePool(
            CreateNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateNodePoolRequest(ref request, ref callSettings);
            return _callCreateNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
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
        public override Task<Operation> DeleteNodePoolAsync(
            DeleteNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteNodePoolRequest(ref request, ref callSettings);
            return _callDeleteNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
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
        public override Operation DeleteNodePool(
            DeleteNodePoolRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteNodePoolRequest(ref request, ref callSettings);
            return _callDeleteNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
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
        public override Task<Operation> RollbackNodePoolUpgradeAsync(
            RollbackNodePoolUpgradeRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackNodePoolUpgradeRequest(ref request, ref callSettings);
            return _callRollbackNodePoolUpgrade.Async(request, callSettings);
        }

        /// <summary>
        /// Roll back the previously Aborted or Failed NodePool upgrade.
        /// This will be an no-op if the last upgrade successfully completed.
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
        public override Operation RollbackNodePoolUpgrade(
            RollbackNodePoolUpgradeRequest request,
            CallSettings callSettings = null)
        {
            Modify_RollbackNodePoolUpgradeRequest(ref request, ref callSettings);
            return _callRollbackNodePoolUpgrade.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
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
        public override Task<Operation> SetNodePoolManagementAsync(
            SetNodePoolManagementRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolManagementRequest(ref request, ref callSettings);
            return _callSetNodePoolManagement.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
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
        public override Operation SetNodePoolManagement(
            SetNodePoolManagementRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolManagementRequest(ref request, ref callSettings);
            return _callSetNodePoolManagement.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets labels on a cluster.
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
        public override Task<Operation> SetLabelsAsync(
            SetLabelsRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLabelsRequest(ref request, ref callSettings);
            return _callSetLabels.Async(request, callSettings);
        }

        /// <summary>
        /// Sets labels on a cluster.
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
        public override Operation SetLabels(
            SetLabelsRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLabelsRequest(ref request, ref callSettings);
            return _callSetLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
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
        public override Task<Operation> SetLegacyAbacAsync(
            SetLegacyAbacRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLegacyAbacRequest(ref request, ref callSettings);
            return _callSetLegacyAbac.Async(request, callSettings);
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
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
        public override Operation SetLegacyAbac(
            SetLegacyAbacRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetLegacyAbacRequest(ref request, ref callSettings);
            return _callSetLegacyAbac.Sync(request, callSettings);
        }

        /// <summary>
        /// Start master IP rotation.
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
        public override Task<Operation> StartIPRotationAsync(
            StartIPRotationRequest request,
            CallSettings callSettings = null)
        {
            Modify_StartIPRotationRequest(ref request, ref callSettings);
            return _callStartIPRotation.Async(request, callSettings);
        }

        /// <summary>
        /// Start master IP rotation.
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
        public override Operation StartIPRotation(
            StartIPRotationRequest request,
            CallSettings callSettings = null)
        {
            Modify_StartIPRotationRequest(ref request, ref callSettings);
            return _callStartIPRotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes master IP rotation.
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
        public override Task<Operation> CompleteIPRotationAsync(
            CompleteIPRotationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CompleteIPRotationRequest(ref request, ref callSettings);
            return _callCompleteIPRotation.Async(request, callSettings);
        }

        /// <summary>
        /// Completes master IP rotation.
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
        public override Operation CompleteIPRotation(
            CompleteIPRotationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CompleteIPRotationRequest(ref request, ref callSettings);
            return _callCompleteIPRotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the size of a specific node pool.
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
        public override Task<Operation> SetNodePoolSizeAsync(
            SetNodePoolSizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolSizeRequest(ref request, ref callSettings);
            return _callSetNodePoolSize.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the size of a specific node pool.
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
        public override Operation SetNodePoolSize(
            SetNodePoolSizeRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNodePoolSizeRequest(ref request, ref callSettings);
            return _callSetNodePoolSize.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
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
        public override Task<Operation> SetNetworkPolicyAsync(
            SetNetworkPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNetworkPolicyRequest(ref request, ref callSettings);
            return _callSetNetworkPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Enables/Disables Network Policy for a cluster.
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
        public override Operation SetNetworkPolicy(
            SetNetworkPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetNetworkPolicyRequest(ref request, ref callSettings);
            return _callSetNetworkPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
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
        public override Task<Operation> SetMaintenancePolicyAsync(
            SetMaintenancePolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMaintenancePolicyRequest(ref request, ref callSettings);
            return _callSetMaintenancePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
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
        public override Operation SetMaintenancePolicy(
            SetMaintenancePolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetMaintenancePolicyRequest(ref request, ref callSettings);
            return _callSetMaintenancePolicy.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
