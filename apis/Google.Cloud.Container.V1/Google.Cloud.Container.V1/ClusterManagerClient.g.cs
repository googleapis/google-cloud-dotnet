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

// Ignore obsolete members within this file.
// This is currently a hand-written addition to the generated file, until the
// generator includes it automatically.
#pragma warning disable CS0612 // Type or member is obsolete

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Container.V1
{
    /// <summary>Settings for <see cref="ClusterManagerClient"/> instances.</summary>
    public sealed partial class ClusterManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ClusterManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ClusterManagerSettings"/>.</returns>
        public static ClusterManagerSettings GetDefault() => new ClusterManagerSettings();

        /// <summary>Constructs a new <see cref="ClusterManagerSettings"/> object with default settings.</summary>
        public ClusterManagerSettings()
        {
        }

        private ClusterManagerSettings(ClusterManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
            ListUsableSubnetworksSettings = existing.ListUsableSubnetworksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ClusterManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListClusters</c> and <c>ClusterManagerClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetCluster</c> and <c>ClusterManagerClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CreateCluster</c> and <c>ClusterManagerClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateCluster</c> and <c>ClusterManagerClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateNodePool</c> and <c>ClusterManagerClient.UpdateNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolAutoscaling</c> and <c>ClusterManagerClient.SetNodePoolAutoscalingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNodePoolAutoscalingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLoggingService</c> and <c>ClusterManagerClient.SetLoggingServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLoggingServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMonitoringService</c> and <c>ClusterManagerClient.SetMonitoringServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMonitoringServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetAddonsConfig</c> and <c>ClusterManagerClient.SetAddonsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetAddonsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLocations</c> and <c>ClusterManagerClient.SetLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.UpdateMaster</c> and <c>ClusterManagerClient.UpdateMasterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMasterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMasterAuth</c> and <c>ClusterManagerClient.SetMasterAuthAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMasterAuthSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.DeleteCluster</c> and <c>ClusterManagerClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListOperations</c> and <c>ClusterManagerClient.ListOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOperationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetOperation</c> and <c>ClusterManagerClient.GetOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOperationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CancelOperation</c> and <c>ClusterManagerClient.CancelOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetServerConfig</c> and <c>ClusterManagerClient.GetServerConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServerConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListNodePools</c> and <c>ClusterManagerClient.ListNodePoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNodePoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.GetNodePool</c> and <c>ClusterManagerClient.GetNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNodePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CreateNodePool</c> and <c>ClusterManagerClient.CreateNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNodePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.DeleteNodePool</c> and <c>ClusterManagerClient.DeleteNodePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNodePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.RollbackNodePoolUpgrade</c> and <c>ClusterManagerClient.RollbackNodePoolUpgradeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackNodePoolUpgradeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolManagement</c> and <c>ClusterManagerClient.SetNodePoolManagementAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNodePoolManagementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLabels</c> and <c>ClusterManagerClient.SetLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetLegacyAbac</c> and <c>ClusterManagerClient.SetLegacyAbacAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetLegacyAbacSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.StartIPRotation</c> and <c>ClusterManagerClient.StartIPRotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartIPRotationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.CompleteIPRotation</c> and <c>ClusterManagerClient.CompleteIPRotationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CompleteIPRotationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNodePoolSize</c> and <c>ClusterManagerClient.SetNodePoolSizeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNodePoolSizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetNetworkPolicy</c> and <c>ClusterManagerClient.SetNetworkPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetNetworkPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.SetMaintenancePolicy</c> and <c>ClusterManagerClient.SetMaintenancePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMaintenancePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClusterManagerClient.ListUsableSubnetworks</c> and <c>ClusterManagerClient.ListUsableSubnetworksAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUsableSubnetworksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ClusterManagerSettings"/> object.</returns>
        public ClusterManagerSettings Clone() => new ClusterManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ClusterManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ClusterManagerClientBuilder : gaxgrpc::ClientBuilderBase<ClusterManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ClusterManagerSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ClusterManagerClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ClusterManagerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<ClusterManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ClusterManagerClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ClusterManagerClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ClusterManagerClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ClusterManagerClient.ChannelPool;
    }

    /// <summary>ClusterManager client wrapper, for convenient use.</summary>
    public abstract partial class ClusterManagerClient
    {
        /// <summary>
        /// The default endpoint for the ClusterManager service, which is a host of "container.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("container.googleapis.com", 443);

        /// <summary>The default ClusterManager scopes.</summary>
        /// <remarks>
        /// The default ClusterManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ClusterManagerClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ClusterManagerClient"/>.</returns>
        public static async stt::Task<ClusterManagerClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ClusterManagerSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ClusterManagerClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterManagerClient"/>.</returns>
        public static ClusterManagerClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ClusterManagerSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ClusterManagerClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterManagerClient"/>.</returns>
        public static ClusterManagerClient Create(grpccore::Channel channel, ClusterManagerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ClusterManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ClusterManagerSettings"/>.</param>
        /// <returns>The created <see cref="ClusterManagerClient"/>.</returns>
        public static ClusterManagerClient Create(grpccore::CallInvoker callInvoker, ClusterManagerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ClusterManager.ClusterManagerClient grpcClient = new ClusterManager.ClusterManagerClient(callInvoker);
            return new ClusterManagerClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,ClusterManagerSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,ClusterManagerSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,ClusterManagerSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,ClusterManagerSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ClusterManager client</summary>
        public virtual ClusterManager.ClusterManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, st::CancellationToken cancellationToken) =>
            ListClustersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListClustersResponse ListClusters(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            ListClusters(new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            ListClustersAsync(new ListClustersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides, or "-" for all zones.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListClustersResponse> ListClustersAsync(string projectId, string zone, st::CancellationToken cancellationToken) =>
            ListClustersAsync(projectId, zone, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to retrieve.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to retrieve.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to retrieve.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string projectId, string zone, string clusterId, st::CancellationToken cancellationToken) =>
            GetClusterAsync(projectId, zone, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cluster">
        /// Required. A [cluster
        /// resource](https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateCluster(string projectId, string zone, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cluster">
        /// Required. A [cluster
        /// resource](https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateClusterAsync(string projectId, string zone, Cluster cluster, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cluster">
        /// Required. A [cluster
        /// resource](https://cloud.google.com/container-engine/reference/rest/v1/projects.zones.clusters)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateClusterAsync(string projectId, string zone, Cluster cluster, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(projectId, zone, cluster, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="update">
        /// Required. A description of the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateCluster(string projectId, string zone, string clusterId, ClusterUpdate update, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Update = gax::GaxPreconditions.CheckNotNull(update, nameof(update)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="update">
        /// Required. A description of the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateClusterAsync(string projectId, string zone, string clusterId, ClusterUpdate update, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Update = gax::GaxPreconditions.CheckNotNull(update, nameof(update)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="update">
        /// Required. A description of the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateClusterAsync(string projectId, string zone, string clusterId, ClusterUpdate update, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(projectId, zone, clusterId, update, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the version and/or image type for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateNodePool(UpdateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the version and/or image type for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateNodePoolAsync(UpdateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the version and/or image type for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateNodePoolAsync(UpdateNodePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the autoscaling settings for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetNodePoolAutoscaling(SetNodePoolAutoscalingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the autoscaling settings for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the autoscaling settings for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest request, st::CancellationToken cancellationToken) =>
            SetNodePoolAutoscalingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLoggingService(SetLoggingServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLoggingServiceAsync(SetLoggingServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLoggingServiceAsync(SetLoggingServiceRequest request, st::CancellationToken cancellationToken) =>
            SetLoggingServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="loggingService">
        /// Required. The logging service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLoggingService(string projectId, string zone, string clusterId, string loggingService, gaxgrpc::CallSettings callSettings = null) =>
            SetLoggingService(new SetLoggingServiceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                LoggingService = gax::GaxPreconditions.CheckNotNullOrEmpty(loggingService, nameof(loggingService)),
            }, callSettings);

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="loggingService">
        /// Required. The logging service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLoggingServiceAsync(string projectId, string zone, string clusterId, string loggingService, gaxgrpc::CallSettings callSettings = null) =>
            SetLoggingServiceAsync(new SetLoggingServiceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                LoggingService = gax::GaxPreconditions.CheckNotNullOrEmpty(loggingService, nameof(loggingService)),
            }, callSettings);

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="loggingService">
        /// Required. The logging service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "logging.googleapis.com" - the Google Cloud Logging service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLoggingServiceAsync(string projectId, string zone, string clusterId, string loggingService, st::CancellationToken cancellationToken) =>
            SetLoggingServiceAsync(projectId, zone, clusterId, loggingService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMonitoringService(SetMonitoringServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMonitoringServiceAsync(SetMonitoringServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMonitoringServiceAsync(SetMonitoringServiceRequest request, st::CancellationToken cancellationToken) =>
            SetMonitoringServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="monitoringService">
        /// Required. The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "monitoring.googleapis.com/kubernetes" - the Google Cloud Monitoring
        /// service with Kubernetes-native resource model
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMonitoringService(string projectId, string zone, string clusterId, string monitoringService, gaxgrpc::CallSettings callSettings = null) =>
            SetMonitoringService(new SetMonitoringServiceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MonitoringService = gax::GaxPreconditions.CheckNotNullOrEmpty(monitoringService, nameof(monitoringService)),
            }, callSettings);

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="monitoringService">
        /// Required. The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "monitoring.googleapis.com/kubernetes" - the Google Cloud Monitoring
        /// service with Kubernetes-native resource model
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMonitoringServiceAsync(string projectId, string zone, string clusterId, string monitoringService, gaxgrpc::CallSettings callSettings = null) =>
            SetMonitoringServiceAsync(new SetMonitoringServiceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MonitoringService = gax::GaxPreconditions.CheckNotNullOrEmpty(monitoringService, nameof(monitoringService)),
            }, callSettings);

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="monitoringService">
        /// Required. The monitoring service the cluster should use to write metrics.
        /// Currently available options:
        /// 
        /// * "monitoring.googleapis.com/kubernetes" - the Google Cloud Monitoring
        /// service with Kubernetes-native resource model
        /// * "monitoring.googleapis.com" - the Google Cloud Monitoring service
        /// * "none" - no metrics will be exported from the cluster
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMonitoringServiceAsync(string projectId, string zone, string clusterId, string monitoringService, st::CancellationToken cancellationToken) =>
            SetMonitoringServiceAsync(projectId, zone, clusterId, monitoringService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetAddonsConfig(SetAddonsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetAddonsConfigAsync(SetAddonsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetAddonsConfigAsync(SetAddonsConfigRequest request, st::CancellationToken cancellationToken) =>
            SetAddonsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="addonsConfig">
        /// Required. The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetAddonsConfig(string projectId, string zone, string clusterId, AddonsConfig addonsConfig, gaxgrpc::CallSettings callSettings = null) =>
            SetAddonsConfig(new SetAddonsConfigRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                AddonsConfig = gax::GaxPreconditions.CheckNotNull(addonsConfig, nameof(addonsConfig)),
            }, callSettings);

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="addonsConfig">
        /// Required. The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetAddonsConfigAsync(string projectId, string zone, string clusterId, AddonsConfig addonsConfig, gaxgrpc::CallSettings callSettings = null) =>
            SetAddonsConfigAsync(new SetAddonsConfigRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                AddonsConfig = gax::GaxPreconditions.CheckNotNull(addonsConfig, nameof(addonsConfig)),
            }, callSettings);

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="addonsConfig">
        /// Required. The desired configurations for the various addons available to run in the
        /// cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetAddonsConfigAsync(string projectId, string zone, string clusterId, AddonsConfig addonsConfig, st::CancellationToken cancellationToken) =>
            SetAddonsConfigAsync(projectId, zone, clusterId, addonsConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLocations(SetLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLocationsAsync(SetLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLocationsAsync(SetLocationsRequest request, st::CancellationToken cancellationToken) =>
            SetLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="locations">
        /// Required. The desired list of Google Compute Engine
        /// [zones](https://cloud.google.com/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        /// 
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLocations(string projectId, string zone, string clusterId, scg::IEnumerable<string> locations, gaxgrpc::CallSettings callSettings = null) =>
            SetLocations(new SetLocationsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Locations =
                {
                    gax::GaxPreconditions.CheckNotNull(locations, nameof(locations)),
                },
            }, callSettings);

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="locations">
        /// Required. The desired list of Google Compute Engine
        /// [zones](https://cloud.google.com/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        /// 
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLocationsAsync(string projectId, string zone, string clusterId, scg::IEnumerable<string> locations, gaxgrpc::CallSettings callSettings = null) =>
            SetLocationsAsync(new SetLocationsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Locations =
                {
                    gax::GaxPreconditions.CheckNotNull(locations, nameof(locations)),
                },
            }, callSettings);

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="locations">
        /// Required. The desired list of Google Compute Engine
        /// [zones](https://cloud.google.com/compute/docs/zones#available) in which the cluster's nodes
        /// should be located. Changing the locations a cluster is in will result
        /// in nodes being either created or removed from the cluster, depending on
        /// whether locations are being added or removed.
        /// 
        /// This list must always include the cluster's primary zone.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLocationsAsync(string projectId, string zone, string clusterId, scg::IEnumerable<string> locations, st::CancellationToken cancellationToken) =>
            SetLocationsAsync(projectId, zone, clusterId, locations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateMaster(UpdateMasterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateMasterAsync(UpdateMasterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateMasterAsync(UpdateMasterRequest request, st::CancellationToken cancellationToken) =>
            UpdateMasterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="masterVersion">
        /// Required. The Kubernetes version to change the master to.
        /// 
        /// Users may specify either explicit versions offered by Kubernetes Engine or
        /// version aliases, which have the following behavior:
        /// 
        /// - "latest": picks the highest valid Kubernetes version
        /// - "1.X": picks the highest valid patch+gke.N patch in the 1.X version
        /// - "1.X.Y": picks the highest valid gke.N patch in the 1.X.Y version
        /// - "1.X.Y-gke.N": picks an explicit Kubernetes version
        /// - "-": picks the default Kubernetes version
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation UpdateMaster(string projectId, string zone, string clusterId, string masterVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMaster(new UpdateMasterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MasterVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(masterVersion, nameof(masterVersion)),
            }, callSettings);

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="masterVersion">
        /// Required. The Kubernetes version to change the master to.
        /// 
        /// Users may specify either explicit versions offered by Kubernetes Engine or
        /// version aliases, which have the following behavior:
        /// 
        /// - "latest": picks the highest valid Kubernetes version
        /// - "1.X": picks the highest valid patch+gke.N patch in the 1.X version
        /// - "1.X.Y": picks the highest valid gke.N patch in the 1.X.Y version
        /// - "1.X.Y-gke.N": picks an explicit Kubernetes version
        /// - "-": picks the default Kubernetes version
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateMasterAsync(string projectId, string zone, string clusterId, string masterVersion, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMasterAsync(new UpdateMasterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MasterVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(masterVersion, nameof(masterVersion)),
            }, callSettings);

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to upgrade.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="masterVersion">
        /// Required. The Kubernetes version to change the master to.
        /// 
        /// Users may specify either explicit versions offered by Kubernetes Engine or
        /// version aliases, which have the following behavior:
        /// 
        /// - "latest": picks the highest valid Kubernetes version
        /// - "1.X": picks the highest valid patch+gke.N patch in the 1.X version
        /// - "1.X.Y": picks the highest valid gke.N patch in the 1.X.Y version
        /// - "1.X.Y-gke.N": picks an explicit Kubernetes version
        /// - "-": picks the default Kubernetes version
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateMasterAsync(string projectId, string zone, string clusterId, string masterVersion, st::CancellationToken cancellationToken) =>
            UpdateMasterAsync(projectId, zone, clusterId, masterVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets master auth materials. Currently supports changing the admin password
        /// or a specific cluster, either via password generation or explicitly setting
        /// the password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMasterAuth(SetMasterAuthRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets master auth materials. Currently supports changing the admin password
        /// or a specific cluster, either via password generation or explicitly setting
        /// the password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMasterAuthAsync(SetMasterAuthRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets master auth materials. Currently supports changing the admin password
        /// or a specific cluster, either via password generation or explicitly setting
        /// the password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMasterAuthAsync(SetMasterAuthRequest request, st::CancellationToken cancellationToken) =>
            SetMasterAuthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteCluster(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteClusterAsync(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteClusterAsync(string projectId, string zone, string clusterId, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(projectId, zone, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListOperationsResponse ListOperations(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, st::CancellationToken cancellationToken) =>
            ListOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-` for
        /// all zones. This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListOperationsResponse ListOperations(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            ListOperations(new ListOperationsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-` for
        /// all zones. This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOperationsResponse> ListOperationsAsync(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            ListOperationsAsync(new ListOperationsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for, or `-` for
        /// all zones. This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListOperationsResponse> ListOperationsAsync(string projectId, string zone, st::CancellationToken cancellationToken) =>
            ListOperationsAsync(projectId, zone, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation GetOperation(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(GetOperationRequest request, st::CancellationToken cancellationToken) =>
            GetOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation GetOperation(string projectId, string zone, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            GetOperation(new GetOperationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(string projectId, string zone, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            GetOperationAsync(new GetOperationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> GetOperationAsync(string projectId, string zone, string operationId, st::CancellationToken cancellationToken) =>
            GetOperationAsync(projectId, zone, operationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelOperation(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(CancelOperationRequest request, st::CancellationToken cancellationToken) =>
            CancelOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelOperation(string projectId, string zone, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            CancelOperation(new CancelOperationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(string projectId, string zone, string operationId, gaxgrpc::CallSettings callSettings = null) =>
            CancelOperationAsync(new CancelOperationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                OperationId = gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)),
            }, callSettings);

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the operation resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="operationId">
        /// Required. Deprecated. The server-assigned `name` of the operation.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelOperationAsync(string projectId, string zone, string operationId, st::CancellationToken cancellationToken) =>
            CancelOperationAsync(projectId, zone, operationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServerConfig GetServerConfig(GetServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerConfig> GetServerConfigAsync(GetServerConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerConfig> GetServerConfigAsync(GetServerConfigRequest request, st::CancellationToken cancellationToken) =>
            GetServerConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServerConfig GetServerConfig(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            GetServerConfig(new GetServerConfigRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerConfig> GetServerConfigAsync(string projectId, string zone, gaxgrpc::CallSettings callSettings = null) =>
            GetServerConfigAsync(new GetServerConfigRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) to return operations for.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServerConfig> GetServerConfigAsync(string projectId, string zone, st::CancellationToken cancellationToken) =>
            GetServerConfigAsync(projectId, zone, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNodePoolsResponse ListNodePools(ListNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest request, st::CancellationToken cancellationToken) =>
            ListNodePoolsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNodePoolsResponse ListNodePools(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            ListNodePools(new ListNodePoolsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNodePoolsResponse> ListNodePoolsAsync(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            ListNodePoolsAsync(new ListNodePoolsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNodePoolsResponse> ListNodePoolsAsync(string projectId, string zone, string clusterId, st::CancellationToken cancellationToken) =>
            ListNodePoolsAsync(projectId, zone, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodePool GetNodePool(GetNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodePool> GetNodePoolAsync(GetNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodePool> GetNodePoolAsync(GetNodePoolRequest request, st::CancellationToken cancellationToken) =>
            GetNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NodePool GetNodePool(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            GetNodePool(new GetNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodePool> GetNodePoolAsync(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            GetNodePoolAsync(new GetNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NodePool> GetNodePoolAsync(string projectId, string zone, string clusterId, string nodePoolId, st::CancellationToken cancellationToken) =>
            GetNodePoolAsync(projectId, zone, clusterId, nodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateNodePool(CreateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateNodePoolAsync(CreateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateNodePoolAsync(CreateNodePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="nodePool">
        /// Required. The node pool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateNodePool(string projectId, string zone, string clusterId, NodePool nodePool, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodePool(new CreateNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePool = gax::GaxPreconditions.CheckNotNull(nodePool, nameof(nodePool)),
            }, callSettings);

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="nodePool">
        /// Required. The node pool to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateNodePoolAsync(string projectId, string zone, string clusterId, NodePool nodePool, gaxgrpc::CallSettings callSettings = null) =>
            CreateNodePoolAsync(new CreateNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePool = gax::GaxPreconditions.CheckNotNull(nodePool, nameof(nodePool)),
            }, callSettings);

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the parent field.
        /// </param>
        /// <param name="nodePool">
        /// Required. The node pool to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateNodePoolAsync(string projectId, string zone, string clusterId, NodePool nodePool, st::CancellationToken cancellationToken) =>
            CreateNodePoolAsync(projectId, zone, clusterId, nodePool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteNodePool(DeleteNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteNodePoolAsync(DeleteNodePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteNodePoolAsync(DeleteNodePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteNodePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteNodePool(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNodePool(new DeleteNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteNodePoolAsync(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNodePoolAsync(new DeleteNodePoolRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to delete.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteNodePoolAsync(string projectId, string zone, string clusterId, string nodePoolId, st::CancellationToken cancellationToken) =>
            DeleteNodePoolAsync(projectId, zone, clusterId, nodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RollbackNodePoolUpgrade(RollbackNodePoolUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest request, st::CancellationToken cancellationToken) =>
            RollbackNodePoolUpgradeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RollbackNodePoolUpgrade(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackNodePoolUpgrade(new RollbackNodePoolUpgradeRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RollbackNodePoolUpgradeAsync(string projectId, string zone, string clusterId, string nodePoolId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackNodePoolUpgradeAsync(new RollbackNodePoolUpgradeRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NodePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(nodePoolId, nameof(nodePoolId)),
            }, callSettings);

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="nodePoolId">
        /// Required. Deprecated. The name of the node pool to rollback.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RollbackNodePoolUpgradeAsync(string projectId, string zone, string clusterId, string nodePoolId, st::CancellationToken cancellationToken) =>
            RollbackNodePoolUpgradeAsync(projectId, zone, clusterId, nodePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetNodePoolManagement(SetNodePoolManagementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolManagementAsync(SetNodePoolManagementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolManagementAsync(SetNodePoolManagementRequest request, st::CancellationToken cancellationToken) =>
            SetNodePoolManagementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets labels on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLabels(SetLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLabelsAsync(SetLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets labels on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLabelsAsync(SetLabelsRequest request, st::CancellationToken cancellationToken) =>
            SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLegacyAbac(SetLegacyAbacRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLegacyAbacAsync(SetLegacyAbacRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLegacyAbacAsync(SetLegacyAbacRequest request, st::CancellationToken cancellationToken) =>
            SetLegacyAbacAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to update.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="enabled">
        /// Required. Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetLegacyAbac(string projectId, string zone, string clusterId, bool enabled, gaxgrpc::CallSettings callSettings = null) =>
            SetLegacyAbac(new SetLegacyAbacRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Enabled = enabled,
            }, callSettings);

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to update.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="enabled">
        /// Required. Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLegacyAbacAsync(string projectId, string zone, string clusterId, bool enabled, gaxgrpc::CallSettings callSettings = null) =>
            SetLegacyAbacAsync(new SetLegacyAbacRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Enabled = enabled,
            }, callSettings);

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster to update.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="enabled">
        /// Required. Whether ABAC authorization will be enabled in the cluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetLegacyAbacAsync(string projectId, string zone, string clusterId, bool enabled, st::CancellationToken cancellationToken) =>
            SetLegacyAbacAsync(projectId, zone, clusterId, enabled, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartIPRotation(StartIPRotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartIPRotationAsync(StartIPRotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartIPRotationAsync(StartIPRotationRequest request, st::CancellationToken cancellationToken) =>
            StartIPRotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartIPRotation(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            StartIPRotation(new StartIPRotationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartIPRotationAsync(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            StartIPRotationAsync(new StartIPRotationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartIPRotationAsync(string projectId, string zone, string clusterId, st::CancellationToken cancellationToken) =>
            StartIPRotationAsync(projectId, zone, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CompleteIPRotation(CompleteIPRotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CompleteIPRotationAsync(CompleteIPRotationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CompleteIPRotationAsync(CompleteIPRotationRequest request, st::CancellationToken cancellationToken) =>
            CompleteIPRotationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CompleteIPRotation(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CompleteIPRotation(new CompleteIPRotationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CompleteIPRotationAsync(string projectId, string zone, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CompleteIPRotationAsync(new CompleteIPRotationRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
            }, callSettings);

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CompleteIPRotationAsync(string projectId, string zone, string clusterId, st::CancellationToken cancellationToken) =>
            CompleteIPRotationAsync(projectId, zone, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the size for a specific node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetNodePoolSize(SetNodePoolSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the size for a specific node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolSizeAsync(SetNodePoolSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the size for a specific node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNodePoolSizeAsync(SetNodePoolSizeRequest request, st::CancellationToken cancellationToken) =>
            SetNodePoolSizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetNetworkPolicy(SetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNetworkPolicyAsync(SetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNetworkPolicyAsync(SetNetworkPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetNetworkPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="networkPolicy">
        /// Required. Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetNetworkPolicy(string projectId, string zone, string clusterId, NetworkPolicy networkPolicy, gaxgrpc::CallSettings callSettings = null) =>
            SetNetworkPolicy(new SetNetworkPolicyRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="networkPolicy">
        /// Required. Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNetworkPolicyAsync(string projectId, string zone, string clusterId, NetworkPolicy networkPolicy, gaxgrpc::CallSettings callSettings = null) =>
            SetNetworkPolicyAsync(new SetNetworkPolicyRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                NetworkPolicy = gax::GaxPreconditions.CheckNotNull(networkPolicy, nameof(networkPolicy)),
            }, callSettings);

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. Deprecated. The Google Developers Console [project ID or project
        /// number](https://developers.google.com/console/help/new/#projectnumber).
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="zone">
        /// Required. Deprecated. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="clusterId">
        /// Required. Deprecated. The name of the cluster.
        /// This field has been deprecated and replaced by the name field.
        /// </param>
        /// <param name="networkPolicy">
        /// Required. Configuration options for the NetworkPolicy feature.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetNetworkPolicyAsync(string projectId, string zone, string clusterId, NetworkPolicy networkPolicy, st::CancellationToken cancellationToken) =>
            SetNetworkPolicyAsync(projectId, zone, clusterId, networkPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMaintenancePolicy(SetMaintenancePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMaintenancePolicyAsync(SetMaintenancePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMaintenancePolicyAsync(SetMaintenancePolicyRequest request, st::CancellationToken cancellationToken) =>
            SetMaintenancePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// Required. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// Required. The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// Required. The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetMaintenancePolicy(string projectId, string zone, string clusterId, MaintenancePolicy maintenancePolicy, gaxgrpc::CallSettings callSettings = null) =>
            SetMaintenancePolicy(new SetMaintenancePolicyRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MaintenancePolicy = gax::GaxPreconditions.CheckNotNull(maintenancePolicy, nameof(maintenancePolicy)),
            }, callSettings);

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// Required. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// Required. The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// Required. The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMaintenancePolicyAsync(string projectId, string zone, string clusterId, MaintenancePolicy maintenancePolicy, gaxgrpc::CallSettings callSettings = null) =>
            SetMaintenancePolicyAsync(new SetMaintenancePolicyRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                MaintenancePolicy = gax::GaxPreconditions.CheckNotNull(maintenancePolicy, nameof(maintenancePolicy)),
            }, callSettings);

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="projectId">
        /// Required. The Google Developers Console [project ID or project
        /// number](https://support.google.com/cloud/answer/6158840).
        /// </param>
        /// <param name="zone">
        /// Required. The name of the Google Compute Engine
        /// [zone](https://cloud.google.com/compute/docs/zones#available) in which the cluster
        /// resides.
        /// </param>
        /// <param name="clusterId">
        /// Required. The name of the cluster to update.
        /// </param>
        /// <param name="maintenancePolicy">
        /// Required. The maintenance policy to be set for the cluster. An empty field
        /// clears the existing maintenance policy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetMaintenancePolicyAsync(string projectId, string zone, string clusterId, MaintenancePolicy maintenancePolicy, st::CancellationToken cancellationToken) =>
            SetMaintenancePolicyAsync(projectId, zone, clusterId, maintenancePolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists subnetworks that are usable for creating clusters in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UsableSubnetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> ListUsableSubnetworks(ListUsableSubnetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists subnetworks that are usable for creating clusters in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UsableSubnetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> ListUsableSubnetworksAsync(ListUsableSubnetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>ClusterManager client wrapper implementation, for convenient use.</summary>
    public sealed partial class ClusterManagerClientImpl : ClusterManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<UpdateNodePoolRequest, Operation> _callUpdateNodePool;

        private readonly gaxgrpc::ApiCall<SetNodePoolAutoscalingRequest, Operation> _callSetNodePoolAutoscaling;

        private readonly gaxgrpc::ApiCall<SetLoggingServiceRequest, Operation> _callSetLoggingService;

        private readonly gaxgrpc::ApiCall<SetMonitoringServiceRequest, Operation> _callSetMonitoringService;

        private readonly gaxgrpc::ApiCall<SetAddonsConfigRequest, Operation> _callSetAddonsConfig;

        private readonly gaxgrpc::ApiCall<SetLocationsRequest, Operation> _callSetLocations;

        private readonly gaxgrpc::ApiCall<UpdateMasterRequest, Operation> _callUpdateMaster;

        private readonly gaxgrpc::ApiCall<SetMasterAuthRequest, Operation> _callSetMasterAuth;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> _callListOperations;

        private readonly gaxgrpc::ApiCall<GetOperationRequest, Operation> _callGetOperation;

        private readonly gaxgrpc::ApiCall<CancelOperationRequest, wkt::Empty> _callCancelOperation;

        private readonly gaxgrpc::ApiCall<GetServerConfigRequest, ServerConfig> _callGetServerConfig;

        private readonly gaxgrpc::ApiCall<ListNodePoolsRequest, ListNodePoolsResponse> _callListNodePools;

        private readonly gaxgrpc::ApiCall<GetNodePoolRequest, NodePool> _callGetNodePool;

        private readonly gaxgrpc::ApiCall<CreateNodePoolRequest, Operation> _callCreateNodePool;

        private readonly gaxgrpc::ApiCall<DeleteNodePoolRequest, Operation> _callDeleteNodePool;

        private readonly gaxgrpc::ApiCall<RollbackNodePoolUpgradeRequest, Operation> _callRollbackNodePoolUpgrade;

        private readonly gaxgrpc::ApiCall<SetNodePoolManagementRequest, Operation> _callSetNodePoolManagement;

        private readonly gaxgrpc::ApiCall<SetLabelsRequest, Operation> _callSetLabels;

        private readonly gaxgrpc::ApiCall<SetLegacyAbacRequest, Operation> _callSetLegacyAbac;

        private readonly gaxgrpc::ApiCall<StartIPRotationRequest, Operation> _callStartIPRotation;

        private readonly gaxgrpc::ApiCall<CompleteIPRotationRequest, Operation> _callCompleteIPRotation;

        private readonly gaxgrpc::ApiCall<SetNodePoolSizeRequest, Operation> _callSetNodePoolSize;

        private readonly gaxgrpc::ApiCall<SetNetworkPolicyRequest, Operation> _callSetNetworkPolicy;

        private readonly gaxgrpc::ApiCall<SetMaintenancePolicyRequest, Operation> _callSetMaintenancePolicy;

        private readonly gaxgrpc::ApiCall<ListUsableSubnetworksRequest, ListUsableSubnetworksResponse> _callListUsableSubnetworks;

        /// <summary>
        /// Constructs a client wrapper for the ClusterManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ClusterManagerSettings"/> used within this client.</param>
        public ClusterManagerClientImpl(ClusterManager.ClusterManagerClient grpcClient, ClusterManagerSettings settings)
        {
            GrpcClient = grpcClient;
            ClusterManagerSettings effectiveSettings = settings ?? ClusterManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>(grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>(grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, Operation>(grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, Operation>(grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callUpdateNodePool = clientHelper.BuildApiCall<UpdateNodePoolRequest, Operation>(grpcClient.UpdateNodePoolAsync, grpcClient.UpdateNodePool, effectiveSettings.UpdateNodePoolSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callUpdateNodePool);
            Modify_UpdateNodePoolApiCall(ref _callUpdateNodePool);
            _callSetNodePoolAutoscaling = clientHelper.BuildApiCall<SetNodePoolAutoscalingRequest, Operation>(grpcClient.SetNodePoolAutoscalingAsync, grpcClient.SetNodePoolAutoscaling, effectiveSettings.SetNodePoolAutoscalingSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetNodePoolAutoscaling);
            Modify_SetNodePoolAutoscalingApiCall(ref _callSetNodePoolAutoscaling);
            _callSetLoggingService = clientHelper.BuildApiCall<SetLoggingServiceRequest, Operation>(grpcClient.SetLoggingServiceAsync, grpcClient.SetLoggingService, effectiveSettings.SetLoggingServiceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetLoggingService);
            Modify_SetLoggingServiceApiCall(ref _callSetLoggingService);
            _callSetMonitoringService = clientHelper.BuildApiCall<SetMonitoringServiceRequest, Operation>(grpcClient.SetMonitoringServiceAsync, grpcClient.SetMonitoringService, effectiveSettings.SetMonitoringServiceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetMonitoringService);
            Modify_SetMonitoringServiceApiCall(ref _callSetMonitoringService);
            _callSetAddonsConfig = clientHelper.BuildApiCall<SetAddonsConfigRequest, Operation>(grpcClient.SetAddonsConfigAsync, grpcClient.SetAddonsConfig, effectiveSettings.SetAddonsConfigSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetAddonsConfig);
            Modify_SetAddonsConfigApiCall(ref _callSetAddonsConfig);
            _callSetLocations = clientHelper.BuildApiCall<SetLocationsRequest, Operation>(grpcClient.SetLocationsAsync, grpcClient.SetLocations, effectiveSettings.SetLocationsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetLocations);
            Modify_SetLocationsApiCall(ref _callSetLocations);
            _callUpdateMaster = clientHelper.BuildApiCall<UpdateMasterRequest, Operation>(grpcClient.UpdateMasterAsync, grpcClient.UpdateMaster, effectiveSettings.UpdateMasterSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callUpdateMaster);
            Modify_UpdateMasterApiCall(ref _callUpdateMaster);
            _callSetMasterAuth = clientHelper.BuildApiCall<SetMasterAuthRequest, Operation>(grpcClient.SetMasterAuthAsync, grpcClient.SetMasterAuth, effectiveSettings.SetMasterAuthSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetMasterAuth);
            Modify_SetMasterAuthApiCall(ref _callSetMasterAuth);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, Operation>(grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callListOperations = clientHelper.BuildApiCall<ListOperationsRequest, ListOperationsResponse>(grpcClient.ListOperationsAsync, grpcClient.ListOperations, effectiveSettings.ListOperationsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListOperations);
            Modify_ListOperationsApiCall(ref _callListOperations);
            _callGetOperation = clientHelper.BuildApiCall<GetOperationRequest, Operation>(grpcClient.GetOperationAsync, grpcClient.GetOperation, effectiveSettings.GetOperationSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetOperation);
            Modify_GetOperationApiCall(ref _callGetOperation);
            _callCancelOperation = clientHelper.BuildApiCall<CancelOperationRequest, wkt::Empty>(grpcClient.CancelOperationAsync, grpcClient.CancelOperation, effectiveSettings.CancelOperationSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callCancelOperation);
            Modify_CancelOperationApiCall(ref _callCancelOperation);
            _callGetServerConfig = clientHelper.BuildApiCall<GetServerConfigRequest, ServerConfig>(grpcClient.GetServerConfigAsync, grpcClient.GetServerConfig, effectiveSettings.GetServerConfigSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetServerConfig);
            Modify_GetServerConfigApiCall(ref _callGetServerConfig);
            _callListNodePools = clientHelper.BuildApiCall<ListNodePoolsRequest, ListNodePoolsResponse>(grpcClient.ListNodePoolsAsync, grpcClient.ListNodePools, effectiveSettings.ListNodePoolsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListNodePools);
            Modify_ListNodePoolsApiCall(ref _callListNodePools);
            _callGetNodePool = clientHelper.BuildApiCall<GetNodePoolRequest, NodePool>(grpcClient.GetNodePoolAsync, grpcClient.GetNodePool, effectiveSettings.GetNodePoolSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetNodePool);
            Modify_GetNodePoolApiCall(ref _callGetNodePool);
            _callCreateNodePool = clientHelper.BuildApiCall<CreateNodePoolRequest, Operation>(grpcClient.CreateNodePoolAsync, grpcClient.CreateNodePool, effectiveSettings.CreateNodePoolSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callCreateNodePool);
            Modify_CreateNodePoolApiCall(ref _callCreateNodePool);
            _callDeleteNodePool = clientHelper.BuildApiCall<DeleteNodePoolRequest, Operation>(grpcClient.DeleteNodePoolAsync, grpcClient.DeleteNodePool, effectiveSettings.DeleteNodePoolSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callDeleteNodePool);
            Modify_DeleteNodePoolApiCall(ref _callDeleteNodePool);
            _callRollbackNodePoolUpgrade = clientHelper.BuildApiCall<RollbackNodePoolUpgradeRequest, Operation>(grpcClient.RollbackNodePoolUpgradeAsync, grpcClient.RollbackNodePoolUpgrade, effectiveSettings.RollbackNodePoolUpgradeSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callRollbackNodePoolUpgrade);
            Modify_RollbackNodePoolUpgradeApiCall(ref _callRollbackNodePoolUpgrade);
            _callSetNodePoolManagement = clientHelper.BuildApiCall<SetNodePoolManagementRequest, Operation>(grpcClient.SetNodePoolManagementAsync, grpcClient.SetNodePoolManagement, effectiveSettings.SetNodePoolManagementSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetNodePoolManagement);
            Modify_SetNodePoolManagementApiCall(ref _callSetNodePoolManagement);
            _callSetLabels = clientHelper.BuildApiCall<SetLabelsRequest, Operation>(grpcClient.SetLabelsAsync, grpcClient.SetLabels, effectiveSettings.SetLabelsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetLabels);
            Modify_SetLabelsApiCall(ref _callSetLabels);
            _callSetLegacyAbac = clientHelper.BuildApiCall<SetLegacyAbacRequest, Operation>(grpcClient.SetLegacyAbacAsync, grpcClient.SetLegacyAbac, effectiveSettings.SetLegacyAbacSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetLegacyAbac);
            Modify_SetLegacyAbacApiCall(ref _callSetLegacyAbac);
            _callStartIPRotation = clientHelper.BuildApiCall<StartIPRotationRequest, Operation>(grpcClient.StartIPRotationAsync, grpcClient.StartIPRotation, effectiveSettings.StartIPRotationSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callStartIPRotation);
            Modify_StartIPRotationApiCall(ref _callStartIPRotation);
            _callCompleteIPRotation = clientHelper.BuildApiCall<CompleteIPRotationRequest, Operation>(grpcClient.CompleteIPRotationAsync, grpcClient.CompleteIPRotation, effectiveSettings.CompleteIPRotationSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callCompleteIPRotation);
            Modify_CompleteIPRotationApiCall(ref _callCompleteIPRotation);
            _callSetNodePoolSize = clientHelper.BuildApiCall<SetNodePoolSizeRequest, Operation>(grpcClient.SetNodePoolSizeAsync, grpcClient.SetNodePoolSize, effectiveSettings.SetNodePoolSizeSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetNodePoolSize);
            Modify_SetNodePoolSizeApiCall(ref _callSetNodePoolSize);
            _callSetNetworkPolicy = clientHelper.BuildApiCall<SetNetworkPolicyRequest, Operation>(grpcClient.SetNetworkPolicyAsync, grpcClient.SetNetworkPolicy, effectiveSettings.SetNetworkPolicySettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetNetworkPolicy);
            Modify_SetNetworkPolicyApiCall(ref _callSetNetworkPolicy);
            _callSetMaintenancePolicy = clientHelper.BuildApiCall<SetMaintenancePolicyRequest, Operation>(grpcClient.SetMaintenancePolicyAsync, grpcClient.SetMaintenancePolicy, effectiveSettings.SetMaintenancePolicySettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callSetMaintenancePolicy);
            Modify_SetMaintenancePolicyApiCall(ref _callSetMaintenancePolicy);
            _callListUsableSubnetworks = clientHelper.BuildApiCall<ListUsableSubnetworksRequest, ListUsableSubnetworksResponse>(grpcClient.ListUsableSubnetworksAsync, grpcClient.ListUsableSubnetworks, effectiveSettings.ListUsableSubnetworksSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListUsableSubnetworks);
            Modify_ListUsableSubnetworksApiCall(ref _callListUsableSubnetworks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, Operation> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, Operation> call);

        partial void Modify_UpdateNodePoolApiCall(ref gaxgrpc::ApiCall<UpdateNodePoolRequest, Operation> call);

        partial void Modify_SetNodePoolAutoscalingApiCall(ref gaxgrpc::ApiCall<SetNodePoolAutoscalingRequest, Operation> call);

        partial void Modify_SetLoggingServiceApiCall(ref gaxgrpc::ApiCall<SetLoggingServiceRequest, Operation> call);

        partial void Modify_SetMonitoringServiceApiCall(ref gaxgrpc::ApiCall<SetMonitoringServiceRequest, Operation> call);

        partial void Modify_SetAddonsConfigApiCall(ref gaxgrpc::ApiCall<SetAddonsConfigRequest, Operation> call);

        partial void Modify_SetLocationsApiCall(ref gaxgrpc::ApiCall<SetLocationsRequest, Operation> call);

        partial void Modify_UpdateMasterApiCall(ref gaxgrpc::ApiCall<UpdateMasterRequest, Operation> call);

        partial void Modify_SetMasterAuthApiCall(ref gaxgrpc::ApiCall<SetMasterAuthRequest, Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, Operation> call);

        partial void Modify_ListOperationsApiCall(ref gaxgrpc::ApiCall<ListOperationsRequest, ListOperationsResponse> call);

        partial void Modify_GetOperationApiCall(ref gaxgrpc::ApiCall<GetOperationRequest, Operation> call);

        partial void Modify_CancelOperationApiCall(ref gaxgrpc::ApiCall<CancelOperationRequest, wkt::Empty> call);

        partial void Modify_GetServerConfigApiCall(ref gaxgrpc::ApiCall<GetServerConfigRequest, ServerConfig> call);

        partial void Modify_ListNodePoolsApiCall(ref gaxgrpc::ApiCall<ListNodePoolsRequest, ListNodePoolsResponse> call);

        partial void Modify_GetNodePoolApiCall(ref gaxgrpc::ApiCall<GetNodePoolRequest, NodePool> call);

        partial void Modify_CreateNodePoolApiCall(ref gaxgrpc::ApiCall<CreateNodePoolRequest, Operation> call);

        partial void Modify_DeleteNodePoolApiCall(ref gaxgrpc::ApiCall<DeleteNodePoolRequest, Operation> call);

        partial void Modify_RollbackNodePoolUpgradeApiCall(ref gaxgrpc::ApiCall<RollbackNodePoolUpgradeRequest, Operation> call);

        partial void Modify_SetNodePoolManagementApiCall(ref gaxgrpc::ApiCall<SetNodePoolManagementRequest, Operation> call);

        partial void Modify_SetLabelsApiCall(ref gaxgrpc::ApiCall<SetLabelsRequest, Operation> call);

        partial void Modify_SetLegacyAbacApiCall(ref gaxgrpc::ApiCall<SetLegacyAbacRequest, Operation> call);

        partial void Modify_StartIPRotationApiCall(ref gaxgrpc::ApiCall<StartIPRotationRequest, Operation> call);

        partial void Modify_CompleteIPRotationApiCall(ref gaxgrpc::ApiCall<CompleteIPRotationRequest, Operation> call);

        partial void Modify_SetNodePoolSizeApiCall(ref gaxgrpc::ApiCall<SetNodePoolSizeRequest, Operation> call);

        partial void Modify_SetNetworkPolicyApiCall(ref gaxgrpc::ApiCall<SetNetworkPolicyRequest, Operation> call);

        partial void Modify_SetMaintenancePolicyApiCall(ref gaxgrpc::ApiCall<SetMaintenancePolicyRequest, Operation> call);

        partial void Modify_ListUsableSubnetworksApiCall(ref gaxgrpc::ApiCall<ListUsableSubnetworksRequest, ListUsableSubnetworksResponse> call);

        partial void OnConstruction(ClusterManager.ClusterManagerClient grpcClient, ClusterManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ClusterManager client</summary>
        public override ClusterManager.ClusterManagerClient GrpcClient { get; }

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNodePoolRequest(ref UpdateNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNodePoolAutoscalingRequest(ref SetNodePoolAutoscalingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLoggingServiceRequest(ref SetLoggingServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMonitoringServiceRequest(ref SetMonitoringServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetAddonsConfigRequest(ref SetAddonsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLocationsRequest(ref SetLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMasterRequest(ref UpdateMasterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMasterAuthRequest(ref SetMasterAuthRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOperationsRequest(ref ListOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOperationRequest(ref GetOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelOperationRequest(ref CancelOperationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServerConfigRequest(ref GetServerConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNodePoolsRequest(ref ListNodePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNodePoolRequest(ref GetNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNodePoolRequest(ref CreateNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNodePoolRequest(ref DeleteNodePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackNodePoolUpgradeRequest(ref RollbackNodePoolUpgradeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNodePoolManagementRequest(ref SetNodePoolManagementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLabelsRequest(ref SetLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetLegacyAbacRequest(ref SetLegacyAbacRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartIPRotationRequest(ref StartIPRotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CompleteIPRotationRequest(ref CompleteIPRotationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNodePoolSizeRequest(ref SetNodePoolSizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetNetworkPolicyRequest(ref SetNetworkPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMaintenancePolicyRequest(ref SetMaintenancePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsableSubnetworksRequest(ref ListUsableSubnetworksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListClustersResponse ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all clusters owned by a project in either the specified zone or all
        /// zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return _callListClusters.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return _callCreateCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a cluster, consisting of the specified number and type of Google
        /// Compute Engine instances.
        /// 
        /// By default, the cluster is created in the project's
        /// [default network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks).
        /// 
        /// One firewall is added for the cluster. After cluster creation,
        /// the Kubelet creates routes for each node to allow the containers
        /// on that node to communicate with all other instances in the
        /// cluster.
        /// 
        /// Finally, an entry is added to the project's global metadata indicating
        /// which CIDR range the cluster is using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return _callCreateCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return _callUpdateCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the settings of a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return _callUpdateCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the version and/or image type for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateNodePool(UpdateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNodePoolRequest(ref request, ref callSettings);
            return _callUpdateNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the version and/or image type for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateNodePoolAsync(UpdateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNodePoolRequest(ref request, ref callSettings);
            return _callUpdateNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the autoscaling settings for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetNodePoolAutoscaling(SetNodePoolAutoscalingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolAutoscalingRequest(ref request, ref callSettings);
            return _callSetNodePoolAutoscaling.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the autoscaling settings for the specified node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetNodePoolAutoscalingAsync(SetNodePoolAutoscalingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolAutoscalingRequest(ref request, ref callSettings);
            return _callSetNodePoolAutoscaling.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetLoggingService(SetLoggingServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLoggingServiceRequest(ref request, ref callSettings);
            return _callSetLoggingService.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the logging service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetLoggingServiceAsync(SetLoggingServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLoggingServiceRequest(ref request, ref callSettings);
            return _callSetLoggingService.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMonitoringService(SetMonitoringServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMonitoringServiceRequest(ref request, ref callSettings);
            return _callSetMonitoringService.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the monitoring service for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMonitoringServiceAsync(SetMonitoringServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMonitoringServiceRequest(ref request, ref callSettings);
            return _callSetMonitoringService.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetAddonsConfig(SetAddonsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAddonsConfigRequest(ref request, ref callSettings);
            return _callSetAddonsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the addons for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetAddonsConfigAsync(SetAddonsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAddonsConfigRequest(ref request, ref callSettings);
            return _callSetAddonsConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetLocations(SetLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLocationsRequest(ref request, ref callSettings);
            return _callSetLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the locations for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetLocationsAsync(SetLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLocationsRequest(ref request, ref callSettings);
            return _callSetLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation UpdateMaster(UpdateMasterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMasterRequest(ref request, ref callSettings);
            return _callUpdateMaster.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the master for a specific cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateMasterAsync(UpdateMasterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMasterRequest(ref request, ref callSettings);
            return _callUpdateMaster.Async(request, callSettings);
        }

        /// <summary>
        /// Sets master auth materials. Currently supports changing the admin password
        /// or a specific cluster, either via password generation or explicitly setting
        /// the password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMasterAuth(SetMasterAuthRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMasterAuthRequest(ref request, ref callSettings);
            return _callSetMasterAuth.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets master auth materials. Currently supports changing the admin password
        /// or a specific cluster, either via password generation or explicitly setting
        /// the password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMasterAuthAsync(SetMasterAuthRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMasterAuthRequest(ref request, ref callSettings);
            return _callSetMasterAuth.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the cluster, including the Kubernetes endpoint and all worker
        /// nodes.
        /// 
        /// Firewalls and routes that were configured during cluster creation
        /// are also deleted.
        /// 
        /// Other Google Compute Engine resources that might be in use by the cluster,
        /// such as load balancer resources, are not deleted if they weren't present
        /// when the cluster was initially created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return _callDeleteCluster.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListOperationsResponse ListOperations(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return _callListOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all operations in a project in a specific zone or all zones.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListOperationsResponse> ListOperationsAsync(ListOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperationsRequest(ref request, ref callSettings);
            return _callListOperations.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation GetOperation(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> GetOperationAsync(GetOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperationRequest(ref request, ref callSettings);
            return _callGetOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelOperation(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            _callCancelOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels the specified operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelOperationAsync(CancelOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelOperationRequest(ref request, ref callSettings);
            return _callCancelOperation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServerConfig GetServerConfig(GetServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerConfigRequest(ref request, ref callSettings);
            return _callGetServerConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns configuration info about the Google Kubernetes Engine service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServerConfig> GetServerConfigAsync(GetServerConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServerConfigRequest(ref request, ref callSettings);
            return _callGetServerConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListNodePoolsResponse ListNodePools(ListNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodePoolsRequest(ref request, ref callSettings);
            return _callListNodePools.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the node pools for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNodePoolsRequest(ref request, ref callSettings);
            return _callListNodePools.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NodePool GetNodePool(GetNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodePoolRequest(ref request, ref callSettings);
            return _callGetNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the requested node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NodePool> GetNodePoolAsync(GetNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNodePoolRequest(ref request, ref callSettings);
            return _callGetNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CreateNodePool(CreateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodePoolRequest(ref request, ref callSettings);
            return _callCreateNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a node pool for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CreateNodePoolAsync(CreateNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNodePoolRequest(ref request, ref callSettings);
            return _callCreateNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteNodePool(DeleteNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNodePoolRequest(ref request, ref callSettings);
            return _callDeleteNodePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a node pool from a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteNodePoolAsync(DeleteNodePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNodePoolRequest(ref request, ref callSettings);
            return _callDeleteNodePool.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RollbackNodePoolUpgrade(RollbackNodePoolUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackNodePoolUpgradeRequest(ref request, ref callSettings);
            return _callRollbackNodePoolUpgrade.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a previously Aborted or Failed NodePool upgrade.
        /// This makes no changes if the last upgrade successfully completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RollbackNodePoolUpgradeAsync(RollbackNodePoolUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackNodePoolUpgradeRequest(ref request, ref callSettings);
            return _callRollbackNodePoolUpgrade.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetNodePoolManagement(SetNodePoolManagementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolManagementRequest(ref request, ref callSettings);
            return _callSetNodePoolManagement.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the NodeManagement options for a node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetNodePoolManagementAsync(SetNodePoolManagementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolManagementRequest(ref request, ref callSettings);
            return _callSetNodePoolManagement.Async(request, callSettings);
        }

        /// <summary>
        /// Sets labels on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetLabels(SetLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRequest(ref request, ref callSettings);
            return _callSetLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets labels on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetLabelsAsync(SetLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLabelsRequest(ref request, ref callSettings);
            return _callSetLabels.Async(request, callSettings);
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetLegacyAbac(SetLegacyAbacRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLegacyAbacRequest(ref request, ref callSettings);
            return _callSetLegacyAbac.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables or disables the ABAC authorization mechanism on a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetLegacyAbacAsync(SetLegacyAbacRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetLegacyAbacRequest(ref request, ref callSettings);
            return _callSetLegacyAbac.Async(request, callSettings);
        }

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StartIPRotation(StartIPRotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartIPRotationRequest(ref request, ref callSettings);
            return _callStartIPRotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartIPRotationAsync(StartIPRotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartIPRotationRequest(ref request, ref callSettings);
            return _callStartIPRotation.Async(request, callSettings);
        }

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CompleteIPRotation(CompleteIPRotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteIPRotationRequest(ref request, ref callSettings);
            return _callCompleteIPRotation.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes master IP rotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CompleteIPRotationAsync(CompleteIPRotationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteIPRotationRequest(ref request, ref callSettings);
            return _callCompleteIPRotation.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the size for a specific node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetNodePoolSize(SetNodePoolSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolSizeRequest(ref request, ref callSettings);
            return _callSetNodePoolSize.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the size for a specific node pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetNodePoolSizeAsync(SetNodePoolSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNodePoolSizeRequest(ref request, ref callSettings);
            return _callSetNodePoolSize.Async(request, callSettings);
        }

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetNetworkPolicy(SetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNetworkPolicyRequest(ref request, ref callSettings);
            return _callSetNetworkPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables or disables Network Policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetNetworkPolicyAsync(SetNetworkPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetNetworkPolicyRequest(ref request, ref callSettings);
            return _callSetNetworkPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetMaintenancePolicy(SetMaintenancePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMaintenancePolicyRequest(ref request, ref callSettings);
            return _callSetMaintenancePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the maintenance policy for a cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetMaintenancePolicyAsync(SetMaintenancePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMaintenancePolicyRequest(ref request, ref callSettings);
            return _callSetMaintenancePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists subnetworks that are usable for creating clusters in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UsableSubnetwork"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> ListUsableSubnetworks(ListUsableSubnetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableSubnetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsableSubnetworksRequest, ListUsableSubnetworksResponse, UsableSubnetwork>(_callListUsableSubnetworks, request, callSettings);
        }

        /// <summary>
        /// Lists subnetworks that are usable for creating clusters in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UsableSubnetwork"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsableSubnetworksResponse, UsableSubnetwork> ListUsableSubnetworksAsync(ListUsableSubnetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsableSubnetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsableSubnetworksRequest, ListUsableSubnetworksResponse, UsableSubnetwork>(_callListUsableSubnetworks, request, callSettings);
        }
    }

    public partial class ListUsableSubnetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsableSubnetworksResponse : gaxgrpc::IPageResponse<UsableSubnetwork>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UsableSubnetwork> GetEnumerator() => Subnetworks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
