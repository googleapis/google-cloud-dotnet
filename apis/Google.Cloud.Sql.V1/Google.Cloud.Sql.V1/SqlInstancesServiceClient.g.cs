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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Sql.V1
{
    /// <summary>Settings for <see cref="SqlInstancesServiceClient"/> instances.</summary>
    public sealed partial class SqlInstancesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlInstancesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlInstancesServiceSettings"/>.</returns>
        public static SqlInstancesServiceSettings GetDefault() => new SqlInstancesServiceSettings();

        /// <summary>Constructs a new <see cref="SqlInstancesServiceSettings"/> object with default settings.</summary>
        public SqlInstancesServiceSettings()
        {
        }

        private SqlInstancesServiceSettings(SqlInstancesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AddServerCaSettings = existing.AddServerCaSettings;
            AddServerCertificateSettings = existing.AddServerCertificateSettings;
            AddEntraIdCertificateSettings = existing.AddEntraIdCertificateSettings;
            CloneSettings = existing.CloneSettings;
            DeleteSettings = existing.DeleteSettings;
            DemoteMasterSettings = existing.DemoteMasterSettings;
            DemoteSettings = existing.DemoteSettings;
            ExportSettings = existing.ExportSettings;
            FailoverSettings = existing.FailoverSettings;
            ReencryptSettings = existing.ReencryptSettings;
            GetSettings = existing.GetSettings;
            ImportSettings = existing.ImportSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            ListServerCasSettings = existing.ListServerCasSettings;
            ListServerCertificatesSettings = existing.ListServerCertificatesSettings;
            ListEntraIdCertificatesSettings = existing.ListEntraIdCertificatesSettings;
            PatchSettings = existing.PatchSettings;
            PromoteReplicaSettings = existing.PromoteReplicaSettings;
            SwitchoverSettings = existing.SwitchoverSettings;
            ResetSslConfigSettings = existing.ResetSslConfigSettings;
            RestartSettings = existing.RestartSettings;
            StartSettings = existing.StartSettings;
            StopSettings = existing.StopSettings;
            RestoreBackupSettings = existing.RestoreBackupSettings;
            RotateServerCaSettings = existing.RotateServerCaSettings;
            RotateServerCertificateSettings = existing.RotateServerCertificateSettings;
            RotateEntraIdCertificateSettings = existing.RotateEntraIdCertificateSettings;
            StartReplicaSettings = existing.StartReplicaSettings;
            StopReplicaSettings = existing.StopReplicaSettings;
            TruncateLogSettings = existing.TruncateLogSettings;
            UpdateSettings = existing.UpdateSettings;
            CreateEphemeralSettings = existing.CreateEphemeralSettings;
            RescheduleMaintenanceSettings = existing.RescheduleMaintenanceSettings;
            VerifyExternalSyncSettingsSettings = existing.VerifyExternalSyncSettingsSettings;
            StartExternalSyncSettings = existing.StartExternalSyncSettings;
            PerformDiskShrinkSettings = existing.PerformDiskShrinkSettings;
            GetDiskShrinkConfigSettings = existing.GetDiskShrinkConfigSettings;
            ResetReplicaSizeSettings = existing.ResetReplicaSizeSettings;
            GetLatestRecoveryTimeSettings = existing.GetLatestRecoveryTimeSettings;
            ExecuteSqlReadOnlySettings = existing.ExecuteSqlReadOnlySettings;
            ExecuteSqlSettings = existing.ExecuteSqlSettings;
            AcquireSsrsLeaseSettings = existing.AcquireSsrsLeaseSettings;
            ReleaseSsrsLeaseSettings = existing.ReleaseSsrsLeaseSettings;
            PreCheckMajorVersionUpgradeSettings = existing.PreCheckMajorVersionUpgradeSettings;
            PointInTimeRestoreSettings = existing.PointInTimeRestoreSettings;
            ReconcileNetworkingSettings = existing.ReconcileNetworkingSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlInstancesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.AddServerCa</c> and <c>SqlInstancesServiceClient.AddServerCaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddServerCaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.AddServerCertificate</c> and
        /// <c>SqlInstancesServiceClient.AddServerCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddServerCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.AddEntraIdCertificate</c> and
        /// <c>SqlInstancesServiceClient.AddEntraIdCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddEntraIdCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Clone</c> and <c>SqlInstancesServiceClient.CloneAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloneSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Delete</c> and <c>SqlInstancesServiceClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.DemoteMaster</c> and <c>SqlInstancesServiceClient.DemoteMasterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DemoteMasterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Demote</c> and <c>SqlInstancesServiceClient.DemoteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DemoteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Export</c> and <c>SqlInstancesServiceClient.ExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Failover</c> and <c>SqlInstancesServiceClient.FailoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Reencrypt</c> and <c>SqlInstancesServiceClient.ReencryptAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReencryptSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Get</c> and <c>SqlInstancesServiceClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Import</c> and <c>SqlInstancesServiceClient.ImportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Insert</c> and <c>SqlInstancesServiceClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.List</c> and <c>SqlInstancesServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ListServerCas</c> and <c>SqlInstancesServiceClient.ListServerCasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServerCasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ListServerCertificates</c> and
        /// <c>SqlInstancesServiceClient.ListServerCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServerCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ListEntraIdCertificates</c> and
        /// <c>SqlInstancesServiceClient.ListEntraIdCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntraIdCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Patch</c> and <c>SqlInstancesServiceClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.PromoteReplica</c> and <c>SqlInstancesServiceClient.PromoteReplicaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PromoteReplicaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Switchover</c> and <c>SqlInstancesServiceClient.SwitchoverAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchoverSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ResetSslConfig</c> and <c>SqlInstancesServiceClient.ResetSslConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetSslConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Restart</c> and <c>SqlInstancesServiceClient.RestartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Start</c> and <c>SqlInstancesServiceClient.StartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Stop</c> and <c>SqlInstancesServiceClient.StopAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.RestoreBackup</c> and <c>SqlInstancesServiceClient.RestoreBackupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreBackupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.RotateServerCa</c> and <c>SqlInstancesServiceClient.RotateServerCaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RotateServerCaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.RotateServerCertificate</c> and
        /// <c>SqlInstancesServiceClient.RotateServerCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RotateServerCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.RotateEntraIdCertificate</c> and
        /// <c>SqlInstancesServiceClient.RotateEntraIdCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RotateEntraIdCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.StartReplica</c> and <c>SqlInstancesServiceClient.StartReplicaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartReplicaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.StopReplica</c> and <c>SqlInstancesServiceClient.StopReplicaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopReplicaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.TruncateLog</c> and <c>SqlInstancesServiceClient.TruncateLogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TruncateLogSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.Update</c> and <c>SqlInstancesServiceClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.CreateEphemeral</c> and <c>SqlInstancesServiceClient.CreateEphemeralAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEphemeralSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.RescheduleMaintenance</c> and
        /// <c>SqlInstancesServiceClient.RescheduleMaintenanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RescheduleMaintenanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.VerifyExternalSyncSettings</c> and
        /// <c>SqlInstancesServiceClient.VerifyExternalSyncSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyExternalSyncSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.StartExternalSync</c> and <c>SqlInstancesServiceClient.StartExternalSyncAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartExternalSyncSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.PerformDiskShrink</c> and <c>SqlInstancesServiceClient.PerformDiskShrinkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PerformDiskShrinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.GetDiskShrinkConfig</c> and
        /// <c>SqlInstancesServiceClient.GetDiskShrinkConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiskShrinkConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ResetReplicaSize</c> and <c>SqlInstancesServiceClient.ResetReplicaSizeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetReplicaSizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.GetLatestRecoveryTime</c> and
        /// <c>SqlInstancesServiceClient.GetLatestRecoveryTimeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLatestRecoveryTimeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ExecuteSqlReadOnly</c> and <c>SqlInstancesServiceClient.ExecuteSqlReadOnlyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteSqlReadOnlySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ExecuteSql</c> and <c>SqlInstancesServiceClient.ExecuteSqlAsync</c>.
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
        /// <c>SqlInstancesServiceClient.AcquireSsrsLease</c> and <c>SqlInstancesServiceClient.AcquireSsrsLeaseAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AcquireSsrsLeaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ReleaseSsrsLease</c> and <c>SqlInstancesServiceClient.ReleaseSsrsLeaseAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReleaseSsrsLeaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.PreCheckMajorVersionUpgrade</c> and
        /// <c>SqlInstancesServiceClient.PreCheckMajorVersionUpgradeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreCheckMajorVersionUpgradeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.PointInTimeRestore</c> and <c>SqlInstancesServiceClient.PointInTimeRestoreAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PointInTimeRestoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlInstancesServiceClient.ReconcileNetworking</c> and
        /// <c>SqlInstancesServiceClient.ReconcileNetworkingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReconcileNetworkingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlInstancesServiceSettings"/> object.</returns>
        public SqlInstancesServiceSettings Clone() => new SqlInstancesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlInstancesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SqlInstancesServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlInstancesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlInstancesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlInstancesServiceClientBuilder() : base(SqlInstancesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlInstancesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlInstancesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlInstancesServiceClient Build()
        {
            SqlInstancesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlInstancesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlInstancesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlInstancesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlInstancesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlInstancesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlInstancesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlInstancesServiceClient.ChannelPool;
    }

    /// <summary>SqlInstancesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlInstancesServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlInstancesService service, which is a host of "sqladmin.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlInstancesService scopes.</summary>
        /// <remarks>
        /// The default SqlInstancesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/sqlservice.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/sqlservice.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlInstancesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlInstancesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SqlInstancesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlInstancesServiceClient"/>.</returns>
        public static stt::Task<SqlInstancesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlInstancesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlInstancesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SqlInstancesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlInstancesServiceClient"/>.</returns>
        public static SqlInstancesServiceClient Create() => new SqlInstancesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlInstancesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlInstancesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlInstancesServiceClient"/>.</returns>
        internal static SqlInstancesServiceClient Create(grpccore::CallInvoker callInvoker, SqlInstancesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlInstancesService.SqlInstancesServiceClient grpcClient = new SqlInstancesService.SqlInstancesServiceClient(callInvoker);
            return new SqlInstancesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlInstancesService client</summary>
        public virtual SqlInstancesService.SqlInstancesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new trusted Certificate Authority (CA) version for the specified
        /// instance. Required to prepare for a certificate rotation. If a CA version
        /// was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version
        /// waiting to be rotated in. For instances that have enabled Certificate
        /// Authority Service (CAS) based server CA, use AddServerCertificate to add a
        /// new server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddServerCa(SqlInstancesAddServerCaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new trusted Certificate Authority (CA) version for the specified
        /// instance. Required to prepare for a certificate rotation. If a CA version
        /// was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version
        /// waiting to be rotated in. For instances that have enabled Certificate
        /// Authority Service (CAS) based server CA, use AddServerCertificate to add a
        /// new server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddServerCaAsync(SqlInstancesAddServerCaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new trusted Certificate Authority (CA) version for the specified
        /// instance. Required to prepare for a certificate rotation. If a CA version
        /// was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version
        /// waiting to be rotated in. For instances that have enabled Certificate
        /// Authority Service (CAS) based server CA, use AddServerCertificate to add a
        /// new server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddServerCaAsync(SqlInstancesAddServerCaRequest request, st::CancellationToken cancellationToken) =>
            AddServerCaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance
        /// using Certificate Authority Service (CAS) server CA. Required to prepare
        /// for a certificate rotation. If a server certificate version was previously
        /// added but never used in a certificate rotation, this operation replaces
        /// that version. There cannot be more than one certificate version waiting to
        /// be rotated in. For instances not using CAS server CA, use AddServerCa
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddServerCertificate(SqlInstancesAddServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance
        /// using Certificate Authority Service (CAS) server CA. Required to prepare
        /// for a certificate rotation. If a server certificate version was previously
        /// added but never used in a certificate rotation, this operation replaces
        /// that version. There cannot be more than one certificate version waiting to
        /// be rotated in. For instances not using CAS server CA, use AddServerCa
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddServerCertificateAsync(SqlInstancesAddServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance
        /// using Certificate Authority Service (CAS) server CA. Required to prepare
        /// for a certificate rotation. If a server certificate version was previously
        /// added but never used in a certificate rotation, this operation replaces
        /// that version. There cannot be more than one certificate version waiting to
        /// be rotated in. For instances not using CAS server CA, use AddServerCa
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddServerCertificateAsync(SqlInstancesAddServerCertificateRequest request, st::CancellationToken cancellationToken) =>
            AddServerCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a new Entra ID certificate for the specified instance. If an Entra ID
        /// certificate was previously added but never used in a certificate rotation,
        /// this operation replaces that version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation AddEntraIdCertificate(SqlInstancesAddEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Entra ID certificate for the specified instance. If an Entra ID
        /// certificate was previously added but never used in a certificate rotation,
        /// this operation replaces that version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddEntraIdCertificateAsync(SqlInstancesAddEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a new Entra ID certificate for the specified instance. If an Entra ID
        /// certificate was previously added but never used in a certificate rotation,
        /// this operation replaces that version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> AddEntraIdCertificateAsync(SqlInstancesAddEntraIdCertificateRequest request, st::CancellationToken cancellationToken) =>
            AddEntraIdCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this
        /// operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Clone(SqlInstancesCloneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this
        /// operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneAsync(SqlInstancesCloneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this
        /// operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CloneAsync(SqlInstancesCloneRequest request, st::CancellationToken cancellationToken) =>
            CloneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(SqlInstancesDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlInstancesDeleteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(SqlInstancesDeleteRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an
        /// external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DemoteMaster(SqlInstancesDemoteMasterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an
        /// external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DemoteMasterAsync(SqlInstancesDemoteMasterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an
        /// external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DemoteMasterAsync(SqlInstancesDemoteMasterRequest request, st::CancellationToken cancellationToken) =>
            DemoteMasterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica
        /// for an external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Demote(SqlInstancesDemoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica
        /// for an external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DemoteAsync(SqlInstancesDemoteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica
        /// for an external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DemoteAsync(SqlInstancesDemoteRequest request, st::CancellationToken cancellationToken) =>
            DemoteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL
        /// dump or CSV file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Export(SqlInstancesExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL
        /// dump or CSV file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ExportAsync(SqlInstancesExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL
        /// dump or CSV file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ExportAsync(SqlInstancesExportRequest request, st::CancellationToken cancellationToken) =>
            ExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance
        /// to a standby instance, which becomes the primary instance. Users are
        /// then rerouted to the new primary. For more information, see the
        /// [Overview of high
        /// availability](https://cloud.google.com/sql/docs/mysql/high-availability)
        /// page in the Cloud SQL documentation.
        /// If using Legacy HA (MySQL only), this causes the instance to failover to
        /// its failover replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Failover(SqlInstancesFailoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance
        /// to a standby instance, which becomes the primary instance. Users are
        /// then rerouted to the new primary. For more information, see the
        /// [Overview of high
        /// availability](https://cloud.google.com/sql/docs/mysql/high-availability)
        /// page in the Cloud SQL documentation.
        /// If using Legacy HA (MySQL only), this causes the instance to failover to
        /// its failover replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> FailoverAsync(SqlInstancesFailoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance
        /// to a standby instance, which becomes the primary instance. Users are
        /// then rerouted to the new primary. For more information, see the
        /// [Overview of high
        /// availability](https://cloud.google.com/sql/docs/mysql/high-availability)
        /// page in the Cloud SQL documentation.
        /// If using Legacy HA (MySQL only), this causes the instance to failover to
        /// its failover replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> FailoverAsync(SqlInstancesFailoverRequest request, st::CancellationToken cancellationToken) =>
            FailoverAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reencrypt CMEK instance with latest key version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Reencrypt(SqlInstancesReencryptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reencrypt CMEK instance with latest key version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ReencryptAsync(SqlInstancesReencryptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reencrypt CMEK instance with latest key version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ReencryptAsync(SqlInstancesReencryptRequest request, st::CancellationToken cancellationToken) =>
            ReencryptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatabaseInstance Get(SqlInstancesGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatabaseInstance> GetAsync(SqlInstancesGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatabaseInstance> GetAsync(SqlInstancesGetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into a Cloud SQL instance from a SQL dump  or CSV file in
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Import(SqlInstancesImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a Cloud SQL instance from a SQL dump  or CSV file in
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ImportAsync(SqlInstancesImportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a Cloud SQL instance from a SQL dump  or CSV file in
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ImportAsync(SqlInstancesImportRequest request, st::CancellationToken cancellationToken) =>
            ImportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(SqlInstancesInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(SqlInstancesInsertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(SqlInstancesInsertRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists instances under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiWarning"/> resources.</returns>
        public virtual gax::PagedEnumerable<InstancesListResponse, ApiWarning> List(SqlInstancesListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiWarning"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<InstancesListResponse, ApiWarning> ListAsync(SqlInstancesListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified
        /// instance. There can be up to three CAs listed: the CA that was used to sign
        /// the certificate that is currently in use, a CA that has been added but not
        /// yet used to sign a certificate, and a CA used to sign a certificate that
        /// has previously rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancesListServerCasResponse ListServerCas(SqlInstancesListServerCasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified
        /// instance. There can be up to three CAs listed: the CA that was used to sign
        /// the certificate that is currently in use, a CA that has been added but not
        /// yet used to sign a certificate, and a CA used to sign a certificate that
        /// has previously rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListServerCasResponse> ListServerCasAsync(SqlInstancesListServerCasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified
        /// instance. There can be up to three CAs listed: the CA that was used to sign
        /// the certificate that is currently in use, a CA that has been added but not
        /// yet used to sign a certificate, and a CA used to sign a certificate that
        /// has previously rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListServerCasResponse> ListServerCasAsync(SqlInstancesListServerCasRequest request, st::CancellationToken cancellationToken) =>
            ListServerCasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs)
        /// for the specified instance. There can be up to three sets of certs listed:
        /// the certificate that is currently in use, a future that has been added but
        /// not yet used to sign a certificate, and a certificate that has been rotated
        /// out. For instances not using Certificate Authority Service (CAS) server CA,
        /// use ListServerCas instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancesListServerCertificatesResponse ListServerCertificates(SqlInstancesListServerCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs)
        /// for the specified instance. There can be up to three sets of certs listed:
        /// the certificate that is currently in use, a future that has been added but
        /// not yet used to sign a certificate, and a certificate that has been rotated
        /// out. For instances not using Certificate Authority Service (CAS) server CA,
        /// use ListServerCas instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListServerCertificatesResponse> ListServerCertificatesAsync(SqlInstancesListServerCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs)
        /// for the specified instance. There can be up to three sets of certs listed:
        /// the certificate that is currently in use, a future that has been added but
        /// not yet used to sign a certificate, and a certificate that has been rotated
        /// out. For instances not using Certificate Authority Service (CAS) server CA,
        /// use ListServerCas instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListServerCertificatesResponse> ListServerCertificatesAsync(SqlInstancesListServerCertificatesRequest request, st::CancellationToken cancellationToken) =>
            ListServerCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all versions of EntraID certificates for the specified instance.
        /// There can be up to three sets of certificates listed: the certificate that
        /// is currently in use, a future that has been added but not yet used to sign
        /// a certificate, and a certificate that has been rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstancesListEntraIdCertificatesResponse ListEntraIdCertificates(SqlInstancesListEntraIdCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of EntraID certificates for the specified instance.
        /// There can be up to three sets of certificates listed: the certificate that
        /// is currently in use, a future that has been added but not yet used to sign
        /// a certificate, and a certificate that has been rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListEntraIdCertificatesResponse> ListEntraIdCertificatesAsync(SqlInstancesListEntraIdCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of EntraID certificates for the specified instance.
        /// There can be up to three sets of certificates listed: the certificate that
        /// is currently in use, a future that has been added but not yet used to sign
        /// a certificate, and a certificate that has been rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstancesListEntraIdCertificatesResponse> ListEntraIdCertificatesAsync(SqlInstancesListEntraIdCertificatesRequest request, st::CancellationToken cancellationToken) =>
            ListEntraIdCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request
        /// with the current configuration. This method supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(SqlInstancesPatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request
        /// with the current configuration. This method supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(SqlInstancesPatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request
        /// with the current configuration. This method supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(SqlInstancesPatchRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL
        /// primary instance.
        /// Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PromoteReplica(SqlInstancesPromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL
        /// primary instance.
        /// Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PromoteReplicaAsync(SqlInstancesPromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL
        /// primary instance.
        /// Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PromoteReplicaAsync(SqlInstancesPromoteReplicaRequest request, st::CancellationToken cancellationToken) =>
            PromoteReplicaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches over from the primary instance to the DR replica
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Switchover(SqlInstancesSwitchoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches over from the primary instance to the DR replica
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverAsync(SqlInstancesSwitchoverRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches over from the primary instance to the DR replica
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverAsync(SqlInstancesSwitchoverRequest request, st::CancellationToken cancellationToken) =>
            SwitchoverAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate
        /// for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation ResetSslConfig(SqlInstancesResetSslConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate
        /// for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetSslConfigAsync(SqlInstancesResetSslConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate
        /// for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetSslConfigAsync(SqlInstancesResetSslConfigRequest request, st::CancellationToken cancellationToken) =>
            ResetSslConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Restart(SqlInstancesRestartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RestartAsync(SqlInstancesRestartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RestartAsync(SqlInstancesRestartRequest request, st::CancellationToken cancellationToken) =>
            RestartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Start(SqlInstancesStartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(SqlInstancesStartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartAsync(SqlInstancesStartRequest request, st::CancellationToken cancellationToken) =>
            StartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Stop(SqlInstancesStopRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(SqlInstancesStopRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopAsync(SqlInstancesStopRequest request, st::CancellationToken cancellationToken) =>
            StopAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RestoreBackup(SqlInstancesRestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RestoreBackupAsync(SqlInstancesRestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RestoreBackupAsync(SqlInstancesRestoreBackupRequest request, st::CancellationToken cancellationToken) =>
            RestoreBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority
        /// (CA) version previously added with the addServerCA method. For instances
        /// that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RotateServerCa(SqlInstancesRotateServerCaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority
        /// (CA) version previously added with the addServerCA method. For instances
        /// that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateServerCaAsync(SqlInstancesRotateServerCaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority
        /// (CA) version previously added with the addServerCA method. For instances
        /// that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateServerCaAsync(SqlInstancesRotateServerCaRequest request, st::CancellationToken cancellationToken) =>
            RotateServerCaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addServerCertificate method. For instances not using Certificate Authority
        /// Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RotateServerCertificate(SqlInstancesRotateServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addServerCertificate method. For instances not using Certificate Authority
        /// Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateServerCertificateAsync(SqlInstancesRotateServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addServerCertificate method. For instances not using Certificate Authority
        /// Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateServerCertificateAsync(SqlInstancesRotateServerCertificateRequest request, st::CancellationToken cancellationToken) =>
            RotateServerCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addEntraIdCertificate method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RotateEntraIdCertificate(SqlInstancesRotateEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addEntraIdCertificate method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateEntraIdCertificateAsync(SqlInstancesRotateEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addEntraIdCertificate method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RotateEntraIdCertificateAsync(SqlInstancesRotateEntraIdCertificateRequest request, st::CancellationToken cancellationToken) =>
            RotateEntraIdCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartReplica(SqlInstancesStartReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartReplicaAsync(SqlInstancesStartReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartReplicaAsync(SqlInstancesStartReplicaRequest request, st::CancellationToken cancellationToken) =>
            StartReplicaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StopReplica(SqlInstancesStopReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopReplicaAsync(SqlInstancesStopReplicaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StopReplicaAsync(SqlInstancesStopReplicaRequest request, st::CancellationToken cancellationToken) =>
            StopReplicaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Truncate MySQL general and slow query log tables
        /// MySQL only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation TruncateLog(SqlInstancesTruncateLogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Truncate MySQL general and slow query log tables
        /// MySQL only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> TruncateLogAsync(SqlInstancesTruncateLogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Truncate MySQL general and slow query log tables
        /// MySQL only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> TruncateLogAsync(SqlInstancesTruncateLogRequest request, st::CancellationToken cancellationToken) =>
            TruncateLogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(SqlInstancesUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(SqlInstancesUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(SqlInstancesUpdateRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SslCert CreateEphemeral(SqlInstancesCreateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCert> CreateEphemeralAsync(SqlInstancesCreateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SslCert> CreateEphemeralAsync(SqlInstancesCreateEphemeralCertRequest request, st::CancellationToken cancellationToken) =>
            CreateEphemeralAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reschedules the maintenance on the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation RescheduleMaintenance(SqlInstancesRescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules the maintenance on the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RescheduleMaintenanceAsync(SqlInstancesRescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reschedules the maintenance on the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> RescheduleMaintenanceAsync(SqlInstancesRescheduleMaintenanceRequest request, st::CancellationToken cancellationToken) =>
            RescheduleMaintenanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verify External primary instance external sync settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesVerifyExternalSyncSettingsResponse VerifyExternalSyncSettings(SqlInstancesVerifyExternalSyncSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify External primary instance external sync settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesVerifyExternalSyncSettingsResponse> VerifyExternalSyncSettingsAsync(SqlInstancesVerifyExternalSyncSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verify External primary instance external sync settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesVerifyExternalSyncSettingsResponse> VerifyExternalSyncSettingsAsync(SqlInstancesVerifyExternalSyncSettingsRequest request, st::CancellationToken cancellationToken) =>
            VerifyExternalSyncSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start External primary instance migration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation StartExternalSync(SqlInstancesStartExternalSyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start External primary instance migration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartExternalSyncAsync(SqlInstancesStartExternalSyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start External primary instance migration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> StartExternalSyncAsync(SqlInstancesStartExternalSyncRequest request, st::CancellationToken cancellationToken) =>
            StartExternalSyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform Disk Shrink on primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PerformDiskShrink(SqlInstancesPerformDiskShrinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform Disk Shrink on primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PerformDiskShrinkAsync(SqlInstancesPerformDiskShrinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform Disk Shrink on primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PerformDiskShrinkAsync(SqlInstancesPerformDiskShrinkRequest request, st::CancellationToken cancellationToken) =>
            PerformDiskShrinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Disk Shrink Config for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesGetDiskShrinkConfigResponse GetDiskShrinkConfig(SqlInstancesGetDiskShrinkConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Disk Shrink Config for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesGetDiskShrinkConfigResponse> GetDiskShrinkConfigAsync(SqlInstancesGetDiskShrinkConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Disk Shrink Config for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesGetDiskShrinkConfigResponse> GetDiskShrinkConfigAsync(SqlInstancesGetDiskShrinkConfigRequest request, st::CancellationToken cancellationToken) =>
            GetDiskShrinkConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reset Replica Size to primary instance disk size.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation ResetReplicaSize(SqlInstancesResetReplicaSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset Replica Size to primary instance disk size.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetReplicaSizeAsync(SqlInstancesResetReplicaSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset Replica Size to primary instance disk size.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ResetReplicaSizeAsync(SqlInstancesResetReplicaSizeRequest request, st::CancellationToken cancellationToken) =>
            ResetReplicaSizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Latest Recovery Time for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesGetLatestRecoveryTimeResponse GetLatestRecoveryTime(SqlInstancesGetLatestRecoveryTimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Latest Recovery Time for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesGetLatestRecoveryTimeResponse> GetLatestRecoveryTimeAsync(SqlInstancesGetLatestRecoveryTimeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Latest Recovery Time for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesGetLatestRecoveryTimeResponse> GetLatestRecoveryTimeAsync(SqlInstancesGetLatestRecoveryTimeRequest request, st::CancellationToken cancellationToken) =>
            GetLatestRecoveryTimeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute SQL statements in read-only mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesExecuteSqlReadOnlyResponse ExecuteSqlReadOnly(SqlInstancesExecuteSqlReadOnlyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute SQL statements in read-only mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesExecuteSqlReadOnlyResponse> ExecuteSqlReadOnlyAsync(SqlInstancesExecuteSqlReadOnlyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute SQL statements in read-only mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesExecuteSqlReadOnlyResponse> ExecuteSqlReadOnlyAsync(SqlInstancesExecuteSqlReadOnlyRequest request, st::CancellationToken cancellationToken) =>
            ExecuteSqlReadOnlyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute SQL statements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesExecuteSqlResponse ExecuteSql(SqlInstancesExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute SQL statements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesExecuteSqlResponse> ExecuteSqlAsync(SqlInstancesExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute SQL statements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesExecuteSqlResponse> ExecuteSqlAsync(SqlInstancesExecuteSqlRequest request, st::CancellationToken cancellationToken) =>
            ExecuteSqlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Acquire a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesAcquireSsrsLeaseResponse AcquireSsrsLease(SqlInstancesAcquireSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acquire a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesAcquireSsrsLeaseResponse> AcquireSsrsLeaseAsync(SqlInstancesAcquireSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Acquire a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesAcquireSsrsLeaseResponse> AcquireSsrsLeaseAsync(SqlInstancesAcquireSsrsLeaseRequest request, st::CancellationToken cancellationToken) =>
            AcquireSsrsLeaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Release a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SqlInstancesReleaseSsrsLeaseResponse ReleaseSsrsLease(SqlInstancesReleaseSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Release a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesReleaseSsrsLeaseResponse> ReleaseSsrsLeaseAsync(SqlInstancesReleaseSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Release a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SqlInstancesReleaseSsrsLeaseResponse> ReleaseSsrsLeaseAsync(SqlInstancesReleaseSsrsLeaseRequest request, st::CancellationToken cancellationToken) =>
            ReleaseSsrsLeaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute MVU Pre-checks
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PreCheckMajorVersionUpgrade(SqlInstancesPreCheckMajorVersionUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute MVU Pre-checks
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PreCheckMajorVersionUpgradeAsync(SqlInstancesPreCheckMajorVersionUpgradeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute MVU Pre-checks
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PreCheckMajorVersionUpgradeAsync(SqlInstancesPreCheckMajorVersionUpgradeRequest request, st::CancellationToken cancellationToken) =>
            PreCheckMajorVersionUpgradeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and
        /// Disaster Recovery.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation PointInTimeRestore(SqlInstancesPointInTimeRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and
        /// Disaster Recovery.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PointInTimeRestoreAsync(SqlInstancesPointInTimeRestoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and
        /// Disaster Recovery.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PointInTimeRestoreAsync(SqlInstancesPointInTimeRestoreRequest request, st::CancellationToken cancellationToken) =>
            PointInTimeRestoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Repairs and recreates networking resources for a Cloud SQL instance. For
        /// Private Service Connect (PSC), this operation recreates PSC DNS write
        /// endpoints on specified VPC networks and reconciles Private Service Connect
        /// connectivity infrastructure for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation ReconcileNetworking(SqlInstancesReconcileNetworkingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Repairs and recreates networking resources for a Cloud SQL instance. For
        /// Private Service Connect (PSC), this operation recreates PSC DNS write
        /// endpoints on specified VPC networks and reconciles Private Service Connect
        /// connectivity infrastructure for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ReconcileNetworkingAsync(SqlInstancesReconcileNetworkingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Repairs and recreates networking resources for a Cloud SQL instance. For
        /// Private Service Connect (PSC), this operation recreates PSC DNS write
        /// endpoints on specified VPC networks and reconciles Private Service Connect
        /// connectivity infrastructure for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> ReconcileNetworkingAsync(SqlInstancesReconcileNetworkingRequest request, st::CancellationToken cancellationToken) =>
            ReconcileNetworkingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SqlInstancesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlInstancesServiceClientImpl : SqlInstancesServiceClient
    {
        private readonly gaxgrpc::ApiCall<SqlInstancesAddServerCaRequest, Operation> _callAddServerCa;

        private readonly gaxgrpc::ApiCall<SqlInstancesAddServerCertificateRequest, Operation> _callAddServerCertificate;

        private readonly gaxgrpc::ApiCall<SqlInstancesAddEntraIdCertificateRequest, Operation> _callAddEntraIdCertificate;

        private readonly gaxgrpc::ApiCall<SqlInstancesCloneRequest, Operation> _callClone;

        private readonly gaxgrpc::ApiCall<SqlInstancesDeleteRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<SqlInstancesDemoteMasterRequest, Operation> _callDemoteMaster;

        private readonly gaxgrpc::ApiCall<SqlInstancesDemoteRequest, Operation> _callDemote;

        private readonly gaxgrpc::ApiCall<SqlInstancesExportRequest, Operation> _callExport;

        private readonly gaxgrpc::ApiCall<SqlInstancesFailoverRequest, Operation> _callFailover;

        private readonly gaxgrpc::ApiCall<SqlInstancesReencryptRequest, Operation> _callReencrypt;

        private readonly gaxgrpc::ApiCall<SqlInstancesGetRequest, DatabaseInstance> _callGet;

        private readonly gaxgrpc::ApiCall<SqlInstancesImportRequest, Operation> _callImport;

        private readonly gaxgrpc::ApiCall<SqlInstancesInsertRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<SqlInstancesListRequest, InstancesListResponse> _callList;

        private readonly gaxgrpc::ApiCall<SqlInstancesListServerCasRequest, InstancesListServerCasResponse> _callListServerCas;

        private readonly gaxgrpc::ApiCall<SqlInstancesListServerCertificatesRequest, InstancesListServerCertificatesResponse> _callListServerCertificates;

        private readonly gaxgrpc::ApiCall<SqlInstancesListEntraIdCertificatesRequest, InstancesListEntraIdCertificatesResponse> _callListEntraIdCertificates;

        private readonly gaxgrpc::ApiCall<SqlInstancesPatchRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<SqlInstancesPromoteReplicaRequest, Operation> _callPromoteReplica;

        private readonly gaxgrpc::ApiCall<SqlInstancesSwitchoverRequest, Operation> _callSwitchover;

        private readonly gaxgrpc::ApiCall<SqlInstancesResetSslConfigRequest, Operation> _callResetSslConfig;

        private readonly gaxgrpc::ApiCall<SqlInstancesRestartRequest, Operation> _callRestart;

        private readonly gaxgrpc::ApiCall<SqlInstancesStartRequest, Operation> _callStart;

        private readonly gaxgrpc::ApiCall<SqlInstancesStopRequest, Operation> _callStop;

        private readonly gaxgrpc::ApiCall<SqlInstancesRestoreBackupRequest, Operation> _callRestoreBackup;

        private readonly gaxgrpc::ApiCall<SqlInstancesRotateServerCaRequest, Operation> _callRotateServerCa;

        private readonly gaxgrpc::ApiCall<SqlInstancesRotateServerCertificateRequest, Operation> _callRotateServerCertificate;

        private readonly gaxgrpc::ApiCall<SqlInstancesRotateEntraIdCertificateRequest, Operation> _callRotateEntraIdCertificate;

        private readonly gaxgrpc::ApiCall<SqlInstancesStartReplicaRequest, Operation> _callStartReplica;

        private readonly gaxgrpc::ApiCall<SqlInstancesStopReplicaRequest, Operation> _callStopReplica;

        private readonly gaxgrpc::ApiCall<SqlInstancesTruncateLogRequest, Operation> _callTruncateLog;

        private readonly gaxgrpc::ApiCall<SqlInstancesUpdateRequest, Operation> _callUpdate;

        private readonly gaxgrpc::ApiCall<SqlInstancesCreateEphemeralCertRequest, SslCert> _callCreateEphemeral;

        private readonly gaxgrpc::ApiCall<SqlInstancesRescheduleMaintenanceRequest, Operation> _callRescheduleMaintenance;

        private readonly gaxgrpc::ApiCall<SqlInstancesVerifyExternalSyncSettingsRequest, SqlInstancesVerifyExternalSyncSettingsResponse> _callVerifyExternalSyncSettings;

        private readonly gaxgrpc::ApiCall<SqlInstancesStartExternalSyncRequest, Operation> _callStartExternalSync;

        private readonly gaxgrpc::ApiCall<SqlInstancesPerformDiskShrinkRequest, Operation> _callPerformDiskShrink;

        private readonly gaxgrpc::ApiCall<SqlInstancesGetDiskShrinkConfigRequest, SqlInstancesGetDiskShrinkConfigResponse> _callGetDiskShrinkConfig;

        private readonly gaxgrpc::ApiCall<SqlInstancesResetReplicaSizeRequest, Operation> _callResetReplicaSize;

        private readonly gaxgrpc::ApiCall<SqlInstancesGetLatestRecoveryTimeRequest, SqlInstancesGetLatestRecoveryTimeResponse> _callGetLatestRecoveryTime;

        private readonly gaxgrpc::ApiCall<SqlInstancesExecuteSqlReadOnlyRequest, SqlInstancesExecuteSqlReadOnlyResponse> _callExecuteSqlReadOnly;

        private readonly gaxgrpc::ApiCall<SqlInstancesExecuteSqlRequest, SqlInstancesExecuteSqlResponse> _callExecuteSql;

        private readonly gaxgrpc::ApiCall<SqlInstancesAcquireSsrsLeaseRequest, SqlInstancesAcquireSsrsLeaseResponse> _callAcquireSsrsLease;

        private readonly gaxgrpc::ApiCall<SqlInstancesReleaseSsrsLeaseRequest, SqlInstancesReleaseSsrsLeaseResponse> _callReleaseSsrsLease;

        private readonly gaxgrpc::ApiCall<SqlInstancesPreCheckMajorVersionUpgradeRequest, Operation> _callPreCheckMajorVersionUpgrade;

        private readonly gaxgrpc::ApiCall<SqlInstancesPointInTimeRestoreRequest, Operation> _callPointInTimeRestore;

        private readonly gaxgrpc::ApiCall<SqlInstancesReconcileNetworkingRequest, Operation> _callReconcileNetworking;

        /// <summary>
        /// Constructs a client wrapper for the SqlInstancesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlInstancesServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlInstancesServiceClientImpl(SqlInstancesService.SqlInstancesServiceClient grpcClient, SqlInstancesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlInstancesServiceSettings effectiveSettings = settings ?? SqlInstancesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callAddServerCa = clientHelper.BuildApiCall<SqlInstancesAddServerCaRequest, Operation>("AddServerCa", grpcClient.AddServerCaAsync, grpcClient.AddServerCa, effectiveSettings.AddServerCaSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddServerCa);
            Modify_AddServerCaApiCall(ref _callAddServerCa);
            _callAddServerCertificate = clientHelper.BuildApiCall<SqlInstancesAddServerCertificateRequest, Operation>("AddServerCertificate", grpcClient.AddServerCertificateAsync, grpcClient.AddServerCertificate, effectiveSettings.AddServerCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddServerCertificate);
            Modify_AddServerCertificateApiCall(ref _callAddServerCertificate);
            _callAddEntraIdCertificate = clientHelper.BuildApiCall<SqlInstancesAddEntraIdCertificateRequest, Operation>("AddEntraIdCertificate", grpcClient.AddEntraIdCertificateAsync, grpcClient.AddEntraIdCertificate, effectiveSettings.AddEntraIdCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAddEntraIdCertificate);
            Modify_AddEntraIdCertificateApiCall(ref _callAddEntraIdCertificate);
            _callClone = clientHelper.BuildApiCall<SqlInstancesCloneRequest, Operation>("Clone", grpcClient.CloneAsync, grpcClient.Clone, effectiveSettings.CloneSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callClone);
            Modify_CloneApiCall(ref _callClone);
            _callDelete = clientHelper.BuildApiCall<SqlInstancesDeleteRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callDemoteMaster = clientHelper.BuildApiCall<SqlInstancesDemoteMasterRequest, Operation>("DemoteMaster", grpcClient.DemoteMasterAsync, grpcClient.DemoteMaster, effectiveSettings.DemoteMasterSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDemoteMaster);
            Modify_DemoteMasterApiCall(ref _callDemoteMaster);
            _callDemote = clientHelper.BuildApiCall<SqlInstancesDemoteRequest, Operation>("Demote", grpcClient.DemoteAsync, grpcClient.Demote, effectiveSettings.DemoteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callDemote);
            Modify_DemoteApiCall(ref _callDemote);
            _callExport = clientHelper.BuildApiCall<SqlInstancesExportRequest, Operation>("Export", grpcClient.ExportAsync, grpcClient.Export, effectiveSettings.ExportSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callExport);
            Modify_ExportApiCall(ref _callExport);
            _callFailover = clientHelper.BuildApiCall<SqlInstancesFailoverRequest, Operation>("Failover", grpcClient.FailoverAsync, grpcClient.Failover, effectiveSettings.FailoverSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callFailover);
            Modify_FailoverApiCall(ref _callFailover);
            _callReencrypt = clientHelper.BuildApiCall<SqlInstancesReencryptRequest, Operation>("Reencrypt", grpcClient.ReencryptAsync, grpcClient.Reencrypt, effectiveSettings.ReencryptSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReencrypt);
            Modify_ReencryptApiCall(ref _callReencrypt);
            _callGet = clientHelper.BuildApiCall<SqlInstancesGetRequest, DatabaseInstance>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callImport = clientHelper.BuildApiCall<SqlInstancesImportRequest, Operation>("Import", grpcClient.ImportAsync, grpcClient.Import, effectiveSettings.ImportSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callImport);
            Modify_ImportApiCall(ref _callImport);
            _callInsert = clientHelper.BuildApiCall<SqlInstancesInsertRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<SqlInstancesInsertRequest>().WithExtractedParameter("project", "^(.+)$", request => request.Project).WithExtractedParameter("region", "^(.+)$", request => request.Body?.Region));
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<SqlInstancesListRequest, InstancesListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callListServerCas = clientHelper.BuildApiCall<SqlInstancesListServerCasRequest, InstancesListServerCasResponse>("ListServerCas", grpcClient.ListServerCasAsync, grpcClient.ListServerCas, effectiveSettings.ListServerCasSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListServerCas);
            Modify_ListServerCasApiCall(ref _callListServerCas);
            _callListServerCertificates = clientHelper.BuildApiCall<SqlInstancesListServerCertificatesRequest, InstancesListServerCertificatesResponse>("ListServerCertificates", grpcClient.ListServerCertificatesAsync, grpcClient.ListServerCertificates, effectiveSettings.ListServerCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListServerCertificates);
            Modify_ListServerCertificatesApiCall(ref _callListServerCertificates);
            _callListEntraIdCertificates = clientHelper.BuildApiCall<SqlInstancesListEntraIdCertificatesRequest, InstancesListEntraIdCertificatesResponse>("ListEntraIdCertificates", grpcClient.ListEntraIdCertificatesAsync, grpcClient.ListEntraIdCertificates, effectiveSettings.ListEntraIdCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callListEntraIdCertificates);
            Modify_ListEntraIdCertificatesApiCall(ref _callListEntraIdCertificates);
            _callPatch = clientHelper.BuildApiCall<SqlInstancesPatchRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callPromoteReplica = clientHelper.BuildApiCall<SqlInstancesPromoteReplicaRequest, Operation>("PromoteReplica", grpcClient.PromoteReplicaAsync, grpcClient.PromoteReplica, effectiveSettings.PromoteReplicaSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callPromoteReplica);
            Modify_PromoteReplicaApiCall(ref _callPromoteReplica);
            _callSwitchover = clientHelper.BuildApiCall<SqlInstancesSwitchoverRequest, Operation>("Switchover", grpcClient.SwitchoverAsync, grpcClient.Switchover, effectiveSettings.SwitchoverSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callSwitchover);
            Modify_SwitchoverApiCall(ref _callSwitchover);
            _callResetSslConfig = clientHelper.BuildApiCall<SqlInstancesResetSslConfigRequest, Operation>("ResetSslConfig", grpcClient.ResetSslConfigAsync, grpcClient.ResetSslConfig, effectiveSettings.ResetSslConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callResetSslConfig);
            Modify_ResetSslConfigApiCall(ref _callResetSslConfig);
            _callRestart = clientHelper.BuildApiCall<SqlInstancesRestartRequest, Operation>("Restart", grpcClient.RestartAsync, grpcClient.Restart, effectiveSettings.RestartSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRestart);
            Modify_RestartApiCall(ref _callRestart);
            _callStart = clientHelper.BuildApiCall<SqlInstancesStartRequest, Operation>("Start", grpcClient.StartAsync, grpcClient.Start, effectiveSettings.StartSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStart);
            Modify_StartApiCall(ref _callStart);
            _callStop = clientHelper.BuildApiCall<SqlInstancesStopRequest, Operation>("Stop", grpcClient.StopAsync, grpcClient.Stop, effectiveSettings.StopSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStop);
            Modify_StopApiCall(ref _callStop);
            _callRestoreBackup = clientHelper.BuildApiCall<SqlInstancesRestoreBackupRequest, Operation>("RestoreBackup", grpcClient.RestoreBackupAsync, grpcClient.RestoreBackup, effectiveSettings.RestoreBackupSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRestoreBackup);
            Modify_RestoreBackupApiCall(ref _callRestoreBackup);
            _callRotateServerCa = clientHelper.BuildApiCall<SqlInstancesRotateServerCaRequest, Operation>("RotateServerCa", grpcClient.RotateServerCaAsync, grpcClient.RotateServerCa, effectiveSettings.RotateServerCaSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRotateServerCa);
            Modify_RotateServerCaApiCall(ref _callRotateServerCa);
            _callRotateServerCertificate = clientHelper.BuildApiCall<SqlInstancesRotateServerCertificateRequest, Operation>("RotateServerCertificate", grpcClient.RotateServerCertificateAsync, grpcClient.RotateServerCertificate, effectiveSettings.RotateServerCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRotateServerCertificate);
            Modify_RotateServerCertificateApiCall(ref _callRotateServerCertificate);
            _callRotateEntraIdCertificate = clientHelper.BuildApiCall<SqlInstancesRotateEntraIdCertificateRequest, Operation>("RotateEntraIdCertificate", grpcClient.RotateEntraIdCertificateAsync, grpcClient.RotateEntraIdCertificate, effectiveSettings.RotateEntraIdCertificateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRotateEntraIdCertificate);
            Modify_RotateEntraIdCertificateApiCall(ref _callRotateEntraIdCertificate);
            _callStartReplica = clientHelper.BuildApiCall<SqlInstancesStartReplicaRequest, Operation>("StartReplica", grpcClient.StartReplicaAsync, grpcClient.StartReplica, effectiveSettings.StartReplicaSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStartReplica);
            Modify_StartReplicaApiCall(ref _callStartReplica);
            _callStopReplica = clientHelper.BuildApiCall<SqlInstancesStopReplicaRequest, Operation>("StopReplica", grpcClient.StopReplicaAsync, grpcClient.StopReplica, effectiveSettings.StopReplicaSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStopReplica);
            Modify_StopReplicaApiCall(ref _callStopReplica);
            _callTruncateLog = clientHelper.BuildApiCall<SqlInstancesTruncateLogRequest, Operation>("TruncateLog", grpcClient.TruncateLogAsync, grpcClient.TruncateLog, effectiveSettings.TruncateLogSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callTruncateLog);
            Modify_TruncateLogApiCall(ref _callTruncateLog);
            _callUpdate = clientHelper.BuildApiCall<SqlInstancesUpdateRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            _callCreateEphemeral = clientHelper.BuildApiCall<SqlInstancesCreateEphemeralCertRequest, SslCert>("CreateEphemeral", grpcClient.CreateEphemeralAsync, grpcClient.CreateEphemeral, effectiveSettings.CreateEphemeralSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callCreateEphemeral);
            Modify_CreateEphemeralApiCall(ref _callCreateEphemeral);
            _callRescheduleMaintenance = clientHelper.BuildApiCall<SqlInstancesRescheduleMaintenanceRequest, Operation>("RescheduleMaintenance", grpcClient.RescheduleMaintenanceAsync, grpcClient.RescheduleMaintenance, effectiveSettings.RescheduleMaintenanceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callRescheduleMaintenance);
            Modify_RescheduleMaintenanceApiCall(ref _callRescheduleMaintenance);
            _callVerifyExternalSyncSettings = clientHelper.BuildApiCall<SqlInstancesVerifyExternalSyncSettingsRequest, SqlInstancesVerifyExternalSyncSettingsResponse>("VerifyExternalSyncSettings", grpcClient.VerifyExternalSyncSettingsAsync, grpcClient.VerifyExternalSyncSettings, effectiveSettings.VerifyExternalSyncSettingsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callVerifyExternalSyncSettings);
            Modify_VerifyExternalSyncSettingsApiCall(ref _callVerifyExternalSyncSettings);
            _callStartExternalSync = clientHelper.BuildApiCall<SqlInstancesStartExternalSyncRequest, Operation>("StartExternalSync", grpcClient.StartExternalSyncAsync, grpcClient.StartExternalSync, effectiveSettings.StartExternalSyncSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callStartExternalSync);
            Modify_StartExternalSyncApiCall(ref _callStartExternalSync);
            _callPerformDiskShrink = clientHelper.BuildApiCall<SqlInstancesPerformDiskShrinkRequest, Operation>("PerformDiskShrink", grpcClient.PerformDiskShrinkAsync, grpcClient.PerformDiskShrink, effectiveSettings.PerformDiskShrinkSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callPerformDiskShrink);
            Modify_PerformDiskShrinkApiCall(ref _callPerformDiskShrink);
            _callGetDiskShrinkConfig = clientHelper.BuildApiCall<SqlInstancesGetDiskShrinkConfigRequest, SqlInstancesGetDiskShrinkConfigResponse>("GetDiskShrinkConfig", grpcClient.GetDiskShrinkConfigAsync, grpcClient.GetDiskShrinkConfig, effectiveSettings.GetDiskShrinkConfigSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetDiskShrinkConfig);
            Modify_GetDiskShrinkConfigApiCall(ref _callGetDiskShrinkConfig);
            _callResetReplicaSize = clientHelper.BuildApiCall<SqlInstancesResetReplicaSizeRequest, Operation>("ResetReplicaSize", grpcClient.ResetReplicaSizeAsync, grpcClient.ResetReplicaSize, effectiveSettings.ResetReplicaSizeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callResetReplicaSize);
            Modify_ResetReplicaSizeApiCall(ref _callResetReplicaSize);
            _callGetLatestRecoveryTime = clientHelper.BuildApiCall<SqlInstancesGetLatestRecoveryTimeRequest, SqlInstancesGetLatestRecoveryTimeResponse>("GetLatestRecoveryTime", grpcClient.GetLatestRecoveryTimeAsync, grpcClient.GetLatestRecoveryTime, effectiveSettings.GetLatestRecoveryTimeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callGetLatestRecoveryTime);
            Modify_GetLatestRecoveryTimeApiCall(ref _callGetLatestRecoveryTime);
            _callExecuteSqlReadOnly = clientHelper.BuildApiCall<SqlInstancesExecuteSqlReadOnlyRequest, SqlInstancesExecuteSqlReadOnlyResponse>("ExecuteSqlReadOnly", grpcClient.ExecuteSqlReadOnlyAsync, grpcClient.ExecuteSqlReadOnly, effectiveSettings.ExecuteSqlReadOnlySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callExecuteSqlReadOnly);
            Modify_ExecuteSqlReadOnlyApiCall(ref _callExecuteSqlReadOnly);
            _callExecuteSql = clientHelper.BuildApiCall<SqlInstancesExecuteSqlRequest, SqlInstancesExecuteSqlResponse>("ExecuteSql", grpcClient.ExecuteSqlAsync, grpcClient.ExecuteSql, effectiveSettings.ExecuteSqlSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callExecuteSql);
            Modify_ExecuteSqlApiCall(ref _callExecuteSql);
            _callAcquireSsrsLease = clientHelper.BuildApiCall<SqlInstancesAcquireSsrsLeaseRequest, SqlInstancesAcquireSsrsLeaseResponse>("AcquireSsrsLease", grpcClient.AcquireSsrsLeaseAsync, grpcClient.AcquireSsrsLease, effectiveSettings.AcquireSsrsLeaseSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callAcquireSsrsLease);
            Modify_AcquireSsrsLeaseApiCall(ref _callAcquireSsrsLease);
            _callReleaseSsrsLease = clientHelper.BuildApiCall<SqlInstancesReleaseSsrsLeaseRequest, SqlInstancesReleaseSsrsLeaseResponse>("ReleaseSsrsLease", grpcClient.ReleaseSsrsLeaseAsync, grpcClient.ReleaseSsrsLease, effectiveSettings.ReleaseSsrsLeaseSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReleaseSsrsLease);
            Modify_ReleaseSsrsLeaseApiCall(ref _callReleaseSsrsLease);
            _callPreCheckMajorVersionUpgrade = clientHelper.BuildApiCall<SqlInstancesPreCheckMajorVersionUpgradeRequest, Operation>("PreCheckMajorVersionUpgrade", grpcClient.PreCheckMajorVersionUpgradeAsync, grpcClient.PreCheckMajorVersionUpgrade, effectiveSettings.PreCheckMajorVersionUpgradeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callPreCheckMajorVersionUpgrade);
            Modify_PreCheckMajorVersionUpgradeApiCall(ref _callPreCheckMajorVersionUpgrade);
            _callPointInTimeRestore = clientHelper.BuildApiCall<SqlInstancesPointInTimeRestoreRequest, Operation>("PointInTimeRestore", grpcClient.PointInTimeRestoreAsync, grpcClient.PointInTimeRestore, effectiveSettings.PointInTimeRestoreSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPointInTimeRestore);
            Modify_PointInTimeRestoreApiCall(ref _callPointInTimeRestore);
            _callReconcileNetworking = clientHelper.BuildApiCall<SqlInstancesReconcileNetworkingRequest, Operation>("ReconcileNetworking", grpcClient.ReconcileNetworkingAsync, grpcClient.ReconcileNetworking, effectiveSettings.ReconcileNetworkingSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callReconcileNetworking);
            Modify_ReconcileNetworkingApiCall(ref _callReconcileNetworking);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AddServerCaApiCall(ref gaxgrpc::ApiCall<SqlInstancesAddServerCaRequest, Operation> call);

        partial void Modify_AddServerCertificateApiCall(ref gaxgrpc::ApiCall<SqlInstancesAddServerCertificateRequest, Operation> call);

        partial void Modify_AddEntraIdCertificateApiCall(ref gaxgrpc::ApiCall<SqlInstancesAddEntraIdCertificateRequest, Operation> call);

        partial void Modify_CloneApiCall(ref gaxgrpc::ApiCall<SqlInstancesCloneRequest, Operation> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<SqlInstancesDeleteRequest, Operation> call);

        partial void Modify_DemoteMasterApiCall(ref gaxgrpc::ApiCall<SqlInstancesDemoteMasterRequest, Operation> call);

        partial void Modify_DemoteApiCall(ref gaxgrpc::ApiCall<SqlInstancesDemoteRequest, Operation> call);

        partial void Modify_ExportApiCall(ref gaxgrpc::ApiCall<SqlInstancesExportRequest, Operation> call);

        partial void Modify_FailoverApiCall(ref gaxgrpc::ApiCall<SqlInstancesFailoverRequest, Operation> call);

        partial void Modify_ReencryptApiCall(ref gaxgrpc::ApiCall<SqlInstancesReencryptRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<SqlInstancesGetRequest, DatabaseInstance> call);

        partial void Modify_ImportApiCall(ref gaxgrpc::ApiCall<SqlInstancesImportRequest, Operation> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<SqlInstancesInsertRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<SqlInstancesListRequest, InstancesListResponse> call);

        partial void Modify_ListServerCasApiCall(ref gaxgrpc::ApiCall<SqlInstancesListServerCasRequest, InstancesListServerCasResponse> call);

        partial void Modify_ListServerCertificatesApiCall(ref gaxgrpc::ApiCall<SqlInstancesListServerCertificatesRequest, InstancesListServerCertificatesResponse> call);

        partial void Modify_ListEntraIdCertificatesApiCall(ref gaxgrpc::ApiCall<SqlInstancesListEntraIdCertificatesRequest, InstancesListEntraIdCertificatesResponse> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<SqlInstancesPatchRequest, Operation> call);

        partial void Modify_PromoteReplicaApiCall(ref gaxgrpc::ApiCall<SqlInstancesPromoteReplicaRequest, Operation> call);

        partial void Modify_SwitchoverApiCall(ref gaxgrpc::ApiCall<SqlInstancesSwitchoverRequest, Operation> call);

        partial void Modify_ResetSslConfigApiCall(ref gaxgrpc::ApiCall<SqlInstancesResetSslConfigRequest, Operation> call);

        partial void Modify_RestartApiCall(ref gaxgrpc::ApiCall<SqlInstancesRestartRequest, Operation> call);

        partial void Modify_StartApiCall(ref gaxgrpc::ApiCall<SqlInstancesStartRequest, Operation> call);

        partial void Modify_StopApiCall(ref gaxgrpc::ApiCall<SqlInstancesStopRequest, Operation> call);

        partial void Modify_RestoreBackupApiCall(ref gaxgrpc::ApiCall<SqlInstancesRestoreBackupRequest, Operation> call);

        partial void Modify_RotateServerCaApiCall(ref gaxgrpc::ApiCall<SqlInstancesRotateServerCaRequest, Operation> call);

        partial void Modify_RotateServerCertificateApiCall(ref gaxgrpc::ApiCall<SqlInstancesRotateServerCertificateRequest, Operation> call);

        partial void Modify_RotateEntraIdCertificateApiCall(ref gaxgrpc::ApiCall<SqlInstancesRotateEntraIdCertificateRequest, Operation> call);

        partial void Modify_StartReplicaApiCall(ref gaxgrpc::ApiCall<SqlInstancesStartReplicaRequest, Operation> call);

        partial void Modify_StopReplicaApiCall(ref gaxgrpc::ApiCall<SqlInstancesStopReplicaRequest, Operation> call);

        partial void Modify_TruncateLogApiCall(ref gaxgrpc::ApiCall<SqlInstancesTruncateLogRequest, Operation> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<SqlInstancesUpdateRequest, Operation> call);

        partial void Modify_CreateEphemeralApiCall(ref gaxgrpc::ApiCall<SqlInstancesCreateEphemeralCertRequest, SslCert> call);

        partial void Modify_RescheduleMaintenanceApiCall(ref gaxgrpc::ApiCall<SqlInstancesRescheduleMaintenanceRequest, Operation> call);

        partial void Modify_VerifyExternalSyncSettingsApiCall(ref gaxgrpc::ApiCall<SqlInstancesVerifyExternalSyncSettingsRequest, SqlInstancesVerifyExternalSyncSettingsResponse> call);

        partial void Modify_StartExternalSyncApiCall(ref gaxgrpc::ApiCall<SqlInstancesStartExternalSyncRequest, Operation> call);

        partial void Modify_PerformDiskShrinkApiCall(ref gaxgrpc::ApiCall<SqlInstancesPerformDiskShrinkRequest, Operation> call);

        partial void Modify_GetDiskShrinkConfigApiCall(ref gaxgrpc::ApiCall<SqlInstancesGetDiskShrinkConfigRequest, SqlInstancesGetDiskShrinkConfigResponse> call);

        partial void Modify_ResetReplicaSizeApiCall(ref gaxgrpc::ApiCall<SqlInstancesResetReplicaSizeRequest, Operation> call);

        partial void Modify_GetLatestRecoveryTimeApiCall(ref gaxgrpc::ApiCall<SqlInstancesGetLatestRecoveryTimeRequest, SqlInstancesGetLatestRecoveryTimeResponse> call);

        partial void Modify_ExecuteSqlReadOnlyApiCall(ref gaxgrpc::ApiCall<SqlInstancesExecuteSqlReadOnlyRequest, SqlInstancesExecuteSqlReadOnlyResponse> call);

        partial void Modify_ExecuteSqlApiCall(ref gaxgrpc::ApiCall<SqlInstancesExecuteSqlRequest, SqlInstancesExecuteSqlResponse> call);

        partial void Modify_AcquireSsrsLeaseApiCall(ref gaxgrpc::ApiCall<SqlInstancesAcquireSsrsLeaseRequest, SqlInstancesAcquireSsrsLeaseResponse> call);

        partial void Modify_ReleaseSsrsLeaseApiCall(ref gaxgrpc::ApiCall<SqlInstancesReleaseSsrsLeaseRequest, SqlInstancesReleaseSsrsLeaseResponse> call);

        partial void Modify_PreCheckMajorVersionUpgradeApiCall(ref gaxgrpc::ApiCall<SqlInstancesPreCheckMajorVersionUpgradeRequest, Operation> call);

        partial void Modify_PointInTimeRestoreApiCall(ref gaxgrpc::ApiCall<SqlInstancesPointInTimeRestoreRequest, Operation> call);

        partial void Modify_ReconcileNetworkingApiCall(ref gaxgrpc::ApiCall<SqlInstancesReconcileNetworkingRequest, Operation> call);

        partial void OnConstruction(SqlInstancesService.SqlInstancesServiceClient grpcClient, SqlInstancesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlInstancesService client</summary>
        public override SqlInstancesService.SqlInstancesServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SqlInstancesAddServerCaRequest(ref SqlInstancesAddServerCaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesAddServerCertificateRequest(ref SqlInstancesAddServerCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesAddEntraIdCertificateRequest(ref SqlInstancesAddEntraIdCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesCloneRequest(ref SqlInstancesCloneRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesDeleteRequest(ref SqlInstancesDeleteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesDemoteMasterRequest(ref SqlInstancesDemoteMasterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesDemoteRequest(ref SqlInstancesDemoteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesExportRequest(ref SqlInstancesExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesFailoverRequest(ref SqlInstancesFailoverRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesReencryptRequest(ref SqlInstancesReencryptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesGetRequest(ref SqlInstancesGetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesImportRequest(ref SqlInstancesImportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesInsertRequest(ref SqlInstancesInsertRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesListRequest(ref SqlInstancesListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesListServerCasRequest(ref SqlInstancesListServerCasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesListServerCertificatesRequest(ref SqlInstancesListServerCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesListEntraIdCertificatesRequest(ref SqlInstancesListEntraIdCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesPatchRequest(ref SqlInstancesPatchRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesPromoteReplicaRequest(ref SqlInstancesPromoteReplicaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesSwitchoverRequest(ref SqlInstancesSwitchoverRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesResetSslConfigRequest(ref SqlInstancesResetSslConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRestartRequest(ref SqlInstancesRestartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesStartRequest(ref SqlInstancesStartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesStopRequest(ref SqlInstancesStopRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRestoreBackupRequest(ref SqlInstancesRestoreBackupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRotateServerCaRequest(ref SqlInstancesRotateServerCaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRotateServerCertificateRequest(ref SqlInstancesRotateServerCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRotateEntraIdCertificateRequest(ref SqlInstancesRotateEntraIdCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesStartReplicaRequest(ref SqlInstancesStartReplicaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesStopReplicaRequest(ref SqlInstancesStopReplicaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesTruncateLogRequest(ref SqlInstancesTruncateLogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesUpdateRequest(ref SqlInstancesUpdateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesCreateEphemeralCertRequest(ref SqlInstancesCreateEphemeralCertRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesRescheduleMaintenanceRequest(ref SqlInstancesRescheduleMaintenanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesVerifyExternalSyncSettingsRequest(ref SqlInstancesVerifyExternalSyncSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesStartExternalSyncRequest(ref SqlInstancesStartExternalSyncRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesPerformDiskShrinkRequest(ref SqlInstancesPerformDiskShrinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesGetDiskShrinkConfigRequest(ref SqlInstancesGetDiskShrinkConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesResetReplicaSizeRequest(ref SqlInstancesResetReplicaSizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesGetLatestRecoveryTimeRequest(ref SqlInstancesGetLatestRecoveryTimeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesExecuteSqlReadOnlyRequest(ref SqlInstancesExecuteSqlReadOnlyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesExecuteSqlRequest(ref SqlInstancesExecuteSqlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesAcquireSsrsLeaseRequest(ref SqlInstancesAcquireSsrsLeaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesReleaseSsrsLeaseRequest(ref SqlInstancesReleaseSsrsLeaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesPreCheckMajorVersionUpgradeRequest(ref SqlInstancesPreCheckMajorVersionUpgradeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesPointInTimeRestoreRequest(ref SqlInstancesPointInTimeRestoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SqlInstancesReconcileNetworkingRequest(ref SqlInstancesReconcileNetworkingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Adds a new trusted Certificate Authority (CA) version for the specified
        /// instance. Required to prepare for a certificate rotation. If a CA version
        /// was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version
        /// waiting to be rotated in. For instances that have enabled Certificate
        /// Authority Service (CAS) based server CA, use AddServerCertificate to add a
        /// new server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddServerCa(SqlInstancesAddServerCaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddServerCaRequest(ref request, ref callSettings);
            return _callAddServerCa.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a new trusted Certificate Authority (CA) version for the specified
        /// instance. Required to prepare for a certificate rotation. If a CA version
        /// was previously added but never used in a certificate rotation, this
        /// operation replaces that version. There cannot be more than one CA version
        /// waiting to be rotated in. For instances that have enabled Certificate
        /// Authority Service (CAS) based server CA, use AddServerCertificate to add a
        /// new server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddServerCaAsync(SqlInstancesAddServerCaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddServerCaRequest(ref request, ref callSettings);
            return _callAddServerCa.Async(request, callSettings);
        }

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance
        /// using Certificate Authority Service (CAS) server CA. Required to prepare
        /// for a certificate rotation. If a server certificate version was previously
        /// added but never used in a certificate rotation, this operation replaces
        /// that version. There cannot be more than one certificate version waiting to
        /// be rotated in. For instances not using CAS server CA, use AddServerCa
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddServerCertificate(SqlInstancesAddServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddServerCertificateRequest(ref request, ref callSettings);
            return _callAddServerCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Add a new trusted server certificate version for the specified instance
        /// using Certificate Authority Service (CAS) server CA. Required to prepare
        /// for a certificate rotation. If a server certificate version was previously
        /// added but never used in a certificate rotation, this operation replaces
        /// that version. There cannot be more than one certificate version waiting to
        /// be rotated in. For instances not using CAS server CA, use AddServerCa
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddServerCertificateAsync(SqlInstancesAddServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddServerCertificateRequest(ref request, ref callSettings);
            return _callAddServerCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a new Entra ID certificate for the specified instance. If an Entra ID
        /// certificate was previously added but never used in a certificate rotation,
        /// this operation replaces that version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation AddEntraIdCertificate(SqlInstancesAddEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddEntraIdCertificateRequest(ref request, ref callSettings);
            return _callAddEntraIdCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a new Entra ID certificate for the specified instance. If an Entra ID
        /// certificate was previously added but never used in a certificate rotation,
        /// this operation replaces that version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> AddEntraIdCertificateAsync(SqlInstancesAddEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAddEntraIdCertificateRequest(ref request, ref callSettings);
            return _callAddEntraIdCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this
        /// operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Clone(SqlInstancesCloneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesCloneRequest(ref request, ref callSettings);
            return _callClone.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Cloud SQL instance as a clone of the source instance. Using this
        /// operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CloneAsync(SqlInstancesCloneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesCloneRequest(ref request, ref callSettings);
            return _callClone.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(SqlInstancesDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDeleteRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(SqlInstancesDeleteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDeleteRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an
        /// external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DemoteMaster(SqlInstancesDemoteMasterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDemoteMasterRequest(ref request, ref callSettings);
            return _callDemoteMaster.Sync(request, callSettings);
        }

        /// <summary>
        /// Demotes the stand-alone instance to be a Cloud SQL read replica for an
        /// external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DemoteMasterAsync(SqlInstancesDemoteMasterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDemoteMasterRequest(ref request, ref callSettings);
            return _callDemoteMaster.Async(request, callSettings);
        }

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica
        /// for an external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Demote(SqlInstancesDemoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDemoteRequest(ref request, ref callSettings);
            return _callDemote.Sync(request, callSettings);
        }

        /// <summary>
        /// Demotes an existing standalone instance to be a Cloud SQL read replica
        /// for an external database server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DemoteAsync(SqlInstancesDemoteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesDemoteRequest(ref request, ref callSettings);
            return _callDemote.Async(request, callSettings);
        }

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL
        /// dump or CSV file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Export(SqlInstancesExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExportRequest(ref request, ref callSettings);
            return _callExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports data from a Cloud SQL instance to a Cloud Storage bucket as a SQL
        /// dump or CSV file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ExportAsync(SqlInstancesExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExportRequest(ref request, ref callSettings);
            return _callExport.Async(request, callSettings);
        }

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance
        /// to a standby instance, which becomes the primary instance. Users are
        /// then rerouted to the new primary. For more information, see the
        /// [Overview of high
        /// availability](https://cloud.google.com/sql/docs/mysql/high-availability)
        /// page in the Cloud SQL documentation.
        /// If using Legacy HA (MySQL only), this causes the instance to failover to
        /// its failover replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Failover(SqlInstancesFailoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesFailoverRequest(ref request, ref callSettings);
            return _callFailover.Sync(request, callSettings);
        }

        /// <summary>
        /// Initiates a manual failover of a high availability (HA) primary instance
        /// to a standby instance, which becomes the primary instance. Users are
        /// then rerouted to the new primary. For more information, see the
        /// [Overview of high
        /// availability](https://cloud.google.com/sql/docs/mysql/high-availability)
        /// page in the Cloud SQL documentation.
        /// If using Legacy HA (MySQL only), this causes the instance to failover to
        /// its failover replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> FailoverAsync(SqlInstancesFailoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesFailoverRequest(ref request, ref callSettings);
            return _callFailover.Async(request, callSettings);
        }

        /// <summary>
        /// Reencrypt CMEK instance with latest key version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Reencrypt(SqlInstancesReencryptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReencryptRequest(ref request, ref callSettings);
            return _callReencrypt.Sync(request, callSettings);
        }

        /// <summary>
        /// Reencrypt CMEK instance with latest key version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ReencryptAsync(SqlInstancesReencryptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReencryptRequest(ref request, ref callSettings);
            return _callReencrypt.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DatabaseInstance Get(SqlInstancesGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DatabaseInstance> GetAsync(SqlInstancesGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Imports data into a Cloud SQL instance from a SQL dump  or CSV file in
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Import(SqlInstancesImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesImportRequest(ref request, ref callSettings);
            return _callImport.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports data into a Cloud SQL instance from a SQL dump  or CSV file in
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ImportAsync(SqlInstancesImportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesImportRequest(ref request, ref callSettings);
            return _callImport.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(SqlInstancesInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesInsertRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(SqlInstancesInsertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesInsertRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists instances under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApiWarning"/> resources.</returns>
        public override gax::PagedEnumerable<InstancesListResponse, ApiWarning> List(SqlInstancesListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SqlInstancesListRequest, InstancesListResponse, ApiWarning>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists instances under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApiWarning"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<InstancesListResponse, ApiWarning> ListAsync(SqlInstancesListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SqlInstancesListRequest, InstancesListResponse, ApiWarning>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified
        /// instance. There can be up to three CAs listed: the CA that was used to sign
        /// the certificate that is currently in use, a CA that has been added but not
        /// yet used to sign a certificate, and a CA used to sign a certificate that
        /// has previously rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstancesListServerCasResponse ListServerCas(SqlInstancesListServerCasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListServerCasRequest(ref request, ref callSettings);
            return _callListServerCas.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all of the trusted Certificate Authorities (CAs) for the specified
        /// instance. There can be up to three CAs listed: the CA that was used to sign
        /// the certificate that is currently in use, a CA that has been added but not
        /// yet used to sign a certificate, and a CA used to sign a certificate that
        /// has previously rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstancesListServerCasResponse> ListServerCasAsync(SqlInstancesListServerCasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListServerCasRequest(ref request, ref callSettings);
            return _callListServerCas.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs)
        /// for the specified instance. There can be up to three sets of certs listed:
        /// the certificate that is currently in use, a future that has been added but
        /// not yet used to sign a certificate, and a certificate that has been rotated
        /// out. For instances not using Certificate Authority Service (CAS) server CA,
        /// use ListServerCas instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstancesListServerCertificatesResponse ListServerCertificates(SqlInstancesListServerCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListServerCertificatesRequest(ref request, ref callSettings);
            return _callListServerCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of server certificates and certificate authorities (CAs)
        /// for the specified instance. There can be up to three sets of certs listed:
        /// the certificate that is currently in use, a future that has been added but
        /// not yet used to sign a certificate, and a certificate that has been rotated
        /// out. For instances not using Certificate Authority Service (CAS) server CA,
        /// use ListServerCas instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstancesListServerCertificatesResponse> ListServerCertificatesAsync(SqlInstancesListServerCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListServerCertificatesRequest(ref request, ref callSettings);
            return _callListServerCertificates.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of EntraID certificates for the specified instance.
        /// There can be up to three sets of certificates listed: the certificate that
        /// is currently in use, a future that has been added but not yet used to sign
        /// a certificate, and a certificate that has been rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstancesListEntraIdCertificatesResponse ListEntraIdCertificates(SqlInstancesListEntraIdCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListEntraIdCertificatesRequest(ref request, ref callSettings);
            return _callListEntraIdCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of EntraID certificates for the specified instance.
        /// There can be up to three sets of certificates listed: the certificate that
        /// is currently in use, a future that has been added but not yet used to sign
        /// a certificate, and a certificate that has been rotated out.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstancesListEntraIdCertificatesResponse> ListEntraIdCertificatesAsync(SqlInstancesListEntraIdCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesListEntraIdCertificatesRequest(ref request, ref callSettings);
            return _callListEntraIdCertificates.Async(request, callSettings);
        }

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request
        /// with the current configuration. This method supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(SqlInstancesPatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPatchRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Partially updates settings of a Cloud SQL instance by merging the request
        /// with the current configuration. This method supports patch semantics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(SqlInstancesPatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPatchRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL
        /// primary instance.
        /// Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation PromoteReplica(SqlInstancesPromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPromoteReplicaRequest(ref request, ref callSettings);
            return _callPromoteReplica.Sync(request, callSettings);
        }

        /// <summary>
        /// Promotes the read replica instance to be an independent Cloud SQL
        /// primary instance.
        /// Using this operation might cause your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PromoteReplicaAsync(SqlInstancesPromoteReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPromoteReplicaRequest(ref request, ref callSettings);
            return _callPromoteReplica.Async(request, callSettings);
        }

        /// <summary>
        /// Switches over from the primary instance to the DR replica
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Switchover(SqlInstancesSwitchoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesSwitchoverRequest(ref request, ref callSettings);
            return _callSwitchover.Sync(request, callSettings);
        }

        /// <summary>
        /// Switches over from the primary instance to the DR replica
        /// instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SwitchoverAsync(SqlInstancesSwitchoverRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesSwitchoverRequest(ref request, ref callSettings);
            return _callSwitchover.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate
        /// for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation ResetSslConfig(SqlInstancesResetSslConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesResetSslConfigRequest(ref request, ref callSettings);
            return _callResetSslConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes all client certificates and generates a new server SSL certificate
        /// for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ResetSslConfigAsync(SqlInstancesResetSslConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesResetSslConfigRequest(ref request, ref callSettings);
            return _callResetSslConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Restarts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Restart(SqlInstancesRestartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRestartRequest(ref request, ref callSettings);
            return _callRestart.Sync(request, callSettings);
        }

        /// <summary>
        /// Restarts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RestartAsync(SqlInstancesRestartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRestartRequest(ref request, ref callSettings);
            return _callRestart.Async(request, callSettings);
        }

        /// <summary>
        /// Starts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Start(SqlInstancesStartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartRequest(ref request, ref callSettings);
            return _callStart.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartAsync(SqlInstancesStartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartRequest(ref request, ref callSettings);
            return _callStart.Async(request, callSettings);
        }

        /// <summary>
        /// Stops a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Stop(SqlInstancesStopRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStopRequest(ref request, ref callSettings);
            return _callStop.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops a Cloud SQL instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StopAsync(SqlInstancesStopRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStopRequest(ref request, ref callSettings);
            return _callStop.Async(request, callSettings);
        }

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RestoreBackup(SqlInstancesRestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRestoreBackupRequest(ref request, ref callSettings);
            return _callRestoreBackup.Sync(request, callSettings);
        }

        /// <summary>
        /// Restores a backup of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RestoreBackupAsync(SqlInstancesRestoreBackupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRestoreBackupRequest(ref request, ref callSettings);
            return _callRestoreBackup.Async(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority
        /// (CA) version previously added with the addServerCA method. For instances
        /// that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RotateServerCa(SqlInstancesRotateServerCaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateServerCaRequest(ref request, ref callSettings);
            return _callRotateServerCa.Sync(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate to one signed by the Certificate Authority
        /// (CA) version previously added with the addServerCA method. For instances
        /// that have enabled Certificate Authority Service (CAS) based server CA,
        /// use RotateServerCertificate to rotate the server certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RotateServerCaAsync(SqlInstancesRotateServerCaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateServerCaRequest(ref request, ref callSettings);
            return _callRotateServerCa.Async(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addServerCertificate method. For instances not using Certificate Authority
        /// Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RotateServerCertificate(SqlInstancesRotateServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateServerCertificateRequest(ref request, ref callSettings);
            return _callRotateServerCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addServerCertificate method. For instances not using Certificate Authority
        /// Service (CAS) server CA, use RotateServerCa instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RotateServerCertificateAsync(SqlInstancesRotateServerCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateServerCertificateRequest(ref request, ref callSettings);
            return _callRotateServerCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addEntraIdCertificate method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RotateEntraIdCertificate(SqlInstancesRotateEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateEntraIdCertificateRequest(ref request, ref callSettings);
            return _callRotateEntraIdCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Rotates the server certificate version to one previously added with the
        /// addEntraIdCertificate method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RotateEntraIdCertificateAsync(SqlInstancesRotateEntraIdCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRotateEntraIdCertificateRequest(ref request, ref callSettings);
            return _callRotateEntraIdCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Starts the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StartReplica(SqlInstancesStartReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartReplicaRequest(ref request, ref callSettings);
            return _callStartReplica.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartReplicaAsync(SqlInstancesStartReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartReplicaRequest(ref request, ref callSettings);
            return _callStartReplica.Async(request, callSettings);
        }

        /// <summary>
        /// Stops the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StopReplica(SqlInstancesStopReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStopReplicaRequest(ref request, ref callSettings);
            return _callStopReplica.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops the replication in the read replica instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StopReplicaAsync(SqlInstancesStopReplicaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStopReplicaRequest(ref request, ref callSettings);
            return _callStopReplica.Async(request, callSettings);
        }

        /// <summary>
        /// Truncate MySQL general and slow query log tables
        /// MySQL only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation TruncateLog(SqlInstancesTruncateLogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesTruncateLogRequest(ref request, ref callSettings);
            return _callTruncateLog.Sync(request, callSettings);
        }

        /// <summary>
        /// Truncate MySQL general and slow query log tables
        /// MySQL only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> TruncateLogAsync(SqlInstancesTruncateLogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesTruncateLogRequest(ref request, ref callSettings);
            return _callTruncateLog.Async(request, callSettings);
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Update(SqlInstancesUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesUpdateRequest(ref request, ref callSettings);
            return _callUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates settings of a Cloud SQL instance. Using this operation might cause
        /// your instance to restart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAsync(SqlInstancesUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesUpdateRequest(ref request, ref callSettings);
            return _callUpdate.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SslCert CreateEphemeral(SqlInstancesCreateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesCreateEphemeralCertRequest(ref request, ref callSettings);
            return _callCreateEphemeral.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a short-lived X509 certificate containing the provided public key
        /// and signed by a private key specific to the target instance. Users may use
        /// the certificate to authenticate as themselves when connecting to the
        /// database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SslCert> CreateEphemeralAsync(SqlInstancesCreateEphemeralCertRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesCreateEphemeralCertRequest(ref request, ref callSettings);
            return _callCreateEphemeral.Async(request, callSettings);
        }

        /// <summary>
        /// Reschedules the maintenance on the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation RescheduleMaintenance(SqlInstancesRescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRescheduleMaintenanceRequest(ref request, ref callSettings);
            return _callRescheduleMaintenance.Sync(request, callSettings);
        }

        /// <summary>
        /// Reschedules the maintenance on the given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> RescheduleMaintenanceAsync(SqlInstancesRescheduleMaintenanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesRescheduleMaintenanceRequest(ref request, ref callSettings);
            return _callRescheduleMaintenance.Async(request, callSettings);
        }

        /// <summary>
        /// Verify External primary instance external sync settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesVerifyExternalSyncSettingsResponse VerifyExternalSyncSettings(SqlInstancesVerifyExternalSyncSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesVerifyExternalSyncSettingsRequest(ref request, ref callSettings);
            return _callVerifyExternalSyncSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Verify External primary instance external sync settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesVerifyExternalSyncSettingsResponse> VerifyExternalSyncSettingsAsync(SqlInstancesVerifyExternalSyncSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesVerifyExternalSyncSettingsRequest(ref request, ref callSettings);
            return _callVerifyExternalSyncSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Start External primary instance migration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation StartExternalSync(SqlInstancesStartExternalSyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartExternalSyncRequest(ref request, ref callSettings);
            return _callStartExternalSync.Sync(request, callSettings);
        }

        /// <summary>
        /// Start External primary instance migration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> StartExternalSyncAsync(SqlInstancesStartExternalSyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesStartExternalSyncRequest(ref request, ref callSettings);
            return _callStartExternalSync.Async(request, callSettings);
        }

        /// <summary>
        /// Perform Disk Shrink on primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation PerformDiskShrink(SqlInstancesPerformDiskShrinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPerformDiskShrinkRequest(ref request, ref callSettings);
            return _callPerformDiskShrink.Sync(request, callSettings);
        }

        /// <summary>
        /// Perform Disk Shrink on primary instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PerformDiskShrinkAsync(SqlInstancesPerformDiskShrinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPerformDiskShrinkRequest(ref request, ref callSettings);
            return _callPerformDiskShrink.Async(request, callSettings);
        }

        /// <summary>
        /// Get Disk Shrink Config for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesGetDiskShrinkConfigResponse GetDiskShrinkConfig(SqlInstancesGetDiskShrinkConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetDiskShrinkConfigRequest(ref request, ref callSettings);
            return _callGetDiskShrinkConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Get Disk Shrink Config for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesGetDiskShrinkConfigResponse> GetDiskShrinkConfigAsync(SqlInstancesGetDiskShrinkConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetDiskShrinkConfigRequest(ref request, ref callSettings);
            return _callGetDiskShrinkConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Reset Replica Size to primary instance disk size.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation ResetReplicaSize(SqlInstancesResetReplicaSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesResetReplicaSizeRequest(ref request, ref callSettings);
            return _callResetReplicaSize.Sync(request, callSettings);
        }

        /// <summary>
        /// Reset Replica Size to primary instance disk size.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ResetReplicaSizeAsync(SqlInstancesResetReplicaSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesResetReplicaSizeRequest(ref request, ref callSettings);
            return _callResetReplicaSize.Async(request, callSettings);
        }

        /// <summary>
        /// Get Latest Recovery Time for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesGetLatestRecoveryTimeResponse GetLatestRecoveryTime(SqlInstancesGetLatestRecoveryTimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetLatestRecoveryTimeRequest(ref request, ref callSettings);
            return _callGetLatestRecoveryTime.Sync(request, callSettings);
        }

        /// <summary>
        /// Get Latest Recovery Time for a given instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesGetLatestRecoveryTimeResponse> GetLatestRecoveryTimeAsync(SqlInstancesGetLatestRecoveryTimeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesGetLatestRecoveryTimeRequest(ref request, ref callSettings);
            return _callGetLatestRecoveryTime.Async(request, callSettings);
        }

        /// <summary>
        /// Execute SQL statements in read-only mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesExecuteSqlReadOnlyResponse ExecuteSqlReadOnly(SqlInstancesExecuteSqlReadOnlyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExecuteSqlReadOnlyRequest(ref request, ref callSettings);
            return _callExecuteSqlReadOnly.Sync(request, callSettings);
        }

        /// <summary>
        /// Execute SQL statements in read-only mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesExecuteSqlReadOnlyResponse> ExecuteSqlReadOnlyAsync(SqlInstancesExecuteSqlReadOnlyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExecuteSqlReadOnlyRequest(ref request, ref callSettings);
            return _callExecuteSqlReadOnly.Async(request, callSettings);
        }

        /// <summary>
        /// Execute SQL statements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesExecuteSqlResponse ExecuteSql(SqlInstancesExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Sync(request, callSettings);
        }

        /// <summary>
        /// Execute SQL statements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesExecuteSqlResponse> ExecuteSqlAsync(SqlInstancesExecuteSqlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesExecuteSqlRequest(ref request, ref callSettings);
            return _callExecuteSql.Async(request, callSettings);
        }

        /// <summary>
        /// Acquire a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesAcquireSsrsLeaseResponse AcquireSsrsLease(SqlInstancesAcquireSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAcquireSsrsLeaseRequest(ref request, ref callSettings);
            return _callAcquireSsrsLease.Sync(request, callSettings);
        }

        /// <summary>
        /// Acquire a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesAcquireSsrsLeaseResponse> AcquireSsrsLeaseAsync(SqlInstancesAcquireSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesAcquireSsrsLeaseRequest(ref request, ref callSettings);
            return _callAcquireSsrsLease.Async(request, callSettings);
        }

        /// <summary>
        /// Release a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SqlInstancesReleaseSsrsLeaseResponse ReleaseSsrsLease(SqlInstancesReleaseSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReleaseSsrsLeaseRequest(ref request, ref callSettings);
            return _callReleaseSsrsLease.Sync(request, callSettings);
        }

        /// <summary>
        /// Release a lease for the setup of SQL Server Reporting Services (SSRS).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SqlInstancesReleaseSsrsLeaseResponse> ReleaseSsrsLeaseAsync(SqlInstancesReleaseSsrsLeaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReleaseSsrsLeaseRequest(ref request, ref callSettings);
            return _callReleaseSsrsLease.Async(request, callSettings);
        }

        /// <summary>
        /// Execute MVU Pre-checks
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation PreCheckMajorVersionUpgrade(SqlInstancesPreCheckMajorVersionUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPreCheckMajorVersionUpgradeRequest(ref request, ref callSettings);
            return _callPreCheckMajorVersionUpgrade.Sync(request, callSettings);
        }

        /// <summary>
        /// Execute MVU Pre-checks
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PreCheckMajorVersionUpgradeAsync(SqlInstancesPreCheckMajorVersionUpgradeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPreCheckMajorVersionUpgradeRequest(ref request, ref callSettings);
            return _callPreCheckMajorVersionUpgrade.Async(request, callSettings);
        }

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and
        /// Disaster Recovery.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation PointInTimeRestore(SqlInstancesPointInTimeRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPointInTimeRestoreRequest(ref request, ref callSettings);
            return _callPointInTimeRestore.Sync(request, callSettings);
        }

        /// <summary>
        /// Point in time restore for an instance managed by Google Cloud Backup and
        /// Disaster Recovery.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PointInTimeRestoreAsync(SqlInstancesPointInTimeRestoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesPointInTimeRestoreRequest(ref request, ref callSettings);
            return _callPointInTimeRestore.Async(request, callSettings);
        }

        /// <summary>
        /// Repairs and recreates networking resources for a Cloud SQL instance. For
        /// Private Service Connect (PSC), this operation recreates PSC DNS write
        /// endpoints on specified VPC networks and reconciles Private Service Connect
        /// connectivity infrastructure for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation ReconcileNetworking(SqlInstancesReconcileNetworkingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReconcileNetworkingRequest(ref request, ref callSettings);
            return _callReconcileNetworking.Sync(request, callSettings);
        }

        /// <summary>
        /// Repairs and recreates networking resources for a Cloud SQL instance. For
        /// Private Service Connect (PSC), this operation recreates PSC DNS write
        /// endpoints on specified VPC networks and reconciles Private Service Connect
        /// connectivity infrastructure for the instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> ReconcileNetworkingAsync(SqlInstancesReconcileNetworkingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SqlInstancesReconcileNetworkingRequest(ref request, ref callSettings);
            return _callReconcileNetworking.Async(request, callSettings);
        }
    }

    public partial class SqlInstancesListRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class InstancesListResponse : gaxgrpc::IPageResponse<ApiWarning>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApiWarning> GetEnumerator() => Warnings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SqlInstancesService
    {
        public partial class SqlInstancesServiceClient
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
