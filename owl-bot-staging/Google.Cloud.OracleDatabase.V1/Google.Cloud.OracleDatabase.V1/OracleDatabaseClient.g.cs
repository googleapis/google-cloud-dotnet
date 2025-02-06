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
            ListDbSystemShapesSettings = existing.ListDbSystemShapesSettings;
            ListAutonomousDatabasesSettings = existing.ListAutonomousDatabasesSettings;
            GetAutonomousDatabaseSettings = existing.GetAutonomousDatabaseSettings;
            CreateAutonomousDatabaseSettings = existing.CreateAutonomousDatabaseSettings;
            CreateAutonomousDatabaseOperationsSettings = existing.CreateAutonomousDatabaseOperationsSettings.Clone();
            DeleteAutonomousDatabaseSettings = existing.DeleteAutonomousDatabaseSettings;
            DeleteAutonomousDatabaseOperationsSettings = existing.DeleteAutonomousDatabaseOperationsSettings.Clone();
            RestoreAutonomousDatabaseSettings = existing.RestoreAutonomousDatabaseSettings;
            RestoreAutonomousDatabaseOperationsSettings = existing.RestoreAutonomousDatabaseOperationsSettings.Clone();
            GenerateAutonomousDatabaseWalletSettings = existing.GenerateAutonomousDatabaseWalletSettings;
            ListAutonomousDbVersionsSettings = existing.ListAutonomousDbVersionsSettings;
            ListAutonomousDatabaseCharacterSetsSettings = existing.ListAutonomousDatabaseCharacterSetsSettings;
            ListAutonomousDatabaseBackupsSettings = existing.ListAutonomousDatabaseBackupsSettings;
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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloudExadataInfrastructuresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloudExadataInfrastructureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloudVmClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloudVmClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntitlementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbNodesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGiVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDbSystemShapesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAutonomousDatabaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDbVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabaseCharacterSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutonomousDatabaseBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

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

        private readonly gaxgrpc::ApiCall<ListDbSystemShapesRequest, ListDbSystemShapesResponse> _callListDbSystemShapes;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse> _callListAutonomousDatabases;

        private readonly gaxgrpc::ApiCall<GetAutonomousDatabaseRequest, AutonomousDatabase> _callGetAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<CreateAutonomousDatabaseRequest, lro::Operation> _callCreateAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<DeleteAutonomousDatabaseRequest, lro::Operation> _callDeleteAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<RestoreAutonomousDatabaseRequest, lro::Operation> _callRestoreAutonomousDatabase;

        private readonly gaxgrpc::ApiCall<GenerateAutonomousDatabaseWalletRequest, GenerateAutonomousDatabaseWalletResponse> _callGenerateAutonomousDatabaseWallet;

        private readonly gaxgrpc::ApiCall<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse> _callListAutonomousDbVersions;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse> _callListAutonomousDatabaseCharacterSets;

        private readonly gaxgrpc::ApiCall<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse> _callListAutonomousDatabaseBackups;

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
            DeleteAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAutonomousDatabaseOperationsSettings, logger);
            RestoreAutonomousDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAutonomousDatabaseOperationsSettings, logger);
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

        partial void Modify_ListDbSystemShapesApiCall(ref gaxgrpc::ApiCall<ListDbSystemShapesRequest, ListDbSystemShapesResponse> call);

        partial void Modify_ListAutonomousDatabasesApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabasesRequest, ListAutonomousDatabasesResponse> call);

        partial void Modify_GetAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<GetAutonomousDatabaseRequest, AutonomousDatabase> call);

        partial void Modify_CreateAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<CreateAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_DeleteAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<DeleteAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_RestoreAutonomousDatabaseApiCall(ref gaxgrpc::ApiCall<RestoreAutonomousDatabaseRequest, lro::Operation> call);

        partial void Modify_GenerateAutonomousDatabaseWalletApiCall(ref gaxgrpc::ApiCall<GenerateAutonomousDatabaseWalletRequest, GenerateAutonomousDatabaseWalletResponse> call);

        partial void Modify_ListAutonomousDbVersionsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDbVersionsRequest, ListAutonomousDbVersionsResponse> call);

        partial void Modify_ListAutonomousDatabaseCharacterSetsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabaseCharacterSetsRequest, ListAutonomousDatabaseCharacterSetsResponse> call);

        partial void Modify_ListAutonomousDatabaseBackupsApiCall(ref gaxgrpc::ApiCall<ListAutonomousDatabaseBackupsRequest, ListAutonomousDatabaseBackupsResponse> call);

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

        partial void Modify_ListDbSystemShapesRequest(ref ListDbSystemShapesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabasesRequest(ref ListAutonomousDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutonomousDatabaseRequest(ref GetAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAutonomousDatabaseRequest(ref CreateAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAutonomousDatabaseRequest(ref DeleteAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreAutonomousDatabaseRequest(ref RestoreAutonomousDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAutonomousDatabaseWalletRequest(ref GenerateAutonomousDatabaseWalletRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDbVersionsRequest(ref ListAutonomousDbVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabaseCharacterSetsRequest(ref ListAutonomousDatabaseCharacterSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutonomousDatabaseBackupsRequest(ref ListAutonomousDatabaseBackupsRequest request, ref gaxgrpc::CallSettings settings);

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
