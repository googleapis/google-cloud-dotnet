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

namespace Google.Cloud.Metastore.V1Alpha
{
    /// <summary>Settings for <see cref="DataprocMetastoreClient"/> instances.</summary>
    public sealed partial class DataprocMetastoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataprocMetastoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataprocMetastoreSettings"/>.</returns>
        public static DataprocMetastoreSettings GetDefault() => new DataprocMetastoreSettings();

        /// <summary>Constructs a new <see cref="DataprocMetastoreSettings"/> object with default settings.</summary>
        public DataprocMetastoreSettings()
        {
        }

        private DataprocMetastoreSettings(DataprocMetastoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServicesSettings = existing.ListServicesSettings;
            GetServiceSettings = existing.GetServiceSettings;
            CreateServiceSettings = existing.CreateServiceSettings;
            CreateServiceOperationsSettings = existing.CreateServiceOperationsSettings.Clone();
            UpdateServiceSettings = existing.UpdateServiceSettings;
            UpdateServiceOperationsSettings = existing.UpdateServiceOperationsSettings.Clone();
            DeleteServiceSettings = existing.DeleteServiceSettings;
            DeleteServiceOperationsSettings = existing.DeleteServiceOperationsSettings.Clone();
            ListMetadataImportsSettings = existing.ListMetadataImportsSettings;
            GetMetadataImportSettings = existing.GetMetadataImportSettings;
            CreateMetadataImportSettings = existing.CreateMetadataImportSettings;
            CreateMetadataImportOperationsSettings = existing.CreateMetadataImportOperationsSettings.Clone();
            UpdateMetadataImportSettings = existing.UpdateMetadataImportSettings;
            UpdateMetadataImportOperationsSettings = existing.UpdateMetadataImportOperationsSettings.Clone();
            ExportMetadataSettings = existing.ExportMetadataSettings;
            ExportMetadataOperationsSettings = existing.ExportMetadataOperationsSettings.Clone();
            RestoreServiceSettings = existing.RestoreServiceSettings;
            RestoreServiceOperationsSettings = existing.RestoreServiceOperationsSettings.Clone();
            ListBackupsSettings = existing.ListBackupsSettings;
            GetBackupSettings = existing.GetBackupSettings;
            CreateBackupSettings = existing.CreateBackupSettings;
            CreateBackupOperationsSettings = existing.CreateBackupOperationsSettings.Clone();
            DeleteBackupSettings = existing.DeleteBackupSettings;
            DeleteBackupOperationsSettings = existing.DeleteBackupOperationsSettings.Clone();
            RemoveIamPolicySettings = existing.RemoveIamPolicySettings;
            QueryMetadataSettings = existing.QueryMetadataSettings;
            QueryMetadataOperationsSettings = existing.QueryMetadataOperationsSettings.Clone();
            MoveTableToDatabaseSettings = existing.MoveTableToDatabaseSettings;
            MoveTableToDatabaseOperationsSettings = existing.MoveTableToDatabaseOperationsSettings.Clone();
            AlterMetadataResourceLocationSettings = existing.AlterMetadataResourceLocationSettings;
            AlterMetadataResourceLocationOperationsSettings = existing.AlterMetadataResourceLocationOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataprocMetastoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.ListServices</c> and <c>DataprocMetastoreClient.ListServicesAsync</c>.
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
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.GetService</c> and <c>DataprocMetastoreClient.GetServiceAsync</c>.
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
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.CreateService</c> and <c>DataprocMetastoreClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.CreateService</c> and
        /// <c>DataprocMetastoreClient.CreateServiceAsync</c>.
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
        public lro::OperationsSettings CreateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.UpdateService</c> and <c>DataprocMetastoreClient.UpdateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.UpdateService</c> and
        /// <c>DataprocMetastoreClient.UpdateServiceAsync</c>.
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
        public lro::OperationsSettings UpdateServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.DeleteService</c> and <c>DataprocMetastoreClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.DeleteService</c> and
        /// <c>DataprocMetastoreClient.DeleteServiceAsync</c>.
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
        public lro::OperationsSettings DeleteServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.ListMetadataImports</c> and <c>DataprocMetastoreClient.ListMetadataImportsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListMetadataImportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.GetMetadataImport</c> and <c>DataprocMetastoreClient.GetMetadataImportAsync</c>.
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
        public gaxgrpc::CallSettings GetMetadataImportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.CreateMetadataImport</c> and <c>DataprocMetastoreClient.CreateMetadataImportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMetadataImportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.CreateMetadataImport</c> and
        /// <c>DataprocMetastoreClient.CreateMetadataImportAsync</c>.
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
        public lro::OperationsSettings CreateMetadataImportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.UpdateMetadataImport</c> and <c>DataprocMetastoreClient.UpdateMetadataImportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMetadataImportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.UpdateMetadataImport</c> and
        /// <c>DataprocMetastoreClient.UpdateMetadataImportAsync</c>.
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
        public lro::OperationsSettings UpdateMetadataImportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.ExportMetadata</c> and <c>DataprocMetastoreClient.ExportMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.ExportMetadata</c> and
        /// <c>DataprocMetastoreClient.ExportMetadataAsync</c>.
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
        public lro::OperationsSettings ExportMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.RestoreService</c> and <c>DataprocMetastoreClient.RestoreServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.RestoreService</c> and
        /// <c>DataprocMetastoreClient.RestoreServiceAsync</c>.
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
        public lro::OperationsSettings RestoreServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.ListBackups</c> and <c>DataprocMetastoreClient.ListBackupsAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.GetBackup</c> and <c>DataprocMetastoreClient.GetBackupAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.CreateBackup</c> and <c>DataprocMetastoreClient.CreateBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.CreateBackup</c> and
        /// <c>DataprocMetastoreClient.CreateBackupAsync</c>.
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
        /// <c>DataprocMetastoreClient.DeleteBackup</c> and <c>DataprocMetastoreClient.DeleteBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.DeleteBackup</c> and
        /// <c>DataprocMetastoreClient.DeleteBackupAsync</c>.
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
        /// <c>DataprocMetastoreClient.RemoveIamPolicy</c> and <c>DataprocMetastoreClient.RemoveIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings RemoveIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.QueryMetadata</c> and <c>DataprocMetastoreClient.QueryMetadataAsync</c>.
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
        public gaxgrpc::CallSettings QueryMetadataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.QueryMetadata</c> and
        /// <c>DataprocMetastoreClient.QueryMetadataAsync</c>.
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
        public lro::OperationsSettings QueryMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.MoveTableToDatabase</c> and <c>DataprocMetastoreClient.MoveTableToDatabaseAsync</c>
        /// .
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
        public gaxgrpc::CallSettings MoveTableToDatabaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.MoveTableToDatabase</c> and
        /// <c>DataprocMetastoreClient.MoveTableToDatabaseAsync</c>.
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
        public lro::OperationsSettings MoveTableToDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreClient.AlterMetadataResourceLocation</c> and
        /// <c>DataprocMetastoreClient.AlterMetadataResourceLocationAsync</c>.
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
        public gaxgrpc::CallSettings AlterMetadataResourceLocationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreClient.AlterMetadataResourceLocation</c>
        /// and <c>DataprocMetastoreClient.AlterMetadataResourceLocationAsync</c>.
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
        public lro::OperationsSettings AlterMetadataResourceLocationOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="DataprocMetastoreSettings"/> object.</returns>
        public DataprocMetastoreSettings Clone() => new DataprocMetastoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataprocMetastoreClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataprocMetastoreClientBuilder : gaxgrpc::ClientBuilderBase<DataprocMetastoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataprocMetastoreSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataprocMetastoreClientBuilder() : base(DataprocMetastoreClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataprocMetastoreClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataprocMetastoreClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataprocMetastoreClient Build()
        {
            DataprocMetastoreClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataprocMetastoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataprocMetastoreClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataprocMetastoreClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataprocMetastoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataprocMetastoreClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataprocMetastoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataprocMetastoreClient.ChannelPool;
    }

    /// <summary>DataprocMetastore client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages metastore services.
    /// Metastore services are fully managed, highly available, autoscaled,
    /// autohealing, OSS-native deployments of technical metadata management
    /// software. Each metastore service exposes a network endpoint through which
    /// metadata queries are served. Metadata queries can originate from a variety
    /// of sources, including Apache Hive, Apache Presto, and Apache Spark.
    /// 
    /// The Dataproc Metastore API defines the following resource model:
    /// 
    /// * The service works with a collection of Google Cloud projects, named:
    /// `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// (a location must refer to a Google Cloud `region`)
    /// * Each location has a collection of services, named: `/services/*`
    /// * Dataproc Metastore services are resources with names of the form:
    /// 
    /// `/projects/{project_number}/locations/{location_id}/services/{service_id}`.
    /// </remarks>
    public abstract partial class DataprocMetastoreClient
    {
        /// <summary>
        /// The default endpoint for the DataprocMetastore service, which is a host of "metastore.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "metastore.googleapis.com:443";

        /// <summary>The default DataprocMetastore scopes.</summary>
        /// <remarks>
        /// The default DataprocMetastore scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataprocMetastore.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataprocMetastoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataprocMetastoreClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataprocMetastoreClient"/>.</returns>
        public static stt::Task<DataprocMetastoreClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataprocMetastoreClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataprocMetastoreClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataprocMetastoreClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataprocMetastoreClient"/>.</returns>
        public static DataprocMetastoreClient Create() => new DataprocMetastoreClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataprocMetastoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataprocMetastoreSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataprocMetastoreClient"/>.</returns>
        internal static DataprocMetastoreClient Create(grpccore::CallInvoker callInvoker, DataprocMetastoreSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataprocMetastore.DataprocMetastoreClient grpcClient = new DataprocMetastore.DataprocMetastoreClient(callInvoker);
            return new DataprocMetastoreClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataprocMetastore client</summary>
        public virtual DataprocMetastore.DataprocMetastoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore services
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore services
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore services
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore services
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to retrieve,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public virtual lro::OperationsClient CreateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceCreateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceCreateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateServiceOperationsClient, callSettings);

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(string parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> CreateService(gagr::LocationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateService(new CreateServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(gagr::LocationName parent, Service service, string serviceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceAsync(new CreateServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ServiceId = gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// metastore service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="service">
        /// Required. The Metastore service to create. The `name` field is
        /// ignored. The ID of the created metastore service must be provided in
        /// the request's `service_id` field.
        /// </param>
        /// <param name="serviceId">
        /// Required. The ID of the metastore service, which is used as the final
        /// component of the metastore service's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(gagr::LocationName parent, Service service, string serviceId, st::CancellationToken cancellationToken) =>
            CreateServiceAsync(parent, service, serviceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public virtual lro::OperationsClient UpdateServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Service, OperationMetadata> PollOnceUpdateService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> PollOnceUpdateServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Service, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateServiceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="service">
        /// Required. The metastore service to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore service's `name` field is used to identify the metastore
        /// service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore service resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Service, OperationMetadata> UpdateService(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateService(new UpdateServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="service">
        /// Required. The metastore service to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore service's `name` field is used to identify the metastore
        /// service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore service resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateServiceAsync(new UpdateServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="service">
        /// Required. The metastore service to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore service's `name` field is used to identify the metastore
        /// service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore service resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(Service service, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateServiceAsync(service, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public virtual lro::OperationsClient DeleteServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteServiceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteService(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteServiceAsync(new DeleteServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore service to delete, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            DeleteServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImports(ListMetadataImportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImportsAsync(ListMetadataImportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose metadata imports
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetadataImportsRequest request = new ListMetadataImportsRequest
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
            return ListMetadataImports(request, callSettings);
        }

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose metadata imports
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetadataImportsRequest request = new ListMetadataImportsRequest
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
            return ListMetadataImportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose metadata imports
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImports(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetadataImportsRequest request = new ListMetadataImportsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetadataImports(request, callSettings);
        }

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose metadata imports
        /// to list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataImport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImportsAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetadataImportsRequest request = new ListMetadataImportsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetadataImportsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataImport GetMetadataImport(GetMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(GetMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(GetMetadataImportRequest request, st::CancellationToken cancellationToken) =>
            GetMetadataImportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataImport GetMetadataImport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataImport(new GetMetadataImportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataImportAsync(new GetMetadataImportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetadataImportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetadataImport GetMetadataImport(MetadataImportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataImport(new GetMetadataImportRequest
            {
                MetadataImportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(MetadataImportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataImportAsync(new GetMetadataImportRequest
            {
                MetadataImportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metadata import to retrieve, in
        /// the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/metadataImports/{import_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MetadataImport> GetMetadataImportAsync(MetadataImportName name, st::CancellationToken cancellationToken) =>
            GetMetadataImportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> CreateMetadataImport(CreateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(CreateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(CreateMetadataImportRequest request, st::CancellationToken cancellationToken) =>
            CreateMetadataImportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMetadataImport</c>.</summary>
        public virtual lro::OperationsClient CreateMetadataImportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMetadataImport</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> PollOnceCreateMetadataImport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataImport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMetadataImportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMetadataImport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> PollOnceCreateMetadataImportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataImport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMetadataImportOperationsClient, callSettings);

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> CreateMetadataImport(string parent, MetadataImport metadataImport, string metadataImportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataImport(new CreateMetadataImportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataImportId = gax::GaxPreconditions.CheckNotNullOrEmpty(metadataImportId, nameof(metadataImportId)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(string parent, MetadataImport metadataImport, string metadataImportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataImportAsync(new CreateMetadataImportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MetadataImportId = gax::GaxPreconditions.CheckNotNullOrEmpty(metadataImportId, nameof(metadataImportId)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(string parent, MetadataImport metadataImport, string metadataImportId, st::CancellationToken cancellationToken) =>
            CreateMetadataImportAsync(parent, metadataImport, metadataImportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> CreateMetadataImport(ServiceName parent, MetadataImport metadataImport, string metadataImportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataImport(new CreateMetadataImportRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataImportId = gax::GaxPreconditions.CheckNotNullOrEmpty(metadataImportId, nameof(metadataImportId)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(ServiceName parent, MetadataImport metadataImport, string metadataImportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetadataImportAsync(new CreateMetadataImportRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MetadataImportId = gax::GaxPreconditions.CheckNotNullOrEmpty(metadataImportId, nameof(metadataImportId)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// metastore import, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="metadataImport">
        /// Required. The metadata import to create. The `name` field is ignored. The
        /// ID of the created metadata import must be provided in the request's
        /// `metadata_import_id` field.
        /// </param>
        /// <param name="metadataImportId">
        /// Required. The ID of the metadata import, which is used as the final
        /// component of the metadata import's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(ServiceName parent, MetadataImport metadataImport, string metadataImportId, st::CancellationToken cancellationToken) =>
            CreateMetadataImportAsync(parent, metadataImport, metadataImportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> UpdateMetadataImport(UpdateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> UpdateMetadataImportAsync(UpdateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> UpdateMetadataImportAsync(UpdateMetadataImportRequest request, st::CancellationToken cancellationToken) =>
            UpdateMetadataImportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMetadataImport</c>.</summary>
        public virtual lro::OperationsClient UpdateMetadataImportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMetadataImport</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> PollOnceUpdateMetadataImport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataImport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMetadataImportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMetadataImport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> PollOnceUpdateMetadataImportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataImport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMetadataImportOperationsClient, callSettings);

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="metadataImport">
        /// Required. The metadata import to update. The server only merges fields
        /// in the import if they are specified in `update_mask`.
        /// 
        /// The metadata import's `name` field is used to identify the metastore
        /// import to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metadata import resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataImport, OperationMetadata> UpdateMetadataImport(MetadataImport metadataImport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMetadataImport(new UpdateMetadataImportRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="metadataImport">
        /// Required. The metadata import to update. The server only merges fields
        /// in the import if they are specified in `update_mask`.
        /// 
        /// The metadata import's `name` field is used to identify the metastore
        /// import to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metadata import resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> UpdateMetadataImportAsync(MetadataImport metadataImport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMetadataImportAsync(new UpdateMetadataImportRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                MetadataImport = gax::GaxPreconditions.CheckNotNull(metadataImport, nameof(metadataImport)),
            }, callSettings);

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="metadataImport">
        /// Required. The metadata import to update. The server only merges fields
        /// in the import if they are specified in `update_mask`.
        /// 
        /// The metadata import's `name` field is used to identify the metastore
        /// import to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metadata import resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataImport, OperationMetadata>> UpdateMetadataImportAsync(MetadataImport metadataImport, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMetadataImportAsync(metadataImport, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports metadata from a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MetadataExport, OperationMetadata> ExportMetadata(ExportMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports metadata from a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataExport, OperationMetadata>> ExportMetadataAsync(ExportMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports metadata from a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MetadataExport, OperationMetadata>> ExportMetadataAsync(ExportMetadataRequest request, st::CancellationToken cancellationToken) =>
            ExportMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportMetadata</c>.</summary>
        public virtual lro::OperationsClient ExportMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MetadataExport, OperationMetadata> PollOnceExportMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataExport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MetadataExport, OperationMetadata>> PollOnceExportMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MetadataExport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportMetadataOperationsClient, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> RestoreService(RestoreServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(RestoreServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(RestoreServiceRequest request, st::CancellationToken cancellationToken) =>
            RestoreServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreService</c>.</summary>
        public virtual lro::OperationsClient RestoreServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> PollOnceRestoreService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> PollOnceRestoreServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Restore, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreServiceOperationsClient, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> RestoreService(string service, string backup, gaxgrpc::CallSettings callSettings = null) =>
            RestoreService(new RestoreServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNullOrEmpty(service, nameof(service)),
                Backup = gax::GaxPreconditions.CheckNotNullOrEmpty(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(string service, string backup, gaxgrpc::CallSettings callSettings = null) =>
            RestoreServiceAsync(new RestoreServiceRequest
            {
                Service = gax::GaxPreconditions.CheckNotNullOrEmpty(service, nameof(service)),
                Backup = gax::GaxPreconditions.CheckNotNullOrEmpty(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(string service, string backup, st::CancellationToken cancellationToken) =>
            RestoreServiceAsync(service, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Restore, OperationMetadata> RestoreService(ServiceName service, BackupName backup, gaxgrpc::CallSettings callSettings = null) =>
            RestoreService(new RestoreServiceRequest
            {
                ServiceAsServiceName = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                BackupAsBackupName = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(ServiceName service, BackupName backup, gaxgrpc::CallSettings callSettings = null) =>
            RestoreServiceAsync(new RestoreServiceRequest
            {
                ServiceAsServiceName = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                BackupAsBackupName = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="service">
        /// Required. The relative resource name of the metastore service to run
        /// restore, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The relative resource name of the metastore service backup to
        /// restore from, in the following form:
        /// 
        /// `projects/{project_id}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(ServiceName service, BackupName backup, st::CancellationToken cancellationToken) =>
            RestoreServiceAsync(service, backup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists backups in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists backups in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Backup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ListBackupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists backups in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose backups to
        /// list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups`.
        /// </param>
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
        /// Lists backups in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose backups to
        /// list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups`.
        /// </param>
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
        /// Lists backups in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose backups to
        /// list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups`.
        /// </param>
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
        public virtual gax::PagedEnumerable<ListBackupsResponse, Backup> ListBackups(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists backups in a service.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service whose backups to
        /// list, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups`.
        /// </param>
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
        public virtual gax::PagedAsyncEnumerable<ListBackupsResponse, Backup> ListBackupsAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(GetBackupRequest request, st::CancellationToken cancellationToken) =>
            GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Backup GetBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackup(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBackupAsync(new GetBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to retrieve, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Backup> GetBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            GetBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new backup in a given project and location.
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
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
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
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
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
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(string parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Backup, OperationMetadata> CreateBackup(ServiceName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackup(new CreateBackupRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(ServiceName parent, Backup backup, string backupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBackupAsync(new CreateBackupRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BackupId = gax::GaxPreconditions.CheckNotNullOrEmpty(backupId, nameof(backupId)),
                Backup = gax::GaxPreconditions.CheckNotNull(backup, nameof(backup)),
            }, callSettings);

        /// <summary>
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the service in which to create a
        /// backup of the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}`.
        /// </param>
        /// <param name="backup">
        /// Required. The backup to create. The `name` field is ignored. The ID of the
        /// created backup must be provided in the request's `backup_id` field.
        /// </param>
        /// <param name="backupId">
        /// Required. The ID of the backup, which is used as the final component of the
        /// backup's name.
        /// 
        /// This value must be between 1 and 64 characters long, begin with a letter,
        /// end with a letter or number, and consist of alpha-numeric ASCII characters
        /// or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(ServiceName parent, Backup backup, string backupId, st::CancellationToken cancellationToken) =>
            CreateBackupAsync(parent, backup, backupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(DeleteBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single backup.
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
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBackup(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackup(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBackupAsync(new DeleteBackupRequest
            {
                BackupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single backup.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the backup to delete, in the
        /// following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/services/{service_id}/backups/{backup_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBackupAsync(BackupName name, st::CancellationToken cancellationToken) =>
            DeleteBackupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes the attached IAM policies for a resource
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveIamPolicyResponse RemoveIamPolicy(RemoveIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the attached IAM policies for a resource
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveIamPolicyResponse> RemoveIamPolicyAsync(RemoveIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes the attached IAM policies for a resource
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveIamPolicyResponse> RemoveIamPolicyAsync(RemoveIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            RemoveIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Query DPMS metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QueryMetadataResponse, OperationMetadata> QueryMetadata(QueryMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query DPMS metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QueryMetadataResponse, OperationMetadata>> QueryMetadataAsync(QueryMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query DPMS metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QueryMetadataResponse, OperationMetadata>> QueryMetadataAsync(QueryMetadataRequest request, st::CancellationToken cancellationToken) =>
            QueryMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>QueryMetadata</c>.</summary>
        public virtual lro::OperationsClient QueryMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>QueryMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QueryMetadataResponse, OperationMetadata> PollOnceQueryMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QueryMetadataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), QueryMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>QueryMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QueryMetadataResponse, OperationMetadata>> PollOnceQueryMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QueryMetadataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), QueryMetadataOperationsClient, callSettings);

        /// <summary>
        /// Move a table to another database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MoveTableToDatabaseResponse, OperationMetadata> MoveTableToDatabase(MoveTableToDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Move a table to another database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>> MoveTableToDatabaseAsync(MoveTableToDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Move a table to another database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>> MoveTableToDatabaseAsync(MoveTableToDatabaseRequest request, st::CancellationToken cancellationToken) =>
            MoveTableToDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveTableToDatabase</c>.</summary>
        public virtual lro::OperationsClient MoveTableToDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveTableToDatabase</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MoveTableToDatabaseResponse, OperationMetadata> PollOnceMoveTableToDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveTableToDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveTableToDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>> PollOnceMoveTableToDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveTableToDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Alter metadata resource location. The metadata resource can be a database,
        /// table, or partition. This functionality only updates the parent directory
        /// for the respective metadata resource and does not transfer any existing
        /// data to the new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata> AlterMetadataResourceLocation(AlterMetadataResourceLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Alter metadata resource location. The metadata resource can be a database,
        /// table, or partition. This functionality only updates the parent directory
        /// for the respective metadata resource and does not transfer any existing
        /// data to the new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>> AlterMetadataResourceLocationAsync(AlterMetadataResourceLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Alter metadata resource location. The metadata resource can be a database,
        /// table, or partition. This functionality only updates the parent directory
        /// for the respective metadata resource and does not transfer any existing
        /// data to the new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>> AlterMetadataResourceLocationAsync(AlterMetadataResourceLocationRequest request, st::CancellationToken cancellationToken) =>
            AlterMetadataResourceLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AlterMetadataResourceLocation</c>.</summary>
        public virtual lro::OperationsClient AlterMetadataResourceLocationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AlterMetadataResourceLocation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata> PollOnceAlterMetadataResourceLocation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AlterMetadataResourceLocationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AlterMetadataResourceLocation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>> PollOnceAlterMetadataResourceLocationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AlterMetadataResourceLocationOperationsClient, callSettings);
    }

    /// <summary>DataprocMetastore client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages metastore services.
    /// Metastore services are fully managed, highly available, autoscaled,
    /// autohealing, OSS-native deployments of technical metadata management
    /// software. Each metastore service exposes a network endpoint through which
    /// metadata queries are served. Metadata queries can originate from a variety
    /// of sources, including Apache Hive, Apache Presto, and Apache Spark.
    /// 
    /// The Dataproc Metastore API defines the following resource model:
    /// 
    /// * The service works with a collection of Google Cloud projects, named:
    /// `/projects/*`
    /// * Each project has a collection of available locations, named: `/locations/*`
    /// (a location must refer to a Google Cloud `region`)
    /// * Each location has a collection of services, named: `/services/*`
    /// * Dataproc Metastore services are resources with names of the form:
    /// 
    /// `/projects/{project_number}/locations/{location_id}/services/{service_id}`.
    /// </remarks>
    public sealed partial class DataprocMetastoreClientImpl : DataprocMetastoreClient
    {
        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> _callCreateService;

        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> _callUpdateService;

        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> _callDeleteService;

        private readonly gaxgrpc::ApiCall<ListMetadataImportsRequest, ListMetadataImportsResponse> _callListMetadataImports;

        private readonly gaxgrpc::ApiCall<GetMetadataImportRequest, MetadataImport> _callGetMetadataImport;

        private readonly gaxgrpc::ApiCall<CreateMetadataImportRequest, lro::Operation> _callCreateMetadataImport;

        private readonly gaxgrpc::ApiCall<UpdateMetadataImportRequest, lro::Operation> _callUpdateMetadataImport;

        private readonly gaxgrpc::ApiCall<ExportMetadataRequest, lro::Operation> _callExportMetadata;

        private readonly gaxgrpc::ApiCall<RestoreServiceRequest, lro::Operation> _callRestoreService;

        private readonly gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> _callListBackups;

        private readonly gaxgrpc::ApiCall<GetBackupRequest, Backup> _callGetBackup;

        private readonly gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> _callCreateBackup;

        private readonly gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> _callDeleteBackup;

        private readonly gaxgrpc::ApiCall<RemoveIamPolicyRequest, RemoveIamPolicyResponse> _callRemoveIamPolicy;

        private readonly gaxgrpc::ApiCall<QueryMetadataRequest, lro::Operation> _callQueryMetadata;

        private readonly gaxgrpc::ApiCall<MoveTableToDatabaseRequest, lro::Operation> _callMoveTableToDatabase;

        private readonly gaxgrpc::ApiCall<AlterMetadataResourceLocationRequest, lro::Operation> _callAlterMetadataResourceLocation;

        /// <summary>
        /// Constructs a client wrapper for the DataprocMetastore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataprocMetastoreSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataprocMetastoreClientImpl(DataprocMetastore.DataprocMetastoreClient grpcClient, DataprocMetastoreSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataprocMetastoreSettings effectiveSettings = settings ?? DataprocMetastoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateServiceOperationsSettings, logger);
            UpdateServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateServiceOperationsSettings, logger);
            DeleteServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteServiceOperationsSettings, logger);
            CreateMetadataImportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMetadataImportOperationsSettings, logger);
            UpdateMetadataImportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMetadataImportOperationsSettings, logger);
            ExportMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportMetadataOperationsSettings, logger);
            RestoreServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreServiceOperationsSettings, logger);
            CreateBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBackupOperationsSettings, logger);
            DeleteBackupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBackupOperationsSettings, logger);
            QueryMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.QueryMetadataOperationsSettings, logger);
            MoveTableToDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MoveTableToDatabaseOperationsSettings, logger);
            AlterMetadataResourceLocationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AlterMetadataResourceLocationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, lro::Operation>("CreateService", grpcClient.CreateServiceAsync, grpcClient.CreateService, effectiveSettings.CreateServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, lro::Operation>("UpdateService", grpcClient.UpdateServiceAsync, grpcClient.UpdateService, effectiveSettings.UpdateServiceSettings).WithGoogleRequestParam("service.name", request => request.Service?.Name);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, lro::Operation>("DeleteService", grpcClient.DeleteServiceAsync, grpcClient.DeleteService, effectiveSettings.DeleteServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            _callListMetadataImports = clientHelper.BuildApiCall<ListMetadataImportsRequest, ListMetadataImportsResponse>("ListMetadataImports", grpcClient.ListMetadataImportsAsync, grpcClient.ListMetadataImports, effectiveSettings.ListMetadataImportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMetadataImports);
            Modify_ListMetadataImportsApiCall(ref _callListMetadataImports);
            _callGetMetadataImport = clientHelper.BuildApiCall<GetMetadataImportRequest, MetadataImport>("GetMetadataImport", grpcClient.GetMetadataImportAsync, grpcClient.GetMetadataImport, effectiveSettings.GetMetadataImportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetadataImport);
            Modify_GetMetadataImportApiCall(ref _callGetMetadataImport);
            _callCreateMetadataImport = clientHelper.BuildApiCall<CreateMetadataImportRequest, lro::Operation>("CreateMetadataImport", grpcClient.CreateMetadataImportAsync, grpcClient.CreateMetadataImport, effectiveSettings.CreateMetadataImportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMetadataImport);
            Modify_CreateMetadataImportApiCall(ref _callCreateMetadataImport);
            _callUpdateMetadataImport = clientHelper.BuildApiCall<UpdateMetadataImportRequest, lro::Operation>("UpdateMetadataImport", grpcClient.UpdateMetadataImportAsync, grpcClient.UpdateMetadataImport, effectiveSettings.UpdateMetadataImportSettings).WithGoogleRequestParam("metadata_import.name", request => request.MetadataImport?.Name);
            Modify_ApiCall(ref _callUpdateMetadataImport);
            Modify_UpdateMetadataImportApiCall(ref _callUpdateMetadataImport);
            _callExportMetadata = clientHelper.BuildApiCall<ExportMetadataRequest, lro::Operation>("ExportMetadata", grpcClient.ExportMetadataAsync, grpcClient.ExportMetadata, effectiveSettings.ExportMetadataSettings).WithGoogleRequestParam("service", request => request.Service);
            Modify_ApiCall(ref _callExportMetadata);
            Modify_ExportMetadataApiCall(ref _callExportMetadata);
            _callRestoreService = clientHelper.BuildApiCall<RestoreServiceRequest, lro::Operation>("RestoreService", grpcClient.RestoreServiceAsync, grpcClient.RestoreService, effectiveSettings.RestoreServiceSettings).WithGoogleRequestParam("service", request => request.Service);
            Modify_ApiCall(ref _callRestoreService);
            Modify_RestoreServiceApiCall(ref _callRestoreService);
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
            _callRemoveIamPolicy = clientHelper.BuildApiCall<RemoveIamPolicyRequest, RemoveIamPolicyResponse>("RemoveIamPolicy", grpcClient.RemoveIamPolicyAsync, grpcClient.RemoveIamPolicy, effectiveSettings.RemoveIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callRemoveIamPolicy);
            Modify_RemoveIamPolicyApiCall(ref _callRemoveIamPolicy);
            _callQueryMetadata = clientHelper.BuildApiCall<QueryMetadataRequest, lro::Operation>("QueryMetadata", grpcClient.QueryMetadataAsync, grpcClient.QueryMetadata, effectiveSettings.QueryMetadataSettings).WithGoogleRequestParam("service", request => request.Service);
            Modify_ApiCall(ref _callQueryMetadata);
            Modify_QueryMetadataApiCall(ref _callQueryMetadata);
            _callMoveTableToDatabase = clientHelper.BuildApiCall<MoveTableToDatabaseRequest, lro::Operation>("MoveTableToDatabase", grpcClient.MoveTableToDatabaseAsync, grpcClient.MoveTableToDatabase, effectiveSettings.MoveTableToDatabaseSettings).WithGoogleRequestParam("service", request => request.Service);
            Modify_ApiCall(ref _callMoveTableToDatabase);
            Modify_MoveTableToDatabaseApiCall(ref _callMoveTableToDatabase);
            _callAlterMetadataResourceLocation = clientHelper.BuildApiCall<AlterMetadataResourceLocationRequest, lro::Operation>("AlterMetadataResourceLocation", grpcClient.AlterMetadataResourceLocationAsync, grpcClient.AlterMetadataResourceLocation, effectiveSettings.AlterMetadataResourceLocationSettings).WithGoogleRequestParam("service", request => request.Service);
            Modify_ApiCall(ref _callAlterMetadataResourceLocation);
            Modify_AlterMetadataResourceLocationApiCall(ref _callAlterMetadataResourceLocation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, lro::Operation> call);

        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, lro::Operation> call);

        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, lro::Operation> call);

        partial void Modify_ListMetadataImportsApiCall(ref gaxgrpc::ApiCall<ListMetadataImportsRequest, ListMetadataImportsResponse> call);

        partial void Modify_GetMetadataImportApiCall(ref gaxgrpc::ApiCall<GetMetadataImportRequest, MetadataImport> call);

        partial void Modify_CreateMetadataImportApiCall(ref gaxgrpc::ApiCall<CreateMetadataImportRequest, lro::Operation> call);

        partial void Modify_UpdateMetadataImportApiCall(ref gaxgrpc::ApiCall<UpdateMetadataImportRequest, lro::Operation> call);

        partial void Modify_ExportMetadataApiCall(ref gaxgrpc::ApiCall<ExportMetadataRequest, lro::Operation> call);

        partial void Modify_RestoreServiceApiCall(ref gaxgrpc::ApiCall<RestoreServiceRequest, lro::Operation> call);

        partial void Modify_ListBackupsApiCall(ref gaxgrpc::ApiCall<ListBackupsRequest, ListBackupsResponse> call);

        partial void Modify_GetBackupApiCall(ref gaxgrpc::ApiCall<GetBackupRequest, Backup> call);

        partial void Modify_CreateBackupApiCall(ref gaxgrpc::ApiCall<CreateBackupRequest, lro::Operation> call);

        partial void Modify_DeleteBackupApiCall(ref gaxgrpc::ApiCall<DeleteBackupRequest, lro::Operation> call);

        partial void Modify_RemoveIamPolicyApiCall(ref gaxgrpc::ApiCall<RemoveIamPolicyRequest, RemoveIamPolicyResponse> call);

        partial void Modify_QueryMetadataApiCall(ref gaxgrpc::ApiCall<QueryMetadataRequest, lro::Operation> call);

        partial void Modify_MoveTableToDatabaseApiCall(ref gaxgrpc::ApiCall<MoveTableToDatabaseRequest, lro::Operation> call);

        partial void Modify_AlterMetadataResourceLocationApiCall(ref gaxgrpc::ApiCall<AlterMetadataResourceLocationRequest, lro::Operation> call);

        partial void OnConstruction(DataprocMetastore.DataprocMetastoreClient grpcClient, DataprocMetastoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataprocMetastore client</summary>
        public override DataprocMetastore.DataprocMetastoreClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMetadataImportsRequest(ref ListMetadataImportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetadataImportRequest(ref GetMetadataImportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMetadataImportRequest(ref CreateMetadataImportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMetadataImportRequest(ref UpdateMetadataImportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportMetadataRequest(ref ExportMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreServiceRequest(ref RestoreServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBackupsRequest(ref ListBackupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBackupRequest(ref GetBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBackupRequest(ref CreateBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBackupRequest(ref DeleteBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveIamPolicyRequest(ref RemoveIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryMetadataRequest(ref QueryMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveTableToDatabaseRequest(ref MoveTableToDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AlterMetadataResourceLocationRequest(ref AlterMetadataResourceLocationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists services in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateService</c>.</summary>
        public override lro::OperationsClient CreateServiceOperationsClient { get; }

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> CreateService(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callCreateService.Sync(request, callSettings), CreateServiceOperationsClient);
        }

        /// <summary>
        /// Creates a metastore service in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> CreateServiceAsync(CreateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callCreateService.Async(request, callSettings).ConfigureAwait(false), CreateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateService</c>.</summary>
        public override lro::OperationsClient UpdateServiceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Service, OperationMetadata> UpdateService(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(_callUpdateService.Sync(request, callSettings), UpdateServiceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Service, OperationMetadata>> UpdateServiceAsync(UpdateServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Service, OperationMetadata>(await _callUpdateService.Async(request, callSettings).ConfigureAwait(false), UpdateServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteService</c>.</summary>
        public override lro::OperationsClient DeleteServiceOperationsClient { get; }

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteService(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteService.Sync(request, callSettings), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Deletes a single service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteServiceAsync(DeleteServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteService.Async(request, callSettings).ConfigureAwait(false), DeleteServiceOperationsClient);
        }

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MetadataImport"/> resources.</returns>
        public override gax::PagedEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImports(ListMetadataImportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataImportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>(_callListMetadataImports, request, callSettings);
        }

        /// <summary>
        /// Lists imports in a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MetadataImport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMetadataImportsResponse, MetadataImport> ListMetadataImportsAsync(ListMetadataImportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetadataImportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMetadataImportsRequest, ListMetadataImportsResponse, MetadataImport>(_callListMetadataImports, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetadataImport GetMetadataImport(GetMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataImportRequest(ref request, ref callSettings);
            return _callGetMetadataImport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single import.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MetadataImport> GetMetadataImportAsync(GetMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataImportRequest(ref request, ref callSettings);
            return _callGetMetadataImport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMetadataImport</c>.</summary>
        public override lro::OperationsClient CreateMetadataImportOperationsClient { get; }

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MetadataImport, OperationMetadata> CreateMetadataImport(CreateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataImportRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataImport, OperationMetadata>(_callCreateMetadataImport.Sync(request, callSettings), CreateMetadataImportOperationsClient);
        }

        /// <summary>
        /// Creates a new MetadataImport in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MetadataImport, OperationMetadata>> CreateMetadataImportAsync(CreateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetadataImportRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataImport, OperationMetadata>(await _callCreateMetadataImport.Async(request, callSettings).ConfigureAwait(false), CreateMetadataImportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMetadataImport</c>.</summary>
        public override lro::OperationsClient UpdateMetadataImportOperationsClient { get; }

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MetadataImport, OperationMetadata> UpdateMetadataImport(UpdateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMetadataImportRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataImport, OperationMetadata>(_callUpdateMetadataImport.Sync(request, callSettings), UpdateMetadataImportOperationsClient);
        }

        /// <summary>
        /// Updates a single import.
        /// Only the description field of MetadataImport is supported to be updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MetadataImport, OperationMetadata>> UpdateMetadataImportAsync(UpdateMetadataImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMetadataImportRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataImport, OperationMetadata>(await _callUpdateMetadataImport.Async(request, callSettings).ConfigureAwait(false), UpdateMetadataImportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportMetadata</c>.</summary>
        public override lro::OperationsClient ExportMetadataOperationsClient { get; }

        /// <summary>
        /// Exports metadata from a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MetadataExport, OperationMetadata> ExportMetadata(ExportMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataExport, OperationMetadata>(_callExportMetadata.Sync(request, callSettings), ExportMetadataOperationsClient);
        }

        /// <summary>
        /// Exports metadata from a service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MetadataExport, OperationMetadata>> ExportMetadataAsync(ExportMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<MetadataExport, OperationMetadata>(await _callExportMetadata.Async(request, callSettings).ConfigureAwait(false), ExportMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreService</c>.</summary>
        public override lro::OperationsClient RestoreServiceOperationsClient { get; }

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Restore, OperationMetadata> RestoreService(RestoreServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(_callRestoreService.Sync(request, callSettings), RestoreServiceOperationsClient);
        }

        /// <summary>
        /// Restores a service from a backup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Restore, OperationMetadata>> RestoreServiceAsync(RestoreServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Restore, OperationMetadata>(await _callRestoreService.Async(request, callSettings).ConfigureAwait(false), RestoreServiceOperationsClient);
        }

        /// <summary>
        /// Lists backups in a service.
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
        /// Lists backups in a service.
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
        /// Gets details of a single backup.
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
        /// Gets details of a single backup.
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
        /// Creates a new backup in a given project and location.
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
        /// Creates a new backup in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Backup, OperationMetadata>> CreateBackupAsync(CreateBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBackupRequest(ref request, ref callSettings);
            return new lro::Operation<Backup, OperationMetadata>(await _callCreateBackup.Async(request, callSettings).ConfigureAwait(false), CreateBackupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBackup</c>.</summary>
        public override lro::OperationsClient DeleteBackupOperationsClient { get; }

        /// <summary>
        /// Deletes a single backup.
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
        /// Deletes a single backup.
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
        /// Removes the attached IAM policies for a resource
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveIamPolicyResponse RemoveIamPolicy(RemoveIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveIamPolicyRequest(ref request, ref callSettings);
            return _callRemoveIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes the attached IAM policies for a resource
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveIamPolicyResponse> RemoveIamPolicyAsync(RemoveIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveIamPolicyRequest(ref request, ref callSettings);
            return _callRemoveIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>QueryMetadata</c>.</summary>
        public override lro::OperationsClient QueryMetadataOperationsClient { get; }

        /// <summary>
        /// Query DPMS metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QueryMetadataResponse, OperationMetadata> QueryMetadata(QueryMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<QueryMetadataResponse, OperationMetadata>(_callQueryMetadata.Sync(request, callSettings), QueryMetadataOperationsClient);
        }

        /// <summary>
        /// Query DPMS metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QueryMetadataResponse, OperationMetadata>> QueryMetadataAsync(QueryMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<QueryMetadataResponse, OperationMetadata>(await _callQueryMetadata.Async(request, callSettings).ConfigureAwait(false), QueryMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MoveTableToDatabase</c>.</summary>
        public override lro::OperationsClient MoveTableToDatabaseOperationsClient { get; }

        /// <summary>
        /// Move a table to another database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MoveTableToDatabaseResponse, OperationMetadata> MoveTableToDatabase(MoveTableToDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveTableToDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>(_callMoveTableToDatabase.Sync(request, callSettings), MoveTableToDatabaseOperationsClient);
        }

        /// <summary>
        /// Move a table to another database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>> MoveTableToDatabaseAsync(MoveTableToDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveTableToDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<MoveTableToDatabaseResponse, OperationMetadata>(await _callMoveTableToDatabase.Async(request, callSettings).ConfigureAwait(false), MoveTableToDatabaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AlterMetadataResourceLocation</c>.</summary>
        public override lro::OperationsClient AlterMetadataResourceLocationOperationsClient { get; }

        /// <summary>
        /// Alter metadata resource location. The metadata resource can be a database,
        /// table, or partition. This functionality only updates the parent directory
        /// for the respective metadata resource and does not transfer any existing
        /// data to the new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata> AlterMetadataResourceLocation(AlterMetadataResourceLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AlterMetadataResourceLocationRequest(ref request, ref callSettings);
            return new lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>(_callAlterMetadataResourceLocation.Sync(request, callSettings), AlterMetadataResourceLocationOperationsClient);
        }

        /// <summary>
        /// Alter metadata resource location. The metadata resource can be a database,
        /// table, or partition. This functionality only updates the parent directory
        /// for the respective metadata resource and does not transfer any existing
        /// data to the new location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>> AlterMetadataResourceLocationAsync(AlterMetadataResourceLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AlterMetadataResourceLocationRequest(ref request, ref callSettings);
            return new lro::Operation<AlterMetadataResourceLocationResponse, OperationMetadata>(await _callAlterMetadataResourceLocation.Async(request, callSettings).ConfigureAwait(false), AlterMetadataResourceLocationOperationsClient);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMetadataImportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBackupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMetadataImportsResponse : gaxgrpc::IPageResponse<MetadataImport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MetadataImport> GetEnumerator() => MetadataImports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBackupsResponse : gaxgrpc::IPageResponse<Backup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Backup> GetEnumerator() => Backups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataprocMetastore
    {
        public partial class DataprocMetastoreClient
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

    public static partial class DataprocMetastore
    {
        public partial class DataprocMetastoreClient
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
