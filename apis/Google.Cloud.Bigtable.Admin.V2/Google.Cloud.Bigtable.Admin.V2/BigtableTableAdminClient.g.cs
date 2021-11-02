// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    /// <summary>Settings for <see cref="BigtableTableAdminClient"/> instances.</summary>
    public sealed partial class BigtableTableAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigtableTableAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigtableTableAdminSettings"/>.</returns>
        public static BigtableTableAdminSettings GetDefault() => new BigtableTableAdminSettings();

        /// <summary>Constructs a new <see cref="BigtableTableAdminSettings"/> object with default settings.</summary>
        public BigtableTableAdminSettings()
        {
        }

        private BigtableTableAdminSettings(BigtableTableAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTableSettings = existing.CreateTableSettings;
            CreateTableFromSnapshotSettings = existing.CreateTableFromSnapshotSettings;
            CreateTableFromSnapshotOperationsSettings = existing.CreateTableFromSnapshotOperationsSettings.Clone();
            ListTablesSettings = existing.ListTablesSettings;
            GetTableSettings = existing.GetTableSettings;
            DeleteTableSettings = existing.DeleteTableSettings;
            ModifyColumnFamiliesSettings = existing.ModifyColumnFamiliesSettings;
            DropRowRangeSettings = existing.DropRowRangeSettings;
            GenerateConsistencyTokenSettings = existing.GenerateConsistencyTokenSettings;
            CheckConsistencySettings = existing.CheckConsistencySettings;
            SnapshotTableSettings = existing.SnapshotTableSettings;
            SnapshotTableOperationsSettings = existing.SnapshotTableOperationsSettings.Clone();
            GetSnapshotSettings = existing.GetSnapshotSettings;
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            GetBackupSettings = existing.GetBackupSettings;
            UpdateBackupSettings = existing.UpdateBackupSettings;
            DeleteBackupSettings = existing.DeleteBackupSettings;
            ListBackupsSettings = existing.ListBackupsSettings;
            RestoreTableSettings = existing.RestoreTableSettings;
            RestoreTableOperationsSettings = existing.RestoreTableOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableTableAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateTable</c> and <c>BigtableTableAdminClient.CreateTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTableFromSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.CreateTableFromSnapshot</c> and
        /// <c>BigtableTableAdminClient.CreateTableFromSnapshotAsync</c>.
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
        public lro::OperationsSettings CreateTableFromSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListTables</c> and <c>BigtableTableAdminClient.ListTablesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTablesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetTable</c> and <c>BigtableTableAdminClient.GetTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTableSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteTable</c> and <c>BigtableTableAdminClient.DeleteTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ModifyColumnFamilies</c> and
        /// <c>BigtableTableAdminClient.ModifyColumnFamiliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ModifyColumnFamiliesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DropRowRange</c> and <c>BigtableTableAdminClient.DropRowRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DropRowRangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GenerateConsistencyToken</c> and
        /// <c>BigtableTableAdminClient.GenerateConsistencyTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateConsistencyTokenSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CheckConsistency</c> and <c>BigtableTableAdminClient.CheckConsistencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckConsistencySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.SnapshotTable</c> and <c>BigtableTableAdminClient.SnapshotTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SnapshotTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.SnapshotTable</c> and
        /// <c>BigtableTableAdminClient.SnapshotTableAsync</c>.
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
        public lro::OperationsSettings SnapshotTableOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetSnapshot</c> and <c>BigtableTableAdminClient.GetSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListSnapshots</c> and <c>BigtableTableAdminClient.ListSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteSnapshot</c> and <c>BigtableTableAdminClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.CreateBackup</c> and <c>BigtableTableAdminClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.CreateBackup</c> and
        /// <c>BigtableTableAdminClient.CreateBackupAsync</c>.
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
        /// <c>BigtableTableAdminClient.GetBackup</c> and <c>BigtableTableAdminClient.GetBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBackupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.UpdateBackup</c> and <c>BigtableTableAdminClient.UpdateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.DeleteBackup</c> and <c>BigtableTableAdminClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.ListBackups</c> and <c>BigtableTableAdminClient.ListBackupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBackupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.RestoreTable</c> and <c>BigtableTableAdminClient.RestoreTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BigtableTableAdminClient.RestoreTable</c> and
        /// <c>BigtableTableAdminClient.RestoreTableAsync</c>.
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
        public lro::OperationsSettings RestoreTableOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.GetIamPolicy</c> and <c>BigtableTableAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.SetIamPolicy</c> and <c>BigtableTableAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableTableAdminClient.TestIamPermissions</c> and <c>BigtableTableAdminClient.TestIamPermissionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigtableTableAdminSettings"/> object.</returns>
        public BigtableTableAdminSettings Clone() => new BigtableTableAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableTableAdminClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BigtableTableAdminClientBuilder : gaxgrpc::ClientBuilderBase<BigtableTableAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigtableTableAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigtableTableAdminClientBuilder()
        {
            UseJwtAccessWithScopes = BigtableTableAdminClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BigtableTableAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigtableTableAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigtableTableAdminClient Build()
        {
            BigtableTableAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigtableTableAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigtableTableAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigtableTableAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableTableAdminClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BigtableTableAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableTableAdminClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BigtableTableAdminClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigtableTableAdminClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableTableAdminClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BigtableTableAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for creating, configuring, and deleting Cloud Bigtable tables.
    /// 
    /// 
    /// Provides access to the table schemas only, not the data stored within
    /// the tables.
    /// </remarks>
    public abstract partial class BigtableTableAdminClient
    {
        /// <summary>
        /// The default endpoint for the BigtableTableAdmin service, which is a host of "bigtableadmin.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigtableadmin.googleapis.com:443";

        /// <summary>The default BigtableTableAdmin scopes.</summary>
        /// <remarks>
        /// The default BigtableTableAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigtable.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigtable.admin.table</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.admin.table</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigtable.admin",
            "https://www.googleapis.com/auth/bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-bigtable.admin",
            "https://www.googleapis.com/auth/cloud-bigtable.admin.table",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableTableAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigtableTableAdminClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableTableAdminClient"/>.</returns>
        public static stt::Task<BigtableTableAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigtableTableAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigtableTableAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigtableTableAdminClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        public static BigtableTableAdminClient Create() => new BigtableTableAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigtableTableAdminClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigtableTableAdminSettings"/>.</param>
        /// <returns>The created <see cref="BigtableTableAdminClient"/>.</returns>
        internal static BigtableTableAdminClient Create(grpccore::CallInvoker callInvoker, BigtableTableAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigtableTableAdmin.BigtableTableAdminClient grpcClient = new BigtableTableAdmin.BigtableTableAdminClient(callInvoker);
            return new BigtableTableAdminClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BigtableTableAdmin client</summary>
        public virtual BigtableTableAdmin.BigtableTableAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table CreateTable(CreateTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(CreateTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(CreateTableRequest request, st::CancellationToken cancellationToken) =>
            CreateTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table CreateTable(string parent, string tableId, Table table, gaxgrpc::CallSettings callSettings = null) =>
            CreateTable(new CreateTableRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
            }, callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(string parent, string tableId, Table table, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableAsync(new CreateTableRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
            }, callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(string parent, string tableId, Table table, st::CancellationToken cancellationToken) =>
            CreateTableAsync(parent, tableId, table, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table CreateTable(InstanceName parent, string tableId, Table table, gaxgrpc::CallSettings callSettings = null) =>
            CreateTable(new CreateTableRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
            }, callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(InstanceName parent, string tableId, Table table, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableAsync(new CreateTableRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                Table = gax::GaxPreconditions.CheckNotNull(table, nameof(table)),
            }, callSettings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// Maximum 50 characters.
        /// </param>
        /// <param name="table">
        /// Required. The Table to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> CreateTableAsync(InstanceName parent, string tableId, Table table, st::CancellationToken cancellationToken) =>
            CreateTableAsync(parent, tableId, table, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(CreateTableFromSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest request, st::CancellationToken cancellationToken) =>
            CreateTableFromSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTableFromSnapshot</c>.</summary>
        public virtual lro::OperationsClient CreateTableFromSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTableFromSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> PollOnceCreateTableFromSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTableFromSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTableFromSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> PollOnceCreateTableFromSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Table, CreateTableFromSnapshotMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTableFromSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(string parent, string tableId, string sourceSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableFromSnapshot(new CreateTableFromSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                SourceSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceSnapshot, nameof(sourceSnapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(string parent, string tableId, string sourceSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableFromSnapshotAsync(new CreateTableFromSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                SourceSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceSnapshot, nameof(sourceSnapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(string parent, string tableId, string sourceSnapshot, st::CancellationToken cancellationToken) =>
            CreateTableFromSnapshotAsync(parent, tableId, sourceSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(InstanceName parent, string tableId, SnapshotName sourceSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableFromSnapshot(new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                SourceSnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(InstanceName parent, string tableId, SnapshotName sourceSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateTableFromSnapshotAsync(new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TableId = gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)),
                SourceSnapshotAsSnapshotName = gax::GaxPreconditions.CheckNotNull(sourceSnapshot, nameof(sourceSnapshot)),
            }, callSettings);

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance in which to create the table.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="tableId">
        /// Required. The name by which the new table should be referred to within the parent
        /// instance, e.g., `foobar` rather than `{parent}/tables/foobar`.
        /// </param>
        /// <param name="sourceSnapshot">
        /// Required. The unique name of the snapshot from which to restore the table. The
        /// snapshot and the table must be in the same instance.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(InstanceName parent, string tableId, SnapshotName sourceSnapshot, st::CancellationToken cancellationToken) =>
            CreateTableFromSnapshotAsync(parent, tableId, sourceSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTables(new ListTablesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTablesAsync(new ListTablesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTablesResponse, Table> ListTables(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTables(new ListTablesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the instance for which tables should be listed.
        /// Values are of the form `projects/{project}/instances/{instance}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTablesAsync(new ListTablesRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(GetTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(GetTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(GetTableRequest request, st::CancellationToken cancellationToken) =>
            GetTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTable(new GetTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableAsync(new GetTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(string name, st::CancellationToken cancellationToken) =>
            GetTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table GetTable(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTable(new GetTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableAsync(new GetTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested table.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> GetTableAsync(TableName name, st::CancellationToken cancellationToken) =>
            GetTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTable(DeleteTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(DeleteTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(DeleteTableRequest request, st::CancellationToken cancellationToken) =>
            DeleteTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTable(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTable(new DeleteTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableAsync(new DeleteTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTable(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTable(new DeleteTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableAsync(new DeleteTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableAsync(TableName name, st::CancellationToken cancellationToken) =>
            DeleteTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table ModifyColumnFamilies(ModifyColumnFamiliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest request, st::CancellationToken cancellationToken) =>
            ModifyColumnFamiliesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table ModifyColumnFamilies(string name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, gaxgrpc::CallSettings callSettings = null) =>
            ModifyColumnFamilies(new ModifyColumnFamiliesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Modifications =
                {
                    gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)),
                },
            }, callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(string name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, gaxgrpc::CallSettings callSettings = null) =>
            ModifyColumnFamiliesAsync(new ModifyColumnFamiliesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Modifications =
                {
                    gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)),
                },
            }, callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(string name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, st::CancellationToken cancellationToken) =>
            ModifyColumnFamiliesAsync(name, modifications, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Table ModifyColumnFamilies(TableName name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, gaxgrpc::CallSettings callSettings = null) =>
            ModifyColumnFamilies(new ModifyColumnFamiliesRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Modifications =
                {
                    gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)),
                },
            }, callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(TableName name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, gaxgrpc::CallSettings callSettings = null) =>
            ModifyColumnFamiliesAsync(new ModifyColumnFamiliesRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Modifications =
                {
                    gax::GaxPreconditions.CheckNotNull(modifications, nameof(modifications)),
                },
            }, callSettings);

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table whose families should be modified.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="modifications">
        /// Required. Modifications to be atomically applied to the specified table's families.
        /// Entries are applied in order, meaning that earlier modifications can be
        /// masked by later ones (in the case of repeated updates to the same family,
        /// for example).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Table> ModifyColumnFamiliesAsync(TableName name, scg::IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications, st::CancellationToken cancellationToken) =>
            ModifyColumnFamiliesAsync(name, modifications, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DropRowRange(DropRowRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DropRowRangeAsync(DropRowRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DropRowRangeAsync(DropRowRangeRequest request, st::CancellationToken cancellationToken) =>
            DropRowRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConsistencyTokenResponse GenerateConsistencyToken(GenerateConsistencyTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateConsistencyTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConsistencyTokenResponse GenerateConsistencyToken(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConsistencyToken(new GenerateConsistencyTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConsistencyTokenAsync(new GenerateConsistencyTokenRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateConsistencyTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConsistencyTokenResponse GenerateConsistencyToken(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConsistencyToken(new GenerateConsistencyTokenRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(TableName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConsistencyTokenAsync(new GenerateConsistencyTokenRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to create a consistency token.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(TableName name, st::CancellationToken cancellationToken) =>
            GenerateConsistencyTokenAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckConsistencyResponse CheckConsistency(CheckConsistencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(CheckConsistencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(CheckConsistencyRequest request, st::CancellationToken cancellationToken) =>
            CheckConsistencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckConsistencyResponse CheckConsistency(string name, string consistencyToken, gaxgrpc::CallSettings callSettings = null) =>
            CheckConsistency(new CheckConsistencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
            }, callSettings);

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(string name, string consistencyToken, gaxgrpc::CallSettings callSettings = null) =>
            CheckConsistencyAsync(new CheckConsistencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
            }, callSettings);

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(string name, string consistencyToken, st::CancellationToken cancellationToken) =>
            CheckConsistencyAsync(name, consistencyToken, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckConsistencyResponse CheckConsistency(TableName name, string consistencyToken, gaxgrpc::CallSettings callSettings = null) =>
            CheckConsistency(new CheckConsistencyRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
            }, callSettings);

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(TableName name, string consistencyToken, gaxgrpc::CallSettings callSettings = null) =>
            CheckConsistencyAsync(new CheckConsistencyRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ConsistencyToken = gax::GaxPreconditions.CheckNotNullOrEmpty(consistencyToken, nameof(consistencyToken)),
            }, callSettings);

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the Table for which to check replication consistency.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="consistencyToken">
        /// Required. The token created using GenerateConsistencyToken for the Table.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(TableName name, string consistencyToken, st::CancellationToken cancellationToken) =>
            CheckConsistencyAsync(name, consistencyToken, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(SnapshotTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(SnapshotTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(SnapshotTableRequest request, st::CancellationToken cancellationToken) =>
            SnapshotTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SnapshotTable</c>.</summary>
        public virtual lro::OperationsClient SnapshotTableOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SnapshotTable</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> PollOnceSnapshotTable(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SnapshotTableOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SnapshotTable</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> PollOnceSnapshotTableAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, SnapshotTableMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SnapshotTableOperationsClient, callSettings);

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(string name, string cluster, string snapshotId, string description, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotTable(new SnapshotTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Cluster = gax::GaxPreconditions.CheckNotNullOrEmpty(cluster, nameof(cluster)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Description = description ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(string name, string cluster, string snapshotId, string description, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotTableAsync(new SnapshotTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Cluster = gax::GaxPreconditions.CheckNotNullOrEmpty(cluster, nameof(cluster)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Description = description ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(string name, string cluster, string snapshotId, string description, st::CancellationToken cancellationToken) =>
            SnapshotTableAsync(name, cluster, snapshotId, description, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(TableName name, ClusterName cluster, string snapshotId, string description, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotTable(new SnapshotTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ClusterAsClusterName = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Description = description ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(TableName name, ClusterName cluster, string snapshotId, string description, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotTableAsync(new SnapshotTableRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ClusterAsClusterName = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
                Description = description ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the table to have the snapshot taken.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/tables/{table}`.
        /// </param>
        /// <param name="cluster">
        /// Required. The name of the cluster where the snapshot will be created in.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="snapshotId">
        /// Required. The ID by which the new snapshot should be referred to within the parent
        /// cluster, e.g., `mysnapshot` of the form: `[_a-zA-Z0-9][-_.a-zA-Z0-9]*`
        /// rather than
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/mysnapshot`.
        /// </param>
        /// <param name="description">
        /// Description of the snapshot.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(TableName name, ClusterName cluster, string snapshotId, string description, st::CancellationToken cancellationToken) =>
            SnapshotTableAsync(name, cluster, snapshotId, description, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the requested snapshot.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshots(new ListSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotsAsync(new ListSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshots(new ListSnapshotsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The unique name of the cluster for which snapshots should be listed.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list snapshots for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotsAsync(new ListSnapshotsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(DeleteSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the snapshot to be deleted.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/snapshots/{snapshot}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, CreateBackupMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(CreateBackupRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Backup, CreateBackupMetadata> PollOnceCreateBackup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, CreateBackupMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBackup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> PollOnceCreateBackupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Backup, CreateBackupMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBackupOperationsClient, callSettings);

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, CreateBackupMetadata> CreateBackup(string parent, string backupId, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(string parent, string backupId, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(string parent, string backupId, Backup backup, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backupId, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, CreateBackupMetadata> CreateBackup(ClusterName parent, string backupId, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(ClusterName parent, string backupId, Backup backup, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="parent">
        /// Required. This must be one of the clusters in the instance in which this
        /// table is located. The backup will be stored in this cluster. Values are
        /// of the form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// </param>
        /// <param name="backupId">
        /// Required. The id of the backup to be created. The `backup_id` along with
        /// the parent `parent` are combined as {parent}/backups/{backup_id} to create
        /// the full backup name, of the form:
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup_id}`.
        /// This string must be between 1 and 50 characters in length and match the
        /// regex [_a-zA-Z0-9][-_.a-zA-Z0-9]*.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(ClusterName parent, string backupId, Backup backup, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backupId, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> UpdateBackupAsync(UpdateBackupRequest request, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update. `backup.name`, and the fields to be updated
        /// as specified by `update_mask` are required. Other fields are ignored.
        /// Update is only supported for the following fields:
        /// * `backup.expire_time`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields (e.g. `expire_time`) in the
        /// Backup resource should be updated. This mask is relative to the Backup
        /// resource, not to the request message. The field mask must always be
        /// specified; this prevents any future fields from being erased accidentally
        /// by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup UpdateBackup(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackup(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update. `backup.name`, and the fields to be updated
        /// as specified by `update_mask` are required. Other fields are ignored.
        /// Update is only supported for the following fields:
        /// * `backup.expire_time`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields (e.g. `expire_time`) in the
        /// Backup resource should be updated. This mask is relative to the Backup
        /// resource, not to the request message. The field mask must always be
        /// specified; this prevents any future fields from being erased accidentally
        /// by clients that do not know about them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBackupAsync(new UpdateBackupRequest
            {
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="backup">
        /// Required. The backup to update. `backup.name`, and the fields to be updated
        /// as specified by `update_mask` are required. Other fields are ignored.
        /// Update is only supported for the following fields:
        /// * `backup.expire_time`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying which fields (e.g. `expire_time`) in the
        /// Backup resource should be updated. This mask is relative to the Backup
        /// resource, not to the request message. The field mask must always be
        /// specified; this prevents any future fields from being erased accidentally
        /// by clients that do not know about them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> UpdateBackupAsync(Backup backup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBackupAsync(backup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(DeleteBackupRequest request, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the backup to delete.
        /// Values are of the form
        /// `projects/{project}/instances/{instance}/clusters/{cluster}/backups/{backup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster to list backups from.  Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list backups for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBackups(new ListBackupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster to list backups from.  Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list backups for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBackupsAsync(new ListBackupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster to list backups from.  Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list backups for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBackups(new ListBackupsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="parent">
        /// Required. The cluster to list backups from.  Values are of the
        /// form `projects/{project}/instances/{instance}/clusters/{cluster}`.
        /// Use `{cluster} = '-'` to list backups for all clusters in an instance,
        /// e.g., `projects/{project}/instances/{instance}/clusters/-`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBackupsAsync(new ListBackupsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Create a new table by restoring from a completed backup. The new table
        /// must be in the same project as the instance containing the backup.  The
        /// returned table [long-running operation][google.longrunning.Operation] can
        /// be used to track the progress of the operation, and to cancel it.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [RestoreTableMetadata][google.bigtable.admin.RestoreTableMetadata].  The
        /// [response][google.longrunning.Operation.response] type is
        /// [Table][google.bigtable.admin.v2.Table], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Table, RestoreTableMetadata> RestoreTable(RestoreTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new table by restoring from a completed backup. The new table
        /// must be in the same project as the instance containing the backup.  The
        /// returned table [long-running operation][google.longrunning.Operation] can
        /// be used to track the progress of the operation, and to cancel it.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [RestoreTableMetadata][google.bigtable.admin.RestoreTableMetadata].  The
        /// [response][google.longrunning.Operation.response] type is
        /// [Table][google.bigtable.admin.v2.Table], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, RestoreTableMetadata>> RestoreTableAsync(RestoreTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new table by restoring from a completed backup. The new table
        /// must be in the same project as the instance containing the backup.  The
        /// returned table [long-running operation][google.longrunning.Operation] can
        /// be used to track the progress of the operation, and to cancel it.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [RestoreTableMetadata][google.bigtable.admin.RestoreTableMetadata].  The
        /// [response][google.longrunning.Operation.response] type is
        /// [Table][google.bigtable.admin.v2.Table], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Table, RestoreTableMetadata>> RestoreTableAsync(RestoreTableRequest request, st::CancellationToken cancellationToken) =>
            RestoreTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreTable</c>.</summary>
        public virtual lro::OperationsClient RestoreTableOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreTable</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Table, RestoreTableMetadata> PollOnceRestoreTable(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Table, RestoreTableMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreTableOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreTable</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Table, RestoreTableMetadata>> PollOnceRestoreTableAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Table, RestoreTableMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreTableOperationsClient, callSettings);

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BigtableTableAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for creating, configuring, and deleting Cloud Bigtable tables.
    /// 
    /// 
    /// Provides access to the table schemas only, not the data stored within
    /// the tables.
    /// </remarks>
    public sealed partial class BigtableTableAdminClientImpl : BigtableTableAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateTableRequest, Table> _callCreateTable;

        private readonly gaxgrpc::ApiCall<CreateTableFromSnapshotRequest, lro::Operation> _callCreateTableFromSnapshot;

        private readonly gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> _callListTables;

        private readonly gaxgrpc::ApiCall<GetTableRequest, Table> _callGetTable;

        private readonly gaxgrpc::ApiCall<DeleteTableRequest, wkt::Empty> _callDeleteTable;

        private readonly gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> _callModifyColumnFamilies;

        private readonly gaxgrpc::ApiCall<DropRowRangeRequest, wkt::Empty> _callDropRowRange;

        private readonly gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> _callGenerateConsistencyToken;

        private readonly gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> _callCheckConsistency;

        private readonly gaxgrpc::ApiCall<SnapshotTableRequest, lro::Operation> _callSnapshotTable;

        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;

        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, wkt::Empty> _callDeleteSnapshot;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<UpdateBackupRequest, Backup> _callUpdateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, wkt::Empty> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<RestoreTableRequest, lro::Operation> _callRestoreTable;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the BigtableTableAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableTableAdminSettings"/> used within this client.</param>
        public BigtableTableAdminClientImpl(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableTableAdminSettings effectiveSettings = settings ?? BigtableTableAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateTableFromSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTableFromSnapshotOperationsSettings);
            SnapshotTableOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SnapshotTableOperationsSettings);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings);
            RestoreTableOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreTableOperationsSettings);
            _callCreateTable = clientHelper.BuildApiCall<CreateTableRequest, Table>(grpcClient.CreateTableAsync, grpcClient.CreateTable, effectiveSettings.CreateTableSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTable);
            Modify_CreateTableApiCall(ref _callCreateTable);
            _callCreateTableFromSnapshot = clientHelper.BuildApiCall<CreateTableFromSnapshotRequest, lro::Operation>(grpcClient.CreateTableFromSnapshotAsync, grpcClient.CreateTableFromSnapshot, effectiveSettings.CreateTableFromSnapshotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTableFromSnapshot);
            Modify_CreateTableFromSnapshotApiCall(ref _callCreateTableFromSnapshot);
            _callListTables = clientHelper.BuildApiCall<ListTablesRequest, ListTablesResponse>(grpcClient.ListTablesAsync, grpcClient.ListTables, effectiveSettings.ListTablesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTables);
            Modify_ListTablesApiCall(ref _callListTables);
            _callGetTable = clientHelper.BuildApiCall<GetTableRequest, Table>(grpcClient.GetTableAsync, grpcClient.GetTable, effectiveSettings.GetTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTable);
            Modify_GetTableApiCall(ref _callGetTable);
            _callDeleteTable = clientHelper.BuildApiCall<DeleteTableRequest, wkt::Empty>(grpcClient.DeleteTableAsync, grpcClient.DeleteTable, effectiveSettings.DeleteTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTable);
            Modify_DeleteTableApiCall(ref _callDeleteTable);
            _callModifyColumnFamilies = clientHelper.BuildApiCall<ModifyColumnFamiliesRequest, Table>(grpcClient.ModifyColumnFamiliesAsync, grpcClient.ModifyColumnFamilies, effectiveSettings.ModifyColumnFamiliesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callModifyColumnFamilies);
            Modify_ModifyColumnFamiliesApiCall(ref _callModifyColumnFamilies);
            _callDropRowRange = clientHelper.BuildApiCall<DropRowRangeRequest, wkt::Empty>(grpcClient.DropRowRangeAsync, grpcClient.DropRowRange, effectiveSettings.DropRowRangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDropRowRange);
            Modify_DropRowRangeApiCall(ref _callDropRowRange);
            _callGenerateConsistencyToken = clientHelper.BuildApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse>(grpcClient.GenerateConsistencyTokenAsync, grpcClient.GenerateConsistencyToken, effectiveSettings.GenerateConsistencyTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateConsistencyToken);
            Modify_GenerateConsistencyTokenApiCall(ref _callGenerateConsistencyToken);
            _callCheckConsistency = clientHelper.BuildApiCall<CheckConsistencyRequest, CheckConsistencyResponse>(grpcClient.CheckConsistencyAsync, grpcClient.CheckConsistency, effectiveSettings.CheckConsistencySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCheckConsistency);
            Modify_CheckConsistencyApiCall(ref _callCheckConsistency);
            _callSnapshotTable = clientHelper.BuildApiCall<SnapshotTableRequest, lro::Operation>(grpcClient.SnapshotTableAsync, grpcClient.SnapshotTable, effectiveSettings.SnapshotTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSnapshotTable);
            Modify_SnapshotTableApiCall(ref _callSnapshotTable);
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>(grpcClient.GetSnapshotAsync, grpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>(grpcClient.ListSnapshotsAsync, grpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, wkt::Empty>(grpcClient.DeleteSnapshotAsync, grpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
            _callCreateBackup = clientHelper.BuildApiCall<CreateBackupRequest, lro::Operation>(grpcClient.CreateBackupAsync, grpcClient.CreateBackup, effectiveSettings.CreateBackupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBackup);
            Modify_CreateBackupApiCall(ref _callCreateBackup);
            _callGetBackup = clientHelper.BuildApiCall<GetBackupRequest, Backup>(grpcClient.GetBackupAsync, grpcClient.GetBackup, effectiveSettings.GetBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBackup);
            Modify_GetBackupApiCall(ref _callGetBackup);
            _callUpdateBackup = clientHelper.BuildApiCall<UpdateBackupRequest, Backup>(grpcClient.UpdateBackupAsync, grpcClient.UpdateBackup, effectiveSettings.UpdateBackupSettings).WithGoogleRequestParam("backup.name", request => request.Backup?.Name);
            Modify_ApiCall(ref _callUpdateBackup);
            Modify_UpdateBackupApiCall(ref _callUpdateBackup);
            _callDeleteBackup = clientHelper.BuildApiCall<DeleteBackupRequest, wkt::Empty>(grpcClient.DeleteBackupAsync, grpcClient.DeleteBackup, effectiveSettings.DeleteBackupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBackup);
            Modify_DeleteBackupApiCall(ref _callDeleteBackup);
            _callListBackups = clientHelper.BuildApiCall<ListBackupsRequest, ListBackupsResponse>(grpcClient.ListBackupsAsync, grpcClient.ListBackups, effectiveSettings.ListBackupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBackups);
            Modify_ListBackupsApiCall(ref _callListBackups);
            _callRestoreTable = clientHelper.BuildApiCall<RestoreTableRequest, lro::Operation>(grpcClient.RestoreTableAsync, grpcClient.RestoreTable, effectiveSettings.RestoreTableSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRestoreTable);
            Modify_RestoreTableApiCall(ref _callRestoreTable);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>(grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>(grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>(grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTableApiCall(ref gaxgrpc::ApiCall<CreateTableRequest, Table> call);

        partial void Modify_CreateTableFromSnapshotApiCall(ref gaxgrpc::ApiCall<CreateTableFromSnapshotRequest, lro::Operation> call);

        partial void Modify_ListTablesApiCall(ref gaxgrpc::ApiCall<ListTablesRequest, ListTablesResponse> call);

        partial void Modify_GetTableApiCall(ref gaxgrpc::ApiCall<GetTableRequest, Table> call);

        partial void Modify_DeleteTableApiCall(ref gaxgrpc::ApiCall<DeleteTableRequest, wkt::Empty> call);

        partial void Modify_ModifyColumnFamiliesApiCall(ref gaxgrpc::ApiCall<ModifyColumnFamiliesRequest, Table> call);

        partial void Modify_DropRowRangeApiCall(ref gaxgrpc::ApiCall<DropRowRangeRequest, wkt::Empty> call);

        partial void Modify_GenerateConsistencyTokenApiCall(ref gaxgrpc::ApiCall<GenerateConsistencyTokenRequest, GenerateConsistencyTokenResponse> call);

        partial void Modify_CheckConsistencyApiCall(ref gaxgrpc::ApiCall<CheckConsistencyRequest, CheckConsistencyResponse> call);

        partial void Modify_SnapshotTableApiCall(ref gaxgrpc::ApiCall<SnapshotTableRequest, lro::Operation> call);

        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);

        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);

        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, wkt::Empty> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_UpdateBackupApiCall(ref gaxgrpc::ApiCall<UpdateBackupRequest, Backup> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, wkt::Empty> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_RestoreTableApiCall(ref gaxgrpc::ApiCall<RestoreTableRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(BigtableTableAdmin.BigtableTableAdminClient grpcClient, BigtableTableAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigtableTableAdmin client</summary>
        public override BigtableTableAdmin.BigtableTableAdminClient GrpcClient { get; }

        partial void Modify_CreateTableRequest(ref CreateTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTableFromSnapshotRequest(ref CreateTableFromSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTablesRequest(ref ListTablesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTableRequest(ref GetTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTableRequest(ref DeleteTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ModifyColumnFamiliesRequest(ref ModifyColumnFamiliesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DropRowRangeRequest(ref DropRowRangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateConsistencyTokenRequest(ref GenerateConsistencyTokenRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckConsistencyRequest(ref CheckConsistencyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SnapshotTableRequest(ref SnapshotTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBackupRequest(ref UpdateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreTableRequest(ref RestoreTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Table CreateTable(CreateTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new table in the specified instance.
        /// The table can be created with a full set of initial column families,
        /// specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Table> CreateTableAsync(CreateTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableRequest(ref request, ref callSettings);
            return _callCreateTable.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTableFromSnapshot</c>.</summary>
        public override lro::OperationsClient CreateTableFromSnapshotOperationsClient { get; }

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Table, CreateTableFromSnapshotMetadata> CreateTableFromSnapshot(CreateTableFromSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Table, CreateTableFromSnapshotMetadata>(_callCreateTableFromSnapshot.Sync(request, callSettings), CreateTableFromSnapshotOperationsClient);
        }

        /// <summary>
        /// Creates a new table from the specified snapshot. The target table must
        /// not exist. The snapshot and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Table, CreateTableFromSnapshotMetadata>> CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTableFromSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Table, CreateTableFromSnapshotMetadata>(await _callCreateTableFromSnapshot.Async(request, callSettings).ConfigureAwait(false), CreateTableFromSnapshotOperationsClient);
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Table"/> resources.</returns>
        public override gax::PagedEnumerable<ListTablesResponse, Table> ListTables(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Lists all tables served from a specified instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Table"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTablesResponse, Table> ListTablesAsync(ListTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTablesRequest, ListTablesResponse, Table>(_callListTables, request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Table GetTable(GetTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata information about the specified table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Table> GetTableAsync(GetTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableRequest(ref request, ref callSettings);
            return _callGetTable.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTable(DeleteTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            _callDeleteTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes a specified table and all of its data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTableAsync(DeleteTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTableRequest(ref request, ref callSettings);
            return _callDeleteTable.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Table ModifyColumnFamilies(ModifyColumnFamiliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a series of column family modifications on the specified table.
        /// Either all or none of the modifications will occur before this method
        /// returns, but data requests received prior to that point may see a table
        /// where only some modifications have taken effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Table> ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModifyColumnFamiliesRequest(ref request, ref callSettings);
            return _callModifyColumnFamilies.Async(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DropRowRange(DropRowRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            _callDropRowRange.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently drop/delete a row range from a specified table. The request can
        /// specify whether to delete all rows in a table, or only those that match a
        /// particular prefix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DropRowRangeAsync(DropRowRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DropRowRangeRequest(ref request, ref callSettings);
            return _callDropRowRange.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConsistencyTokenResponse GenerateConsistencyToken(GenerateConsistencyTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConsistencyTokenRequest(ref request, ref callSettings);
            return _callGenerateConsistencyToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a consistency token for a Table, which can be used in
        /// CheckConsistency to check whether mutations to the table that finished
        /// before this call started have been replicated. The tokens will be available
        /// for 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConsistencyTokenResponse> GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConsistencyTokenRequest(ref request, ref callSettings);
            return _callGenerateConsistencyToken.Async(request, callSettings);
        }

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckConsistencyResponse CheckConsistency(CheckConsistencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckConsistencyRequest(ref request, ref callSettings);
            return _callCheckConsistency.Sync(request, callSettings);
        }

        /// <summary>
        /// Checks replication consistency based on a consistency token, that is, if
        /// replication has caught up based on the conditions specified in the token
        /// and the check request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckConsistencyResponse> CheckConsistencyAsync(CheckConsistencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckConsistencyRequest(ref request, ref callSettings);
            return _callCheckConsistency.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SnapshotTable</c>.</summary>
        public override lro::OperationsClient SnapshotTableOperationsClient { get; }

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, SnapshotTableMetadata> SnapshotTable(SnapshotTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, SnapshotTableMetadata>(_callSnapshotTable.Sync(request, callSettings), SnapshotTableOperationsClient);
        }

        /// <summary>
        /// Creates a new snapshot in the specified cluster from the specified
        /// source table. The cluster and the table must be in the same instance.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, SnapshotTableMetadata>> SnapshotTableAsync(SnapshotTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotTableRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, SnapshotTableMetadata>(await _callSnapshotTable.Async(request, callSettings).ConfigureAwait(false), SnapshotTableOperationsClient);
        }

        /// <summary>
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
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
        /// Gets metadata information about the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
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
        /// Lists all snapshots associated with the specified cluster.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
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
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            _callDeleteSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Permanently deletes the specified snapshot.
        /// 
        /// Note: This is a private alpha release of Cloud Bigtable snapshots. This
        /// feature is not currently available to most Cloud Bigtable customers. This
        /// feature might be changed in backward-incompatible ways and is not
        /// recommended for production use. It is not subject to any SLA or deprecation
        /// policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return _callDeleteSnapshot.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBackup</c>.</summary>
        public override lro::OperationsClient CreateBackupOperationsClient { get; }

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Backup, CreateBackupMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, CreateBackupMetadata>(_callCreateBackup.Sync(request, callSettings), CreateBackupOperationsClient);
        }

        /// <summary>
        /// Starts creating a new Cloud Bigtable Backup.  The returned backup
        /// [long-running operation][google.longrunning.Operation] can be used to
        /// track creation of the backup. The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateBackupMetadata][google.bigtable.admin.v2.CreateBackupMetadata]. The
        /// [response][google.longrunning.Operation.response] field type is
        /// [Backup][google.bigtable.admin.v2.Backup], if successful. Cancelling the returned operation will stop the
        /// creation and delete the backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, CreateBackupMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, CreateBackupMetadata>(await _callCreateBackup.Async(request, callSettings).ConfigureAwait(false), CreateBackupOperationsClient);
        }

        /// <summary>
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
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
        /// Gets metadata on a pending or completed Cloud Bigtable Backup.
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
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Backup UpdateBackup(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return _callUpdateBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a pending or completed Cloud Bigtable Backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Backup> UpdateBackupAsync(UpdateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBackupRequest(ref request, ref callSettings);
            return _callUpdateBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            _callDeleteBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a pending or completed Cloud Bigtable backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBackupRequest(ref request, ref callSettings);
            return _callDeleteBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
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
        /// Lists Cloud Bigtable backups. Returns both completed and pending
        /// backups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBackupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBackupsRequest, ListBackupsResponse, Backup>(_callListBackups, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RestoreTable</c>.</summary>
        public override lro::OperationsClient RestoreTableOperationsClient { get; }

        /// <summary>
        /// Create a new table by restoring from a completed backup. The new table
        /// must be in the same project as the instance containing the backup.  The
        /// returned table [long-running operation][google.longrunning.Operation] can
        /// be used to track the progress of the operation, and to cancel it.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [RestoreTableMetadata][google.bigtable.admin.RestoreTableMetadata].  The
        /// [response][google.longrunning.Operation.response] type is
        /// [Table][google.bigtable.admin.v2.Table], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Table, RestoreTableMetadata> RestoreTable(RestoreTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreTableRequest(ref request, ref callSettings);
            return new lro::Operation<Table, RestoreTableMetadata>(_callRestoreTable.Sync(request, callSettings), RestoreTableOperationsClient);
        }

        /// <summary>
        /// Create a new table by restoring from a completed backup. The new table
        /// must be in the same project as the instance containing the backup.  The
        /// returned table [long-running operation][google.longrunning.Operation] can
        /// be used to track the progress of the operation, and to cancel it.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [RestoreTableMetadata][google.bigtable.admin.RestoreTableMetadata].  The
        /// [response][google.longrunning.Operation.response] type is
        /// [Table][google.bigtable.admin.v2.Table], if successful.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Table, RestoreTableMetadata>> RestoreTableAsync(RestoreTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreTableRequest(ref request, ref callSettings);
            return new lro::Operation<Table, RestoreTableMetadata>(await _callRestoreTable.Async(request, callSettings).ConfigureAwait(false), RestoreTableOperationsClient);
        }

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a Table or Backup resource.
        /// Returns an empty policy if the resource exists but does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a Table or Backup resource.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified Table or Backup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListTablesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTablesResponse : gaxgrpc::IPageResponse<Table>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Table> GetEnumerator() => Tables.GetEnumerator();

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

    public static partial class BigtableTableAdmin
    {
        public partial class BigtableTableAdminClient
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
}
