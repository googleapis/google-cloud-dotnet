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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AlloyDb.V1Alpha
{
    /// <summary>Settings for <see cref="AlloyDBAdminClient"/> instances.</summary>
    public sealed partial class AlloyDBAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AlloyDBAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AlloyDBAdminSettings"/>.</returns>
        public static AlloyDBAdminSettings GetDefault() => new AlloyDBAdminSettings();

        /// <summary>Constructs a new <see cref="AlloyDBAdminSettings"/> object with default settings.</summary>
        public AlloyDBAdminSettings()
        {
        }

        private AlloyDBAdminSettings(AlloyDBAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClustersSettings = existing.ListClustersSettings;
            GetClusterSettings = existing.GetClusterSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            UpgradeClusterSettings = existing.UpgradeClusterSettings;
            UpgradeClusterOperationsSettings = existing.UpgradeClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings.Clone();
            PromoteClusterSettings = existing.PromoteClusterSettings;
            PromoteClusterOperationsSettings = existing.PromoteClusterOperationsSettings.Clone();
            SwitchoverClusterSettings = existing.SwitchoverClusterSettings;
            SwitchoverClusterOperationsSettings = existing.SwitchoverClusterOperationsSettings.Clone();
            RestoreClusterSettings = existing.RestoreClusterSettings;
            RestoreClusterOperationsSettings = existing.RestoreClusterOperationsSettings.Clone();
            CreateSecondaryClusterSettings = existing.CreateSecondaryClusterSettings;
            CreateSecondaryClusterOperationsSettings = existing.CreateSecondaryClusterOperationsSettings.Clone();
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            CreateSecondaryInstanceSettings = existing.CreateSecondaryInstanceSettings;
            CreateSecondaryInstanceOperationsSettings = existing.CreateSecondaryInstanceOperationsSettings.Clone();
            BatchCreateInstancesSettings = existing.BatchCreateInstancesSettings;
            BatchCreateInstancesOperationsSettings = existing.BatchCreateInstancesOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            FailoverInstanceSettings = existing.FailoverInstanceSettings;
            FailoverInstanceOperationsSettings = existing.FailoverInstanceOperationsSettings.Clone();
            InjectFaultSettings = existing.InjectFaultSettings;
            InjectFaultOperationsSettings = existing.InjectFaultOperationsSettings.Clone();
            RestartInstanceSettings = existing.RestartInstanceSettings;
            RestartInstanceOperationsSettings = existing.RestartInstanceOperationsSettings.Clone();
            ExecuteSqlSettings = existing.ExecuteSqlSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            UpdateBackupSettings = existing.UpdateBackupSettings;
            UpdateBackupOperationsSettings = existing.UpdateBackupOperationsSettings.Clone();
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            ListSupportedDatabaseFlagsSettings = existing.ListSupportedDatabaseFlagsSettings;
            GenerateClientCertificateSettings = existing.GenerateClientCertificateSettings;
            GetConnectionInfoSettings = existing.GetConnectionInfoSettings;
            ListUsersSettings = existing.ListUsersSettings;
            GetUserSettings = existing.GetUserSettings;
            CreateUserSettings = existing.CreateUserSettings;
            UpdateUserSettings = existing.UpdateUserSettings;
            DeleteUserSettings = existing.DeleteUserSettings;
            ListDatabasesSettings = existing.ListDatabasesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlloyDBAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListClusters</c> and <c>AlloyDBAdminClient.ListClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.GetCluster</c> and <c>AlloyDBAdminClient.GetClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateCluster</c> and <c>AlloyDBAdminClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.CreateCluster</c> and
        /// <c>AlloyDBAdminClient.CreateClusterAsync</c>.
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
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.UpdateCluster</c> and <c>AlloyDBAdminClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.UpdateCluster</c> and
        /// <c>AlloyDBAdminClient.UpdateClusterAsync</c>.
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
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.UpgradeCluster</c> and <c>AlloyDBAdminClient.UpgradeClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.UpgradeCluster</c> and
        /// <c>AlloyDBAdminClient.UpgradeClusterAsync</c>.
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
        public lro::OperationsSettings UpgradeClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.DeleteCluster</c> and <c>AlloyDBAdminClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.DeleteCluster</c> and
        /// <c>AlloyDBAdminClient.DeleteClusterAsync</c>.
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
        public lro::OperationsSettings DeleteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.PromoteCluster</c> and <c>AlloyDBAdminClient.PromoteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PromoteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.PromoteCluster</c> and
        /// <c>AlloyDBAdminClient.PromoteClusterAsync</c>.
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
        public lro::OperationsSettings PromoteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.SwitchoverCluster</c> and <c>AlloyDBAdminClient.SwitchoverClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchoverClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.SwitchoverCluster</c> and
        /// <c>AlloyDBAdminClient.SwitchoverClusterAsync</c>.
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
        public lro::OperationsSettings SwitchoverClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.RestoreCluster</c> and <c>AlloyDBAdminClient.RestoreClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.RestoreCluster</c> and
        /// <c>AlloyDBAdminClient.RestoreClusterAsync</c>.
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
        public lro::OperationsSettings RestoreClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateSecondaryCluster</c> and <c>AlloyDBAdminClient.CreateSecondaryClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecondaryClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.CreateSecondaryCluster</c> and
        /// <c>AlloyDBAdminClient.CreateSecondaryClusterAsync</c>.
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
        public lro::OperationsSettings CreateSecondaryClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListInstances</c> and <c>AlloyDBAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.GetInstance</c> and <c>AlloyDBAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateInstance</c> and <c>AlloyDBAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.CreateInstance</c> and
        /// <c>AlloyDBAdminClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateSecondaryInstance</c> and <c>AlloyDBAdminClient.CreateSecondaryInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecondaryInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.CreateSecondaryInstance</c> and
        /// <c>AlloyDBAdminClient.CreateSecondaryInstanceAsync</c>.
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
        public lro::OperationsSettings CreateSecondaryInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.BatchCreateInstances</c> and <c>AlloyDBAdminClient.BatchCreateInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.BatchCreateInstances</c> and
        /// <c>AlloyDBAdminClient.BatchCreateInstancesAsync</c>.
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
        public lro::OperationsSettings BatchCreateInstancesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.UpdateInstance</c> and <c>AlloyDBAdminClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.UpdateInstance</c> and
        /// <c>AlloyDBAdminClient.UpdateInstanceAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.DeleteInstance</c> and <c>AlloyDBAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.DeleteInstance</c> and
        /// <c>AlloyDBAdminClient.DeleteInstanceAsync</c>.
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
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.FailoverInstance</c> and <c>AlloyDBAdminClient.FailoverInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.FailoverInstance</c> and
        /// <c>AlloyDBAdminClient.FailoverInstanceAsync</c>.
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
        public lro::OperationsSettings FailoverInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.InjectFault</c> and <c>AlloyDBAdminClient.InjectFaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InjectFaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.InjectFault</c> and
        /// <c>AlloyDBAdminClient.InjectFaultAsync</c>.
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
        public lro::OperationsSettings InjectFaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.RestartInstance</c> and <c>AlloyDBAdminClient.RestartInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.RestartInstance</c> and
        /// <c>AlloyDBAdminClient.RestartInstanceAsync</c>.
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
        public lro::OperationsSettings RestartInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ExecuteSql</c> and <c>AlloyDBAdminClient.ExecuteSqlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteSqlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListBackups</c> and <c>AlloyDBAdminClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.GetBackup</c> and <c>AlloyDBAdminClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateBackup</c> and <c>AlloyDBAdminClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.CreateBackup</c> and
        /// <c>AlloyDBAdminClient.CreateBackupAsync</c>.
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
        public lro::OperationsSettings CreateBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.UpdateBackup</c> and <c>AlloyDBAdminClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.UpdateBackup</c> and
        /// <c>AlloyDBAdminClient.UpdateBackupAsync</c>.
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
        public lro::OperationsSettings UpdateBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.DeleteBackup</c> and <c>AlloyDBAdminClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AlloyDBAdminClient.DeleteBackup</c> and
        /// <c>AlloyDBAdminClient.DeleteBackupAsync</c>.
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
        public lro::OperationsSettings DeleteBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListSupportedDatabaseFlags</c> and
        /// <c>AlloyDBAdminClient.ListSupportedDatabaseFlagsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSupportedDatabaseFlagsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.GenerateClientCertificate</c> and <c>AlloyDBAdminClient.GenerateClientCertificateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateClientCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.GetConnectionInfo</c> and <c>AlloyDBAdminClient.GetConnectionInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectionInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListUsers</c> and <c>AlloyDBAdminClient.ListUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUsersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AlloyDBAdminClient.GetUser</c>
        ///  and <c>AlloyDBAdminClient.GetUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.CreateUser</c> and <c>AlloyDBAdminClient.CreateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.UpdateUser</c> and <c>AlloyDBAdminClient.UpdateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.DeleteUser</c> and <c>AlloyDBAdminClient.DeleteUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlloyDBAdminClient.ListDatabases</c> and <c>AlloyDBAdminClient.ListDatabasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatabasesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AlloyDBAdminSettings"/> object.</returns>
        public AlloyDBAdminSettings Clone() => new AlloyDBAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlloyDBAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AlloyDBAdminClientBuilder : gaxgrpc::ClientBuilderBase<AlloyDBAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AlloyDBAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AlloyDBAdminClientBuilder() : base(AlloyDBAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AlloyDBAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AlloyDBAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AlloyDBAdminClient Build()
        {
            AlloyDBAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AlloyDBAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AlloyDBAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AlloyDBAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlloyDBAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AlloyDBAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlloyDBAdminClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlloyDBAdminClient.ChannelPool;
    }

    /// <summary>AlloyDBAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class AlloyDBAdminClient
    {
        /// <summary>
        /// The default endpoint for the AlloyDBAdmin service, which is a host of "alloydb.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "alloydb.googleapis.com:443";

        /// <summary>The default AlloyDBAdmin scopes.</summary>
        /// <remarks>
        /// The default AlloyDBAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AlloyDBAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AlloyDBAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlloyDBAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AlloyDBAdminClient"/>.</returns>
        public static stt::Task<AlloyDBAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AlloyDBAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AlloyDBAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlloyDBAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AlloyDBAdminClient"/>.</returns>
        public static AlloyDBAdminClient Create() => new AlloyDBAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AlloyDBAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AlloyDBAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AlloyDBAdminClient"/>.</returns>
        internal static AlloyDBAdminClient Create(grpccore::CallInvoker callInvoker, AlloyDBAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlloyDBAdmin.AlloyDBAdminClient grpcClient = new AlloyDBAdmin.AlloyDBAdminClient(callInvoker);
            return new AlloyDBAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AlloyDBAdmin client</summary>
        public virtual AlloyDBAdmin.AlloyDBAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Cluster.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with the following format:
        /// * projects/{project}/locations/-
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Cluster.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with the following format:
        /// * projects/{project}/locations/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Cluster.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with the following format:
        /// * projects/{project}/locations/-
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Cluster.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with the following format:
        /// * projects/{project}/locations/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. The resource being created
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Cluster resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                UpdateMask = updateMask,
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Cluster resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                UpdateMask = updateMask,
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Cluster resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeClusterResponse, OperationMetadata> UpgradeCluster(UpgradeClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(UpgradeClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(UpgradeClusterRequest request, st::CancellationToken cancellationToken) =>
            UpgradeClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeCluster</c>.</summary>
        public virtual lro::OperationsClient UpgradeClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpgradeCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpgradeClusterResponse, OperationMetadata> PollOnceUpgradeCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeClusterResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> PollOnceUpgradeClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeClusterResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeClusterOperationsClient, callSettings);

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeClusterResponse, OperationMetadata> UpgradeCluster(string name, DatabaseVersion version, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeCluster(new UpgradeClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Version = version,
            }, callSettings);

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(string name, DatabaseVersion version, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeClusterAsync(new UpgradeClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Version = version,
            }, callSettings);

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(string name, DatabaseVersion version, st::CancellationToken cancellationToken) =>
            UpgradeClusterAsync(name, version, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeClusterResponse, OperationMetadata> UpgradeCluster(ClusterName name, DatabaseVersion version, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeCluster(new UpgradeClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Version = version,
            }, callSettings);

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(ClusterName name, DatabaseVersion version, gaxgrpc::CallSettings callSettings = null) =>
            UpgradeClusterAsync(new UpgradeClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Version = version,
            }, callSettings);

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the cluster.
        /// </param>
        /// <param name="version">
        /// Required. The version the cluster is going to be upgraded to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(ClusterName name, DatabaseVersion version, st::CancellationToken cancellationToken) =>
            UpgradeClusterAsync(name, version, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PromoteCluster(PromoteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(PromoteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(PromoteClusterRequest request, st::CancellationToken cancellationToken) =>
            PromoteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteCluster</c>.</summary>
        public virtual lro::OperationsClient PromoteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOncePromoteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOncePromoteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteClusterOperationsClient, callSettings);

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PromoteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCluster(new PromoteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PromoteClusterAsync(new PromoteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            PromoteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PromoteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCluster(new PromoteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            PromoteClusterAsync(new PromoteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            PromoteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> SwitchoverCluster(SwitchoverClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(SwitchoverClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(SwitchoverClusterRequest request, st::CancellationToken cancellationToken) =>
            SwitchoverClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SwitchoverCluster</c>.</summary>
        public virtual lro::OperationsClient SwitchoverClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SwitchoverCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceSwitchoverCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchoverClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchoverCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceSwitchoverClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchoverClusterOperationsClient, callSettings);

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> SwitchoverCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverCluster(new SwitchoverClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverClusterAsync(new SwitchoverClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(string name, st::CancellationToken cancellationToken) =>
            SwitchoverClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> SwitchoverCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverCluster(new SwitchoverClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverClusterAsync(new SwitchoverClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Cluster.name field
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            SwitchoverClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cluster in a given project and location, with a volume
        /// restored from the provided source, either a backup ID or a point-in-time
        /// and a source cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> RestoreCluster(RestoreClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cluster in a given project and location, with a volume
        /// restored from the provided source, either a backup ID or a point-in-time
        /// and a source cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreClusterAsync(RestoreClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cluster in a given project and location, with a volume
        /// restored from the provided source, either a backup ID or a point-in-time
        /// and a source cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreClusterAsync(RestoreClusterRequest request, st::CancellationToken cancellationToken) =>
            RestoreClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreCluster</c>.</summary>
        public virtual lro::OperationsClient RestoreClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceRestoreCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceRestoreClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateSecondaryCluster(CreateSecondaryClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(CreateSecondaryClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(CreateSecondaryClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateSecondaryClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSecondaryCluster</c>.</summary>
        public virtual lro::OperationsClient CreateSecondaryClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecondaryCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceCreateSecondaryCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecondaryClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecondaryCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceCreateSecondaryClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecondaryClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateSecondaryCluster(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryCluster(new CreateSecondaryClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryClusterAsync(new CreateSecondaryClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(string parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateSecondaryClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateSecondaryCluster(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryCluster(new CreateSecondaryClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryClusterAsync(new CreateSecondaryClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of the new cluster. For the required
        /// format, see the comment on the Cluster.name field.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="clusterId">
        /// Required. ID of the requesting object (the secondary cluster).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateSecondaryClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with one of the following
        /// formats:
        /// * projects/{project}/locations/-/clusters/-
        /// * projects/{project}/locations/{region}/clusters/-
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with one of the following
        /// formats:
        /// * projects/{project}/locations/-/clusters/-
        /// * projects/{project}/locations/{region}/clusters/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with one of the following
        /// formats:
        /// * projects/{project}/locations/-/clusters/-
        /// * projects/{project}/locations/{region}/clusters/-
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field. Additionally, you can perform an
        /// aggregated list operation by specifying a value with one of the following
        /// formats:
        /// * projects/{project}/locations/-/clusters/-
        /// * projects/{project}/locations/{region}/clusters/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(ClusterName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(ClusterName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(ClusterName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateSecondaryInstance(CreateSecondaryInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(CreateSecondaryInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(CreateSecondaryInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateSecondaryInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSecondaryInstance</c>.</summary>
        public virtual lro::OperationsClient CreateSecondaryInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecondaryInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateSecondaryInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecondaryInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecondaryInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateSecondaryInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecondaryInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateSecondaryInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryInstance(new CreateSecondaryInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryInstanceAsync(new CreateSecondaryInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateSecondaryInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateSecondaryInstance(ClusterName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryInstance(new CreateSecondaryInstanceRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(ClusterName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecondaryInstanceAsync(new CreateSecondaryInstanceRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="instance">
        /// Required. The resource being created
        /// </param>
        /// <param name="instanceId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(ClusterName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateSecondaryInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new instances under the given project, location and cluster.
        /// There can be only one primary instance in a cluster. If the primary
        /// instance exists in the cluster as well as this request, then API will
        /// throw an error.
        /// The primary instance should exist before any read pool instance is
        /// created. If the primary instance is a part of the request payload, then
        /// the API will take care of creating instances in the correct order.
        /// This method is here to support Google-internal use cases, and is not meant
        /// for external customers to consume. Please do not start relying on it; its
        /// behavior is subject to change without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchCreateInstancesResponse, OperationMetadata> BatchCreateInstances(BatchCreateInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new instances under the given project, location and cluster.
        /// There can be only one primary instance in a cluster. If the primary
        /// instance exists in the cluster as well as this request, then API will
        /// throw an error.
        /// The primary instance should exist before any read pool instance is
        /// created. If the primary instance is a part of the request payload, then
        /// the API will take care of creating instances in the correct order.
        /// This method is here to support Google-internal use cases, and is not meant
        /// for external customers to consume. Please do not start relying on it; its
        /// behavior is subject to change without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateInstancesResponse, OperationMetadata>> BatchCreateInstancesAsync(BatchCreateInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new instances under the given project, location and cluster.
        /// There can be only one primary instance in a cluster. If the primary
        /// instance exists in the cluster as well as this request, then API will
        /// throw an error.
        /// The primary instance should exist before any read pool instance is
        /// created. If the primary instance is a part of the request payload, then
        /// the API will take care of creating instances in the correct order.
        /// This method is here to support Google-internal use cases, and is not meant
        /// for external customers to consume. Please do not start relying on it; its
        /// behavior is subject to change without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateInstancesResponse, OperationMetadata>> BatchCreateInstancesAsync(BatchCreateInstancesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateInstancesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateInstances</c>.</summary>
        public virtual lro::OperationsClient BatchCreateInstancesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateInstances</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchCreateInstancesResponse, OperationMetadata> PollOnceBatchCreateInstances(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateInstancesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateInstancesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateInstances</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchCreateInstancesResponse, OperationMetadata>> PollOnceBatchCreateInstancesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchCreateInstancesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateInstancesOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public virtual lro::OperationsClient FailoverInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceFailoverInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceFailoverInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> InjectFault(InjectFaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest request, st::CancellationToken cancellationToken) =>
            InjectFaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InjectFault</c>.</summary>
        public virtual lro::OperationsClient InjectFaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InjectFault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceInjectFault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InjectFaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InjectFault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceInjectFaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InjectFaultOperationsClient, callSettings);

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> InjectFault(InjectFaultRequest.Types.FaultType faultType, string name, gaxgrpc::CallSettings callSettings = null) =>
            InjectFault(new InjectFaultRequest
            {
                FaultType = faultType,
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest.Types.FaultType faultType, string name, gaxgrpc::CallSettings callSettings = null) =>
            InjectFaultAsync(new InjectFaultRequest
            {
                FaultType = faultType,
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest.Types.FaultType faultType, string name, st::CancellationToken cancellationToken) =>
            InjectFaultAsync(faultType, name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> InjectFault(InjectFaultRequest.Types.FaultType faultType, InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            InjectFault(new InjectFaultRequest
            {
                FaultType = faultType,
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest.Types.FaultType faultType, InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            InjectFaultAsync(new InjectFaultRequest
            {
                FaultType = faultType,
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="faultType">
        /// Required. The type of fault to be injected in an instance.
        /// </param>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest.Types.FaultType faultType, InstanceName name, st::CancellationToken cancellationToken) =>
            InjectFaultAsync(faultType, name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RestartInstance(RestartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(RestartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(RestartInstanceRequest request, st::CancellationToken cancellationToken) =>
            RestartInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestartInstance</c>.</summary>
        public virtual lro::OperationsClient RestartInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRestartInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRestartInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RestartInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartInstance(new RestartInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartInstanceAsync(new RestartInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            RestartInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RestartInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartInstance(new RestartInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartInstanceAsync(new RestartInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the Instance.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            RestartInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(ExecuteSqlRequest request, st::CancellationToken cancellationToken) =>
            ExecuteSqlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteSqlResponse ExecuteSql(string instance, string database, string user, string sqlStatement, string password, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSql(new ExecuteSqlRequest
            {
                Password = password ?? "",
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                User = gax::GaxPreconditions.CheckNotNullOrEmpty(user, nameof(user)),
                SqlStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(sqlStatement, nameof(sqlStatement)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(string instance, string database, string user, string sqlStatement, string password, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSqlAsync(new ExecuteSqlRequest
            {
                Password = password ?? "",
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                User = gax::GaxPreconditions.CheckNotNullOrEmpty(user, nameof(user)),
                SqlStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(sqlStatement, nameof(sqlStatement)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(string instance, string database, string user, string sqlStatement, string password, st::CancellationToken cancellationToken) =>
            ExecuteSqlAsync(instance, database, user, sqlStatement, password, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteSqlResponse ExecuteSql(InstanceName instance, string database, string user, string sqlStatement, string password, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSql(new ExecuteSqlRequest
            {
                Password = password ?? "",
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                User = gax::GaxPreconditions.CheckNotNullOrEmpty(user, nameof(user)),
                SqlStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(sqlStatement, nameof(sqlStatement)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(InstanceName instance, string database, string user, string sqlStatement, string password, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteSqlAsync(new ExecuteSqlRequest
            {
                Password = password ?? "",
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                User = gax::GaxPreconditions.CheckNotNullOrEmpty(user, nameof(user)),
                SqlStatement = gax::GaxPreconditions.CheckNotNullOrEmpty(sqlStatement, nameof(sqlStatement)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance where the SQL will be executed. For the required
        /// format, see the comment on the Instance.name field.
        /// </param>
        /// <param name="database">
        /// Required. Name of the database where the query will be executed.
        /// Note - Value provided should be the same as expected from `SELECT
        /// current_database();` and NOT as a resource reference.
        /// </param>
        /// <param name="user">
        /// Required. Database user to be used for executing the SQL.
        /// Note - Value provided should be the same as expected from
        /// `SELECT current_user;` and NOT as a resource reference.
        /// </param>
        /// <param name="sqlStatement">
        /// Required. SQL statement to execute on database. Any valid statement is
        /// permitted, including DDL, DML, DQL statements.
        /// </param>
        /// <param name="password">
        /// Optional. The database native user’s password.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(InstanceName instance, string database, string user, string sqlStatement, string password, st::CancellationToken cancellationToken) =>
            ExecuteSqlAsync(instance, database, user, sqlStatement, password, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupsRequest
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupsRequest
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
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public virtual lro::OperationsClient CreateBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> PollOnceCreateBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> PollOnceCreateBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(gagr::LocationName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(gagr::LocationName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backup">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(gagr::LocationName parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBackup</c>.</summary>
        public virtual lro::OperationsClient UpdateBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> PollOnceUpdateBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> PollOnceUpdateBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                UpdateMask = updateMask,
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                UpdateMask = updateMask,
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. For the required format, see the comment on
        /// the Backup.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlags(ListSupportedDatabaseFlagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlagsAsync(ListSupportedDatabaseFlagsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}
        /// 
        /// Regardless of the parent specified here, as long it is contains a valid
        /// project and location, the service will return a static list of supported
        /// flags resources. Note that we do not yet support region-specific
        /// flags.
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
        /// <returns>A pageable sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlags(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
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
            return ListSupportedDatabaseFlags(request, callSettings);
        }

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}
        /// 
        /// Regardless of the parent specified here, as long it is contains a valid
        /// project and location, the service will return a static list of supported
        /// flags resources. Note that we do not yet support region-specific
        /// flags.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlagsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
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
            return ListSupportedDatabaseFlagsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}
        /// 
        /// Regardless of the parent specified here, as long it is contains a valid
        /// project and location, the service will return a static list of supported
        /// flags resources. Note that we do not yet support region-specific
        /// flags.
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
        /// <returns>A pageable sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlags(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
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
            return ListSupportedDatabaseFlags(request, callSettings);
        }

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}
        /// 
        /// Regardless of the parent specified here, as long it is contains a valid
        /// project and location, the service will return a static list of supported
        /// flags resources. Note that we do not yet support region-specific
        /// flags.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlagsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
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
            return ListSupportedDatabaseFlagsAsync(request, callSettings);
        }

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, st::CancellationToken cancellationToken) =>
            GenerateClientCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateClientCertificateResponse GenerateClientCertificate(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateClientCertificate(new GenerateClientCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateClientCertificateAsync(new GenerateClientCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(string parent, st::CancellationToken cancellationToken) =>
            GenerateClientCertificateAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateClientCertificateResponse GenerateClientCertificate(ClusterName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateClientCertificate(new GenerateClientCertificateRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(ClusterName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateClientCertificateAsync(new GenerateClientCertificateRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// * projects/{project}/locations/{location}/clusters/{cluster}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(ClusterName parent, st::CancellationToken cancellationToken) =>
            GenerateClientCertificateAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionInfo GetConnectionInfo(GetConnectionInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(GetConnectionInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(GetConnectionInfoRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionInfo GetConnectionInfo(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionInfo(new GetConnectionInfoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionInfoAsync(new GetConnectionInfoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(string parent, st::CancellationToken cancellationToken) =>
            GetConnectionInfoAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectionInfo GetConnectionInfo(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionInfo(new GetConnectionInfoRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionInfoAsync(new GetConnectionInfoRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource. The required format is:
        /// projects/{project}/locations/{location}/clusters/{cluster}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectionInfo> GetConnectionInfoAsync(InstanceName parent, st::CancellationToken cancellationToken) =>
            GetConnectionInfoAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
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
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
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
            return ListUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListUsersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, st::CancellationToken cancellationToken) =>
            GetUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, st::CancellationToken cancellationToken) =>
            CreateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(string parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(string parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(string parent, User user, string userId, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, userId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(ClusterName parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(ClusterName parent, User user, string userId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserId = gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="user">
        /// Required. The resource being created
        /// </param>
        /// <param name="userId">
        /// Required. ID of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(ClusterName parent, User user, string userId, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, userId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUser(new UpdateUserRequest
            {
                UpdateMask = updateMask,
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserAsync(new UpdateUserRequest
            {
                UpdateMask = updateMask,
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="user">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// User resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(user, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(DeleteUserRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the resource. For the required format, see the
        /// comment on the User.name field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatabasesRequest.
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
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatabasesRequest.
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
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatabasesRequest.
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
        public virtual gax::PagedEnumerable<ListDatabasesResponse, Database> ListDatabases(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatabasesRequest.
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
        public virtual gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
    }

    /// <summary>AlloyDBAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class AlloyDBAdminClientImpl : AlloyDBAdminClient
    {
        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<UpgradeClusterRequest, lro::Operation> _callUpgradeCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<PromoteClusterRequest, lro::Operation> _callPromoteCluster;

        private readonly gaxgrpc::ApiCall<SwitchoverClusterRequest, lro::Operation> _callSwitchoverCluster;

        private readonly gaxgrpc::ApiCall<RestoreClusterRequest, lro::Operation> _callRestoreCluster;

        private readonly gaxgrpc::ApiCall<CreateSecondaryClusterRequest, lro::Operation> _callCreateSecondaryCluster;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<CreateSecondaryInstanceRequest, lro::Operation> _callCreateSecondaryInstance;

        private readonly gaxgrpc::ApiCall<BatchCreateInstancesRequest, lro::Operation> _callBatchCreateInstances;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> _callFailoverInstance;

        private readonly gaxgrpc::ApiCall<InjectFaultRequest, lro::Operation> _callInjectFault;

        private readonly gaxgrpc::ApiCall<RestartInstanceRequest, lro::Operation> _callRestartInstance;

        private readonly gaxgrpc::ApiCall<ExecuteSqlRequest, ExecuteSqlResponse> _callExecuteSql;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<ListSupportedDatabaseFlagsRequest, ListSupportedDatabaseFlagsResponse> _callListSupportedDatabaseFlags;

        private readonly gaxgrpc::ApiCall<GenerateClientCertificateRequest, GenerateClientCertificateResponse> _callGenerateClientCertificate;

        private readonly gaxgrpc::ApiCall<GetConnectionInfoRequest, ConnectionInfo> _callGetConnectionInfo;

        private readonly gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> _callListUsers;

        private readonly gaxgrpc::ApiCall<GetUserRequest, User> _callGetUser;

        private readonly gaxgrpc::ApiCall<CreateUserRequest, User> _callCreateUser;

        private readonly gaxgrpc::ApiCall<UpdateUserRequest, User> _callUpdateUser;

        private readonly gaxgrpc::ApiCall<DeleteUserRequest, wkt::Empty> _callDeleteUser;

        private readonly gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> _callListDatabases;

        /// <summary>
        /// Constructs a client wrapper for the AlloyDBAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlloyDBAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AlloyDBAdminClientImpl(AlloyDBAdmin.AlloyDBAdminClient grpcClient, AlloyDBAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AlloyDBAdminSettings effectiveSettings = settings ?? AlloyDBAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            UpgradeClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeClusterOperationsSettings, logger);
            DeleteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings, logger);
            PromoteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteClusterOperationsSettings, logger);
            SwitchoverClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SwitchoverClusterOperationsSettings, logger);
            RestoreClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreClusterOperationsSettings, logger);
            CreateSecondaryClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSecondaryClusterOperationsSettings, logger);
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            CreateSecondaryInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSecondaryInstanceOperationsSettings, logger);
            BatchCreateInstancesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateInstancesOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            FailoverInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FailoverInstanceOperationsSettings, logger);
            InjectFaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InjectFaultOperationsSettings, logger);
            RestartInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestartInstanceOperationsSettings, logger);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings, logger);
            UpdateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("cluster.name", request => request.Cluster?.Name);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callUpgradeCluster = clientHelper.BuildApiCall<UpgradeClusterRequest, lro::Operation>("UpgradeCluster", grpcClient.UpgradeClusterAsync, grpcClient.UpgradeCluster, effectiveSettings.UpgradeClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeCluster);
            Modify_UpgradeClusterApiCall(ref _callUpgradeCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, lro::Operation>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callPromoteCluster = clientHelper.BuildApiCall<PromoteClusterRequest, lro::Operation>("PromoteCluster", grpcClient.PromoteClusterAsync, grpcClient.PromoteCluster, effectiveSettings.PromoteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPromoteCluster);
            Modify_PromoteClusterApiCall(ref _callPromoteCluster);
            _callSwitchoverCluster = clientHelper.BuildApiCall<SwitchoverClusterRequest, lro::Operation>("SwitchoverCluster", grpcClient.SwitchoverClusterAsync, grpcClient.SwitchoverCluster, effectiveSettings.SwitchoverClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSwitchoverCluster);
            Modify_SwitchoverClusterApiCall(ref _callSwitchoverCluster);
            _callRestoreCluster = clientHelper.BuildApiCall<RestoreClusterRequest, lro::Operation>("RestoreCluster", grpcClient.RestoreClusterAsync, grpcClient.RestoreCluster, effectiveSettings.RestoreClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRestoreCluster);
            Modify_RestoreClusterApiCall(ref _callRestoreCluster);
            _callCreateSecondaryCluster = clientHelper.BuildApiCall<CreateSecondaryClusterRequest, lro::Operation>("CreateSecondaryCluster", grpcClient.CreateSecondaryClusterAsync, grpcClient.CreateSecondaryCluster, effectiveSettings.CreateSecondaryClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecondaryCluster);
            Modify_CreateSecondaryClusterApiCall(ref _callCreateSecondaryCluster);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callCreateSecondaryInstance = clientHelper.BuildApiCall<CreateSecondaryInstanceRequest, lro::Operation>("CreateSecondaryInstance", grpcClient.CreateSecondaryInstanceAsync, grpcClient.CreateSecondaryInstance, effectiveSettings.CreateSecondaryInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecondaryInstance);
            Modify_CreateSecondaryInstanceApiCall(ref _callCreateSecondaryInstance);
            _callBatchCreateInstances = clientHelper.BuildApiCall<BatchCreateInstancesRequest, lro::Operation>("BatchCreateInstances", grpcClient.BatchCreateInstancesAsync, grpcClient.BatchCreateInstances, effectiveSettings.BatchCreateInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateInstances);
            Modify_BatchCreateInstancesApiCall(ref _callBatchCreateInstances);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callFailoverInstance = clientHelper.BuildApiCall<FailoverInstanceRequest, lro::Operation>("FailoverInstance", grpcClient.FailoverInstanceAsync, grpcClient.FailoverInstance, effectiveSettings.FailoverInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFailoverInstance);
            Modify_FailoverInstanceApiCall(ref _callFailoverInstance);
            _callInjectFault = clientHelper.BuildApiCall<InjectFaultRequest, lro::Operation>("InjectFault", grpcClient.InjectFaultAsync, grpcClient.InjectFault, effectiveSettings.InjectFaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInjectFault);
            Modify_InjectFaultApiCall(ref _callInjectFault);
            _callRestartInstance = clientHelper.BuildApiCall<RestartInstanceRequest, lro::Operation>("RestartInstance", grpcClient.RestartInstanceAsync, grpcClient.RestartInstance, effectiveSettings.RestartInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestartInstance);
            Modify_RestartInstanceApiCall(ref _callRestartInstance);
            _callExecuteSql = clientHelper.BuildApiCall<ExecuteSqlRequest, ExecuteSqlResponse>("ExecuteSql", grpcClient.ExecuteSqlAsync, grpcClient.ExecuteSql, effectiveSettings.ExecuteSqlSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callExecuteSql);
            Modify_ExecuteSqlApiCall(ref _callExecuteSql);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, lro::Operation>("CreateBackup", grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, lro::Operation>("UpdateBackup", grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callListSupportedDatabaseFlags = clientHelper.BuildApiCall<ListSupportedDatabaseFlagsRequest, ListSupportedDatabaseFlagsResponse>("ListSupportedDatabaseFlags", grpcClient.ListSupportedDatabaseFlagsAsync, grpcClient.ListSupportedDatabaseFlags, effectiveSettings.ListSupportedDatabaseFlagsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSupportedDatabaseFlags);
            Modify_ListSupportedDatabaseFlagsApiCall(ref _callListSupportedDatabaseFlags);
            _callGenerateClientCertificate = clientHelper.BuildApiCall<GenerateClientCertificateRequest, GenerateClientCertificateResponse>("GenerateClientCertificate", grpcClient.GenerateClientCertificateAsync, grpcClient.GenerateClientCertificate, effectiveSettings.GenerateClientCertificateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateClientCertificate);
            Modify_GenerateClientCertificateApiCall(ref _callGenerateClientCertificate);
            _callGetConnectionInfo = clientHelper.BuildApiCall<GetConnectionInfoRequest, ConnectionInfo>("GetConnectionInfo", grpcClient.GetConnectionInfoAsync, grpcClient.GetConnectionInfo, effectiveSettings.GetConnectionInfoSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetConnectionInfo);
            Modify_GetConnectionInfoApiCall(ref _callGetConnectionInfo);
            _callListUsers = clientHelper.BuildApiCall<ListUsersRequest, ListUsersResponse>("ListUsers", grpcClient.ListUsersAsync, grpcClient.ListUsers, effectiveSettings.ListUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsers);
            Modify_ListUsersApiCall(ref _callListUsers);
            _callGetUser = clientHelper.BuildApiCall<GetUserRequest, User>("GetUser", grpcClient.GetUserAsync, grpcClient.GetUser, effectiveSettings.GetUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUser);
            Modify_GetUserApiCall(ref _callGetUser);
            _callCreateUser = clientHelper.BuildApiCall<CreateUserRequest, User>("CreateUser", grpcClient.CreateUserAsync, grpcClient.CreateUser, effectiveSettings.CreateUserSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUser);
            Modify_CreateUserApiCall(ref _callCreateUser);
            _callUpdateUser = clientHelper.BuildApiCall<UpdateUserRequest, User>("UpdateUser", grpcClient.UpdateUserAsync, grpcClient.UpdateUser, effectiveSettings.UpdateUserSettings).WithGoogleRequestParam("user.name", request => request.User?.Name);
            Modify_ApiCall(ref _callUpdateUser);
            Modify_UpdateUserApiCall(ref _callUpdateUser);
            _callDeleteUser = clientHelper.BuildApiCall<DeleteUserRequest, wkt::Empty>("DeleteUser", grpcClient.DeleteUserAsync, grpcClient.DeleteUser, effectiveSettings.DeleteUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUser);
            Modify_DeleteUserApiCall(ref _callDeleteUser);
            _callListDatabases = clientHelper.BuildApiCall<ListDatabasesRequest, ListDatabasesResponse>("ListDatabases", grpcClient.ListDatabasesAsync, grpcClient.ListDatabases, effectiveSettings.ListDatabasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatabases);
            Modify_ListDatabasesApiCall(ref _callListDatabases);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> call);

        partial void Modify_UpgradeClusterApiCall(ref gaxgrpc::ApiCall<UpgradeClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> call);

        partial void Modify_PromoteClusterApiCall(ref gaxgrpc::ApiCall<PromoteClusterRequest, lro::Operation> call);

        partial void Modify_SwitchoverClusterApiCall(ref gaxgrpc::ApiCall<SwitchoverClusterRequest, lro::Operation> call);

        partial void Modify_RestoreClusterApiCall(ref gaxgrpc::ApiCall<RestoreClusterRequest, lro::Operation> call);

        partial void Modify_CreateSecondaryClusterApiCall(ref gaxgrpc::ApiCall<CreateSecondaryClusterRequest, lro::Operation> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_CreateSecondaryInstanceApiCall(ref gaxgrpc::ApiCall<CreateSecondaryInstanceRequest, lro::Operation> call);

        partial void Modify_BatchCreateInstancesApiCall(ref gaxgrpc::ApiCall<BatchCreateInstancesRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_FailoverInstanceApiCall(ref gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> call);

        partial void Modify_InjectFaultApiCall(ref gaxgrpc::ApiCall<InjectFaultRequest, lro::Operation> call);

        partial void Modify_RestartInstanceApiCall(ref gaxgrpc::ApiCall<RestartInstanceRequest, lro::Operation> call);

        partial void Modify_ExecuteSqlApiCall(ref gaxgrpc::ApiCall<ExecuteSqlRequest, ExecuteSqlResponse> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_ListSupportedDatabaseFlagsApiCall(ref gaxgrpc::ApiCall<ListSupportedDatabaseFlagsRequest, ListSupportedDatabaseFlagsResponse> call);

        partial void Modify_GenerateClientCertificateApiCall(ref gaxgrpc::ApiCall<GenerateClientCertificateRequest, GenerateClientCertificateResponse> call);

        partial void Modify_GetConnectionInfoApiCall(ref gaxgrpc::ApiCall<GetConnectionInfoRequest, ConnectionInfo> call);

        partial void Modify_ListUsersApiCall(ref gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> call);

        partial void Modify_GetUserApiCall(ref gaxgrpc::ApiCall<GetUserRequest, User> call);

        partial void Modify_CreateUserApiCall(ref gaxgrpc::ApiCall<CreateUserRequest, User> call);

        partial void Modify_UpdateUserApiCall(ref gaxgrpc::ApiCall<UpdateUserRequest, User> call);

        partial void Modify_DeleteUserApiCall(ref gaxgrpc::ApiCall<DeleteUserRequest, wkt::Empty> call);

        partial void Modify_ListDatabasesApiCall(ref gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> call);

        partial void OnConstruction(AlloyDBAdmin.AlloyDBAdminClient grpcClient, AlloyDBAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AlloyDBAdmin client</summary>
        public override AlloyDBAdmin.AlloyDBAdminClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeClusterRequest(ref UpgradeClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteClusterRequest(ref PromoteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SwitchoverClusterRequest(ref SwitchoverClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreClusterRequest(ref RestoreClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecondaryClusterRequest(ref CreateSecondaryClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecondaryInstanceRequest(ref CreateSecondaryInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateInstancesRequest(ref BatchCreateInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FailoverInstanceRequest(ref FailoverInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InjectFaultRequest(ref InjectFaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestartInstanceRequest(ref RestartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteSqlRequest(ref ExecuteSqlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSupportedDatabaseFlagsRequest(ref ListSupportedDatabaseFlagsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateClientCertificateRequest(ref GenerateClientCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionInfoRequest(ref GetConnectionInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsersRequest(ref ListUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserRequest(ref GetUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserRequest(ref CreateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserRequest(ref UpdateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserRequest(ref DeleteUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists Clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Cluster.
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
        /// Gets details of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new Cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeCluster</c>.</summary>
        public override lro::OperationsClient UpgradeClusterOperationsClient { get; }

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpgradeClusterResponse, OperationMetadata> UpgradeCluster(UpgradeClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeClusterRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeClusterResponse, OperationMetadata>(_callUpgradeCluster.Sync(request, callSettings), UpgradeClusterOperationsClient);
        }

        /// <summary>
        /// Upgrades a single Cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpgradeClusterResponse, OperationMetadata>> UpgradeClusterAsync(UpgradeClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeClusterRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeClusterResponse, OperationMetadata>(await _callUpgradeCluster.Async(request, callSettings).ConfigureAwait(false), UpgradeClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public override lro::OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single Cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PromoteCluster</c>.</summary>
        public override lro::OperationsClient PromoteClusterOperationsClient { get; }

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> PromoteCluster(PromoteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callPromoteCluster.Sync(request, callSettings), PromoteClusterOperationsClient);
        }

        /// <summary>
        /// Promotes a SECONDARY cluster. This turns down replication
        /// from the PRIMARY cluster and promotes a secondary cluster
        /// into its own standalone cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> PromoteClusterAsync(PromoteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callPromoteCluster.Async(request, callSettings).ConfigureAwait(false), PromoteClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SwitchoverCluster</c>.</summary>
        public override lro::OperationsClient SwitchoverClusterOperationsClient { get; }

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> SwitchoverCluster(SwitchoverClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callSwitchoverCluster.Sync(request, callSettings), SwitchoverClusterOperationsClient);
        }

        /// <summary>
        /// Switches the roles of PRIMARY and SECONDARY clusters without any data loss.
        /// This promotes the SECONDARY cluster to PRIMARY and sets up the original
        /// PRIMARY cluster to replicate from this newly promoted cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> SwitchoverClusterAsync(SwitchoverClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callSwitchoverCluster.Async(request, callSettings).ConfigureAwait(false), SwitchoverClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreCluster</c>.</summary>
        public override lro::OperationsClient RestoreClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new Cluster in a given project and location, with a volume
        /// restored from the provided source, either a backup ID or a point-in-time
        /// and a source cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> RestoreCluster(RestoreClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callRestoreCluster.Sync(request, callSettings), RestoreClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new Cluster in a given project and location, with a volume
        /// restored from the provided source, either a backup ID or a point-in-time
        /// and a source cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> RestoreClusterAsync(RestoreClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callRestoreCluster.Async(request, callSettings).ConfigureAwait(false), RestoreClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSecondaryCluster</c>.</summary>
        public override lro::OperationsClient CreateSecondaryClusterOperationsClient { get; }

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> CreateSecondaryCluster(CreateSecondaryClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecondaryClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callCreateSecondaryCluster.Sync(request, callSettings), CreateSecondaryClusterOperationsClient);
        }

        /// <summary>
        /// Creates a cluster of type SECONDARY in the given location using
        /// the primary cluster as the source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateSecondaryClusterAsync(CreateSecondaryClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecondaryClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callCreateSecondaryCluster.Async(request, callSettings).ConfigureAwait(false), CreateSecondaryClusterOperationsClient);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSecondaryInstance</c>.</summary>
        public override lro::OperationsClient CreateSecondaryInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateSecondaryInstance(CreateSecondaryInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecondaryInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateSecondaryInstance.Sync(request, callSettings), CreateSecondaryInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new SECONDARY Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateSecondaryInstanceAsync(CreateSecondaryInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecondaryInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateSecondaryInstance.Async(request, callSettings).ConfigureAwait(false), CreateSecondaryInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreateInstances</c>.</summary>
        public override lro::OperationsClient BatchCreateInstancesOperationsClient { get; }

        /// <summary>
        /// Creates new instances under the given project, location and cluster.
        /// There can be only one primary instance in a cluster. If the primary
        /// instance exists in the cluster as well as this request, then API will
        /// throw an error.
        /// The primary instance should exist before any read pool instance is
        /// created. If the primary instance is a part of the request payload, then
        /// the API will take care of creating instances in the correct order.
        /// This method is here to support Google-internal use cases, and is not meant
        /// for external customers to consume. Please do not start relying on it; its
        /// behavior is subject to change without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchCreateInstancesResponse, OperationMetadata> BatchCreateInstances(BatchCreateInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateInstancesResponse, OperationMetadata>(_callBatchCreateInstances.Sync(request, callSettings), BatchCreateInstancesOperationsClient);
        }

        /// <summary>
        /// Creates new instances under the given project, location and cluster.
        /// There can be only one primary instance in a cluster. If the primary
        /// instance exists in the cluster as well as this request, then API will
        /// throw an error.
        /// The primary instance should exist before any read pool instance is
        /// created. If the primary instance is a part of the request payload, then
        /// the API will take care of creating instances in the correct order.
        /// This method is here to support Google-internal use cases, and is not meant
        /// for external customers to consume. Please do not start relying on it; its
        /// behavior is subject to change without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchCreateInstancesResponse, OperationMetadata>> BatchCreateInstancesAsync(BatchCreateInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateInstancesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchCreateInstancesResponse, OperationMetadata>(await _callBatchCreateInstances.Async(request, callSettings).ConfigureAwait(false), BatchCreateInstancesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public override lro::OperationsClient FailoverInstanceOperationsClient { get; }

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callFailoverInstance.Sync(request, callSettings), FailoverInstanceOperationsClient);
        }

        /// <summary>
        /// Forces a Failover for a highly available instance.
        /// Failover promotes the HA standby instance as the new primary.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callFailoverInstance.Async(request, callSettings).ConfigureAwait(false), FailoverInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>InjectFault</c>.</summary>
        public override lro::OperationsClient InjectFaultOperationsClient { get; }

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> InjectFault(InjectFaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InjectFaultRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callInjectFault.Sync(request, callSettings), InjectFaultOperationsClient);
        }

        /// <summary>
        /// Injects fault in an instance.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> InjectFaultAsync(InjectFaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InjectFaultRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callInjectFault.Async(request, callSettings).ConfigureAwait(false), InjectFaultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestartInstance</c>.</summary>
        public override lro::OperationsClient RestartInstanceOperationsClient { get; }

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RestartInstance(RestartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRestartInstance.Sync(request, callSettings), RestartInstanceOperationsClient);
        }

        /// <summary>
        /// Restart an Instance in a cluster.
        /// Imperative only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RestartInstanceAsync(RestartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRestartInstance.Async(request, callSettings).ConfigureAwait(false), RestartInstanceOperationsClient);
        }

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes a SQL statement in a database inside an AlloyDB instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteSqlResponse> ExecuteSqlAsync(ExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Lists Backups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public override lro::OperationsClient CreateBackupOperationsClient { get; }

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(_callCreateBackup.Sync(request, callSettings), CreateBackupOperationsClient);
        }

        /// <summary>
        /// Creates a new Backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callCreateBackup.Async(request, callSettings).ConfigureAwait(false), CreateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBackup</c>.</summary>
        public override lro::OperationsClient UpdateBackupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(_callUpdateBackup.Sync(request, callSettings), UpdateBackupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callUpdateBackup.Async(request, callSettings).ConfigureAwait(false), UpdateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackup.Sync(request, callSettings), DeleteBackupOperationsClient);
        }

        /// <summary>
        /// Deletes a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public override gax::PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlags(ListSupportedDatabaseFlagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSupportedDatabaseFlagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSupportedDatabaseFlagsRequest, ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag>(_callListSupportedDatabaseFlags, request, callSettings);
        }

        /// <summary>
        /// Lists SupportedDatabaseFlags for a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SupportedDatabaseFlag"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> ListSupportedDatabaseFlagsAsync(ListSupportedDatabaseFlagsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSupportedDatabaseFlagsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSupportedDatabaseFlagsRequest, ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag>(_callListSupportedDatabaseFlags, request, callSettings);
        }

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateClientCertificateRequest(ref request, ref callSettings);
            return _callGenerateClientCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate a client certificate signed by a Cluster CA.
        /// The sole purpose of this endpoint is to support AlloyDB connectors and the
        /// Auth Proxy client. The endpoint's behavior is subject to change without
        /// notice, so do not rely on its behavior remaining constant. Future changes
        /// will not break AlloyDB connectors or the Auth Proxy client.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateClientCertificateRequest(ref request, ref callSettings);
            return _callGenerateClientCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectionInfo GetConnectionInfo(GetConnectionInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionInfoRequest(ref request, ref callSettings);
            return _callGetConnectionInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Get instance metadata used for a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectionInfo> GetConnectionInfoAsync(GetConnectionInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionInfoRequest(ref request, ref callSettings);
            return _callGetConnectionInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Lists Users in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return _callCreateUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new User in a given project, location, and cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return _callCreateUser.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return _callUpdateUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return _callUpdateUser.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            _callDeleteUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single User.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            return _callDeleteUser.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Databases in a given project and location.
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
        /// Lists Databases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Database"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatabasesResponse, Database> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatabasesRequest, ListDatabasesResponse, Database>(_callListDatabases, request, callSettings);
        }
    }

    public partial class ListClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSupportedDatabaseFlagsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatabasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClustersResponse : gaxgrpc::IPageResponse<Cluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSupportedDatabaseFlagsResponse : gaxgrpc::IPageResponse<SupportedDatabaseFlag>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SupportedDatabaseFlag> GetEnumerator() => SupportedDatabaseFlags.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUsersResponse : gaxgrpc::IPageResponse<User>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<User> GetEnumerator() => Users.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatabasesResponse : gaxgrpc::IPageResponse<Database>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Database> GetEnumerator() => Databases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AlloyDBAdmin
    {
        public partial class AlloyDBAdminClient
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

    public static partial class AlloyDBAdmin
    {
        public partial class AlloyDBAdminClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
