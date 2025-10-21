// Copyright 2025 Google LLC
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

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.OracleDatabase.V1
{
    /// <summary>Settings for <see cref="OracleDatabaseClient"/> instances.</summary>
    public sealed partial class OracleDatabaseSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OracleDatabaseSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OracleDatabaseSettings"/>.</returns>
        public static OracleDatabaseSettings GetDefault() => new OracleDatabaseSettings();

        /// <summary>Constructs a new <see cref="OracleDatabaseSettings"/> object with default settings.</summary>
        public OracleDatabaseSettings()
        {
        }

        private OracleDatabaseSettings(OracleDatabaseSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCloudExadataInfrastructuresSettings = existing.ListCloudExadataInfrastructuresSettings;
            GetCloudExadataInfrastructureSettings = existing.GetCloudExadataInfrastructureSettings;
            CreateCloudExadataInfrastructureSettings = existing.CreateCloudExadataInfrastructureSettings;
            CreateCloudExadataInfrastructureOperationsSettings = existing.CreateCloudExadataInfrastructureOperationsSettings.Clone();
            DeleteCloudExadataInfrastructureSettings = existing.DeleteCloudExadataInfrastructureSettings;
            DeleteCloudExadataInfrastructureOperationsSettings = existing.DeleteCloudExadataInfrastructureOperationsSettings.Clone();
            ListCloudVmClustersSettings = existing.ListCloudVmClustersSettings;
            GetCloudVmClusterSettings = existing.GetCloudVmClusterSettings;
            CreateCloudVmClusterSettings = existing.CreateCloudVmClusterSettings;
            CreateCloudVmClusterOperationsSettings = existing.CreateCloudVmClusterOperationsSettings.Clone();
            DeleteCloudVmClusterSettings = existing.DeleteCloudVmClusterSettings;
            DeleteCloudVmClusterOperationsSettings = existing.DeleteCloudVmClusterOperationsSettings.Clone();
            ListEntitlementsSettings = existing.ListEntitlementsSettings;
            ListDbServersSettings = existing.ListDbServersSettings;
            ListDbNodesSettings = existing.ListDbNodesSettings;
            ListGiVersionsSettings = existing.ListGiVersionsSettings;
            ListMinorVersionsSettings = existing.ListMinorVersionsSettings;
            ListDbSystemShapesSettings = existing.ListDbSystemShapesSettings;
            ListAutonomousDatabasesSettings = existing.ListAutonomousDatabasesSettings;
            GetAutonomousDatabaseSettings = existing.GetAutonomousDatabaseSettings;
            CreateAutonomousDatabaseSettings = existing.CreateAutonomousDatabaseSettings;
            CreateAutonomousDatabaseOperationsSettings = existing.CreateAutonomousDatabaseOperationsSettings.Clone();
            UpdateAutonomousDatabaseSettings = existing.UpdateAutonomousDatabaseSettings;
            UpdateAutonomousDatabaseOperationsSettings = existing.UpdateAutonomousDatabaseOperationsSettings.Clone();
            DeleteAutonomousDatabaseSettings = existing.DeleteAutonomousDatabaseSettings;
            DeleteAutonomousDatabaseOperationsSettings = existing.DeleteAutonomousDatabaseOperationsSettings.Clone();
            RestoreAutonomousDatabaseSettings = existing.RestoreAutonomousDatabaseSettings;
            RestoreAutonomousDatabaseOperationsSettings = existing.RestoreAutonomousDatabaseOperationsSettings.Clone();
            GenerateAutonomousDatabaseWalletSettings = existing.GenerateAutonomousDatabaseWalletSettings;
            ListAutonomousDbVersionsSettings = existing.ListAutonomousDbVersionsSettings;
            ListAutonomousDatabaseCharacterSetsSettings = existing.ListAutonomousDatabaseCharacterSetsSettings;
            ListAutonomousDatabaseBackupsSettings = existing.ListAutonomousDatabaseBackupsSettings;
            StopAutonomousDatabaseSettings = existing.StopAutonomousDatabaseSettings;
            StopAutonomousDatabaseOperationsSettings = existing.StopAutonomousDatabaseOperationsSettings.Clone();
            StartAutonomousDatabaseSettings = existing.StartAutonomousDatabaseSettings;
            StartAutonomousDatabaseOperationsSettings = existing.StartAutonomousDatabaseOperationsSettings.Clone();
            RestartAutonomousDatabaseSettings = existing.RestartAutonomousDatabaseSettings;
            RestartAutonomousDatabaseOperationsSettings = existing.RestartAutonomousDatabaseOperationsSettings.Clone();
            SwitchoverAutonomousDatabaseSettings = existing.SwitchoverAutonomousDatabaseSettings;
            SwitchoverAutonomousDatabaseOperationsSettings = existing.SwitchoverAutonomousDatabaseOperationsSettings.Clone();
            FailoverAutonomousDatabaseSettings = existing.FailoverAutonomousDatabaseSettings;
            FailoverAutonomousDatabaseOperationsSettings = existing.FailoverAutonomousDatabaseOperationsSettings.Clone();
            ListOdbNetworksSettings = existing.ListOdbNetworksSettings;
            GetOdbNetworkSettings = existing.GetOdbNetworkSettings;
            CreateOdbNetworkSettings = existing.CreateOdbNetworkSettings;
            CreateOdbNetworkOperationsSettings = existing.CreateOdbNetworkOperationsSettings.Clone();
            DeleteOdbNetworkSettings = existing.DeleteOdbNetworkSettings;
            DeleteOdbNetworkOperationsSettings = existing.DeleteOdbNetworkOperationsSettings.Clone();
            ListOdbSubnetsSettings = existing.ListOdbSubnetsSettings;
            GetOdbSubnetSettings = existing.GetOdbSubnetSettings;
            CreateOdbSubnetSettings = existing.CreateOdbSubnetSettings;
            CreateOdbSubnetOperationsSettings = existing.CreateOdbSubnetOperationsSettings.Clone();
            DeleteOdbSubnetSettings = existing.DeleteOdbSubnetSettings;
            DeleteOdbSubnetOperationsSettings = existing.DeleteOdbSubnetOperationsSettings.Clone();
            ListExadbVmClustersSettings = existing.ListExadbVmClustersSettings;
            GetExadbVmClusterSettings = existing.GetExadbVmClusterSettings;
            CreateExadbVmClusterSettings = existing.CreateExadbVmClusterSettings;
            CreateExadbVmClusterOperationsSettings = existing.CreateExadbVmClusterOperationsSettings.Clone();
            DeleteExadbVmClusterSettings = existing.DeleteExadbVmClusterSettings;
            DeleteExadbVmClusterOperationsSettings = existing.DeleteExadbVmClusterOperationsSettings.Clone();
            UpdateExadbVmClusterSettings = existing.UpdateExadbVmClusterSettings;
            UpdateExadbVmClusterOperationsSettings = existing.UpdateExadbVmClusterOperationsSettings.Clone();
            RemoveVirtualMachineExadbVmClusterSettings = existing.RemoveVirtualMachineExadbVmClusterSettings;
            RemoveVirtualMachineExadbVmClusterOperationsSettings = existing.RemoveVirtualMachineExadbVmClusterOperationsSettings.Clone();
            ListExascaleDbStorageVaultsSettings = existing.ListExascaleDbStorageVaultsSettings;
            GetExascaleDbStorageVaultSettings = existing.GetExascaleDbStorageVaultSettings;
            CreateExascaleDbStorageVaultSettings = existing.CreateExascaleDbStorageVaultSettings;
            CreateExascaleDbStorageVaultOperationsSettings = existing.CreateExascaleDbStorageVaultOperationsSettings.Clone();
            DeleteExascaleDbStorageVaultSettings = existing.DeleteExascaleDbStorageVaultSettings;
            DeleteExascaleDbStorageVaultOperationsSettings = existing.DeleteExascaleDbStorageVaultOperationsSettings.Clone();
            ListDbSystemInitialStorageSizesSettings = existing.ListDbSystemInitialStorageSizesSettings;
            ListDatabasesSettings = existing.ListDatabasesSettings;
            GetDatabaseSettings = existing.GetDatabaseSettings;
            ListPluggableDatabasesSettings = existing.ListPluggableDatabasesSettings;
            GetPluggableDatabaseSettings = existing.GetPluggableDatabaseSettings;
            ListDbSystemsSettings = existing.ListDbSystemsSettings;
            GetDbSystemSettings = existing.GetDbSystemSettings;
            CreateDbSystemSettings = existing.CreateDbSystemSettings;
            CreateDbSystemOperationsSettings = existing.CreateDbSystemOperationsSettings.Clone();
            DeleteDbSystemSettings = existing.DeleteDbSystemSettings;
            DeleteDbSystemOperationsSettings = existing.DeleteDbSystemOperationsSettings.Clone();
            ListDbVersionsSettings = existing.ListDbVersionsSettings;
            ListDatabaseCharacterSetsSettings = existing.ListDatabaseCharacterSetsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OracleDatabaseSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListCloudExadataInfrastructures</c> and
        /// <c>OracleDatabaseClient.ListCloudExadataInfrastructuresAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloudExadataInfrastructuresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetCloudExadataInfrastructure</c> and
        /// <c>OracleDatabaseClient.GetCloudExadataInfrastructureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloudExadataInfrastructureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateCloudExadataInfrastructure</c> and
        /// <c>OracleDatabaseClient.CreateCloudExadataInfrastructureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCloudExadataInfrastructureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateCloudExadataInfrastructure</c>
        /// and <c>OracleDatabaseClient.CreateCloudExadataInfrastructureAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateCloudExadataInfrastructureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteCloudExadataInfrastructure</c> and
        /// <c>OracleDatabaseClient.DeleteCloudExadataInfrastructureAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCloudExadataInfrastructureSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteCloudExadataInfrastructure</c>
        /// and <c>OracleDatabaseClient.DeleteCloudExadataInfrastructureAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteCloudExadataInfrastructureOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListCloudVmClusters</c> and <c>OracleDatabaseClient.ListCloudVmClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloudVmClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetCloudVmCluster</c> and <c>OracleDatabaseClient.GetCloudVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloudVmClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateCloudVmCluster</c> and <c>OracleDatabaseClient.CreateCloudVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCloudVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateCloudVmCluster</c> and
        /// <c>OracleDatabaseClient.CreateCloudVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateCloudVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteCloudVmCluster</c> and <c>OracleDatabaseClient.DeleteCloudVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCloudVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteCloudVmCluster</c> and
        /// <c>OracleDatabaseClient.DeleteCloudVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteCloudVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListEntitlements</c> and <c>OracleDatabaseClient.ListEntitlementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntitlementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbServers</c> and <c>OracleDatabaseClient.ListDbServersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbNodes</c> and <c>OracleDatabaseClient.ListDbNodesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbNodesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListGiVersions</c> and <c>OracleDatabaseClient.ListGiVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGiVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListMinorVersions</c> and <c>OracleDatabaseClient.ListMinorVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMinorVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbSystemShapes</c> and <c>OracleDatabaseClient.ListDbSystemShapesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbSystemShapesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListAutonomousDatabases</c> and <c>OracleDatabaseClient.ListAutonomousDatabasesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetAutonomousDatabase</c> and <c>OracleDatabaseClient.GetAutonomousDatabaseAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.CreateAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.CreateAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.UpdateAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.UpdateAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.UpdateAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.UpdateAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.DeleteAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.DeleteAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.RestoreAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.RestoreAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.RestoreAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.RestoreAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RestoreAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GenerateAutonomousDatabaseWallet</c> and
        /// <c>OracleDatabaseClient.GenerateAutonomousDatabaseWalletAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAutonomousDatabaseWalletSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListAutonomousDbVersions</c> and
        /// <c>OracleDatabaseClient.ListAutonomousDbVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDbVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListAutonomousDatabaseCharacterSets</c> and
        /// <c>OracleDatabaseClient.ListAutonomousDatabaseCharacterSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabaseCharacterSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListAutonomousDatabaseBackups</c> and
        /// <c>OracleDatabaseClient.ListAutonomousDatabaseBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabaseBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.StopAutonomousDatabase</c> and <c>OracleDatabaseClient.StopAutonomousDatabaseAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.StopAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.StopAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StopAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.StartAutonomousDatabase</c> and <c>OracleDatabaseClient.StartAutonomousDatabaseAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.StartAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.StartAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StartAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.RestartAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.RestartAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.RestartAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.RestartAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RestartAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.SwitchoverAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.SwitchoverAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchoverAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.SwitchoverAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.SwitchoverAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SwitchoverAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.FailoverAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.FailoverAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.FailoverAutonomousDatabase</c> and
        /// <c>OracleDatabaseClient.FailoverAutonomousDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings FailoverAutonomousDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListOdbNetworks</c> and <c>OracleDatabaseClient.ListOdbNetworksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOdbNetworksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetOdbNetwork</c> and <c>OracleDatabaseClient.GetOdbNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOdbNetworkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateOdbNetwork</c> and <c>OracleDatabaseClient.CreateOdbNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOdbNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateOdbNetwork</c> and
        /// <c>OracleDatabaseClient.CreateOdbNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateOdbNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteOdbNetwork</c> and <c>OracleDatabaseClient.DeleteOdbNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOdbNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteOdbNetwork</c> and
        /// <c>OracleDatabaseClient.DeleteOdbNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteOdbNetworkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListOdbSubnets</c> and <c>OracleDatabaseClient.ListOdbSubnetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOdbSubnetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetOdbSubnet</c> and <c>OracleDatabaseClient.GetOdbSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOdbSubnetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateOdbSubnet</c> and <c>OracleDatabaseClient.CreateOdbSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOdbSubnetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateOdbSubnet</c> and
        /// <c>OracleDatabaseClient.CreateOdbSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateOdbSubnetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteOdbSubnet</c> and <c>OracleDatabaseClient.DeleteOdbSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOdbSubnetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteOdbSubnet</c> and
        /// <c>OracleDatabaseClient.DeleteOdbSubnetAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteOdbSubnetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListExadbVmClusters</c> and <c>OracleDatabaseClient.ListExadbVmClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExadbVmClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetExadbVmCluster</c> and <c>OracleDatabaseClient.GetExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExadbVmClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateExadbVmCluster</c> and <c>OracleDatabaseClient.CreateExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExadbVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateExadbVmCluster</c> and
        /// <c>OracleDatabaseClient.CreateExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateExadbVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteExadbVmCluster</c> and <c>OracleDatabaseClient.DeleteExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExadbVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteExadbVmCluster</c> and
        /// <c>OracleDatabaseClient.DeleteExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteExadbVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.UpdateExadbVmCluster</c> and <c>OracleDatabaseClient.UpdateExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExadbVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.UpdateExadbVmCluster</c> and
        /// <c>OracleDatabaseClient.UpdateExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateExadbVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.RemoveVirtualMachineExadbVmCluster</c> and
        /// <c>OracleDatabaseClient.RemoveVirtualMachineExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveVirtualMachineExadbVmClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.RemoveVirtualMachineExadbVmCluster</c>
        /// and <c>OracleDatabaseClient.RemoveVirtualMachineExadbVmClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RemoveVirtualMachineExadbVmClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListExascaleDbStorageVaults</c> and
        /// <c>OracleDatabaseClient.ListExascaleDbStorageVaultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExascaleDbStorageVaultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetExascaleDbStorageVault</c> and
        /// <c>OracleDatabaseClient.GetExascaleDbStorageVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExascaleDbStorageVaultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateExascaleDbStorageVault</c> and
        /// <c>OracleDatabaseClient.CreateExascaleDbStorageVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExascaleDbStorageVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateExascaleDbStorageVault</c> and
        /// <c>OracleDatabaseClient.CreateExascaleDbStorageVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateExascaleDbStorageVaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteExascaleDbStorageVault</c> and
        /// <c>OracleDatabaseClient.DeleteExascaleDbStorageVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExascaleDbStorageVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteExascaleDbStorageVault</c> and
        /// <c>OracleDatabaseClient.DeleteExascaleDbStorageVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteExascaleDbStorageVaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbSystemInitialStorageSizes</c> and
        /// <c>OracleDatabaseClient.ListDbSystemInitialStorageSizesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbSystemInitialStorageSizesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDatabases</c> and <c>OracleDatabaseClient.ListDatabasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatabasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetDatabase</c> and <c>OracleDatabaseClient.GetDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatabaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListPluggableDatabases</c> and <c>OracleDatabaseClient.ListPluggableDatabasesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPluggableDatabasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetPluggableDatabase</c> and <c>OracleDatabaseClient.GetPluggableDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPluggableDatabaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbSystems</c> and <c>OracleDatabaseClient.ListDbSystemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbSystemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.GetDbSystem</c> and <c>OracleDatabaseClient.GetDbSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDbSystemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.CreateDbSystem</c> and <c>OracleDatabaseClient.CreateDbSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDbSystemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.CreateDbSystem</c> and
        /// <c>OracleDatabaseClient.CreateDbSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateDbSystemOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.DeleteDbSystem</c> and <c>OracleDatabaseClient.DeleteDbSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDbSystemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OracleDatabaseClient.DeleteDbSystem</c> and
        /// <c>OracleDatabaseClient.DeleteDbSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteDbSystemOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDbVersions</c> and <c>OracleDatabaseClient.ListDbVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OracleDatabaseClient.ListDatabaseCharacterSets</c> and
        /// <c>OracleDatabaseClient.ListDatabaseCharacterSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatabaseCharacterSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OracleDatabaseSettings"/> object.</returns>
        public OracleDatabaseSettings Clone() => new OracleDatabaseSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OracleDatabaseClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class OracleDatabaseClientBuilder : gaxgrpc::ClientBuilderBase<OracleDatabaseClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OracleDatabaseSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OracleDatabaseClientBuilder() : base(OracleDatabaseClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OracleDatabaseClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OracleDatabaseClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OracleDatabaseClient Build()
        {
            OracleDatabaseClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OracleDatabaseClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OracleDatabaseClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OracleDatabaseClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OracleDatabaseClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OracleDatabaseClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OracleDatabaseClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OracleDatabaseClient.ChannelPool;
    }

    /// <summary>OracleDatabase client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class OracleDatabaseClient
    {
        /// <summary>
        /// The default endpoint for the OracleDatabase service, which is a host of "oracledatabase.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "oracledatabase.googleapis.com:443";

        /// <summary>The default OracleDatabase scopes.</summary>
        /// <remarks>
        /// The default OracleDatabase scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OracleDatabase.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OracleDatabaseClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OracleDatabaseClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OracleDatabaseClient"/>.</returns>
        public static stt::Task<OracleDatabaseClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OracleDatabaseClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OracleDatabaseClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OracleDatabaseClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OracleDatabaseClient"/>.</returns>
        public static OracleDatabaseClient Create() => new OracleDatabaseClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OracleDatabaseClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OracleDatabaseSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OracleDatabaseClient"/>.</returns>
        internal static OracleDatabaseClient Create(grpccore::CallInvoker callInvoker, OracleDatabaseSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OracleDatabase.OracleDatabaseClient grpcClient = new OracleDatabase.OracleDatabaseClient(callInvoker);
            return new OracleDatabaseClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC OracleDatabase client</summary>
        public virtual OracleDatabase.OracleDatabaseClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructures(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudExadataInfrastructures(request, callSettings);
        }

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructuresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudExadataInfrastructuresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructures(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudExadataInfrastructures(request, callSettings);
        }

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructuresAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudExadataInfrastructuresAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudExadataInfrastructure GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, st::CancellationToken cancellationToken) =>
            GetCloudExadataInfrastructureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudExadataInfrastructure GetCloudExadataInfrastructure(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudExadataInfrastructure(new GetCloudExadataInfrastructureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudExadataInfrastructureAsync(new GetCloudExadataInfrastructureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloudExadataInfrastructureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudExadataInfrastructure GetCloudExadataInfrastructure(CloudExadataInfrastructureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudExadataInfrastructure(new GetCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(CloudExadataInfrastructureName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudExadataInfrastructureAsync(new GetCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(CloudExadataInfrastructureName name, st::CancellationToken cancellationToken) =>
            GetCloudExadataInfrastructureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudExadataInfrastructure, OperationMetadata> CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, st::CancellationToken cancellationToken) =>
            CreateCloudExadataInfrastructureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCloudExadataInfrastructure</c>.</summary>
        public virtual lro::OperationsClient CreateCloudExadataInfrastructureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCloudExadataInfrastructure</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CloudExadataInfrastructure, OperationMetadata> PollOnceCreateCloudExadataInfrastructure(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudExadataInfrastructure, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloudExadataInfrastructureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCloudExadataInfrastructure</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> PollOnceCreateCloudExadataInfrastructureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudExadataInfrastructure, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloudExadataInfrastructureOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudExadataInfrastructure, OperationMetadata> CreateCloudExadataInfrastructure(string parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudExadataInfrastructure(new CreateCloudExadataInfrastructureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudExadataInfrastructureId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudExadataInfrastructureId, nameof(cloudExadataInfrastructureId)),
                CloudExadataInfrastructure = gax::GaxPreconditions.CheckNotNull(cloudExadataInfrastructure, nameof(cloudExadataInfrastructure)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(string parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudExadataInfrastructureAsync(new CreateCloudExadataInfrastructureRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudExadataInfrastructureId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudExadataInfrastructureId, nameof(cloudExadataInfrastructureId)),
                CloudExadataInfrastructure = gax::GaxPreconditions.CheckNotNull(cloudExadataInfrastructure, nameof(cloudExadataInfrastructure)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(string parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, st::CancellationToken cancellationToken) =>
            CreateCloudExadataInfrastructureAsync(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudExadataInfrastructure, OperationMetadata> CreateCloudExadataInfrastructure(gagr::LocationName parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudExadataInfrastructure(new CreateCloudExadataInfrastructureRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudExadataInfrastructureId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudExadataInfrastructureId, nameof(cloudExadataInfrastructureId)),
                CloudExadataInfrastructure = gax::GaxPreconditions.CheckNotNull(cloudExadataInfrastructure, nameof(cloudExadataInfrastructure)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(gagr::LocationName parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudExadataInfrastructureAsync(new CreateCloudExadataInfrastructureRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudExadataInfrastructureId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudExadataInfrastructureId, nameof(cloudExadataInfrastructureId)),
                CloudExadataInfrastructure = gax::GaxPreconditions.CheckNotNull(cloudExadataInfrastructure, nameof(cloudExadataInfrastructure)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for CloudExadataInfrastructure in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudExadataInfrastructure">
        /// Required. Details of the Exadata Infrastructure instance to create.
        /// </param>
        /// <param name="cloudExadataInfrastructureId">
        /// Required. The ID of the Exadata Infrastructure to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(gagr::LocationName parent, CloudExadataInfrastructure cloudExadataInfrastructure, string cloudExadataInfrastructureId, st::CancellationToken cancellationToken) =>
            CreateCloudExadataInfrastructureAsync(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, st::CancellationToken cancellationToken) =>
            DeleteCloudExadataInfrastructureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCloudExadataInfrastructure</c>.</summary>
        public virtual lro::OperationsClient DeleteCloudExadataInfrastructureOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCloudExadataInfrastructure</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCloudExadataInfrastructure(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCloudExadataInfrastructureOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCloudExadataInfrastructure</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCloudExadataInfrastructureAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCloudExadataInfrastructureOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudExadataInfrastructure(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudExadataInfrastructure(new DeleteCloudExadataInfrastructureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudExadataInfrastructureAsync(new DeleteCloudExadataInfrastructureRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCloudExadataInfrastructureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudExadataInfrastructure(CloudExadataInfrastructureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudExadataInfrastructure(new DeleteCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(CloudExadataInfrastructureName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudExadataInfrastructureAsync(new DeleteCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud Exadata Infrastructure in the following
        /// format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(CloudExadataInfrastructureName name, st::CancellationToken cancellationToken) =>
            DeleteCloudExadataInfrastructureAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClusters(ListCloudVmClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClustersAsync(ListCloudVmClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudVmClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudVmClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudVmClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloudVmClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudVmCluster GetCloudVmCluster(GetCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, st::CancellationToken cancellationToken) =>
            GetCloudVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudVmCluster GetCloudVmCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudVmCluster(new GetCloudVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudVmClusterAsync(new GetCloudVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloudVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudVmCluster GetCloudVmCluster(CloudVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudVmCluster(new GetCloudVmClusterRequest
            {
                CloudVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(CloudVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudVmClusterAsync(new GetCloudVmClusterRequest
            {
                CloudVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudVmCluster> GetCloudVmClusterAsync(CloudVmClusterName name, st::CancellationToken cancellationToken) =>
            GetCloudVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudVmCluster, OperationMetadata> CreateCloudVmCluster(CreateCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateCloudVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCloudVmCluster</c>.</summary>
        public virtual lro::OperationsClient CreateCloudVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCloudVmCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CloudVmCluster, OperationMetadata> PollOnceCreateCloudVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudVmCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloudVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCloudVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> PollOnceCreateCloudVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudVmCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloudVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudVmCluster, OperationMetadata> CreateCloudVmCluster(string parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudVmCluster(new CreateCloudVmClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)),
                CloudVmCluster = gax::GaxPreconditions.CheckNotNull(cloudVmCluster, nameof(cloudVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(string parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudVmClusterAsync(new CreateCloudVmClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)),
                CloudVmCluster = gax::GaxPreconditions.CheckNotNull(cloudVmCluster, nameof(cloudVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(string parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, st::CancellationToken cancellationToken) =>
            CreateCloudVmClusterAsync(parent, cloudVmCluster, cloudVmClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudVmCluster, OperationMetadata> CreateCloudVmCluster(gagr::LocationName parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudVmCluster(new CreateCloudVmClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)),
                CloudVmCluster = gax::GaxPreconditions.CheckNotNull(cloudVmCluster, nameof(cloudVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(gagr::LocationName parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudVmClusterAsync(new CreateCloudVmClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudVmClusterId, nameof(cloudVmClusterId)),
                CloudVmCluster = gax::GaxPreconditions.CheckNotNull(cloudVmCluster, nameof(cloudVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="cloudVmCluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudVmClusterId">
        /// Required. The ID of the VM Cluster to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(gagr::LocationName parent, CloudVmCluster cloudVmCluster, string cloudVmClusterId, st::CancellationToken cancellationToken) =>
            CreateCloudVmClusterAsync(parent, cloudVmCluster, cloudVmClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudVmCluster(DeleteCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteCloudVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCloudVmCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteCloudVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCloudVmCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCloudVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCloudVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCloudVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCloudVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCloudVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudVmCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudVmCluster(new DeleteCloudVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudVmClusterAsync(new DeleteCloudVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCloudVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudVmCluster(CloudVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudVmCluster(new DeleteCloudVmClusterRequest
            {
                CloudVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(CloudVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudVmClusterAsync(new DeleteCloudVmClusterRequest
            {
                CloudVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Cloud VM Cluster in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloud_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(CloudVmClusterName name, st::CancellationToken cancellationToken) =>
            DeleteCloudVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the entitlement in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the entitlement in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the entitlement in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the entitlement in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbServersResponse, DbServer> ListDbServers(ListDbServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbServersResponse, DbServer> ListDbServersAsync(ListDbServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database server in the following format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbServersResponse, DbServer> ListDbServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbServersRequest request = new ListDbServersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbServers(request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database server in the following format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbServersResponse, DbServer> ListDbServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbServersRequest request = new ListDbServersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database server in the following format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbServersResponse, DbServer> ListDbServers(CloudExadataInfrastructureName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbServersRequest request = new ListDbServersRequest
            {
                ParentAsCloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbServers(request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database server in the following format:
        /// projects/{project}/locations/{location}/cloudExadataInfrastructures/{cloudExadataInfrastructure}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbServersResponse, DbServer> ListDbServersAsync(CloudExadataInfrastructureName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbServersRequest request = new ListDbServersRequest
            {
                ParentAsCloudExadataInfrastructureName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbNodesResponse, DbNode> ListDbNodes(ListDbNodesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbNodesResponse, DbNode> ListDbNodesAsync(ListDbNodesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbNodesResponse, DbNode> ListDbNodes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodes(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbNodesResponse, DbNode> ListDbNodesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbNodesResponse, DbNode> ListDbNodes(CloudVmClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsCloudVmClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodes(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbNodesResponse, DbNode> ListDbNodesAsync(CloudVmClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsCloudVmClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbNodesResponse, DbNode> ListDbNodes(ExadbVmClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodes(request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for database node in the following format:
        /// projects/{project}/locations/{location}/cloudVmClusters/{cloudVmCluster}.
        /// .
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbNode"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbNodesResponse, DbNode> ListDbNodesAsync(ExadbVmClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbNodesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersions(ListGiVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersionsAsync(ListGiVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Grid Infrastructure Version in the following
        /// format: Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGiVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Grid Infrastructure Version in the following
        /// format: Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGiVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Grid Infrastructure Version in the following
        /// format: Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGiVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Grid Infrastructure Version in the following
        /// format: Format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GiVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGiVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersions(ListMinorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersionsAsync(ListMinorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the MinorVersion resource with the format:
        /// projects/{project}/locations/{location}/giVersions/{gi_version}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMinorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the MinorVersion resource with the format:
        /// projects/{project}/locations/{location}/giVersions/{gi_version}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMinorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the MinorVersion resource with the format:
        /// projects/{project}/locations/{location}/giVersions/{gi_version}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersions(GiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                ParentAsGiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMinorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the MinorVersion resource with the format:
        /// projects/{project}/locations/{location}/giVersions/{gi_version}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MinorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersionsAsync(GiVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                ParentAsGiVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMinorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapes(ListDbSystemShapesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapesAsync(ListDbSystemShapesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Database System Shapes in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemShapes(request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Database System Shapes in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemShapesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Database System Shapes in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemShapes(request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for Database System Shapes in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemShape"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemShapesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabases(ListAutonomousDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabasesAsync(ListAutonomousDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabases(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabasesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutonomousDatabase GetAutonomousDatabase(GetAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            GetAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutonomousDatabase GetAutonomousDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutonomousDatabase(new GetAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutonomousDatabaseAsync(new GetAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutonomousDatabase GetAutonomousDatabase(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutonomousDatabase(new GetAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutonomousDatabaseAsync(new GetAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(AutonomousDatabaseName name, st::CancellationToken cancellationToken) =>
            GetAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> CreateAutonomousDatabase(CreateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            CreateAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient CreateAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceCreateAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceCreateAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> CreateAutonomousDatabase(string parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutonomousDatabase(new CreateAutonomousDatabaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AutonomousDatabaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseId, nameof(autonomousDatabaseId)),
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(string parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutonomousDatabaseAsync(new CreateAutonomousDatabaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AutonomousDatabaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseId, nameof(autonomousDatabaseId)),
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(string parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, st::CancellationToken cancellationToken) =>
            CreateAutonomousDatabaseAsync(parent, autonomousDatabase, autonomousDatabaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> CreateAutonomousDatabase(gagr::LocationName parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutonomousDatabase(new CreateAutonomousDatabaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AutonomousDatabaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseId, nameof(autonomousDatabaseId)),
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(gagr::LocationName parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutonomousDatabaseAsync(new CreateAutonomousDatabaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AutonomousDatabaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(autonomousDatabaseId, nameof(autonomousDatabaseId)),
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="autonomousDatabase">
        /// Required. The Autonomous Database being created.
        /// </param>
        /// <param name="autonomousDatabaseId">
        /// Required. The ID of the Autonomous Database to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(gagr::LocationName parent, AutonomousDatabase autonomousDatabase, string autonomousDatabaseId, st::CancellationToken cancellationToken) =>
            CreateAutonomousDatabaseAsync(parent, autonomousDatabase, autonomousDatabaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> UpdateAutonomousDatabase(UpdateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient UpdateAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceUpdateAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceUpdateAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="autonomousDatabase">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Exadata resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. If the user does not provide a mask then all fields
        /// will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> UpdateAutonomousDatabase(AutonomousDatabase autonomousDatabase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutonomousDatabase(new UpdateAutonomousDatabaseRequest
            {
                UpdateMask = updateMask,
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="autonomousDatabase">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Exadata resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. If the user does not provide a mask then all fields
        /// will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> UpdateAutonomousDatabaseAsync(AutonomousDatabase autonomousDatabase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutonomousDatabaseAsync(new UpdateAutonomousDatabaseRequest
            {
                UpdateMask = updateMask,
                AutonomousDatabase = gax::GaxPreconditions.CheckNotNull(autonomousDatabase, nameof(autonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="autonomousDatabase">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Exadata resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. If the user does not provide a mask then all fields
        /// will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> UpdateAutonomousDatabaseAsync(AutonomousDatabase autonomousDatabase, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAutonomousDatabaseAsync(autonomousDatabase, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutonomousDatabase(DeleteAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            DeleteAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient DeleteAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutonomousDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutonomousDatabase(new DeleteAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutonomousDatabaseAsync(new DeleteAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutonomousDatabase(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutonomousDatabase(new DeleteAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutonomousDatabaseAsync(new DeleteAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(AutonomousDatabaseName name, st::CancellationToken cancellationToken) =>
            DeleteAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestoreAutonomousDatabase(RestoreAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            RestoreAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient RestoreAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceRestoreAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceRestoreAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestoreAutonomousDatabase(string name, wkt::Timestamp restoreTime, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAutonomousDatabase(new RestoreAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RestoreTime = gax::GaxPreconditions.CheckNotNull(restoreTime, nameof(restoreTime)),
            }, callSettings);

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(string name, wkt::Timestamp restoreTime, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAutonomousDatabaseAsync(new RestoreAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RestoreTime = gax::GaxPreconditions.CheckNotNull(restoreTime, nameof(restoreTime)),
            }, callSettings);

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(string name, wkt::Timestamp restoreTime, st::CancellationToken cancellationToken) =>
            RestoreAutonomousDatabaseAsync(name, restoreTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestoreAutonomousDatabase(AutonomousDatabaseName name, wkt::Timestamp restoreTime, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAutonomousDatabase(new RestoreAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RestoreTime = gax::GaxPreconditions.CheckNotNull(restoreTime, nameof(restoreTime)),
            }, callSettings);

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(AutonomousDatabaseName name, wkt::Timestamp restoreTime, gaxgrpc::CallSettings callSettings = null) =>
            RestoreAutonomousDatabaseAsync(new RestoreAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RestoreTime = gax::GaxPreconditions.CheckNotNull(restoreTime, nameof(restoreTime)),
            }, callSettings);

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="restoreTime">
        /// Required. The time and date to restore the database to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(AutonomousDatabaseName name, wkt::Timestamp restoreTime, st::CancellationToken cancellationToken) =>
            RestoreAutonomousDatabaseAsync(name, restoreTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAutonomousDatabaseWalletResponse GenerateAutonomousDatabaseWallet(GenerateAutonomousDatabaseWalletRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(GenerateAutonomousDatabaseWalletRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(GenerateAutonomousDatabaseWalletRequest request, st::CancellationToken cancellationToken) =>
            GenerateAutonomousDatabaseWalletAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAutonomousDatabaseWalletResponse GenerateAutonomousDatabaseWallet(string name, GenerateType type, bool isRegional, string password, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAutonomousDatabaseWallet(new GenerateAutonomousDatabaseWalletRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Type = type,
                IsRegional = isRegional,
                Password = gax::GaxPreconditions.CheckNotNullOrEmpty(password, nameof(password)),
            }, callSettings);

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(string name, GenerateType type, bool isRegional, string password, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAutonomousDatabaseWalletAsync(new GenerateAutonomousDatabaseWalletRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Type = type,
                IsRegional = isRegional,
                Password = gax::GaxPreconditions.CheckNotNullOrEmpty(password, nameof(password)),
            }, callSettings);

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(string name, GenerateType type, bool isRegional, string password, st::CancellationToken cancellationToken) =>
            GenerateAutonomousDatabaseWalletAsync(name, type, isRegional, password, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAutonomousDatabaseWalletResponse GenerateAutonomousDatabaseWallet(AutonomousDatabaseName name, GenerateType type, bool isRegional, string password, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAutonomousDatabaseWallet(new GenerateAutonomousDatabaseWalletRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Type = type,
                IsRegional = isRegional,
                Password = gax::GaxPreconditions.CheckNotNullOrEmpty(password, nameof(password)),
            }, callSettings);

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(AutonomousDatabaseName name, GenerateType type, bool isRegional, string password, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAutonomousDatabaseWalletAsync(new GenerateAutonomousDatabaseWalletRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Type = type,
                IsRegional = isRegional,
                Password = gax::GaxPreconditions.CheckNotNullOrEmpty(password, nameof(password)),
            }, callSettings);

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="type">
        /// Optional. The type of wallet generation for the Autonomous Database. The
        /// default value is SINGLE.
        /// </param>
        /// <param name="isRegional">
        /// Optional. True when requesting regional connection strings in PDB connect
        /// info, applicable to cross-region Data Guard only.
        /// </param>
        /// <param name="password">
        /// Required. The password used to encrypt the keys inside the wallet. The
        /// password must be a minimum of 8 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(AutonomousDatabaseName name, GenerateType type, bool isRegional, string password, st::CancellationToken cancellationToken) =>
            GenerateAutonomousDatabaseWalletAsync(name, type, isRegional, password, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersions(ListAutonomousDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersionsAsync(ListAutonomousDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDbVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDbVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDbVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDbVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSets(ListAutonomousDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSetsAsync(ListAutonomousDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseCharacterSets(request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseCharacterSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseCharacterSets(request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the Autonomous Database in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseCharacterSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackups(ListAutonomousDatabaseBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackupsAsync(ListAutonomousDatabaseBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ListAutonomousDatabaseBackups in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseBackups(request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ListAutonomousDatabaseBackups in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ListAutonomousDatabaseBackups in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseBackups(request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ListAutonomousDatabaseBackups in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutonomousDatabaseBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StopAutonomousDatabase(StopAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            StopAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient StopAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceStopAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceStopAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StopAutonomousDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopAutonomousDatabase(new StopAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopAutonomousDatabaseAsync(new StopAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            StopAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StopAutonomousDatabase(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            StopAutonomousDatabase(new StopAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            StopAutonomousDatabaseAsync(new StopAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(AutonomousDatabaseName name, st::CancellationToken cancellationToken) =>
            StopAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StartAutonomousDatabase(StartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            StartAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient StartAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceStartAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceStartAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StartAutonomousDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartAutonomousDatabase(new StartAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartAutonomousDatabaseAsync(new StartAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            StartAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> StartAutonomousDatabase(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            StartAutonomousDatabase(new StartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            StartAutonomousDatabaseAsync(new StartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(AutonomousDatabaseName name, st::CancellationToken cancellationToken) =>
            StartAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestartAutonomousDatabase(RestartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(RestartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(RestartAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            RestartAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestartAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient RestartAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestartAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceRestartAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestartAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceRestartAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestartAutonomousDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartAutonomousDatabase(new RestartAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartAutonomousDatabaseAsync(new RestartAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            RestartAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> RestartAutonomousDatabase(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartAutonomousDatabase(new RestartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(AutonomousDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartAutonomousDatabaseAsync(new RestartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(AutonomousDatabaseName name, st::CancellationToken cancellationToken) =>
            RestartAutonomousDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> SwitchoverAutonomousDatabase(SwitchoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            SwitchoverAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SwitchoverAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient SwitchoverAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchoverAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceSwitchoverAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchoverAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchoverAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceSwitchoverAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchoverAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> SwitchoverAutonomousDatabase(string name, string peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverAutonomousDatabase(new SwitchoverAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PeerAutonomousDatabase = gax::GaxPreconditions.CheckNotNullOrEmpty(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(string name, string peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverAutonomousDatabaseAsync(new SwitchoverAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PeerAutonomousDatabase = gax::GaxPreconditions.CheckNotNullOrEmpty(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(string name, string peerAutonomousDatabase, st::CancellationToken cancellationToken) =>
            SwitchoverAutonomousDatabaseAsync(name, peerAutonomousDatabase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> SwitchoverAutonomousDatabase(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverAutonomousDatabase(new SwitchoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverAutonomousDatabaseAsync(new SwitchoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to switch over to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, st::CancellationToken cancellationToken) =>
            SwitchoverAutonomousDatabaseAsync(name, peerAutonomousDatabase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> FailoverAutonomousDatabase(FailoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest request, st::CancellationToken cancellationToken) =>
            FailoverAutonomousDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FailoverAutonomousDatabase</c>.</summary>
        public virtual lro::OperationsClient FailoverAutonomousDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FailoverAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> PollOnceFailoverAutonomousDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FailoverAutonomousDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> PollOnceFailoverAutonomousDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AutonomousDatabase, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverAutonomousDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> FailoverAutonomousDatabase(string name, string peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            FailoverAutonomousDatabase(new FailoverAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PeerAutonomousDatabase = gax::GaxPreconditions.CheckNotNullOrEmpty(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(string name, string peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            FailoverAutonomousDatabaseAsync(new FailoverAutonomousDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PeerAutonomousDatabase = gax::GaxPreconditions.CheckNotNullOrEmpty(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(string name, string peerAutonomousDatabase, st::CancellationToken cancellationToken) =>
            FailoverAutonomousDatabaseAsync(name, peerAutonomousDatabase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AutonomousDatabase, OperationMetadata> FailoverAutonomousDatabase(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            FailoverAutonomousDatabase(new FailoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, gaxgrpc::CallSettings callSettings = null) =>
            FailoverAutonomousDatabaseAsync(new FailoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = gax::GaxPreconditions.CheckNotNull(peerAutonomousDatabase, nameof(peerAutonomousDatabase)),
            }, callSettings);

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Autonomous Database in the following format:
        /// projects/{project}/locations/{location}/autonomousDatabases/{autonomous_database}.
        /// </param>
        /// <param name="peerAutonomousDatabase">
        /// Required. The peer database name to fail over to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(AutonomousDatabaseName name, AutonomousDatabaseName peerAutonomousDatabase, st::CancellationToken cancellationToken) =>
            FailoverAutonomousDatabaseAsync(name, peerAutonomousDatabase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworks(ListOdbNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworksAsync(ListOdbNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the ODB Network in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbNetworks(request, callSettings);
        }

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the ODB Network in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbNetworksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the ODB Network in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbNetworks(request, callSettings);
        }

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the ODB Network in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbNetwork"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbNetworksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbNetwork GetOdbNetwork(GetOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(GetOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(GetOdbNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetOdbNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbNetwork GetOdbNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbNetwork(new GetOdbNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbNetworkAsync(new GetOdbNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetOdbNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbNetwork GetOdbNetwork(OdbNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbNetwork(new GetOdbNetworkRequest
            {
                OdbNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(OdbNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbNetworkAsync(new GetOdbNetworkRequest
            {
                OdbNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbNetwork> GetOdbNetworkAsync(OdbNetworkName name, st::CancellationToken cancellationToken) =>
            GetOdbNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbNetwork, OperationMetadata> CreateOdbNetwork(CreateOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, st::CancellationToken cancellationToken) =>
            CreateOdbNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOdbNetwork</c>.</summary>
        public virtual lro::OperationsClient CreateOdbNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateOdbNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OdbNetwork, OperationMetadata> PollOnceCreateOdbNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OdbNetwork, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOdbNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOdbNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> PollOnceCreateOdbNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OdbNetwork, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOdbNetworkOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbNetwork, OperationMetadata> CreateOdbNetwork(string parent, OdbNetwork odbNetwork, string odbNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbNetwork(new CreateOdbNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OdbNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)),
                OdbNetwork = gax::GaxPreconditions.CheckNotNull(odbNetwork, nameof(odbNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(string parent, OdbNetwork odbNetwork, string odbNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbNetworkAsync(new CreateOdbNetworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OdbNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)),
                OdbNetwork = gax::GaxPreconditions.CheckNotNull(odbNetwork, nameof(odbNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(string parent, OdbNetwork odbNetwork, string odbNetworkId, st::CancellationToken cancellationToken) =>
            CreateOdbNetworkAsync(parent, odbNetwork, odbNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbNetwork, OperationMetadata> CreateOdbNetwork(gagr::LocationName parent, OdbNetwork odbNetwork, string odbNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbNetwork(new CreateOdbNetworkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OdbNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)),
                OdbNetwork = gax::GaxPreconditions.CheckNotNull(odbNetwork, nameof(odbNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(gagr::LocationName parent, OdbNetwork odbNetwork, string odbNetworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbNetworkAsync(new CreateOdbNetworkRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OdbNetworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbNetworkId, nameof(odbNetworkId)),
                OdbNetwork = gax::GaxPreconditions.CheckNotNull(odbNetwork, nameof(odbNetwork)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbNetwork in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="odbNetwork">
        /// Required. Details of the OdbNetwork instance to create.
        /// </param>
        /// <param name="odbNetworkId">
        /// Required. The ID of the OdbNetwork to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(gagr::LocationName parent, OdbNetwork odbNetwork, string odbNetworkId, st::CancellationToken cancellationToken) =>
            CreateOdbNetworkAsync(parent, odbNetwork, odbNetworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbNetwork(DeleteOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, st::CancellationToken cancellationToken) =>
            DeleteOdbNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOdbNetwork</c>.</summary>
        public virtual lro::OperationsClient DeleteOdbNetworkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteOdbNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteOdbNetwork(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOdbNetworkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOdbNetwork</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteOdbNetworkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOdbNetworkOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbNetwork(new DeleteOdbNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbNetworkAsync(new DeleteOdbNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOdbNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbNetwork(OdbNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbNetwork(new DeleteOdbNetworkRequest
            {
                OdbNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(OdbNetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbNetworkAsync(new DeleteOdbNetworkRequest
            {
                OdbNetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(OdbNetworkName name, st::CancellationToken cancellationToken) =>
            DeleteOdbNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnets(ListOdbSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnetsAsync(ListOdbSubnetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbSubnets(request, callSettings);
        }

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbSubnetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnets(OdbNetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                ParentAsOdbNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbSubnets(request, callSettings);
        }

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbSubnet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnetsAsync(OdbNetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                ParentAsOdbNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOdbSubnetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbSubnet GetOdbSubnet(GetOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(GetOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(GetOdbSubnetRequest request, st::CancellationToken cancellationToken) =>
            GetOdbSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbSubnet GetOdbSubnet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbSubnet(new GetOdbSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbSubnetAsync(new GetOdbSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(string name, st::CancellationToken cancellationToken) =>
            GetOdbSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OdbSubnet GetOdbSubnet(OdbSubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbSubnet(new GetOdbSubnetRequest
            {
                OdbSubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(OdbSubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOdbSubnetAsync(new GetOdbSubnetRequest
            {
                OdbSubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OdbSubnet> GetOdbSubnetAsync(OdbSubnetName name, st::CancellationToken cancellationToken) =>
            GetOdbSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbSubnet, OperationMetadata> CreateOdbSubnet(CreateOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(CreateOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(CreateOdbSubnetRequest request, st::CancellationToken cancellationToken) =>
            CreateOdbSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOdbSubnet</c>.</summary>
        public virtual lro::OperationsClient CreateOdbSubnetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateOdbSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OdbSubnet, OperationMetadata> PollOnceCreateOdbSubnet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OdbSubnet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOdbSubnetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOdbSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> PollOnceCreateOdbSubnetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OdbSubnet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOdbSubnetOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbSubnet, OperationMetadata> CreateOdbSubnet(string parent, OdbSubnet odbSubnet, string odbSubnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbSubnet(new CreateOdbSubnetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OdbSubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)),
                OdbSubnet = gax::GaxPreconditions.CheckNotNull(odbSubnet, nameof(odbSubnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(string parent, OdbSubnet odbSubnet, string odbSubnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbSubnetAsync(new CreateOdbSubnetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OdbSubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)),
                OdbSubnet = gax::GaxPreconditions.CheckNotNull(odbSubnet, nameof(odbSubnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(string parent, OdbSubnet odbSubnet, string odbSubnetId, st::CancellationToken cancellationToken) =>
            CreateOdbSubnetAsync(parent, odbSubnet, odbSubnetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OdbSubnet, OperationMetadata> CreateOdbSubnet(OdbNetworkName parent, OdbSubnet odbSubnet, string odbSubnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbSubnet(new CreateOdbSubnetRequest
            {
                ParentAsOdbNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OdbSubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)),
                OdbSubnet = gax::GaxPreconditions.CheckNotNull(odbSubnet, nameof(odbSubnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(OdbNetworkName parent, OdbSubnet odbSubnet, string odbSubnetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOdbSubnetAsync(new CreateOdbSubnetRequest
            {
                ParentAsOdbNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OdbSubnetId = gax::GaxPreconditions.CheckNotNullOrEmpty(odbSubnetId, nameof(odbSubnetId)),
                OdbSubnet = gax::GaxPreconditions.CheckNotNull(odbSubnet, nameof(odbSubnet)),
            }, callSettings);

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the OdbSubnet in the following format:
        /// projects/{project}/locations/{location}/odbNetworks/{odb_network}.
        /// </param>
        /// <param name="odbSubnet">
        /// Required. Details of the OdbSubnet instance to create.
        /// </param>
        /// <param name="odbSubnetId">
        /// Required. The ID of the OdbSubnet to create. This value is restricted
        /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
        /// characters in length. The value must start with a letter and end with
        /// a letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(OdbNetworkName parent, OdbSubnet odbSubnet, string odbSubnetId, st::CancellationToken cancellationToken) =>
            CreateOdbSubnetAsync(parent, odbSubnet, odbSubnetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbSubnet(DeleteOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(DeleteOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(DeleteOdbSubnetRequest request, st::CancellationToken cancellationToken) =>
            DeleteOdbSubnetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOdbSubnet</c>.</summary>
        public virtual lro::OperationsClient DeleteOdbSubnetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteOdbSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteOdbSubnet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOdbSubnetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOdbSubnet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteOdbSubnetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOdbSubnetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbSubnet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbSubnet(new DeleteOdbSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbSubnetAsync(new DeleteOdbSubnetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOdbSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbSubnet(OdbSubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbSubnet(new DeleteOdbSubnetRequest
            {
                OdbSubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(OdbSubnetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOdbSubnetAsync(new DeleteOdbSubnetRequest
            {
                OdbSubnetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource in the following format:
        /// projects/{project}/locations/{region}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(OdbSubnetName name, st::CancellationToken cancellationToken) =>
            DeleteOdbSubnetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClusters(ListExadbVmClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClustersAsync(ListExadbVmClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExadbVmClusters in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExadbVmClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExadbVmClusters in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExadbVmClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExadbVmClusters in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExadbVmClusters(request, callSettings);
        }

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExadbVmClusters in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExadbVmClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExadbVmCluster GetExadbVmCluster(GetExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(GetExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(GetExadbVmClusterRequest request, st::CancellationToken cancellationToken) =>
            GetExadbVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExadbVmCluster GetExadbVmCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExadbVmCluster(new GetExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExadbVmClusterAsync(new GetExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetExadbVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExadbVmCluster GetExadbVmCluster(ExadbVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExadbVmCluster(new GetExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(ExadbVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExadbVmClusterAsync(new GetExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(ExadbVmClusterName name, st::CancellationToken cancellationToken) =>
            GetExadbVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> CreateExadbVmCluster(CreateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(CreateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(CreateExadbVmClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateExadbVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateExadbVmCluster</c>.</summary>
        public virtual lro::OperationsClient CreateExadbVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateExadbVmCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> PollOnceCreateExadbVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateExadbVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> PollOnceCreateExadbVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> CreateExadbVmCluster(string parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExadbVmCluster(new CreateExadbVmClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExadbVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)),
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(string parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExadbVmClusterAsync(new CreateExadbVmClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExadbVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)),
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(string parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, st::CancellationToken cancellationToken) =>
            CreateExadbVmClusterAsync(parent, exadbVmCluster, exadbVmClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> CreateExadbVmCluster(gagr::LocationName parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExadbVmCluster(new CreateExadbVmClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExadbVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)),
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(gagr::LocationName parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExadbVmClusterAsync(new CreateExadbVmClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExadbVmClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(exadbVmClusterId, nameof(exadbVmClusterId)),
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExadbVmCluster in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exadbVmCluster">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exadbVmClusterId">
        /// Required. The ID of the ExadbVmCluster to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(gagr::LocationName parent, ExadbVmCluster exadbVmCluster, string exadbVmClusterId, st::CancellationToken cancellationToken) =>
            CreateExadbVmClusterAsync(parent, exadbVmCluster, exadbVmClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExadbVmCluster(DeleteExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteExadbVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExadbVmCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteExadbVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExadbVmCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteExadbVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExadbVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteExadbVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExadbVmCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExadbVmCluster(new DeleteExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExadbVmClusterAsync(new DeleteExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExadbVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExadbVmCluster(ExadbVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExadbVmCluster(new DeleteExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(ExadbVmClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExadbVmClusterAsync(new DeleteExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(ExadbVmClusterName name, st::CancellationToken cancellationToken) =>
            DeleteExadbVmClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> UpdateExadbVmCluster(UpdateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateExadbVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateExadbVmCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateExadbVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateExadbVmCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> PollOnceUpdateExadbVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateExadbVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> PollOnceUpdateExadbVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="exadbVmCluster">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A mask specifying which fields in th VM Cluster should be
        /// updated. A field specified in the mask is overwritten. If a mask isn't
        /// provided then all the fields in the VM Cluster are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> UpdateExadbVmCluster(ExadbVmCluster exadbVmCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExadbVmCluster(new UpdateExadbVmClusterRequest
            {
                UpdateMask = updateMask,
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="exadbVmCluster">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A mask specifying which fields in th VM Cluster should be
        /// updated. A field specified in the mask is overwritten. If a mask isn't
        /// provided then all the fields in the VM Cluster are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> UpdateExadbVmClusterAsync(ExadbVmCluster exadbVmCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExadbVmClusterAsync(new UpdateExadbVmClusterRequest
            {
                UpdateMask = updateMask,
                ExadbVmCluster = gax::GaxPreconditions.CheckNotNull(exadbVmCluster, nameof(exadbVmCluster)),
            }, callSettings);

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="exadbVmCluster">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A mask specifying which fields in th VM Cluster should be
        /// updated. A field specified in the mask is overwritten. If a mask isn't
        /// provided then all the fields in the VM Cluster are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> UpdateExadbVmClusterAsync(ExadbVmCluster exadbVmCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExadbVmClusterAsync(exadbVmCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> RemoveVirtualMachineExadbVmCluster(RemoveVirtualMachineExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(RemoveVirtualMachineExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(RemoveVirtualMachineExadbVmClusterRequest request, st::CancellationToken cancellationToken) =>
            RemoveVirtualMachineExadbVmClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveVirtualMachineExadbVmCluster</c>.</summary>
        public virtual lro::OperationsClient RemoveVirtualMachineExadbVmClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveVirtualMachineExadbVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> PollOnceRemoveVirtualMachineExadbVmCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveVirtualMachineExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveVirtualMachineExadbVmCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> PollOnceRemoveVirtualMachineExadbVmClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExadbVmCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveVirtualMachineExadbVmClusterOperationsClient, callSettings);

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> RemoveVirtualMachineExadbVmCluster(string name, scg::IEnumerable<string> hostnames, gaxgrpc::CallSettings callSettings = null) =>
            RemoveVirtualMachineExadbVmCluster(new RemoveVirtualMachineExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Hostnames =
                {
                    gax::GaxPreconditions.CheckNotNull(hostnames, nameof(hostnames)),
                },
            }, callSettings);

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(string name, scg::IEnumerable<string> hostnames, gaxgrpc::CallSettings callSettings = null) =>
            RemoveVirtualMachineExadbVmClusterAsync(new RemoveVirtualMachineExadbVmClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Hostnames =
                {
                    gax::GaxPreconditions.CheckNotNull(hostnames, nameof(hostnames)),
                },
            }, callSettings);

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(string name, scg::IEnumerable<string> hostnames, st::CancellationToken cancellationToken) =>
            RemoveVirtualMachineExadbVmClusterAsync(name, hostnames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExadbVmCluster, OperationMetadata> RemoveVirtualMachineExadbVmCluster(ExadbVmClusterName name, scg::IEnumerable<string> hostnames, gaxgrpc::CallSettings callSettings = null) =>
            RemoveVirtualMachineExadbVmCluster(new RemoveVirtualMachineExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Hostnames =
                {
                    gax::GaxPreconditions.CheckNotNull(hostnames, nameof(hostnames)),
                },
            }, callSettings);

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(ExadbVmClusterName name, scg::IEnumerable<string> hostnames, gaxgrpc::CallSettings callSettings = null) =>
            RemoveVirtualMachineExadbVmClusterAsync(new RemoveVirtualMachineExadbVmClusterRequest
            {
                ExadbVmClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Hostnames =
                {
                    gax::GaxPreconditions.CheckNotNull(hostnames, nameof(hostnames)),
                },
            }, callSettings);

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExadbVmCluster in the following format:
        /// projects/{project}/locations/{location}/exadbVmClusters/{exadb_vm_cluster}.
        /// </param>
        /// <param name="hostnames">
        /// Required. The list of host names of db nodes to be removed from the
        /// ExadbVmCluster.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(ExadbVmClusterName name, scg::IEnumerable<string> hostnames, st::CancellationToken cancellationToken) =>
            RemoveVirtualMachineExadbVmClusterAsync(name, hostnames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaults(ListExascaleDbStorageVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaultsAsync(ListExascaleDbStorageVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExascaleDbStorageVault in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExascaleDbStorageVaults(request, callSettings);
        }

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExascaleDbStorageVault in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExascaleDbStorageVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExascaleDbStorageVault in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaults(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExascaleDbStorageVaults(request, callSettings);
        }

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for ExascaleDbStorageVault in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaultsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExascaleDbStorageVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExascaleDbStorageVault GetExascaleDbStorageVault(GetExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest request, st::CancellationToken cancellationToken) =>
            GetExascaleDbStorageVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExascaleDbStorageVault GetExascaleDbStorageVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExascaleDbStorageVault(new GetExascaleDbStorageVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExascaleDbStorageVaultAsync(new GetExascaleDbStorageVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(string name, st::CancellationToken cancellationToken) =>
            GetExascaleDbStorageVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExascaleDbStorageVault GetExascaleDbStorageVault(ExascaleDbStorageVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExascaleDbStorageVault(new GetExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExascaleDbStorageVaultAsync(new GetExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName name, st::CancellationToken cancellationToken) =>
            GetExascaleDbStorageVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExascaleDbStorageVault, OperationMetadata> CreateExascaleDbStorageVault(CreateExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest request, st::CancellationToken cancellationToken) =>
            CreateExascaleDbStorageVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateExascaleDbStorageVault</c>.</summary>
        public virtual lro::OperationsClient CreateExascaleDbStorageVaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateExascaleDbStorageVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExascaleDbStorageVault, OperationMetadata> PollOnceCreateExascaleDbStorageVault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExascaleDbStorageVault, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExascaleDbStorageVaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateExascaleDbStorageVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> PollOnceCreateExascaleDbStorageVaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExascaleDbStorageVault, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExascaleDbStorageVaultOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExascaleDbStorageVault, OperationMetadata> CreateExascaleDbStorageVault(string parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExascaleDbStorageVault(new CreateExascaleDbStorageVaultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExascaleDbStorageVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)),
                ExascaleDbStorageVault = gax::GaxPreconditions.CheckNotNull(exascaleDbStorageVault, nameof(exascaleDbStorageVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(string parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExascaleDbStorageVaultAsync(new CreateExascaleDbStorageVaultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExascaleDbStorageVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)),
                ExascaleDbStorageVault = gax::GaxPreconditions.CheckNotNull(exascaleDbStorageVault, nameof(exascaleDbStorageVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(string parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, st::CancellationToken cancellationToken) =>
            CreateExascaleDbStorageVaultAsync(parent, exascaleDbStorageVault, exascaleDbStorageVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExascaleDbStorageVault, OperationMetadata> CreateExascaleDbStorageVault(gagr::LocationName parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExascaleDbStorageVault(new CreateExascaleDbStorageVaultRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExascaleDbStorageVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)),
                ExascaleDbStorageVault = gax::GaxPreconditions.CheckNotNull(exascaleDbStorageVault, nameof(exascaleDbStorageVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(gagr::LocationName parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExascaleDbStorageVaultAsync(new CreateExascaleDbStorageVaultRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExascaleDbStorageVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(exascaleDbStorageVaultId, nameof(exascaleDbStorageVaultId)),
                ExascaleDbStorageVault = gax::GaxPreconditions.CheckNotNull(exascaleDbStorageVault, nameof(exascaleDbStorageVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the ExascaleDbStorageVault in the
        /// following format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="exascaleDbStorageVault">
        /// Required. The resource being created.
        /// </param>
        /// <param name="exascaleDbStorageVaultId">
        /// Required. The ID of the ExascaleDbStorageVault to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(gagr::LocationName parent, ExascaleDbStorageVault exascaleDbStorageVault, string exascaleDbStorageVaultId, st::CancellationToken cancellationToken) =>
            CreateExascaleDbStorageVaultAsync(parent, exascaleDbStorageVault, exascaleDbStorageVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExascaleDbStorageVault(DeleteExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest request, st::CancellationToken cancellationToken) =>
            DeleteExascaleDbStorageVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExascaleDbStorageVault</c>.</summary>
        public virtual lro::OperationsClient DeleteExascaleDbStorageVaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExascaleDbStorageVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteExascaleDbStorageVault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExascaleDbStorageVaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExascaleDbStorageVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteExascaleDbStorageVaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExascaleDbStorageVaultOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExascaleDbStorageVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExascaleDbStorageVault(new DeleteExascaleDbStorageVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExascaleDbStorageVaultAsync(new DeleteExascaleDbStorageVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExascaleDbStorageVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExascaleDbStorageVault(ExascaleDbStorageVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExascaleDbStorageVault(new DeleteExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExascaleDbStorageVaultAsync(new DeleteExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ExascaleDbStorageVault in the following format:
        /// projects/{project}/locations/{location}/exascaleDbStorageVaults/{exascale_db_storage_vault}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName name, st::CancellationToken cancellationToken) =>
            DeleteExascaleDbStorageVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizes(ListDbSystemInitialStorageSizesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizesAsync(ListDbSystemInitialStorageSizesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbSystemInitialStorageSize resource with
        /// the format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemInitialStorageSizes(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbSystemInitialStorageSize resource with
        /// the format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemInitialStorageSizesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbSystemInitialStorageSize resource with
        /// the format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemInitialStorageSizes(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbSystemInitialStorageSize resource with
        /// the format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemInitialStorageSizesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the following format:
        /// projects/{project}/locations/{region}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the following format:
        /// projects/{project}/locations/{region}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the following format:
        /// projects/{project}/locations/{region}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name in the following format:
        /// projects/{project}/locations/{region}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabase(new GetDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabaseAsync(new GetDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabase(new GetDatabaseRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabaseAsync(new GetDatabaseRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Database resource in the following format:
        /// projects/{project}/locations/{region}/databases/{database}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(DatabaseName name, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabases(ListPluggableDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabasesAsync(ListPluggableDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PluggableDatabases.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluggableDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PluggableDatabases.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluggableDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PluggableDatabases.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabases(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluggableDatabases(request, callSettings);
        }

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of PluggableDatabases.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabasesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPluggableDatabasesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluggableDatabase GetPluggableDatabase(GetPluggableDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(GetPluggableDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(GetPluggableDatabaseRequest request, st::CancellationToken cancellationToken) =>
            GetPluggableDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluggableDatabase GetPluggableDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluggableDatabase(new GetPluggableDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluggableDatabaseAsync(new GetPluggableDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetPluggableDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PluggableDatabase GetPluggableDatabase(PluggableDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluggableDatabase(new GetPluggableDatabaseRequest
            {
                PluggableDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(PluggableDatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPluggableDatabaseAsync(new GetPluggableDatabaseRequest
            {
                PluggableDatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PluggableDatabase resource in the following
        /// format:
        /// projects/{project}/locations/{region}/pluggableDatabases/{pluggable_database}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(PluggableDatabaseName name, st::CancellationToken cancellationToken) =>
            GetPluggableDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystems(ListDbSystemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystemsAsync(ListDbSystemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DbSystems in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystems(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystems(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DbSystems in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystemsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DbSystems in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystems(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystems(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DbSystems in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystemsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbSystemsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DbSystem GetDbSystem(GetDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(GetDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(GetDbSystemRequest request, st::CancellationToken cancellationToken) =>
            GetDbSystemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DbSystem GetDbSystem(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDbSystem(new GetDbSystemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDbSystemAsync(new GetDbSystemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(string name, st::CancellationToken cancellationToken) =>
            GetDbSystemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DbSystem GetDbSystem(DbSystemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDbSystem(new GetDbSystemRequest
            {
                DbSystemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(DbSystemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDbSystemAsync(new GetDbSystemRequest
            {
                DbSystemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DbSystem> GetDbSystemAsync(DbSystemName name, st::CancellationToken cancellationToken) =>
            GetDbSystemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DbSystem, OperationMetadata> CreateDbSystem(CreateDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(CreateDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(CreateDbSystemRequest request, st::CancellationToken cancellationToken) =>
            CreateDbSystemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDbSystem</c>.</summary>
        public virtual lro::OperationsClient CreateDbSystemOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDbSystem</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DbSystem, OperationMetadata> PollOnceCreateDbSystem(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DbSystem, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDbSystemOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDbSystem</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> PollOnceCreateDbSystemAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DbSystem, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDbSystemOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DbSystem, OperationMetadata> CreateDbSystem(string parent, DbSystem dbSystem, string dbSystemId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDbSystem(new CreateDbSystemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DbSystemId = gax::GaxPreconditions.CheckNotNullOrEmpty(dbSystemId, nameof(dbSystemId)),
                DbSystem = gax::GaxPreconditions.CheckNotNull(dbSystem, nameof(dbSystem)),
            }, callSettings);

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(string parent, DbSystem dbSystem, string dbSystemId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDbSystemAsync(new CreateDbSystemRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DbSystemId = gax::GaxPreconditions.CheckNotNullOrEmpty(dbSystemId, nameof(dbSystemId)),
                DbSystem = gax::GaxPreconditions.CheckNotNull(dbSystem, nameof(dbSystem)),
            }, callSettings);

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(string parent, DbSystem dbSystem, string dbSystemId, st::CancellationToken cancellationToken) =>
            CreateDbSystemAsync(parent, dbSystem, dbSystemId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DbSystem, OperationMetadata> CreateDbSystem(gagr::LocationName parent, DbSystem dbSystem, string dbSystemId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDbSystem(new CreateDbSystemRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DbSystemId = gax::GaxPreconditions.CheckNotNullOrEmpty(dbSystemId, nameof(dbSystemId)),
                DbSystem = gax::GaxPreconditions.CheckNotNull(dbSystem, nameof(dbSystem)),
            }, callSettings);

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(gagr::LocationName parent, DbSystem dbSystem, string dbSystemId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDbSystemAsync(new CreateDbSystemRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DbSystemId = gax::GaxPreconditions.CheckNotNullOrEmpty(dbSystemId, nameof(dbSystemId)),
                DbSystem = gax::GaxPreconditions.CheckNotNull(dbSystem, nameof(dbSystem)),
            }, callSettings);

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for parent of the DbSystem in the following format:
        /// projects/{project}/locations/{location}.
        /// </param>
        /// <param name="dbSystem">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dbSystemId">
        /// Required. The ID of the DbSystem to create. This value is
        /// restricted to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of
        /// 63 characters in length. The value must start with a letter and end with a
        /// letter or a number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(gagr::LocationName parent, DbSystem dbSystem, string dbSystemId, st::CancellationToken cancellationToken) =>
            CreateDbSystemAsync(parent, dbSystem, dbSystemId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDbSystem(DeleteDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(DeleteDbSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(DeleteDbSystemRequest request, st::CancellationToken cancellationToken) =>
            DeleteDbSystemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDbSystem</c>.</summary>
        public virtual lro::OperationsClient DeleteDbSystemOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDbSystem</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDbSystem(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDbSystemOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDbSystem</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDbSystemAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDbSystemOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDbSystem(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDbSystem(new DeleteDbSystemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDbSystemAsync(new DeleteDbSystemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDbSystemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDbSystem(DbSystemName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDbSystem(new DeleteDbSystemRequest
            {
                DbSystemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(DbSystemName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDbSystemAsync(new DeleteDbSystemRequest
            {
                DbSystemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DbSystem in the following format:
        /// projects/{project}/locations/{location}/dbSystems/{db_system}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(DbSystemName name, st::CancellationToken cancellationToken) =>
            DeleteDbSystemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersions(ListDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersionsAsync(ListDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbVersion resource with the
        /// format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbVersions(request, callSettings);
        }

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbVersion resource with the
        /// format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbVersion resource with the
        /// format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbVersions(request, callSettings);
        }

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for the DbVersion resource with the
        /// format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDbVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSets(ListDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSetsAsync(ListDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DatabaseCharacterSets in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabaseCharacterSets(request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DatabaseCharacterSets in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabaseCharacterSetsAsync(request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DatabaseCharacterSets in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabaseCharacterSets(request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for DatabaseCharacterSets in the following
        /// format: projects/{project}/locations/{location}.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatabaseCharacterSetsAsync(request, callSettings);
        }
    }

    /// <summary>OracleDatabase client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class OracleDatabaseClientImpl : OracleDatabaseClient
    {
        private readonly gaxgrpc::ApiCall<ListCloudExadataInfrastructuresRequest, ListCloudExadataInfrastructuresResponse> _callListCloudExadataInfrastructures;

        private readonly gaxgrpc::ApiCall<GetCloudExadataInfrastructureRequest, CloudExadataInfrastructure> _callGetCloudExadataInfrastructure;

        private readonly gaxgrpc::ApiCall<CreateCloudExadataInfrastructureRequest, lro::Operation> _callCreateCloudExadataInfrastructure;

        private readonly gaxgrpc::ApiCall<DeleteCloudExadataInfrastructureRequest, lro::Operation> _callDeleteCloudExadataInfrastructure;

        private readonly gaxgrpc::ApiCall<ListCloudVmClustersRequest, ListCloudVmClustersResponse> _callListCloudVmClusters;

        private readonly gaxgrpc::ApiCall<GetCloudVmClusterRequest, CloudVmCluster> _callGetCloudVmCluster;

        private readonly gaxgrpc::ApiCall<CreateCloudVmClusterRequest, lro::Operation> _callCreateCloudVmCluster;

        private readonly gaxgrpc::ApiCall<DeleteCloudVmClusterRequest, lro::Operation> _callDeleteCloudVmCluster;

        private readonly gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> _callListEntitlements;

        private readonly gaxgrpc::ApiCall<ListDbServersRequest, ListDbServersResponse> _callListDbServers;

        private readonly gaxgrpc::ApiCall<ListDbNodesRequest, ListDbNodesResponse> _callListDbNodes;

        private readonly gaxgrpc::ApiCall<ListGiVersionsRequest, ListGiVersionsResponse> _callListGiVersions;

        private readonly gaxgrpc::ApiCall<ListMinorVersionsRequest, ListMinorVersionsResponse> _callListMinorVersions;

        private readonly gaxgrpc::ApiCall<ListDbSystemShapesRequest, ListDbSystemShapesResponse> _callListDbSystemShapes;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse> _callListAutonomousDatabases;

        private readonly gaxgrpc::ApiCall<GetAutonomousDatabaseRequest, AutonomousDatabase> _callGetAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<CreateAutonomousDatabaseRequest, lro::Operation> _callCreateAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<UpdateAutonomousDatabaseRequest, lro::Operation> _callUpdateAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<DeleteAutonomousDatabaseRequest, lro::Operation> _callDeleteAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<RestoreAutonomousDatabaseRequest, lro::Operation> _callRestoreAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<GenerateAutonomousDatabaseWalletRequest, GenerateAutonomousDatabaseWalletResponse> _callGenerateAutonomousDatabaseWallet;

        private readonly gaxgrpc::ApiCall<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse> _callListAutonomousDbVersions;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse> _callListAutonomousDatabaseCharacterSets;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse> _callListAutonomousDatabaseBackups;

        private readonly gaxgrpc::ApiCall<StopAutonomousDatabaseRequest, lro::Operation> _callStopAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<StartAutonomousDatabaseRequest, lro::Operation> _callStartAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<RestartAutonomousDatabaseRequest, lro::Operation> _callRestartAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<SwitchoverAutonomousDatabaseRequest, lro::Operation> _callSwitchoverAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<FailoverAutonomousDatabaseRequest, lro::Operation> _callFailoverAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<ListOdbNetworksRequest, ListOdbNetworksResponse> _callListOdbNetworks;

        private readonly gaxgrpc::ApiCall<GetOdbNetworkRequest, OdbNetwork> _callGetOdbNetwork;

        private readonly gaxgrpc::ApiCall<CreateOdbNetworkRequest, lro::Operation> _callCreateOdbNetwork;

        private readonly gaxgrpc::ApiCall<DeleteOdbNetworkRequest, lro::Operation> _callDeleteOdbNetwork;

        private readonly gaxgrpc::ApiCall<ListOdbSubnetsRequest, ListOdbSubnetsResponse> _callListOdbSubnets;

        private readonly gaxgrpc::ApiCall<GetOdbSubnetRequest, OdbSubnet> _callGetOdbSubnet;

        private readonly gaxgrpc::ApiCall<CreateOdbSubnetRequest, lro::Operation> _callCreateOdbSubnet;

        private readonly gaxgrpc::ApiCall<DeleteOdbSubnetRequest, lro::Operation> _callDeleteOdbSubnet;

        private readonly gaxgrpc::ApiCall<ListExadbVmClustersRequest, ListExadbVmClustersResponse> _callListExadbVmClusters;

        private readonly gaxgrpc::ApiCall<GetExadbVmClusterRequest, ExadbVmCluster> _callGetExadbVmCluster;

        private readonly gaxgrpc::ApiCall<CreateExadbVmClusterRequest, lro::Operation> _callCreateExadbVmCluster;

        private readonly gaxgrpc::ApiCall<DeleteExadbVmClusterRequest, lro::Operation> _callDeleteExadbVmCluster;

        private readonly gaxgrpc::ApiCall<UpdateExadbVmClusterRequest, lro::Operation> _callUpdateExadbVmCluster;

        private readonly gaxgrpc::ApiCall<RemoveVirtualMachineExadbVmClusterRequest, lro::Operation> _callRemoveVirtualMachineExadbVmCluster;

        private readonly gaxgrpc::ApiCall<ListExascaleDbStorageVaultsRequest, ListExascaleDbStorageVaultsResponse> _callListExascaleDbStorageVaults;

        private readonly gaxgrpc::ApiCall<GetExascaleDbStorageVaultRequest, ExascaleDbStorageVault> _callGetExascaleDbStorageVault;

        private readonly gaxgrpc::ApiCall<CreateExascaleDbStorageVaultRequest, lro::Operation> _callCreateExascaleDbStorageVault;

        private readonly gaxgrpc::ApiCall<DeleteExascaleDbStorageVaultRequest, lro::Operation> _callDeleteExascaleDbStorageVault;

        private readonly gaxgrpc::ApiCall<ListDbSystemInitialStorageSizesRequest, ListDbSystemInitialStorageSizesResponse> _callListDbSystemInitialStorageSizes;

        private readonly gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> _callListDatabases;

        private readonly gaxgrpc::ApiCall<GetDatabaseRequest, Database> _callGetDatabase;

        private readonly gaxgrpc::ApiCall<ListPluggableDatabasesRequest, ListPluggableDatabasesResponse> _callListPluggableDatabases;

        private readonly gaxgrpc::ApiCall<GetPluggableDatabaseRequest, PluggableDatabase> _callGetPluggableDatabase;

        private readonly gaxgrpc::ApiCall<ListDbSystemsRequest, ListDbSystemsResponse> _callListDbSystems;

        private readonly gaxgrpc::ApiCall<GetDbSystemRequest, DbSystem> _callGetDbSystem;

        private readonly gaxgrpc::ApiCall<CreateDbSystemRequest, lro::Operation> _callCreateDbSystem;

        private readonly gaxgrpc::ApiCall<DeleteDbSystemRequest, lro::Operation> _callDeleteDbSystem;

        private readonly gaxgrpc::ApiCall<ListDbVersionsRequest, ListDbVersionsResponse> _callListDbVersions;

        private readonly gaxgrpc::ApiCall<ListDatabaseCharacterSetsRequest, ListDatabaseCharacterSetsResponse> _callListDatabaseCharacterSets;

        /// <summary>
        /// Constructs a client wrapper for the OracleDatabase service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OracleDatabaseSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OracleDatabaseClientImpl(OracleDatabase.OracleDatabaseClient grpcClient, OracleDatabaseSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OracleDatabaseSettings effectiveSettings = settings ?? OracleDatabaseSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateCloudExadataInfrastructureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCloudExadataInfrastructureOperationsSettings, logger);
            DeleteCloudExadataInfrastructureOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCloudExadataInfrastructureOperationsSettings, logger);
            CreateCloudVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCloudVmClusterOperationsSettings, logger);
            DeleteCloudVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCloudVmClusterOperationsSettings, logger);
            CreateAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAutonomousDatabaseOperationsSettings, logger);
            UpdateAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAutonomousDatabaseOperationsSettings, logger);
            DeleteAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAutonomousDatabaseOperationsSettings, logger);
            RestoreAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAutonomousDatabaseOperationsSettings, logger);
            StopAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopAutonomousDatabaseOperationsSettings, logger);
            StartAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartAutonomousDatabaseOperationsSettings, logger);
            RestartAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestartAutonomousDatabaseOperationsSettings, logger);
            SwitchoverAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SwitchoverAutonomousDatabaseOperationsSettings, logger);
            FailoverAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FailoverAutonomousDatabaseOperationsSettings, logger);
            CreateOdbNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOdbNetworkOperationsSettings, logger);
            DeleteOdbNetworkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOdbNetworkOperationsSettings, logger);
            CreateOdbSubnetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOdbSubnetOperationsSettings, logger);
            DeleteOdbSubnetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOdbSubnetOperationsSettings, logger);
            CreateExadbVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateExadbVmClusterOperationsSettings, logger);
            DeleteExadbVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExadbVmClusterOperationsSettings, logger);
            UpdateExadbVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateExadbVmClusterOperationsSettings, logger);
            RemoveVirtualMachineExadbVmClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveVirtualMachineExadbVmClusterOperationsSettings, logger);
            CreateExascaleDbStorageVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateExascaleDbStorageVaultOperationsSettings, logger);
            DeleteExascaleDbStorageVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExascaleDbStorageVaultOperationsSettings, logger);
            CreateDbSystemOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDbSystemOperationsSettings, logger);
            DeleteDbSystemOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDbSystemOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListCloudExadataInfrastructures = clientHelper.BuildApiCall<ListCloudExadataInfrastructuresRequest, ListCloudExadataInfrastructuresResponse>("ListCloudExadataInfrastructures", grpcClient.ListCloudExadataInfrastructuresAsync, grpcClient.ListCloudExadataInfrastructures, effectiveSettings.ListCloudExadataInfrastructuresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloudExadataInfrastructures);
            Modify_ListCloudExadataInfrastructuresApiCall(ref _callListCloudExadataInfrastructures);
            _callGetCloudExadataInfrastructure = clientHelper.BuildApiCall<GetCloudExadataInfrastructureRequest, CloudExadataInfrastructure>("GetCloudExadataInfrastructure", grpcClient.GetCloudExadataInfrastructureAsync, grpcClient.GetCloudExadataInfrastructure, effectiveSettings.GetCloudExadataInfrastructureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloudExadataInfrastructure);
            Modify_GetCloudExadataInfrastructureApiCall(ref _callGetCloudExadataInfrastructure);
            _callCreateCloudExadataInfrastructure = clientHelper.BuildApiCall<CreateCloudExadataInfrastructureRequest, lro::Operation>("CreateCloudExadataInfrastructure", grpcClient.CreateCloudExadataInfrastructureAsync, grpcClient.CreateCloudExadataInfrastructure, effectiveSettings.CreateCloudExadataInfrastructureSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCloudExadataInfrastructure);
            Modify_CreateCloudExadataInfrastructureApiCall(ref _callCreateCloudExadataInfrastructure);
            _callDeleteCloudExadataInfrastructure = clientHelper.BuildApiCall<DeleteCloudExadataInfrastructureRequest, lro::Operation>("DeleteCloudExadataInfrastructure", grpcClient.DeleteCloudExadataInfrastructureAsync, grpcClient.DeleteCloudExadataInfrastructure, effectiveSettings.DeleteCloudExadataInfrastructureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCloudExadataInfrastructure);
            Modify_DeleteCloudExadataInfrastructureApiCall(ref _callDeleteCloudExadataInfrastructure);
            _callListCloudVmClusters = clientHelper.BuildApiCall<ListCloudVmClustersRequest, ListCloudVmClustersResponse>("ListCloudVmClusters", grpcClient.ListCloudVmClustersAsync, grpcClient.ListCloudVmClusters, effectiveSettings.ListCloudVmClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloudVmClusters);
            Modify_ListCloudVmClustersApiCall(ref _callListCloudVmClusters);
            _callGetCloudVmCluster = clientHelper.BuildApiCall<GetCloudVmClusterRequest, CloudVmCluster>("GetCloudVmCluster", grpcClient.GetCloudVmClusterAsync, grpcClient.GetCloudVmCluster, effectiveSettings.GetCloudVmClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloudVmCluster);
            Modify_GetCloudVmClusterApiCall(ref _callGetCloudVmCluster);
            _callCreateCloudVmCluster = clientHelper.BuildApiCall<CreateCloudVmClusterRequest, lro::Operation>("CreateCloudVmCluster", grpcClient.CreateCloudVmClusterAsync, grpcClient.CreateCloudVmCluster, effectiveSettings.CreateCloudVmClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCloudVmCluster);
            Modify_CreateCloudVmClusterApiCall(ref _callCreateCloudVmCluster);
            _callDeleteCloudVmCluster = clientHelper.BuildApiCall<DeleteCloudVmClusterRequest, lro::Operation>("DeleteCloudVmCluster", grpcClient.DeleteCloudVmClusterAsync, grpcClient.DeleteCloudVmCluster, effectiveSettings.DeleteCloudVmClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCloudVmCluster);
            Modify_DeleteCloudVmClusterApiCall(ref _callDeleteCloudVmCluster);
            _callListEntitlements = clientHelper.BuildApiCall<ListEntitlementsRequest, ListEntitlementsResponse>("ListEntitlements", grpcClient.ListEntitlementsAsync, grpcClient.ListEntitlements, effectiveSettings.ListEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitlements);
            Modify_ListEntitlementsApiCall(ref _callListEntitlements);
            _callListDbServers = clientHelper.BuildApiCall<ListDbServersRequest, ListDbServersResponse>("ListDbServers", grpcClient.ListDbServersAsync, grpcClient.ListDbServers, effectiveSettings.ListDbServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbServers);
            Modify_ListDbServersApiCall(ref _callListDbServers);
            _callListDbNodes = clientHelper.BuildApiCall<ListDbNodesRequest, ListDbNodesResponse>("ListDbNodes", grpcClient.ListDbNodesAsync, grpcClient.ListDbNodes, effectiveSettings.ListDbNodesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbNodes);
            Modify_ListDbNodesApiCall(ref _callListDbNodes);
            _callListGiVersions = clientHelper.BuildApiCall<ListGiVersionsRequest, ListGiVersionsResponse>("ListGiVersions", grpcClient.ListGiVersionsAsync, grpcClient.ListGiVersions, effectiveSettings.ListGiVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGiVersions);
            Modify_ListGiVersionsApiCall(ref _callListGiVersions);
            _callListMinorVersions = clientHelper.BuildApiCall<ListMinorVersionsRequest, ListMinorVersionsResponse>("ListMinorVersions", grpcClient.ListMinorVersionsAsync, grpcClient.ListMinorVersions, effectiveSettings.ListMinorVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMinorVersions);
            Modify_ListMinorVersionsApiCall(ref _callListMinorVersions);
            _callListDbSystemShapes = clientHelper.BuildApiCall<ListDbSystemShapesRequest, ListDbSystemShapesResponse>("ListDbSystemShapes", grpcClient.ListDbSystemShapesAsync, grpcClient.ListDbSystemShapes, effectiveSettings.ListDbSystemShapesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbSystemShapes);
            Modify_ListDbSystemShapesApiCall(ref _callListDbSystemShapes);
            _callListAutonomousDatabases = clientHelper.BuildApiCall<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse>("ListAutonomousDatabases", grpcClient.ListAutonomousDatabasesAsync, grpcClient.ListAutonomousDatabases, effectiveSettings.ListAutonomousDatabasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutonomousDatabases);
            Modify_ListAutonomousDatabasesApiCall(ref _callListAutonomousDatabases);
            _callGetAutonomousDatabase = clientHelper.BuildApiCall<GetAutonomousDatabaseRequest, AutonomousDatabase>("GetAutonomousDatabase", grpcClient.GetAutonomousDatabaseAsync, grpcClient.GetAutonomousDatabase, effectiveSettings.GetAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutonomousDatabase);
            Modify_GetAutonomousDatabaseApiCall(ref _callGetAutonomousDatabase);
            _callCreateAutonomousDatabase = clientHelper.BuildApiCall<CreateAutonomousDatabaseRequest, lro::Operation>("CreateAutonomousDatabase", grpcClient.CreateAutonomousDatabaseAsync, grpcClient.CreateAutonomousDatabase, effectiveSettings.CreateAutonomousDatabaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAutonomousDatabase);
            Modify_CreateAutonomousDatabaseApiCall(ref _callCreateAutonomousDatabase);
            _callUpdateAutonomousDatabase = clientHelper.BuildApiCall<UpdateAutonomousDatabaseRequest, lro::Operation>("UpdateAutonomousDatabase", grpcClient.UpdateAutonomousDatabaseAsync, grpcClient.UpdateAutonomousDatabase, effectiveSettings.UpdateAutonomousDatabaseSettings).WithGoogleRequestParam("autonomous_database.name", request => request.AutonomousDatabase?.Name);
            Modify_ApiCall(ref _callUpdateAutonomousDatabase);
            Modify_UpdateAutonomousDatabaseApiCall(ref _callUpdateAutonomousDatabase);
            _callDeleteAutonomousDatabase = clientHelper.BuildApiCall<DeleteAutonomousDatabaseRequest, lro::Operation>("DeleteAutonomousDatabase", grpcClient.DeleteAutonomousDatabaseAsync, grpcClient.DeleteAutonomousDatabase, effectiveSettings.DeleteAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAutonomousDatabase);
            Modify_DeleteAutonomousDatabaseApiCall(ref _callDeleteAutonomousDatabase);
            _callRestoreAutonomousDatabase = clientHelper.BuildApiCall<RestoreAutonomousDatabaseRequest, lro::Operation>("RestoreAutonomousDatabase", grpcClient.RestoreAutonomousDatabaseAsync, grpcClient.RestoreAutonomousDatabase, effectiveSettings.RestoreAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreAutonomousDatabase);
            Modify_RestoreAutonomousDatabaseApiCall(ref _callRestoreAutonomousDatabase);
            _callGenerateAutonomousDatabaseWallet = clientHelper.BuildApiCall<GenerateAutonomousDatabaseWalletRequest, GenerateAutonomousDatabaseWalletResponse>("GenerateAutonomousDatabaseWallet", grpcClient.GenerateAutonomousDatabaseWalletAsync, grpcClient.GenerateAutonomousDatabaseWallet, effectiveSettings.GenerateAutonomousDatabaseWalletSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateAutonomousDatabaseWallet);
            Modify_GenerateAutonomousDatabaseWalletApiCall(ref _callGenerateAutonomousDatabaseWallet);
            _callListAutonomousDbVersions = clientHelper.BuildApiCall<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse>("ListAutonomousDbVersions", grpcClient.ListAutonomousDbVersionsAsync, grpcClient.ListAutonomousDbVersions, effectiveSettings.ListAutonomousDbVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutonomousDbVersions);
            Modify_ListAutonomousDbVersionsApiCall(ref _callListAutonomousDbVersions);
            _callListAutonomousDatabaseCharacterSets = clientHelper.BuildApiCall<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse>("ListAutonomousDatabaseCharacterSets", grpcClient.ListAutonomousDatabaseCharacterSetsAsync, grpcClient.ListAutonomousDatabaseCharacterSets, effectiveSettings.ListAutonomousDatabaseCharacterSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutonomousDatabaseCharacterSets);
            Modify_ListAutonomousDatabaseCharacterSetsApiCall(ref _callListAutonomousDatabaseCharacterSets);
            _callListAutonomousDatabaseBackups = clientHelper.BuildApiCall<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse>("ListAutonomousDatabaseBackups", grpcClient.ListAutonomousDatabaseBackupsAsync, grpcClient.ListAutonomousDatabaseBackups, effectiveSettings.ListAutonomousDatabaseBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutonomousDatabaseBackups);
            Modify_ListAutonomousDatabaseBackupsApiCall(ref _callListAutonomousDatabaseBackups);
            _callStopAutonomousDatabase = clientHelper.BuildApiCall<StopAutonomousDatabaseRequest, lro::Operation>("StopAutonomousDatabase", grpcClient.StopAutonomousDatabaseAsync, grpcClient.StopAutonomousDatabase, effectiveSettings.StopAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopAutonomousDatabase);
            Modify_StopAutonomousDatabaseApiCall(ref _callStopAutonomousDatabase);
            _callStartAutonomousDatabase = clientHelper.BuildApiCall<StartAutonomousDatabaseRequest, lro::Operation>("StartAutonomousDatabase", grpcClient.StartAutonomousDatabaseAsync, grpcClient.StartAutonomousDatabase, effectiveSettings.StartAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartAutonomousDatabase);
            Modify_StartAutonomousDatabaseApiCall(ref _callStartAutonomousDatabase);
            _callRestartAutonomousDatabase = clientHelper.BuildApiCall<RestartAutonomousDatabaseRequest, lro::Operation>("RestartAutonomousDatabase", grpcClient.RestartAutonomousDatabaseAsync, grpcClient.RestartAutonomousDatabase, effectiveSettings.RestartAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestartAutonomousDatabase);
            Modify_RestartAutonomousDatabaseApiCall(ref _callRestartAutonomousDatabase);
            _callSwitchoverAutonomousDatabase = clientHelper.BuildApiCall<SwitchoverAutonomousDatabaseRequest, lro::Operation>("SwitchoverAutonomousDatabase", grpcClient.SwitchoverAutonomousDatabaseAsync, grpcClient.SwitchoverAutonomousDatabase, effectiveSettings.SwitchoverAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSwitchoverAutonomousDatabase);
            Modify_SwitchoverAutonomousDatabaseApiCall(ref _callSwitchoverAutonomousDatabase);
            _callFailoverAutonomousDatabase = clientHelper.BuildApiCall<FailoverAutonomousDatabaseRequest, lro::Operation>("FailoverAutonomousDatabase", grpcClient.FailoverAutonomousDatabaseAsync, grpcClient.FailoverAutonomousDatabase, effectiveSettings.FailoverAutonomousDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFailoverAutonomousDatabase);
            Modify_FailoverAutonomousDatabaseApiCall(ref _callFailoverAutonomousDatabase);
            _callListOdbNetworks = clientHelper.BuildApiCall<ListOdbNetworksRequest, ListOdbNetworksResponse>("ListOdbNetworks", grpcClient.ListOdbNetworksAsync, grpcClient.ListOdbNetworks, effectiveSettings.ListOdbNetworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOdbNetworks);
            Modify_ListOdbNetworksApiCall(ref _callListOdbNetworks);
            _callGetOdbNetwork = clientHelper.BuildApiCall<GetOdbNetworkRequest, OdbNetwork>("GetOdbNetwork", grpcClient.GetOdbNetworkAsync, grpcClient.GetOdbNetwork, effectiveSettings.GetOdbNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOdbNetwork);
            Modify_GetOdbNetworkApiCall(ref _callGetOdbNetwork);
            _callCreateOdbNetwork = clientHelper.BuildApiCall<CreateOdbNetworkRequest, lro::Operation>("CreateOdbNetwork", grpcClient.CreateOdbNetworkAsync, grpcClient.CreateOdbNetwork, effectiveSettings.CreateOdbNetworkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOdbNetwork);
            Modify_CreateOdbNetworkApiCall(ref _callCreateOdbNetwork);
            _callDeleteOdbNetwork = clientHelper.BuildApiCall<DeleteOdbNetworkRequest, lro::Operation>("DeleteOdbNetwork", grpcClient.DeleteOdbNetworkAsync, grpcClient.DeleteOdbNetwork, effectiveSettings.DeleteOdbNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOdbNetwork);
            Modify_DeleteOdbNetworkApiCall(ref _callDeleteOdbNetwork);
            _callListOdbSubnets = clientHelper.BuildApiCall<ListOdbSubnetsRequest, ListOdbSubnetsResponse>("ListOdbSubnets", grpcClient.ListOdbSubnetsAsync, grpcClient.ListOdbSubnets, effectiveSettings.ListOdbSubnetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOdbSubnets);
            Modify_ListOdbSubnetsApiCall(ref _callListOdbSubnets);
            _callGetOdbSubnet = clientHelper.BuildApiCall<GetOdbSubnetRequest, OdbSubnet>("GetOdbSubnet", grpcClient.GetOdbSubnetAsync, grpcClient.GetOdbSubnet, effectiveSettings.GetOdbSubnetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOdbSubnet);
            Modify_GetOdbSubnetApiCall(ref _callGetOdbSubnet);
            _callCreateOdbSubnet = clientHelper.BuildApiCall<CreateOdbSubnetRequest, lro::Operation>("CreateOdbSubnet", grpcClient.CreateOdbSubnetAsync, grpcClient.CreateOdbSubnet, effectiveSettings.CreateOdbSubnetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOdbSubnet);
            Modify_CreateOdbSubnetApiCall(ref _callCreateOdbSubnet);
            _callDeleteOdbSubnet = clientHelper.BuildApiCall<DeleteOdbSubnetRequest, lro::Operation>("DeleteOdbSubnet", grpcClient.DeleteOdbSubnetAsync, grpcClient.DeleteOdbSubnet, effectiveSettings.DeleteOdbSubnetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOdbSubnet);
            Modify_DeleteOdbSubnetApiCall(ref _callDeleteOdbSubnet);
            _callListExadbVmClusters = clientHelper.BuildApiCall<ListExadbVmClustersRequest, ListExadbVmClustersResponse>("ListExadbVmClusters", grpcClient.ListExadbVmClustersAsync, grpcClient.ListExadbVmClusters, effectiveSettings.ListExadbVmClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExadbVmClusters);
            Modify_ListExadbVmClustersApiCall(ref _callListExadbVmClusters);
            _callGetExadbVmCluster = clientHelper.BuildApiCall<GetExadbVmClusterRequest, ExadbVmCluster>("GetExadbVmCluster", grpcClient.GetExadbVmClusterAsync, grpcClient.GetExadbVmCluster, effectiveSettings.GetExadbVmClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExadbVmCluster);
            Modify_GetExadbVmClusterApiCall(ref _callGetExadbVmCluster);
            _callCreateExadbVmCluster = clientHelper.BuildApiCall<CreateExadbVmClusterRequest, lro::Operation>("CreateExadbVmCluster", grpcClient.CreateExadbVmClusterAsync, grpcClient.CreateExadbVmCluster, effectiveSettings.CreateExadbVmClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExadbVmCluster);
            Modify_CreateExadbVmClusterApiCall(ref _callCreateExadbVmCluster);
            _callDeleteExadbVmCluster = clientHelper.BuildApiCall<DeleteExadbVmClusterRequest, lro::Operation>("DeleteExadbVmCluster", grpcClient.DeleteExadbVmClusterAsync, grpcClient.DeleteExadbVmCluster, effectiveSettings.DeleteExadbVmClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExadbVmCluster);
            Modify_DeleteExadbVmClusterApiCall(ref _callDeleteExadbVmCluster);
            _callUpdateExadbVmCluster = clientHelper.BuildApiCall<UpdateExadbVmClusterRequest, lro::Operation>("UpdateExadbVmCluster", grpcClient.UpdateExadbVmClusterAsync, grpcClient.UpdateExadbVmCluster, effectiveSettings.UpdateExadbVmClusterSettings).WithGoogleRequestParam("exadb_vm_cluster.name", request => request.ExadbVmCluster?.Name);
            Modify_ApiCall(ref _callUpdateExadbVmCluster);
            Modify_UpdateExadbVmClusterApiCall(ref _callUpdateExadbVmCluster);
            _callRemoveVirtualMachineExadbVmCluster = clientHelper.BuildApiCall<RemoveVirtualMachineExadbVmClusterRequest, lro::Operation>("RemoveVirtualMachineExadbVmCluster", grpcClient.RemoveVirtualMachineExadbVmClusterAsync, grpcClient.RemoveVirtualMachineExadbVmCluster, effectiveSettings.RemoveVirtualMachineExadbVmClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveVirtualMachineExadbVmCluster);
            Modify_RemoveVirtualMachineExadbVmClusterApiCall(ref _callRemoveVirtualMachineExadbVmCluster);
            _callListExascaleDbStorageVaults = clientHelper.BuildApiCall<ListExascaleDbStorageVaultsRequest, ListExascaleDbStorageVaultsResponse>("ListExascaleDbStorageVaults", grpcClient.ListExascaleDbStorageVaultsAsync, grpcClient.ListExascaleDbStorageVaults, effectiveSettings.ListExascaleDbStorageVaultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExascaleDbStorageVaults);
            Modify_ListExascaleDbStorageVaultsApiCall(ref _callListExascaleDbStorageVaults);
            _callGetExascaleDbStorageVault = clientHelper.BuildApiCall<GetExascaleDbStorageVaultRequest, ExascaleDbStorageVault>("GetExascaleDbStorageVault", grpcClient.GetExascaleDbStorageVaultAsync, grpcClient.GetExascaleDbStorageVault, effectiveSettings.GetExascaleDbStorageVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExascaleDbStorageVault);
            Modify_GetExascaleDbStorageVaultApiCall(ref _callGetExascaleDbStorageVault);
            _callCreateExascaleDbStorageVault = clientHelper.BuildApiCall<CreateExascaleDbStorageVaultRequest, lro::Operation>("CreateExascaleDbStorageVault", grpcClient.CreateExascaleDbStorageVaultAsync, grpcClient.CreateExascaleDbStorageVault, effectiveSettings.CreateExascaleDbStorageVaultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExascaleDbStorageVault);
            Modify_CreateExascaleDbStorageVaultApiCall(ref _callCreateExascaleDbStorageVault);
            _callDeleteExascaleDbStorageVault = clientHelper.BuildApiCall<DeleteExascaleDbStorageVaultRequest, lro::Operation>("DeleteExascaleDbStorageVault", grpcClient.DeleteExascaleDbStorageVaultAsync, grpcClient.DeleteExascaleDbStorageVault, effectiveSettings.DeleteExascaleDbStorageVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExascaleDbStorageVault);
            Modify_DeleteExascaleDbStorageVaultApiCall(ref _callDeleteExascaleDbStorageVault);
            _callListDbSystemInitialStorageSizes = clientHelper.BuildApiCall<ListDbSystemInitialStorageSizesRequest, ListDbSystemInitialStorageSizesResponse>("ListDbSystemInitialStorageSizes", grpcClient.ListDbSystemInitialStorageSizesAsync, grpcClient.ListDbSystemInitialStorageSizes, effectiveSettings.ListDbSystemInitialStorageSizesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbSystemInitialStorageSizes);
            Modify_ListDbSystemInitialStorageSizesApiCall(ref _callListDbSystemInitialStorageSizes);
            _callListDatabases = clientHelper.BuildApiCall<ListDatabasesRequest, ListDatabasesResponse>("ListDatabases", grpcClient.ListDatabasesAsync, grpcClient.ListDatabases, effectiveSettings.ListDatabasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatabases);
            Modify_ListDatabasesApiCall(ref _callListDatabases);
            _callGetDatabase = clientHelper.BuildApiCall<GetDatabaseRequest, Database>("GetDatabase", grpcClient.GetDatabaseAsync, grpcClient.GetDatabase, effectiveSettings.GetDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDatabase);
            Modify_GetDatabaseApiCall(ref _callGetDatabase);
            _callListPluggableDatabases = clientHelper.BuildApiCall<ListPluggableDatabasesRequest, ListPluggableDatabasesResponse>("ListPluggableDatabases", grpcClient.ListPluggableDatabasesAsync, grpcClient.ListPluggableDatabases, effectiveSettings.ListPluggableDatabasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPluggableDatabases);
            Modify_ListPluggableDatabasesApiCall(ref _callListPluggableDatabases);
            _callGetPluggableDatabase = clientHelper.BuildApiCall<GetPluggableDatabaseRequest, PluggableDatabase>("GetPluggableDatabase", grpcClient.GetPluggableDatabaseAsync, grpcClient.GetPluggableDatabase, effectiveSettings.GetPluggableDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPluggableDatabase);
            Modify_GetPluggableDatabaseApiCall(ref _callGetPluggableDatabase);
            _callListDbSystems = clientHelper.BuildApiCall<ListDbSystemsRequest, ListDbSystemsResponse>("ListDbSystems", grpcClient.ListDbSystemsAsync, grpcClient.ListDbSystems, effectiveSettings.ListDbSystemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbSystems);
            Modify_ListDbSystemsApiCall(ref _callListDbSystems);
            _callGetDbSystem = clientHelper.BuildApiCall<GetDbSystemRequest, DbSystem>("GetDbSystem", grpcClient.GetDbSystemAsync, grpcClient.GetDbSystem, effectiveSettings.GetDbSystemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDbSystem);
            Modify_GetDbSystemApiCall(ref _callGetDbSystem);
            _callCreateDbSystem = clientHelper.BuildApiCall<CreateDbSystemRequest, lro::Operation>("CreateDbSystem", grpcClient.CreateDbSystemAsync, grpcClient.CreateDbSystem, effectiveSettings.CreateDbSystemSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDbSystem);
            Modify_CreateDbSystemApiCall(ref _callCreateDbSystem);
            _callDeleteDbSystem = clientHelper.BuildApiCall<DeleteDbSystemRequest, lro::Operation>("DeleteDbSystem", grpcClient.DeleteDbSystemAsync, grpcClient.DeleteDbSystem, effectiveSettings.DeleteDbSystemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDbSystem);
            Modify_DeleteDbSystemApiCall(ref _callDeleteDbSystem);
            _callListDbVersions = clientHelper.BuildApiCall<ListDbVersionsRequest, ListDbVersionsResponse>("ListDbVersions", grpcClient.ListDbVersionsAsync, grpcClient.ListDbVersions, effectiveSettings.ListDbVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDbVersions);
            Modify_ListDbVersionsApiCall(ref _callListDbVersions);
            _callListDatabaseCharacterSets = clientHelper.BuildApiCall<ListDatabaseCharacterSetsRequest, ListDatabaseCharacterSetsResponse>("ListDatabaseCharacterSets", grpcClient.ListDatabaseCharacterSetsAsync, grpcClient.ListDatabaseCharacterSets, effectiveSettings.ListDatabaseCharacterSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatabaseCharacterSets);
            Modify_ListDatabaseCharacterSetsApiCall(ref _callListDatabaseCharacterSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCloudExadataInfrastructuresApiCall(ref gaxgrpc::ApiCall<ListCloudExadataInfrastructuresRequest, ListCloudExadataInfrastructuresResponse> call);

        partial void Modify_GetCloudExadataInfrastructureApiCall(ref gaxgrpc::ApiCall<GetCloudExadataInfrastructureRequest, CloudExadataInfrastructure> call);

        partial void Modify_CreateCloudExadataInfrastructureApiCall(ref gaxgrpc::ApiCall<CreateCloudExadataInfrastructureRequest, lro::Operation> call);

        partial void Modify_DeleteCloudExadataInfrastructureApiCall(ref gaxgrpc::ApiCall<DeleteCloudExadataInfrastructureRequest, lro::Operation> call);

        partial void Modify_ListCloudVmClustersApiCall(ref gaxgrpc::ApiCall<ListCloudVmClustersRequest, ListCloudVmClustersResponse> call);

        partial void Modify_GetCloudVmClusterApiCall(ref gaxgrpc::ApiCall<GetCloudVmClusterRequest, CloudVmCluster> call);

        partial void Modify_CreateCloudVmClusterApiCall(ref gaxgrpc::ApiCall<CreateCloudVmClusterRequest, lro::Operation> call);

        partial void Modify_DeleteCloudVmClusterApiCall(ref gaxgrpc::ApiCall<DeleteCloudVmClusterRequest, lro::Operation> call);

        partial void Modify_ListEntitlementsApiCall(ref gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> call);

        partial void Modify_ListDbServersApiCall(ref gaxgrpc::ApiCall<ListDbServersRequest, ListDbServersResponse> call);

        partial void Modify_ListDbNodesApiCall(ref gaxgrpc::ApiCall<ListDbNodesRequest, ListDbNodesResponse> call);

        partial void Modify_ListGiVersionsApiCall(ref gaxgrpc::ApiCall<ListGiVersionsRequest, ListGiVersionsResponse> call);

        partial void Modify_ListMinorVersionsApiCall(ref gaxgrpc::ApiCall<ListMinorVersionsRequest, ListMinorVersionsResponse> call);

        partial void Modify_ListDbSystemShapesApiCall(ref gaxgrpc::ApiCall<ListDbSystemShapesRequest, ListDbSystemShapesResponse> call);

        partial void Modify_ListAutonomousDatabasesApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse> call);

        partial void Modify_GetAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<GetAutonomousDatabaseRequest, AutonomousDatabase> call);

        partial void Modify_CreateAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<CreateAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_UpdateAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<UpdateAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_DeleteAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<DeleteAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_RestoreAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<RestoreAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_GenerateAutonomousDatabaseWalletApiCall(ref gaxgrpc::ApiCall<GenerateAutonomousDatabaseWalletRequest, GenerateAutonomousDatabaseWalletResponse> call);

        partial void Modify_ListAutonomousDbVersionsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse> call);

        partial void Modify_ListAutonomousDatabaseCharacterSetsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse> call);

        partial void Modify_ListAutonomousDatabaseBackupsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse> call);

        partial void Modify_StopAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<StopAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_StartAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<StartAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_RestartAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<RestartAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_SwitchoverAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<SwitchoverAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_FailoverAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<FailoverAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_ListOdbNetworksApiCall(ref gaxgrpc::ApiCall<ListOdbNetworksRequest, ListOdbNetworksResponse> call);

        partial void Modify_GetOdbNetworkApiCall(ref gaxgrpc::ApiCall<GetOdbNetworkRequest, OdbNetwork> call);

        partial void Modify_CreateOdbNetworkApiCall(ref gaxgrpc::ApiCall<CreateOdbNetworkRequest, lro::Operation> call);

        partial void Modify_DeleteOdbNetworkApiCall(ref gaxgrpc::ApiCall<DeleteOdbNetworkRequest, lro::Operation> call);

        partial void Modify_ListOdbSubnetsApiCall(ref gaxgrpc::ApiCall<ListOdbSubnetsRequest, ListOdbSubnetsResponse> call);

        partial void Modify_GetOdbSubnetApiCall(ref gaxgrpc::ApiCall<GetOdbSubnetRequest, OdbSubnet> call);

        partial void Modify_CreateOdbSubnetApiCall(ref gaxgrpc::ApiCall<CreateOdbSubnetRequest, lro::Operation> call);

        partial void Modify_DeleteOdbSubnetApiCall(ref gaxgrpc::ApiCall<DeleteOdbSubnetRequest, lro::Operation> call);

        partial void Modify_ListExadbVmClustersApiCall(ref gaxgrpc::ApiCall<ListExadbVmClustersRequest, ListExadbVmClustersResponse> call);

        partial void Modify_GetExadbVmClusterApiCall(ref gaxgrpc::ApiCall<GetExadbVmClusterRequest, ExadbVmCluster> call);

        partial void Modify_CreateExadbVmClusterApiCall(ref gaxgrpc::ApiCall<CreateExadbVmClusterRequest, lro::Operation> call);

        partial void Modify_DeleteExadbVmClusterApiCall(ref gaxgrpc::ApiCall<DeleteExadbVmClusterRequest, lro::Operation> call);

        partial void Modify_UpdateExadbVmClusterApiCall(ref gaxgrpc::ApiCall<UpdateExadbVmClusterRequest, lro::Operation> call);

        partial void Modify_RemoveVirtualMachineExadbVmClusterApiCall(ref gaxgrpc::ApiCall<RemoveVirtualMachineExadbVmClusterRequest, lro::Operation> call);

        partial void Modify_ListExascaleDbStorageVaultsApiCall(ref gaxgrpc::ApiCall<ListExascaleDbStorageVaultsRequest, ListExascaleDbStorageVaultsResponse> call);

        partial void Modify_GetExascaleDbStorageVaultApiCall(ref gaxgrpc::ApiCall<GetExascaleDbStorageVaultRequest, ExascaleDbStorageVault> call);

        partial void Modify_CreateExascaleDbStorageVaultApiCall(ref gaxgrpc::ApiCall<CreateExascaleDbStorageVaultRequest, lro::Operation> call);

        partial void Modify_DeleteExascaleDbStorageVaultApiCall(ref gaxgrpc::ApiCall<DeleteExascaleDbStorageVaultRequest, lro::Operation> call);

        partial void Modify_ListDbSystemInitialStorageSizesApiCall(ref gaxgrpc::ApiCall<ListDbSystemInitialStorageSizesRequest, ListDbSystemInitialStorageSizesResponse> call);

        partial void Modify_ListDatabasesApiCall(ref gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> call);

        partial void Modify_GetDatabaseApiCall(ref gaxgrpc::ApiCall<GetDatabaseRequest, Database> call);

        partial void Modify_ListPluggableDatabasesApiCall(ref gaxgrpc::ApiCall<ListPluggableDatabasesRequest, ListPluggableDatabasesResponse> call);

        partial void Modify_GetPluggableDatabaseApiCall(ref gaxgrpc::ApiCall<GetPluggableDatabaseRequest, PluggableDatabase> call);

        partial void Modify_ListDbSystemsApiCall(ref gaxgrpc::ApiCall<ListDbSystemsRequest, ListDbSystemsResponse> call);

        partial void Modify_GetDbSystemApiCall(ref gaxgrpc::ApiCall<GetDbSystemRequest, DbSystem> call);

        partial void Modify_CreateDbSystemApiCall(ref gaxgrpc::ApiCall<CreateDbSystemRequest, lro::Operation> call);

        partial void Modify_DeleteDbSystemApiCall(ref gaxgrpc::ApiCall<DeleteDbSystemRequest, lro::Operation> call);

        partial void Modify_ListDbVersionsApiCall(ref gaxgrpc::ApiCall<ListDbVersionsRequest, ListDbVersionsResponse> call);

        partial void Modify_ListDatabaseCharacterSetsApiCall(ref gaxgrpc::ApiCall<ListDatabaseCharacterSetsRequest, ListDatabaseCharacterSetsResponse> call);

        partial void OnConstruction(OracleDatabase.OracleDatabaseClient grpcClient, OracleDatabaseSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OracleDatabase client</summary>
        public override OracleDatabase.OracleDatabaseClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListCloudExadataInfrastructuresRequest(ref ListCloudExadataInfrastructuresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloudExadataInfrastructureRequest(ref GetCloudExadataInfrastructureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCloudExadataInfrastructureRequest(ref CreateCloudExadataInfrastructureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCloudExadataInfrastructureRequest(ref DeleteCloudExadataInfrastructureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCloudVmClustersRequest(ref ListCloudVmClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloudVmClusterRequest(ref GetCloudVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCloudVmClusterRequest(ref CreateCloudVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCloudVmClusterRequest(ref DeleteCloudVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitlementsRequest(ref ListEntitlementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbServersRequest(ref ListDbServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbNodesRequest(ref ListDbNodesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGiVersionsRequest(ref ListGiVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMinorVersionsRequest(ref ListMinorVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbSystemShapesRequest(ref ListDbSystemShapesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabasesRequest(ref ListAutonomousDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutonomousDatabaseRequest(ref GetAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAutonomousDatabaseRequest(ref CreateAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAutonomousDatabaseRequest(ref UpdateAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAutonomousDatabaseRequest(ref DeleteAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreAutonomousDatabaseRequest(ref RestoreAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAutonomousDatabaseWalletRequest(ref GenerateAutonomousDatabaseWalletRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDbVersionsRequest(ref ListAutonomousDbVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabaseCharacterSetsRequest(ref ListAutonomousDatabaseCharacterSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabaseBackupsRequest(ref ListAutonomousDatabaseBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopAutonomousDatabaseRequest(ref StopAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartAutonomousDatabaseRequest(ref StartAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestartAutonomousDatabaseRequest(ref RestartAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SwitchoverAutonomousDatabaseRequest(ref SwitchoverAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FailoverAutonomousDatabaseRequest(ref FailoverAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOdbNetworksRequest(ref ListOdbNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOdbNetworkRequest(ref GetOdbNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOdbNetworkRequest(ref CreateOdbNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOdbNetworkRequest(ref DeleteOdbNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOdbSubnetsRequest(ref ListOdbSubnetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOdbSubnetRequest(ref GetOdbSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOdbSubnetRequest(ref CreateOdbSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOdbSubnetRequest(ref DeleteOdbSubnetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExadbVmClustersRequest(ref ListExadbVmClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExadbVmClusterRequest(ref GetExadbVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExadbVmClusterRequest(ref CreateExadbVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExadbVmClusterRequest(ref DeleteExadbVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExadbVmClusterRequest(ref UpdateExadbVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveVirtualMachineExadbVmClusterRequest(ref RemoveVirtualMachineExadbVmClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExascaleDbStorageVaultsRequest(ref ListExascaleDbStorageVaultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExascaleDbStorageVaultRequest(ref GetExascaleDbStorageVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExascaleDbStorageVaultRequest(ref CreateExascaleDbStorageVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExascaleDbStorageVaultRequest(ref DeleteExascaleDbStorageVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbSystemInitialStorageSizesRequest(ref ListDbSystemInitialStorageSizesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatabaseRequest(ref GetDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPluggableDatabasesRequest(ref ListPluggableDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPluggableDatabaseRequest(ref GetPluggableDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbSystemsRequest(ref ListDbSystemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDbSystemRequest(ref GetDbSystemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDbSystemRequest(ref CreateDbSystemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDbSystemRequest(ref DeleteDbSystemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDbVersionsRequest(ref ListDbVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatabaseCharacterSetsRequest(ref ListDatabaseCharacterSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudExadataInfrastructuresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloudExadataInfrastructuresRequest, ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure>(_callListCloudExadataInfrastructures, request, callSettings);
        }

        /// <summary>
        /// Lists Exadata Infrastructures in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudExadataInfrastructure"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudExadataInfrastructuresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloudExadataInfrastructuresRequest, ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure>(_callListCloudExadataInfrastructures, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudExadataInfrastructure GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return _callGetCloudExadataInfrastructure.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudExadataInfrastructure> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return _callGetCloudExadataInfrastructure.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCloudExadataInfrastructure</c>.</summary>
        public override lro::OperationsClient CreateCloudExadataInfrastructureOperationsClient { get; }

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CloudExadataInfrastructure, OperationMetadata> CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return new lro::Operation<CloudExadataInfrastructure, OperationMetadata>(_callCreateCloudExadataInfrastructure.Sync(request, callSettings), CreateCloudExadataInfrastructureOperationsClient);
        }

        /// <summary>
        /// Creates a new Exadata Infrastructure in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CloudExadataInfrastructure, OperationMetadata>> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return new lro::Operation<CloudExadataInfrastructure, OperationMetadata>(await _callCreateCloudExadataInfrastructure.Async(request, callSettings).ConfigureAwait(false), CreateCloudExadataInfrastructureOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCloudExadataInfrastructure</c>.</summary>
        public override lro::OperationsClient DeleteCloudExadataInfrastructureOperationsClient { get; }

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCloudExadataInfrastructure.Sync(request, callSettings), DeleteCloudExadataInfrastructureOperationsClient);
        }

        /// <summary>
        /// Deletes a single Exadata Infrastructure.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudExadataInfrastructureRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCloudExadataInfrastructure.Async(request, callSettings).ConfigureAwait(false), DeleteCloudExadataInfrastructureOperationsClient);
        }

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClusters(ListCloudVmClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudVmClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloudVmClustersRequest, ListCloudVmClustersResponse, CloudVmCluster>(_callListCloudVmClusters, request, callSettings);
        }

        /// <summary>
        /// Lists the VM Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudVmCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> ListCloudVmClustersAsync(ListCloudVmClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudVmClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloudVmClustersRequest, ListCloudVmClustersResponse, CloudVmCluster>(_callListCloudVmClusters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudVmCluster GetCloudVmCluster(GetCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudVmClusterRequest(ref request, ref callSettings);
            return _callGetCloudVmCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudVmCluster> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudVmClusterRequest(ref request, ref callSettings);
            return _callGetCloudVmCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCloudVmCluster</c>.</summary>
        public override lro::OperationsClient CreateCloudVmClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CloudVmCluster, OperationMetadata> CreateCloudVmCluster(CreateCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<CloudVmCluster, OperationMetadata>(_callCreateCloudVmCluster.Sync(request, callSettings), CreateCloudVmClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new VM Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CloudVmCluster, OperationMetadata>> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<CloudVmCluster, OperationMetadata>(await _callCreateCloudVmCluster.Async(request, callSettings).ConfigureAwait(false), CreateCloudVmClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCloudVmCluster</c>.</summary>
        public override lro::OperationsClient DeleteCloudVmClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCloudVmCluster(DeleteCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCloudVmCluster.Sync(request, callSettings), DeleteCloudVmClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCloudVmCluster.Async(request, callSettings).ConfigureAwait(false), DeleteCloudVmClusterOperationsClient);
        }

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// Lists the entitlements in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbServersResponse, DbServer> ListDbServers(ListDbServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbServersRequest, ListDbServersResponse, DbServer>(_callListDbServers, request, callSettings);
        }

        /// <summary>
        /// Lists the database servers of an Exadata Infrastructure instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbServersResponse, DbServer> ListDbServersAsync(ListDbServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbServersRequest, ListDbServersResponse, DbServer>(_callListDbServers, request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbNode"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbNodesResponse, DbNode> ListDbNodes(ListDbNodesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbNodesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbNodesRequest, ListDbNodesResponse, DbNode>(_callListDbNodes, request, callSettings);
        }

        /// <summary>
        /// Lists the database nodes of a VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbNode"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbNodesResponse, DbNode> ListDbNodesAsync(ListDbNodesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbNodesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbNodesRequest, ListDbNodesResponse, DbNode>(_callListDbNodes, request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GiVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersions(ListGiVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGiVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGiVersionsRequest, ListGiVersionsResponse, GiVersion>(_callListGiVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all the valid Oracle Grid Infrastructure (GI) versions for the given
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GiVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> ListGiVersionsAsync(ListGiVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGiVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGiVersionsRequest, ListGiVersionsResponse, GiVersion>(_callListGiVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MinorVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersions(ListMinorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMinorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMinorVersionsRequest, ListMinorVersionsResponse, MinorVersion>(_callListMinorVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all the valid minor versions for the given
        /// project, location, gi version and shape family.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MinorVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> ListMinorVersionsAsync(ListMinorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMinorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMinorVersionsRequest, ListMinorVersionsResponse, MinorVersion>(_callListMinorVersions, request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemShape"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapes(ListDbSystemShapesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemShapesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbSystemShapesRequest, ListDbSystemShapesResponse, DbSystemShape>(_callListDbSystemShapes, request, callSettings);
        }

        /// <summary>
        /// Lists the database system shapes available for the project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemShape"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> ListDbSystemShapesAsync(ListDbSystemShapesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemShapesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbSystemShapesRequest, ListDbSystemShapesResponse, DbSystemShape>(_callListDbSystemShapes, request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabases(ListAutonomousDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse, AutonomousDatabase>(_callListAutonomousDatabases, request, callSettings);
        }

        /// <summary>
        /// Lists the Autonomous Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabase"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> ListAutonomousDatabasesAsync(ListAutonomousDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse, AutonomousDatabase>(_callListAutonomousDatabases, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutonomousDatabase GetAutonomousDatabase(GetAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutonomousDatabaseRequest(ref request, ref callSettings);
            return _callGetAutonomousDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutonomousDatabase> GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutonomousDatabaseRequest(ref request, ref callSettings);
            return _callGetAutonomousDatabase.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient CreateAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> CreateAutonomousDatabase(CreateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callCreateAutonomousDatabase.Sync(request, callSettings), CreateAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Creates a new Autonomous Database in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callCreateAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), CreateAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient UpdateAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> UpdateAutonomousDatabase(UpdateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callUpdateAutonomousDatabase.Sync(request, callSettings), UpdateAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callUpdateAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), UpdateAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient DeleteAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAutonomousDatabase(DeleteAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAutonomousDatabase.Sync(request, callSettings), DeleteAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Deletes a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), DeleteAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient RestoreAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> RestoreAutonomousDatabase(RestoreAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callRestoreAutonomousDatabase.Sync(request, callSettings), RestoreAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Restores a single Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callRestoreAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), RestoreAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAutonomousDatabaseWalletResponse GenerateAutonomousDatabaseWallet(GenerateAutonomousDatabaseWalletRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAutonomousDatabaseWalletRequest(ref request, ref callSettings);
            return _callGenerateAutonomousDatabaseWallet.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a wallet for an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAutonomousDatabaseWalletResponse> GenerateAutonomousDatabaseWalletAsync(GenerateAutonomousDatabaseWalletRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAutonomousDatabaseWalletRequest(ref request, ref callSettings);
            return _callGenerateAutonomousDatabaseWallet.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersions(ListAutonomousDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDbVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse, AutonomousDbVersion>(_callListAutonomousDbVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all the available Autonomous Database versions for a project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDbVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> ListAutonomousDbVersionsAsync(ListAutonomousDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDbVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse, AutonomousDbVersion>(_callListAutonomousDbVersions, request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSets(ListAutonomousDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabaseCharacterSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet>(_callListAutonomousDatabaseCharacterSets, request, callSettings);
        }

        /// <summary>
        /// Lists Autonomous Database Character Sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AutonomousDatabaseCharacterSet"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> ListAutonomousDatabaseCharacterSetsAsync(ListAutonomousDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabaseCharacterSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet>(_callListAutonomousDatabaseCharacterSets, request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackups(ListAutonomousDatabaseBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabaseBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup>(_callListAutonomousDatabaseBackups, request, callSettings);
        }

        /// <summary>
        /// Lists the long-term and automatic backups of an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutonomousDatabaseBackup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> ListAutonomousDatabaseBackupsAsync(ListAutonomousDatabaseBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutonomousDatabaseBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup>(_callListAutonomousDatabaseBackups, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>StopAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient StopAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> StopAutonomousDatabase(StopAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callStopAutonomousDatabase.Sync(request, callSettings), StopAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Stops an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callStopAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), StopAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient StartAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> StartAutonomousDatabase(StartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callStartAutonomousDatabase.Sync(request, callSettings), StartAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Starts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callStartAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), StartAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestartAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient RestartAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> RestartAutonomousDatabase(RestartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callRestartAutonomousDatabase.Sync(request, callSettings), RestartAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Restarts an Autonomous Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> RestartAutonomousDatabaseAsync(RestartAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callRestartAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), RestartAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SwitchoverAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient SwitchoverAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> SwitchoverAutonomousDatabase(SwitchoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callSwitchoverAutonomousDatabase.Sync(request, callSettings), SwitchoverAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Initiates a switchover of specified autonomous database to the associated
        /// peer database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callSwitchoverAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), SwitchoverAutonomousDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FailoverAutonomousDatabase</c>.</summary>
        public override lro::OperationsClient FailoverAutonomousDatabaseOperationsClient { get; }

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AutonomousDatabase, OperationMetadata> FailoverAutonomousDatabase(FailoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(_callFailoverAutonomousDatabase.Sync(request, callSettings), FailoverAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Initiates a failover to target autonomous database from the associated
        /// primary database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AutonomousDatabase, OperationMetadata>> FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverAutonomousDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<AutonomousDatabase, OperationMetadata>(await _callFailoverAutonomousDatabase.Async(request, callSettings).ConfigureAwait(false), FailoverAutonomousDatabaseOperationsClient);
        }

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbNetwork"/> resources.</returns>
        public override gax::PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworks(ListOdbNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOdbNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOdbNetworksRequest, ListOdbNetworksResponse, OdbNetwork>(_callListOdbNetworks, request, callSettings);
        }

        /// <summary>
        /// Lists the ODB Networks in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbNetwork"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> ListOdbNetworksAsync(ListOdbNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOdbNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOdbNetworksRequest, ListOdbNetworksResponse, OdbNetwork>(_callListOdbNetworks, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OdbNetwork GetOdbNetwork(GetOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOdbNetworkRequest(ref request, ref callSettings);
            return _callGetOdbNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OdbNetwork> GetOdbNetworkAsync(GetOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOdbNetworkRequest(ref request, ref callSettings);
            return _callGetOdbNetwork.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOdbNetwork</c>.</summary>
        public override lro::OperationsClient CreateOdbNetworkOperationsClient { get; }

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OdbNetwork, OperationMetadata> CreateOdbNetwork(CreateOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOdbNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<OdbNetwork, OperationMetadata>(_callCreateOdbNetwork.Sync(request, callSettings), CreateOdbNetworkOperationsClient);
        }

        /// <summary>
        /// Creates a new ODB Network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OdbNetwork, OperationMetadata>> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOdbNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<OdbNetwork, OperationMetadata>(await _callCreateOdbNetwork.Async(request, callSettings).ConfigureAwait(false), CreateOdbNetworkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOdbNetwork</c>.</summary>
        public override lro::OperationsClient DeleteOdbNetworkOperationsClient { get; }

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbNetwork(DeleteOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOdbNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteOdbNetwork.Sync(request, callSettings), DeleteOdbNetworkOperationsClient);
        }

        /// <summary>
        /// Deletes a single ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOdbNetworkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteOdbNetwork.Async(request, callSettings).ConfigureAwait(false), DeleteOdbNetworkOperationsClient);
        }

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OdbSubnet"/> resources.</returns>
        public override gax::PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnets(ListOdbSubnetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOdbSubnetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOdbSubnetsRequest, ListOdbSubnetsResponse, OdbSubnet>(_callListOdbSubnets, request, callSettings);
        }

        /// <summary>
        /// Lists all the ODB Subnets in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OdbSubnet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> ListOdbSubnetsAsync(ListOdbSubnetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOdbSubnetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOdbSubnetsRequest, ListOdbSubnetsResponse, OdbSubnet>(_callListOdbSubnets, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OdbSubnet GetOdbSubnet(GetOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOdbSubnetRequest(ref request, ref callSettings);
            return _callGetOdbSubnet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OdbSubnet> GetOdbSubnetAsync(GetOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOdbSubnetRequest(ref request, ref callSettings);
            return _callGetOdbSubnet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOdbSubnet</c>.</summary>
        public override lro::OperationsClient CreateOdbSubnetOperationsClient { get; }

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OdbSubnet, OperationMetadata> CreateOdbSubnet(CreateOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOdbSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<OdbSubnet, OperationMetadata>(_callCreateOdbSubnet.Sync(request, callSettings), CreateOdbSubnetOperationsClient);
        }

        /// <summary>
        /// Creates a new ODB Subnet in a given ODB Network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OdbSubnet, OperationMetadata>> CreateOdbSubnetAsync(CreateOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOdbSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<OdbSubnet, OperationMetadata>(await _callCreateOdbSubnet.Async(request, callSettings).ConfigureAwait(false), CreateOdbSubnetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOdbSubnet</c>.</summary>
        public override lro::OperationsClient DeleteOdbSubnetOperationsClient { get; }

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteOdbSubnet(DeleteOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOdbSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteOdbSubnet.Sync(request, callSettings), DeleteOdbSubnetOperationsClient);
        }

        /// <summary>
        /// Deletes a single ODB Subnet.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOdbSubnetAsync(DeleteOdbSubnetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOdbSubnetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteOdbSubnet.Async(request, callSettings).ConfigureAwait(false), DeleteOdbSubnetOperationsClient);
        }

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClusters(ListExadbVmClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExadbVmClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExadbVmClustersRequest, ListExadbVmClustersResponse, ExadbVmCluster>(_callListExadbVmClusters, request, callSettings);
        }

        /// <summary>
        /// Lists all the Exadb (Exascale) VM Clusters for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExadbVmCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> ListExadbVmClustersAsync(ListExadbVmClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExadbVmClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExadbVmClustersRequest, ListExadbVmClustersResponse, ExadbVmCluster>(_callListExadbVmClusters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExadbVmCluster GetExadbVmCluster(GetExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExadbVmClusterRequest(ref request, ref callSettings);
            return _callGetExadbVmCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExadbVmCluster> GetExadbVmClusterAsync(GetExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExadbVmClusterRequest(ref request, ref callSettings);
            return _callGetExadbVmCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateExadbVmCluster</c>.</summary>
        public override lro::OperationsClient CreateExadbVmClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExadbVmCluster, OperationMetadata> CreateExadbVmCluster(CreateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(_callCreateExadbVmCluster.Sync(request, callSettings), CreateExadbVmClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new Exadb (Exascale) VM Cluster resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> CreateExadbVmClusterAsync(CreateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(await _callCreateExadbVmCluster.Async(request, callSettings).ConfigureAwait(false), CreateExadbVmClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteExadbVmCluster</c>.</summary>
        public override lro::OperationsClient DeleteExadbVmClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteExadbVmCluster(DeleteExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteExadbVmCluster.Sync(request, callSettings), DeleteExadbVmClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single Exadb (Exascale) VM Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteExadbVmCluster.Async(request, callSettings).ConfigureAwait(false), DeleteExadbVmClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateExadbVmCluster</c>.</summary>
        public override lro::OperationsClient UpdateExadbVmClusterOperationsClient { get; }

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExadbVmCluster, OperationMetadata> UpdateExadbVmCluster(UpdateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(_callUpdateExadbVmCluster.Sync(request, callSettings), UpdateExadbVmClusterOperationsClient);
        }

        /// <summary>
        /// Updates a single Exadb (Exascale) VM Cluster. To add virtual machines to
        /// existing exadb vm cluster, only pass the node count.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(await _callUpdateExadbVmCluster.Async(request, callSettings).ConfigureAwait(false), UpdateExadbVmClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveVirtualMachineExadbVmCluster</c>.</summary>
        public override lro::OperationsClient RemoveVirtualMachineExadbVmClusterOperationsClient { get; }

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExadbVmCluster, OperationMetadata> RemoveVirtualMachineExadbVmCluster(RemoveVirtualMachineExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveVirtualMachineExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(_callRemoveVirtualMachineExadbVmCluster.Sync(request, callSettings), RemoveVirtualMachineExadbVmClusterOperationsClient);
        }

        /// <summary>
        /// Removes virtual machines from an existing exadb vm cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExadbVmCluster, OperationMetadata>> RemoveVirtualMachineExadbVmClusterAsync(RemoveVirtualMachineExadbVmClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveVirtualMachineExadbVmClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ExadbVmCluster, OperationMetadata>(await _callRemoveVirtualMachineExadbVmCluster.Async(request, callSettings).ConfigureAwait(false), RemoveVirtualMachineExadbVmClusterOperationsClient);
        }

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public override gax::PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaults(ListExascaleDbStorageVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExascaleDbStorageVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExascaleDbStorageVaultsRequest, ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault>(_callListExascaleDbStorageVaults, request, callSettings);
        }

        /// <summary>
        /// Lists all the ExascaleDB Storage Vaults for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ExascaleDbStorageVault"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> ListExascaleDbStorageVaultsAsync(ListExascaleDbStorageVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExascaleDbStorageVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExascaleDbStorageVaultsRequest, ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault>(_callListExascaleDbStorageVaults, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExascaleDbStorageVault GetExascaleDbStorageVault(GetExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return _callGetExascaleDbStorageVault.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExascaleDbStorageVault> GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return _callGetExascaleDbStorageVault.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateExascaleDbStorageVault</c>.</summary>
        public override lro::OperationsClient CreateExascaleDbStorageVaultOperationsClient { get; }

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExascaleDbStorageVault, OperationMetadata> CreateExascaleDbStorageVault(CreateExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return new lro::Operation<ExascaleDbStorageVault, OperationMetadata>(_callCreateExascaleDbStorageVault.Sync(request, callSettings), CreateExascaleDbStorageVaultOperationsClient);
        }

        /// <summary>
        /// Creates a new ExascaleDB Storage Vault resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExascaleDbStorageVault, OperationMetadata>> CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return new lro::Operation<ExascaleDbStorageVault, OperationMetadata>(await _callCreateExascaleDbStorageVault.Async(request, callSettings).ConfigureAwait(false), CreateExascaleDbStorageVaultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteExascaleDbStorageVault</c>.</summary>
        public override lro::OperationsClient DeleteExascaleDbStorageVaultOperationsClient { get; }

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteExascaleDbStorageVault(DeleteExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteExascaleDbStorageVault.Sync(request, callSettings), DeleteExascaleDbStorageVaultOperationsClient);
        }

        /// <summary>
        /// Deletes a single ExascaleDB Storage Vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExascaleDbStorageVaultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteExascaleDbStorageVault.Async(request, callSettings).ConfigureAwait(false), DeleteExascaleDbStorageVaultOperationsClient);
        }

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizes(ListDbSystemInitialStorageSizesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemInitialStorageSizesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbSystemInitialStorageSizesRequest, ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize>(_callListDbSystemInitialStorageSizes, request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystemInitialStorageSizes for the given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystemInitialStorageSize"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> ListDbSystemInitialStorageSizesAsync(ListDbSystemInitialStorageSizesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemInitialStorageSizesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbSystemInitialStorageSizesRequest, ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize>(_callListDbSystemInitialStorageSizes, request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Database"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Lists all the Databases for the given project, location and DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Database GetDatabase(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public override gax::PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabases(ListPluggableDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluggableDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPluggableDatabasesRequest, ListPluggableDatabasesResponse, PluggableDatabase>(_callListPluggableDatabases, request, callSettings);
        }

        /// <summary>
        /// Lists all the PluggableDatabases for the given project, location and
        /// Container Database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PluggableDatabase"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> ListPluggableDatabasesAsync(ListPluggableDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPluggableDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPluggableDatabasesRequest, ListPluggableDatabasesResponse, PluggableDatabase>(_callListPluggableDatabases, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PluggableDatabase GetPluggableDatabase(GetPluggableDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluggableDatabaseRequest(ref request, ref callSettings);
            return _callGetPluggableDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PluggableDatabase.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PluggableDatabase> GetPluggableDatabaseAsync(GetPluggableDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPluggableDatabaseRequest(ref request, ref callSettings);
            return _callGetPluggableDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbSystem"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystems(ListDbSystemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbSystemsRequest, ListDbSystemsResponse, DbSystem>(_callListDbSystems, request, callSettings);
        }

        /// <summary>
        /// Lists all the DbSystems for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbSystem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> ListDbSystemsAsync(ListDbSystemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbSystemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbSystemsRequest, ListDbSystemsResponse, DbSystem>(_callListDbSystems, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DbSystem GetDbSystem(GetDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDbSystemRequest(ref request, ref callSettings);
            return _callGetDbSystem.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DbSystem> GetDbSystemAsync(GetDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDbSystemRequest(ref request, ref callSettings);
            return _callGetDbSystem.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDbSystem</c>.</summary>
        public override lro::OperationsClient CreateDbSystemOperationsClient { get; }

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DbSystem, OperationMetadata> CreateDbSystem(CreateDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDbSystemRequest(ref request, ref callSettings);
            return new lro::Operation<DbSystem, OperationMetadata>(_callCreateDbSystem.Sync(request, callSettings), CreateDbSystemOperationsClient);
        }

        /// <summary>
        /// Creates a new DbSystem in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DbSystem, OperationMetadata>> CreateDbSystemAsync(CreateDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDbSystemRequest(ref request, ref callSettings);
            return new lro::Operation<DbSystem, OperationMetadata>(await _callCreateDbSystem.Async(request, callSettings).ConfigureAwait(false), CreateDbSystemOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDbSystem</c>.</summary>
        public override lro::OperationsClient DeleteDbSystemOperationsClient { get; }

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDbSystem(DeleteDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDbSystemRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDbSystem.Sync(request, callSettings), DeleteDbSystemOperationsClient);
        }

        /// <summary>
        /// Deletes a single DbSystem.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDbSystemAsync(DeleteDbSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDbSystemRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDbSystem.Async(request, callSettings).ConfigureAwait(false), DeleteDbSystemOperationsClient);
        }

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DbVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersions(ListDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDbVersionsRequest, ListDbVersionsResponse, DbVersion>(_callListDbVersions, request, callSettings);
        }

        /// <summary>
        /// List DbVersions for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DbVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> ListDbVersionsAsync(ListDbVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDbVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDbVersionsRequest, ListDbVersionsResponse, DbVersion>(_callListDbVersions, request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSets(ListDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabaseCharacterSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatabaseCharacterSetsRequest, ListDatabaseCharacterSetsResponse, DatabaseCharacterSet>(_callListDatabaseCharacterSets, request, callSettings);
        }

        /// <summary>
        /// List DatabaseCharacterSets for the given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatabaseCharacterSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> ListDatabaseCharacterSetsAsync(ListDatabaseCharacterSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabaseCharacterSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatabaseCharacterSetsRequest, ListDatabaseCharacterSetsResponse, DatabaseCharacterSet>(_callListDatabaseCharacterSets, request, callSettings);
        }
    }

    public partial class ListCloudExadataInfrastructuresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloudVmClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitlementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbNodesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGiVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMinorVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbSystemShapesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutonomousDatabasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutonomousDbVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutonomousDatabaseCharacterSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutonomousDatabaseBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOdbNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOdbSubnetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExadbVmClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExascaleDbStorageVaultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbSystemInitialStorageSizesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatabasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPluggableDatabasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbSystemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDbVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatabaseCharacterSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloudExadataInfrastructuresResponse : gaxgrpc::IPageResponse<CloudExadataInfrastructure>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudExadataInfrastructure> GetEnumerator() => CloudExadataInfrastructures.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCloudVmClustersResponse : gaxgrpc::IPageResponse<CloudVmCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudVmCluster> GetEnumerator() => CloudVmClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntitlementsResponse : gaxgrpc::IPageResponse<Entitlement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entitlement> GetEnumerator() => Entitlements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbServersResponse : gaxgrpc::IPageResponse<DbServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbServer> GetEnumerator() => DbServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbNodesResponse : gaxgrpc::IPageResponse<DbNode>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbNode> GetEnumerator() => DbNodes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGiVersionsResponse : gaxgrpc::IPageResponse<GiVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GiVersion> GetEnumerator() => GiVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMinorVersionsResponse : gaxgrpc::IPageResponse<MinorVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MinorVersion> GetEnumerator() => MinorVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbSystemShapesResponse : gaxgrpc::IPageResponse<DbSystemShape>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbSystemShape> GetEnumerator() => DbSystemShapes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutonomousDatabasesResponse : gaxgrpc::IPageResponse<AutonomousDatabase>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutonomousDatabase> GetEnumerator() => AutonomousDatabases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutonomousDbVersionsResponse : gaxgrpc::IPageResponse<AutonomousDbVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutonomousDbVersion> GetEnumerator() => AutonomousDbVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutonomousDatabaseCharacterSetsResponse : gaxgrpc::IPageResponse<AutonomousDatabaseCharacterSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutonomousDatabaseCharacterSet> GetEnumerator() =>
            AutonomousDatabaseCharacterSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutonomousDatabaseBackupsResponse : gaxgrpc::IPageResponse<AutonomousDatabaseBackup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutonomousDatabaseBackup> GetEnumerator() => AutonomousDatabaseBackups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOdbNetworksResponse : gaxgrpc::IPageResponse<OdbNetwork>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OdbNetwork> GetEnumerator() => OdbNetworks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOdbSubnetsResponse : gaxgrpc::IPageResponse<OdbSubnet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OdbSubnet> GetEnumerator() => OdbSubnets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExadbVmClustersResponse : gaxgrpc::IPageResponse<ExadbVmCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ExadbVmCluster> GetEnumerator() => ExadbVmClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExascaleDbStorageVaultsResponse : gaxgrpc::IPageResponse<ExascaleDbStorageVault>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ExascaleDbStorageVault> GetEnumerator() => ExascaleDbStorageVaults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbSystemInitialStorageSizesResponse : gaxgrpc::IPageResponse<DbSystemInitialStorageSize>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbSystemInitialStorageSize> GetEnumerator() => DbSystemInitialStorageSizes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatabasesResponse : gaxgrpc::IPageResponse<Database>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Database> GetEnumerator() => Databases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPluggableDatabasesResponse : gaxgrpc::IPageResponse<PluggableDatabase>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PluggableDatabase> GetEnumerator() => PluggableDatabases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbSystemsResponse : gaxgrpc::IPageResponse<DbSystem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbSystem> GetEnumerator() => DbSystems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDbVersionsResponse : gaxgrpc::IPageResponse<DbVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DbVersion> GetEnumerator() => DbVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatabaseCharacterSetsResponse : gaxgrpc::IPageResponse<DatabaseCharacterSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DatabaseCharacterSet> GetEnumerator() => DatabaseCharacterSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class OracleDatabase
    {
        public partial class OracleDatabaseClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class OracleDatabase
    {
        public partial class OracleDatabaseClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
