// Copyright 2026 Google LLC
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

namespace Google.Cloud.Memorystore.V1Beta
{
    /// <summary>Settings for <see cref="MemorystoreClient"/> instances.</summary>
    public sealed partial class MemorystoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MemorystoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MemorystoreSettings"/>.</returns>
        public static MemorystoreSettings GetDefault() => new MemorystoreSettings();

        /// <summary>Constructs a new <see cref="MemorystoreSettings"/> object with default settings.</summary>
        public MemorystoreSettings()
        {
        }

        private MemorystoreSettings(MemorystoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAclPoliciesSettings = existing.ListAclPoliciesSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            GetAclPolicySettings = existing.GetAclPolicySettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateAclPolicySettings = existing.CreateAclPolicySettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateAclPolicySettings = existing.UpdateAclPolicySettings;
            UpdateAclPolicyOperationsSettings = existing.UpdateAclPolicyOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            DeleteAclPolicySettings = existing.DeleteAclPolicySettings;
            DeleteAclPolicyOperationsSettings = existing.DeleteAclPolicyOperationsSettings.Clone();
            GetAclPolicyRevisionSettings = existing.GetAclPolicyRevisionSettings;
            ListAclPolicyRevisionsSettings = existing.ListAclPolicyRevisionsSettings;
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            GetCertificateAuthoritySettings = existing.GetCertificateAuthoritySettings;
            GetSharedRegionalCertificateAuthoritySettings = existing.GetSharedRegionalCertificateAuthoritySettings;
            RescheduleMaintenanceSettings = existing.RescheduleMaintenanceSettings;
            RescheduleMaintenanceOperationsSettings = existing.RescheduleMaintenanceOperationsSettings.Clone();
            ListBackupCollectionsSettings = existing.ListBackupCollectionsSettings;
            GetBackupCollectionSettings = existing.GetBackupCollectionSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            ExportBackupSettings = existing.ExportBackupSettings;
            ExportBackupOperationsSettings = existing.ExportBackupOperationsSettings.Clone();
            BackupInstanceSettings = existing.BackupInstanceSettings;
            BackupInstanceOperationsSettings = existing.BackupInstanceOperationsSettings.Clone();
            StartMigrationSettings = existing.StartMigrationSettings;
            StartMigrationOperationsSettings = existing.StartMigrationOperationsSettings.Clone();
            FinishMigrationSettings = existing.FinishMigrationSettings;
            FinishMigrationOperationsSettings = existing.FinishMigrationOperationsSettings.Clone();
            ListTokenAuthUsersSettings = existing.ListTokenAuthUsersSettings;
            GetTokenAuthUserSettings = existing.GetTokenAuthUserSettings;
            ListAuthTokensSettings = existing.ListAuthTokensSettings;
            GetAuthTokenSettings = existing.GetAuthTokenSettings;
            AddTokenAuthUserSettings = existing.AddTokenAuthUserSettings;
            AddTokenAuthUserOperationsSettings = existing.AddTokenAuthUserOperationsSettings.Clone();
            DeleteTokenAuthUserSettings = existing.DeleteTokenAuthUserSettings;
            DeleteTokenAuthUserOperationsSettings = existing.DeleteTokenAuthUserOperationsSettings.Clone();
            AddAuthTokenSettings = existing.AddAuthTokenSettings;
            AddAuthTokenOperationsSettings = existing.AddAuthTokenOperationsSettings.Clone();
            DeleteAuthTokenSettings = existing.DeleteAuthTokenSettings;
            DeleteAuthTokenOperationsSettings = existing.DeleteAuthTokenOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MemorystoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListAclPolicies</c> and <c>MemorystoreClient.ListAclPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListAclPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListInstances</c> and <c>MemorystoreClient.ListInstancesAsync</c>.
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
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetAclPolicy</c> and <c>MemorystoreClient.GetAclPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetAclPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetInstance</c> and <c>MemorystoreClient.GetInstanceAsync</c>.
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
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.CreateAclPolicy</c> and <c>MemorystoreClient.CreateAclPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAclPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.CreateInstance</c> and <c>MemorystoreClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.CreateInstance</c> and
        /// <c>MemorystoreClient.CreateInstanceAsync</c>.
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
        /// <c>MemorystoreClient.UpdateAclPolicy</c> and <c>MemorystoreClient.UpdateAclPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAclPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.UpdateAclPolicy</c> and
        /// <c>MemorystoreClient.UpdateAclPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateAclPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.UpdateInstance</c> and <c>MemorystoreClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.UpdateInstance</c> and
        /// <c>MemorystoreClient.UpdateInstanceAsync</c>.
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
        /// <c>MemorystoreClient.DeleteAclPolicy</c> and <c>MemorystoreClient.DeleteAclPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAclPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteAclPolicy</c> and
        /// <c>MemorystoreClient.DeleteAclPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteAclPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetAclPolicyRevision</c> and <c>MemorystoreClient.GetAclPolicyRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetAclPolicyRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListAclPolicyRevisions</c> and <c>MemorystoreClient.ListAclPolicyRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListAclPolicyRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteInstance</c> and <c>MemorystoreClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteInstance</c> and
        /// <c>MemorystoreClient.DeleteInstanceAsync</c>.
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
        /// <c>MemorystoreClient.GetCertificateAuthority</c> and <c>MemorystoreClient.GetCertificateAuthorityAsync</c>.
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
        public gaxgrpc::CallSettings GetCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetSharedRegionalCertificateAuthority</c> and
        /// <c>MemorystoreClient.GetSharedRegionalCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSharedRegionalCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.RescheduleMaintenance</c> and <c>MemorystoreClient.RescheduleMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RescheduleMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.RescheduleMaintenance</c> and
        /// <c>MemorystoreClient.RescheduleMaintenanceAsync</c>.
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
        public lro::OperationsSettings RescheduleMaintenanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListBackupCollections</c> and <c>MemorystoreClient.ListBackupCollectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupCollectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetBackupCollection</c> and <c>MemorystoreClient.GetBackupCollectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupCollectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListBackups</c> and <c>MemorystoreClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>MemorystoreClient.GetBackup</c>
        ///  and <c>MemorystoreClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteBackup</c> and <c>MemorystoreClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteBackup</c> and
        /// <c>MemorystoreClient.DeleteBackupAsync</c>.
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
        /// <c>MemorystoreClient.ExportBackup</c> and <c>MemorystoreClient.ExportBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.ExportBackup</c> and
        /// <c>MemorystoreClient.ExportBackupAsync</c>.
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
        public lro::OperationsSettings ExportBackupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.BackupInstance</c> and <c>MemorystoreClient.BackupInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BackupInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.BackupInstance</c> and
        /// <c>MemorystoreClient.BackupInstanceAsync</c>.
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
        public lro::OperationsSettings BackupInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.StartMigration</c> and <c>MemorystoreClient.StartMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.StartMigration</c> and
        /// <c>MemorystoreClient.StartMigrationAsync</c>.
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
        public lro::OperationsSettings StartMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.FinishMigration</c> and <c>MemorystoreClient.FinishMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinishMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.FinishMigration</c> and
        /// <c>MemorystoreClient.FinishMigrationAsync</c>.
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
        public lro::OperationsSettings FinishMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListTokenAuthUsers</c> and <c>MemorystoreClient.ListTokenAuthUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTokenAuthUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetTokenAuthUser</c> and <c>MemorystoreClient.GetTokenAuthUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTokenAuthUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.ListAuthTokens</c> and <c>MemorystoreClient.ListAuthTokensAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuthTokensSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.GetAuthToken</c> and <c>MemorystoreClient.GetAuthTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuthTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.AddTokenAuthUser</c> and <c>MemorystoreClient.AddTokenAuthUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddTokenAuthUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.AddTokenAuthUser</c> and
        /// <c>MemorystoreClient.AddTokenAuthUserAsync</c>.
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
        public lro::OperationsSettings AddTokenAuthUserOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteTokenAuthUser</c> and <c>MemorystoreClient.DeleteTokenAuthUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTokenAuthUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteTokenAuthUser</c> and
        /// <c>MemorystoreClient.DeleteTokenAuthUserAsync</c>.
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
        public lro::OperationsSettings DeleteTokenAuthUserOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.AddAuthToken</c> and <c>MemorystoreClient.AddAuthTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAuthTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.AddAuthToken</c> and
        /// <c>MemorystoreClient.AddAuthTokenAsync</c>.
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
        public lro::OperationsSettings AddAuthTokenOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MemorystoreClient.DeleteAuthToken</c> and <c>MemorystoreClient.DeleteAuthTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAuthTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MemorystoreClient.DeleteAuthToken</c> and
        /// <c>MemorystoreClient.DeleteAuthTokenAsync</c>.
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
        public lro::OperationsSettings DeleteAuthTokenOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MemorystoreSettings"/> object.</returns>
        public MemorystoreSettings Clone() => new MemorystoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MemorystoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MemorystoreClientBuilder : gaxgrpc::ClientBuilderBase<MemorystoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MemorystoreSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MemorystoreClientBuilder() : base(MemorystoreClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MemorystoreClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MemorystoreClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MemorystoreClient Build()
        {
            MemorystoreClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MemorystoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MemorystoreClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MemorystoreClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MemorystoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MemorystoreClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MemorystoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MemorystoreClient.ChannelPool;
    }

    /// <summary>Memorystore client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class MemorystoreClient
    {
        /// <summary>
        /// The default endpoint for the Memorystore service, which is a host of "memorystore.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "memorystore.googleapis.com:443";

        /// <summary>The default Memorystore scopes.</summary>
        /// <remarks>
        /// The default Memorystore scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/memorystore.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/memorystore.read-write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/memorystore.read-only",
            "https://www.googleapis.com/auth/memorystore.read-write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Memorystore.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MemorystoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemorystoreClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MemorystoreClient"/>.</returns>
        public static stt::Task<MemorystoreClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MemorystoreClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MemorystoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MemorystoreClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MemorystoreClient"/>.</returns>
        public static MemorystoreClient Create() => new MemorystoreClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MemorystoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MemorystoreSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MemorystoreClient"/>.</returns>
        internal static MemorystoreClient Create(grpccore::CallInvoker callInvoker, MemorystoreSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Memorystore.MemorystoreClient grpcClient = new Memorystore.MemorystoreClient(callInvoker);
            return new MemorystoreClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Memorystore client</summary>
        public virtual Memorystore.MemorystoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPolicies(ListAclPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPoliciesAsync(ListAclPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPoliciesRequest request = new ListAclPoliciesRequest
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
            return ListAclPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPoliciesRequest request = new ListAclPoliciesRequest
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
            return ListAclPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPoliciesRequest request = new ListAclPoliciesRequest
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
            return ListAclPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPoliciesRequest request = new ListAclPoliciesRequest
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
            return ListAclPoliciesAsync(request, callSettings);
        }

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
        /// Required. The parent to list instances from.
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
        /// Required. The parent to list instances from.
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
        /// Required. The parent to list instances from.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists Instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list instances from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
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
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy GetAclPolicy(GetAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(GetAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(GetAclPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAclPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy GetAclPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicy(new GetAclPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyAsync(new GetAclPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAclPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy GetAclPolicy(AclPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicy(new GetAclPolicyRequest
            {
                AclPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(AclPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyAsync(new GetAclPolicyRequest
            {
                AclPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> GetAclPolicyAsync(AclPolicyName name, st::CancellationToken cancellationToken) =>
            GetAclPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to retrieve.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy CreateAclPolicy(CreateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(CreateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(CreateAclPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAclPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy CreateAclPolicy(string parent, AclPolicy aclPolicy, string aclPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAclPolicy(new CreateAclPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AclPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(aclPolicyId, nameof(aclPolicyId)),
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(string parent, AclPolicy aclPolicy, string aclPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAclPolicyAsync(new CreateAclPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AclPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(aclPolicyId, nameof(aclPolicyId)),
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(string parent, AclPolicy aclPolicy, string aclPolicyId, st::CancellationToken cancellationToken) =>
            CreateAclPolicyAsync(parent, aclPolicy, aclPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicy CreateAclPolicy(gagr::LocationName parent, AclPolicy aclPolicy, string aclPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAclPolicy(new CreateAclPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AclPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(aclPolicyId, nameof(aclPolicyId)),
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(gagr::LocationName parent, AclPolicy aclPolicy, string aclPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAclPolicyAsync(new CreateAclPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AclPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(aclPolicyId, nameof(aclPolicyId)),
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy location using the form:
        /// `projects/{project}/locations/{location}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="aclPolicy">
        /// Required. The ACL policy that is to be created.
        /// </param>
        /// <param name="aclPolicyId">
        /// Required. The logical name of the ACL policy in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicy> CreateAclPolicyAsync(gagr::LocationName parent, AclPolicy aclPolicy, string aclPolicyId, st::CancellationToken cancellationToken) =>
            CreateAclPolicyAsync(parent, aclPolicy, aclPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
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
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
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
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this instance will be created.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID to use for the instance, which will become the final
        /// component of the instance's resource name.
        /// 
        /// This value is subject to the following restrictions:
        /// 
        /// * Must be 4-63 characters in length
        /// * Must begin with a letter or digit
        /// * Must contain only lowercase letters, digits, and hyphens
        /// * Must not end with a hyphen
        /// * Must be unique within a location
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AclPolicy, OperationMetadata> UpdateAclPolicy(UpdateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AclPolicy, OperationMetadata>> UpdateAclPolicyAsync(UpdateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AclPolicy, OperationMetadata>> UpdateAclPolicyAsync(UpdateAclPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAclPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAclPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateAclPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAclPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AclPolicy, OperationMetadata> PollOnceUpdateAclPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AclPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAclPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAclPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AclPolicy, OperationMetadata>> PollOnceUpdateAclPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AclPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAclPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="aclPolicy">
        /// Required. The ACL policy to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to be updated. At least one path must be supplied
        /// in this field. The elements of the repeated paths field may only include
        /// these fields from `AclPolicy`:
        /// 
        /// *   `rules`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AclPolicy, OperationMetadata> UpdateAclPolicy(AclPolicy aclPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAclPolicy(new UpdateAclPolicyRequest
            {
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="aclPolicy">
        /// Required. The ACL policy to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to be updated. At least one path must be supplied
        /// in this field. The elements of the repeated paths field may only include
        /// these fields from `AclPolicy`:
        /// 
        /// *   `rules`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AclPolicy, OperationMetadata>> UpdateAclPolicyAsync(AclPolicy aclPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAclPolicyAsync(new UpdateAclPolicyRequest
            {
                AclPolicy = gax::GaxPreconditions.CheckNotNull(aclPolicy, nameof(aclPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="aclPolicy">
        /// Required. The ACL policy to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to be updated. At least one path must be supplied
        /// in this field. The elements of the repeated paths field may only include
        /// these fields from `AclPolicy`:
        /// 
        /// *   `rules`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AclPolicy, OperationMetadata>> UpdateAclPolicyAsync(AclPolicy aclPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAclPolicyAsync(aclPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
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
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
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
        /// Required. The instance to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to be updated on the instance. At least one
        /// field must be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAclPolicy(DeleteAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(DeleteAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(DeleteAclPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAclPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAclPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteAclPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAclPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAclPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAclPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAclPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAclPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAclPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAclPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAclPolicy(new DeleteAclPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAclPolicyAsync(new DeleteAclPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAclPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAclPolicy(AclPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAclPolicy(new DeleteAclPolicyRequest
            {
                AclPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(AclPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAclPolicyAsync(new DeleteAclPolicyRequest
            {
                AclPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy_id}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(AclPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAclPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicyRevision GetAclPolicyRevision(GetAclPolicyRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(GetAclPolicyRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(GetAclPolicyRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetAclPolicyRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicyRevision GetAclPolicyRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyRevision(new GetAclPolicyRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyRevisionAsync(new GetAclPolicyRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetAclPolicyRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AclPolicyRevision GetAclPolicyRevision(AclPolicyRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyRevision(new GetAclPolicyRevisionRequest
            {
                AclPolicyRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(AclPolicyRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAclPolicyRevisionAsync(new GetAclPolicyRevisionRequest
            {
                AclPolicyRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="name">
        /// Required. Memorystore ACL policy revision resource name using the form:
        /// `projects/{project}/locations/{location}/aclPolicies/{acl_policy}/revisions/{revision}`
        /// where `location` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(AclPolicyRevisionName name, st::CancellationToken cancellationToken) =>
            GetAclPolicyRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisions(ListAclPolicyRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisionsAsync(ListAclPolicyRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy to list revisions for.
        /// Format: "projects/{project}/locations/{location}/aclPolicies/{acl_policy}"
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
        /// <returns>A pageable sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPolicyRevisionsRequest request = new ListAclPolicyRevisionsRequest
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
            return ListAclPolicyRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy to list revisions for.
        /// Format: "projects/{project}/locations/{location}/aclPolicies/{acl_policy}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPolicyRevisionsRequest request = new ListAclPolicyRevisionsRequest
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
            return ListAclPolicyRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy to list revisions for.
        /// Format: "projects/{project}/locations/{location}/aclPolicies/{acl_policy}"
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
        /// <returns>A pageable sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisions(AclPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPolicyRevisionsRequest request = new ListAclPolicyRevisionsRequest
            {
                ParentAsAclPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAclPolicyRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ACL policy to list revisions for.
        /// Format: "projects/{project}/locations/{location}/aclPolicies/{acl_policy}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisionsAsync(AclPolicyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAclPolicyRevisionsRequest request = new ListAclPolicyRevisionsRequest
            {
                ParentAsAclPolicyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAclPolicyRevisionsAsync(request, callSettings);
        }

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
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// Required. The name of the instance to delete.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the certificate authority.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/certificateAuthority
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedRegionalCertificateAuthority GetSharedRegionalCertificateAuthority(GetSharedRegionalCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(GetSharedRegionalCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(GetSharedRegionalCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetSharedRegionalCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedRegionalCertificateAuthority GetSharedRegionalCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedRegionalCertificateAuthority(new GetSharedRegionalCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedRegionalCertificateAuthorityAsync(new GetSharedRegionalCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetSharedRegionalCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedRegionalCertificateAuthority GetSharedRegionalCertificateAuthority(SharedRegionalCertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedRegionalCertificateAuthority(new GetSharedRegionalCertificateAuthorityRequest
            {
                SharedRegionalCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(SharedRegionalCertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedRegionalCertificateAuthorityAsync(new GetSharedRegionalCertificateAuthorityRequest
            {
                SharedRegionalCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="name">
        /// Required. Regional certificate authority resource name using the form:
        /// `projects/{project}/locations/{location}/sharedRegionalCertificateAuthority`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(SharedRegionalCertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            GetSharedRegionalCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public virtual lro::OperationsClient RescheduleMaintenanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RescheduleMaintenance</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRescheduleMaintenance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RescheduleMaintenance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRescheduleMaintenanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RescheduleMaintenanceOperationsClient, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(string name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenance(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, gaxgrpc::CallSettings callSettings = null) =>
            RescheduleMaintenanceAsync(new RescheduleMaintenanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                RescheduleType = rescheduleType,
                ScheduleTime = scheduleTime,
            }, callSettings);

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the instance to reschedule maintenance for:
        /// `projects/{project}/locations/{location_id}/instances/{instance}`
        /// </param>
        /// <param name="rescheduleType">
        /// Required. If reschedule type is SPECIFIC_TIME, schedule_time must be set.
        /// </param>
        /// <param name="scheduleTime">
        /// Optional. Timestamp when the maintenance shall be rescheduled to if
        /// reschedule_type=SPECIFIC_TIME, in RFC 3339 format.
        /// Example: `2012-11-15T16:19:00.094Z`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(InstanceName name, RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType, wkt::Timestamp scheduleTime, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollections(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollections(request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection location using the
        /// form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a Google Cloud region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
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
            return ListBackupCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollection(new GetBackupCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollectionAsync(new GetBackupCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupCollection GetBackupCollection(BackupCollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollection(new GetBackupCollectionRequest
            {
                BackupCollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(BackupCollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupCollectionAsync(new GetBackupCollectionRequest
            {
                BackupCollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backupCollection resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupCollection> GetBackupCollectionAsync(BackupCollectionName name, st::CancellationToken cancellationToken) =>
            GetBackupCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(BackupCollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists all backups owned by a backup collection.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the backupCollection using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(BackupCollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific backup.
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
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance backup resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/backupCollections/{backup_collection_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> ExportBackup(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, st::CancellationToken cancellationToken) =>
            ExportBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportBackup</c>.</summary>
        public virtual lro::OperationsClient ExportBackupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> PollOnceExportBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> PollOnceExportBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBackupOperationsClient, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BackupInstance</c>.</summary>
        public virtual lro::OperationsClient BackupInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BackupInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceBackupInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BackupInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BackupInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceBackupInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BackupInstanceOperationsClient, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstance(new BackupInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstanceAsync(new BackupInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> BackupInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstance(new BackupInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            BackupInstanceAsync(new BackupInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="name">
        /// Required. Instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a Google Cloud region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            BackupInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the migration of a source instance to the target Memorystore
        /// instance.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Set up replication with the source instance and replicate any writes to
        /// the source instance.
        /// 2. Only allow reads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> StartMigration(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the migration of a source instance to the target Memorystore
        /// instance.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Set up replication with the source instance and replicate any writes to
        /// the source instance.
        /// 2. Only allow reads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the migration of a source instance to the target Memorystore
        /// instance.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Set up replication with the source instance and replicate any writes to
        /// the source instance.
        /// 2. Only allow reads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, st::CancellationToken cancellationToken) =>
            StartMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartMigration</c>.</summary>
        public virtual lro::OperationsClient StartMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceStartMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceStartMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationOperationsClient, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FinishMigration(FinishMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(FinishMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(FinishMigrationRequest request, st::CancellationToken cancellationToken) =>
            FinishMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FinishMigration</c>.</summary>
        public virtual lro::OperationsClient FinishMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>FinishMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceFinishMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FinishMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FinishMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceFinishMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FinishMigrationOperationsClient, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FinishMigration(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            FinishMigration(new FinishMigrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            FinishMigrationAsync(new FinishMigrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            FinishMigrationAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FinishMigration(InstanceName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            FinishMigration(new FinishMigrationRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(InstanceName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            FinishMigrationAsync(new FinishMigrationRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the instance to finalize migration on.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="force">
        /// Optional. By default, the `FinishMigration` operation ensures the target
        /// replication offset to catch up to the source offset as of the time of the
        /// call. Set this field to `true` to bypass this offset verification check.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(InstanceName name, bool force, st::CancellationToken cancellationToken) =>
            FinishMigrationAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsers(ListTokenAuthUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsersAsync(ListTokenAuthUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list token auth users from.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTokenAuthUsersRequest request = new ListTokenAuthUsersRequest
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
            return ListTokenAuthUsers(request, callSettings);
        }

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list token auth users from.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTokenAuthUsersRequest request = new ListTokenAuthUsersRequest
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
            return ListTokenAuthUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list token auth users from.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsers(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTokenAuthUsersRequest request = new ListTokenAuthUsersRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTokenAuthUsers(request, callSettings);
        }

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list token auth users from.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsersAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTokenAuthUsersRequest request = new ListTokenAuthUsersRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTokenAuthUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TokenAuthUser GetTokenAuthUser(GetTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(GetTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(GetTokenAuthUserRequest request, st::CancellationToken cancellationToken) =>
            GetTokenAuthUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TokenAuthUser GetTokenAuthUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTokenAuthUser(new GetTokenAuthUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTokenAuthUserAsync(new GetTokenAuthUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(string name, st::CancellationToken cancellationToken) =>
            GetTokenAuthUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TokenAuthUser GetTokenAuthUser(TokenAuthUserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTokenAuthUser(new GetTokenAuthUserRequest
            {
                TokenAuthUserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(TokenAuthUserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTokenAuthUserAsync(new GetTokenAuthUserRequest
            {
                TokenAuthUserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a basic auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TokenAuthUser> GetTokenAuthUserAsync(TokenAuthUserName name, st::CancellationToken cancellationToken) =>
            GetTokenAuthUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokens(ListAuthTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokensAsync(ListAuthTokensRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list auth tokens from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
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
        /// <returns>A pageable sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokens(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthTokensRequest request = new ListAuthTokensRequest
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
            return ListAuthTokens(request, callSettings);
        }

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list auth tokens from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokensAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthTokensRequest request = new ListAuthTokensRequest
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
            return ListAuthTokensAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list auth tokens from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
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
        /// <returns>A pageable sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokens(TokenAuthUserName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthTokensRequest request = new ListAuthTokensRequest
            {
                ParentAsTokenAuthUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAuthTokens(request, callSettings);
        }

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent to list auth tokens from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AuthToken"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokensAsync(TokenAuthUserName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAuthTokensRequest request = new ListAuthTokensRequest
            {
                ParentAsTokenAuthUserName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAuthTokensAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthToken GetAuthToken(GetAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(GetAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(GetAuthTokenRequest request, st::CancellationToken cancellationToken) =>
            GetAuthTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthToken GetAuthToken(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthToken(new GetAuthTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthTokenAsync(new GetAuthTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(string name, st::CancellationToken cancellationToken) =>
            GetAuthTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthToken GetAuthToken(AuthTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthToken(new GetAuthTokenRequest
            {
                AuthTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(AuthTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAuthTokenAsync(new GetAuthTokenRequest
            {
                AuthTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of token auth user for a token auth enabled instance.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{auth_token}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthToken> GetAuthTokenAsync(AuthTokenName name, st::CancellationToken cancellationToken) =>
            GetAuthTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> AddTokenAuthUser(AddTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(AddTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(AddTokenAuthUserRequest request, st::CancellationToken cancellationToken) =>
            AddTokenAuthUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddTokenAuthUser</c>.</summary>
        public virtual lro::OperationsClient AddTokenAuthUserOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddTokenAuthUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceAddTokenAuthUser(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddTokenAuthUserOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddTokenAuthUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceAddTokenAuthUserAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddTokenAuthUserOperationsClient, callSettings);

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> AddTokenAuthUser(string instance, string tokenAuthUser, gaxgrpc::CallSettings callSettings = null) =>
            AddTokenAuthUser(new AddTokenAuthUserRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
            }, callSettings);

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(string instance, string tokenAuthUser, gaxgrpc::CallSettings callSettings = null) =>
            AddTokenAuthUserAsync(new AddTokenAuthUserRequest
            {
                Instance = gax::GaxPreconditions.CheckNotNullOrEmpty(instance, nameof(instance)),
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
            }, callSettings);

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(string instance, string tokenAuthUser, st::CancellationToken cancellationToken) =>
            AddTokenAuthUserAsync(instance, tokenAuthUser, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> AddTokenAuthUser(InstanceName instance, string tokenAuthUser, gaxgrpc::CallSettings callSettings = null) =>
            AddTokenAuthUser(new AddTokenAuthUserRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
            }, callSettings);

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(InstanceName instance, string tokenAuthUser, gaxgrpc::CallSettings callSettings = null) =>
            AddTokenAuthUserAsync(new AddTokenAuthUserRequest
            {
                InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
            }, callSettings);

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="instance">
        /// Required. The instance resource that this token auth user will be added
        /// for. Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(InstanceName instance, string tokenAuthUser, st::CancellationToken cancellationToken) =>
            AddTokenAuthUserAsync(instance, tokenAuthUser, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTokenAuthUser(DeleteTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(DeleteTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(DeleteTokenAuthUserRequest request, st::CancellationToken cancellationToken) =>
            DeleteTokenAuthUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTokenAuthUser</c>.</summary>
        public virtual lro::OperationsClient DeleteTokenAuthUserOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTokenAuthUser</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTokenAuthUser(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTokenAuthUserOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTokenAuthUser</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTokenAuthUserAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTokenAuthUserOperationsClient, callSettings);

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTokenAuthUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTokenAuthUser(new DeleteTokenAuthUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTokenAuthUserAsync(new DeleteTokenAuthUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTokenAuthUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTokenAuthUser(TokenAuthUserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTokenAuthUser(new DeleteTokenAuthUserRequest
            {
                TokenAuthUserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(TokenAuthUserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTokenAuthUserAsync(new DeleteTokenAuthUserRequest
            {
                TokenAuthUserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(TokenAuthUserName name, st::CancellationToken cancellationToken) =>
            DeleteTokenAuthUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TokenAuthUser, OperationMetadata> AddAuthToken(AddAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(AddAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(AddAuthTokenRequest request, st::CancellationToken cancellationToken) =>
            AddAuthTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddAuthToken</c>.</summary>
        public virtual lro::OperationsClient AddAuthTokenOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddAuthToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TokenAuthUser, OperationMetadata> PollOnceAddAuthToken(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TokenAuthUser, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAuthTokenOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddAuthToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> PollOnceAddAuthTokenAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TokenAuthUser, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAuthTokenOperationsClient, callSettings);

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TokenAuthUser, OperationMetadata> AddAuthToken(string tokenAuthUser, AuthToken authToken, gaxgrpc::CallSettings callSettings = null) =>
            AddAuthToken(new AddAuthTokenRequest
            {
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
                AuthToken = gax::GaxPreconditions.CheckNotNull(authToken, nameof(authToken)),
            }, callSettings);

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(string tokenAuthUser, AuthToken authToken, gaxgrpc::CallSettings callSettings = null) =>
            AddAuthTokenAsync(new AddAuthTokenRequest
            {
                TokenAuthUser = gax::GaxPreconditions.CheckNotNullOrEmpty(tokenAuthUser, nameof(tokenAuthUser)),
                AuthToken = gax::GaxPreconditions.CheckNotNull(authToken, nameof(authToken)),
            }, callSettings);

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(string tokenAuthUser, AuthToken authToken, st::CancellationToken cancellationToken) =>
            AddAuthTokenAsync(tokenAuthUser, authToken, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TokenAuthUser, OperationMetadata> AddAuthToken(TokenAuthUserName tokenAuthUser, AuthToken authToken, gaxgrpc::CallSettings callSettings = null) =>
            AddAuthToken(new AddAuthTokenRequest
            {
                TokenAuthUserAsTokenAuthUserName = gax::GaxPreconditions.CheckNotNull(tokenAuthUser, nameof(tokenAuthUser)),
                AuthToken = gax::GaxPreconditions.CheckNotNull(authToken, nameof(authToken)),
            }, callSettings);

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(TokenAuthUserName tokenAuthUser, AuthToken authToken, gaxgrpc::CallSettings callSettings = null) =>
            AddAuthTokenAsync(new AddAuthTokenRequest
            {
                TokenAuthUserAsTokenAuthUserName = gax::GaxPreconditions.CheckNotNull(tokenAuthUser, nameof(tokenAuthUser)),
                AuthToken = gax::GaxPreconditions.CheckNotNull(authToken, nameof(authToken)),
            }, callSettings);

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="tokenAuthUser">
        /// Required. The name of the token auth user resource that this token will be
        /// added for.
        /// </param>
        /// <param name="authToken">
        /// Required. The auth token to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(TokenAuthUserName tokenAuthUser, AuthToken authToken, st::CancellationToken cancellationToken) =>
            AddAuthTokenAsync(tokenAuthUser, authToken, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthToken(DeleteAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(DeleteAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(DeleteAuthTokenRequest request, st::CancellationToken cancellationToken) =>
            DeleteAuthTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAuthToken</c>.</summary>
        public virtual lro::OperationsClient DeleteAuthTokenOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAuthToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAuthToken(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthTokenOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAuthToken</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAuthTokenAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAuthTokenOperationsClient, callSettings);

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthToken(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthToken(new DeleteAuthTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthTokenAsync(new DeleteAuthTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAuthTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthToken(AuthTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthToken(new DeleteAuthTokenRequest
            {
                AuthTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(AuthTokenName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAuthTokenAsync(new DeleteAuthTokenRequest
            {
                AuthTokenName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the token auth user resource that this token will be
        /// deleted from. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/tokenAuthUsers/{token_auth_user}/authTokens/{name}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(AuthTokenName name, st::CancellationToken cancellationToken) =>
            DeleteAuthTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Memorystore client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class MemorystoreClientImpl : MemorystoreClient
    {
        private readonly gaxgrpc::ApiCall<ListAclPoliciesRequest, ListAclPoliciesResponse> _callListAclPolicies;

        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetAclPolicyRequest, AclPolicy> _callGetAclPolicy;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateAclPolicyRequest, AclPolicy> _callCreateAclPolicy;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateAclPolicyRequest, lro::Operation> _callUpdateAclPolicy;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteAclPolicyRequest, lro::Operation> _callDeleteAclPolicy;

        private readonly gaxgrpc::ApiCall<GetAclPolicyRevisionRequest, AclPolicyRevision> _callGetAclPolicyRevision;

        private readonly gaxgrpc::ApiCall<ListAclPolicyRevisionsRequest, ListAclPolicyRevisionsResponse> _callListAclPolicyRevisions;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> _callGetCertificateAuthority;

        private readonly gaxgrpc::ApiCall<GetSharedRegionalCertificateAuthorityRequest, SharedRegionalCertificateAuthority> _callGetSharedRegionalCertificateAuthority;

        private readonly gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> _callRescheduleMaintenance;

        private readonly gaxgrpc::ApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse> _callListBackupCollections;

        private readonly gaxgrpc::ApiCall<GetBackupCollectionRequest, BackupCollection> _callGetBackupCollection;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<ExportBackupRequest, lro::Operation> _callExportBackup;

        private readonly gaxgrpc::ApiCall<BackupInstanceRequest, lro::Operation> _callBackupInstance;

        private readonly gaxgrpc::ApiCall<StartMigrationRequest, lro::Operation> _callStartMigration;

        private readonly gaxgrpc::ApiCall<FinishMigrationRequest, lro::Operation> _callFinishMigration;

        private readonly gaxgrpc::ApiCall<ListTokenAuthUsersRequest, ListTokenAuthUsersResponse> _callListTokenAuthUsers;

        private readonly gaxgrpc::ApiCall<GetTokenAuthUserRequest, TokenAuthUser> _callGetTokenAuthUser;

        private readonly gaxgrpc::ApiCall<ListAuthTokensRequest, ListAuthTokensResponse> _callListAuthTokens;

        private readonly gaxgrpc::ApiCall<GetAuthTokenRequest, AuthToken> _callGetAuthToken;

        private readonly gaxgrpc::ApiCall<AddTokenAuthUserRequest, lro::Operation> _callAddTokenAuthUser;

        private readonly gaxgrpc::ApiCall<DeleteTokenAuthUserRequest, lro::Operation> _callDeleteTokenAuthUser;

        private readonly gaxgrpc::ApiCall<AddAuthTokenRequest, lro::Operation> _callAddAuthToken;

        private readonly gaxgrpc::ApiCall<DeleteAuthTokenRequest, lro::Operation> _callDeleteAuthToken;

        /// <summary>
        /// Constructs a client wrapper for the Memorystore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MemorystoreSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MemorystoreClientImpl(Memorystore.MemorystoreClient grpcClient, MemorystoreSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MemorystoreSettings effectiveSettings = settings ?? MemorystoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateAclPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAclPolicyOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            DeleteAclPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAclPolicyOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            RescheduleMaintenanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RescheduleMaintenanceOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            ExportBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportBackupOperationsSettings, logger);
            BackupInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BackupInstanceOperationsSettings, logger);
            StartMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartMigrationOperationsSettings, logger);
            FinishMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FinishMigrationOperationsSettings, logger);
            AddTokenAuthUserOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddTokenAuthUserOperationsSettings, logger);
            DeleteTokenAuthUserOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTokenAuthUserOperationsSettings, logger);
            AddAuthTokenOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddAuthTokenOperationsSettings, logger);
            DeleteAuthTokenOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAuthTokenOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListAclPolicies = clientHelper.BuildApiCall<ListAclPoliciesRequest, ListAclPoliciesResponse>("ListAclPolicies", grpcClient.ListAclPoliciesAsync, grpcClient.ListAclPolicies, effectiveSettings.ListAclPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAclPolicies);
            Modify_ListAclPoliciesApiCall(ref _callListAclPolicies);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetAclPolicy = clientHelper.BuildApiCall<GetAclPolicyRequest, AclPolicy>("GetAclPolicy", grpcClient.GetAclPolicyAsync, grpcClient.GetAclPolicy, effectiveSettings.GetAclPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAclPolicy);
            Modify_GetAclPolicyApiCall(ref _callGetAclPolicy);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateAclPolicy = clientHelper.BuildApiCall<CreateAclPolicyRequest, AclPolicy>("CreateAclPolicy", grpcClient.CreateAclPolicyAsync, grpcClient.CreateAclPolicy, effectiveSettings.CreateAclPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAclPolicy);
            Modify_CreateAclPolicyApiCall(ref _callCreateAclPolicy);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateAclPolicy = clientHelper.BuildApiCall<UpdateAclPolicyRequest, lro::Operation>("UpdateAclPolicy", grpcClient.UpdateAclPolicyAsync, grpcClient.UpdateAclPolicy, effectiveSettings.UpdateAclPolicySettings).WithGoogleRequestParam("acl_policy.name", request => request.AclPolicy?.Name);
            Modify_ApiCall(ref _callUpdateAclPolicy);
            Modify_UpdateAclPolicyApiCall(ref _callUpdateAclPolicy);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callDeleteAclPolicy = clientHelper.BuildApiCall<DeleteAclPolicyRequest, lro::Operation>("DeleteAclPolicy", grpcClient.DeleteAclPolicyAsync, grpcClient.DeleteAclPolicy, effectiveSettings.DeleteAclPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAclPolicy);
            Modify_DeleteAclPolicyApiCall(ref _callDeleteAclPolicy);
            _callGetAclPolicyRevision = clientHelper.BuildApiCall<GetAclPolicyRevisionRequest, AclPolicyRevision>("GetAclPolicyRevision", grpcClient.GetAclPolicyRevisionAsync, grpcClient.GetAclPolicyRevision, effectiveSettings.GetAclPolicyRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAclPolicyRevision);
            Modify_GetAclPolicyRevisionApiCall(ref _callGetAclPolicyRevision);
            _callListAclPolicyRevisions = clientHelper.BuildApiCall<ListAclPolicyRevisionsRequest, ListAclPolicyRevisionsResponse>("ListAclPolicyRevisions", grpcClient.ListAclPolicyRevisionsAsync, grpcClient.ListAclPolicyRevisions, effectiveSettings.ListAclPolicyRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAclPolicyRevisions);
            Modify_ListAclPolicyRevisionsApiCall(ref _callListAclPolicyRevisions);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callGetCertificateAuthority = clientHelper.BuildApiCall<GetCertificateAuthorityRequest, CertificateAuthority>("GetCertificateAuthority", grpcClient.GetCertificateAuthorityAsync, grpcClient.GetCertificateAuthority, effectiveSettings.GetCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateAuthority);
            Modify_GetCertificateAuthorityApiCall(ref _callGetCertificateAuthority);
            _callGetSharedRegionalCertificateAuthority = clientHelper.BuildApiCall<GetSharedRegionalCertificateAuthorityRequest, SharedRegionalCertificateAuthority>("GetSharedRegionalCertificateAuthority", grpcClient.GetSharedRegionalCertificateAuthorityAsync, grpcClient.GetSharedRegionalCertificateAuthority, effectiveSettings.GetSharedRegionalCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSharedRegionalCertificateAuthority);
            Modify_GetSharedRegionalCertificateAuthorityApiCall(ref _callGetSharedRegionalCertificateAuthority);
            _callRescheduleMaintenance = clientHelper.BuildApiCall<RescheduleMaintenanceRequest, lro::Operation>("RescheduleMaintenance", grpcClient.RescheduleMaintenanceAsync, grpcClient.RescheduleMaintenance, effectiveSettings.RescheduleMaintenanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRescheduleMaintenance);
            Modify_RescheduleMaintenanceApiCall(ref _callRescheduleMaintenance);
            _callListBackupCollections = clientHelper.BuildApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse>("ListBackupCollections", grpcClient.ListBackupCollectionsAsync, grpcClient.ListBackupCollections, effectiveSettings.ListBackupCollectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupCollections);
            Modify_ListBackupCollectionsApiCall(ref _callListBackupCollections);
            _callGetBackupCollection = clientHelper.BuildApiCall<GetBackupCollectionRequest, BackupCollection>("GetBackupCollection", grpcClient.GetBackupCollectionAsync, grpcClient.GetBackupCollection, effectiveSettings.GetBackupCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupCollection);
            Modify_GetBackupCollectionApiCall(ref _callGetBackupCollection);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callExportBackup = clientHelper.BuildApiCall<ExportBackupRequest, lro::Operation>("ExportBackup", grpcClient.ExportBackupAsync, grpcClient.ExportBackup, effectiveSettings.ExportBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportBackup);
            Modify_ExportBackupApiCall(ref _callExportBackup);
            _callBackupInstance = clientHelper.BuildApiCall<BackupInstanceRequest, lro::Operation>("BackupInstance", grpcClient.BackupInstanceAsync, grpcClient.BackupInstance, effectiveSettings.BackupInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBackupInstance);
            Modify_BackupInstanceApiCall(ref _callBackupInstance);
            _callStartMigration = clientHelper.BuildApiCall<StartMigrationRequest, lro::Operation>("StartMigration", grpcClient.StartMigrationAsync, grpcClient.StartMigration, effectiveSettings.StartMigrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartMigration);
            Modify_StartMigrationApiCall(ref _callStartMigration);
            _callFinishMigration = clientHelper.BuildApiCall<FinishMigrationRequest, lro::Operation>("FinishMigration", grpcClient.FinishMigrationAsync, grpcClient.FinishMigration, effectiveSettings.FinishMigrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFinishMigration);
            Modify_FinishMigrationApiCall(ref _callFinishMigration);
            _callListTokenAuthUsers = clientHelper.BuildApiCall<ListTokenAuthUsersRequest, ListTokenAuthUsersResponse>("ListTokenAuthUsers", grpcClient.ListTokenAuthUsersAsync, grpcClient.ListTokenAuthUsers, effectiveSettings.ListTokenAuthUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTokenAuthUsers);
            Modify_ListTokenAuthUsersApiCall(ref _callListTokenAuthUsers);
            _callGetTokenAuthUser = clientHelper.BuildApiCall<GetTokenAuthUserRequest, TokenAuthUser>("GetTokenAuthUser", grpcClient.GetTokenAuthUserAsync, grpcClient.GetTokenAuthUser, effectiveSettings.GetTokenAuthUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTokenAuthUser);
            Modify_GetTokenAuthUserApiCall(ref _callGetTokenAuthUser);
            _callListAuthTokens = clientHelper.BuildApiCall<ListAuthTokensRequest, ListAuthTokensResponse>("ListAuthTokens", grpcClient.ListAuthTokensAsync, grpcClient.ListAuthTokens, effectiveSettings.ListAuthTokensSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuthTokens);
            Modify_ListAuthTokensApiCall(ref _callListAuthTokens);
            _callGetAuthToken = clientHelper.BuildApiCall<GetAuthTokenRequest, AuthToken>("GetAuthToken", grpcClient.GetAuthTokenAsync, grpcClient.GetAuthToken, effectiveSettings.GetAuthTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuthToken);
            Modify_GetAuthTokenApiCall(ref _callGetAuthToken);
            _callAddTokenAuthUser = clientHelper.BuildApiCall<AddTokenAuthUserRequest, lro::Operation>("AddTokenAuthUser", grpcClient.AddTokenAuthUserAsync, grpcClient.AddTokenAuthUser, effectiveSettings.AddTokenAuthUserSettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddTokenAuthUser);
            Modify_AddTokenAuthUserApiCall(ref _callAddTokenAuthUser);
            _callDeleteTokenAuthUser = clientHelper.BuildApiCall<DeleteTokenAuthUserRequest, lro::Operation>("DeleteTokenAuthUser", grpcClient.DeleteTokenAuthUserAsync, grpcClient.DeleteTokenAuthUser, effectiveSettings.DeleteTokenAuthUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTokenAuthUser);
            Modify_DeleteTokenAuthUserApiCall(ref _callDeleteTokenAuthUser);
            _callAddAuthToken = clientHelper.BuildApiCall<AddAuthTokenRequest, lro::Operation>("AddAuthToken", grpcClient.AddAuthTokenAsync, grpcClient.AddAuthToken, effectiveSettings.AddAuthTokenSettings).WithGoogleRequestParam("token_auth_user", request => request.TokenAuthUser);
            Modify_ApiCall(ref _callAddAuthToken);
            Modify_AddAuthTokenApiCall(ref _callAddAuthToken);
            _callDeleteAuthToken = clientHelper.BuildApiCall<DeleteAuthTokenRequest, lro::Operation>("DeleteAuthToken", grpcClient.DeleteAuthTokenAsync, grpcClient.DeleteAuthToken, effectiveSettings.DeleteAuthTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAuthToken);
            Modify_DeleteAuthTokenApiCall(ref _callDeleteAuthToken);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAclPoliciesApiCall(ref gaxgrpc::ApiCall<ListAclPoliciesRequest, ListAclPoliciesResponse> call);

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetAclPolicyApiCall(ref gaxgrpc::ApiCall<GetAclPolicyRequest, AclPolicy> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateAclPolicyApiCall(ref gaxgrpc::ApiCall<CreateAclPolicyRequest, AclPolicy> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateAclPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAclPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteAclPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAclPolicyRequest, lro::Operation> call);

        partial void Modify_GetAclPolicyRevisionApiCall(ref gaxgrpc::ApiCall<GetAclPolicyRevisionRequest, AclPolicyRevision> call);

        partial void Modify_ListAclPolicyRevisionsApiCall(ref gaxgrpc::ApiCall<ListAclPolicyRevisionsRequest, ListAclPolicyRevisionsResponse> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_GetCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> call);

        partial void Modify_GetSharedRegionalCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<GetSharedRegionalCertificateAuthorityRequest, SharedRegionalCertificateAuthority> call);

        partial void Modify_RescheduleMaintenanceApiCall(ref gaxgrpc::ApiCall<RescheduleMaintenanceRequest, lro::Operation> call);

        partial void Modify_ListBackupCollectionsApiCall(ref gaxgrpc::ApiCall<ListBackupCollectionsRequest, ListBackupCollectionsResponse> call);

        partial void Modify_GetBackupCollectionApiCall(ref gaxgrpc::ApiCall<GetBackupCollectionRequest, BackupCollection> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_ExportBackupApiCall(ref gaxgrpc::ApiCall<ExportBackupRequest, lro::Operation> call);

        partial void Modify_BackupInstanceApiCall(ref gaxgrpc::ApiCall<BackupInstanceRequest, lro::Operation> call);

        partial void Modify_StartMigrationApiCall(ref gaxgrpc::ApiCall<StartMigrationRequest, lro::Operation> call);

        partial void Modify_FinishMigrationApiCall(ref gaxgrpc::ApiCall<FinishMigrationRequest, lro::Operation> call);

        partial void Modify_ListTokenAuthUsersApiCall(ref gaxgrpc::ApiCall<ListTokenAuthUsersRequest, ListTokenAuthUsersResponse> call);

        partial void Modify_GetTokenAuthUserApiCall(ref gaxgrpc::ApiCall<GetTokenAuthUserRequest, TokenAuthUser> call);

        partial void Modify_ListAuthTokensApiCall(ref gaxgrpc::ApiCall<ListAuthTokensRequest, ListAuthTokensResponse> call);

        partial void Modify_GetAuthTokenApiCall(ref gaxgrpc::ApiCall<GetAuthTokenRequest, AuthToken> call);

        partial void Modify_AddTokenAuthUserApiCall(ref gaxgrpc::ApiCall<AddTokenAuthUserRequest, lro::Operation> call);

        partial void Modify_DeleteTokenAuthUserApiCall(ref gaxgrpc::ApiCall<DeleteTokenAuthUserRequest, lro::Operation> call);

        partial void Modify_AddAuthTokenApiCall(ref gaxgrpc::ApiCall<AddAuthTokenRequest, lro::Operation> call);

        partial void Modify_DeleteAuthTokenApiCall(ref gaxgrpc::ApiCall<DeleteAuthTokenRequest, lro::Operation> call);

        partial void OnConstruction(Memorystore.MemorystoreClient grpcClient, MemorystoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Memorystore client</summary>
        public override Memorystore.MemorystoreClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListAclPoliciesRequest(ref ListAclPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAclPolicyRequest(ref GetAclPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAclPolicyRequest(ref CreateAclPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAclPolicyRequest(ref UpdateAclPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAclPolicyRequest(ref DeleteAclPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAclPolicyRevisionRequest(ref GetAclPolicyRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAclPolicyRevisionsRequest(ref ListAclPolicyRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateAuthorityRequest(ref GetCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSharedRegionalCertificateAuthorityRequest(ref GetSharedRegionalCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RescheduleMaintenanceRequest(ref RescheduleMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupCollectionsRequest(ref ListBackupCollectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupCollectionRequest(ref GetBackupCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportBackupRequest(ref ExportBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BackupInstanceRequest(ref BackupInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMigrationRequest(ref StartMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FinishMigrationRequest(ref FinishMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTokenAuthUsersRequest(ref ListTokenAuthUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTokenAuthUserRequest(ref GetTokenAuthUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAuthTokensRequest(ref ListAuthTokensRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAuthTokenRequest(ref GetAuthTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddTokenAuthUserRequest(ref AddTokenAuthUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTokenAuthUserRequest(ref DeleteTokenAuthUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddAuthTokenRequest(ref AddAuthTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAuthTokenRequest(ref DeleteAuthTokenRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AclPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPolicies(ListAclPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAclPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAclPoliciesRequest, ListAclPoliciesResponse, AclPolicy>(_callListAclPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policies owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// 
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAclPoliciesResponse, AclPolicy> ListAclPoliciesAsync(ListAclPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAclPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAclPoliciesRequest, ListAclPoliciesResponse, AclPolicy>(_callListAclPolicies, request, callSettings);
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
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AclPolicy GetAclPolicy(GetAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclPolicyRequest(ref request, ref callSettings);
            return _callGetAclPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Memorystore ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AclPolicy> GetAclPolicyAsync(GetAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclPolicyRequest(ref request, ref callSettings);
            return _callGetAclPolicy.Async(request, callSettings);
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

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AclPolicy CreateAclPolicy(CreateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAclPolicyRequest(ref request, ref callSettings);
            return _callCreateAclPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an ACL policy.
        /// The creation is executed synchronously and the policy is available for use
        /// immediately after the RPC returns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AclPolicy> CreateAclPolicyAsync(CreateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAclPolicyRequest(ref request, ref callSettings);
            return _callCreateAclPolicy.Async(request, callSettings);
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

        /// <summary>The long-running operations client for <c>UpdateAclPolicy</c>.</summary>
        public override lro::OperationsClient UpdateAclPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AclPolicy, OperationMetadata> UpdateAclPolicy(UpdateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAclPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AclPolicy, OperationMetadata>(_callUpdateAclPolicy.Sync(request, callSettings), UpdateAclPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the ACL policy.
        /// 
        /// The operation will apply the updated ACL policy to all the linked
        /// instances. The operation will return success if it successfully applied the
        /// policy to all the instances. If the operation completed with a failure, the
        /// service will continue to apply the policy via reconciliation for the failed
        /// instances even after operation completion to ensure eventual consistency.
        /// 
        /// Completed longrunning.Operation will contain the new ACL policy object
        /// in the response field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AclPolicy, OperationMetadata>> UpdateAclPolicyAsync(UpdateAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAclPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<AclPolicy, OperationMetadata>(await _callUpdateAclPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateAclPolicyOperationsClient);
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

        /// <summary>The long-running operations client for <c>DeleteAclPolicy</c>.</summary>
        public override lro::OperationsClient DeleteAclPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAclPolicy(DeleteAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAclPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAclPolicy.Sync(request, callSettings), DeleteAclPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a specific ACL policy. This action will delete the ACL policy and
        /// all the rules associated with it. An ACL policy cannot be deleted if it is
        /// attached to an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAclPolicyAsync(DeleteAclPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAclPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAclPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteAclPolicyOperationsClient);
        }

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AclPolicyRevision GetAclPolicyRevision(GetAclPolicyRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclPolicyRevisionRequest(ref request, ref callSettings);
            return _callGetAclPolicyRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a specific ACL policy revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AclPolicyRevision> GetAclPolicyRevisionAsync(GetAclPolicyRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAclPolicyRevisionRequest(ref request, ref callSettings);
            return _callGetAclPolicyRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisions(ListAclPolicyRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAclPolicyRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAclPolicyRevisionsRequest, ListAclPolicyRevisionsResponse, AclPolicyRevision>(_callListAclPolicyRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all ACL policy revisions in a given ACL policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AclPolicyRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAclPolicyRevisionsResponse, AclPolicyRevision> ListAclPolicyRevisionsAsync(ListAclPolicyRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAclPolicyRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAclPolicyRevisionsRequest, ListAclPolicyRevisionsResponse, AclPolicyRevision>(_callListAclPolicyRevisions, request, callSettings);
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

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about the certificate authority for an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SharedRegionalCertificateAuthority GetSharedRegionalCertificateAuthority(GetSharedRegionalCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedRegionalCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetSharedRegionalCertificateAuthority.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of shared regional certificate authority information for
        /// Memorystore instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SharedRegionalCertificateAuthority> GetSharedRegionalCertificateAuthorityAsync(GetSharedRegionalCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedRegionalCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetSharedRegionalCertificateAuthority.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RescheduleMaintenance</c>.</summary>
        public override lro::OperationsClient RescheduleMaintenanceOperationsClient { get; }

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RescheduleMaintenance(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRescheduleMaintenance.Sync(request, callSettings), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Reschedules upcoming maintenance event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RescheduleMaintenanceAsync(RescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RescheduleMaintenanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRescheduleMaintenance.Async(request, callSettings).ConfigureAwait(false), RescheduleMaintenanceOperationsClient);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupCollection"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollections(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupCollectionsRequest, ListBackupCollectionsResponse, BackupCollection>(_callListBackupCollections, request, callSettings);
        }

        /// <summary>
        /// Lists all backup collections owned by a consumer project in either the
        /// specified location (region) or all locations.
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupCollection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> ListBackupCollectionsAsync(ListBackupCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupCollectionsRequest, ListBackupCollectionsResponse, BackupCollection>(_callListBackupCollections, request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupCollection GetBackupCollection(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupCollectionRequest(ref request, ref callSettings);
            return _callGetBackupCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a backup collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupCollection> GetBackupCollectionAsync(GetBackupCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupCollectionRequest(ref request, ref callSettings);
            return _callGetBackupCollection.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all backups owned by a backup collection.
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
        /// Lists all backups owned by a backup collection.
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
        /// Gets the details of a specific backup.
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
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Deletes a specific backup.
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
        /// Deletes a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportBackup</c>.</summary>
        public override lro::OperationsClient ExportBackupOperationsClient { get; }

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, OperationMetadata> ExportBackup(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(_callExportBackup.Sync(request, callSettings), ExportBackupOperationsClient);
        }

        /// <summary>
        /// Exports a specific backup to a customer target Cloud Storage URI.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> ExportBackupAsync(ExportBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callExportBackup.Async(request, callSettings).ConfigureAwait(false), ExportBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BackupInstance</c>.</summary>
        public override lro::OperationsClient BackupInstanceOperationsClient { get; }

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> BackupInstance(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BackupInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callBackupInstance.Sync(request, callSettings), BackupInstanceOperationsClient);
        }

        /// <summary>
        /// Backup Instance.
        /// If this is the first time a backup is being created, a backup collection
        /// will be created at the backend, and this backup belongs to this collection.
        /// Both collection and backup will have a resource name. Backup will be
        /// executed for each shard. A replica (primary if nonHA) will be selected to
        /// perform the execution. Backup call will be rejected if there is an ongoing
        /// backup or update operation. Be aware that during preview, if the instance's
        /// internal software version is too old, critical update will be performed
        /// before actual backup. Once the internal software version is updated to the
        /// minimum version required by the backup feature, subsequent backups will not
        /// require critical update. After preview, there will be no critical update
        /// needed for backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> BackupInstanceAsync(BackupInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BackupInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callBackupInstance.Async(request, callSettings).ConfigureAwait(false), BackupInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartMigration</c>.</summary>
        public override lro::OperationsClient StartMigrationOperationsClient { get; }

        /// <summary>
        /// Initiates the migration of a source instance to the target Memorystore
        /// instance.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Set up replication with the source instance and replicate any writes to
        /// the source instance.
        /// 2. Only allow reads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> StartMigration(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callStartMigration.Sync(request, callSettings), StartMigrationOperationsClient);
        }

        /// <summary>
        /// Initiates the migration of a source instance to the target Memorystore
        /// instance.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Set up replication with the source instance and replicate any writes to
        /// the source instance.
        /// 2. Only allow reads.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callStartMigration.Async(request, callSettings).ConfigureAwait(false), StartMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FinishMigration</c>.</summary>
        public override lro::OperationsClient FinishMigrationOperationsClient { get; }

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> FinishMigration(FinishMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callFinishMigration.Sync(request, callSettings), FinishMigrationOperationsClient);
        }

        /// <summary>
        /// Finalizes the migration process.
        /// 
        /// After the successful completion of this operation, the target instance
        /// will:
        /// 1. Stop replicating from the source instance.
        /// 2. Allow both reads and writes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> FinishMigrationAsync(FinishMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callFinishMigration.Async(request, callSettings).ConfigureAwait(false), FinishMigrationOperationsClient);
        }

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public override gax::PagedEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsers(ListTokenAuthUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTokenAuthUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTokenAuthUsersRequest, ListTokenAuthUsersResponse, TokenAuthUser>(_callListTokenAuthUsers, request, callSettings);
        }

        /// <summary>
        /// Lists all the token auth users for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TokenAuthUser"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTokenAuthUsersResponse, TokenAuthUser> ListTokenAuthUsersAsync(ListTokenAuthUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTokenAuthUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTokenAuthUsersRequest, ListTokenAuthUsersResponse, TokenAuthUser>(_callListTokenAuthUsers, request, callSettings);
        }

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TokenAuthUser GetTokenAuthUser(GetTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTokenAuthUserRequest(ref request, ref callSettings);
            return _callGetTokenAuthUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a specific token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TokenAuthUser> GetTokenAuthUserAsync(GetTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTokenAuthUserRequest(ref request, ref callSettings);
            return _callGetTokenAuthUser.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthToken"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokens(ListAuthTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuthTokensRequest, ListAuthTokensResponse, AuthToken>(_callListAuthTokens, request, callSettings);
        }

        /// <summary>
        /// Lists all the auth tokens for a specific token auth user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthToken"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuthTokensResponse, AuthToken> ListAuthTokensAsync(ListAuthTokensRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthTokensRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuthTokensRequest, ListAuthTokensResponse, AuthToken>(_callListAuthTokens, request, callSettings);
        }

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthToken GetAuthToken(GetAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthTokenRequest(ref request, ref callSettings);
            return _callGetAuthToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a token based auth enabled instance's auth token for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthToken> GetAuthTokenAsync(GetAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthTokenRequest(ref request, ref callSettings);
            return _callGetAuthToken.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>AddTokenAuthUser</c>.</summary>
        public override lro::OperationsClient AddTokenAuthUserOperationsClient { get; }

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> AddTokenAuthUser(AddTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddTokenAuthUserRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callAddTokenAuthUser.Sync(request, callSettings), AddTokenAuthUserOperationsClient);
        }

        /// <summary>
        /// Adds a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> AddTokenAuthUserAsync(AddTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddTokenAuthUserRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callAddTokenAuthUser.Async(request, callSettings).ConfigureAwait(false), AddTokenAuthUserOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTokenAuthUser</c>.</summary>
        public override lro::OperationsClient DeleteTokenAuthUserOperationsClient { get; }

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTokenAuthUser(DeleteTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTokenAuthUserRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTokenAuthUser.Sync(request, callSettings), DeleteTokenAuthUserOperationsClient);
        }

        /// <summary>
        /// Deletes a token auth user for a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTokenAuthUserAsync(DeleteTokenAuthUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTokenAuthUserRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTokenAuthUser.Async(request, callSettings).ConfigureAwait(false), DeleteTokenAuthUserOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddAuthToken</c>.</summary>
        public override lro::OperationsClient AddAuthTokenOperationsClient { get; }

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TokenAuthUser, OperationMetadata> AddAuthToken(AddAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAuthTokenRequest(ref request, ref callSettings);
            return new lro::Operation<TokenAuthUser, OperationMetadata>(_callAddAuthToken.Sync(request, callSettings), AddAuthTokenOperationsClient);
        }

        /// <summary>
        /// Adds a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TokenAuthUser, OperationMetadata>> AddAuthTokenAsync(AddAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAuthTokenRequest(ref request, ref callSettings);
            return new lro::Operation<TokenAuthUser, OperationMetadata>(await _callAddAuthToken.Async(request, callSettings).ConfigureAwait(false), AddAuthTokenOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAuthToken</c>.</summary>
        public override lro::OperationsClient DeleteAuthTokenOperationsClient { get; }

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAuthToken(DeleteAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthTokenRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAuthToken.Sync(request, callSettings), DeleteAuthTokenOperationsClient);
        }

        /// <summary>
        /// Deletes a token for a user of a token based auth enabled instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAuthTokenAsync(DeleteAuthTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthTokenRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAuthToken.Async(request, callSettings).ConfigureAwait(false), DeleteAuthTokenOperationsClient);
        }
    }

    public partial class ListAclPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAclPolicyRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupCollectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTokenAuthUsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthTokensRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAclPoliciesResponse : gaxgrpc::IPageResponse<AclPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AclPolicy> GetEnumerator() => AclPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAclPolicyRevisionsResponse : gaxgrpc::IPageResponse<AclPolicyRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AclPolicyRevision> GetEnumerator() => AclPolicyRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupCollectionsResponse : gaxgrpc::IPageResponse<BackupCollection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupCollection> GetEnumerator() => BackupCollections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTokenAuthUsersResponse : gaxgrpc::IPageResponse<TokenAuthUser>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TokenAuthUser> GetEnumerator() => TokenAuthUsers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAuthTokensResponse : gaxgrpc::IPageResponse<AuthToken>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthToken> GetEnumerator() => AuthTokens.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Memorystore
    {
        public partial class MemorystoreClient
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

    public static partial class Memorystore
    {
        public partial class MemorystoreClient
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
