// Copyright 2024 Google LLC
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

namespace Google.Cloud.GkeBackup.V1
{
    /// <summary>Settings for <see cref="BackupForGKEClient"/> instances.</summary>
    public sealed partial class BackupForGKESettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackupForGKESettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackupForGKESettings"/>.</returns>
        public static BackupForGKESettings GetDefault() => new BackupForGKESettings();

        /// <summary>Constructs a new <see cref="BackupForGKESettings"/> object with default settings.</summary>
        public BackupForGKESettings()
        {
        }

        private BackupForGKESettings(BackupForGKESettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBackupPlanSettings = existing.CreateBackupPlanSettings;
            CreateBackupPlanOperationsSettings = existing.CreateBackupPlanOperationsSettings.Clone();
            ListBackupPlansSettings = existing.ListBackupPlansSettings;
            GetBackupPlanSettings = existing.GetBackupPlanSettings;
            UpdateBackupPlanSettings = existing.UpdateBackupPlanSettings;
            UpdateBackupPlanOperationsSettings = existing.UpdateBackupPlanOperationsSettings.Clone();
            DeleteBackupPlanSettings = existing.DeleteBackupPlanSettings;
            DeleteBackupPlanOperationsSettings = existing.DeleteBackupPlanOperationsSettings.Clone();
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            UpdateBackupSettings = existing.UpdateBackupSettings;
            UpdateBackupOperationsSettings = existing.UpdateBackupOperationsSettings.Clone();
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            ListVolumeBackupsSettings = existing.ListVolumeBackupsSettings;
            GetVolumeBackupSettings = existing.GetVolumeBackupSettings;
            CreateRestorePlanSettings = existing.CreateRestorePlanSettings;
            CreateRestorePlanOperationsSettings = existing.CreateRestorePlanOperationsSettings.Clone();
            ListRestorePlansSettings = existing.ListRestorePlansSettings;
            GetRestorePlanSettings = existing.GetRestorePlanSettings;
            UpdateRestorePlanSettings = existing.UpdateRestorePlanSettings;
            UpdateRestorePlanOperationsSettings = existing.UpdateRestorePlanOperationsSettings.Clone();
            DeleteRestorePlanSettings = existing.DeleteRestorePlanSettings;
            DeleteRestorePlanOperationsSettings = existing.DeleteRestorePlanOperationsSettings.Clone();
            CreateRestoreSettings = existing.CreateRestoreSettings;
            CreateRestoreOperationsSettings = existing.CreateRestoreOperationsSettings.Clone();
            ListRestoresSettings = existing.ListRestoresSettings;
            GetRestoreSettings = existing.GetRestoreSettings;
            UpdateRestoreSettings = existing.UpdateRestoreSettings;
            UpdateRestoreOperationsSettings = existing.UpdateRestoreOperationsSettings.Clone();
            DeleteRestoreSettings = existing.DeleteRestoreSettings;
            DeleteRestoreOperationsSettings = existing.DeleteRestoreOperationsSettings.Clone();
            ListVolumeRestoresSettings = existing.ListVolumeRestoresSettings;
            GetVolumeRestoreSettings = existing.GetVolumeRestoreSettings;
            GetBackupIndexDownloadUrlSettings = existing.GetBackupIndexDownloadUrlSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BackupForGKESettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.CreateBackupPlan</c> and <c>BackupForGKEClient.CreateBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.CreateBackupPlan</c> and
        /// <c>BackupForGKEClient.CreateBackupPlanAsync</c>.
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
        /// <c>BackupForGKEClient.ListBackupPlans</c> and <c>BackupForGKEClient.ListBackupPlansAsync</c>.
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
        public gaxgrpc::CallSettings ListBackupPlansSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetBackupPlan</c> and <c>BackupForGKEClient.GetBackupPlanAsync</c>.
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
        public gaxgrpc::CallSettings GetBackupPlanSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.UpdateBackupPlan</c> and <c>BackupForGKEClient.UpdateBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.UpdateBackupPlan</c> and
        /// <c>BackupForGKEClient.UpdateBackupPlanAsync</c>.
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
        public lro::OperationsSettings UpdateBackupPlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.DeleteBackupPlan</c> and <c>BackupForGKEClient.DeleteBackupPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupPlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.DeleteBackupPlan</c> and
        /// <c>BackupForGKEClient.DeleteBackupPlanAsync</c>.
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
        /// <c>BackupForGKEClient.CreateBackup</c> and <c>BackupForGKEClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.CreateBackup</c> and
        /// <c>BackupForGKEClient.CreateBackupAsync</c>.
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
        /// <c>BackupForGKEClient.ListBackups</c> and <c>BackupForGKEClient.ListBackupsAsync</c>.
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
        /// <c>BackupForGKEClient.GetBackup</c> and <c>BackupForGKEClient.GetBackupAsync</c>.
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
        /// <c>BackupForGKEClient.UpdateBackup</c> and <c>BackupForGKEClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.UpdateBackup</c> and
        /// <c>BackupForGKEClient.UpdateBackupAsync</c>.
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
        /// <c>BackupForGKEClient.DeleteBackup</c> and <c>BackupForGKEClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.DeleteBackup</c> and
        /// <c>BackupForGKEClient.DeleteBackupAsync</c>.
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
        /// <c>BackupForGKEClient.ListVolumeBackups</c> and <c>BackupForGKEClient.ListVolumeBackupsAsync</c>.
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
        public gaxgrpc::CallSettings ListVolumeBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetVolumeBackup</c> and <c>BackupForGKEClient.GetVolumeBackupAsync</c>.
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
        public gaxgrpc::CallSettings GetVolumeBackupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.CreateRestorePlan</c> and <c>BackupForGKEClient.CreateRestorePlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRestorePlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.CreateRestorePlan</c> and
        /// <c>BackupForGKEClient.CreateRestorePlanAsync</c>.
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
        public lro::OperationsSettings CreateRestorePlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.ListRestorePlans</c> and <c>BackupForGKEClient.ListRestorePlansAsync</c>.
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
        public gaxgrpc::CallSettings ListRestorePlansSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetRestorePlan</c> and <c>BackupForGKEClient.GetRestorePlanAsync</c>.
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
        public gaxgrpc::CallSettings GetRestorePlanSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.UpdateRestorePlan</c> and <c>BackupForGKEClient.UpdateRestorePlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRestorePlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.UpdateRestorePlan</c> and
        /// <c>BackupForGKEClient.UpdateRestorePlanAsync</c>.
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
        public lro::OperationsSettings UpdateRestorePlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.DeleteRestorePlan</c> and <c>BackupForGKEClient.DeleteRestorePlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRestorePlanSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.DeleteRestorePlan</c> and
        /// <c>BackupForGKEClient.DeleteRestorePlanAsync</c>.
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
        public lro::OperationsSettings DeleteRestorePlanOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.CreateRestore</c> and <c>BackupForGKEClient.CreateRestoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.CreateRestore</c> and
        /// <c>BackupForGKEClient.CreateRestoreAsync</c>.
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
        public lro::OperationsSettings CreateRestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.ListRestores</c> and <c>BackupForGKEClient.ListRestoresAsync</c>.
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
        public gaxgrpc::CallSettings ListRestoresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetRestore</c> and <c>BackupForGKEClient.GetRestoreAsync</c>.
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
        public gaxgrpc::CallSettings GetRestoreSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.UpdateRestore</c> and <c>BackupForGKEClient.UpdateRestoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.UpdateRestore</c> and
        /// <c>BackupForGKEClient.UpdateRestoreAsync</c>.
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
        public lro::OperationsSettings UpdateRestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.DeleteRestore</c> and <c>BackupForGKEClient.DeleteRestoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupForGKEClient.DeleteRestore</c> and
        /// <c>BackupForGKEClient.DeleteRestoreAsync</c>.
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
        public lro::OperationsSettings DeleteRestoreOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.ListVolumeRestores</c> and <c>BackupForGKEClient.ListVolumeRestoresAsync</c>.
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
        public gaxgrpc::CallSettings ListVolumeRestoresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetVolumeRestore</c> and <c>BackupForGKEClient.GetVolumeRestoreAsync</c>.
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
        public gaxgrpc::CallSettings GetVolumeRestoreSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupForGKEClient.GetBackupIndexDownloadUrl</c> and <c>BackupForGKEClient.GetBackupIndexDownloadUrlAsync</c>
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
        public gaxgrpc::CallSettings GetBackupIndexDownloadUrlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BackupForGKESettings"/> object.</returns>
        public BackupForGKESettings Clone() => new BackupForGKESettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackupForGKEClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BackupForGKEClientBuilder : gaxgrpc::ClientBuilderBase<BackupForGKEClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackupForGKESettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BackupForGKEClientBuilder() : base(BackupForGKEClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BackupForGKEClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackupForGKEClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackupForGKEClient Build()
        {
            BackupForGKEClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackupForGKEClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackupForGKEClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackupForGKEClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackupForGKEClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BackupForGKEClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackupForGKEClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackupForGKEClient.ChannelPool;
    }

    /// <summary>BackupForGKE client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BackupForGKE allows Kubernetes administrators to configure, execute, and
    /// manage backup and restore operations for their GKE clusters.
    /// </remarks>
    public abstract partial class BackupForGKEClient
    {
        /// <summary>
        /// The default endpoint for the BackupForGKE service, which is a host of "gkebackup.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gkebackup.googleapis.com:443";

        /// <summary>The default BackupForGKE scopes.</summary>
        /// <remarks>
        /// The default BackupForGKE scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BackupForGKE.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BackupForGKEClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackupForGKEClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackupForGKEClient"/>.</returns>
        public static stt::Task<BackupForGKEClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackupForGKEClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackupForGKEClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BackupForGKEClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackupForGKEClient"/>.</returns>
        public static BackupForGKEClient Create() => new BackupForGKEClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackupForGKEClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackupForGKESettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BackupForGKEClient"/>.</returns>
        internal static BackupForGKEClient Create(grpccore::CallInvoker callInvoker, BackupForGKESettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackupForGKE.BackupForGKEClient grpcClient = new BackupForGKE.BackupForGKEClient(callInvoker);
            return new BackupForGKEClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BackupForGKE client</summary>
        public virtual BackupForGKE.BackupForGKEClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(CreateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new BackupPlan in a given location.
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
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(string parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlan(new CreateBackupPlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(string parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAsync(new CreateBackupPlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(string parent, BackupPlan backupPlan, string backupPlanId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAsync(parent, backupPlan, backupPlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> CreateBackupPlan(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlan(new CreateBackupPlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPlanAsync(new CreateBackupPlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                BackupPlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPlanId, nameof(backupPlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new BackupPlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the BackupPlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="backupPlan">
        /// Required. The BackupPlan resource object to create.
        /// </param>
        /// <param name="backupPlanId">
        /// Required. The client-provided short name for the BackupPlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of BackupPlans in this location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> CreateBackupPlanAsync(gagr::LocationName parent, BackupPlan backupPlan, string backupPlanId, st::CancellationToken cancellationToken) =>
            CreateBackupPlanAsync(parent, backupPlan, backupPlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlans(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the BackupPlans to list.
        /// Format: `projects/*/locations/*`
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
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the BackupPlans to list.
        /// Format: `projects/*/locations/*`
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
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the BackupPlans to list.
        /// Format: `projects/*/locations/*`
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
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the BackupPlans to list.
        /// Format: `projects/*/locations/*`
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
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlan(new GetBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAsync(new GetBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPlan GetBackupPlan(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlan(new GetBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPlanAsync(new GetBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPlan> GetBackupPlanAsync(BackupPlanName name, st::CancellationToken cancellationToken) =>
            GetBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> UpdateBackupPlan(UpdateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> UpdateBackupPlanAsync(UpdateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> UpdateBackupPlanAsync(UpdateBackupPlanRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBackupPlan</c>.</summary>
        public virtual lro::OperationsClient UpdateBackupPlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> PollOnceUpdateBackupPlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackupPlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> PollOnceUpdateBackupPlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPlan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupPlanOperationsClient, callSettings);

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="backupPlan">
        /// Required. A new version of the BackupPlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// BackupPlan targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource
        /// (e.g., `description`, `backup_config.include_volume_data`, etc.)
        /// If no `update_mask` is provided, all fields in `backup_plan` will be
        /// written to the target BackupPlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup_plan` are ignored
        /// and are not used to update the target BackupPlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPlan, OperationMetadata> UpdateBackupPlan(BackupPlan backupPlan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupPlan(new UpdateBackupPlanRequest
            {
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="backupPlan">
        /// Required. A new version of the BackupPlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// BackupPlan targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource
        /// (e.g., `description`, `backup_config.include_volume_data`, etc.)
        /// If no `update_mask` is provided, all fields in `backup_plan` will be
        /// written to the target BackupPlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup_plan` are ignored
        /// and are not used to update the target BackupPlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> UpdateBackupPlanAsync(BackupPlan backupPlan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupPlanAsync(new UpdateBackupPlanRequest
            {
                BackupPlan = gax::GaxPreconditions.CheckNotNull(backupPlan, nameof(backupPlan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="backupPlan">
        /// Required. A new version of the BackupPlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// BackupPlan targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource
        /// (e.g., `description`, `backup_config.include_volume_data`, etc.)
        /// If no `update_mask` is provided, all fields in `backup_plan` will be
        /// written to the target BackupPlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup_plan` are ignored
        /// and are not used to update the target BackupPlan.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPlan, OperationMetadata>> UpdateBackupPlanAsync(BackupPlan backupPlan, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupPlanAsync(backupPlan, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing BackupPlan.
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
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlan(new DeleteBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAsync(new DeleteBackupPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPlan(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlan(new DeleteBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(BackupPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPlanAsync(new DeleteBackupPlanRequest
            {
                BackupPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified BackupPlan name.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(BackupPlanName name, st::CancellationToken cancellationToken) =>
            DeleteBackupPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
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
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = backup,
                BackupId = backupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = backup,
                BackupId = backupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(BackupPlanName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsBackupPlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = backup,
                BackupId = backupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(BackupPlanName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsBackupPlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = backup,
                BackupId = backupId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan within which to create the Backup.
        /// Format: `projects/*/locations/*/backupPlans/*`
        /// </param>
        /// <param name="backup">
        /// Optional. The Backup resource to create.
        /// </param>
        /// <param name="backupId">
        /// Optional. The client-provided short name for the Backup resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Backups in this BackupPlan
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(BackupPlanName parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan that contains the Backups to list.
        /// Format: `projects/*/locations/*/backupPlans/*`
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
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan that contains the Backups to list.
        /// Format: `projects/*/locations/*/backupPlans/*`
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
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan that contains the Backups to list.
        /// Format: `projects/*/locations/*/backupPlans/*`
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(BackupPlanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupPlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists the Backups for a given BackupPlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The BackupPlan that contains the Backups to list.
        /// Format: `projects/*/locations/*/backupPlans/*`
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(BackupPlanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupPlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Backup.
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
        /// Update a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A new version of the Backup resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Backup targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `backup` will be
        /// written to the target Backup resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup` are ignored
        /// and are not used to update the target Backup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A new version of the Backup resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Backup targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `backup` will be
        /// written to the target Backup resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup` are ignored
        /// and are not used to update the target Backup.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A new version of the Backup resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Backup targeted for update. The values for each of these
        /// updated fields will be taken from the `backup_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `backup` will be
        /// written to the target Backup resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `backup` are ignored
        /// and are not used to update the target Backup.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Backup.
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
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Backup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackups(ListVolumeBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackupsAsync(ListVolumeBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The Backup that contains the VolumeBackups to list.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
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
        /// <returns>A pageable sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
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
            return ListVolumeBackups(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The Backup that contains the VolumeBackups to list.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
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
            return ListVolumeBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The Backup that contains the VolumeBackups to list.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
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
        /// <returns>A pageable sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackups(BackupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
            {
                ParentAsBackupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeBackups(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The Backup that contains the VolumeBackups to list.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeBackup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackupsAsync(BackupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeBackupsRequest request = new ListVolumeBackupsRequest
            {
                ParentAsBackupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeBackup GetVolumeBackup(GetVolumeBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(GetVolumeBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(GetVolumeBackupRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeBackup GetVolumeBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeBackup(new GetVolumeBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeBackupAsync(new GetVolumeBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeBackup GetVolumeBackup(VolumeBackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeBackup(new GetVolumeBackupRequest
            {
                VolumeBackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(VolumeBackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeBackupAsync(new GetVolumeBackupRequest
            {
                VolumeBackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeBackup resource.
        /// Format: `projects/*/locations/*/backupPlans/*/backups/*/volumeBackups/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeBackup> GetVolumeBackupAsync(VolumeBackupName name, st::CancellationToken cancellationToken) =>
            GetVolumeBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> CreateRestorePlan(CreateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(CreateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(CreateRestorePlanRequest request, st::CancellationToken cancellationToken) =>
            CreateRestorePlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRestorePlan</c>.</summary>
        public virtual lro::OperationsClient CreateRestorePlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRestorePlan</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> PollOnceCreateRestorePlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestorePlan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRestorePlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> PollOnceCreateRestorePlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestorePlan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> CreateRestorePlan(string parent, RestorePlan restorePlan, string restorePlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestorePlan(new CreateRestorePlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                RestorePlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(string parent, RestorePlan restorePlan, string restorePlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestorePlanAsync(new CreateRestorePlanRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                RestorePlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(string parent, RestorePlan restorePlan, string restorePlanId, st::CancellationToken cancellationToken) =>
            CreateRestorePlanAsync(parent, restorePlan, restorePlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> CreateRestorePlan(gagr::LocationName parent, RestorePlan restorePlan, string restorePlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestorePlan(new CreateRestorePlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                RestorePlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(gagr::LocationName parent, RestorePlan restorePlan, string restorePlanId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestorePlanAsync(new CreateRestorePlanRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                RestorePlanId = gax::GaxPreconditions.CheckNotNullOrEmpty(restorePlanId, nameof(restorePlanId)),
            }, callSettings);

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location within which to create the RestorePlan.
        /// Format: `projects/*/locations/*`
        /// </param>
        /// <param name="restorePlan">
        /// Required. The RestorePlan resource object to create.
        /// </param>
        /// <param name="restorePlanId">
        /// Required. The client-provided short name for the RestorePlan resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of RestorePlans in this location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(gagr::LocationName parent, RestorePlan restorePlan, string restorePlanId, st::CancellationToken cancellationToken) =>
            CreateRestorePlanAsync(parent, restorePlan, restorePlanId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlans(ListRestorePlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlansAsync(ListRestorePlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the RestorePlans to list.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlans(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestorePlansRequest request = new ListRestorePlansRequest
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
            return ListRestorePlans(request, callSettings);
        }

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the RestorePlans to list.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlansAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestorePlansRequest request = new ListRestorePlansRequest
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
            return ListRestorePlansAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the RestorePlans to list.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlans(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestorePlansRequest request = new ListRestorePlansRequest
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
            return ListRestorePlans(request, callSettings);
        }

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location that contains the RestorePlans to list.
        /// Format: `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RestorePlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlansAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestorePlansRequest request = new ListRestorePlansRequest
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
            return ListRestorePlansAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlan GetRestorePlan(GetRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(GetRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(GetRestorePlanRequest request, st::CancellationToken cancellationToken) =>
            GetRestorePlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlan GetRestorePlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestorePlan(new GetRestorePlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestorePlanAsync(new GetRestorePlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(string name, st::CancellationToken cancellationToken) =>
            GetRestorePlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestorePlan GetRestorePlan(RestorePlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestorePlan(new GetRestorePlanRequest
            {
                RestorePlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(RestorePlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestorePlanAsync(new GetRestorePlanRequest
            {
                RestorePlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestorePlan> GetRestorePlanAsync(RestorePlanName name, st::CancellationToken cancellationToken) =>
            GetRestorePlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> UpdateRestorePlan(UpdateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> UpdateRestorePlanAsync(UpdateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> UpdateRestorePlanAsync(UpdateRestorePlanRequest request, st::CancellationToken cancellationToken) =>
            UpdateRestorePlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRestorePlan</c>.</summary>
        public virtual lro::OperationsClient UpdateRestorePlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRestorePlan</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> PollOnceUpdateRestorePlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestorePlan, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRestorePlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> PollOnceUpdateRestorePlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RestorePlan, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="restorePlan">
        /// Required. A new version of the RestorePlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// RestorePlan targeted for update. The values for each of these
        /// updated fields will be taken from the `restore_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore_plan` will be
        /// written to the target RestorePlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore_plan` are ignored
        /// and are not used to update the target RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RestorePlan, OperationMetadata> UpdateRestorePlan(RestorePlan restorePlan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRestorePlan(new UpdateRestorePlanRequest
            {
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="restorePlan">
        /// Required. A new version of the RestorePlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// RestorePlan targeted for update. The values for each of these
        /// updated fields will be taken from the `restore_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore_plan` will be
        /// written to the target RestorePlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore_plan` are ignored
        /// and are not used to update the target RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> UpdateRestorePlanAsync(RestorePlan restorePlan, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRestorePlanAsync(new UpdateRestorePlanRequest
            {
                RestorePlan = gax::GaxPreconditions.CheckNotNull(restorePlan, nameof(restorePlan)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="restorePlan">
        /// Required. A new version of the RestorePlan resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// RestorePlan targeted for update. The values for each of these
        /// updated fields will be taken from the `restore_plan` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore_plan` will be
        /// written to the target RestorePlan resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore_plan` are ignored
        /// and are not used to update the target RestorePlan.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RestorePlan, OperationMetadata>> UpdateRestorePlanAsync(RestorePlan restorePlan, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRestorePlanAsync(restorePlan, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestorePlan(DeleteRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(DeleteRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(DeleteRestorePlanRequest request, st::CancellationToken cancellationToken) =>
            DeleteRestorePlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRestorePlan</c>.</summary>
        public virtual lro::OperationsClient DeleteRestorePlanOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRestorePlan</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRestorePlan(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRestorePlan</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRestorePlanAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRestorePlanOperationsClient, callSettings);

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestorePlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestorePlan(new DeleteRestorePlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestorePlanAsync(new DeleteRestorePlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRestorePlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestorePlan(RestorePlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestorePlan(new DeleteRestorePlanRequest
            {
                RestorePlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(RestorePlanName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestorePlanAsync(new DeleteRestorePlanRequest
            {
                RestorePlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="name">
        /// Required. Fully qualified RestorePlan name.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(RestorePlanName name, st::CancellationToken cancellationToken) =>
            DeleteRestorePlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> CreateRestore(CreateRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(CreateRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(CreateRestoreRequest request, st::CancellationToken cancellationToken) =>
            CreateRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRestore</c>.</summary>
        public virtual lro::OperationsClient CreateRestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> PollOnceCreateRestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> PollOnceCreateRestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRestoreOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> CreateRestore(string parent, Restore restore, string restoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestore(new CreateRestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                RestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(string parent, Restore restore, string restoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestoreAsync(new CreateRestoreRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                RestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(string parent, Restore restore, string restoreId, st::CancellationToken cancellationToken) =>
            CreateRestoreAsync(parent, restore, restoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> CreateRestore(RestorePlanName parent, Restore restore, string restoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestore(new CreateRestoreRequest
            {
                ParentAsRestorePlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                RestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(RestorePlanName parent, Restore restore, string restoreId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRestoreAsync(new CreateRestoreRequest
            {
                ParentAsRestorePlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                RestoreId = gax::GaxPreconditions.CheckNotNullOrEmpty(restoreId, nameof(restoreId)),
            }, callSettings);

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan within which to create the Restore.
        /// Format: `projects/*/locations/*/restorePlans/*`
        /// </param>
        /// <param name="restore">
        /// Required. The restore resource to create.
        /// </param>
        /// <param name="restoreId">
        /// Required. The client-provided short name for the Restore resource.
        /// This name must:
        /// 
        /// - be between 1 and 63 characters long (inclusive)
        /// - consist of only lower-case ASCII letters, numbers, and dashes
        /// - start with a lower-case letter
        /// - end with a lower-case letter or number
        /// - be unique within the set of Restores in this RestorePlan.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(RestorePlanName parent, Restore restore, string restoreId, st::CancellationToken cancellationToken) =>
            CreateRestoreAsync(parent, restore, restoreId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestoresResponse, Restore> ListRestores(ListRestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestoresResponse, Restore> ListRestoresAsync(ListRestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan that contains the Restores to list.
        /// Format: `projects/*/locations/*/restorePlans/*`
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
        /// <returns>A pageable sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestoresResponse, Restore> ListRestores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestoresRequest request = new ListRestoresRequest
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
            return ListRestores(request, callSettings);
        }

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan that contains the Restores to list.
        /// Format: `projects/*/locations/*/restorePlans/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestoresResponse, Restore> ListRestoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestoresRequest request = new ListRestoresRequest
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
            return ListRestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan that contains the Restores to list.
        /// Format: `projects/*/locations/*/restorePlans/*`
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
        /// <returns>A pageable sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRestoresResponse, Restore> ListRestores(RestorePlanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestoresRequest request = new ListRestoresRequest
            {
                ParentAsRestorePlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRestores(request, callSettings);
        }

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="parent">
        /// Required. The RestorePlan that contains the Restores to list.
        /// Format: `projects/*/locations/*/restorePlans/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Restore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRestoresResponse, Restore> ListRestoresAsync(RestorePlanName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRestoresRequest request = new ListRestoresRequest
            {
                ParentAsRestorePlanName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Restore GetRestore(GetRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(GetRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(GetRestoreRequest request, st::CancellationToken cancellationToken) =>
            GetRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Restore GetRestore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestore(new GetRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestoreAsync(new GetRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Restore GetRestore(RestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestore(new GetRestoreRequest
            {
                RestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(RestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRestoreAsync(new GetRestoreRequest
            {
                RestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the restore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Restore> GetRestoreAsync(RestoreName name, st::CancellationToken cancellationToken) =>
            GetRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> UpdateRestore(UpdateRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> UpdateRestoreAsync(UpdateRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> UpdateRestoreAsync(UpdateRestoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRestore</c>.</summary>
        public virtual lro::OperationsClient UpdateRestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> PollOnceUpdateRestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> PollOnceUpdateRestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRestoreOperationsClient, callSettings);

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="restore">
        /// Required. A new version of the Restore resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Restore targeted for update. The values for each of these
        /// updated fields will be taken from the `restore` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore` will be
        /// written to the target Restore resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore` are ignored
        /// and are not used to update the target Restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> UpdateRestore(Restore restore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRestore(new UpdateRestoreRequest
            {
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="restore">
        /// Required. A new version of the Restore resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Restore targeted for update. The values for each of these
        /// updated fields will be taken from the `restore` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore` will be
        /// written to the target Restore resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore` are ignored
        /// and are not used to update the target Restore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> UpdateRestoreAsync(Restore restore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRestoreAsync(new UpdateRestoreRequest
            {
                Restore = gax::GaxPreconditions.CheckNotNull(restore, nameof(restore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="restore">
        /// Required. A new version of the Restore resource that contains updated
        /// fields. This may be sparsely populated if an `update_mask` is provided.
        /// </param>
        /// <param name="updateMask">
        /// Optional. This is used to specify the fields to be overwritten in the
        /// Restore targeted for update. The values for each of these
        /// updated fields will be taken from the `restore` provided
        /// with this request. Field names are relative to the root of the resource.
        /// If no `update_mask` is provided, all fields in `restore` will be
        /// written to the target Restore resource.
        /// Note that OUTPUT_ONLY and IMMUTABLE fields in `restore` are ignored
        /// and are not used to update the target Restore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> UpdateRestoreAsync(Restore restore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRestoreAsync(restore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestore(DeleteRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(DeleteRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(DeleteRestoreRequest request, st::CancellationToken cancellationToken) =>
            DeleteRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRestore</c>.</summary>
        public virtual lro::OperationsClient DeleteRestoreOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRestore(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRestoreOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRestore</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRestoreAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRestoreOperationsClient, callSettings);

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestore(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestore(new DeleteRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestoreAsync(new DeleteRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRestore(RestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestore(new DeleteRestoreRequest
            {
                RestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(RestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRestoreAsync(new DeleteRestoreRequest
            {
                RestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the Restore
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(RestoreName name, st::CancellationToken cancellationToken) =>
            DeleteRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestores(ListVolumeRestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestoresAsync(ListVolumeRestoresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="parent">
        /// Required. The Restore that contains the VolumeRestores to list.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
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
        /// <returns>A pageable sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestores(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
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
            return ListVolumeRestores(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="parent">
        /// Required. The Restore that contains the VolumeRestores to list.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestoresAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
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
            return ListVolumeRestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="parent">
        /// Required. The Restore that contains the VolumeRestores to list.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
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
        /// <returns>A pageable sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestores(RestoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
            {
                ParentAsRestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeRestores(request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="parent">
        /// Required. The Restore that contains the VolumeRestores to list.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeRestore"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestoresAsync(RestoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumeRestoresRequest request = new ListVolumeRestoresRequest
            {
                ParentAsRestoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVolumeRestoresAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeRestore GetVolumeRestore(GetVolumeRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(GetVolumeRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(GetVolumeRestoreRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeRestore GetVolumeRestore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeRestore(new GetVolumeRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeRestoreAsync(new GetVolumeRestoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeRestore GetVolumeRestore(VolumeRestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeRestore(new GetVolumeRestoreRequest
            {
                VolumeRestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(VolumeRestoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeRestoreAsync(new GetVolumeRestoreRequest
            {
                VolumeRestoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="name">
        /// Required. Full name of the VolumeRestore resource.
        /// Format: `projects/*/locations/*/restorePlans/*/restores/*/volumeRestores/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeRestore> GetVolumeRestoreAsync(VolumeRestoreName name, st::CancellationToken cancellationToken) =>
            GetVolumeRestoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetBackupIndexDownloadUrlResponse GetBackupIndexDownloadUrl(GetBackupIndexDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(GetBackupIndexDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(GetBackupIndexDownloadUrlRequest request, st::CancellationToken cancellationToken) =>
            GetBackupIndexDownloadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetBackupIndexDownloadUrlResponse GetBackupIndexDownloadUrl(string backup, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupIndexDownloadUrl(new GetBackupIndexDownloadUrlRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNullOrEmpty(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(string backup, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupIndexDownloadUrlAsync(new GetBackupIndexDownloadUrlRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNullOrEmpty(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(string backup, st::CancellationToken cancellationToken) =>
            GetBackupIndexDownloadUrlAsync(backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetBackupIndexDownloadUrlResponse GetBackupIndexDownloadUrl(BackupName backup, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupIndexDownloadUrl(new GetBackupIndexDownloadUrlRequest
            {
                BackupAsBackupName = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(BackupName backup, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupIndexDownloadUrlAsync(new GetBackupIndexDownloadUrlRequest
            {
                BackupAsBackupName = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="backup">
        /// Required. Full name of Backup resource.
        /// Format:
        /// projects/{project}/locations/{location}/backupPlans/{backup_plan}/backups/{backup}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(BackupName backup, st::CancellationToken cancellationToken) =>
            GetBackupIndexDownloadUrlAsync(backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BackupForGKE client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BackupForGKE allows Kubernetes administrators to configure, execute, and
    /// manage backup and restore operations for their GKE clusters.
    /// </remarks>
    public sealed partial class BackupForGKEClientImpl : BackupForGKEClient
    {
        private readonly gaxgrpc::ApiCall<CreateBackupPlanRequest, lro::Operation> _callCreateBackupPlan;

        private readonly gaxgrpc::ApiCall<ListBackupPlansRequest, ListBackupPlansResponse> _callListBackupPlans;

        private readonly gaxgrpc::ApiCall<GetBackupPlanRequest, BackupPlan> _callGetBackupPlan;

        private readonly gaxgrpc::ApiCall<UpdateBackupPlanRequest, lro::Operation> _callUpdateBackupPlan;

        private readonly gaxgrpc::ApiCall<DeleteBackupPlanRequest, lro::Operation> _callDeleteBackupPlan;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<ListVolumeBackupsRequest, ListVolumeBackupsResponse> _callListVolumeBackups;

        private readonly gaxgrpc::ApiCall<GetVolumeBackupRequest, VolumeBackup> _callGetVolumeBackup;

        private readonly gaxgrpc::ApiCall<CreateRestorePlanRequest, lro::Operation> _callCreateRestorePlan;

        private readonly gaxgrpc::ApiCall<ListRestorePlansRequest, ListRestorePlansResponse> _callListRestorePlans;

        private readonly gaxgrpc::ApiCall<GetRestorePlanRequest, RestorePlan> _callGetRestorePlan;

        private readonly gaxgrpc::ApiCall<UpdateRestorePlanRequest, lro::Operation> _callUpdateRestorePlan;

        private readonly gaxgrpc::ApiCall<DeleteRestorePlanRequest, lro::Operation> _callDeleteRestorePlan;

        private readonly gaxgrpc::ApiCall<CreateRestoreRequest, lro::Operation> _callCreateRestore;

        private readonly gaxgrpc::ApiCall<ListRestoresRequest, ListRestoresResponse> _callListRestores;

        private readonly gaxgrpc::ApiCall<GetRestoreRequest, Restore> _callGetRestore;

        private readonly gaxgrpc::ApiCall<UpdateRestoreRequest, lro::Operation> _callUpdateRestore;

        private readonly gaxgrpc::ApiCall<DeleteRestoreRequest, lro::Operation> _callDeleteRestore;

        private readonly gaxgrpc::ApiCall<ListVolumeRestoresRequest, ListVolumeRestoresResponse> _callListVolumeRestores;

        private readonly gaxgrpc::ApiCall<GetVolumeRestoreRequest, VolumeRestore> _callGetVolumeRestore;

        private readonly gaxgrpc::ApiCall<GetBackupIndexDownloadUrlRequest, GetBackupIndexDownloadUrlResponse> _callGetBackupIndexDownloadUrl;

        /// <summary>
        /// Constructs a client wrapper for the BackupForGKE service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BackupForGKESettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BackupForGKEClientImpl(BackupForGKE.BackupForGKEClient grpcClient, BackupForGKESettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BackupForGKESettings effectiveSettings = settings ?? BackupForGKESettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateBackupPlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupPlanOperationsSettings, logger);
            UpdateBackupPlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupPlanOperationsSettings, logger);
            DeleteBackupPlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupPlanOperationsSettings, logger);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings, logger);
            UpdateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            CreateRestorePlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRestorePlanOperationsSettings, logger);
            UpdateRestorePlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRestorePlanOperationsSettings, logger);
            DeleteRestorePlanOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRestorePlanOperationsSettings, logger);
            CreateRestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRestoreOperationsSettings, logger);
            UpdateRestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRestoreOperationsSettings, logger);
            DeleteRestoreOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRestoreOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateBackupPlan = clientHelper.BuildApiCall<CreateBackupPlanRequest, lro::Operation>("CreateBackupPlan", grpcClient.CreateBackupPlanAsync, grpcClient.CreateBackupPlan, effectiveSettings.CreateBackupPlanSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupPlan);
            Modify_CreateBackupPlanApiCall(ref _callCreateBackupPlan);
            _callListBackupPlans = clientHelper.BuildApiCall<ListBackupPlansRequest, ListBackupPlansResponse>("ListBackupPlans", grpcClient.ListBackupPlansAsync, grpcClient.ListBackupPlans, effectiveSettings.ListBackupPlansSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupPlans);
            Modify_ListBackupPlansApiCall(ref _callListBackupPlans);
            _callGetBackupPlan = clientHelper.BuildApiCall<GetBackupPlanRequest, BackupPlan>("GetBackupPlan", grpcClient.GetBackupPlanAsync, grpcClient.GetBackupPlan, effectiveSettings.GetBackupPlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupPlan);
            Modify_GetBackupPlanApiCall(ref _callGetBackupPlan);
            _callUpdateBackupPlan = clientHelper.BuildApiCall<UpdateBackupPlanRequest, lro::Operation>("UpdateBackupPlan", grpcClient.UpdateBackupPlanAsync, grpcClient.UpdateBackupPlan, effectiveSettings.UpdateBackupPlanSettings).WithGoogleRequestParam("backup_plan.name", request => request.BackupPlan?.Name);
            Modify_ApiCall(ref _callUpdateBackupPlan);
            Modify_UpdateBackupPlanApiCall(ref _callUpdateBackupPlan);
            _callDeleteBackupPlan = clientHelper.BuildApiCall<DeleteBackupPlanRequest, lro::Operation>("DeleteBackupPlan", grpcClient.DeleteBackupPlanAsync, grpcClient.DeleteBackupPlan, effectiveSettings.DeleteBackupPlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupPlan);
            Modify_DeleteBackupPlanApiCall(ref _callDeleteBackupPlan);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, lro::Operation>("CreateBackup", grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
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
            _callListVolumeBackups = clientHelper.BuildApiCall<ListVolumeBackupsRequest, ListVolumeBackupsResponse>("ListVolumeBackups", grpcClient.ListVolumeBackupsAsync, grpcClient.ListVolumeBackups, effectiveSettings.ListVolumeBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumeBackups);
            Modify_ListVolumeBackupsApiCall(ref _callListVolumeBackups);
            _callGetVolumeBackup = clientHelper.BuildApiCall<GetVolumeBackupRequest, VolumeBackup>("GetVolumeBackup", grpcClient.GetVolumeBackupAsync, grpcClient.GetVolumeBackup, effectiveSettings.GetVolumeBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolumeBackup);
            Modify_GetVolumeBackupApiCall(ref _callGetVolumeBackup);
            _callCreateRestorePlan = clientHelper.BuildApiCall<CreateRestorePlanRequest, lro::Operation>("CreateRestorePlan", grpcClient.CreateRestorePlanAsync, grpcClient.CreateRestorePlan, effectiveSettings.CreateRestorePlanSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRestorePlan);
            Modify_CreateRestorePlanApiCall(ref _callCreateRestorePlan);
            _callListRestorePlans = clientHelper.BuildApiCall<ListRestorePlansRequest, ListRestorePlansResponse>("ListRestorePlans", grpcClient.ListRestorePlansAsync, grpcClient.ListRestorePlans, effectiveSettings.ListRestorePlansSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRestorePlans);
            Modify_ListRestorePlansApiCall(ref _callListRestorePlans);
            _callGetRestorePlan = clientHelper.BuildApiCall<GetRestorePlanRequest, RestorePlan>("GetRestorePlan", grpcClient.GetRestorePlanAsync, grpcClient.GetRestorePlan, effectiveSettings.GetRestorePlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRestorePlan);
            Modify_GetRestorePlanApiCall(ref _callGetRestorePlan);
            _callUpdateRestorePlan = clientHelper.BuildApiCall<UpdateRestorePlanRequest, lro::Operation>("UpdateRestorePlan", grpcClient.UpdateRestorePlanAsync, grpcClient.UpdateRestorePlan, effectiveSettings.UpdateRestorePlanSettings).WithGoogleRequestParam("restore_plan.name", request => request.RestorePlan?.Name);
            Modify_ApiCall(ref _callUpdateRestorePlan);
            Modify_UpdateRestorePlanApiCall(ref _callUpdateRestorePlan);
            _callDeleteRestorePlan = clientHelper.BuildApiCall<DeleteRestorePlanRequest, lro::Operation>("DeleteRestorePlan", grpcClient.DeleteRestorePlanAsync, grpcClient.DeleteRestorePlan, effectiveSettings.DeleteRestorePlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRestorePlan);
            Modify_DeleteRestorePlanApiCall(ref _callDeleteRestorePlan);
            _callCreateRestore = clientHelper.BuildApiCall<CreateRestoreRequest, lro::Operation>("CreateRestore", grpcClient.CreateRestoreAsync, grpcClient.CreateRestore, effectiveSettings.CreateRestoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRestore);
            Modify_CreateRestoreApiCall(ref _callCreateRestore);
            _callListRestores = clientHelper.BuildApiCall<ListRestoresRequest, ListRestoresResponse>("ListRestores", grpcClient.ListRestoresAsync, grpcClient.ListRestores, effectiveSettings.ListRestoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRestores);
            Modify_ListRestoresApiCall(ref _callListRestores);
            _callGetRestore = clientHelper.BuildApiCall<GetRestoreRequest, Restore>("GetRestore", grpcClient.GetRestoreAsync, grpcClient.GetRestore, effectiveSettings.GetRestoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRestore);
            Modify_GetRestoreApiCall(ref _callGetRestore);
            _callUpdateRestore = clientHelper.BuildApiCall<UpdateRestoreRequest, lro::Operation>("UpdateRestore", grpcClient.UpdateRestoreAsync, grpcClient.UpdateRestore, effectiveSettings.UpdateRestoreSettings).WithGoogleRequestParam("restore.name", request => request.Restore?.Name);
            Modify_ApiCall(ref _callUpdateRestore);
            Modify_UpdateRestoreApiCall(ref _callUpdateRestore);
            _callDeleteRestore = clientHelper.BuildApiCall<DeleteRestoreRequest, lro::Operation>("DeleteRestore", grpcClient.DeleteRestoreAsync, grpcClient.DeleteRestore, effectiveSettings.DeleteRestoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRestore);
            Modify_DeleteRestoreApiCall(ref _callDeleteRestore);
            _callListVolumeRestores = clientHelper.BuildApiCall<ListVolumeRestoresRequest, ListVolumeRestoresResponse>("ListVolumeRestores", grpcClient.ListVolumeRestoresAsync, grpcClient.ListVolumeRestores, effectiveSettings.ListVolumeRestoresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumeRestores);
            Modify_ListVolumeRestoresApiCall(ref _callListVolumeRestores);
            _callGetVolumeRestore = clientHelper.BuildApiCall<GetVolumeRestoreRequest, VolumeRestore>("GetVolumeRestore", grpcClient.GetVolumeRestoreAsync, grpcClient.GetVolumeRestore, effectiveSettings.GetVolumeRestoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolumeRestore);
            Modify_GetVolumeRestoreApiCall(ref _callGetVolumeRestore);
            _callGetBackupIndexDownloadUrl = clientHelper.BuildApiCall<GetBackupIndexDownloadUrlRequest, GetBackupIndexDownloadUrlResponse>("GetBackupIndexDownloadUrl", grpcClient.GetBackupIndexDownloadUrlAsync, grpcClient.GetBackupIndexDownloadUrl, effectiveSettings.GetBackupIndexDownloadUrlSettings).WithGoogleRequestParam("backup", request => request.Backup);
            Modify_ApiCall(ref _callGetBackupIndexDownloadUrl);
            Modify_GetBackupIndexDownloadUrlApiCall(ref _callGetBackupIndexDownloadUrl);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBackupPlanApiCall(ref gaxgrpc::ApiCall<CreateBackupPlanRequest, lro::Operation> call);

        partial void Modify_ListBackupPlansApiCall(ref gaxgrpc::ApiCall<ListBackupPlansRequest, ListBackupPlansResponse> call);

        partial void Modify_GetBackupPlanApiCall(ref gaxgrpc::ApiCall<GetBackupPlanRequest, BackupPlan> call);

        partial void Modify_UpdateBackupPlanApiCall(ref gaxgrpc::ApiCall<UpdateBackupPlanRequest, lro::Operation> call);

        partial void Modify_DeleteBackupPlanApiCall(ref gaxgrpc::ApiCall<DeleteBackupPlanRequest, lro::Operation> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_ListVolumeBackupsApiCall(ref gaxgrpc::ApiCall<ListVolumeBackupsRequest, ListVolumeBackupsResponse> call);

        partial void Modify_GetVolumeBackupApiCall(ref gaxgrpc::ApiCall<GetVolumeBackupRequest, VolumeBackup> call);

        partial void Modify_CreateRestorePlanApiCall(ref gaxgrpc::ApiCall<CreateRestorePlanRequest, lro::Operation> call);

        partial void Modify_ListRestorePlansApiCall(ref gaxgrpc::ApiCall<ListRestorePlansRequest, ListRestorePlansResponse> call);

        partial void Modify_GetRestorePlanApiCall(ref gaxgrpc::ApiCall<GetRestorePlanRequest, RestorePlan> call);

        partial void Modify_UpdateRestorePlanApiCall(ref gaxgrpc::ApiCall<UpdateRestorePlanRequest, lro::Operation> call);

        partial void Modify_DeleteRestorePlanApiCall(ref gaxgrpc::ApiCall<DeleteRestorePlanRequest, lro::Operation> call);

        partial void Modify_CreateRestoreApiCall(ref gaxgrpc::ApiCall<CreateRestoreRequest, lro::Operation> call);

        partial void Modify_ListRestoresApiCall(ref gaxgrpc::ApiCall<ListRestoresRequest, ListRestoresResponse> call);

        partial void Modify_GetRestoreApiCall(ref gaxgrpc::ApiCall<GetRestoreRequest, Restore> call);

        partial void Modify_UpdateRestoreApiCall(ref gaxgrpc::ApiCall<UpdateRestoreRequest, lro::Operation> call);

        partial void Modify_DeleteRestoreApiCall(ref gaxgrpc::ApiCall<DeleteRestoreRequest, lro::Operation> call);

        partial void Modify_ListVolumeRestoresApiCall(ref gaxgrpc::ApiCall<ListVolumeRestoresRequest, ListVolumeRestoresResponse> call);

        partial void Modify_GetVolumeRestoreApiCall(ref gaxgrpc::ApiCall<GetVolumeRestoreRequest, VolumeRestore> call);

        partial void Modify_GetBackupIndexDownloadUrlApiCall(ref gaxgrpc::ApiCall<GetBackupIndexDownloadUrlRequest, GetBackupIndexDownloadUrlResponse> call);

        partial void OnConstruction(BackupForGKE.BackupForGKEClient grpcClient, BackupForGKESettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackupForGKE client</summary>
        public override BackupForGKE.BackupForGKEClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateBackupPlanRequest(ref CreateBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupPlansRequest(ref ListBackupPlansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupPlanRequest(ref GetBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupPlanRequest(ref UpdateBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupPlanRequest(ref DeleteBackupPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumeBackupsRequest(ref ListVolumeBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeBackupRequest(ref GetVolumeBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRestorePlanRequest(ref CreateRestorePlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRestorePlansRequest(ref ListRestorePlansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRestorePlanRequest(ref GetRestorePlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRestorePlanRequest(ref UpdateRestorePlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRestorePlanRequest(ref DeleteRestorePlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRestoreRequest(ref CreateRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRestoresRequest(ref ListRestoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRestoreRequest(ref GetRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRestoreRequest(ref UpdateRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRestoreRequest(ref DeleteRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumeRestoresRequest(ref ListVolumeRestoresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRestoreRequest(ref GetVolumeRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupIndexDownloadUrlRequest(ref GetBackupIndexDownloadUrlRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateBackupPlan</c>.</summary>
        public override lro::OperationsClient CreateBackupPlanOperationsClient { get; }

        /// <summary>
        /// Creates a new BackupPlan in a given location.
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
        /// Creates a new BackupPlan in a given location.
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
        /// Lists BackupPlans in a given location.
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
        /// Lists BackupPlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPlan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> ListBackupPlansAsync(ListBackupPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupPlansRequest, ListBackupPlansResponse, BackupPlan>(_callListBackupPlans, request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single BackupPlan.
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
        /// Retrieve the details of a single BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupPlan> GetBackupPlanAsync(GetBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPlanRequest(ref request, ref callSettings);
            return _callGetBackupPlan.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBackupPlan</c>.</summary>
        public override lro::OperationsClient UpdateBackupPlanOperationsClient { get; }

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPlan, OperationMetadata> UpdateBackupPlan(UpdateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlan, OperationMetadata>(_callUpdateBackupPlan.Sync(request, callSettings), UpdateBackupPlanOperationsClient);
        }

        /// <summary>
        /// Update a BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPlan, OperationMetadata>> UpdateBackupPlanAsync(UpdateBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPlan, OperationMetadata>(await _callUpdateBackupPlan.Async(request, callSettings).ConfigureAwait(false), UpdateBackupPlanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackupPlan</c>.</summary>
        public override lro::OperationsClient DeleteBackupPlanOperationsClient { get; }

        /// <summary>
        /// Deletes an existing BackupPlan.
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
        /// Deletes an existing BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPlanAsync(DeleteBackupPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPlanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupPlan.Async(request, callSettings).ConfigureAwait(false), DeleteBackupPlanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public override lro::OperationsClient CreateBackupOperationsClient { get; }

        /// <summary>
        /// Creates a Backup for the given BackupPlan.
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
        /// Creates a Backup for the given BackupPlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callCreateBackup.Async(request, callSettings).ConfigureAwait(false), CreateBackupOperationsClient);
        }

        /// <summary>
        /// Lists the Backups for a given BackupPlan.
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
        /// Lists the Backups for a given BackupPlan.
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
        /// Retrieve the details of a single Backup.
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
        /// Retrieve the details of a single Backup.
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
        /// Update a Backup.
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
        /// Update a Backup.
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
        /// Deletes an existing Backup.
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
        /// Deletes an existing Backup.
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
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeBackup"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackups(ListVolumeBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumeBackupsRequest, ListVolumeBackupsResponse, VolumeBackup>(_callListVolumeBackups, request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeBackups for a given Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeBackup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumeBackupsResponse, VolumeBackup> ListVolumeBackupsAsync(ListVolumeBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumeBackupsRequest, ListVolumeBackupsResponse, VolumeBackup>(_callListVolumeBackups, request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeBackup GetVolumeBackup(GetVolumeBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeBackupRequest(ref request, ref callSettings);
            return _callGetVolumeBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeBackup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeBackup> GetVolumeBackupAsync(GetVolumeBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeBackupRequest(ref request, ref callSettings);
            return _callGetVolumeBackup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRestorePlan</c>.</summary>
        public override lro::OperationsClient CreateRestorePlanOperationsClient { get; }

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RestorePlan, OperationMetadata> CreateRestorePlan(CreateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<RestorePlan, OperationMetadata>(_callCreateRestorePlan.Sync(request, callSettings), CreateRestorePlanOperationsClient);
        }

        /// <summary>
        /// Creates a new RestorePlan in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RestorePlan, OperationMetadata>> CreateRestorePlanAsync(CreateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<RestorePlan, OperationMetadata>(await _callCreateRestorePlan.Async(request, callSettings).ConfigureAwait(false), CreateRestorePlanOperationsClient);
        }

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RestorePlan"/> resources.</returns>
        public override gax::PagedEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlans(ListRestorePlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRestorePlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRestorePlansRequest, ListRestorePlansResponse, RestorePlan>(_callListRestorePlans, request, callSettings);
        }

        /// <summary>
        /// Lists RestorePlans in a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RestorePlan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRestorePlansResponse, RestorePlan> ListRestorePlansAsync(ListRestorePlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRestorePlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRestorePlansRequest, ListRestorePlansResponse, RestorePlan>(_callListRestorePlans, request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RestorePlan GetRestorePlan(GetRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRestorePlanRequest(ref request, ref callSettings);
            return _callGetRestorePlan.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RestorePlan> GetRestorePlanAsync(GetRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRestorePlanRequest(ref request, ref callSettings);
            return _callGetRestorePlan.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateRestorePlan</c>.</summary>
        public override lro::OperationsClient UpdateRestorePlanOperationsClient { get; }

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RestorePlan, OperationMetadata> UpdateRestorePlan(UpdateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<RestorePlan, OperationMetadata>(_callUpdateRestorePlan.Sync(request, callSettings), UpdateRestorePlanOperationsClient);
        }

        /// <summary>
        /// Update a RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RestorePlan, OperationMetadata>> UpdateRestorePlanAsync(UpdateRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<RestorePlan, OperationMetadata>(await _callUpdateRestorePlan.Async(request, callSettings).ConfigureAwait(false), UpdateRestorePlanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRestorePlan</c>.</summary>
        public override lro::OperationsClient DeleteRestorePlanOperationsClient { get; }

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRestorePlan(DeleteRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRestorePlan.Sync(request, callSettings), DeleteRestorePlanOperationsClient);
        }

        /// <summary>
        /// Deletes an existing RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestorePlanAsync(DeleteRestorePlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRestorePlanRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRestorePlan.Async(request, callSettings).ConfigureAwait(false), DeleteRestorePlanOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateRestore</c>.</summary>
        public override lro::OperationsClient CreateRestoreOperationsClient { get; }

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Restore, OperationMetadata> CreateRestore(CreateRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(_callCreateRestore.Sync(request, callSettings), CreateRestoreOperationsClient);
        }

        /// <summary>
        /// Creates a new Restore for the given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Restore, OperationMetadata>> CreateRestoreAsync(CreateRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(await _callCreateRestore.Async(request, callSettings).ConfigureAwait(false), CreateRestoreOperationsClient);
        }

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Restore"/> resources.</returns>
        public override gax::PagedEnumerable<ListRestoresResponse, Restore> ListRestores(ListRestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRestoresRequest, ListRestoresResponse, Restore>(_callListRestores, request, callSettings);
        }

        /// <summary>
        /// Lists the Restores for a given RestorePlan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Restore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRestoresResponse, Restore> ListRestoresAsync(ListRestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRestoresRequest, ListRestoresResponse, Restore>(_callListRestores, request, callSettings);
        }

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Restore GetRestore(GetRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRestoreRequest(ref request, ref callSettings);
            return _callGetRestore.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the details of a single Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Restore> GetRestoreAsync(GetRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRestoreRequest(ref request, ref callSettings);
            return _callGetRestore.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateRestore</c>.</summary>
        public override lro::OperationsClient UpdateRestoreOperationsClient { get; }

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Restore, OperationMetadata> UpdateRestore(UpdateRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(_callUpdateRestore.Sync(request, callSettings), UpdateRestoreOperationsClient);
        }

        /// <summary>
        /// Update a Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Restore, OperationMetadata>> UpdateRestoreAsync(UpdateRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(await _callUpdateRestore.Async(request, callSettings).ConfigureAwait(false), UpdateRestoreOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRestore</c>.</summary>
        public override lro::OperationsClient DeleteRestoreOperationsClient { get; }

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRestore(DeleteRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRestore.Sync(request, callSettings), DeleteRestoreOperationsClient);
        }

        /// <summary>
        /// Deletes an existing Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRestoreAsync(DeleteRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRestoreRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRestore.Async(request, callSettings).ConfigureAwait(false), DeleteRestoreOperationsClient);
        }

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeRestore"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestores(ListVolumeRestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeRestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumeRestoresRequest, ListVolumeRestoresResponse, VolumeRestore>(_callListVolumeRestores, request, callSettings);
        }

        /// <summary>
        /// Lists the VolumeRestores for a given Restore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeRestore"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumeRestoresResponse, VolumeRestore> ListVolumeRestoresAsync(ListVolumeRestoresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeRestoresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumeRestoresRequest, ListVolumeRestoresResponse, VolumeRestore>(_callListVolumeRestores, request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeRestore GetVolumeRestore(GetVolumeRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRestoreRequest(ref request, ref callSettings);
            return _callGetVolumeRestore.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the details of a single VolumeRestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeRestore> GetVolumeRestoreAsync(GetVolumeRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRestoreRequest(ref request, ref callSettings);
            return _callGetVolumeRestore.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetBackupIndexDownloadUrlResponse GetBackupIndexDownloadUrl(GetBackupIndexDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupIndexDownloadUrlRequest(ref request, ref callSettings);
            return _callGetBackupIndexDownloadUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the link to the backupIndex.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetBackupIndexDownloadUrlResponse> GetBackupIndexDownloadUrlAsync(GetBackupIndexDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupIndexDownloadUrlRequest(ref request, ref callSettings);
            return _callGetBackupIndexDownloadUrl.Async(request, callSettings);
        }
    }

    public partial class ListBackupPlansRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumeBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRestorePlansRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRestoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumeRestoresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupPlansResponse : gaxgrpc::IPageResponse<BackupPlan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupPlan> GetEnumerator() => BackupPlans.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumeBackupsResponse : gaxgrpc::IPageResponse<VolumeBackup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VolumeBackup> GetEnumerator() => VolumeBackups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRestorePlansResponse : gaxgrpc::IPageResponse<RestorePlan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RestorePlan> GetEnumerator() => RestorePlans.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRestoresResponse : gaxgrpc::IPageResponse<Restore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Restore> GetEnumerator() => Restores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumeRestoresResponse : gaxgrpc::IPageResponse<VolumeRestore>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VolumeRestore> GetEnumerator() => VolumeRestores.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BackupForGKE
    {
        public partial class BackupForGKEClient
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

    public static partial class BackupForGKE
    {
        public partial class BackupForGKEClient
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
