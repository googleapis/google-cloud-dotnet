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

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Settings for <see cref="BackupDRClient"/> instances.</summary>
    public sealed partial class BackupDRSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackupDRSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackupDRSettings"/>.</returns>
        public static BackupDRSettings GetDefault() => new BackupDRSettings();

        /// <summary>Constructs a new <see cref="BackupDRSettings"/> object with default settings.</summary>
        public BackupDRSettings()
        {
        }

        private BackupDRSettings(BackupDRSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListManagementServersSettings = existing.ListManagementServersSettings;
            GetManagementServerSettings = existing.GetManagementServerSettings;
            CreateManagementServerSettings = existing.CreateManagementServerSettings;
            CreateManagementServerOperationsSettings = existing.CreateManagementServerOperationsSettings.Clone();
            DeleteManagementServerSettings = existing.DeleteManagementServerSettings;
            DeleteManagementServerOperationsSettings = existing.DeleteManagementServerOperationsSettings.Clone();
            CreateBackupVaultSettings = existing.CreateBackupVaultSettings;
            CreateBackupVaultOperationsSettings = existing.CreateBackupVaultOperationsSettings.Clone();
            ListBackupVaultsSettings = existing.ListBackupVaultsSettings;
            FetchUsableBackupVaultsSettings = existing.FetchUsableBackupVaultsSettings;
            GetBackupVaultSettings = existing.GetBackupVaultSettings;
            UpdateBackupVaultSettings = existing.UpdateBackupVaultSettings;
            UpdateBackupVaultOperationsSettings = existing.UpdateBackupVaultOperationsSettings.Clone();
            DeleteBackupVaultSettings = existing.DeleteBackupVaultSettings;
            DeleteBackupVaultOperationsSettings = existing.DeleteBackupVaultOperationsSettings.Clone();
            ListDataSourcesSettings = existing.ListDataSourcesSettings;
            GetDataSourceSettings = existing.GetDataSourceSettings;
            UpdateDataSourceSettings = existing.UpdateDataSourceSettings;
            UpdateDataSourceOperationsSettings = existing.UpdateDataSourceOperationsSettings.Clone();
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            UpdateBackupSettings = existing.UpdateBackupSettings;
            UpdateBackupOperationsSettings = existing.UpdateBackupOperationsSettings.Clone();
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            RestoreBackupSettings = existing.RestoreBackupSettings;
            RestoreBackupOperationsSettings = existing.RestoreBackupOperationsSettings.Clone();
            CreateBackupPlanSettings = existing.CreateBackupPlanSettings;
            CreateBackupPlanOperationsSettings = existing.CreateBackupPlanOperationsSettings.Clone();
            GetBackupPlanSettings = existing.GetBackupPlanSettings;
            ListBackupPlansSettings = existing.ListBackupPlansSettings;
            DeleteBackupPlanSettings = existing.DeleteBackupPlanSettings;
            DeleteBackupPlanOperationsSettings = existing.DeleteBackupPlanOperationsSettings.Clone();
            CreateBackupPlanAssociationSettings = existing.CreateBackupPlanAssociationSettings;
            CreateBackupPlanAssociationOperationsSettings = existing.CreateBackupPlanAssociationOperationsSettings.Clone();
            GetBackupPlanAssociationSettings = existing.GetBackupPlanAssociationSettings;
            ListBackupPlanAssociationsSettings = existing.ListBackupPlanAssociationsSettings;
            DeleteBackupPlanAssociationSettings = existing.DeleteBackupPlanAssociationSettings;
            DeleteBackupPlanAssociationOperationsSettings = existing.DeleteBackupPlanAssociationOperationsSettings.Clone();
            TriggerBackupSettings = existing.TriggerBackupSettings;
            TriggerBackupOperationsSettings = existing.TriggerBackupOperationsSettings.Clone();
            InitializeServiceSettings = existing.InitializeServiceSettings;
            InitializeServiceOperationsSettings = existing.InitializeServiceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BackupDRSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListManagementServers</c> and <c>BackupDRClient.ListManagementServersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListManagementServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetManagementServer</c> and <c>BackupDRClient.GetManagementServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetManagementServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.CreateManagementServer</c> and <c>BackupDRClient.CreateManagementServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateManagementServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.CreateManagementServer</c> and
        /// <c>BackupDRClient.CreateManagementServerAsync</c>.
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
        public lro::OperationsSettings CreateManagementServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.DeleteManagementServer</c> and <c>BackupDRClient.DeleteManagementServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteManagementServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteManagementServer</c> and
        /// <c>BackupDRClient.DeleteManagementServerAsync</c>.
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
        public lro::OperationsSettings DeleteManagementServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.CreateBackupVault</c> and <c>BackupDRClient.CreateBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupVaultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.CreateBackupVault</c> and
        /// <c>BackupDRClient.CreateBackupVaultAsync</c>.
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
        public lro::OperationsSettings CreateBackupVaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListBackupVaults</c> and <c>BackupDRClient.ListBackupVaultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupVaultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.FetchUsableBackupVaults</c> and <c>BackupDRClient.FetchUsableBackupVaultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchUsableBackupVaultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetBackupVault</c> and <c>BackupDRClient.GetBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupVaultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.UpdateBackupVault</c> and <c>BackupDRClient.UpdateBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.UpdateBackupVault</c> and
        /// <c>BackupDRClient.UpdateBackupVaultAsync</c>.
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
        public lro::OperationsSettings UpdateBackupVaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.DeleteBackupVault</c> and <c>BackupDRClient.DeleteBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupVaultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteBackupVault</c> and
        /// <c>BackupDRClient.DeleteBackupVaultAsync</c>.
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
        public lro::OperationsSettings DeleteBackupVaultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListDataSources</c> and <c>BackupDRClient.ListDataSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetDataSource</c> and <c>BackupDRClient.GetDataSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.UpdateDataSource</c> and <c>BackupDRClient.UpdateDataSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.UpdateDataSource</c> and
        /// <c>BackupDRClient.UpdateDataSourceAsync</c>.
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
        public lro::OperationsSettings UpdateDataSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackupDRClient.ListBackups</c>
        ///  and <c>BackupDRClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackupDRClient.GetBackup</c>
        ///  and <c>BackupDRClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackupDRClient.UpdateBackup</c>
        ///  and <c>BackupDRClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.UpdateBackup</c> and
        /// <c>BackupDRClient.UpdateBackupAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BackupDRClient.DeleteBackup</c>
        ///  and <c>BackupDRClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteBackup</c> and
        /// <c>BackupDRClient.DeleteBackupAsync</c>.
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
        /// <c>BackupDRClient.RestoreBackup</c> and <c>BackupDRClient.RestoreBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.RestoreBackup</c> and
        /// <c>BackupDRClient.RestoreBackupAsync</c>.
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
        public lro::OperationsSettings RestoreBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.CreateBackupPlan</c> and <c>BackupDRClient.CreateBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.CreateBackupPlan</c> and
        /// <c>BackupDRClient.CreateBackupPlanAsync</c>.
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
        public lro::OperationsSettings CreateBackupPlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetBackupPlan</c> and <c>BackupDRClient.GetBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListBackupPlans</c> and <c>BackupDRClient.ListBackupPlansAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupPlansSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.DeleteBackupPlan</c> and <c>BackupDRClient.DeleteBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteBackupPlan</c> and
        /// <c>BackupDRClient.DeleteBackupPlanAsync</c>.
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
        public lro::OperationsSettings DeleteBackupPlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.CreateBackupPlanAssociation</c> and <c>BackupDRClient.CreateBackupPlanAssociationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupPlanAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.CreateBackupPlanAssociation</c> and
        /// <c>BackupDRClient.CreateBackupPlanAssociationAsync</c>.
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
        public lro::OperationsSettings CreateBackupPlanAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetBackupPlanAssociation</c> and <c>BackupDRClient.GetBackupPlanAssociationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupPlanAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListBackupPlanAssociations</c> and <c>BackupDRClient.ListBackupPlanAssociationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupPlanAssociationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.DeleteBackupPlanAssociation</c> and <c>BackupDRClient.DeleteBackupPlanAssociationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupPlanAssociationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteBackupPlanAssociation</c> and
        /// <c>BackupDRClient.DeleteBackupPlanAssociationAsync</c>.
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
        public lro::OperationsSettings DeleteBackupPlanAssociationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.TriggerBackup</c> and <c>BackupDRClient.TriggerBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TriggerBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.TriggerBackup</c> and
        /// <c>BackupDRClient.TriggerBackupAsync</c>.
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
        public lro::OperationsSettings TriggerBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.InitializeService</c> and <c>BackupDRClient.InitializeServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InitializeServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.InitializeService</c> and
        /// <c>BackupDRClient.InitializeServiceAsync</c>.
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
        public lro::OperationsSettings InitializeServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BackupDRSettings"/> object.</returns>
        public BackupDRSettings Clone() => new BackupDRSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackupDRClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BackupDRClientBuilder : gaxgrpc::ClientBuilderBase<BackupDRClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackupDRSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BackupDRClientBuilder() : base(BackupDRClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BackupDRClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackupDRClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackupDRClient Build()
        {
            BackupDRClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackupDRClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackupDRClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackupDRClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackupDRClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BackupDRClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackupDRClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackupDRClient.ChannelPool;
    }

    /// <summary>BackupDR client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The BackupDR Service
    /// </remarks>
    public abstract partial class BackupDRClient
    {
        /// <summary>
        /// The default endpoint for the BackupDR service, which is a host of "backupdr.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "backupdr.googleapis.com:443";

        /// <summary>The default BackupDR scopes.</summary>
        /// <remarks>
        /// The default BackupDR scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BackupDR.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BackupDRClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BackupDRClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackupDRClient"/>.</returns>
        public static stt::Task<BackupDRClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackupDRClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackupDRClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BackupDRClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackupDRClient"/>.</returns>
        public static BackupDRClient Create() => new BackupDRClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackupDRClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackupDRSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BackupDRClient"/>.</returns>
        internal static BackupDRClient Create(grpccore::CallInvoker callInvoker, BackupDRSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackupDR.BackupDRClient grpcClient = new BackupDR.BackupDRClient(callInvoker);
            return new BackupDRClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BackupDR client</summary>
        public virtual BackupDR.BackupDRClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud BackupDR, locations map to Google Cloud regions, for example
        /// **us-central1**. To retrieve management servers for all locations, use "-"
        /// for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServers(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud BackupDR, locations map to Google Cloud regions, for example
        /// **us-central1**. To retrieve management servers for all locations, use "-"
        /// for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud BackupDR, locations map to Google Cloud regions, for example
        /// **us-central1**. To retrieve management servers for all locations, use "-"
        /// for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServers(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud BackupDR, locations map to Google Cloud regions, for example
        /// **us-central1**. To retrieve management servers for all locations, use "-"
        /// for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServer(new GetManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServerAsync(new GetManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServer(new GetManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServerAsync(new GetManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// 'projects/{project_id}/locations/{location}/managementServers/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(ManagementServerName name, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateManagementServer</c>.</summary>
        public virtual lro::OperationsClient CreateManagementServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> PollOnceCreateManagementServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagementServer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> PollOnceCreateManagementServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagementServer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(string parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServer(new CreateManagementServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(string parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServerAsync(new CreateManagementServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(string parent, ManagementServer managementServer, string managementServerId, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(parent, managementServer, managementServerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServer(new CreateManagementServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServerAsync(new CreateManagementServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(parent, managementServer, managementServerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteManagementServer</c>.</summary>
        public virtual lro::OperationsClient DeleteManagementServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteManagementServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteManagementServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServer(new DeleteManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServerAsync(new DeleteManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServer(new DeleteManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServerAsync(new DeleteManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(ManagementServerName name, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> CreateBackupVault(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(CreateBackupVaultRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackupVault</c>.</summary>
        public virtual lro::OperationsClient CreateBackupVaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBackupVault</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> PollOnceCreateBackupVault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupVault, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackupVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> PollOnceCreateBackupVaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupVault, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> CreateBackupVault(string parent, BackupVault backupVault, string backupVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupVault(new CreateBackupVaultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(string parent, BackupVault backupVault, string backupVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupVaultAsync(new CreateBackupVaultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(string parent, BackupVault backupVault, string backupVaultId, st::CancellationToken cancellationToken) =>
            CreateBackupVaultAsync(parent, backupVault, backupVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> CreateBackupVault(gagr::LocationName parent, BackupVault backupVault, string backupVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupVault(new CreateBackupVaultRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(gagr::LocationName parent, BackupVault backupVault, string backupVaultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupVaultAsync(new CreateBackupVaultRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupVaultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupVaultId, nameof(backupVaultId)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="backupVault">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupVaultId">
        /// Required. ID of the requesting object
        /// If auto-generating ID server-side, remove this field and
        /// backup_vault_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(gagr::LocationName parent, BackupVault backupVault, string backupVaultId, st::CancellationToken cancellationToken) =>
            CreateBackupVaultAsync(parent, backupVault, backupVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaults(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
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
            return ListBackupVaults(request, callSettings);
        }

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
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
            return ListBackupVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaults(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
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
            return ListBackupVaults(request, callSettings);
        }

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
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
            return ListBackupVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaults(FetchUsableBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaultsAsync(FetchUsableBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
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
            return FetchUsableBackupVaults(request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
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
            return FetchUsableBackupVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaults(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
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
            return FetchUsableBackupVaults(request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backupvault stores
        /// information, in the format 'projects/{project_id}/locations/{location}'. In
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
        /// To retrieve backupvault stores for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaultsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
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
            return FetchUsableBackupVaultsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVault(new GetBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVaultAsync(new GetBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVault(new GetBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVaultAsync(new GetBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backupvault store resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(BackupVaultName name, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> UpdateBackupVault(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(UpdateBackupVaultRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBackupVault</c>.</summary>
        public virtual lro::OperationsClient UpdateBackupVaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBackupVault</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> PollOnceUpdateBackupVault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupVault, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackupVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> PollOnceUpdateBackupVaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupVault, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// BackupVault resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> UpdateBackupVault(BackupVault backupVault, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupVault(new UpdateBackupVaultRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// BackupVault resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(BackupVault backupVault, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupVaultAsync(new UpdateBackupVaultRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                BackupVault = gax::GaxPreconditions.CheckNotNull(backupVault, nameof(backupVault)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// BackupVault resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(BackupVault backupVault, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupVaultAsync(backupVault, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackupVault</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupVaultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBackupVault</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackupVault(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackupVault</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupVaultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupVaultOperationsClient, callSettings);

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVault(new DeleteBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVaultAsync(new DeleteBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVault(new DeleteBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVaultAsync(new DeleteBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(BackupVaultName name, st::CancellationToken cancellationToken) =>
            DeleteBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve data
        /// sources information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve data
        /// sources information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve data
        /// sources information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(BackupVaultName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsBackupVaultName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve data
        /// sources information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(BackupVaultName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsBackupVaultName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{resource_name}/dataSource/{resource_name}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataSource, OperationMetadata> UpdateDataSource(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataSource, OperationMetadata>> UpdateDataSourceAsync(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataSource, OperationMetadata>> UpdateDataSourceAsync(UpdateDataSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataSource</c>.</summary>
        public virtual lro::OperationsClient UpdateDataSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataSource, OperationMetadata> PollOnceUpdateDataSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataSource, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataSource, OperationMetadata>> PollOnceUpdateDataSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataSource, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataSourceOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// DataSource resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataSource, OperationMetadata> UpdateDataSource(DataSource dataSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSource(new UpdateDataSourceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// DataSource resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataSource, OperationMetadata>> UpdateDataSourceAsync(DataSource dataSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSourceAsync(new UpdateDataSourceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// DataSource resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataSource, OperationMetadata>> UpdateDataSourceAsync(DataSource dataSource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataSourceAsync(dataSource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(DataSourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsDataSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// 'projects/{project_id}/locations/{location}'. In Cloud Backup and DR,
        /// locations map to Google Cloud regions, for example **us-central1**.
        /// To retrieve data sources for all locations, use "-" for the
        /// '{location}' value.
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(DataSourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsDataSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the data source resource name, in the format
        /// 'projects/{project_id}/locations/{location}/backupVaults/{backupVault}/dataSources/{datasource}/backups/{backup}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a Backup.
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
        /// Updates the settings of a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Backup, OperationMetadata> PollOnceDeleteBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> PollOnceDeleteBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreBackupResponse, OperationMetadata> RestoreBackup(RestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(RestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(RestoreBackupRequest request, st::CancellationToken cancellationToken) =>
            RestoreBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreBackup</c>.</summary>
        public virtual lro::OperationsClient RestoreBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RestoreBackupResponse, OperationMetadata> PollOnceRestoreBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestoreBackupResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> PollOnceRestoreBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestoreBackupResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreBackupOperationsClient, callSettings);

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreBackupResponse, OperationMetadata> RestoreBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreBackup(new RestoreBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreBackupAsync(new RestoreBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(string name, st::CancellationToken cancellationToken) =>
            RestoreBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestoreBackupResponse, OperationMetadata> RestoreBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreBackup(new RestoreBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreBackupAsync(new RestoreBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Backup instance, in the format
        /// 'projects/*/locations/*/backupVaults/*/dataSources/*/backups/'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            RestoreBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(CreateBackupPlanRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackupPlan</c>.</summary>
        public virtual lro::OperationsClient CreateBackupPlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> PollOnceCreateBackupPlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> PollOnceCreateBackupPlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(string parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlan(new CreateBackupPlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(string parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAsync(new CreateBackupPlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(string parent, BackupPlan backupPlan, string backupPlanId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAsync(parent, backupPlan, backupPlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlan(new CreateBackupPlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAsync(new CreateBackupPlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="parent">
        /// Required. The `BackupPlan` project and location in the format
        /// `projects/{project}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlan">
        /// Required. The `BackupPlan` resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The name of the `BackupPlan` to create. The name must be unique
        /// for the specified project and location.The name must start with a lowercase
        /// letter followed by up to 62 lowercase letters, numbers, or hyphens.
        /// Pattern, /[a-z][a-z0-9-]{,62}/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAsync(parent, backupPlan, backupPlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlan(new GetBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAsync(new GetBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlan(new GetBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAsync(new GetBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(BackupPlanName name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlans(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve `BackupPlans`
        /// information. Format: `projects/{project}/locations/{location}`. In Cloud
        /// BackupDR, locations map to GCP regions, for e.g. **us-central1**. To
        /// retrieve backup plans for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlans(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlansRequest request = new ListBackupPlansRequest
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
            return ListBackupPlans(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve `BackupPlans`
        /// information. Format: `projects/{project}/locations/{location}`. In Cloud
        /// BackupDR, locations map to GCP regions, for e.g. **us-central1**. To
        /// retrieve backup plans for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlansRequest request = new ListBackupPlansRequest
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
            return ListBackupPlansAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve `BackupPlans`
        /// information. Format: `projects/{project}/locations/{location}`. In Cloud
        /// BackupDR, locations map to GCP regions, for e.g. **us-central1**. To
        /// retrieve backup plans for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlans(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlansRequest request = new ListBackupPlansRequest
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
            return ListBackupPlans(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve `BackupPlans`
        /// information. Format: `projects/{project}/locations/{location}`. In Cloud
        /// BackupDR, locations map to GCP regions, for e.g. **us-central1**. To
        /// retrieve backup plans for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlansRequest request = new ListBackupPlansRequest
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
            return ListBackupPlansAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackupPlan</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupPlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackupPlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupPlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlan(new DeleteBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAsync(new DeleteBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlan(new DeleteBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAsync(new DeleteBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BackupPlan` to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/backupPlans/{backup_plan}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(BackupPlanName name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> CreateBackupPlanAssociation(CreateBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(CreateBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(CreateBackupPlanAssociationRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackupPlanAssociation</c>.</summary>
        public virtual lro::OperationsClient CreateBackupPlanAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackupPlanAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> PollOnceCreateBackupPlanAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlanAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPlanAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackupPlanAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> PollOnceCreateBackupPlanAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlanAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPlanAssociationOperationsClient, callSettings);

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> CreateBackupPlanAssociation(string parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAssociation(new CreateBackupPlanAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlanAssociationId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)),
                BackupPlanAssociation = gax::GaxPreconditions.CheckNotNull(backupPlanAssociation, nameof(backupPlanAssociation)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(string parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAssociationAsync(new CreateBackupPlanAssociationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlanAssociationId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)),
                BackupPlanAssociation = gax::GaxPreconditions.CheckNotNull(backupPlanAssociation, nameof(backupPlanAssociation)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(string parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAssociationAsync(parent, backupPlanAssociation, backupPlanAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> CreateBackupPlanAssociation(gagr::LocationName parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAssociation(new CreateBackupPlanAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlanAssociationId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)),
                BackupPlanAssociation = gax::GaxPreconditions.CheckNotNull(backupPlanAssociation, nameof(backupPlanAssociation)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(gagr::LocationName parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAssociationAsync(new CreateBackupPlanAssociationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlanAssociationId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanAssociationId, nameof(backupPlanAssociationId)),
                BackupPlanAssociation = gax::GaxPreconditions.CheckNotNull(backupPlanAssociation, nameof(backupPlanAssociation)),
            }, callSettings);

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="parent">
        /// Required. The backup plan association project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR locations
        /// map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="backupPlanAssociation">
        /// Required. The resource being created
        /// </param>
        /// <param name="backupPlanAssociationId">
        /// Required. The name of the backup plan association to create. The name must
        /// be unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(gagr::LocationName parent, BackupPlanAssociation backupPlanAssociation, string backupPlanAssociationId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAssociationAsync(parent, backupPlanAssociation, backupPlanAssociationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlanAssociation GetBackupPlanAssociation(GetBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(GetBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(GetBackupPlanAssociationRequest request, st::CancellationToken cancellationToken) =>
            GetBackupPlanAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlanAssociation GetBackupPlanAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAssociation(new GetBackupPlanAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAssociationAsync(new GetBackupPlanAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlanAssociation GetBackupPlanAssociation(BackupPlanAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAssociation(new GetBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(BackupPlanAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAssociationAsync(new GetBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(BackupPlanAssociationName name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociations(ListBackupPlanAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociationsAsync(ListBackupPlanAssociationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup Plan
        /// Associations information, in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations
        /// map to GCP regions, for example **us-central1**. To retrieve backup plan
        /// associations for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
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
            return ListBackupPlanAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup Plan
        /// Associations information, in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations
        /// map to GCP regions, for example **us-central1**. To retrieve backup plan
        /// associations for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
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
            return ListBackupPlanAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup Plan
        /// Associations information, in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations
        /// map to GCP regions, for example **us-central1**. To retrieve backup plan
        /// associations for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
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
            return ListBackupPlanAssociations(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup Plan
        /// Associations information, in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud BackupDR, locations
        /// map to GCP regions, for example **us-central1**. To retrieve backup plan
        /// associations for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
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
            return ListBackupPlanAssociationsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlanAssociation(DeleteBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(DeleteBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(DeleteBackupPlanAssociationRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAssociationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackupPlanAssociation</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupPlanAssociationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackupPlanAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackupPlanAssociation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPlanAssociationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackupPlanAssociation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupPlanAssociationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPlanAssociationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlanAssociation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAssociation(new DeleteBackupPlanAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAssociationAsync(new DeleteBackupPlanAssociationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlanAssociation(BackupPlanAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAssociation(new DeleteBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(BackupPlanAssociationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAssociationAsync(new DeleteBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(BackupPlanAssociationName name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAssociationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> TriggerBackup(TriggerBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(TriggerBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(TriggerBackupRequest request, st::CancellationToken cancellationToken) =>
            TriggerBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TriggerBackup</c>.</summary>
        public virtual lro::OperationsClient TriggerBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TriggerBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> PollOnceTriggerBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlanAssociation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TriggerBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TriggerBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> PollOnceTriggerBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlanAssociation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TriggerBackupOperationsClient, callSettings);

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> TriggerBackup(string name, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            TriggerBackup(new TriggerBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)),
            }, callSettings);

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(string name, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            TriggerBackupAsync(new TriggerBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)),
            }, callSettings);

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(string name, string ruleId, st::CancellationToken cancellationToken) =>
            TriggerBackupAsync(name, ruleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlanAssociation, OperationMetadata> TriggerBackup(BackupPlanAssociationName name, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            TriggerBackup(new TriggerBackupRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)),
            }, callSettings);

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(BackupPlanAssociationName name, string ruleId, gaxgrpc::CallSettings callSettings = null) =>
            TriggerBackupAsync(new TriggerBackupRequest
            {
                BackupPlanAssociationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RuleId = gax::GaxPreconditions.CheckNotNullOrEmpty(ruleId, nameof(ruleId)),
            }, callSettings);

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup plan association resource, in the format
        /// `projects/{project}/locations/{location}/backupPlanAssociations/{backupPlanAssociationId}`
        /// </param>
        /// <param name="ruleId">
        /// Required. backup rule_id for which a backup needs to be triggered.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(BackupPlanAssociationName name, string ruleId, st::CancellationToken cancellationToken) =>
            TriggerBackupAsync(name, ruleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initializes the service related config for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InitializeServiceResponse, OperationMetadata> InitializeService(InitializeServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes the service related config for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeServiceResponse, OperationMetadata>> InitializeServiceAsync(InitializeServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes the service related config for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeServiceResponse, OperationMetadata>> InitializeServiceAsync(InitializeServiceRequest request, st::CancellationToken cancellationToken) =>
            InitializeServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InitializeService</c>.</summary>
        public virtual lro::OperationsClient InitializeServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InitializeService</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InitializeServiceResponse, OperationMetadata> PollOnceInitializeService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeServiceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InitializeService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InitializeServiceResponse, OperationMetadata>> PollOnceInitializeServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeServiceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeServiceOperationsClient, callSettings);
    }

    /// <summary>BackupDR client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The BackupDR Service
    /// </remarks>
    public sealed partial class BackupDRClientImpl : BackupDRClient
    {
        private readonly gaxgrpc::ApiCall<ListManagementServersRequest, ListManagementServersResponse> _callListManagementServers;

        private readonly gaxgrpc::ApiCall<GetManagementServerRequest, ManagementServer> _callGetManagementServer;

        private readonly gaxgrpc::ApiCall<CreateManagementServerRequest, lro::Operation> _callCreateManagementServer;

        private readonly gaxgrpc::ApiCall<DeleteManagementServerRequest, lro::Operation> _callDeleteManagementServer;

        private readonly gaxgrpc::ApiCall<CreateBackupVaultRequest, lro::Operation> _callCreateBackupVault;

        private readonly gaxgrpc::ApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse> _callListBackupVaults;

        private readonly gaxgrpc::ApiCall<FetchUsableBackupVaultsRequest, FetchUsableBackupVaultsResponse> _callFetchUsableBackupVaults;

        private readonly gaxgrpc::ApiCall<GetBackupVaultRequest, BackupVault> _callGetBackupVault;

        private readonly gaxgrpc::ApiCall<UpdateBackupVaultRequest, lro::Operation> _callUpdateBackupVault;

        private readonly gaxgrpc::ApiCall<DeleteBackupVaultRequest, lro::Operation> _callDeleteBackupVault;

        private readonly gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> _callListDataSources;

        private readonly gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> _callGetDataSource;

        private readonly gaxgrpc::ApiCall<UpdateDataSourceRequest, lro::Operation> _callUpdateDataSource;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<RestoreBackupRequest, lro::Operation> _callRestoreBackup;

        private readonly gaxgrpc::ApiCall<CreateBackupPlanRequest, lro::Operation> _callCreateBackupPlan;

        private readonly gaxgrpc::ApiCall<GetBackupPlanRequest, BackupPlan> _callGetBackupPlan;

        private readonly gaxgrpc::ApiCall<ListBackupPlansRequest, ListBackupPlansResponse> _callListBackupPlans;

        private readonly gaxgrpc::ApiCall<DeleteBackupPlanRequest, lro::Operation> _callDeleteBackupPlan;

        private readonly gaxgrpc::ApiCall<CreateBackupPlanAssociationRequest, lro::Operation> _callCreateBackupPlanAssociation;

        private readonly gaxgrpc::ApiCall<GetBackupPlanAssociationRequest, BackupPlanAssociation> _callGetBackupPlanAssociation;

        private readonly gaxgrpc::ApiCall<ListBackupPlanAssociationsRequest, ListBackupPlanAssociationsResponse> _callListBackupPlanAssociations;

        private readonly gaxgrpc::ApiCall<DeleteBackupPlanAssociationRequest, lro::Operation> _callDeleteBackupPlanAssociation;

        private readonly gaxgrpc::ApiCall<TriggerBackupRequest, lro::Operation> _callTriggerBackup;

        private readonly gaxgrpc::ApiCall<InitializeServiceRequest, lro::Operation> _callInitializeService;

        /// <summary>
        /// Constructs a client wrapper for the BackupDR service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BackupDRSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BackupDRClientImpl(BackupDR.BackupDRClient grpcClient, BackupDRSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BackupDRSettings effectiveSettings = settings ?? BackupDRSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateManagementServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateManagementServerOperationsSettings, logger);
            DeleteManagementServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteManagementServerOperationsSettings, logger);
            CreateBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupVaultOperationsSettings, logger);
            UpdateBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupVaultOperationsSettings, logger);
            DeleteBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupVaultOperationsSettings, logger);
            UpdateDataSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataSourceOperationsSettings, logger);
            UpdateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            RestoreBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreBackupOperationsSettings, logger);
            CreateBackupPlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupPlanOperationsSettings, logger);
            DeleteBackupPlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupPlanOperationsSettings, logger);
            CreateBackupPlanAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupPlanAssociationOperationsSettings, logger);
            DeleteBackupPlanAssociationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupPlanAssociationOperationsSettings, logger);
            TriggerBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TriggerBackupOperationsSettings, logger);
            InitializeServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InitializeServiceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListManagementServers = clientHelper.BuildApiCall<ListManagementServersRequest, ListManagementServersResponse>("ListManagementServers", grpcClient.ListManagementServersAsync, grpcClient.ListManagementServers, effectiveSettings.ListManagementServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListManagementServers);
            Modify_ListManagementServersApiCall(ref _callListManagementServers);
            _callGetManagementServer = clientHelper.BuildApiCall<GetManagementServerRequest, ManagementServer>("GetManagementServer", grpcClient.GetManagementServerAsync, grpcClient.GetManagementServer, effectiveSettings.GetManagementServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetManagementServer);
            Modify_GetManagementServerApiCall(ref _callGetManagementServer);
            _callCreateManagementServer = clientHelper.BuildApiCall<CreateManagementServerRequest, lro::Operation>("CreateManagementServer", grpcClient.CreateManagementServerAsync, grpcClient.CreateManagementServer, effectiveSettings.CreateManagementServerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateManagementServer);
            Modify_CreateManagementServerApiCall(ref _callCreateManagementServer);
            _callDeleteManagementServer = clientHelper.BuildApiCall<DeleteManagementServerRequest, lro::Operation>("DeleteManagementServer", grpcClient.DeleteManagementServerAsync, grpcClient.DeleteManagementServer, effectiveSettings.DeleteManagementServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteManagementServer);
            Modify_DeleteManagementServerApiCall(ref _callDeleteManagementServer);
            _callCreateBackupVault = clientHelper.BuildApiCall<CreateBackupVaultRequest, lro::Operation>("CreateBackupVault", grpcClient.CreateBackupVaultAsync, grpcClient.CreateBackupVault, effectiveSettings.CreateBackupVaultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupVault);
            Modify_CreateBackupVaultApiCall(ref _callCreateBackupVault);
            _callListBackupVaults = clientHelper.BuildApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse>("ListBackupVaults", grpcClient.ListBackupVaultsAsync, grpcClient.ListBackupVaults, effectiveSettings.ListBackupVaultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupVaults);
            Modify_ListBackupVaultsApiCall(ref _callListBackupVaults);
            _callFetchUsableBackupVaults = clientHelper.BuildApiCall<FetchUsableBackupVaultsRequest, FetchUsableBackupVaultsResponse>("FetchUsableBackupVaults", grpcClient.FetchUsableBackupVaultsAsync, grpcClient.FetchUsableBackupVaults, effectiveSettings.FetchUsableBackupVaultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchUsableBackupVaults);
            Modify_FetchUsableBackupVaultsApiCall(ref _callFetchUsableBackupVaults);
            _callGetBackupVault = clientHelper.BuildApiCall<GetBackupVaultRequest, BackupVault>("GetBackupVault", grpcClient.GetBackupVaultAsync, grpcClient.GetBackupVault, effectiveSettings.GetBackupVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupVault);
            Modify_GetBackupVaultApiCall(ref _callGetBackupVault);
            _callUpdateBackupVault = clientHelper.BuildApiCall<UpdateBackupVaultRequest, lro::Operation>("UpdateBackupVault", grpcClient.UpdateBackupVaultAsync, grpcClient.UpdateBackupVault, effectiveSettings.UpdateBackupVaultSettings).WithGoogleRequestParam("backup_vault.name", request => request.BackupVault?.Name);
            Modify_ApiCall(ref _callUpdateBackupVault);
            Modify_UpdateBackupVaultApiCall(ref _callUpdateBackupVault);
            _callDeleteBackupVault = clientHelper.BuildApiCall<DeleteBackupVaultRequest, lro::Operation>("DeleteBackupVault", grpcClient.DeleteBackupVaultAsync, grpcClient.DeleteBackupVault, effectiveSettings.DeleteBackupVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupVault);
            Modify_DeleteBackupVaultApiCall(ref _callDeleteBackupVault);
            _callListDataSources = clientHelper.BuildApiCall<ListDataSourcesRequest, ListDataSourcesResponse>("ListDataSources", grpcClient.ListDataSourcesAsync, grpcClient.ListDataSources, effectiveSettings.ListDataSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataSources);
            Modify_ListDataSourcesApiCall(ref _callListDataSources);
            _callGetDataSource = clientHelper.BuildApiCall<GetDataSourceRequest, DataSource>("GetDataSource", grpcClient.GetDataSourceAsync, grpcClient.GetDataSource, effectiveSettings.GetDataSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSource);
            Modify_GetDataSourceApiCall(ref _callGetDataSource);
            _callUpdateDataSource = clientHelper.BuildApiCall<UpdateDataSourceRequest, lro::Operation>("UpdateDataSource", grpcClient.UpdateDataSourceAsync, grpcClient.UpdateDataSource, effectiveSettings.UpdateDataSourceSettings).WithGoogleRequestParam("data_source.name", request => request.DataSource?.Name);
            Modify_ApiCall(ref _callUpdateDataSource);
            Modify_UpdateDataSourceApiCall(ref _callUpdateDataSource);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, lro::Operation>("UpdateBackup", grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callRestoreBackup = clientHelper.BuildApiCall<RestoreBackupRequest, lro::Operation>("RestoreBackup", grpcClient.RestoreBackupAsync, grpcClient.RestoreBackup, effectiveSettings.RestoreBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreBackup);
            Modify_RestoreBackupApiCall(ref _callRestoreBackup);
            _callCreateBackupPlan = clientHelper.BuildApiCall<CreateBackupPlanRequest, lro::Operation>("CreateBackupPlan", grpcClient.CreateBackupPlanAsync, grpcClient.CreateBackupPlan, effectiveSettings.CreateBackupPlanSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupPlan);
            Modify_CreateBackupPlanApiCall(ref _callCreateBackupPlan);
            _callGetBackupPlan = clientHelper.BuildApiCall<GetBackupPlanRequest, BackupPlan>("GetBackupPlan", grpcClient.GetBackupPlanAsync, grpcClient.GetBackupPlan, effectiveSettings.GetBackupPlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupPlan);
            Modify_GetBackupPlanApiCall(ref _callGetBackupPlan);
            _callListBackupPlans = clientHelper.BuildApiCall<ListBackupPlansRequest, ListBackupPlansResponse>("ListBackupPlans", grpcClient.ListBackupPlansAsync, grpcClient.ListBackupPlans, effectiveSettings.ListBackupPlansSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupPlans);
            Modify_ListBackupPlansApiCall(ref _callListBackupPlans);
            _callDeleteBackupPlan = clientHelper.BuildApiCall<DeleteBackupPlanRequest, lro::Operation>("DeleteBackupPlan", grpcClient.DeleteBackupPlanAsync, grpcClient.DeleteBackupPlan, effectiveSettings.DeleteBackupPlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupPlan);
            Modify_DeleteBackupPlanApiCall(ref _callDeleteBackupPlan);
            _callCreateBackupPlanAssociation = clientHelper.BuildApiCall<CreateBackupPlanAssociationRequest, lro::Operation>("CreateBackupPlanAssociation", grpcClient.CreateBackupPlanAssociationAsync, grpcClient.CreateBackupPlanAssociation, effectiveSettings.CreateBackupPlanAssociationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupPlanAssociation);
            Modify_CreateBackupPlanAssociationApiCall(ref _callCreateBackupPlanAssociation);
            _callGetBackupPlanAssociation = clientHelper.BuildApiCall<GetBackupPlanAssociationRequest, BackupPlanAssociation>("GetBackupPlanAssociation", grpcClient.GetBackupPlanAssociationAsync, grpcClient.GetBackupPlanAssociation, effectiveSettings.GetBackupPlanAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupPlanAssociation);
            Modify_GetBackupPlanAssociationApiCall(ref _callGetBackupPlanAssociation);
            _callListBackupPlanAssociations = clientHelper.BuildApiCall<ListBackupPlanAssociationsRequest, ListBackupPlanAssociationsResponse>("ListBackupPlanAssociations", grpcClient.ListBackupPlanAssociationsAsync, grpcClient.ListBackupPlanAssociations, effectiveSettings.ListBackupPlanAssociationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupPlanAssociations);
            Modify_ListBackupPlanAssociationsApiCall(ref _callListBackupPlanAssociations);
            _callDeleteBackupPlanAssociation = clientHelper.BuildApiCall<DeleteBackupPlanAssociationRequest, lro::Operation>("DeleteBackupPlanAssociation", grpcClient.DeleteBackupPlanAssociationAsync, grpcClient.DeleteBackupPlanAssociation, effectiveSettings.DeleteBackupPlanAssociationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupPlanAssociation);
            Modify_DeleteBackupPlanAssociationApiCall(ref _callDeleteBackupPlanAssociation);
            _callTriggerBackup = clientHelper.BuildApiCall<TriggerBackupRequest, lro::Operation>("TriggerBackup", grpcClient.TriggerBackupAsync, grpcClient.TriggerBackup, effectiveSettings.TriggerBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTriggerBackup);
            Modify_TriggerBackupApiCall(ref _callTriggerBackup);
            _callInitializeService = clientHelper.BuildApiCall<InitializeServiceRequest, lro::Operation>("InitializeService", grpcClient.InitializeServiceAsync, grpcClient.InitializeService, effectiveSettings.InitializeServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInitializeService);
            Modify_InitializeServiceApiCall(ref _callInitializeService);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListManagementServersApiCall(ref gaxgrpc::ApiCall<ListManagementServersRequest, ListManagementServersResponse> call);

        partial void Modify_GetManagementServerApiCall(ref gaxgrpc::ApiCall<GetManagementServerRequest, ManagementServer> call);

        partial void Modify_CreateManagementServerApiCall(ref gaxgrpc::ApiCall<CreateManagementServerRequest, lro::Operation> call);

        partial void Modify_DeleteManagementServerApiCall(ref gaxgrpc::ApiCall<DeleteManagementServerRequest, lro::Operation> call);

        partial void Modify_CreateBackupVaultApiCall(ref gaxgrpc::ApiCall<CreateBackupVaultRequest, lro::Operation> call);

        partial void Modify_ListBackupVaultsApiCall(ref gaxgrpc::ApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse> call);

        partial void Modify_FetchUsableBackupVaultsApiCall(ref gaxgrpc::ApiCall<FetchUsableBackupVaultsRequest, FetchUsableBackupVaultsResponse> call);

        partial void Modify_GetBackupVaultApiCall(ref gaxgrpc::ApiCall<GetBackupVaultRequest, BackupVault> call);

        partial void Modify_UpdateBackupVaultApiCall(ref gaxgrpc::ApiCall<UpdateBackupVaultRequest, lro::Operation> call);

        partial void Modify_DeleteBackupVaultApiCall(ref gaxgrpc::ApiCall<DeleteBackupVaultRequest, lro::Operation> call);

        partial void Modify_ListDataSourcesApiCall(ref gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> call);

        partial void Modify_GetDataSourceApiCall(ref gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> call);

        partial void Modify_UpdateDataSourceApiCall(ref gaxgrpc::ApiCall<UpdateDataSourceRequest, lro::Operation> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_RestoreBackupApiCall(ref gaxgrpc::ApiCall<RestoreBackupRequest, lro::Operation> call);

        partial void Modify_CreateBackupPlanApiCall(ref gaxgrpc::ApiCall<CreateBackupPlanRequest, lro::Operation> call);

        partial void Modify_GetBackupPlanApiCall(ref gaxgrpc::ApiCall<GetBackupPlanRequest, BackupPlan> call);

        partial void Modify_ListBackupPlansApiCall(ref gaxgrpc::ApiCall<ListBackupPlansRequest, ListBackupPlansResponse> call);

        partial void Modify_DeleteBackupPlanApiCall(ref gaxgrpc::ApiCall<DeleteBackupPlanRequest, lro::Operation> call);

        partial void Modify_CreateBackupPlanAssociationApiCall(ref gaxgrpc::ApiCall<CreateBackupPlanAssociationRequest, lro::Operation> call);

        partial void Modify_GetBackupPlanAssociationApiCall(ref gaxgrpc::ApiCall<GetBackupPlanAssociationRequest, BackupPlanAssociation> call);

        partial void Modify_ListBackupPlanAssociationsApiCall(ref gaxgrpc::ApiCall<ListBackupPlanAssociationsRequest, ListBackupPlanAssociationsResponse> call);

        partial void Modify_DeleteBackupPlanAssociationApiCall(ref gaxgrpc::ApiCall<DeleteBackupPlanAssociationRequest, lro::Operation> call);

        partial void Modify_TriggerBackupApiCall(ref gaxgrpc::ApiCall<TriggerBackupRequest, lro::Operation> call);

        partial void Modify_InitializeServiceApiCall(ref gaxgrpc::ApiCall<InitializeServiceRequest, lro::Operation> call);

        partial void OnConstruction(BackupDR.BackupDRClient grpcClient, BackupDRSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackupDR client</summary>
        public override BackupDR.BackupDRClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListManagementServersRequest(ref ListManagementServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetManagementServerRequest(ref GetManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateManagementServerRequest(ref CreateManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteManagementServerRequest(ref DeleteManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupVaultRequest(ref CreateBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupVaultsRequest(ref ListBackupVaultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchUsableBackupVaultsRequest(ref FetchUsableBackupVaultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupVaultRequest(ref GetBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupVaultRequest(ref UpdateBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupVaultRequest(ref DeleteBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataSourcesRequest(ref ListDataSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataSourceRequest(ref GetDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataSourceRequest(ref UpdateDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreBackupRequest(ref RestoreBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupPlanRequest(ref CreateBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupPlanRequest(ref GetBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupPlansRequest(ref ListBackupPlansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupPlanRequest(ref DeleteBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupPlanAssociationRequest(ref CreateBackupPlanAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupPlanAssociationRequest(ref GetBackupPlanAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupPlanAssociationsRequest(ref ListBackupPlanAssociationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupPlanAssociationRequest(ref DeleteBackupPlanAssociationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TriggerBackupRequest(ref TriggerBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InitializeServiceRequest(ref InitializeServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagementServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListManagementServersRequest, ListManagementServersResponse, ManagementServer>(_callListManagementServers, request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagementServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListManagementServersRequest, ListManagementServersResponse, ManagementServer>(_callListManagementServers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagementServer GetManagementServer(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagementServerRequest(ref request, ref callSettings);
            return _callGetManagementServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagementServerRequest(ref request, ref callSettings);
            return _callGetManagementServer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateManagementServer</c>.</summary>
        public override lro::OperationsClient CreateManagementServerOperationsClient { get; }

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<ManagementServer, OperationMetadata>(_callCreateManagementServer.Sync(request, callSettings), CreateManagementServerOperationsClient);
        }

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<ManagementServer, OperationMetadata>(await _callCreateManagementServer.Async(request, callSettings).ConfigureAwait(false), CreateManagementServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteManagementServer</c>.</summary>
        public override lro::OperationsClient DeleteManagementServerOperationsClient { get; }

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteManagementServer.Sync(request, callSettings), DeleteManagementServerOperationsClient);
        }

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteManagementServer.Async(request, callSettings).ConfigureAwait(false), DeleteManagementServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackupVault</c>.</summary>
        public override lro::OperationsClient CreateBackupVaultOperationsClient { get; }

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupVault, OperationMetadata> CreateBackupVault(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<BackupVault, OperationMetadata>(_callCreateBackupVault.Sync(request, callSettings), CreateBackupVaultOperationsClient);
        }

        /// <summary>
        /// Creates a new BackupVault in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<BackupVault, OperationMetadata>(await _callCreateBackupVault.Async(request, callSettings).ConfigureAwait(false), CreateBackupVaultOperationsClient);
        }

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaults(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupVaultsRequest, ListBackupVaultsResponse, BackupVault>(_callListBackupVaults, request, callSettings);
        }

        /// <summary>
        /// Lists BackupVaults in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupVaultsRequest, ListBackupVaultsResponse, BackupVault>(_callListBackupVaults, request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public override gax::PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaults(FetchUsableBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchUsableBackupVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchUsableBackupVaultsRequest, FetchUsableBackupVaultsResponse, BackupVault>(_callFetchUsableBackupVaults, request, callSettings);
        }

        /// <summary>
        /// FetchUsableBackupVaults lists usable BackupVaults in a given project and
        /// location. Usable BackupVault are the ones that user has
        /// backupdr.backupVaults.get permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> FetchUsableBackupVaultsAsync(FetchUsableBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchUsableBackupVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchUsableBackupVaultsRequest, FetchUsableBackupVaultsResponse, BackupVault>(_callFetchUsableBackupVaults, request, callSettings);
        }

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupVault GetBackupVault(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupVaultRequest(ref request, ref callSettings);
            return _callGetBackupVault.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupVaultRequest(ref request, ref callSettings);
            return _callGetBackupVault.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBackupVault</c>.</summary>
        public override lro::OperationsClient UpdateBackupVaultOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupVault, OperationMetadata> UpdateBackupVault(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<BackupVault, OperationMetadata>(_callUpdateBackupVault.Sync(request, callSettings), UpdateBackupVaultOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<BackupVault, OperationMetadata>(await _callUpdateBackupVault.Async(request, callSettings).ConfigureAwait(false), UpdateBackupVaultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackupVault</c>.</summary>
        public override lro::OperationsClient DeleteBackupVaultOperationsClient { get; }

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackupVault.Sync(request, callSettings), DeleteBackupVaultOperationsClient);
        }

        /// <summary>
        /// Deletes a BackupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupVault.Async(request, callSettings).ConfigureAwait(false), DeleteBackupVaultOperationsClient);
        }

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Lists DataSources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateDataSource</c>.</summary>
        public override lro::OperationsClient UpdateDataSourceOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataSource, OperationMetadata> UpdateDataSource(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceRequest(ref request, ref callSettings);
            return new lro::Operation<DataSource, OperationMetadata>(_callUpdateDataSource.Sync(request, callSettings), UpdateDataSourceOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a DataSource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataSource, OperationMetadata>> UpdateDataSourceAsync(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceRequest(ref request, ref callSettings);
            return new lro::Operation<DataSource, OperationMetadata>(await _callUpdateDataSource.Async(request, callSettings).ConfigureAwait(false), UpdateDataSourceOperationsClient);
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
        /// Gets details of a Backup.
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
        /// Gets details of a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBackup</c>.</summary>
        public override lro::OperationsClient UpdateBackupOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a Backup.
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
        /// Updates the settings of a Backup.
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
        /// Deletes a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(_callDeleteBackup.Sync(request, callSettings), DeleteBackupOperationsClient);
        }

        /// <summary>
        /// Deletes a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreBackup</c>.</summary>
        public override lro::OperationsClient RestoreBackupOperationsClient { get; }

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RestoreBackupResponse, OperationMetadata> RestoreBackup(RestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreBackupRequest(ref request, ref callSettings);
            return new lro::Operation<RestoreBackupResponse, OperationMetadata>(_callRestoreBackup.Sync(request, callSettings), RestoreBackupOperationsClient);
        }

        /// <summary>
        /// Restore from a Backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RestoreBackupResponse, OperationMetadata>> RestoreBackupAsync(RestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreBackupRequest(ref request, ref callSettings);
            return new lro::Operation<RestoreBackupResponse, OperationMetadata>(await _callRestoreBackup.Async(request, callSettings).ConfigureAwait(false), RestoreBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackupPlan</c>.</summary>
        public override lro::OperationsClient CreateBackupPlanOperationsClient { get; }

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlan, OperationMetadata>(_callCreateBackupPlan.Sync(request, callSettings), CreateBackupPlanOperationsClient);
        }

        /// <summary>
        /// Create a BackupPlan
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlan, OperationMetadata>(await _callCreateBackupPlan.Async(request, callSettings).ConfigureAwait(false), CreateBackupPlanOperationsClient);
        }

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupPlan GetBackupPlan(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPlanRequest(ref request, ref callSettings);
            return _callGetBackupPlan.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPlanRequest(ref request, ref callSettings);
            return _callGetBackupPlan.Async(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPlan"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlans(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupPlansRequest, ListBackupPlansResponse, BackupPlan>(_callListBackupPlans, request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlans in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupPlansRequest, ListBackupPlansResponse, BackupPlan>(_callListBackupPlans, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBackupPlan</c>.</summary>
        public override lro::OperationsClient DeleteBackupPlanOperationsClient { get; }

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackupPlan.Sync(request, callSettings), DeleteBackupPlanOperationsClient);
        }

        /// <summary>
        /// Deletes a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupPlan.Async(request, callSettings).ConfigureAwait(false), DeleteBackupPlanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackupPlanAssociation</c>.</summary>
        public override lro::OperationsClient CreateBackupPlanAssociationOperationsClient { get; }

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPlanAssociation, OperationMetadata> CreateBackupPlanAssociation(CreateBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPlanAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlanAssociation, OperationMetadata>(_callCreateBackupPlanAssociation.Sync(request, callSettings), CreateBackupPlanAssociationOperationsClient);
        }

        /// <summary>
        /// Create a BackupPlanAssociation
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> CreateBackupPlanAssociationAsync(CreateBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPlanAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlanAssociation, OperationMetadata>(await _callCreateBackupPlanAssociation.Async(request, callSettings).ConfigureAwait(false), CreateBackupPlanAssociationOperationsClient);
        }

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupPlanAssociation GetBackupPlanAssociation(GetBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPlanAssociationRequest(ref request, ref callSettings);
            return _callGetBackupPlanAssociation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupPlanAssociation> GetBackupPlanAssociationAsync(GetBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPlanAssociationRequest(ref request, ref callSettings);
            return _callGetBackupPlanAssociation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociations(ListBackupPlanAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPlanAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupPlanAssociationsRequest, ListBackupPlanAssociationsResponse, BackupPlanAssociation>(_callListBackupPlanAssociations, request, callSettings);
        }

        /// <summary>
        /// Lists BackupPlanAssociations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlanAssociation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> ListBackupPlanAssociationsAsync(ListBackupPlanAssociationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPlanAssociationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupPlanAssociationsRequest, ListBackupPlanAssociationsResponse, BackupPlanAssociation>(_callListBackupPlanAssociations, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBackupPlanAssociation</c>.</summary>
        public override lro::OperationsClient DeleteBackupPlanAssociationOperationsClient { get; }

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlanAssociation(DeleteBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPlanAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackupPlanAssociation.Sync(request, callSettings), DeleteBackupPlanAssociationOperationsClient);
        }

        /// <summary>
        /// Deletes a single BackupPlanAssociation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAssociationAsync(DeleteBackupPlanAssociationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPlanAssociationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupPlanAssociation.Async(request, callSettings).ConfigureAwait(false), DeleteBackupPlanAssociationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>TriggerBackup</c>.</summary>
        public override lro::OperationsClient TriggerBackupOperationsClient { get; }

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPlanAssociation, OperationMetadata> TriggerBackup(TriggerBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerBackupRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlanAssociation, OperationMetadata>(_callTriggerBackup.Sync(request, callSettings), TriggerBackupOperationsClient);
        }

        /// <summary>
        /// Triggers a new Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPlanAssociation, OperationMetadata>> TriggerBackupAsync(TriggerBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerBackupRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlanAssociation, OperationMetadata>(await _callTriggerBackup.Async(request, callSettings).ConfigureAwait(false), TriggerBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>InitializeService</c>.</summary>
        public override lro::OperationsClient InitializeServiceOperationsClient { get; }

        /// <summary>
        /// Initializes the service related config for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InitializeServiceResponse, OperationMetadata> InitializeService(InitializeServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeServiceRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeServiceResponse, OperationMetadata>(_callInitializeService.Sync(request, callSettings), InitializeServiceOperationsClient);
        }

        /// <summary>
        /// Initializes the service related config for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InitializeServiceResponse, OperationMetadata>> InitializeServiceAsync(InitializeServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeServiceRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeServiceResponse, OperationMetadata>(await _callInitializeService.Async(request, callSettings).ConfigureAwait(false), InitializeServiceOperationsClient);
        }
    }

    public partial class ListManagementServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupVaultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchUsableBackupVaultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupPlansRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupPlanAssociationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListManagementServersResponse : gaxgrpc::IPageResponse<ManagementServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagementServer> GetEnumerator() => ManagementServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupVaultsResponse : gaxgrpc::IPageResponse<BackupVault>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupVault> GetEnumerator() => BackupVaults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchUsableBackupVaultsResponse : gaxgrpc::IPageResponse<BackupVault>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupVault> GetEnumerator() => BackupVaults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataSourcesResponse : gaxgrpc::IPageResponse<DataSource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataSource> GetEnumerator() => DataSources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupPlansResponse : gaxgrpc::IPageResponse<BackupPlan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupPlan> GetEnumerator() => BackupPlans.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupPlanAssociationsResponse : gaxgrpc::IPageResponse<BackupPlanAssociation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupPlanAssociation> GetEnumerator() => BackupPlanAssociations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BackupDR
    {
        public partial class BackupDRClient
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

    public static partial class BackupDR
    {
        public partial class BackupDRClient
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
