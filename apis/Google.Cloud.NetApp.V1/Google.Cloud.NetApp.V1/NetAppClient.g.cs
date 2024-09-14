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

namespace Google.Cloud.NetApp.V1
{
    /// <summary>Settings for <see cref="NetAppClient"/> instances.</summary>
    public sealed partial class NetAppSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetAppSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetAppSettings"/>.</returns>
        public static NetAppSettings GetDefault() => new NetAppSettings();

        /// <summary>Constructs a new <see cref="NetAppSettings"/> object with default settings.</summary>
        public NetAppSettings()
        {
        }

        private NetAppSettings(NetAppSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListStoragePoolsSettings = existing.ListStoragePoolsSettings;
            CreateStoragePoolSettings = existing.CreateStoragePoolSettings;
            CreateStoragePoolOperationsSettings = existing.CreateStoragePoolOperationsSettings.Clone();
            GetStoragePoolSettings = existing.GetStoragePoolSettings;
            UpdateStoragePoolSettings = existing.UpdateStoragePoolSettings;
            UpdateStoragePoolOperationsSettings = existing.UpdateStoragePoolOperationsSettings.Clone();
            DeleteStoragePoolSettings = existing.DeleteStoragePoolSettings;
            DeleteStoragePoolOperationsSettings = existing.DeleteStoragePoolOperationsSettings.Clone();
            SwitchActiveReplicaZoneSettings = existing.SwitchActiveReplicaZoneSettings;
            SwitchActiveReplicaZoneOperationsSettings = existing.SwitchActiveReplicaZoneOperationsSettings.Clone();
            ListVolumesSettings = existing.ListVolumesSettings;
            GetVolumeSettings = existing.GetVolumeSettings;
            CreateVolumeSettings = existing.CreateVolumeSettings;
            CreateVolumeOperationsSettings = existing.CreateVolumeOperationsSettings.Clone();
            UpdateVolumeSettings = existing.UpdateVolumeSettings;
            UpdateVolumeOperationsSettings = existing.UpdateVolumeOperationsSettings.Clone();
            DeleteVolumeSettings = existing.DeleteVolumeSettings;
            DeleteVolumeOperationsSettings = existing.DeleteVolumeOperationsSettings.Clone();
            RevertVolumeSettings = existing.RevertVolumeSettings;
            RevertVolumeOperationsSettings = existing.RevertVolumeOperationsSettings.Clone();
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            GetSnapshotSettings = existing.GetSnapshotSettings;
            CreateSnapshotSettings = existing.CreateSnapshotSettings;
            CreateSnapshotOperationsSettings = existing.CreateSnapshotOperationsSettings.Clone();
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            DeleteSnapshotOperationsSettings = existing.DeleteSnapshotOperationsSettings.Clone();
            UpdateSnapshotSettings = existing.UpdateSnapshotSettings;
            UpdateSnapshotOperationsSettings = existing.UpdateSnapshotOperationsSettings.Clone();
            ListActiveDirectoriesSettings = existing.ListActiveDirectoriesSettings;
            GetActiveDirectorySettings = existing.GetActiveDirectorySettings;
            CreateActiveDirectorySettings = existing.CreateActiveDirectorySettings;
            CreateActiveDirectoryOperationsSettings = existing.CreateActiveDirectoryOperationsSettings.Clone();
            UpdateActiveDirectorySettings = existing.UpdateActiveDirectorySettings;
            UpdateActiveDirectoryOperationsSettings = existing.UpdateActiveDirectoryOperationsSettings.Clone();
            DeleteActiveDirectorySettings = existing.DeleteActiveDirectorySettings;
            DeleteActiveDirectoryOperationsSettings = existing.DeleteActiveDirectoryOperationsSettings.Clone();
            ListKmsConfigsSettings = existing.ListKmsConfigsSettings;
            CreateKmsConfigSettings = existing.CreateKmsConfigSettings;
            CreateKmsConfigOperationsSettings = existing.CreateKmsConfigOperationsSettings.Clone();
            GetKmsConfigSettings = existing.GetKmsConfigSettings;
            UpdateKmsConfigSettings = existing.UpdateKmsConfigSettings;
            UpdateKmsConfigOperationsSettings = existing.UpdateKmsConfigOperationsSettings.Clone();
            EncryptVolumesSettings = existing.EncryptVolumesSettings;
            EncryptVolumesOperationsSettings = existing.EncryptVolumesOperationsSettings.Clone();
            VerifyKmsConfigSettings = existing.VerifyKmsConfigSettings;
            DeleteKmsConfigSettings = existing.DeleteKmsConfigSettings;
            DeleteKmsConfigOperationsSettings = existing.DeleteKmsConfigOperationsSettings.Clone();
            ListReplicationsSettings = existing.ListReplicationsSettings;
            GetReplicationSettings = existing.GetReplicationSettings;
            CreateReplicationSettings = existing.CreateReplicationSettings;
            CreateReplicationOperationsSettings = existing.CreateReplicationOperationsSettings.Clone();
            DeleteReplicationSettings = existing.DeleteReplicationSettings;
            DeleteReplicationOperationsSettings = existing.DeleteReplicationOperationsSettings.Clone();
            UpdateReplicationSettings = existing.UpdateReplicationSettings;
            UpdateReplicationOperationsSettings = existing.UpdateReplicationOperationsSettings.Clone();
            StopReplicationSettings = existing.StopReplicationSettings;
            StopReplicationOperationsSettings = existing.StopReplicationOperationsSettings.Clone();
            ResumeReplicationSettings = existing.ResumeReplicationSettings;
            ResumeReplicationOperationsSettings = existing.ResumeReplicationOperationsSettings.Clone();
            ReverseReplicationDirectionSettings = existing.ReverseReplicationDirectionSettings;
            ReverseReplicationDirectionOperationsSettings = existing.ReverseReplicationDirectionOperationsSettings.Clone();
            CreateBackupVaultSettings = existing.CreateBackupVaultSettings;
            CreateBackupVaultOperationsSettings = existing.CreateBackupVaultOperationsSettings.Clone();
            GetBackupVaultSettings = existing.GetBackupVaultSettings;
            ListBackupVaultsSettings = existing.ListBackupVaultsSettings;
            UpdateBackupVaultSettings = existing.UpdateBackupVaultSettings;
            UpdateBackupVaultOperationsSettings = existing.UpdateBackupVaultOperationsSettings.Clone();
            DeleteBackupVaultSettings = existing.DeleteBackupVaultSettings;
            DeleteBackupVaultOperationsSettings = existing.DeleteBackupVaultOperationsSettings.Clone();
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            GetBackupSettings = existing.GetBackupSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            UpdateBackupSettings = existing.UpdateBackupSettings;
            UpdateBackupOperationsSettings = existing.UpdateBackupOperationsSettings.Clone();
            CreateBackupPolicySettings = existing.CreateBackupPolicySettings;
            CreateBackupPolicyOperationsSettings = existing.CreateBackupPolicyOperationsSettings.Clone();
            GetBackupPolicySettings = existing.GetBackupPolicySettings;
            ListBackupPoliciesSettings = existing.ListBackupPoliciesSettings;
            UpdateBackupPolicySettings = existing.UpdateBackupPolicySettings;
            UpdateBackupPolicyOperationsSettings = existing.UpdateBackupPolicyOperationsSettings.Clone();
            DeleteBackupPolicySettings = existing.DeleteBackupPolicySettings;
            DeleteBackupPolicyOperationsSettings = existing.DeleteBackupPolicyOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetAppSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListStoragePools</c> and <c>NetAppClient.ListStoragePoolsAsync</c>.
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
        public gaxgrpc::CallSettings ListStoragePoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateStoragePool</c> and <c>NetAppClient.CreateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateStoragePool</c> and
        /// <c>NetAppClient.CreateStoragePoolAsync</c>.
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
        public lro::OperationsSettings CreateStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetStoragePool</c>
        ///  and <c>NetAppClient.GetStoragePoolAsync</c>.
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
        public gaxgrpc::CallSettings GetStoragePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateStoragePool</c> and <c>NetAppClient.UpdateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateStoragePool</c> and
        /// <c>NetAppClient.UpdateStoragePoolAsync</c>.
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
        public lro::OperationsSettings UpdateStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteStoragePool</c> and <c>NetAppClient.DeleteStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteStoragePool</c> and
        /// <c>NetAppClient.DeleteStoragePoolAsync</c>.
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
        public lro::OperationsSettings DeleteStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.SwitchActiveReplicaZone</c> and <c>NetAppClient.SwitchActiveReplicaZoneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchActiveReplicaZoneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.SwitchActiveReplicaZone</c> and
        /// <c>NetAppClient.SwitchActiveReplicaZoneAsync</c>.
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
        public lro::OperationsSettings SwitchActiveReplicaZoneOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListVolumes</c>
        ///  and <c>NetAppClient.ListVolumesAsync</c>.
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
        public gaxgrpc::CallSettings ListVolumesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetVolume</c>
        /// and <c>NetAppClient.GetVolumeAsync</c>.
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
        public gaxgrpc::CallSettings GetVolumeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.CreateVolume</c>
        ///  and <c>NetAppClient.CreateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateVolume</c> and
        /// <c>NetAppClient.CreateVolumeAsync</c>.
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
        public lro::OperationsSettings CreateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.UpdateVolume</c>
        ///  and <c>NetAppClient.UpdateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateVolume</c> and
        /// <c>NetAppClient.UpdateVolumeAsync</c>.
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
        public lro::OperationsSettings UpdateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.DeleteVolume</c>
        ///  and <c>NetAppClient.DeleteVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteVolume</c> and
        /// <c>NetAppClient.DeleteVolumeAsync</c>.
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
        public lro::OperationsSettings DeleteVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.RevertVolume</c>
        ///  and <c>NetAppClient.RevertVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevertVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.RevertVolume</c> and
        /// <c>NetAppClient.RevertVolumeAsync</c>.
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
        public lro::OperationsSettings RevertVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListSnapshots</c>
        ///  and <c>NetAppClient.ListSnapshotsAsync</c>.
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
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetSnapshot</c>
        ///  and <c>NetAppClient.GetSnapshotAsync</c>.
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
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.CreateSnapshot</c>
        ///  and <c>NetAppClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateSnapshot</c> and
        /// <c>NetAppClient.CreateSnapshotAsync</c>.
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
        public lro::OperationsSettings CreateSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.DeleteSnapshot</c>
        ///  and <c>NetAppClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteSnapshot</c> and
        /// <c>NetAppClient.DeleteSnapshotAsync</c>.
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
        public lro::OperationsSettings DeleteSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.UpdateSnapshot</c>
        ///  and <c>NetAppClient.UpdateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateSnapshot</c> and
        /// <c>NetAppClient.UpdateSnapshotAsync</c>.
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
        public lro::OperationsSettings UpdateSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListActiveDirectories</c> and <c>NetAppClient.ListActiveDirectoriesAsync</c>.
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
        public gaxgrpc::CallSettings ListActiveDirectoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.GetActiveDirectory</c> and <c>NetAppClient.GetActiveDirectoryAsync</c>.
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
        public gaxgrpc::CallSettings GetActiveDirectorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateActiveDirectory</c> and <c>NetAppClient.CreateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateActiveDirectory</c> and
        /// <c>NetAppClient.CreateActiveDirectoryAsync</c>.
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
        public lro::OperationsSettings CreateActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateActiveDirectory</c> and <c>NetAppClient.UpdateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateActiveDirectory</c> and
        /// <c>NetAppClient.UpdateActiveDirectoryAsync</c>.
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
        public lro::OperationsSettings UpdateActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteActiveDirectory</c> and <c>NetAppClient.DeleteActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteActiveDirectory</c> and
        /// <c>NetAppClient.DeleteActiveDirectoryAsync</c>.
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
        public lro::OperationsSettings DeleteActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListKmsConfigs</c>
        ///  and <c>NetAppClient.ListKmsConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListKmsConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateKmsConfig</c> and <c>NetAppClient.CreateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateKmsConfig</c> and
        /// <c>NetAppClient.CreateKmsConfigAsync</c>.
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
        public lro::OperationsSettings CreateKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetKmsConfig</c>
        ///  and <c>NetAppClient.GetKmsConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetKmsConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateKmsConfig</c> and <c>NetAppClient.UpdateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateKmsConfig</c> and
        /// <c>NetAppClient.UpdateKmsConfigAsync</c>.
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
        public lro::OperationsSettings UpdateKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.EncryptVolumes</c>
        ///  and <c>NetAppClient.EncryptVolumesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EncryptVolumesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.EncryptVolumes</c> and
        /// <c>NetAppClient.EncryptVolumesAsync</c>.
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
        public lro::OperationsSettings EncryptVolumesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.VerifyKmsConfig</c> and <c>NetAppClient.VerifyKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteKmsConfig</c> and <c>NetAppClient.DeleteKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteKmsConfig</c> and
        /// <c>NetAppClient.DeleteKmsConfigAsync</c>.
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
        public lro::OperationsSettings DeleteKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListReplications</c> and <c>NetAppClient.ListReplicationsAsync</c>.
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
        public gaxgrpc::CallSettings ListReplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetReplication</c>
        ///  and <c>NetAppClient.GetReplicationAsync</c>.
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
        public gaxgrpc::CallSettings GetReplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateReplication</c> and <c>NetAppClient.CreateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateReplication</c> and
        /// <c>NetAppClient.CreateReplicationAsync</c>.
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
        public lro::OperationsSettings CreateReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteReplication</c> and <c>NetAppClient.DeleteReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteReplication</c> and
        /// <c>NetAppClient.DeleteReplicationAsync</c>.
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
        public lro::OperationsSettings DeleteReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateReplication</c> and <c>NetAppClient.UpdateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateReplication</c> and
        /// <c>NetAppClient.UpdateReplicationAsync</c>.
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
        public lro::OperationsSettings UpdateReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.StopReplication</c> and <c>NetAppClient.StopReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.StopReplication</c> and
        /// <c>NetAppClient.StopReplicationAsync</c>.
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
        public lro::OperationsSettings StopReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ResumeReplication</c> and <c>NetAppClient.ResumeReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.ResumeReplication</c> and
        /// <c>NetAppClient.ResumeReplicationAsync</c>.
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
        public lro::OperationsSettings ResumeReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ReverseReplicationDirection</c> and <c>NetAppClient.ReverseReplicationDirectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReverseReplicationDirectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.ReverseReplicationDirection</c> and
        /// <c>NetAppClient.ReverseReplicationDirectionAsync</c>.
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
        public lro::OperationsSettings ReverseReplicationDirectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateBackupVault</c> and <c>NetAppClient.CreateBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateBackupVault</c> and
        /// <c>NetAppClient.CreateBackupVaultAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetBackupVault</c>
        ///  and <c>NetAppClient.GetBackupVaultAsync</c>.
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
        /// <c>NetAppClient.ListBackupVaults</c> and <c>NetAppClient.ListBackupVaultsAsync</c>.
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
        /// <c>NetAppClient.UpdateBackupVault</c> and <c>NetAppClient.UpdateBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateBackupVault</c> and
        /// <c>NetAppClient.UpdateBackupVaultAsync</c>.
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
        /// <c>NetAppClient.DeleteBackupVault</c> and <c>NetAppClient.DeleteBackupVaultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupVaultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteBackupVault</c> and
        /// <c>NetAppClient.DeleteBackupVaultAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.CreateBackup</c>
        ///  and <c>NetAppClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateBackup</c> and
        /// <c>NetAppClient.CreateBackupAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetBackup</c>
        /// and <c>NetAppClient.GetBackupAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListBackups</c>
        ///  and <c>NetAppClient.ListBackupsAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.DeleteBackup</c>
        ///  and <c>NetAppClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteBackup</c> and
        /// <c>NetAppClient.DeleteBackupAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.UpdateBackup</c>
        ///  and <c>NetAppClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateBackup</c> and
        /// <c>NetAppClient.UpdateBackupAsync</c>.
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
        /// <c>NetAppClient.CreateBackupPolicy</c> and <c>NetAppClient.CreateBackupPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateBackupPolicy</c> and
        /// <c>NetAppClient.CreateBackupPolicyAsync</c>.
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
        public lro::OperationsSettings CreateBackupPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.GetBackupPolicy</c> and <c>NetAppClient.GetBackupPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetBackupPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListBackupPolicies</c> and <c>NetAppClient.ListBackupPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListBackupPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateBackupPolicy</c> and <c>NetAppClient.UpdateBackupPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateBackupPolicy</c> and
        /// <c>NetAppClient.UpdateBackupPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateBackupPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteBackupPolicy</c> and <c>NetAppClient.DeleteBackupPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteBackupPolicy</c> and
        /// <c>NetAppClient.DeleteBackupPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteBackupPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetAppSettings"/> object.</returns>
        public NetAppSettings Clone() => new NetAppSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetAppClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class NetAppClientBuilder : gaxgrpc::ClientBuilderBase<NetAppClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetAppSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetAppClientBuilder() : base(NetAppClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetAppClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetAppClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetAppClient Build()
        {
            NetAppClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetAppClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetAppClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetAppClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetAppClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetAppClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetAppClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetAppClient.ChannelPool;
    }

    /// <summary>NetApp client wrapper, for convenient use.</summary>
    /// <remarks>
    /// NetApp Files Google Cloud Service
    /// </remarks>
    public abstract partial class NetAppClient
    {
        /// <summary>
        /// The default endpoint for the NetApp service, which is a host of "netapp.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "netapp.googleapis.com:443";

        /// <summary>The default NetApp scopes.</summary>
        /// <remarks>
        /// The default NetApp scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetApp.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetAppClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="NetAppClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetAppClient"/>.</returns>
        public static stt::Task<NetAppClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetAppClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetAppClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="NetAppClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetAppClient"/>.</returns>
        public static NetAppClient Create() => new NetAppClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetAppClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetAppSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetAppClient"/>.</returns>
        internal static NetAppClient Create(grpccore::CallInvoker callInvoker, NetAppSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetApp.NetAppClient grpcClient = new NetApp.NetAppClient(callInvoker);
            return new NetAppClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetApp client</summary>
        public virtual NetApp.NetAppClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
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
            return ListStoragePools(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
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
            return ListStoragePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
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
            return ListStoragePools(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
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
            return ListStoragePoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateStoragePool</c>.</summary>
        public virtual lro::OperationsClient CreateStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> PollOnceCreateStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> PollOnceCreateStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(string parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePool(new CreateStoragePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(string parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePoolAsync(new CreateStoragePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(string parent, StoragePool storagePool, string storagePoolId, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(parent, storagePool, storagePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePool(new CreateStoragePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePoolAsync(new CreateStoragePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(parent, storagePool, storagePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePool(new GetStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePoolAsync(new GetStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePool(new GetStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePoolAsync(new GetStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(StoragePoolName name, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateStoragePool</c>.</summary>
        public virtual lro::OperationsClient UpdateStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> PollOnceUpdateStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> PollOnceUpdateStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(StoragePool storagePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoragePool(new UpdateStoragePoolRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(StoragePool storagePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoragePoolAsync(new UpdateStoragePoolRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(StoragePool storagePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStoragePoolAsync(storagePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteStoragePool</c>.</summary>
        public virtual lro::OperationsClient DeleteStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePool(new DeleteStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePoolAsync(new DeleteStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePool(new DeleteStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePoolAsync(new DeleteStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(StoragePoolName name, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This operation will switch the active/replica zone for a regional
        /// storagePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> SwitchActiveReplicaZone(SwitchActiveReplicaZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This operation will switch the active/replica zone for a regional
        /// storagePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> SwitchActiveReplicaZoneAsync(SwitchActiveReplicaZoneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This operation will switch the active/replica zone for a regional
        /// storagePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> SwitchActiveReplicaZoneAsync(SwitchActiveReplicaZoneRequest request, st::CancellationToken cancellationToken) =>
            SwitchActiveReplicaZoneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SwitchActiveReplicaZone</c>.</summary>
        public virtual lro::OperationsClient SwitchActiveReplicaZoneOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchActiveReplicaZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> PollOnceSwitchActiveReplicaZone(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchActiveReplicaZoneOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SwitchActiveReplicaZone</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> PollOnceSwitchActiveReplicaZoneAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SwitchActiveReplicaZoneOperationsClient, callSettings);

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumes(request, callSettings);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumes(request, callSettings);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVolumesRequest request = new ListVolumesRequest
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
            return ListVolumesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVolume</c>.</summary>
        public virtual lro::OperationsClient CreateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceCreateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceCreateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(string parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolume(new CreateVolumeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(string parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeAsync(new CreateVolumeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(string parent, Volume volume, string volumeId, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(parent, volume, volumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(gagr::LocationName parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolume(new CreateVolumeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(gagr::LocationName parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeAsync(new CreateVolumeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(gagr::LocationName parent, Volume volume, string volumeId, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(parent, volume, volumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public virtual lro::OperationsClient UpdateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceUpdateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceUpdateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolume(new UpdateVolumeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolumeAsync(new UpdateVolumeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(volume, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVolume</c>.</summary>
        public virtual lro::OperationsClient DeleteVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVolumeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolume(new DeleteVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeAsync(new DeleteVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolume(new DeleteVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeAsync(new DeleteVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> RevertVolume(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, st::CancellationToken cancellationToken) =>
            RevertVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RevertVolume</c>.</summary>
        public virtual lro::OperationsClient RevertVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RevertVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceRevertVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RevertVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceRevertVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertVolumeOperationsClient, callSettings);

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
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
            return ListSnapshots(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
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
            return ListSnapshotsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSnapshots(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSnapshotsAsync(request, callSettings);
        }

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public virtual lro::OperationsClient CreateSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> PollOnceCreateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> PollOnceCreateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(VolumeName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(VolumeName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(VolumeName parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSnapshot</c>.</summary>
        public virtual lro::OperationsClient DeleteSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, st::CancellationToken cancellationToken) =>
            UpdateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSnapshot</c>.</summary>
        public virtual lro::OperationsClient UpdateSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> PollOnceUpdateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> PollOnceUpdateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshot(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshotAsync(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSnapshotAsync(snapshot, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
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
            return ListActiveDirectories(request, callSettings);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
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
            return ListActiveDirectoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
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
            return ListActiveDirectories(request, callSettings);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
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
            return ListActiveDirectoriesAsync(request, callSettings);
        }

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectory(new GetActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectoryAsync(new GetActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectory(new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectoryAsync(new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(ActiveDirectoryName name, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient CreateActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> PollOnceCreateActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> PollOnceCreateActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectory(new CreateActiveDirectoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectoryAsync(new CreateActiveDirectoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectory(new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectoryAsync(new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create. Must be unique within the
        /// parent resource. Must contain only letters, numbers, underscore and hyphen,
        /// with the first character a letter or underscore, the last a letter or
        /// underscore or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient UpdateActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> PollOnceUpdateActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> PollOnceUpdateActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveDirectory(new UpdateActiveDirectoryRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
            }, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveDirectoryAsync(new UpdateActiveDirectoryRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
            }, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateActiveDirectoryAsync(activeDirectory, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient DeleteActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectory(new DeleteActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectoryAsync(new DeleteActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectory(new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectoryAsync(new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(ActiveDirectoryName name, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
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
            return ListKmsConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
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
            return ListKmsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
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
            return ListKmsConfigs(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
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
            return ListKmsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateKmsConfig</c>.</summary>
        public virtual lro::OperationsClient CreateKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceCreateKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceCreateKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(string parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfig(new CreateKmsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(string parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfigAsync(new CreateKmsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(string parent, KmsConfig kmsConfig, string kmsConfigId, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfig(new CreateKmsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfigAsync(new CreateKmsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfig(new GetKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfigAsync(new GetKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfig(new GetKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfigAsync(new GetKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(KmsConfigName name, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateKmsConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceUpdateKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceUpdateKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(KmsConfig kmsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsConfig(new UpdateKmsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(KmsConfig kmsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsConfigAsync(new UpdateKmsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(KmsConfig kmsConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateKmsConfigAsync(kmsConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> EncryptVolumes(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, st::CancellationToken cancellationToken) =>
            EncryptVolumesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EncryptVolumes</c>.</summary>
        public virtual lro::OperationsClient EncryptVolumesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EncryptVolumes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceEncryptVolumes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EncryptVolumesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EncryptVolumes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceEncryptVolumesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EncryptVolumesOperationsClient, callSettings);

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyKmsConfigResponse VerifyKmsConfig(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            VerifyKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteKmsConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfig(new DeleteKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfigAsync(new DeleteKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfig(new DeleteKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfigAsync(new DeleteKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(KmsConfigName name, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationsRequest request = new ListReplicationsRequest
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
            return ListReplications(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationsRequest request = new ListReplicationsRequest
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
            return ListReplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationsRequest request = new ListReplicationsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplications(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationsRequest request = new ListReplicationsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplication(new GetReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationAsync(new GetReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplication(new GetReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationAsync(new GetReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(ReplicationName name, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReplication</c>.</summary>
        public virtual lro::OperationsClient CreateReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceCreateReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceCreateReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(string parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplication(new CreateReplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(string parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplicationAsync(new CreateReplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(string parent, Replication replication, string replicationId, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(parent, replication, replicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(VolumeName parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplication(new CreateReplicationRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(VolumeName parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplicationAsync(new CreateReplicationRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create. Must be unique within the parent
        /// resource. Must contain only letters, numbers, underscore and hyphen, with
        /// the first character a letter or underscore, the last a letter or underscore
        /// or a number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(VolumeName parent, Replication replication, string replicationId, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(parent, replication, replicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReplication</c>.</summary>
        public virtual lro::OperationsClient DeleteReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReplicationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplication(new DeleteReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplicationAsync(new DeleteReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplication(new DeleteReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplicationAsync(new DeleteReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(ReplicationName name, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> UpdateReplication(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateReplication</c>.</summary>
        public virtual lro::OperationsClient UpdateReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceUpdateReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceUpdateReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> UpdateReplication(Replication replication, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReplication(new UpdateReplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(Replication replication, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReplicationAsync(new UpdateReplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(Replication replication, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReplicationAsync(replication, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> StopReplication(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, st::CancellationToken cancellationToken) =>
            StopReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopReplication</c>.</summary>
        public virtual lro::OperationsClient StopReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceStopReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceStopReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopReplicationOperationsClient, callSettings);

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> ResumeReplication(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, st::CancellationToken cancellationToken) =>
            ResumeReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeReplication</c>.</summary>
        public virtual lro::OperationsClient ResumeReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceResumeReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceResumeReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeReplicationOperationsClient, callSettings);

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> ReverseReplicationDirection(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, st::CancellationToken cancellationToken) =>
            ReverseReplicationDirectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReverseReplicationDirection</c>.</summary>
        public virtual lro::OperationsClient ReverseReplicationDirectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReverseReplicationDirection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceReverseReplicationDirection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReverseReplicationDirectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReverseReplicationDirection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceReverseReplicationDirectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReverseReplicationDirectionOperationsClient, callSettings);

        /// <summary>
        /// Creates new backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> CreateBackupVault(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(CreateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new backup vault
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
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(string parent, BackupVault backupVault, string backupVaultId, st::CancellationToken cancellationToken) =>
            CreateBackupVaultAsync(parent, backupVault, backupVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates new backup vault
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup vaults, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupVault">
        /// Required. A backupVault resource
        /// </param>
        /// <param name="backupVaultId">
        /// Required. The ID to use for the backupVault.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> CreateBackupVaultAsync(gagr::LocationName parent, BackupVault backupVault, string backupVaultId, st::CancellationToken cancellationToken) =>
            CreateBackupVaultAsync(parent, backupVault, backupVaultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVault(new GetBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVaultAsync(new GetBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupVault GetBackupVault(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVault(new GetBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupVaultAsync(new GetBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupVault> GetBackupVaultAsync(BackupVaultName name, st::CancellationToken cancellationToken) =>
            GetBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaults(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which to retrieve backupVault information,
        /// in the format
        /// `projects/{project_id}/locations/{location}`.
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
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which to retrieve backupVault information,
        /// in the format
        /// `projects/{project_id}/locations/{location}`.
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
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which to retrieve backupVault information,
        /// in the format
        /// `projects/{project_id}/locations/{location}`.
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
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="parent">
        /// Required. The location for which to retrieve backupVault information,
        /// in the format
        /// `projects/{project_id}/locations/{location}`.
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
        /// Updates the settings of a specific backup vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupVault, OperationMetadata> UpdateBackupVault(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific backup vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(UpdateBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific backup vault.
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
        /// Updates the settings of a specific backup vault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The backupVault being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Updates the settings of a specific backup vault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The backupVault being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Updates the settings of a specific backup vault.
        /// </summary>
        /// <param name="backupVault">
        /// Required. The backupVault being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupVault, OperationMetadata>> UpdateBackupVaultAsync(BackupVault backupVault, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupVaultAsync(backupVault, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
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
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVault(new DeleteBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVaultAsync(new DeleteBackupVaultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupVault(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVault(new DeleteBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(BackupVaultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupVaultAsync(new DeleteBackupVaultRequest
            {
                BackupVaultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="name">
        /// Required. The backupVault resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(BackupVaultName name, st::CancellationToken cancellationToken) =>
            DeleteBackupVaultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
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
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
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
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(BackupVaultName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsBackupVaultName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(BackupVaultName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsBackupVaultName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp backupVault to create the backups of, in the format
        /// `projects/*/locations/*/backupVaults/{backup_vault_id}`
        /// </param>
        /// <param name="backup">
        /// Required. A backup resource
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified backupVault.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(BackupVaultName parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="parent">
        /// Required. The backupVault for which to retrieve backup information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
        /// To retrieve backup information for all locations, use "-" for the
        /// `{location}` value.
        /// To retrieve backup information for all backupVaults, use "-" for the
        /// `{backup_vault_id}` value.
        /// To retrieve backup information for a volume, use "-" for the
        /// `{backup_vault_id}` value and specify volume full name with the filter.
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
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="parent">
        /// Required. The backupVault for which to retrieve backup information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
        /// To retrieve backup information for all locations, use "-" for the
        /// `{location}` value.
        /// To retrieve backup information for all backupVaults, use "-" for the
        /// `{backup_vault_id}` value.
        /// To retrieve backup information for a volume, use "-" for the
        /// `{backup_vault_id}` value and specify volume full name with the filter.
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
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="parent">
        /// Required. The backupVault for which to retrieve backup information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
        /// To retrieve backup information for all locations, use "-" for the
        /// `{location}` value.
        /// To retrieve backup information for all backupVaults, use "-" for the
        /// `{backup_vault_id}` value.
        /// To retrieve backup information for a volume, use "-" for the
        /// `{backup_vault_id}` value and specify volume full name with the filter.
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(BackupVaultName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackups(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="parent">
        /// Required. The backupVault for which to retrieve backup information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}`.
        /// To retrieve backup information for all locations, use "-" for the
        /// `{location}` value.
        /// To retrieve backup information for all backupVaults, use "-" for the
        /// `{backup_vault_id}` value.
        /// To retrieve backup information for a volume, use "-" for the
        /// `{backup_vault_id}` value and specify volume full name with the filter.
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(BackupVaultName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
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
            return ListBackupsAsync(request, callSettings);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
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
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupVaults/{backup_vault_id}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update backup with full spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update backup with full spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update backup with full spec.
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
        /// Update backup with full spec.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Update backup with full spec.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Update backup with full spec.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup resource to be updated.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> CreateBackupPolicy(CreateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(CreateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(CreateBackupPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateBackupPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBackupPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateBackupPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBackupPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> PollOnceCreateBackupPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackupPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> PollOnceCreateBackupPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> CreateBackupPolicy(string parent, BackupPolicy backupPolicy, string backupPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPolicy(new CreateBackupPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
                BackupPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPolicyId, nameof(backupPolicyId)),
            }, callSettings);

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(string parent, BackupPolicy backupPolicy, string backupPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPolicyAsync(new CreateBackupPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
                BackupPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPolicyId, nameof(backupPolicyId)),
            }, callSettings);

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(string parent, BackupPolicy backupPolicy, string backupPolicyId, st::CancellationToken cancellationToken) =>
            CreateBackupPolicyAsync(parent, backupPolicy, backupPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> CreateBackupPolicy(gagr::LocationName parent, BackupPolicy backupPolicy, string backupPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPolicy(new CreateBackupPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
                BackupPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPolicyId, nameof(backupPolicyId)),
            }, callSettings);

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(gagr::LocationName parent, BackupPolicy backupPolicy, string backupPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupPolicyAsync(new CreateBackupPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
                BackupPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupPolicyId, nameof(backupPolicyId)),
            }, callSettings);

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create the backup policies of, in the format
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="backupPolicy">
        /// Required. A backupPolicy resource
        /// </param>
        /// <param name="backupPolicyId">
        /// Required. The ID to use for the backup policy.
        /// The ID must be unique within the specified location.
        /// Must contain only letters, numbers, underscore and hyphen, with the first
        /// character a letter or underscore, the last a letter or underscore or a
        /// number, and a 63 character maximum.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(gagr::LocationName parent, BackupPolicy backupPolicy, string backupPolicyId, st::CancellationToken cancellationToken) =>
            CreateBackupPolicyAsync(parent, backupPolicy, backupPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPolicy GetBackupPolicy(GetBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(GetBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(GetBackupPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetBackupPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPolicy GetBackupPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPolicy(new GetBackupPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPolicyAsync(new GetBackupPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BackupPolicy GetBackupPolicy(BackupPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPolicy(new GetBackupPolicyRequest
            {
                BackupPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(BackupPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupPolicyAsync(new GetBackupPolicyRequest
            {
                BackupPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="name">
        /// Required. The backupPolicy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BackupPolicy> GetBackupPolicyAsync(BackupPolicyName name, st::CancellationToken cancellationToken) =>
            GetBackupPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPolicies(ListBackupPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPoliciesAsync(ListBackupPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupPoliciesRequest
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
        /// <returns>A pageable sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
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
            return ListBackupPolicies(request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupPoliciesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
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
            return ListBackupPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupPoliciesRequest
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
        /// <returns>A pageable sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
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
            return ListBackupPolicies(request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListBackupPoliciesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
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
            return ListBackupPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> UpdateBackupPolicy(UpdateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> UpdateBackupPolicyAsync(UpdateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> UpdateBackupPolicyAsync(UpdateBackupPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBackupPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateBackupPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBackupPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> PollOnceUpdateBackupPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackupPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> PollOnceUpdateBackupPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BackupPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="backupPolicy">
        /// Required. The backup policy being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup Policy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BackupPolicy, OperationMetadata> UpdateBackupPolicy(BackupPolicy backupPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupPolicy(new UpdateBackupPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="backupPolicy">
        /// Required. The backup policy being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup Policy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> UpdateBackupPolicyAsync(BackupPolicy backupPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupPolicyAsync(new UpdateBackupPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                BackupPolicy = gax::GaxPreconditions.CheckNotNull(backupPolicy, nameof(backupPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="backupPolicy">
        /// Required. The backup policy being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Backup Policy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> UpdateBackupPolicyAsync(BackupPolicy backupPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupPolicyAsync(backupPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPolicy(DeleteBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(DeleteBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(DeleteBackupPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBackupPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteBackupPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBackupPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBackupPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackupPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBackupPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupPolicyOperationsClient, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPolicy(new DeleteBackupPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPolicyAsync(new DeleteBackupPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPolicy(BackupPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPolicy(new DeleteBackupPolicyRequest
            {
                BackupPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(BackupPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupPolicyAsync(new DeleteBackupPolicyRequest
            {
                BackupPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="name">
        /// Required. The backup policy resource name, in the format
        /// `projects/{project_id}/locations/{location}/backupPolicies/{backup_policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(BackupPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteBackupPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetApp client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// NetApp Files Google Cloud Service
    /// </remarks>
    public sealed partial class NetAppClientImpl : NetAppClient
    {
        private readonly gaxgrpc::ApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse> _callListStoragePools;

        private readonly gaxgrpc::ApiCall<CreateStoragePoolRequest, lro::Operation> _callCreateStoragePool;

        private readonly gaxgrpc::ApiCall<GetStoragePoolRequest, StoragePool> _callGetStoragePool;

        private readonly gaxgrpc::ApiCall<UpdateStoragePoolRequest, lro::Operation> _callUpdateStoragePool;

        private readonly gaxgrpc::ApiCall<DeleteStoragePoolRequest, lro::Operation> _callDeleteStoragePool;

        private readonly gaxgrpc::ApiCall<SwitchActiveReplicaZoneRequest, lro::Operation> _callSwitchActiveReplicaZone;

        private readonly gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> _callListVolumes;

        private readonly gaxgrpc::ApiCall<GetVolumeRequest, Volume> _callGetVolume;

        private readonly gaxgrpc::ApiCall<CreateVolumeRequest, lro::Operation> _callCreateVolume;

        private readonly gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> _callUpdateVolume;

        private readonly gaxgrpc::ApiCall<DeleteVolumeRequest, lro::Operation> _callDeleteVolume;

        private readonly gaxgrpc::ApiCall<RevertVolumeRequest, lro::Operation> _callRevertVolume;

        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;

        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;

        private readonly gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> _callCreateSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> _callDeleteSnapshot;

        private readonly gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> _callUpdateSnapshot;

        private readonly gaxgrpc::ApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse> _callListActiveDirectories;

        private readonly gaxgrpc::ApiCall<GetActiveDirectoryRequest, ActiveDirectory> _callGetActiveDirectory;

        private readonly gaxgrpc::ApiCall<CreateActiveDirectoryRequest, lro::Operation> _callCreateActiveDirectory;

        private readonly gaxgrpc::ApiCall<UpdateActiveDirectoryRequest, lro::Operation> _callUpdateActiveDirectory;

        private readonly gaxgrpc::ApiCall<DeleteActiveDirectoryRequest, lro::Operation> _callDeleteActiveDirectory;

        private readonly gaxgrpc::ApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse> _callListKmsConfigs;

        private readonly gaxgrpc::ApiCall<CreateKmsConfigRequest, lro::Operation> _callCreateKmsConfig;

        private readonly gaxgrpc::ApiCall<GetKmsConfigRequest, KmsConfig> _callGetKmsConfig;

        private readonly gaxgrpc::ApiCall<UpdateKmsConfigRequest, lro::Operation> _callUpdateKmsConfig;

        private readonly gaxgrpc::ApiCall<EncryptVolumesRequest, lro::Operation> _callEncryptVolumes;

        private readonly gaxgrpc::ApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse> _callVerifyKmsConfig;

        private readonly gaxgrpc::ApiCall<DeleteKmsConfigRequest, lro::Operation> _callDeleteKmsConfig;

        private readonly gaxgrpc::ApiCall<ListReplicationsRequest, ListReplicationsResponse> _callListReplications;

        private readonly gaxgrpc::ApiCall<GetReplicationRequest, Replication> _callGetReplication;

        private readonly gaxgrpc::ApiCall<CreateReplicationRequest, lro::Operation> _callCreateReplication;

        private readonly gaxgrpc::ApiCall<DeleteReplicationRequest, lro::Operation> _callDeleteReplication;

        private readonly gaxgrpc::ApiCall<UpdateReplicationRequest, lro::Operation> _callUpdateReplication;

        private readonly gaxgrpc::ApiCall<StopReplicationRequest, lro::Operation> _callStopReplication;

        private readonly gaxgrpc::ApiCall<ResumeReplicationRequest, lro::Operation> _callResumeReplication;

        private readonly gaxgrpc::ApiCall<ReverseReplicationDirectionRequest, lro::Operation> _callReverseReplicationDirection;

        private readonly gaxgrpc::ApiCall<CreateBackupVaultRequest, lro::Operation> _callCreateBackupVault;

        private readonly gaxgrpc::ApiCall<GetBackupVaultRequest, BackupVault> _callGetBackupVault;

        private readonly gaxgrpc::ApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse> _callListBackupVaults;

        private readonly gaxgrpc::ApiCall<UpdateBackupVaultRequest, lro::Operation> _callUpdateBackupVault;

        private readonly gaxgrpc::ApiCall<DeleteBackupVaultRequest, lro::Operation> _callDeleteBackupVault;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<CreateBackupPolicyRequest, lro::Operation> _callCreateBackupPolicy;

        private readonly gaxgrpc::ApiCall<GetBackupPolicyRequest, BackupPolicy> _callGetBackupPolicy;

        private readonly gaxgrpc::ApiCall<ListBackupPoliciesRequest, ListBackupPoliciesResponse> _callListBackupPolicies;

        private readonly gaxgrpc::ApiCall<UpdateBackupPolicyRequest, lro::Operation> _callUpdateBackupPolicy;

        private readonly gaxgrpc::ApiCall<DeleteBackupPolicyRequest, lro::Operation> _callDeleteBackupPolicy;

        /// <summary>
        /// Constructs a client wrapper for the NetApp service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetAppSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetAppClientImpl(NetApp.NetAppClient grpcClient, NetAppSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetAppSettings effectiveSettings = settings ?? NetAppSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateStoragePoolOperationsSettings, logger);
            UpdateStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateStoragePoolOperationsSettings, logger);
            DeleteStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteStoragePoolOperationsSettings, logger);
            SwitchActiveReplicaZoneOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SwitchActiveReplicaZoneOperationsSettings, logger);
            CreateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVolumeOperationsSettings, logger);
            UpdateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVolumeOperationsSettings, logger);
            DeleteVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVolumeOperationsSettings, logger);
            RevertVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RevertVolumeOperationsSettings, logger);
            CreateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSnapshotOperationsSettings, logger);
            DeleteSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSnapshotOperationsSettings, logger);
            UpdateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSnapshotOperationsSettings, logger);
            CreateActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateActiveDirectoryOperationsSettings, logger);
            UpdateActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateActiveDirectoryOperationsSettings, logger);
            DeleteActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteActiveDirectoryOperationsSettings, logger);
            CreateKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateKmsConfigOperationsSettings, logger);
            UpdateKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateKmsConfigOperationsSettings, logger);
            EncryptVolumesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EncryptVolumesOperationsSettings, logger);
            DeleteKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteKmsConfigOperationsSettings, logger);
            CreateReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReplicationOperationsSettings, logger);
            DeleteReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReplicationOperationsSettings, logger);
            UpdateReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateReplicationOperationsSettings, logger);
            StopReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopReplicationOperationsSettings, logger);
            ResumeReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeReplicationOperationsSettings, logger);
            ReverseReplicationDirectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReverseReplicationDirectionOperationsSettings, logger);
            CreateBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupVaultOperationsSettings, logger);
            UpdateBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupVaultOperationsSettings, logger);
            DeleteBackupVaultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupVaultOperationsSettings, logger);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            UpdateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupOperationsSettings, logger);
            CreateBackupPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupPolicyOperationsSettings, logger);
            UpdateBackupPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupPolicyOperationsSettings, logger);
            DeleteBackupPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListStoragePools = clientHelper.BuildApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse>("ListStoragePools", grpcClient.ListStoragePoolsAsync, grpcClient.ListStoragePools, effectiveSettings.ListStoragePoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStoragePools);
            Modify_ListStoragePoolsApiCall(ref _callListStoragePools);
            _callCreateStoragePool = clientHelper.BuildApiCall<CreateStoragePoolRequest, lro::Operation>("CreateStoragePool", grpcClient.CreateStoragePoolAsync, grpcClient.CreateStoragePool, effectiveSettings.CreateStoragePoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStoragePool);
            Modify_CreateStoragePoolApiCall(ref _callCreateStoragePool);
            _callGetStoragePool = clientHelper.BuildApiCall<GetStoragePoolRequest, StoragePool>("GetStoragePool", grpcClient.GetStoragePoolAsync, grpcClient.GetStoragePool, effectiveSettings.GetStoragePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStoragePool);
            Modify_GetStoragePoolApiCall(ref _callGetStoragePool);
            _callUpdateStoragePool = clientHelper.BuildApiCall<UpdateStoragePoolRequest, lro::Operation>("UpdateStoragePool", grpcClient.UpdateStoragePoolAsync, grpcClient.UpdateStoragePool, effectiveSettings.UpdateStoragePoolSettings).WithGoogleRequestParam("storage_pool.name", request => request.StoragePool?.Name);
            Modify_ApiCall(ref _callUpdateStoragePool);
            Modify_UpdateStoragePoolApiCall(ref _callUpdateStoragePool);
            _callDeleteStoragePool = clientHelper.BuildApiCall<DeleteStoragePoolRequest, lro::Operation>("DeleteStoragePool", grpcClient.DeleteStoragePoolAsync, grpcClient.DeleteStoragePool, effectiveSettings.DeleteStoragePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStoragePool);
            Modify_DeleteStoragePoolApiCall(ref _callDeleteStoragePool);
            _callSwitchActiveReplicaZone = clientHelper.BuildApiCall<SwitchActiveReplicaZoneRequest, lro::Operation>("SwitchActiveReplicaZone", grpcClient.SwitchActiveReplicaZoneAsync, grpcClient.SwitchActiveReplicaZone, effectiveSettings.SwitchActiveReplicaZoneSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSwitchActiveReplicaZone);
            Modify_SwitchActiveReplicaZoneApiCall(ref _callSwitchActiveReplicaZone);
            _callListVolumes = clientHelper.BuildApiCall<ListVolumesRequest, ListVolumesResponse>("ListVolumes", grpcClient.ListVolumesAsync, grpcClient.ListVolumes, effectiveSettings.ListVolumesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumes);
            Modify_ListVolumesApiCall(ref _callListVolumes);
            _callGetVolume = clientHelper.BuildApiCall<GetVolumeRequest, Volume>("GetVolume", grpcClient.GetVolumeAsync, grpcClient.GetVolume, effectiveSettings.GetVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolume);
            Modify_GetVolumeApiCall(ref _callGetVolume);
            _callCreateVolume = clientHelper.BuildApiCall<CreateVolumeRequest, lro::Operation>("CreateVolume", grpcClient.CreateVolumeAsync, grpcClient.CreateVolume, effectiveSettings.CreateVolumeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVolume);
            Modify_CreateVolumeApiCall(ref _callCreateVolume);
            _callUpdateVolume = clientHelper.BuildApiCall<UpdateVolumeRequest, lro::Operation>("UpdateVolume", grpcClient.UpdateVolumeAsync, grpcClient.UpdateVolume, effectiveSettings.UpdateVolumeSettings).WithGoogleRequestParam("volume.name", request => request.Volume?.Name);
            Modify_ApiCall(ref _callUpdateVolume);
            Modify_UpdateVolumeApiCall(ref _callUpdateVolume);
            _callDeleteVolume = clientHelper.BuildApiCall<DeleteVolumeRequest, lro::Operation>("DeleteVolume", grpcClient.DeleteVolumeAsync, grpcClient.DeleteVolume, effectiveSettings.DeleteVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVolume);
            Modify_DeleteVolumeApiCall(ref _callDeleteVolume);
            _callRevertVolume = clientHelper.BuildApiCall<RevertVolumeRequest, lro::Operation>("RevertVolume", grpcClient.RevertVolumeAsync, grpcClient.RevertVolume, effectiveSettings.RevertVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevertVolume);
            Modify_RevertVolumeApiCall(ref _callRevertVolume);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>("ListSnapshots", grpcClient.ListSnapshotsAsync, grpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>("GetSnapshot", grpcClient.GetSnapshotAsync, grpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotRequest, lro::Operation>("CreateSnapshot", grpcClient.CreateSnapshotAsync, grpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSnapshot);
            Modify_CreateSnapshotApiCall(ref _callCreateSnapshot);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, lro::Operation>("DeleteSnapshot", grpcClient.DeleteSnapshotAsync, grpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
            _callUpdateSnapshot = clientHelper.BuildApiCall<UpdateSnapshotRequest, lro::Operation>("UpdateSnapshot", grpcClient.UpdateSnapshotAsync, grpcClient.UpdateSnapshot, effectiveSettings.UpdateSnapshotSettings).WithGoogleRequestParam("snapshot.name", request => request.Snapshot?.Name);
            Modify_ApiCall(ref _callUpdateSnapshot);
            Modify_UpdateSnapshotApiCall(ref _callUpdateSnapshot);
            _callListActiveDirectories = clientHelper.BuildApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse>("ListActiveDirectories", grpcClient.ListActiveDirectoriesAsync, grpcClient.ListActiveDirectories, effectiveSettings.ListActiveDirectoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListActiveDirectories);
            Modify_ListActiveDirectoriesApiCall(ref _callListActiveDirectories);
            _callGetActiveDirectory = clientHelper.BuildApiCall<GetActiveDirectoryRequest, ActiveDirectory>("GetActiveDirectory", grpcClient.GetActiveDirectoryAsync, grpcClient.GetActiveDirectory, effectiveSettings.GetActiveDirectorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetActiveDirectory);
            Modify_GetActiveDirectoryApiCall(ref _callGetActiveDirectory);
            _callCreateActiveDirectory = clientHelper.BuildApiCall<CreateActiveDirectoryRequest, lro::Operation>("CreateActiveDirectory", grpcClient.CreateActiveDirectoryAsync, grpcClient.CreateActiveDirectory, effectiveSettings.CreateActiveDirectorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateActiveDirectory);
            Modify_CreateActiveDirectoryApiCall(ref _callCreateActiveDirectory);
            _callUpdateActiveDirectory = clientHelper.BuildApiCall<UpdateActiveDirectoryRequest, lro::Operation>("UpdateActiveDirectory", grpcClient.UpdateActiveDirectoryAsync, grpcClient.UpdateActiveDirectory, effectiveSettings.UpdateActiveDirectorySettings).WithGoogleRequestParam("active_directory.name", request => request.ActiveDirectory?.Name);
            Modify_ApiCall(ref _callUpdateActiveDirectory);
            Modify_UpdateActiveDirectoryApiCall(ref _callUpdateActiveDirectory);
            _callDeleteActiveDirectory = clientHelper.BuildApiCall<DeleteActiveDirectoryRequest, lro::Operation>("DeleteActiveDirectory", grpcClient.DeleteActiveDirectoryAsync, grpcClient.DeleteActiveDirectory, effectiveSettings.DeleteActiveDirectorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteActiveDirectory);
            Modify_DeleteActiveDirectoryApiCall(ref _callDeleteActiveDirectory);
            _callListKmsConfigs = clientHelper.BuildApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse>("ListKmsConfigs", grpcClient.ListKmsConfigsAsync, grpcClient.ListKmsConfigs, effectiveSettings.ListKmsConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKmsConfigs);
            Modify_ListKmsConfigsApiCall(ref _callListKmsConfigs);
            _callCreateKmsConfig = clientHelper.BuildApiCall<CreateKmsConfigRequest, lro::Operation>("CreateKmsConfig", grpcClient.CreateKmsConfigAsync, grpcClient.CreateKmsConfig, effectiveSettings.CreateKmsConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKmsConfig);
            Modify_CreateKmsConfigApiCall(ref _callCreateKmsConfig);
            _callGetKmsConfig = clientHelper.BuildApiCall<GetKmsConfigRequest, KmsConfig>("GetKmsConfig", grpcClient.GetKmsConfigAsync, grpcClient.GetKmsConfig, effectiveSettings.GetKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKmsConfig);
            Modify_GetKmsConfigApiCall(ref _callGetKmsConfig);
            _callUpdateKmsConfig = clientHelper.BuildApiCall<UpdateKmsConfigRequest, lro::Operation>("UpdateKmsConfig", grpcClient.UpdateKmsConfigAsync, grpcClient.UpdateKmsConfig, effectiveSettings.UpdateKmsConfigSettings).WithGoogleRequestParam("kms_config.name", request => request.KmsConfig?.Name);
            Modify_ApiCall(ref _callUpdateKmsConfig);
            Modify_UpdateKmsConfigApiCall(ref _callUpdateKmsConfig);
            _callEncryptVolumes = clientHelper.BuildApiCall<EncryptVolumesRequest, lro::Operation>("EncryptVolumes", grpcClient.EncryptVolumesAsync, grpcClient.EncryptVolumes, effectiveSettings.EncryptVolumesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEncryptVolumes);
            Modify_EncryptVolumesApiCall(ref _callEncryptVolumes);
            _callVerifyKmsConfig = clientHelper.BuildApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse>("VerifyKmsConfig", grpcClient.VerifyKmsConfigAsync, grpcClient.VerifyKmsConfig, effectiveSettings.VerifyKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyKmsConfig);
            Modify_VerifyKmsConfigApiCall(ref _callVerifyKmsConfig);
            _callDeleteKmsConfig = clientHelper.BuildApiCall<DeleteKmsConfigRequest, lro::Operation>("DeleteKmsConfig", grpcClient.DeleteKmsConfigAsync, grpcClient.DeleteKmsConfig, effectiveSettings.DeleteKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKmsConfig);
            Modify_DeleteKmsConfigApiCall(ref _callDeleteKmsConfig);
            _callListReplications = clientHelper.BuildApiCall<ListReplicationsRequest, ListReplicationsResponse>("ListReplications", grpcClient.ListReplicationsAsync, grpcClient.ListReplications, effectiveSettings.ListReplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReplications);
            Modify_ListReplicationsApiCall(ref _callListReplications);
            _callGetReplication = clientHelper.BuildApiCall<GetReplicationRequest, Replication>("GetReplication", grpcClient.GetReplicationAsync, grpcClient.GetReplication, effectiveSettings.GetReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReplication);
            Modify_GetReplicationApiCall(ref _callGetReplication);
            _callCreateReplication = clientHelper.BuildApiCall<CreateReplicationRequest, lro::Operation>("CreateReplication", grpcClient.CreateReplicationAsync, grpcClient.CreateReplication, effectiveSettings.CreateReplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReplication);
            Modify_CreateReplicationApiCall(ref _callCreateReplication);
            _callDeleteReplication = clientHelper.BuildApiCall<DeleteReplicationRequest, lro::Operation>("DeleteReplication", grpcClient.DeleteReplicationAsync, grpcClient.DeleteReplication, effectiveSettings.DeleteReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReplication);
            Modify_DeleteReplicationApiCall(ref _callDeleteReplication);
            _callUpdateReplication = clientHelper.BuildApiCall<UpdateReplicationRequest, lro::Operation>("UpdateReplication", grpcClient.UpdateReplicationAsync, grpcClient.UpdateReplication, effectiveSettings.UpdateReplicationSettings).WithGoogleRequestParam("replication.name", request => request.Replication?.Name);
            Modify_ApiCall(ref _callUpdateReplication);
            Modify_UpdateReplicationApiCall(ref _callUpdateReplication);
            _callStopReplication = clientHelper.BuildApiCall<StopReplicationRequest, lro::Operation>("StopReplication", grpcClient.StopReplicationAsync, grpcClient.StopReplication, effectiveSettings.StopReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopReplication);
            Modify_StopReplicationApiCall(ref _callStopReplication);
            _callResumeReplication = clientHelper.BuildApiCall<ResumeReplicationRequest, lro::Operation>("ResumeReplication", grpcClient.ResumeReplicationAsync, grpcClient.ResumeReplication, effectiveSettings.ResumeReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeReplication);
            Modify_ResumeReplicationApiCall(ref _callResumeReplication);
            _callReverseReplicationDirection = clientHelper.BuildApiCall<ReverseReplicationDirectionRequest, lro::Operation>("ReverseReplicationDirection", grpcClient.ReverseReplicationDirectionAsync, grpcClient.ReverseReplicationDirection, effectiveSettings.ReverseReplicationDirectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReverseReplicationDirection);
            Modify_ReverseReplicationDirectionApiCall(ref _callReverseReplicationDirection);
            _callCreateBackupVault = clientHelper.BuildApiCall<CreateBackupVaultRequest, lro::Operation>("CreateBackupVault", grpcClient.CreateBackupVaultAsync, grpcClient.CreateBackupVault, effectiveSettings.CreateBackupVaultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupVault);
            Modify_CreateBackupVaultApiCall(ref _callCreateBackupVault);
            _callGetBackupVault = clientHelper.BuildApiCall<GetBackupVaultRequest, BackupVault>("GetBackupVault", grpcClient.GetBackupVaultAsync, grpcClient.GetBackupVault, effectiveSettings.GetBackupVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupVault);
            Modify_GetBackupVaultApiCall(ref _callGetBackupVault);
            _callListBackupVaults = clientHelper.BuildApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse>("ListBackupVaults", grpcClient.ListBackupVaultsAsync, grpcClient.ListBackupVaults, effectiveSettings.ListBackupVaultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupVaults);
            Modify_ListBackupVaultsApiCall(ref _callListBackupVaults);
            _callUpdateBackupVault = clientHelper.BuildApiCall<UpdateBackupVaultRequest, lro::Operation>("UpdateBackupVault", grpcClient.UpdateBackupVaultAsync, grpcClient.UpdateBackupVault, effectiveSettings.UpdateBackupVaultSettings).WithGoogleRequestParam("backup_vault.name", request => request.BackupVault?.Name);
            Modify_ApiCall(ref _callUpdateBackupVault);
            Modify_UpdateBackupVaultApiCall(ref _callUpdateBackupVault);
            _callDeleteBackupVault = clientHelper.BuildApiCall<DeleteBackupVaultRequest, lro::Operation>("DeleteBackupVault", grpcClient.DeleteBackupVaultAsync, grpcClient.DeleteBackupVault, effectiveSettings.DeleteBackupVaultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupVault);
            Modify_DeleteBackupVaultApiCall(ref _callDeleteBackupVault);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, lro::Operation>("CreateBackup", grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, lro::Operation>("UpdateBackup", grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callCreateBackupPolicy = clientHelper.BuildApiCall<CreateBackupPolicyRequest, lro::Operation>("CreateBackupPolicy", grpcClient.CreateBackupPolicyAsync, grpcClient.CreateBackupPolicy, effectiveSettings.CreateBackupPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackupPolicy);
            Modify_CreateBackupPolicyApiCall(ref _callCreateBackupPolicy);
            _callGetBackupPolicy = clientHelper.BuildApiCall<GetBackupPolicyRequest, BackupPolicy>("GetBackupPolicy", grpcClient.GetBackupPolicyAsync, grpcClient.GetBackupPolicy, effectiveSettings.GetBackupPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackupPolicy);
            Modify_GetBackupPolicyApiCall(ref _callGetBackupPolicy);
            _callListBackupPolicies = clientHelper.BuildApiCall<ListBackupPoliciesRequest, ListBackupPoliciesResponse>("ListBackupPolicies", grpcClient.ListBackupPoliciesAsync, grpcClient.ListBackupPolicies, effectiveSettings.ListBackupPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackupPolicies);
            Modify_ListBackupPoliciesApiCall(ref _callListBackupPolicies);
            _callUpdateBackupPolicy = clientHelper.BuildApiCall<UpdateBackupPolicyRequest, lro::Operation>("UpdateBackupPolicy", grpcClient.UpdateBackupPolicyAsync, grpcClient.UpdateBackupPolicy, effectiveSettings.UpdateBackupPolicySettings).WithGoogleRequestParam("backup_policy.name", request => request.BackupPolicy?.Name);
            Modify_ApiCall(ref _callUpdateBackupPolicy);
            Modify_UpdateBackupPolicyApiCall(ref _callUpdateBackupPolicy);
            _callDeleteBackupPolicy = clientHelper.BuildApiCall<DeleteBackupPolicyRequest, lro::Operation>("DeleteBackupPolicy", grpcClient.DeleteBackupPolicyAsync, grpcClient.DeleteBackupPolicy, effectiveSettings.DeleteBackupPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackupPolicy);
            Modify_DeleteBackupPolicyApiCall(ref _callDeleteBackupPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListStoragePoolsApiCall(ref gaxgrpc::ApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse> call);

        partial void Modify_CreateStoragePoolApiCall(ref gaxgrpc::ApiCall<CreateStoragePoolRequest, lro::Operation> call);

        partial void Modify_GetStoragePoolApiCall(ref gaxgrpc::ApiCall<GetStoragePoolRequest, StoragePool> call);

        partial void Modify_UpdateStoragePoolApiCall(ref gaxgrpc::ApiCall<UpdateStoragePoolRequest, lro::Operation> call);

        partial void Modify_DeleteStoragePoolApiCall(ref gaxgrpc::ApiCall<DeleteStoragePoolRequest, lro::Operation> call);

        partial void Modify_SwitchActiveReplicaZoneApiCall(ref gaxgrpc::ApiCall<SwitchActiveReplicaZoneRequest, lro::Operation> call);

        partial void Modify_ListVolumesApiCall(ref gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> call);

        partial void Modify_GetVolumeApiCall(ref gaxgrpc::ApiCall<GetVolumeRequest, Volume> call);

        partial void Modify_CreateVolumeApiCall(ref gaxgrpc::ApiCall<CreateVolumeRequest, lro::Operation> call);

        partial void Modify_UpdateVolumeApiCall(ref gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> call);

        partial void Modify_DeleteVolumeApiCall(ref gaxgrpc::ApiCall<DeleteVolumeRequest, lro::Operation> call);

        partial void Modify_RevertVolumeApiCall(ref gaxgrpc::ApiCall<RevertVolumeRequest, lro::Operation> call);

        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);

        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);

        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> call);

        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> call);

        partial void Modify_UpdateSnapshotApiCall(ref gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> call);

        partial void Modify_ListActiveDirectoriesApiCall(ref gaxgrpc::ApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse> call);

        partial void Modify_GetActiveDirectoryApiCall(ref gaxgrpc::ApiCall<GetActiveDirectoryRequest, ActiveDirectory> call);

        partial void Modify_CreateActiveDirectoryApiCall(ref gaxgrpc::ApiCall<CreateActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_UpdateActiveDirectoryApiCall(ref gaxgrpc::ApiCall<UpdateActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_DeleteActiveDirectoryApiCall(ref gaxgrpc::ApiCall<DeleteActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_ListKmsConfigsApiCall(ref gaxgrpc::ApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse> call);

        partial void Modify_CreateKmsConfigApiCall(ref gaxgrpc::ApiCall<CreateKmsConfigRequest, lro::Operation> call);

        partial void Modify_GetKmsConfigApiCall(ref gaxgrpc::ApiCall<GetKmsConfigRequest, KmsConfig> call);

        partial void Modify_UpdateKmsConfigApiCall(ref gaxgrpc::ApiCall<UpdateKmsConfigRequest, lro::Operation> call);

        partial void Modify_EncryptVolumesApiCall(ref gaxgrpc::ApiCall<EncryptVolumesRequest, lro::Operation> call);

        partial void Modify_VerifyKmsConfigApiCall(ref gaxgrpc::ApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse> call);

        partial void Modify_DeleteKmsConfigApiCall(ref gaxgrpc::ApiCall<DeleteKmsConfigRequest, lro::Operation> call);

        partial void Modify_ListReplicationsApiCall(ref gaxgrpc::ApiCall<ListReplicationsRequest, ListReplicationsResponse> call);

        partial void Modify_GetReplicationApiCall(ref gaxgrpc::ApiCall<GetReplicationRequest, Replication> call);

        partial void Modify_CreateReplicationApiCall(ref gaxgrpc::ApiCall<CreateReplicationRequest, lro::Operation> call);

        partial void Modify_DeleteReplicationApiCall(ref gaxgrpc::ApiCall<DeleteReplicationRequest, lro::Operation> call);

        partial void Modify_UpdateReplicationApiCall(ref gaxgrpc::ApiCall<UpdateReplicationRequest, lro::Operation> call);

        partial void Modify_StopReplicationApiCall(ref gaxgrpc::ApiCall<StopReplicationRequest, lro::Operation> call);

        partial void Modify_ResumeReplicationApiCall(ref gaxgrpc::ApiCall<ResumeReplicationRequest, lro::Operation> call);

        partial void Modify_ReverseReplicationDirectionApiCall(ref gaxgrpc::ApiCall<ReverseReplicationDirectionRequest, lro::Operation> call);

        partial void Modify_CreateBackupVaultApiCall(ref gaxgrpc::ApiCall<CreateBackupVaultRequest, lro::Operation> call);

        partial void Modify_GetBackupVaultApiCall(ref gaxgrpc::ApiCall<GetBackupVaultRequest, BackupVault> call);

        partial void Modify_ListBackupVaultsApiCall(ref gaxgrpc::ApiCall<ListBackupVaultsRequest, ListBackupVaultsResponse> call);

        partial void Modify_UpdateBackupVaultApiCall(ref gaxgrpc::ApiCall<UpdateBackupVaultRequest, lro::Operation> call);

        partial void Modify_DeleteBackupVaultApiCall(ref gaxgrpc::ApiCall<DeleteBackupVaultRequest, lro::Operation> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> call);

        partial void Modify_CreateBackupPolicyApiCall(ref gaxgrpc::ApiCall<CreateBackupPolicyRequest, lro::Operation> call);

        partial void Modify_GetBackupPolicyApiCall(ref gaxgrpc::ApiCall<GetBackupPolicyRequest, BackupPolicy> call);

        partial void Modify_ListBackupPoliciesApiCall(ref gaxgrpc::ApiCall<ListBackupPoliciesRequest, ListBackupPoliciesResponse> call);

        partial void Modify_UpdateBackupPolicyApiCall(ref gaxgrpc::ApiCall<UpdateBackupPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteBackupPolicyApiCall(ref gaxgrpc::ApiCall<DeleteBackupPolicyRequest, lro::Operation> call);

        partial void OnConstruction(NetApp.NetAppClient grpcClient, NetAppSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetApp client</summary>
        public override NetApp.NetAppClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListStoragePoolsRequest(ref ListStoragePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateStoragePoolRequest(ref CreateStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStoragePoolRequest(ref GetStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStoragePoolRequest(ref UpdateStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStoragePoolRequest(ref DeleteStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SwitchActiveReplicaZoneRequest(ref SwitchActiveReplicaZoneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumesRequest(ref ListVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRequest(ref GetVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVolumeRequest(ref CreateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVolumeRequest(ref UpdateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVolumeRequest(ref DeleteVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevertVolumeRequest(ref RevertVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotRequest(ref CreateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSnapshotRequest(ref UpdateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListActiveDirectoriesRequest(ref ListActiveDirectoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetActiveDirectoryRequest(ref GetActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateActiveDirectoryRequest(ref CreateActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateActiveDirectoryRequest(ref UpdateActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteActiveDirectoryRequest(ref DeleteActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKmsConfigsRequest(ref ListKmsConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateKmsConfigRequest(ref CreateKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKmsConfigRequest(ref GetKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKmsConfigRequest(ref UpdateKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EncryptVolumesRequest(ref EncryptVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyKmsConfigRequest(ref VerifyKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKmsConfigRequest(ref DeleteKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReplicationsRequest(ref ListReplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReplicationRequest(ref GetReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReplicationRequest(ref CreateReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReplicationRequest(ref DeleteReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReplicationRequest(ref UpdateReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopReplicationRequest(ref StopReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeReplicationRequest(ref ResumeReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReverseReplicationDirectionRequest(ref ReverseReplicationDirectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupVaultRequest(ref CreateBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupVaultRequest(ref GetBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupVaultsRequest(ref ListBackupVaultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupVaultRequest(ref UpdateBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupVaultRequest(ref DeleteBackupVaultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupPolicyRequest(ref CreateBackupPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupPolicyRequest(ref GetBackupPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupPoliciesRequest(ref ListBackupPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupPolicyRequest(ref UpdateBackupPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupPolicyRequest(ref DeleteBackupPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public override gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStoragePoolsRequest, ListStoragePoolsResponse, StoragePool>(_callListStoragePools, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStoragePoolsRequest, ListStoragePoolsResponse, StoragePool>(_callListStoragePools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateStoragePool</c>.</summary>
        public override lro::OperationsClient CreateStoragePoolOperationsClient { get; }

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(_callCreateStoragePool.Sync(request, callSettings), CreateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(await _callCreateStoragePool.Async(request, callSettings).ConfigureAwait(false), CreateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoragePool GetStoragePool(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolRequest(ref request, ref callSettings);
            return _callGetStoragePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolRequest(ref request, ref callSettings);
            return _callGetStoragePool.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateStoragePool</c>.</summary>
        public override lro::OperationsClient UpdateStoragePoolOperationsClient { get; }

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(_callUpdateStoragePool.Sync(request, callSettings), UpdateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(await _callUpdateStoragePool.Async(request, callSettings).ConfigureAwait(false), UpdateStoragePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteStoragePool</c>.</summary>
        public override lro::OperationsClient DeleteStoragePoolOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteStoragePool.Sync(request, callSettings), DeleteStoragePoolOperationsClient);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteStoragePool.Async(request, callSettings).ConfigureAwait(false), DeleteStoragePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SwitchActiveReplicaZone</c>.</summary>
        public override lro::OperationsClient SwitchActiveReplicaZoneOperationsClient { get; }

        /// <summary>
        /// This operation will switch the active/replica zone for a regional
        /// storagePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StoragePool, OperationMetadata> SwitchActiveReplicaZone(SwitchActiveReplicaZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchActiveReplicaZoneRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(_callSwitchActiveReplicaZone.Sync(request, callSettings), SwitchActiveReplicaZoneOperationsClient);
        }

        /// <summary>
        /// This operation will switch the active/replica zone for a regional
        /// storagePool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StoragePool, OperationMetadata>> SwitchActiveReplicaZoneAsync(SwitchActiveReplicaZoneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchActiveReplicaZoneRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(await _callSwitchActiveReplicaZone.Async(request, callSettings).ConfigureAwait(false), SwitchActiveReplicaZoneOperationsClient);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateVolume</c>.</summary>
        public override lro::OperationsClient CreateVolumeOperationsClient { get; }

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> CreateVolume(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callCreateVolume.Sync(request, callSettings), CreateVolumeOperationsClient);
        }

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callCreateVolume.Async(request, callSettings).ConfigureAwait(false), CreateVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public override lro::OperationsClient UpdateVolumeOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callUpdateVolume.Sync(request, callSettings), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callUpdateVolume.Async(request, callSettings).ConfigureAwait(false), UpdateVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVolume</c>.</summary>
        public override lro::OperationsClient DeleteVolumeOperationsClient { get; }

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVolume.Sync(request, callSettings), DeleteVolumeOperationsClient);
        }

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVolume.Async(request, callSettings).ConfigureAwait(false), DeleteVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RevertVolume</c>.</summary>
        public override lro::OperationsClient RevertVolumeOperationsClient { get; }

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> RevertVolume(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callRevertVolume.Sync(request, callSettings), RevertVolumeOperationsClient);
        }

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callRevertVolume.Async(request, callSettings).ConfigureAwait(false), RevertVolumeOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public override lro::OperationsClient CreateSnapshotOperationsClient { get; }

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(_callCreateSnapshot.Sync(request, callSettings), CreateSnapshotOperationsClient);
        }

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(await _callCreateSnapshot.Async(request, callSettings).ConfigureAwait(false), CreateSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSnapshot</c>.</summary>
        public override lro::OperationsClient DeleteSnapshotOperationsClient { get; }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSnapshot.Sync(request, callSettings), DeleteSnapshotOperationsClient);
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSnapshot.Async(request, callSettings).ConfigureAwait(false), DeleteSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSnapshot</c>.</summary>
        public override lro::OperationsClient UpdateSnapshotOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(_callUpdateSnapshot.Sync(request, callSettings), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(await _callUpdateSnapshot.Async(request, callSettings).ConfigureAwait(false), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public override gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveDirectoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse, ActiveDirectory>(_callListActiveDirectories, request, callSettings);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveDirectoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse, ActiveDirectory>(_callListActiveDirectories, request, callSettings);
        }

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ActiveDirectory GetActiveDirectory(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetActiveDirectoryRequest(ref request, ref callSettings);
            return _callGetActiveDirectory.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetActiveDirectoryRequest(ref request, ref callSettings);
            return _callGetActiveDirectory.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateActiveDirectory</c>.</summary>
        public override lro::OperationsClient CreateActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(_callCreateActiveDirectory.Sync(request, callSettings), CreateActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(await _callCreateActiveDirectory.Async(request, callSettings).ConfigureAwait(false), CreateActiveDirectoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateActiveDirectory</c>.</summary>
        public override lro::OperationsClient UpdateActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(_callUpdateActiveDirectory.Sync(request, callSettings), UpdateActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(await _callUpdateActiveDirectory.Async(request, callSettings).ConfigureAwait(false), UpdateActiveDirectoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteActiveDirectory</c>.</summary>
        public override lro::OperationsClient DeleteActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteActiveDirectory.Sync(request, callSettings), DeleteActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteActiveDirectory.Async(request, callSettings).ConfigureAwait(false), DeleteActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKmsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKmsConfigsRequest, ListKmsConfigsResponse, KmsConfig>(_callListKmsConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKmsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKmsConfigsRequest, ListKmsConfigsResponse, KmsConfig>(_callListKmsConfigs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateKmsConfig</c>.</summary>
        public override lro::OperationsClient CreateKmsConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callCreateKmsConfig.Sync(request, callSettings), CreateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callCreateKmsConfig.Async(request, callSettings).ConfigureAwait(false), CreateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KmsConfig GetKmsConfig(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKmsConfigRequest(ref request, ref callSettings);
            return _callGetKmsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKmsConfigRequest(ref request, ref callSettings);
            return _callGetKmsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateKmsConfig</c>.</summary>
        public override lro::OperationsClient UpdateKmsConfigOperationsClient { get; }

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callUpdateKmsConfig.Sync(request, callSettings), UpdateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callUpdateKmsConfig.Async(request, callSettings).ConfigureAwait(false), UpdateKmsConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EncryptVolumes</c>.</summary>
        public override lro::OperationsClient EncryptVolumesOperationsClient { get; }

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> EncryptVolumes(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptVolumesRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callEncryptVolumes.Sync(request, callSettings), EncryptVolumesOperationsClient);
        }

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptVolumesRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callEncryptVolumes.Async(request, callSettings).ConfigureAwait(false), EncryptVolumesOperationsClient);
        }

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VerifyKmsConfigResponse VerifyKmsConfig(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyKmsConfigRequest(ref request, ref callSettings);
            return _callVerifyKmsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyKmsConfigRequest(ref request, ref callSettings);
            return _callVerifyKmsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteKmsConfig</c>.</summary>
        public override lro::OperationsClient DeleteKmsConfigOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteKmsConfig.Sync(request, callSettings), DeleteKmsConfigOperationsClient);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteKmsConfig.Async(request, callSettings).ConfigureAwait(false), DeleteKmsConfigOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public override gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReplicationsRequest, ListReplicationsResponse, Replication>(_callListReplications, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReplicationsRequest, ListReplicationsResponse, Replication>(_callListReplications, request, callSettings);
        }

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Replication GetReplication(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationRequest(ref request, ref callSettings);
            return _callGetReplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationRequest(ref request, ref callSettings);
            return _callGetReplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateReplication</c>.</summary>
        public override lro::OperationsClient CreateReplicationOperationsClient { get; }

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> CreateReplication(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callCreateReplication.Sync(request, callSettings), CreateReplicationOperationsClient);
        }

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callCreateReplication.Async(request, callSettings).ConfigureAwait(false), CreateReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteReplication</c>.</summary>
        public override lro::OperationsClient DeleteReplicationOperationsClient { get; }

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteReplication.Sync(request, callSettings), DeleteReplicationOperationsClient);
        }

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteReplication.Async(request, callSettings).ConfigureAwait(false), DeleteReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateReplication</c>.</summary>
        public override lro::OperationsClient UpdateReplicationOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> UpdateReplication(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callUpdateReplication.Sync(request, callSettings), UpdateReplicationOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callUpdateReplication.Async(request, callSettings).ConfigureAwait(false), UpdateReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopReplication</c>.</summary>
        public override lro::OperationsClient StopReplicationOperationsClient { get; }

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> StopReplication(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callStopReplication.Sync(request, callSettings), StopReplicationOperationsClient);
        }

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callStopReplication.Async(request, callSettings).ConfigureAwait(false), StopReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeReplication</c>.</summary>
        public override lro::OperationsClient ResumeReplicationOperationsClient { get; }

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> ResumeReplication(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callResumeReplication.Sync(request, callSettings), ResumeReplicationOperationsClient);
        }

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callResumeReplication.Async(request, callSettings).ConfigureAwait(false), ResumeReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReverseReplicationDirection</c>.</summary>
        public override lro::OperationsClient ReverseReplicationDirectionOperationsClient { get; }

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> ReverseReplicationDirection(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReverseReplicationDirectionRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callReverseReplicationDirection.Sync(request, callSettings), ReverseReplicationDirectionOperationsClient);
        }

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReverseReplicationDirectionRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callReverseReplicationDirection.Async(request, callSettings).ConfigureAwait(false), ReverseReplicationDirectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackupVault</c>.</summary>
        public override lro::OperationsClient CreateBackupVaultOperationsClient { get; }

        /// <summary>
        /// Creates new backup vault
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
        /// Creates new backup vault
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
        /// Returns the description of the specified backup vault
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
        /// Returns the description of the specified backup vault
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupVault> GetBackupVaultAsync(GetBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupVaultRequest(ref request, ref callSettings);
            return _callGetBackupVault.Async(request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup vaults.
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
        /// Returns list of all available backup vaults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupVault"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> ListBackupVaultsAsync(ListBackupVaultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupVaultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupVaultsRequest, ListBackupVaultsResponse, BackupVault>(_callListBackupVaults, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBackupVault</c>.</summary>
        public override lro::OperationsClient UpdateBackupVaultOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific backup vault.
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
        /// Updates the settings of a specific backup vault.
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
        /// Warning! This operation will permanently delete the backup vault.
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
        /// Warning! This operation will permanently delete the backup vault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupVaultAsync(DeleteBackupVaultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupVaultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupVault.Async(request, callSettings).ConfigureAwait(false), DeleteBackupVaultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public override lro::OperationsClient CreateBackupOperationsClient { get; }

        /// <summary>
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
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
        /// Creates a backup from the volume specified in the request
        /// The backup can be created from the given snapshot if specified in the
        /// request. If no snapshot specified, there'll be a new snapshot taken to
        /// initiate the backup creation.
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
        /// Returns the description of the specified backup
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
        /// Returns the description of the specified backup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupRequest(ref request, ref callSettings);
            return _callGetBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all backups for a backupVault.
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
        /// Returns descriptions of all backups for a backupVault.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the backup.
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
        /// Warning! This operation will permanently delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBackup</c>.</summary>
        public override lro::OperationsClient UpdateBackupOperationsClient { get; }

        /// <summary>
        /// Update backup with full spec.
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
        /// Update backup with full spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callUpdateBackup.Async(request, callSettings).ConfigureAwait(false), UpdateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateBackupPolicy</c>.</summary>
        public override lro::OperationsClient CreateBackupPolicyOperationsClient { get; }

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPolicy, OperationMetadata> CreateBackupPolicy(CreateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPolicy, OperationMetadata>(_callCreateBackupPolicy.Sync(request, callSettings), CreateBackupPolicyOperationsClient);
        }

        /// <summary>
        /// Creates new backup policy
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> CreateBackupPolicyAsync(CreateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPolicy, OperationMetadata>(await _callCreateBackupPolicy.Async(request, callSettings).ConfigureAwait(false), CreateBackupPolicyOperationsClient);
        }

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BackupPolicy GetBackupPolicy(GetBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPolicyRequest(ref request, ref callSettings);
            return _callGetBackupPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the description of the specified backup policy by backup_policy_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BackupPolicy> GetBackupPolicyAsync(GetBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBackupPolicyRequest(ref request, ref callSettings);
            return _callGetBackupPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BackupPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPolicies(ListBackupPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBackupPoliciesRequest, ListBackupPoliciesResponse, BackupPolicy>(_callListBackupPolicies, request, callSettings);
        }

        /// <summary>
        /// Returns list of all available backup policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BackupPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> ListBackupPoliciesAsync(ListBackupPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupPoliciesRequest, ListBackupPoliciesResponse, BackupPolicy>(_callListBackupPolicies, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateBackupPolicy</c>.</summary>
        public override lro::OperationsClient UpdateBackupPolicyOperationsClient { get; }

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BackupPolicy, OperationMetadata> UpdateBackupPolicy(UpdateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPolicy, OperationMetadata>(_callUpdateBackupPolicy.Sync(request, callSettings), UpdateBackupPolicyOperationsClient);
        }

        /// <summary>
        /// Updates settings of a specific backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BackupPolicy, OperationMetadata>> UpdateBackupPolicyAsync(UpdateBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<BackupPolicy, OperationMetadata>(await _callUpdateBackupPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateBackupPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackupPolicy</c>.</summary>
        public override lro::OperationsClient DeleteBackupPolicyOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBackupPolicy(DeleteBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBackupPolicy.Sync(request, callSettings), DeleteBackupPolicyOperationsClient);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the backup policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupPolicyAsync(DeleteBackupPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBackupPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteBackupPolicyOperationsClient);
        }
    }

    public partial class ListStoragePoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListActiveDirectoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKmsConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupVaultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStoragePoolsResponse : gaxgrpc::IPageResponse<StoragePool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StoragePool> GetEnumerator() => StoragePools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumesResponse : gaxgrpc::IPageResponse<Volume>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Volume> GetEnumerator() => Volumes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListActiveDirectoriesResponse : gaxgrpc::IPageResponse<ActiveDirectory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ActiveDirectory> GetEnumerator() => ActiveDirectories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListKmsConfigsResponse : gaxgrpc::IPageResponse<KmsConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<KmsConfig> GetEnumerator() => KmsConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReplicationsResponse : gaxgrpc::IPageResponse<Replication>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Replication> GetEnumerator() => Replications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupVaultsResponse : gaxgrpc::IPageResponse<BackupVault>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupVault> GetEnumerator() => BackupVaults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupPoliciesResponse : gaxgrpc::IPageResponse<BackupPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BackupPolicy> GetEnumerator() => BackupPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetApp
    {
        public partial class NetAppClient
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

    public static partial class NetApp
    {
        public partial class NetAppClient
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
