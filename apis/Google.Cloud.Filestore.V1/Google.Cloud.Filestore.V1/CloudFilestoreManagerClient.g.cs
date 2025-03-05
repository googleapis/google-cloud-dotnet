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
using gcc = Google.Cloud.Common;
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

namespace Google.Cloud.Filestore.V1
{
    /// <summary>Settings for <see cref="CloudFilestoreManagerClient"/> instances.</summary>
    public sealed partial class CloudFilestoreManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudFilestoreManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudFilestoreManagerSettings"/>.</returns>
        public static CloudFilestoreManagerSettings GetDefault() => new CloudFilestoreManagerSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudFilestoreManagerSettings"/> object with default settings.
        /// </summary>
        public CloudFilestoreManagerSettings()
        {
        }

        private CloudFilestoreManagerSettings(CloudFilestoreManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            RestoreInstanceSettings = existing.RestoreInstanceSettings;
            RestoreInstanceOperationsSettings = existing.RestoreInstanceOperationsSettings.Clone();
            RevertInstanceSettings = existing.RevertInstanceSettings;
            RevertInstanceOperationsSettings = existing.RevertInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            GetSnapshotSettings = existing.GetSnapshotSettings;
            CreateSnapshotSettings = existing.CreateSnapshotSettings;
            CreateSnapshotOperationsSettings = existing.CreateSnapshotOperationsSettings.Clone();
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            DeleteSnapshotOperationsSettings = existing.DeleteSnapshotOperationsSettings.Clone();
            UpdateSnapshotSettings = existing.UpdateSnapshotSettings;
            UpdateSnapshotOperationsSettings = existing.UpdateSnapshotOperationsSettings.Clone();
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            UpdateBackupSettings = existing.UpdateBackupSettings;
            UpdateBackupOperationsSettings = existing.UpdateBackupOperationsSettings.Clone();
            PromoteReplicaSettings = existing.PromoteReplicaSettings;
            PromoteReplicaOperationsSettings = existing.PromoteReplicaOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudFilestoreManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.ListInstances</c> and <c>CloudFilestoreManagerClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.GetInstance</c> and <c>CloudFilestoreManagerClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.CreateInstance</c> and <c>CloudFilestoreManagerClient.CreateInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.CreateInstance</c> and
        /// <c>CloudFilestoreManagerClient.CreateInstanceAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.UpdateInstance</c> and <c>CloudFilestoreManagerClient.UpdateInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.UpdateInstance</c> and
        /// <c>CloudFilestoreManagerClient.UpdateInstanceAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.RestoreInstance</c> and <c>CloudFilestoreManagerClient.RestoreInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.RestoreInstance</c> and
        /// <c>CloudFilestoreManagerClient.RestoreInstanceAsync</c>.
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
        public lro::OperationsSettings RestoreInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.RevertInstance</c> and <c>CloudFilestoreManagerClient.RevertInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevertInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.RevertInstance</c> and
        /// <c>CloudFilestoreManagerClient.RevertInstanceAsync</c>.
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
        public lro::OperationsSettings RevertInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.DeleteInstance</c> and <c>CloudFilestoreManagerClient.DeleteInstanceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.DeleteInstance</c> and
        /// <c>CloudFilestoreManagerClient.DeleteInstanceAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.ListSnapshots</c> and <c>CloudFilestoreManagerClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.GetSnapshot</c> and <c>CloudFilestoreManagerClient.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.CreateSnapshot</c> and <c>CloudFilestoreManagerClient.CreateSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.CreateSnapshot</c> and
        /// <c>CloudFilestoreManagerClient.CreateSnapshotAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.DeleteSnapshot</c> and <c>CloudFilestoreManagerClient.DeleteSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.DeleteSnapshot</c> and
        /// <c>CloudFilestoreManagerClient.DeleteSnapshotAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.UpdateSnapshot</c> and <c>CloudFilestoreManagerClient.UpdateSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.UpdateSnapshot</c> and
        /// <c>CloudFilestoreManagerClient.UpdateSnapshotAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.ListBackups</c> and <c>CloudFilestoreManagerClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.GetBackup</c> and <c>CloudFilestoreManagerClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 250 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(250), maxBackoff: sys::TimeSpan.FromMilliseconds(32000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFilestoreManagerClient.CreateBackup</c> and <c>CloudFilestoreManagerClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.CreateBackup</c> and
        /// <c>CloudFilestoreManagerClient.CreateBackupAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.DeleteBackup</c> and <c>CloudFilestoreManagerClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.DeleteBackup</c> and
        /// <c>CloudFilestoreManagerClient.DeleteBackupAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.UpdateBackup</c> and <c>CloudFilestoreManagerClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.UpdateBackup</c> and
        /// <c>CloudFilestoreManagerClient.UpdateBackupAsync</c>.
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
        /// <c>CloudFilestoreManagerClient.PromoteReplica</c> and <c>CloudFilestoreManagerClient.PromoteReplicaAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PromoteReplicaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFilestoreManagerClient.PromoteReplica</c> and
        /// <c>CloudFilestoreManagerClient.PromoteReplicaAsync</c>.
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
        public lro::OperationsSettings PromoteReplicaOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudFilestoreManagerSettings"/> object.</returns>
        public CloudFilestoreManagerSettings Clone() => new CloudFilestoreManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudFilestoreManagerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CloudFilestoreManagerClientBuilder : gaxgrpc::ClientBuilderBase<CloudFilestoreManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudFilestoreManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudFilestoreManagerClientBuilder() : base(CloudFilestoreManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudFilestoreManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudFilestoreManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudFilestoreManagerClient Build()
        {
            CloudFilestoreManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudFilestoreManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudFilestoreManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudFilestoreManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudFilestoreManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudFilestoreManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudFilestoreManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudFilestoreManagerClient.ChannelPool;
    }

    /// <summary>CloudFilestoreManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Filestore resources.
    /// 
    /// Filestore Manager v1.
    /// 
    /// The `file.googleapis.com` service implements the Filestore API and
    /// defines the following resource model for managing instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of instances and backups, named:
    /// `/instances/*` and `/backups/*` respectively.
    /// * As such, Filestore instances are resources of the form:
    /// `/projects/{project_number}/locations/{location_id}/instances/{instance_id}`
    /// and backups are resources of the form:
    /// `/projects/{project_number}/locations/{location_id}/backup/{backup_id}`
    /// 
    /// Note that location_id must be a Google Cloud `zone` for instances, but
    /// a Google Cloud `region` for backups; for example:
    /// * `projects/12345/locations/us-central1-c/instances/my-filestore`
    /// * `projects/12345/locations/us-central1/backups/my-backup`
    /// </remarks>
    public abstract partial class CloudFilestoreManagerClient
    {
        /// <summary>
        /// The default endpoint for the CloudFilestoreManager service, which is a host of "file.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "file.googleapis.com:443";

        /// <summary>The default CloudFilestoreManager scopes.</summary>
        /// <remarks>
        /// The default CloudFilestoreManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudFilestoreManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudFilestoreManagerClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudFilestoreManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudFilestoreManagerClient"/>.</returns>
        public static stt::Task<CloudFilestoreManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudFilestoreManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudFilestoreManagerClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudFilestoreManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudFilestoreManagerClient"/>.</returns>
        public static CloudFilestoreManagerClient Create() => new CloudFilestoreManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudFilestoreManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudFilestoreManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudFilestoreManagerClient"/>.</returns>
        internal static CloudFilestoreManagerClient Create(grpccore::CallInvoker callInvoker, CloudFilestoreManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudFilestoreManager.CloudFilestoreManagerClient grpcClient = new CloudFilestoreManager.CloudFilestoreManagerClient(callInvoker);
            return new CloudFilestoreManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudFilestoreManager client</summary>
        public virtual CloudFilestoreManager.CloudFilestoreManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve instance
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud Filestore, locations map to Google Cloud zones, for example
        /// **us-west1-b**. To retrieve instance information for all locations, use "-"
        /// for the
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
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve instance
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud Filestore, locations map to Google Cloud zones, for example
        /// **us-west1-b**. To retrieve instance information for all locations, use "-"
        /// for the
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
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve instance
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud Filestore, locations map to Google Cloud zones, for example
        /// **us-west1-b**. To retrieve instance information for all locations, use "-"
        /// for the
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
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve instance
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud Filestore, locations map to Google Cloud zones, for example
        /// **us-west1-b**. To retrieve instance information for all locations, use "-"
        /// for the
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
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> CreateInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> CreateInstance(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="parent">
        /// Required. The instance's project and location, in the format
        /// `projects/{project_id}/locations/{location}`. In Filestore,
        /// locations map to Google Cloud zones, for example **us-west1-b**.
        /// </param>
        /// <param name="instance">
        /// Required. An [instance resource][google.cloud.filestore.v1.Instance]
        /// </param>
        /// <param name="instanceId">
        /// Required. The name of the instance to create.
        /// The name must be unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="instance">
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.  At least one path must be supplied in this
        /// field.  The elements of the repeated paths field may only include these
        /// fields:
        /// 
        /// * "description"
        /// * "file_shares"
        /// * "labels"
        /// * "performance_config"
        /// * "deletion_protection_enabled"
        /// * "deletion_protection_reason"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> UpdateInstance(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = instance,
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="instance">
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.  At least one path must be supplied in this
        /// field.  The elements of the repeated paths field may only include these
        /// fields:
        /// 
        /// * "description"
        /// * "file_shares"
        /// * "labels"
        /// * "performance_config"
        /// * "deletion_protection_enabled"
        /// * "deletion_protection_reason"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = updateMask,
                Instance = instance,
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="instance">
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Mask of fields to update.  At least one path must be supplied in this
        /// field.  The elements of the repeated paths field may only include these
        /// fields:
        /// 
        /// * "description"
        /// * "file_shares"
        /// * "labels"
        /// * "performance_config"
        /// * "deletion_protection_enabled"
        /// * "deletion_protection_reason"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores an existing instance's file share from a backup.
        /// 
        /// The capacity of the instance needs to be equal to or larger than the
        /// capacity of the backup (and also equal to or larger than the minimum
        /// capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> RestoreInstance(RestoreInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores an existing instance's file share from a backup.
        /// 
        /// The capacity of the instance needs to be equal to or larger than the
        /// capacity of the backup (and also equal to or larger than the minimum
        /// capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RestoreInstanceAsync(RestoreInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores an existing instance's file share from a backup.
        /// 
        /// The capacity of the instance needs to be equal to or larger than the
        /// capacity of the backup (and also equal to or larger than the minimum
        /// capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RestoreInstanceAsync(RestoreInstanceRequest request, st::CancellationToken cancellationToken) =>
            RestoreInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreInstance</c>.</summary>
        public virtual lro::OperationsClient RestoreInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PollOnceRestoreInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PollOnceRestoreInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreInstanceOperationsClient, callSettings);

        /// <summary>
        /// Revert an existing instance's file system to a specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> RevertInstance(RevertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing instance's file system to a specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RevertInstanceAsync(RevertInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing instance's file system to a specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RevertInstanceAsync(RevertInstanceRequest request, st::CancellationToken cancellationToken) =>
            RevertInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RevertInstance</c>.</summary>
        public virtual lro::OperationsClient RevertInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RevertInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PollOnceRevertInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RevertInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PollOnceRevertInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The instance resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
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
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
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
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
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
            return ListSnapshots(request, callSettings);
        }

        /// <summary>
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnapshotsRequest request = new ListSnapshotsRequest
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
            return ListSnapshotsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> PollOnceCreateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> PollOnceCreateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> CreateSnapshot(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> CreateSnapshot(InstanceName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(InstanceName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="parent">
        /// Required. The Filestore Instance to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID to use for the snapshot.
        /// The ID must be unique within the specified instance.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(InstanceName parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> PollOnceDeleteSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> PollOnceDeleteSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> PollOnceUpdateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> PollOnceUpdateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, gcc::OperationMetadata> UpdateSnapshot(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshot(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshotAsync(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSnapshotAsync(snapshot, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore, backup
        /// locations map to Google Cloud regions, for example **us-west1**. To
        /// retrieve backup information for all locations, use "-" for the
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
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore, backup
        /// locations map to Google Cloud regions, for example **us-west1**. To
        /// retrieve backup information for all locations, use "-" for the
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
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore, backup
        /// locations map to Google Cloud regions, for example **us-west1**. To
        /// retrieve backup information for all locations, use "-" for the
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
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve backup
        /// information, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore, backup
        /// locations map to Google Cloud regions, for example **us-west1**. To
        /// retrieve backup information for all locations, use "-" for the
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
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
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
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
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
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
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
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
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
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, gcc::OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Backup, gcc::OperationMetadata> PollOnceCreateBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> PollOnceCreateBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, gcc::OperationMetadata> CreateBackup(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
            }, callSettings);

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
            }, callSettings);

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, gcc::OperationMetadata> CreateBackup(gagr::LocationName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
            }, callSettings);

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(gagr::LocationName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
            }, callSettings);

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="parent">
        /// Required. The backup's project and location, in the format
        /// `projects/{project_number}/locations/{location}`. In Filestore,
        /// backup locations map to Google Cloud regions, for example **us-west1**.
        /// </param>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="backupId">
        /// Required. The ID to use for the backup.
        /// The ID must be unique within the specified project and location.
        /// 
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// Values that do not match this pattern will trigger an INVALID_ARGUMENT
        /// error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(gagr::LocationName parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> PollOnceDeleteBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> PollOnceDeleteBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBackupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="name">
        /// Required. The backup resource name, in the format
        /// `projects/{project_number}/locations/{location}/backups/{backup_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, gcc::OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Backup, gcc::OperationMetadata> PollOnceUpdateBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> PollOnceUpdateBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBackupOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, gcc::OperationMetadata> UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="backup">
        /// Required. A [backup resource][google.cloud.filestore.v1.Backup]
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promote the standby instance (replica).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PromoteReplica(PromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote the standby instance (replica).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PromoteReplicaAsync(PromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promote the standby instance (replica).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PromoteReplicaAsync(PromoteReplicaRequest request, st::CancellationToken cancellationToken) =>
            PromoteReplicaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteReplica</c>.</summary>
        public virtual lro::OperationsClient PromoteReplicaOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteReplica</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, gcc::OperationMetadata> PollOncePromoteReplica(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteReplicaOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteReplica</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PollOncePromoteReplicaAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, gcc::OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteReplicaOperationsClient, callSettings);
    }

    /// <summary>CloudFilestoreManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages Filestore resources.
    /// 
    /// Filestore Manager v1.
    /// 
    /// The `file.googleapis.com` service implements the Filestore API and
    /// defines the following resource model for managing instances:
    /// * The service works with a collection of cloud projects, named: `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// * Each location has a collection of instances and backups, named:
    /// `/instances/*` and `/backups/*` respectively.
    /// * As such, Filestore instances are resources of the form:
    /// `/projects/{project_number}/locations/{location_id}/instances/{instance_id}`
    /// and backups are resources of the form:
    /// `/projects/{project_number}/locations/{location_id}/backup/{backup_id}`
    /// 
    /// Note that location_id must be a Google Cloud `zone` for instances, but
    /// a Google Cloud `region` for backups; for example:
    /// * `projects/12345/locations/us-central1-c/instances/my-filestore`
    /// * `projects/12345/locations/us-central1/backups/my-backup`
    /// </remarks>
    public sealed partial class CloudFilestoreManagerClientImpl : CloudFilestoreManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<RestoreInstanceRequest, lro::Operation> _callRestoreInstance;

        private readonly gaxgrpc::ApiCall<RevertInstanceRequest, lro::Operation> _callRevertInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;

        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;

        private readonly gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> _callCreateSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> _callDeleteSnapshot;

        private readonly gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> _callUpdateSnapshot;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<PromoteReplicaRequest, lro::Operation> _callPromoteReplica;

        /// <summary>
        /// Constructs a client wrapper for the CloudFilestoreManager service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudFilestoreManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudFilestoreManagerClientImpl(CloudFilestoreManager.CloudFilestoreManagerClient grpcClient, CloudFilestoreManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudFilestoreManagerSettings effectiveSettings = settings ?? CloudFilestoreManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            RestoreInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreInstanceOperationsSettings, logger);
            RevertInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RevertInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            CreateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSnapshotOperationsSettings, logger);
            DeleteSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSnapshotOperationsSettings, logger);
            UpdateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSnapshotOperationsSettings, logger);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            UpdateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBackupOperationsSettings, logger);
            PromoteReplicaOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteReplicaOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>("UpdateInstance", grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callRestoreInstance = clientHelper.BuildApiCall<RestoreInstanceRequest, lro::Operation>("RestoreInstance", grpcClient.RestoreInstanceAsync, grpcClient.RestoreInstance, effectiveSettings.RestoreInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreInstance);
            Modify_RestoreInstanceApiCall(ref _callRestoreInstance);
            _callRevertInstance = clientHelper.BuildApiCall<RevertInstanceRequest, lro::Operation>("RevertInstance", grpcClient.RevertInstanceAsync, grpcClient.RevertInstance, effectiveSettings.RevertInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevertInstance);
            Modify_RevertInstanceApiCall(ref _callRevertInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
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
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>("ListBackups", grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>("GetBackup", grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, lro::Operation>("CreateBackup", grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, lro::Operation>("DeleteBackup", grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, lro::Operation>("UpdateBackup", grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callPromoteReplica = clientHelper.BuildApiCall<PromoteReplicaRequest, lro::Operation>("PromoteReplica", grpcClient.PromoteReplicaAsync, grpcClient.PromoteReplica, effectiveSettings.PromoteReplicaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPromoteReplica);
            Modify_PromoteReplicaApiCall(ref _callPromoteReplica);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_RestoreInstanceApiCall(ref gaxgrpc::ApiCall<RestoreInstanceRequest, lro::Operation> call);

        partial void Modify_RevertInstanceApiCall(ref gaxgrpc::ApiCall<RevertInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);

        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);

        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> call);

        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> call);

        partial void Modify_UpdateSnapshotApiCall(ref gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, lro::Operation> call);

        partial void Modify_PromoteReplicaApiCall(ref gaxgrpc::ApiCall<PromoteReplicaRequest, lro::Operation> call);

        partial void OnConstruction(CloudFilestoreManager.CloudFilestoreManagerClient grpcClient, CloudFilestoreManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudFilestoreManager client</summary>
        public override CloudFilestoreManager.CloudFilestoreManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreInstanceRequest(ref RestoreInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevertInstanceRequest(ref RevertInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotRequest(ref CreateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSnapshotRequest(ref UpdateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteReplicaRequest(ref PromoteReplicaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
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
        /// Lists all instances in a project for either a specified location
        /// or for all locations.
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
        /// Gets the details of a specific instance.
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
        /// Gets the details of a specific instance.
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
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, gcc::OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates an instance.
        /// When creating from a backup, the capacity of the new instance needs to be
        /// equal to or larger than the capacity of the backup (and also equal to or
        /// larger than the minimum capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, gcc::OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreInstance</c>.</summary>
        public override lro::OperationsClient RestoreInstanceOperationsClient { get; }

        /// <summary>
        /// Restores an existing instance's file share from a backup.
        /// 
        /// The capacity of the instance needs to be equal to or larger than the
        /// capacity of the backup (and also equal to or larger than the minimum
        /// capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, gcc::OperationMetadata> RestoreInstance(RestoreInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(_callRestoreInstance.Sync(request, callSettings), RestoreInstanceOperationsClient);
        }

        /// <summary>
        /// Restores an existing instance's file share from a backup.
        /// 
        /// The capacity of the instance needs to be equal to or larger than the
        /// capacity of the backup (and also equal to or larger than the minimum
        /// capacity of the tier).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RestoreInstanceAsync(RestoreInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(await _callRestoreInstance.Async(request, callSettings).ConfigureAwait(false), RestoreInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RevertInstance</c>.</summary>
        public override lro::OperationsClient RevertInstanceOperationsClient { get; }

        /// <summary>
        /// Revert an existing instance's file system to a specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, gcc::OperationMetadata> RevertInstance(RevertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(_callRevertInstance.Sync(request, callSettings), RevertInstanceOperationsClient);
        }

        /// <summary>
        /// Revert an existing instance's file system to a specified snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> RevertInstanceAsync(RevertInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(await _callRevertInstance.Async(request, callSettings).ConfigureAwait(false), RevertInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
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
        /// Lists all snapshots in a project for either a specified location
        /// or for all locations.
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
        /// Gets the details of a specific snapshot.
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
        /// Gets the details of a specific snapshot.
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
        /// Creates a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, gcc::OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, gcc::OperationMetadata>(_callCreateSnapshot.Sync(request, callSettings), CreateSnapshotOperationsClient);
        }

        /// <summary>
        /// Creates a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, gcc::OperationMetadata>(await _callCreateSnapshot.Async(request, callSettings).ConfigureAwait(false), CreateSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSnapshot</c>.</summary>
        public override lro::OperationsClient DeleteSnapshotOperationsClient { get; }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(_callDeleteSnapshot.Sync(request, callSettings), DeleteSnapshotOperationsClient);
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(await _callDeleteSnapshot.Async(request, callSettings).ConfigureAwait(false), DeleteSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSnapshot</c>.</summary>
        public override lro::OperationsClient UpdateSnapshotOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, gcc::OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, gcc::OperationMetadata>(_callUpdateSnapshot.Sync(request, callSettings), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, gcc::OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, gcc::OperationMetadata>(await _callUpdateSnapshot.Async(request, callSettings).ConfigureAwait(false), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
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
        /// Lists all backups in a project for either a specified location or for all
        /// locations.
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

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public override lro::OperationsClient CreateBackupOperationsClient { get; }

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, gcc::OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, gcc::OperationMetadata>(_callCreateBackup.Sync(request, callSettings), CreateBackupOperationsClient);
        }

        /// <summary>
        /// Creates a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, gcc::OperationMetadata>(await _callCreateBackup.Async(request, callSettings).ConfigureAwait(false), CreateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, gcc::OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(_callDeleteBackup.Sync(request, callSettings), DeleteBackupOperationsClient);
        }

        /// <summary>
        /// Deletes a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, gcc::OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gcc::OperationMetadata>(await _callDeleteBackup.Async(request, callSettings).ConfigureAwait(false), DeleteBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBackup</c>.</summary>
        public override lro::OperationsClient UpdateBackupOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, gcc::OperationMetadata> UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, gcc::OperationMetadata>(_callUpdateBackup.Sync(request, callSettings), UpdateBackupOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, gcc::OperationMetadata>> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, gcc::OperationMetadata>(await _callUpdateBackup.Async(request, callSettings).ConfigureAwait(false), UpdateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PromoteReplica</c>.</summary>
        public override lro::OperationsClient PromoteReplicaOperationsClient { get; }

        /// <summary>
        /// Promote the standby instance (replica).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, gcc::OperationMetadata> PromoteReplica(PromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteReplicaRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(_callPromoteReplica.Sync(request, callSettings), PromoteReplicaOperationsClient);
        }

        /// <summary>
        /// Promote the standby instance (replica).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, gcc::OperationMetadata>> PromoteReplicaAsync(PromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteReplicaRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, gcc::OperationMetadata>(await _callPromoteReplica.Async(request, callSettings).ConfigureAwait(false), PromoteReplicaOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudFilestoreManager
    {
        public partial class CloudFilestoreManagerClient
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

    public static partial class CloudFilestoreManager
    {
        public partial class CloudFilestoreManagerClient
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
