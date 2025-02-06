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

namespace Google.Cloud.VMMigration.V1
{
    /// <summary>Settings for <see cref="VmMigrationClient"/> instances.</summary>
    public sealed partial class VmMigrationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VmMigrationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VmMigrationSettings"/>.</returns>
        public static VmMigrationSettings GetDefault() => new VmMigrationSettings();

        /// <summary>Constructs a new <see cref="VmMigrationSettings"/> object with default settings.</summary>
        public VmMigrationSettings()
        {
        }

        private VmMigrationSettings(VmMigrationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSourcesSettings = existing.ListSourcesSettings;
            GetSourceSettings = existing.GetSourceSettings;
            CreateSourceSettings = existing.CreateSourceSettings;
            CreateSourceOperationsSettings = existing.CreateSourceOperationsSettings.Clone();
            UpdateSourceSettings = existing.UpdateSourceSettings;
            UpdateSourceOperationsSettings = existing.UpdateSourceOperationsSettings.Clone();
            DeleteSourceSettings = existing.DeleteSourceSettings;
            DeleteSourceOperationsSettings = existing.DeleteSourceOperationsSettings.Clone();
            FetchInventorySettings = existing.FetchInventorySettings;
            ListUtilizationReportsSettings = existing.ListUtilizationReportsSettings;
            GetUtilizationReportSettings = existing.GetUtilizationReportSettings;
            CreateUtilizationReportSettings = existing.CreateUtilizationReportSettings;
            CreateUtilizationReportOperationsSettings = existing.CreateUtilizationReportOperationsSettings.Clone();
            DeleteUtilizationReportSettings = existing.DeleteUtilizationReportSettings;
            DeleteUtilizationReportOperationsSettings = existing.DeleteUtilizationReportOperationsSettings.Clone();
            ListDatacenterConnectorsSettings = existing.ListDatacenterConnectorsSettings;
            GetDatacenterConnectorSettings = existing.GetDatacenterConnectorSettings;
            CreateDatacenterConnectorSettings = existing.CreateDatacenterConnectorSettings;
            CreateDatacenterConnectorOperationsSettings = existing.CreateDatacenterConnectorOperationsSettings.Clone();
            DeleteDatacenterConnectorSettings = existing.DeleteDatacenterConnectorSettings;
            DeleteDatacenterConnectorOperationsSettings = existing.DeleteDatacenterConnectorOperationsSettings.Clone();
            UpgradeApplianceSettings = existing.UpgradeApplianceSettings;
            UpgradeApplianceOperationsSettings = existing.UpgradeApplianceOperationsSettings.Clone();
            CreateMigratingVmSettings = existing.CreateMigratingVmSettings;
            CreateMigratingVmOperationsSettings = existing.CreateMigratingVmOperationsSettings.Clone();
            ListMigratingVmsSettings = existing.ListMigratingVmsSettings;
            GetMigratingVmSettings = existing.GetMigratingVmSettings;
            UpdateMigratingVmSettings = existing.UpdateMigratingVmSettings;
            UpdateMigratingVmOperationsSettings = existing.UpdateMigratingVmOperationsSettings.Clone();
            DeleteMigratingVmSettings = existing.DeleteMigratingVmSettings;
            DeleteMigratingVmOperationsSettings = existing.DeleteMigratingVmOperationsSettings.Clone();
            StartMigrationSettings = existing.StartMigrationSettings;
            StartMigrationOperationsSettings = existing.StartMigrationOperationsSettings.Clone();
            ResumeMigrationSettings = existing.ResumeMigrationSettings;
            ResumeMigrationOperationsSettings = existing.ResumeMigrationOperationsSettings.Clone();
            PauseMigrationSettings = existing.PauseMigrationSettings;
            PauseMigrationOperationsSettings = existing.PauseMigrationOperationsSettings.Clone();
            FinalizeMigrationSettings = existing.FinalizeMigrationSettings;
            FinalizeMigrationOperationsSettings = existing.FinalizeMigrationOperationsSettings.Clone();
            CreateCloneJobSettings = existing.CreateCloneJobSettings;
            CreateCloneJobOperationsSettings = existing.CreateCloneJobOperationsSettings.Clone();
            CancelCloneJobSettings = existing.CancelCloneJobSettings;
            CancelCloneJobOperationsSettings = existing.CancelCloneJobOperationsSettings.Clone();
            ListCloneJobsSettings = existing.ListCloneJobsSettings;
            GetCloneJobSettings = existing.GetCloneJobSettings;
            CreateCutoverJobSettings = existing.CreateCutoverJobSettings;
            CreateCutoverJobOperationsSettings = existing.CreateCutoverJobOperationsSettings.Clone();
            CancelCutoverJobSettings = existing.CancelCutoverJobSettings;
            CancelCutoverJobOperationsSettings = existing.CancelCutoverJobOperationsSettings.Clone();
            ListCutoverJobsSettings = existing.ListCutoverJobsSettings;
            GetCutoverJobSettings = existing.GetCutoverJobSettings;
            ListGroupsSettings = existing.ListGroupsSettings;
            GetGroupSettings = existing.GetGroupSettings;
            CreateGroupSettings = existing.CreateGroupSettings;
            CreateGroupOperationsSettings = existing.CreateGroupOperationsSettings.Clone();
            UpdateGroupSettings = existing.UpdateGroupSettings;
            UpdateGroupOperationsSettings = existing.UpdateGroupOperationsSettings.Clone();
            DeleteGroupSettings = existing.DeleteGroupSettings;
            DeleteGroupOperationsSettings = existing.DeleteGroupOperationsSettings.Clone();
            AddGroupMigrationSettings = existing.AddGroupMigrationSettings;
            AddGroupMigrationOperationsSettings = existing.AddGroupMigrationOperationsSettings.Clone();
            RemoveGroupMigrationSettings = existing.RemoveGroupMigrationSettings;
            RemoveGroupMigrationOperationsSettings = existing.RemoveGroupMigrationOperationsSettings.Clone();
            ListTargetProjectsSettings = existing.ListTargetProjectsSettings;
            GetTargetProjectSettings = existing.GetTargetProjectSettings;
            CreateTargetProjectSettings = existing.CreateTargetProjectSettings;
            CreateTargetProjectOperationsSettings = existing.CreateTargetProjectOperationsSettings.Clone();
            UpdateTargetProjectSettings = existing.UpdateTargetProjectSettings;
            UpdateTargetProjectOperationsSettings = existing.UpdateTargetProjectOperationsSettings.Clone();
            DeleteTargetProjectSettings = existing.DeleteTargetProjectSettings;
            DeleteTargetProjectOperationsSettings = existing.DeleteTargetProjectOperationsSettings.Clone();
            ListReplicationCyclesSettings = existing.ListReplicationCyclesSettings;
            GetReplicationCycleSettings = existing.GetReplicationCycleSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VmMigrationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListSources</c> and <c>VmMigrationClient.ListSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VmMigrationClient.GetSource</c>
        ///  and <c>VmMigrationClient.GetSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateSource</c> and <c>VmMigrationClient.CreateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 900 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(900000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateSource</c> and
        /// <c>VmMigrationClient.CreateSourceAsync</c>.
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
        public lro::OperationsSettings CreateSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.UpdateSource</c> and <c>VmMigrationClient.UpdateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.UpdateSource</c> and
        /// <c>VmMigrationClient.UpdateSourceAsync</c>.
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
        public lro::OperationsSettings UpdateSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteSource</c> and <c>VmMigrationClient.DeleteSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteSource</c> and
        /// <c>VmMigrationClient.DeleteSourceAsync</c>.
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
        public lro::OperationsSettings DeleteSourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.FetchInventory</c> and <c>VmMigrationClient.FetchInventoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchInventorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListUtilizationReports</c> and <c>VmMigrationClient.ListUtilizationReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUtilizationReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetUtilizationReport</c> and <c>VmMigrationClient.GetUtilizationReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUtilizationReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateUtilizationReport</c> and <c>VmMigrationClient.CreateUtilizationReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUtilizationReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateUtilizationReport</c> and
        /// <c>VmMigrationClient.CreateUtilizationReportAsync</c>.
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
        public lro::OperationsSettings CreateUtilizationReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteUtilizationReport</c> and <c>VmMigrationClient.DeleteUtilizationReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUtilizationReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteUtilizationReport</c> and
        /// <c>VmMigrationClient.DeleteUtilizationReportAsync</c>.
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
        public lro::OperationsSettings DeleteUtilizationReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListDatacenterConnectors</c> and <c>VmMigrationClient.ListDatacenterConnectorsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatacenterConnectorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetDatacenterConnector</c> and <c>VmMigrationClient.GetDatacenterConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatacenterConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateDatacenterConnector</c> and <c>VmMigrationClient.CreateDatacenterConnectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatacenterConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateDatacenterConnector</c> and
        /// <c>VmMigrationClient.CreateDatacenterConnectorAsync</c>.
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
        public lro::OperationsSettings CreateDatacenterConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteDatacenterConnector</c> and <c>VmMigrationClient.DeleteDatacenterConnectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatacenterConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteDatacenterConnector</c> and
        /// <c>VmMigrationClient.DeleteDatacenterConnectorAsync</c>.
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
        public lro::OperationsSettings DeleteDatacenterConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.UpgradeAppliance</c> and <c>VmMigrationClient.UpgradeApplianceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeApplianceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.UpgradeAppliance</c> and
        /// <c>VmMigrationClient.UpgradeApplianceAsync</c>.
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
        public lro::OperationsSettings UpgradeApplianceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateMigratingVm</c> and <c>VmMigrationClient.CreateMigratingVmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMigratingVmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateMigratingVm</c> and
        /// <c>VmMigrationClient.CreateMigratingVmAsync</c>.
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
        public lro::OperationsSettings CreateMigratingVmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListMigratingVms</c> and <c>VmMigrationClient.ListMigratingVmsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMigratingVmsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetMigratingVm</c> and <c>VmMigrationClient.GetMigratingVmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMigratingVmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.UpdateMigratingVm</c> and <c>VmMigrationClient.UpdateMigratingVmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMigratingVmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.UpdateMigratingVm</c> and
        /// <c>VmMigrationClient.UpdateMigratingVmAsync</c>.
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
        public lro::OperationsSettings UpdateMigratingVmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteMigratingVm</c> and <c>VmMigrationClient.DeleteMigratingVmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMigratingVmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteMigratingVm</c> and
        /// <c>VmMigrationClient.DeleteMigratingVmAsync</c>.
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
        public lro::OperationsSettings DeleteMigratingVmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.StartMigration</c> and <c>VmMigrationClient.StartMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.StartMigration</c> and
        /// <c>VmMigrationClient.StartMigrationAsync</c>.
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
        /// <c>VmMigrationClient.ResumeMigration</c> and <c>VmMigrationClient.ResumeMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.ResumeMigration</c> and
        /// <c>VmMigrationClient.ResumeMigrationAsync</c>.
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
        public lro::OperationsSettings ResumeMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.PauseMigration</c> and <c>VmMigrationClient.PauseMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.PauseMigration</c> and
        /// <c>VmMigrationClient.PauseMigrationAsync</c>.
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
        public lro::OperationsSettings PauseMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.FinalizeMigration</c> and <c>VmMigrationClient.FinalizeMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinalizeMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.FinalizeMigration</c> and
        /// <c>VmMigrationClient.FinalizeMigrationAsync</c>.
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
        public lro::OperationsSettings FinalizeMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateCloneJob</c> and <c>VmMigrationClient.CreateCloneJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCloneJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateCloneJob</c> and
        /// <c>VmMigrationClient.CreateCloneJobAsync</c>.
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
        public lro::OperationsSettings CreateCloneJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CancelCloneJob</c> and <c>VmMigrationClient.CancelCloneJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelCloneJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CancelCloneJob</c> and
        /// <c>VmMigrationClient.CancelCloneJobAsync</c>.
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
        public lro::OperationsSettings CancelCloneJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListCloneJobs</c> and <c>VmMigrationClient.ListCloneJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCloneJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetCloneJob</c> and <c>VmMigrationClient.GetCloneJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCloneJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateCutoverJob</c> and <c>VmMigrationClient.CreateCutoverJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCutoverJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateCutoverJob</c> and
        /// <c>VmMigrationClient.CreateCutoverJobAsync</c>.
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
        public lro::OperationsSettings CreateCutoverJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CancelCutoverJob</c> and <c>VmMigrationClient.CancelCutoverJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelCutoverJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CancelCutoverJob</c> and
        /// <c>VmMigrationClient.CancelCutoverJobAsync</c>.
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
        public lro::OperationsSettings CancelCutoverJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListCutoverJobs</c> and <c>VmMigrationClient.ListCutoverJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCutoverJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetCutoverJob</c> and <c>VmMigrationClient.GetCutoverJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCutoverJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListGroups</c> and <c>VmMigrationClient.ListGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VmMigrationClient.GetGroup</c>
        ///  and <c>VmMigrationClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateGroup</c> and <c>VmMigrationClient.CreateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateGroup</c> and
        /// <c>VmMigrationClient.CreateGroupAsync</c>.
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
        public lro::OperationsSettings CreateGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.UpdateGroup</c> and <c>VmMigrationClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.UpdateGroup</c> and
        /// <c>VmMigrationClient.UpdateGroupAsync</c>.
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
        public lro::OperationsSettings UpdateGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteGroup</c> and <c>VmMigrationClient.DeleteGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteGroup</c> and
        /// <c>VmMigrationClient.DeleteGroupAsync</c>.
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
        public lro::OperationsSettings DeleteGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.AddGroupMigration</c> and <c>VmMigrationClient.AddGroupMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddGroupMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.AddGroupMigration</c> and
        /// <c>VmMigrationClient.AddGroupMigrationAsync</c>.
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
        public lro::OperationsSettings AddGroupMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.RemoveGroupMigration</c> and <c>VmMigrationClient.RemoveGroupMigrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveGroupMigrationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.RemoveGroupMigration</c> and
        /// <c>VmMigrationClient.RemoveGroupMigrationAsync</c>.
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
        public lro::OperationsSettings RemoveGroupMigrationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListTargetProjects</c> and <c>VmMigrationClient.ListTargetProjectsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTargetProjectsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetTargetProject</c> and <c>VmMigrationClient.GetTargetProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTargetProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.CreateTargetProject</c> and <c>VmMigrationClient.CreateTargetProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTargetProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.CreateTargetProject</c> and
        /// <c>VmMigrationClient.CreateTargetProjectAsync</c>.
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
        public lro::OperationsSettings CreateTargetProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.UpdateTargetProject</c> and <c>VmMigrationClient.UpdateTargetProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTargetProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.UpdateTargetProject</c> and
        /// <c>VmMigrationClient.UpdateTargetProjectAsync</c>.
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
        public lro::OperationsSettings UpdateTargetProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.DeleteTargetProject</c> and <c>VmMigrationClient.DeleteTargetProjectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTargetProjectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VmMigrationClient.DeleteTargetProject</c> and
        /// <c>VmMigrationClient.DeleteTargetProjectAsync</c>.
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
        public lro::OperationsSettings DeleteTargetProjectOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.ListReplicationCycles</c> and <c>VmMigrationClient.ListReplicationCyclesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReplicationCyclesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VmMigrationClient.GetReplicationCycle</c> and <c>VmMigrationClient.GetReplicationCycleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReplicationCycleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VmMigrationSettings"/> object.</returns>
        public VmMigrationSettings Clone() => new VmMigrationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VmMigrationClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VmMigrationClientBuilder : gaxgrpc::ClientBuilderBase<VmMigrationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VmMigrationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VmMigrationClientBuilder() : base(VmMigrationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VmMigrationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VmMigrationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VmMigrationClient Build()
        {
            VmMigrationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VmMigrationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VmMigrationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VmMigrationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VmMigrationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VmMigrationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VmMigrationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VmMigrationClient.ChannelPool;
    }

    /// <summary>VmMigration client wrapper, for convenient use.</summary>
    /// <remarks>
    /// VM Migration Service
    /// </remarks>
    public abstract partial class VmMigrationClient
    {
        /// <summary>
        /// The default endpoint for the VmMigration service, which is a host of "vmmigration.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vmmigration.googleapis.com:443";

        /// <summary>The default VmMigration scopes.</summary>
        /// <remarks>
        /// The default VmMigration scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VmMigration.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VmMigrationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VmMigrationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VmMigrationClient"/>.</returns>
        public static stt::Task<VmMigrationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VmMigrationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VmMigrationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VmMigrationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VmMigrationClient"/>.</returns>
        public static VmMigrationClient Create() => new VmMigrationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VmMigrationClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VmMigrationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VmMigrationClient"/>.</returns>
        internal static VmMigrationClient Create(grpccore::CallInvoker callInvoker, VmMigrationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VmMigration.VmMigrationClient grpcClient = new VmMigration.VmMigrationClient(callInvoker);
            return new VmMigrationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VmMigration client</summary>
        public virtual VmMigration.VmMigrationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sources.
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
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
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
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
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
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sources.
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
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
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
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of sources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
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
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, st::CancellationToken cancellationToken) =>
            GetSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> CreateSource(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(CreateSourceRequest request, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSource</c>.</summary>
        public virtual lro::OperationsClient CreateSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Source, OperationMetadata> PollOnceCreateSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Source, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> PollOnceCreateSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Source, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSourceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> CreateSource(string parent, Source source, string sourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSource(new CreateSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(string parent, Source source, string sourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSourceAsync(new CreateSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(string parent, Source source, string sourceId, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, sourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> CreateSource(gagr::LocationName parent, Source source, string sourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSource(new CreateSourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(gagr::LocationName parent, Source source, string sourceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSourceAsync(new CreateSourceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Source's parent.
        /// </param>
        /// <param name="source">
        /// Required. The create request body.
        /// </param>
        /// <param name="sourceId">
        /// Required. The source identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(gagr::LocationName parent, Source source, string sourceId, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, sourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> UpdateSource(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(UpdateSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSource</c>.</summary>
        public virtual lro::OperationsClient UpdateSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Source, OperationMetadata> PollOnceUpdateSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Source, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> PollOnceUpdateSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Source, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSourceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="source">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Source resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> UpdateSource(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSource(new UpdateSourceRequest
            {
                UpdateMask = updateMask,
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="source">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Source resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSourceAsync(new UpdateSourceRequest
            {
                UpdateMask = updateMask,
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="source">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Source resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSourceAsync(source, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(DeleteSourceRequest request, st::CancellationToken cancellationToken) =>
            DeleteSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSource</c>.</summary>
        public virtual lro::OperationsClient DeleteSourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSourceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSource(new DeleteSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSourceAsync(new DeleteSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSource(new DeleteSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSourceAsync(new DeleteSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="name">
        /// Required. The Source name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(SourceName name, st::CancellationToken cancellationToken) =>
            DeleteSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchInventoryResponse FetchInventory(FetchInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(FetchInventoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(FetchInventoryRequest request, st::CancellationToken cancellationToken) =>
            FetchInventoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchInventoryResponse FetchInventory(string source, gaxgrpc::CallSettings callSettings = null) =>
            FetchInventory(new FetchInventoryRequest
            {
                Source = gax::GaxPreconditions.CheckNotNullOrEmpty(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(string source, gaxgrpc::CallSettings callSettings = null) =>
            FetchInventoryAsync(new FetchInventoryRequest
            {
                Source = gax::GaxPreconditions.CheckNotNullOrEmpty(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(string source, st::CancellationToken cancellationToken) =>
            FetchInventoryAsync(source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchInventoryResponse FetchInventory(SourceName source, gaxgrpc::CallSettings callSettings = null) =>
            FetchInventory(new FetchInventoryRequest
            {
                SourceAsSourceName = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(SourceName source, gaxgrpc::CallSettings callSettings = null) =>
            FetchInventoryAsync(new FetchInventoryRequest
            {
                SourceAsSourceName = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="source">
        /// Required. The name of the Source.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchInventoryResponse> FetchInventoryAsync(SourceName source, st::CancellationToken cancellationToken) =>
            FetchInventoryAsync(source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReports(ListUtilizationReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReportsAsync(ListUtilizationReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Reports parent.
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
        /// <returns>A pageable sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
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
            return ListUtilizationReports(request, callSettings);
        }

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Reports parent.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
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
            return ListUtilizationReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Reports parent.
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
        /// <returns>A pageable sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReports(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUtilizationReports(request, callSettings);
        }

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Reports parent.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UtilizationReport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReportsAsync(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUtilizationReportsRequest request = new ListUtilizationReportsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUtilizationReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UtilizationReport GetUtilizationReport(GetUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(GetUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(GetUtilizationReportRequest request, st::CancellationToken cancellationToken) =>
            GetUtilizationReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UtilizationReport GetUtilizationReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUtilizationReport(new GetUtilizationReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUtilizationReportAsync(new GetUtilizationReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetUtilizationReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UtilizationReport GetUtilizationReport(UtilizationReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUtilizationReport(new GetUtilizationReportRequest
            {
                UtilizationReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(UtilizationReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUtilizationReportAsync(new GetUtilizationReportRequest
            {
                UtilizationReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UtilizationReport> GetUtilizationReportAsync(UtilizationReportName name, st::CancellationToken cancellationToken) =>
            GetUtilizationReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UtilizationReport, OperationMetadata> CreateUtilizationReport(CreateUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(CreateUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(CreateUtilizationReportRequest request, st::CancellationToken cancellationToken) =>
            CreateUtilizationReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateUtilizationReport</c>.</summary>
        public virtual lro::OperationsClient CreateUtilizationReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateUtilizationReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UtilizationReport, OperationMetadata> PollOnceCreateUtilizationReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UtilizationReport, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUtilizationReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateUtilizationReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> PollOnceCreateUtilizationReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UtilizationReport, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateUtilizationReportOperationsClient, callSettings);

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UtilizationReport, OperationMetadata> CreateUtilizationReport(string parent, UtilizationReport utilizationReport, string utilizationReportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUtilizationReport(new CreateUtilizationReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UtilizationReport = gax::GaxPreconditions.CheckNotNull(utilizationReport, nameof(utilizationReport)),
                UtilizationReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)),
            }, callSettings);

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(string parent, UtilizationReport utilizationReport, string utilizationReportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUtilizationReportAsync(new CreateUtilizationReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UtilizationReport = gax::GaxPreconditions.CheckNotNull(utilizationReport, nameof(utilizationReport)),
                UtilizationReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)),
            }, callSettings);

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(string parent, UtilizationReport utilizationReport, string utilizationReportId, st::CancellationToken cancellationToken) =>
            CreateUtilizationReportAsync(parent, utilizationReport, utilizationReportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UtilizationReport, OperationMetadata> CreateUtilizationReport(SourceName parent, UtilizationReport utilizationReport, string utilizationReportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUtilizationReport(new CreateUtilizationReportRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UtilizationReport = gax::GaxPreconditions.CheckNotNull(utilizationReport, nameof(utilizationReport)),
                UtilizationReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)),
            }, callSettings);

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(SourceName parent, UtilizationReport utilizationReport, string utilizationReportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateUtilizationReportAsync(new CreateUtilizationReportRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UtilizationReport = gax::GaxPreconditions.CheckNotNull(utilizationReport, nameof(utilizationReport)),
                UtilizationReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(utilizationReportId, nameof(utilizationReportId)),
            }, callSettings);

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="parent">
        /// Required. The Utilization Report's parent.
        /// </param>
        /// <param name="utilizationReport">
        /// Required. The report to create.
        /// </param>
        /// <param name="utilizationReportId">
        /// Required. The ID to use for the report, which will become the final
        /// component of the reports's resource name.
        /// 
        /// This value maximum length is 63 characters, and valid characters
        /// are /[a-z][0-9]-/. It must start with an english letter and must not
        /// end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(SourceName parent, UtilizationReport utilizationReport, string utilizationReportId, st::CancellationToken cancellationToken) =>
            CreateUtilizationReportAsync(parent, utilizationReport, utilizationReportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUtilizationReport(DeleteUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(DeleteUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(DeleteUtilizationReportRequest request, st::CancellationToken cancellationToken) =>
            DeleteUtilizationReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteUtilizationReport</c>.</summary>
        public virtual lro::OperationsClient DeleteUtilizationReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteUtilizationReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteUtilizationReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUtilizationReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteUtilizationReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteUtilizationReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteUtilizationReportOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUtilizationReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUtilizationReport(new DeleteUtilizationReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUtilizationReportAsync(new DeleteUtilizationReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUtilizationReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteUtilizationReport(UtilizationReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUtilizationReport(new DeleteUtilizationReportRequest
            {
                UtilizationReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(UtilizationReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUtilizationReportAsync(new DeleteUtilizationReportRequest
            {
                UtilizationReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="name">
        /// Required. The Utilization Report name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(UtilizationReportName name, st::CancellationToken cancellationToken) =>
            DeleteUtilizationReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectors(ListDatacenterConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectorsAsync(ListDatacenterConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connectors.
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
        /// <returns>A pageable sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
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
            return ListDatacenterConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connectors.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
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
            return ListDatacenterConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connectors.
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
        /// <returns>A pageable sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectors(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatacenterConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of connectors.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectorsAsync(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatacenterConnectorsRequest request = new ListDatacenterConnectorsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatacenterConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatacenterConnector GetDatacenterConnector(GetDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(GetDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(GetDatacenterConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetDatacenterConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatacenterConnector GetDatacenterConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatacenterConnector(new GetDatacenterConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatacenterConnectorAsync(new GetDatacenterConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatacenterConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatacenterConnector GetDatacenterConnector(DatacenterConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatacenterConnector(new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(DatacenterConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatacenterConnectorAsync(new GetDatacenterConnectorRequest
            {
                DatacenterConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DatacenterConnector.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(DatacenterConnectorName name, st::CancellationToken cancellationToken) =>
            GetDatacenterConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatacenterConnector, OperationMetadata> CreateDatacenterConnector(CreateDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(CreateDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(CreateDatacenterConnectorRequest request, st::CancellationToken cancellationToken) =>
            CreateDatacenterConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDatacenterConnector</c>.</summary>
        public virtual lro::OperationsClient CreateDatacenterConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDatacenterConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DatacenterConnector, OperationMetadata> PollOnceCreateDatacenterConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatacenterConnector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatacenterConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDatacenterConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> PollOnceCreateDatacenterConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatacenterConnector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatacenterConnectorOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatacenterConnector, OperationMetadata> CreateDatacenterConnector(string parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatacenterConnector(new CreateDatacenterConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatacenterConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)),
                DatacenterConnector = gax::GaxPreconditions.CheckNotNull(datacenterConnector, nameof(datacenterConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(string parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatacenterConnectorAsync(new CreateDatacenterConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatacenterConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)),
                DatacenterConnector = gax::GaxPreconditions.CheckNotNull(datacenterConnector, nameof(datacenterConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(string parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, st::CancellationToken cancellationToken) =>
            CreateDatacenterConnectorAsync(parent, datacenterConnector, datacenterConnectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatacenterConnector, OperationMetadata> CreateDatacenterConnector(SourceName parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatacenterConnector(new CreateDatacenterConnectorRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatacenterConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)),
                DatacenterConnector = gax::GaxPreconditions.CheckNotNull(datacenterConnector, nameof(datacenterConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(SourceName parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatacenterConnectorAsync(new CreateDatacenterConnectorRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatacenterConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(datacenterConnectorId, nameof(datacenterConnectorId)),
                DatacenterConnector = gax::GaxPreconditions.CheckNotNull(datacenterConnector, nameof(datacenterConnector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The DatacenterConnector's parent.
        /// Required. The Source in where the new DatacenterConnector will be created.
        /// For example:
        /// `projects/my-project/locations/us-central1/sources/my-source`
        /// </param>
        /// <param name="datacenterConnector">
        /// Required. The create request body.
        /// </param>
        /// <param name="datacenterConnectorId">
        /// Required. The datacenterConnector identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(SourceName parent, DatacenterConnector datacenterConnector, string datacenterConnectorId, st::CancellationToken cancellationToken) =>
            CreateDatacenterConnectorAsync(parent, datacenterConnector, datacenterConnectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatacenterConnector(DeleteDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(DeleteDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(DeleteDatacenterConnectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatacenterConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDatacenterConnector</c>.</summary>
        public virtual lro::OperationsClient DeleteDatacenterConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDatacenterConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDatacenterConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatacenterConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDatacenterConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDatacenterConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatacenterConnectorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatacenterConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatacenterConnector(new DeleteDatacenterConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatacenterConnectorAsync(new DeleteDatacenterConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatacenterConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatacenterConnector(DatacenterConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatacenterConnector(new DeleteDatacenterConnectorRequest
            {
                DatacenterConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(DatacenterConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatacenterConnectorAsync(new DeleteDatacenterConnectorRequest
            {
                DatacenterConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="name">
        /// Required. The DatacenterConnector name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(DatacenterConnectorName name, st::CancellationToken cancellationToken) =>
            DeleteDatacenterConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades the appliance relate to this DatacenterConnector to the in-place
        /// updateable version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UpgradeApplianceResponse, OperationMetadata> UpgradeAppliance(UpgradeApplianceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades the appliance relate to this DatacenterConnector to the in-place
        /// updateable version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeApplianceResponse, OperationMetadata>> UpgradeApplianceAsync(UpgradeApplianceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades the appliance relate to this DatacenterConnector to the in-place
        /// updateable version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UpgradeApplianceResponse, OperationMetadata>> UpgradeApplianceAsync(UpgradeApplianceRequest request, st::CancellationToken cancellationToken) =>
            UpgradeApplianceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeAppliance</c>.</summary>
        public virtual lro::OperationsClient UpgradeApplianceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpgradeAppliance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UpgradeApplianceResponse, OperationMetadata> PollOnceUpgradeAppliance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeApplianceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeApplianceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeAppliance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UpgradeApplianceResponse, OperationMetadata>> PollOnceUpgradeApplianceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UpgradeApplianceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeApplianceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> CreateMigratingVm(CreateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(CreateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(CreateMigratingVmRequest request, st::CancellationToken cancellationToken) =>
            CreateMigratingVmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMigratingVm</c>.</summary>
        public virtual lro::OperationsClient CreateMigratingVmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateMigratingVm</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> PollOnceCreateMigratingVm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigratingVm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMigratingVm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> PollOnceCreateMigratingVmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigratingVm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> CreateMigratingVm(string parent, MigratingVm migratingVm, string migratingVmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigratingVm(new CreateMigratingVmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigratingVmId = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)),
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(string parent, MigratingVm migratingVm, string migratingVmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigratingVmAsync(new CreateMigratingVmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MigratingVmId = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)),
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(string parent, MigratingVm migratingVm, string migratingVmId, st::CancellationToken cancellationToken) =>
            CreateMigratingVmAsync(parent, migratingVm, migratingVmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> CreateMigratingVm(SourceName parent, MigratingVm migratingVm, string migratingVmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigratingVm(new CreateMigratingVmRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigratingVmId = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)),
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(SourceName parent, MigratingVm migratingVm, string migratingVmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMigratingVmAsync(new CreateMigratingVmRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MigratingVmId = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVmId, nameof(migratingVmId)),
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The MigratingVm's parent.
        /// </param>
        /// <param name="migratingVm">
        /// Required. The create request body.
        /// </param>
        /// <param name="migratingVmId">
        /// Required. The migratingVm identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(SourceName parent, MigratingVm migratingVm, string migratingVmId, st::CancellationToken cancellationToken) =>
            CreateMigratingVmAsync(parent, migratingVm, migratingVmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVms(ListMigratingVmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVmsAsync(ListMigratingVmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MigratingVms.
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
        /// <returns>A pageable sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
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
            return ListMigratingVms(request, callSettings);
        }

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MigratingVms.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVmsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
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
            return ListMigratingVmsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MigratingVms.
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
        /// <returns>A pageable sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVms(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMigratingVms(request, callSettings);
        }

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of MigratingVms.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MigratingVm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVmsAsync(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMigratingVmsRequest request = new ListMigratingVmsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMigratingVmsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigratingVm GetMigratingVm(GetMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(GetMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(GetMigratingVmRequest request, st::CancellationToken cancellationToken) =>
            GetMigratingVmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigratingVm GetMigratingVm(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigratingVm(new GetMigratingVmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigratingVmAsync(new GetMigratingVmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(string name, st::CancellationToken cancellationToken) =>
            GetMigratingVmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MigratingVm GetMigratingVm(MigratingVmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigratingVm(new GetMigratingVmRequest
            {
                MigratingVmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(MigratingVmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMigratingVmAsync(new GetMigratingVmRequest
            {
                MigratingVmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MigratingVm> GetMigratingVmAsync(MigratingVmName name, st::CancellationToken cancellationToken) =>
            GetMigratingVmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> UpdateMigratingVm(UpdateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> UpdateMigratingVmAsync(UpdateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> UpdateMigratingVmAsync(UpdateMigratingVmRequest request, st::CancellationToken cancellationToken) =>
            UpdateMigratingVmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMigratingVm</c>.</summary>
        public virtual lro::OperationsClient UpdateMigratingVmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateMigratingVm</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> PollOnceUpdateMigratingVm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigratingVm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMigratingVm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> PollOnceUpdateMigratingVmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MigratingVm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// MigratingVm resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MigratingVm, OperationMetadata> UpdateMigratingVm(MigratingVm migratingVm, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigratingVm(new UpdateMigratingVmRequest
            {
                UpdateMask = updateMask,
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// MigratingVm resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> UpdateMigratingVmAsync(MigratingVm migratingVm, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMigratingVmAsync(new UpdateMigratingVmRequest
            {
                UpdateMask = updateMask,
                MigratingVm = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// MigratingVm resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MigratingVm, OperationMetadata>> UpdateMigratingVmAsync(MigratingVm migratingVm, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMigratingVmAsync(migratingVm, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigratingVm(DeleteMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(DeleteMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(DeleteMigratingVmRequest request, st::CancellationToken cancellationToken) =>
            DeleteMigratingVmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMigratingVm</c>.</summary>
        public virtual lro::OperationsClient DeleteMigratingVmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteMigratingVm</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMigratingVm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMigratingVm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMigratingVmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMigratingVmOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigratingVm(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigratingVm(new DeleteMigratingVmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigratingVmAsync(new DeleteMigratingVmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMigratingVmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMigratingVm(MigratingVmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigratingVm(new DeleteMigratingVmRequest
            {
                MigratingVmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(MigratingVmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMigratingVmAsync(new DeleteMigratingVmRequest
            {
                MigratingVmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(MigratingVmName name, st::CancellationToken cancellationToken) =>
            DeleteMigratingVmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartMigrationResponse, OperationMetadata> StartMigration(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<StartMigrationResponse, OperationMetadata> PollOnceStartMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> PollOnceStartMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StartMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartMigrationOperationsClient, callSettings);

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartMigrationResponse, OperationMetadata> StartMigration(string migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            StartMigration(new StartMigrationRequest
            {
                MigratingVm = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(string migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationAsync(new StartMigrationRequest
            {
                MigratingVm = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(string migratingVm, st::CancellationToken cancellationToken) =>
            StartMigrationAsync(migratingVm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StartMigrationResponse, OperationMetadata> StartMigration(MigratingVmName migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            StartMigration(new StartMigrationRequest
            {
                MigratingVmAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(MigratingVmName migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            StartMigrationAsync(new StartMigrationRequest
            {
                MigratingVmAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(MigratingVmName migratingVm, st::CancellationToken cancellationToken) =>
            StartMigrationAsync(migratingVm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a migration for a VM. When called on a paused migration, will start
        /// the process of uploading data and creating snapshots; when called on a
        /// completed cut-over migration, will update the migration to active state and
        /// start the process of uploading data and creating snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResumeMigrationResponse, OperationMetadata> ResumeMigration(ResumeMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a migration for a VM. When called on a paused migration, will start
        /// the process of uploading data and creating snapshots; when called on a
        /// completed cut-over migration, will update the migration to active state and
        /// start the process of uploading data and creating snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResumeMigrationResponse, OperationMetadata>> ResumeMigrationAsync(ResumeMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a migration for a VM. When called on a paused migration, will start
        /// the process of uploading data and creating snapshots; when called on a
        /// completed cut-over migration, will update the migration to active state and
        /// start the process of uploading data and creating snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResumeMigrationResponse, OperationMetadata>> ResumeMigrationAsync(ResumeMigrationRequest request, st::CancellationToken cancellationToken) =>
            ResumeMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeMigration</c>.</summary>
        public virtual lro::OperationsClient ResumeMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResumeMigrationResponse, OperationMetadata> PollOnceResumeMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResumeMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResumeMigrationResponse, OperationMetadata>> PollOnceResumeMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResumeMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeMigrationOperationsClient, callSettings);

        /// <summary>
        /// Pauses a migration for a VM. If cycle tasks are running they will be
        /// cancelled, preserving source task data. Further replication cycles will not
        /// be triggered while the VM is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PauseMigrationResponse, OperationMetadata> PauseMigration(PauseMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a migration for a VM. If cycle tasks are running they will be
        /// cancelled, preserving source task data. Further replication cycles will not
        /// be triggered while the VM is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PauseMigrationResponse, OperationMetadata>> PauseMigrationAsync(PauseMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a migration for a VM. If cycle tasks are running they will be
        /// cancelled, preserving source task data. Further replication cycles will not
        /// be triggered while the VM is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PauseMigrationResponse, OperationMetadata>> PauseMigrationAsync(PauseMigrationRequest request, st::CancellationToken cancellationToken) =>
            PauseMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PauseMigration</c>.</summary>
        public virtual lro::OperationsClient PauseMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PauseMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PauseMigrationResponse, OperationMetadata> PollOncePauseMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PauseMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PauseMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PauseMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PauseMigrationResponse, OperationMetadata>> PollOncePauseMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PauseMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PauseMigrationOperationsClient, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FinalizeMigrationResponse, OperationMetadata> FinalizeMigration(FinalizeMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(FinalizeMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(FinalizeMigrationRequest request, st::CancellationToken cancellationToken) =>
            FinalizeMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FinalizeMigration</c>.</summary>
        public virtual lro::OperationsClient FinalizeMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>FinalizeMigration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FinalizeMigrationResponse, OperationMetadata> PollOnceFinalizeMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FinalizeMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FinalizeMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FinalizeMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> PollOnceFinalizeMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FinalizeMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FinalizeMigrationOperationsClient, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FinalizeMigrationResponse, OperationMetadata> FinalizeMigration(string migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeMigration(new FinalizeMigrationRequest
            {
                MigratingVm = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(string migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeMigrationAsync(new FinalizeMigrationRequest
            {
                MigratingVm = gax::GaxPreconditions.CheckNotNullOrEmpty(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(string migratingVm, st::CancellationToken cancellationToken) =>
            FinalizeMigrationAsync(migratingVm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FinalizeMigrationResponse, OperationMetadata> FinalizeMigration(MigratingVmName migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeMigration(new FinalizeMigrationRequest
            {
                MigratingVmAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(MigratingVmName migratingVm, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeMigrationAsync(new FinalizeMigrationRequest
            {
                MigratingVmAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(migratingVm, nameof(migratingVm)),
            }, callSettings);

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="migratingVm">
        /// Required. The name of the MigratingVm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(MigratingVmName migratingVm, st::CancellationToken cancellationToken) =>
            FinalizeMigrationAsync(migratingVm, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloneJob, OperationMetadata> CreateCloneJob(CreateCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(CreateCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(CreateCloneJobRequest request, st::CancellationToken cancellationToken) =>
            CreateCloneJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCloneJob</c>.</summary>
        public virtual lro::OperationsClient CreateCloneJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCloneJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CloneJob, OperationMetadata> PollOnceCreateCloneJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloneJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloneJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCloneJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> PollOnceCreateCloneJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloneJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCloneJobOperationsClient, callSettings);

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloneJob, OperationMetadata> CreateCloneJob(string parent, CloneJob cloneJob, string cloneJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloneJob(new CreateCloneJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloneJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)),
                CloneJob = gax::GaxPreconditions.CheckNotNull(cloneJob, nameof(cloneJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(string parent, CloneJob cloneJob, string cloneJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloneJobAsync(new CreateCloneJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloneJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)),
                CloneJob = gax::GaxPreconditions.CheckNotNull(cloneJob, nameof(cloneJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(string parent, CloneJob cloneJob, string cloneJobId, st::CancellationToken cancellationToken) =>
            CreateCloneJobAsync(parent, cloneJob, cloneJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloneJob, OperationMetadata> CreateCloneJob(MigratingVmName parent, CloneJob cloneJob, string cloneJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloneJob(new CreateCloneJobRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloneJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)),
                CloneJob = gax::GaxPreconditions.CheckNotNull(cloneJob, nameof(cloneJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(MigratingVmName parent, CloneJob cloneJob, string cloneJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloneJobAsync(new CreateCloneJobRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloneJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloneJobId, nameof(cloneJobId)),
                CloneJob = gax::GaxPreconditions.CheckNotNull(cloneJob, nameof(cloneJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The Clone's parent.
        /// </param>
        /// <param name="cloneJob">
        /// Required. The clone request body.
        /// </param>
        /// <param name="cloneJobId">
        /// Required. The clone job identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(MigratingVmName parent, CloneJob cloneJob, string cloneJobId, st::CancellationToken cancellationToken) =>
            CreateCloneJobAsync(parent, cloneJob, cloneJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCloneJobResponse, OperationMetadata> CancelCloneJob(CancelCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(CancelCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(CancelCloneJobRequest request, st::CancellationToken cancellationToken) =>
            CancelCloneJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CancelCloneJob</c>.</summary>
        public virtual lro::OperationsClient CancelCloneJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CancelCloneJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CancelCloneJobResponse, OperationMetadata> PollOnceCancelCloneJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelCloneJobResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelCloneJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CancelCloneJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> PollOnceCancelCloneJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelCloneJobResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelCloneJobOperationsClient, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCloneJobResponse, OperationMetadata> CancelCloneJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCloneJob(new CancelCloneJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCloneJobAsync(new CancelCloneJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelCloneJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCloneJobResponse, OperationMetadata> CancelCloneJob(CloneJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCloneJob(new CancelCloneJobRequest
            {
                CloneJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(CloneJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCloneJobAsync(new CancelCloneJobRequest
            {
                CloneJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="name">
        /// Required. The clone job id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(CloneJobName name, st::CancellationToken cancellationToken) =>
            CancelCloneJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobs(ListCloneJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobsAsync(ListCloneJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of source VMs.
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
        /// <returns>A pageable sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloneJobsRequest request = new ListCloneJobsRequest
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
            return ListCloneJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of source VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloneJobsRequest request = new ListCloneJobsRequest
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
            return ListCloneJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of source VMs.
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
        /// <returns>A pageable sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobs(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloneJobsRequest request = new ListCloneJobsRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloneJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of source VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloneJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobsAsync(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloneJobsRequest request = new ListCloneJobsRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCloneJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloneJob GetCloneJob(GetCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(GetCloneJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(GetCloneJobRequest request, st::CancellationToken cancellationToken) =>
            GetCloneJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloneJob GetCloneJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloneJob(new GetCloneJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloneJobAsync(new GetCloneJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloneJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloneJob GetCloneJob(CloneJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloneJob(new GetCloneJobRequest
            {
                CloneJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(CloneJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloneJobAsync(new GetCloneJobRequest
            {
                CloneJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CloneJob.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloneJob> GetCloneJobAsync(CloneJobName name, st::CancellationToken cancellationToken) =>
            GetCloneJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CutoverJob, OperationMetadata> CreateCutoverJob(CreateCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(CreateCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(CreateCutoverJobRequest request, st::CancellationToken cancellationToken) =>
            CreateCutoverJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCutoverJob</c>.</summary>
        public virtual lro::OperationsClient CreateCutoverJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCutoverJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CutoverJob, OperationMetadata> PollOnceCreateCutoverJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CutoverJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCutoverJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCutoverJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> PollOnceCreateCutoverJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CutoverJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCutoverJobOperationsClient, callSettings);

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CutoverJob, OperationMetadata> CreateCutoverJob(string parent, CutoverJob cutoverJob, string cutoverJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCutoverJob(new CreateCutoverJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CutoverJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)),
                CutoverJob = gax::GaxPreconditions.CheckNotNull(cutoverJob, nameof(cutoverJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(string parent, CutoverJob cutoverJob, string cutoverJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCutoverJobAsync(new CreateCutoverJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CutoverJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)),
                CutoverJob = gax::GaxPreconditions.CheckNotNull(cutoverJob, nameof(cutoverJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(string parent, CutoverJob cutoverJob, string cutoverJobId, st::CancellationToken cancellationToken) =>
            CreateCutoverJobAsync(parent, cutoverJob, cutoverJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CutoverJob, OperationMetadata> CreateCutoverJob(MigratingVmName parent, CutoverJob cutoverJob, string cutoverJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCutoverJob(new CreateCutoverJobRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CutoverJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)),
                CutoverJob = gax::GaxPreconditions.CheckNotNull(cutoverJob, nameof(cutoverJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(MigratingVmName parent, CutoverJob cutoverJob, string cutoverJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCutoverJobAsync(new CreateCutoverJobRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CutoverJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(cutoverJobId, nameof(cutoverJobId)),
                CutoverJob = gax::GaxPreconditions.CheckNotNull(cutoverJob, nameof(cutoverJob)),
            }, callSettings);

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cutover's parent.
        /// </param>
        /// <param name="cutoverJob">
        /// Required. The cutover request body.
        /// </param>
        /// <param name="cutoverJobId">
        /// Required. The cutover job identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(MigratingVmName parent, CutoverJob cutoverJob, string cutoverJobId, st::CancellationToken cancellationToken) =>
            CreateCutoverJobAsync(parent, cutoverJob, cutoverJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCutoverJobResponse, OperationMetadata> CancelCutoverJob(CancelCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(CancelCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(CancelCutoverJobRequest request, st::CancellationToken cancellationToken) =>
            CancelCutoverJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CancelCutoverJob</c>.</summary>
        public virtual lro::OperationsClient CancelCutoverJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CancelCutoverJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CancelCutoverJobResponse, OperationMetadata> PollOnceCancelCutoverJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelCutoverJobResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelCutoverJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CancelCutoverJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> PollOnceCancelCutoverJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CancelCutoverJobResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelCutoverJobOperationsClient, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCutoverJobResponse, OperationMetadata> CancelCutoverJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCutoverJob(new CancelCutoverJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCutoverJobAsync(new CancelCutoverJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelCutoverJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CancelCutoverJobResponse, OperationMetadata> CancelCutoverJob(CutoverJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCutoverJob(new CancelCutoverJobRequest
            {
                CutoverJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(CutoverJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCutoverJobAsync(new CancelCutoverJobRequest
            {
                CutoverJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="name">
        /// Required. The cutover job id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(CutoverJobName name, st::CancellationToken cancellationToken) =>
            CancelCutoverJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobs(ListCutoverJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobsAsync(ListCutoverJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrating VMs.
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
        /// <returns>A pageable sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
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
            return ListCutoverJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrating VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
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
            return ListCutoverJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrating VMs.
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
        /// <returns>A pageable sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobs(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCutoverJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of migrating VMs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CutoverJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobsAsync(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCutoverJobsRequest request = new ListCutoverJobsRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCutoverJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CutoverJob GetCutoverJob(GetCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(GetCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(GetCutoverJobRequest request, st::CancellationToken cancellationToken) =>
            GetCutoverJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CutoverJob GetCutoverJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCutoverJob(new GetCutoverJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCutoverJobAsync(new GetCutoverJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetCutoverJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CutoverJob GetCutoverJob(CutoverJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCutoverJob(new GetCutoverJobRequest
            {
                CutoverJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(CutoverJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCutoverJobAsync(new GetCutoverJobRequest
            {
                CutoverJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CutoverJob.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CutoverJob> GetCutoverJobAsync(CutoverJobName name, st::CancellationToken cancellationToken) =>
            GetCutoverJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of groups.
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of groups.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of groups.
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of groups.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, st::CancellationToken cancellationToken) =>
            GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The group name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> CreateGroup(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(CreateGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGroup</c>.</summary>
        public virtual lro::OperationsClient CreateGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Group, OperationMetadata> PollOnceCreateGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> PollOnceCreateGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> CreateGroup(string parent, Group group, string groupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(string parent, Group group, string groupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(string parent, Group group, string groupId, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(parent, group, groupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> CreateGroup(gagr::LocationName parent, Group group, string groupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(gagr::LocationName parent, Group group, string groupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(groupId, nameof(groupId)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The Group's parent.
        /// </param>
        /// <param name="group">
        /// Required. The create request body.
        /// </param>
        /// <param name="groupId">
        /// Required. The group identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(gagr::LocationName parent, Group group, string groupId, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(parent, group, groupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Group, OperationMetadata> PollOnceUpdateGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> PollOnceUpdateGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="group">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Group resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroup(new UpdateGroupRequest
            {
                UpdateMask = updateMask,
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="group">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Group resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroupAsync(new UpdateGroupRequest
            {
                UpdateMask = updateMask,
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="group">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// Group resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(group, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(DeleteGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="name">
        /// Required. The Group name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddGroupMigrationResponse, OperationMetadata> AddGroupMigration(AddGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(AddGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(AddGroupMigrationRequest request, st::CancellationToken cancellationToken) =>
            AddGroupMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddGroupMigration</c>.</summary>
        public virtual lro::OperationsClient AddGroupMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddGroupMigration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddGroupMigrationResponse, OperationMetadata> PollOnceAddGroupMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddGroupMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddGroupMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddGroupMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> PollOnceAddGroupMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddGroupMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddGroupMigrationOperationsClient, callSettings);

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddGroupMigrationResponse, OperationMetadata> AddGroupMigration(string group, gaxgrpc::CallSettings callSettings = null) =>
            AddGroupMigration(new AddGroupMigrationRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(string group, gaxgrpc::CallSettings callSettings = null) =>
            AddGroupMigrationAsync(new AddGroupMigrationRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(string group, st::CancellationToken cancellationToken) =>
            AddGroupMigrationAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddGroupMigrationResponse, OperationMetadata> AddGroupMigration(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            AddGroupMigration(new AddGroupMigrationRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            AddGroupMigrationAsync(new AddGroupMigrationRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The full path name of the Group to add to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(GroupName group, st::CancellationToken cancellationToken) =>
            AddGroupMigrationAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveGroupMigrationResponse, OperationMetadata> RemoveGroupMigration(RemoveGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(RemoveGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(RemoveGroupMigrationRequest request, st::CancellationToken cancellationToken) =>
            RemoveGroupMigrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveGroupMigration</c>.</summary>
        public virtual lro::OperationsClient RemoveGroupMigrationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveGroupMigration</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RemoveGroupMigrationResponse, OperationMetadata> PollOnceRemoveGroupMigration(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveGroupMigrationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveGroupMigration</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> PollOnceRemoveGroupMigrationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveGroupMigrationOperationsClient, callSettings);

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveGroupMigrationResponse, OperationMetadata> RemoveGroupMigration(string group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveGroupMigration(new RemoveGroupMigrationRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(string group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveGroupMigrationAsync(new RemoveGroupMigrationRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(string group, st::CancellationToken cancellationToken) =>
            RemoveGroupMigrationAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RemoveGroupMigrationResponse, OperationMetadata> RemoveGroupMigration(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveGroupMigration(new RemoveGroupMigrationRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveGroupMigrationAsync(new RemoveGroupMigrationRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="group">
        /// Required. The name of the Group.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(GroupName group, st::CancellationToken cancellationToken) =>
            RemoveGroupMigrationAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjects(ListTargetProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjectsAsync(ListTargetProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets.
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
        /// <returns>A pageable sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjects(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
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
            return ListTargetProjects(request, callSettings);
        }

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjectsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
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
            return ListTargetProjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets.
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
        /// <returns>A pageable sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjects(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
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
            return ListTargetProjects(request, callSettings);
        }

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetProject"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjectsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetProjectsRequest request = new ListTargetProjectsRequest
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
            return ListTargetProjectsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetProject GetTargetProject(GetTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(GetTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(GetTargetProjectRequest request, st::CancellationToken cancellationToken) =>
            GetTargetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetProject GetTargetProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetProject(new GetTargetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetProjectAsync(new GetTargetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(string name, st::CancellationToken cancellationToken) =>
            GetTargetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetProject GetTargetProject(TargetProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetProject(new GetTargetProjectRequest
            {
                TargetProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(TargetProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetProjectAsync(new GetTargetProjectRequest
            {
                TargetProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetProject> GetTargetProjectAsync(TargetProjectName name, st::CancellationToken cancellationToken) =>
            GetTargetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> CreateTargetProject(CreateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(CreateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(CreateTargetProjectRequest request, st::CancellationToken cancellationToken) =>
            CreateTargetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTargetProject</c>.</summary>
        public virtual lro::OperationsClient CreateTargetProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTargetProject</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> PollOnceCreateTargetProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetProject, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTargetProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> PollOnceCreateTargetProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetProject, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> CreateTargetProject(string parent, TargetProject targetProject, string targetProjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetProject(new CreateTargetProjectRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)),
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(string parent, TargetProject targetProject, string targetProjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetProjectAsync(new CreateTargetProjectRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)),
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(string parent, TargetProject targetProject, string targetProjectId, st::CancellationToken cancellationToken) =>
            CreateTargetProjectAsync(parent, targetProject, targetProjectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> CreateTargetProject(gagr::LocationName parent, TargetProject targetProject, string targetProjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetProject(new CreateTargetProjectRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)),
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(gagr::LocationName parent, TargetProject targetProject, string targetProjectId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetProjectAsync(new CreateTargetProjectRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetProjectId, nameof(targetProjectId)),
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="parent">
        /// Required. The TargetProject's parent.
        /// </param>
        /// <param name="targetProject">
        /// Required. The create request body.
        /// </param>
        /// <param name="targetProjectId">
        /// Required. The target_project identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(gagr::LocationName parent, TargetProject targetProject, string targetProjectId, st::CancellationToken cancellationToken) =>
            CreateTargetProjectAsync(parent, targetProject, targetProjectId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> UpdateTargetProject(UpdateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> UpdateTargetProjectAsync(UpdateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> UpdateTargetProjectAsync(UpdateTargetProjectRequest request, st::CancellationToken cancellationToken) =>
            UpdateTargetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTargetProject</c>.</summary>
        public virtual lro::OperationsClient UpdateTargetProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTargetProject</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> PollOnceUpdateTargetProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetProject, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTargetProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> PollOnceUpdateTargetProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TargetProject, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="targetProject">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// TargetProject resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TargetProject, OperationMetadata> UpdateTargetProject(TargetProject targetProject, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTargetProject(new UpdateTargetProjectRequest
            {
                UpdateMask = updateMask,
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="targetProject">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// TargetProject resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> UpdateTargetProjectAsync(TargetProject targetProject, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTargetProjectAsync(new UpdateTargetProjectRequest
            {
                UpdateMask = updateMask,
                TargetProject = gax::GaxPreconditions.CheckNotNull(targetProject, nameof(targetProject)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="targetProject">
        /// Required. The update request body.
        /// </param>
        /// <param name="updateMask">
        /// Field mask is used to specify the fields to be overwritten in the
        /// TargetProject resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TargetProject, OperationMetadata>> UpdateTargetProjectAsync(TargetProject targetProject, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTargetProjectAsync(targetProject, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTargetProject(DeleteTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(DeleteTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(DeleteTargetProjectRequest request, st::CancellationToken cancellationToken) =>
            DeleteTargetProjectAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTargetProject</c>.</summary>
        public virtual lro::OperationsClient DeleteTargetProjectOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTargetProject</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTargetProject(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTargetProject</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTargetProjectAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetProjectOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTargetProject(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetProject(new DeleteTargetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetProjectAsync(new DeleteTargetProjectRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTargetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTargetProject(TargetProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetProject(new DeleteTargetProjectRequest
            {
                TargetProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(TargetProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetProjectAsync(new DeleteTargetProjectRequest
            {
                TargetProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="name">
        /// Required. The TargetProject name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(TargetProjectName name, st::CancellationToken cancellationToken) =>
            DeleteTargetProjectAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCycles(ListReplicationCyclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCyclesAsync(ListReplicationCyclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ReplicationCycles.
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
        /// <returns>A pageable sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCycles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
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
            return ListReplicationCycles(request, callSettings);
        }

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ReplicationCycles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCyclesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
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
            return ListReplicationCyclesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ReplicationCycles.
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
        /// <returns>A pageable sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCycles(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplicationCycles(request, callSettings);
        }

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ReplicationCycles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCyclesAsync(MigratingVmName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReplicationCyclesRequest request = new ListReplicationCyclesRequest
            {
                ParentAsMigratingVmName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReplicationCyclesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReplicationCycle GetReplicationCycle(GetReplicationCycleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(GetReplicationCycleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(GetReplicationCycleRequest request, st::CancellationToken cancellationToken) =>
            GetReplicationCycleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReplicationCycle GetReplicationCycle(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationCycle(new GetReplicationCycleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationCycleAsync(new GetReplicationCycleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(string name, st::CancellationToken cancellationToken) =>
            GetReplicationCycleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReplicationCycle GetReplicationCycle(ReplicationCycleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationCycle(new GetReplicationCycleRequest
            {
                ReplicationCycleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(ReplicationCycleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationCycleAsync(new GetReplicationCycleRequest
            {
                ReplicationCycleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ReplicationCycle.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReplicationCycle> GetReplicationCycleAsync(ReplicationCycleName name, st::CancellationToken cancellationToken) =>
            GetReplicationCycleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VmMigration client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// VM Migration Service
    /// </remarks>
    public sealed partial class VmMigrationClientImpl : VmMigrationClient
    {
        private readonly gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> _callListSources;

        private readonly gaxgrpc::ApiCall<GetSourceRequest, Source> _callGetSource;

        private readonly gaxgrpc::ApiCall<CreateSourceRequest, lro::Operation> _callCreateSource;

        private readonly gaxgrpc::ApiCall<UpdateSourceRequest, lro::Operation> _callUpdateSource;

        private readonly gaxgrpc::ApiCall<DeleteSourceRequest, lro::Operation> _callDeleteSource;

        private readonly gaxgrpc::ApiCall<FetchInventoryRequest, FetchInventoryResponse> _callFetchInventory;

        private readonly gaxgrpc::ApiCall<ListUtilizationReportsRequest, ListUtilizationReportsResponse> _callListUtilizationReports;

        private readonly gaxgrpc::ApiCall<GetUtilizationReportRequest, UtilizationReport> _callGetUtilizationReport;

        private readonly gaxgrpc::ApiCall<CreateUtilizationReportRequest, lro::Operation> _callCreateUtilizationReport;

        private readonly gaxgrpc::ApiCall<DeleteUtilizationReportRequest, lro::Operation> _callDeleteUtilizationReport;

        private readonly gaxgrpc::ApiCall<ListDatacenterConnectorsRequest, ListDatacenterConnectorsResponse> _callListDatacenterConnectors;

        private readonly gaxgrpc::ApiCall<GetDatacenterConnectorRequest, DatacenterConnector> _callGetDatacenterConnector;

        private readonly gaxgrpc::ApiCall<CreateDatacenterConnectorRequest, lro::Operation> _callCreateDatacenterConnector;

        private readonly gaxgrpc::ApiCall<DeleteDatacenterConnectorRequest, lro::Operation> _callDeleteDatacenterConnector;

        private readonly gaxgrpc::ApiCall<UpgradeApplianceRequest, lro::Operation> _callUpgradeAppliance;

        private readonly gaxgrpc::ApiCall<CreateMigratingVmRequest, lro::Operation> _callCreateMigratingVm;

        private readonly gaxgrpc::ApiCall<ListMigratingVmsRequest, ListMigratingVmsResponse> _callListMigratingVms;

        private readonly gaxgrpc::ApiCall<GetMigratingVmRequest, MigratingVm> _callGetMigratingVm;

        private readonly gaxgrpc::ApiCall<UpdateMigratingVmRequest, lro::Operation> _callUpdateMigratingVm;

        private readonly gaxgrpc::ApiCall<DeleteMigratingVmRequest, lro::Operation> _callDeleteMigratingVm;

        private readonly gaxgrpc::ApiCall<StartMigrationRequest, lro::Operation> _callStartMigration;

        private readonly gaxgrpc::ApiCall<ResumeMigrationRequest, lro::Operation> _callResumeMigration;

        private readonly gaxgrpc::ApiCall<PauseMigrationRequest, lro::Operation> _callPauseMigration;

        private readonly gaxgrpc::ApiCall<FinalizeMigrationRequest, lro::Operation> _callFinalizeMigration;

        private readonly gaxgrpc::ApiCall<CreateCloneJobRequest, lro::Operation> _callCreateCloneJob;

        private readonly gaxgrpc::ApiCall<CancelCloneJobRequest, lro::Operation> _callCancelCloneJob;

        private readonly gaxgrpc::ApiCall<ListCloneJobsRequest, ListCloneJobsResponse> _callListCloneJobs;

        private readonly gaxgrpc::ApiCall<GetCloneJobRequest, CloneJob> _callGetCloneJob;

        private readonly gaxgrpc::ApiCall<CreateCutoverJobRequest, lro::Operation> _callCreateCutoverJob;

        private readonly gaxgrpc::ApiCall<CancelCutoverJobRequest, lro::Operation> _callCancelCutoverJob;

        private readonly gaxgrpc::ApiCall<ListCutoverJobsRequest, ListCutoverJobsResponse> _callListCutoverJobs;

        private readonly gaxgrpc::ApiCall<GetCutoverJobRequest, CutoverJob> _callGetCutoverJob;

        private readonly gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;

        private readonly gaxgrpc::ApiCall<GetGroupRequest, Group> _callGetGroup;

        private readonly gaxgrpc::ApiCall<CreateGroupRequest, lro::Operation> _callCreateGroup;

        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> _callUpdateGroup;

        private readonly gaxgrpc::ApiCall<DeleteGroupRequest, lro::Operation> _callDeleteGroup;

        private readonly gaxgrpc::ApiCall<AddGroupMigrationRequest, lro::Operation> _callAddGroupMigration;

        private readonly gaxgrpc::ApiCall<RemoveGroupMigrationRequest, lro::Operation> _callRemoveGroupMigration;

        private readonly gaxgrpc::ApiCall<ListTargetProjectsRequest, ListTargetProjectsResponse> _callListTargetProjects;

        private readonly gaxgrpc::ApiCall<GetTargetProjectRequest, TargetProject> _callGetTargetProject;

        private readonly gaxgrpc::ApiCall<CreateTargetProjectRequest, lro::Operation> _callCreateTargetProject;

        private readonly gaxgrpc::ApiCall<UpdateTargetProjectRequest, lro::Operation> _callUpdateTargetProject;

        private readonly gaxgrpc::ApiCall<DeleteTargetProjectRequest, lro::Operation> _callDeleteTargetProject;

        private readonly gaxgrpc::ApiCall<ListReplicationCyclesRequest, ListReplicationCyclesResponse> _callListReplicationCycles;

        private readonly gaxgrpc::ApiCall<GetReplicationCycleRequest, ReplicationCycle> _callGetReplicationCycle;

        /// <summary>
        /// Constructs a client wrapper for the VmMigration service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VmMigrationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VmMigrationClientImpl(VmMigration.VmMigrationClient grpcClient, VmMigrationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VmMigrationSettings effectiveSettings = settings ?? VmMigrationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSourceOperationsSettings, logger);
            UpdateSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSourceOperationsSettings, logger);
            DeleteSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSourceOperationsSettings, logger);
            CreateUtilizationReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateUtilizationReportOperationsSettings, logger);
            DeleteUtilizationReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteUtilizationReportOperationsSettings, logger);
            CreateDatacenterConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatacenterConnectorOperationsSettings, logger);
            DeleteDatacenterConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDatacenterConnectorOperationsSettings, logger);
            UpgradeApplianceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeApplianceOperationsSettings, logger);
            CreateMigratingVmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMigratingVmOperationsSettings, logger);
            UpdateMigratingVmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMigratingVmOperationsSettings, logger);
            DeleteMigratingVmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMigratingVmOperationsSettings, logger);
            StartMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartMigrationOperationsSettings, logger);
            ResumeMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeMigrationOperationsSettings, logger);
            PauseMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PauseMigrationOperationsSettings, logger);
            FinalizeMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FinalizeMigrationOperationsSettings, logger);
            CreateCloneJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCloneJobOperationsSettings, logger);
            CancelCloneJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelCloneJobOperationsSettings, logger);
            CreateCutoverJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCutoverJobOperationsSettings, logger);
            CancelCutoverJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelCutoverJobOperationsSettings, logger);
            CreateGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGroupOperationsSettings, logger);
            UpdateGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGroupOperationsSettings, logger);
            DeleteGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGroupOperationsSettings, logger);
            AddGroupMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddGroupMigrationOperationsSettings, logger);
            RemoveGroupMigrationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveGroupMigrationOperationsSettings, logger);
            CreateTargetProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTargetProjectOperationsSettings, logger);
            UpdateTargetProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTargetProjectOperationsSettings, logger);
            DeleteTargetProjectOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTargetProjectOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListSources = clientHelper.BuildApiCall<ListSourcesRequest, ListSourcesResponse>("ListSources", grpcClient.ListSourcesAsync, grpcClient.ListSources, effectiveSettings.ListSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSources);
            Modify_ListSourcesApiCall(ref _callListSources);
            _callGetSource = clientHelper.BuildApiCall<GetSourceRequest, Source>("GetSource", grpcClient.GetSourceAsync, grpcClient.GetSource, effectiveSettings.GetSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSource);
            Modify_GetSourceApiCall(ref _callGetSource);
            _callCreateSource = clientHelper.BuildApiCall<CreateSourceRequest, lro::Operation>("CreateSource", grpcClient.CreateSourceAsync, grpcClient.CreateSource, effectiveSettings.CreateSourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSource);
            Modify_CreateSourceApiCall(ref _callCreateSource);
            _callUpdateSource = clientHelper.BuildApiCall<UpdateSourceRequest, lro::Operation>("UpdateSource", grpcClient.UpdateSourceAsync, grpcClient.UpdateSource, effectiveSettings.UpdateSourceSettings).WithGoogleRequestParam("source.name", request => request.Source?.Name);
            Modify_ApiCall(ref _callUpdateSource);
            Modify_UpdateSourceApiCall(ref _callUpdateSource);
            _callDeleteSource = clientHelper.BuildApiCall<DeleteSourceRequest, lro::Operation>("DeleteSource", grpcClient.DeleteSourceAsync, grpcClient.DeleteSource, effectiveSettings.DeleteSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSource);
            Modify_DeleteSourceApiCall(ref _callDeleteSource);
            _callFetchInventory = clientHelper.BuildApiCall<FetchInventoryRequest, FetchInventoryResponse>("FetchInventory", grpcClient.FetchInventoryAsync, grpcClient.FetchInventory, effectiveSettings.FetchInventorySettings).WithGoogleRequestParam("source", request => request.Source);
            Modify_ApiCall(ref _callFetchInventory);
            Modify_FetchInventoryApiCall(ref _callFetchInventory);
            _callListUtilizationReports = clientHelper.BuildApiCall<ListUtilizationReportsRequest, ListUtilizationReportsResponse>("ListUtilizationReports", grpcClient.ListUtilizationReportsAsync, grpcClient.ListUtilizationReports, effectiveSettings.ListUtilizationReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUtilizationReports);
            Modify_ListUtilizationReportsApiCall(ref _callListUtilizationReports);
            _callGetUtilizationReport = clientHelper.BuildApiCall<GetUtilizationReportRequest, UtilizationReport>("GetUtilizationReport", grpcClient.GetUtilizationReportAsync, grpcClient.GetUtilizationReport, effectiveSettings.GetUtilizationReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUtilizationReport);
            Modify_GetUtilizationReportApiCall(ref _callGetUtilizationReport);
            _callCreateUtilizationReport = clientHelper.BuildApiCall<CreateUtilizationReportRequest, lro::Operation>("CreateUtilizationReport", grpcClient.CreateUtilizationReportAsync, grpcClient.CreateUtilizationReport, effectiveSettings.CreateUtilizationReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUtilizationReport);
            Modify_CreateUtilizationReportApiCall(ref _callCreateUtilizationReport);
            _callDeleteUtilizationReport = clientHelper.BuildApiCall<DeleteUtilizationReportRequest, lro::Operation>("DeleteUtilizationReport", grpcClient.DeleteUtilizationReportAsync, grpcClient.DeleteUtilizationReport, effectiveSettings.DeleteUtilizationReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUtilizationReport);
            Modify_DeleteUtilizationReportApiCall(ref _callDeleteUtilizationReport);
            _callListDatacenterConnectors = clientHelper.BuildApiCall<ListDatacenterConnectorsRequest, ListDatacenterConnectorsResponse>("ListDatacenterConnectors", grpcClient.ListDatacenterConnectorsAsync, grpcClient.ListDatacenterConnectors, effectiveSettings.ListDatacenterConnectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatacenterConnectors);
            Modify_ListDatacenterConnectorsApiCall(ref _callListDatacenterConnectors);
            _callGetDatacenterConnector = clientHelper.BuildApiCall<GetDatacenterConnectorRequest, DatacenterConnector>("GetDatacenterConnector", grpcClient.GetDatacenterConnectorAsync, grpcClient.GetDatacenterConnector, effectiveSettings.GetDatacenterConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDatacenterConnector);
            Modify_GetDatacenterConnectorApiCall(ref _callGetDatacenterConnector);
            _callCreateDatacenterConnector = clientHelper.BuildApiCall<CreateDatacenterConnectorRequest, lro::Operation>("CreateDatacenterConnector", grpcClient.CreateDatacenterConnectorAsync, grpcClient.CreateDatacenterConnector, effectiveSettings.CreateDatacenterConnectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDatacenterConnector);
            Modify_CreateDatacenterConnectorApiCall(ref _callCreateDatacenterConnector);
            _callDeleteDatacenterConnector = clientHelper.BuildApiCall<DeleteDatacenterConnectorRequest, lro::Operation>("DeleteDatacenterConnector", grpcClient.DeleteDatacenterConnectorAsync, grpcClient.DeleteDatacenterConnector, effectiveSettings.DeleteDatacenterConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDatacenterConnector);
            Modify_DeleteDatacenterConnectorApiCall(ref _callDeleteDatacenterConnector);
            _callUpgradeAppliance = clientHelper.BuildApiCall<UpgradeApplianceRequest, lro::Operation>("UpgradeAppliance", grpcClient.UpgradeApplianceAsync, grpcClient.UpgradeAppliance, effectiveSettings.UpgradeApplianceSettings).WithGoogleRequestParam("datacenter_connector", request => request.DatacenterConnector);
            Modify_ApiCall(ref _callUpgradeAppliance);
            Modify_UpgradeApplianceApiCall(ref _callUpgradeAppliance);
            _callCreateMigratingVm = clientHelper.BuildApiCall<CreateMigratingVmRequest, lro::Operation>("CreateMigratingVm", grpcClient.CreateMigratingVmAsync, grpcClient.CreateMigratingVm, effectiveSettings.CreateMigratingVmSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMigratingVm);
            Modify_CreateMigratingVmApiCall(ref _callCreateMigratingVm);
            _callListMigratingVms = clientHelper.BuildApiCall<ListMigratingVmsRequest, ListMigratingVmsResponse>("ListMigratingVms", grpcClient.ListMigratingVmsAsync, grpcClient.ListMigratingVms, effectiveSettings.ListMigratingVmsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMigratingVms);
            Modify_ListMigratingVmsApiCall(ref _callListMigratingVms);
            _callGetMigratingVm = clientHelper.BuildApiCall<GetMigratingVmRequest, MigratingVm>("GetMigratingVm", grpcClient.GetMigratingVmAsync, grpcClient.GetMigratingVm, effectiveSettings.GetMigratingVmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMigratingVm);
            Modify_GetMigratingVmApiCall(ref _callGetMigratingVm);
            _callUpdateMigratingVm = clientHelper.BuildApiCall<UpdateMigratingVmRequest, lro::Operation>("UpdateMigratingVm", grpcClient.UpdateMigratingVmAsync, grpcClient.UpdateMigratingVm, effectiveSettings.UpdateMigratingVmSettings).WithGoogleRequestParam("migrating_vm.name", request => request.MigratingVm?.Name);
            Modify_ApiCall(ref _callUpdateMigratingVm);
            Modify_UpdateMigratingVmApiCall(ref _callUpdateMigratingVm);
            _callDeleteMigratingVm = clientHelper.BuildApiCall<DeleteMigratingVmRequest, lro::Operation>("DeleteMigratingVm", grpcClient.DeleteMigratingVmAsync, grpcClient.DeleteMigratingVm, effectiveSettings.DeleteMigratingVmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMigratingVm);
            Modify_DeleteMigratingVmApiCall(ref _callDeleteMigratingVm);
            _callStartMigration = clientHelper.BuildApiCall<StartMigrationRequest, lro::Operation>("StartMigration", grpcClient.StartMigrationAsync, grpcClient.StartMigration, effectiveSettings.StartMigrationSettings).WithGoogleRequestParam("migrating_vm", request => request.MigratingVm);
            Modify_ApiCall(ref _callStartMigration);
            Modify_StartMigrationApiCall(ref _callStartMigration);
            _callResumeMigration = clientHelper.BuildApiCall<ResumeMigrationRequest, lro::Operation>("ResumeMigration", grpcClient.ResumeMigrationAsync, grpcClient.ResumeMigration, effectiveSettings.ResumeMigrationSettings).WithGoogleRequestParam("migrating_vm", request => request.MigratingVm);
            Modify_ApiCall(ref _callResumeMigration);
            Modify_ResumeMigrationApiCall(ref _callResumeMigration);
            _callPauseMigration = clientHelper.BuildApiCall<PauseMigrationRequest, lro::Operation>("PauseMigration", grpcClient.PauseMigrationAsync, grpcClient.PauseMigration, effectiveSettings.PauseMigrationSettings).WithGoogleRequestParam("migrating_vm", request => request.MigratingVm);
            Modify_ApiCall(ref _callPauseMigration);
            Modify_PauseMigrationApiCall(ref _callPauseMigration);
            _callFinalizeMigration = clientHelper.BuildApiCall<FinalizeMigrationRequest, lro::Operation>("FinalizeMigration", grpcClient.FinalizeMigrationAsync, grpcClient.FinalizeMigration, effectiveSettings.FinalizeMigrationSettings).WithGoogleRequestParam("migrating_vm", request => request.MigratingVm);
            Modify_ApiCall(ref _callFinalizeMigration);
            Modify_FinalizeMigrationApiCall(ref _callFinalizeMigration);
            _callCreateCloneJob = clientHelper.BuildApiCall<CreateCloneJobRequest, lro::Operation>("CreateCloneJob", grpcClient.CreateCloneJobAsync, grpcClient.CreateCloneJob, effectiveSettings.CreateCloneJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCloneJob);
            Modify_CreateCloneJobApiCall(ref _callCreateCloneJob);
            _callCancelCloneJob = clientHelper.BuildApiCall<CancelCloneJobRequest, lro::Operation>("CancelCloneJob", grpcClient.CancelCloneJobAsync, grpcClient.CancelCloneJob, effectiveSettings.CancelCloneJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelCloneJob);
            Modify_CancelCloneJobApiCall(ref _callCancelCloneJob);
            _callListCloneJobs = clientHelper.BuildApiCall<ListCloneJobsRequest, ListCloneJobsResponse>("ListCloneJobs", grpcClient.ListCloneJobsAsync, grpcClient.ListCloneJobs, effectiveSettings.ListCloneJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloneJobs);
            Modify_ListCloneJobsApiCall(ref _callListCloneJobs);
            _callGetCloneJob = clientHelper.BuildApiCall<GetCloneJobRequest, CloneJob>("GetCloneJob", grpcClient.GetCloneJobAsync, grpcClient.GetCloneJob, effectiveSettings.GetCloneJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloneJob);
            Modify_GetCloneJobApiCall(ref _callGetCloneJob);
            _callCreateCutoverJob = clientHelper.BuildApiCall<CreateCutoverJobRequest, lro::Operation>("CreateCutoverJob", grpcClient.CreateCutoverJobAsync, grpcClient.CreateCutoverJob, effectiveSettings.CreateCutoverJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCutoverJob);
            Modify_CreateCutoverJobApiCall(ref _callCreateCutoverJob);
            _callCancelCutoverJob = clientHelper.BuildApiCall<CancelCutoverJobRequest, lro::Operation>("CancelCutoverJob", grpcClient.CancelCutoverJobAsync, grpcClient.CancelCutoverJob, effectiveSettings.CancelCutoverJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelCutoverJob);
            Modify_CancelCutoverJobApiCall(ref _callCancelCutoverJob);
            _callListCutoverJobs = clientHelper.BuildApiCall<ListCutoverJobsRequest, ListCutoverJobsResponse>("ListCutoverJobs", grpcClient.ListCutoverJobsAsync, grpcClient.ListCutoverJobs, effectiveSettings.ListCutoverJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCutoverJobs);
            Modify_ListCutoverJobsApiCall(ref _callListCutoverJobs);
            _callGetCutoverJob = clientHelper.BuildApiCall<GetCutoverJobRequest, CutoverJob>("GetCutoverJob", grpcClient.GetCutoverJobAsync, grpcClient.GetCutoverJob, effectiveSettings.GetCutoverJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCutoverJob);
            Modify_GetCutoverJobApiCall(ref _callGetCutoverJob);
            _callListGroups = clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>("ListGroups", grpcClient.ListGroupsAsync, grpcClient.ListGroups, effectiveSettings.ListGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGroups);
            Modify_ListGroupsApiCall(ref _callListGroups);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, Group>("GetGroup", grpcClient.GetGroupAsync, grpcClient.GetGroup, effectiveSettings.GetGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGroup);
            Modify_GetGroupApiCall(ref _callGetGroup);
            _callCreateGroup = clientHelper.BuildApiCall<CreateGroupRequest, lro::Operation>("CreateGroup", grpcClient.CreateGroupAsync, grpcClient.CreateGroup, effectiveSettings.CreateGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGroup);
            Modify_CreateGroupApiCall(ref _callCreateGroup);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, lro::Operation>("UpdateGroup", grpcClient.UpdateGroupAsync, grpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings).WithGoogleRequestParam("group.name", request => request.Group?.Name);
            Modify_ApiCall(ref _callUpdateGroup);
            Modify_UpdateGroupApiCall(ref _callUpdateGroup);
            _callDeleteGroup = clientHelper.BuildApiCall<DeleteGroupRequest, lro::Operation>("DeleteGroup", grpcClient.DeleteGroupAsync, grpcClient.DeleteGroup, effectiveSettings.DeleteGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGroup);
            Modify_DeleteGroupApiCall(ref _callDeleteGroup);
            _callAddGroupMigration = clientHelper.BuildApiCall<AddGroupMigrationRequest, lro::Operation>("AddGroupMigration", grpcClient.AddGroupMigrationAsync, grpcClient.AddGroupMigration, effectiveSettings.AddGroupMigrationSettings).WithGoogleRequestParam("group", request => request.Group);
            Modify_ApiCall(ref _callAddGroupMigration);
            Modify_AddGroupMigrationApiCall(ref _callAddGroupMigration);
            _callRemoveGroupMigration = clientHelper.BuildApiCall<RemoveGroupMigrationRequest, lro::Operation>("RemoveGroupMigration", grpcClient.RemoveGroupMigrationAsync, grpcClient.RemoveGroupMigration, effectiveSettings.RemoveGroupMigrationSettings).WithGoogleRequestParam("group", request => request.Group);
            Modify_ApiCall(ref _callRemoveGroupMigration);
            Modify_RemoveGroupMigrationApiCall(ref _callRemoveGroupMigration);
            _callListTargetProjects = clientHelper.BuildApiCall<ListTargetProjectsRequest, ListTargetProjectsResponse>("ListTargetProjects", grpcClient.ListTargetProjectsAsync, grpcClient.ListTargetProjects, effectiveSettings.ListTargetProjectsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTargetProjects);
            Modify_ListTargetProjectsApiCall(ref _callListTargetProjects);
            _callGetTargetProject = clientHelper.BuildApiCall<GetTargetProjectRequest, TargetProject>("GetTargetProject", grpcClient.GetTargetProjectAsync, grpcClient.GetTargetProject, effectiveSettings.GetTargetProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTargetProject);
            Modify_GetTargetProjectApiCall(ref _callGetTargetProject);
            _callCreateTargetProject = clientHelper.BuildApiCall<CreateTargetProjectRequest, lro::Operation>("CreateTargetProject", grpcClient.CreateTargetProjectAsync, grpcClient.CreateTargetProject, effectiveSettings.CreateTargetProjectSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTargetProject);
            Modify_CreateTargetProjectApiCall(ref _callCreateTargetProject);
            _callUpdateTargetProject = clientHelper.BuildApiCall<UpdateTargetProjectRequest, lro::Operation>("UpdateTargetProject", grpcClient.UpdateTargetProjectAsync, grpcClient.UpdateTargetProject, effectiveSettings.UpdateTargetProjectSettings).WithGoogleRequestParam("target_project.name", request => request.TargetProject?.Name);
            Modify_ApiCall(ref _callUpdateTargetProject);
            Modify_UpdateTargetProjectApiCall(ref _callUpdateTargetProject);
            _callDeleteTargetProject = clientHelper.BuildApiCall<DeleteTargetProjectRequest, lro::Operation>("DeleteTargetProject", grpcClient.DeleteTargetProjectAsync, grpcClient.DeleteTargetProject, effectiveSettings.DeleteTargetProjectSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTargetProject);
            Modify_DeleteTargetProjectApiCall(ref _callDeleteTargetProject);
            _callListReplicationCycles = clientHelper.BuildApiCall<ListReplicationCyclesRequest, ListReplicationCyclesResponse>("ListReplicationCycles", grpcClient.ListReplicationCyclesAsync, grpcClient.ListReplicationCycles, effectiveSettings.ListReplicationCyclesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReplicationCycles);
            Modify_ListReplicationCyclesApiCall(ref _callListReplicationCycles);
            _callGetReplicationCycle = clientHelper.BuildApiCall<GetReplicationCycleRequest, ReplicationCycle>("GetReplicationCycle", grpcClient.GetReplicationCycleAsync, grpcClient.GetReplicationCycle, effectiveSettings.GetReplicationCycleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReplicationCycle);
            Modify_GetReplicationCycleApiCall(ref _callGetReplicationCycle);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSourcesApiCall(ref gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> call);

        partial void Modify_GetSourceApiCall(ref gaxgrpc::ApiCall<GetSourceRequest, Source> call);

        partial void Modify_CreateSourceApiCall(ref gaxgrpc::ApiCall<CreateSourceRequest, lro::Operation> call);

        partial void Modify_UpdateSourceApiCall(ref gaxgrpc::ApiCall<UpdateSourceRequest, lro::Operation> call);

        partial void Modify_DeleteSourceApiCall(ref gaxgrpc::ApiCall<DeleteSourceRequest, lro::Operation> call);

        partial void Modify_FetchInventoryApiCall(ref gaxgrpc::ApiCall<FetchInventoryRequest, FetchInventoryResponse> call);

        partial void Modify_ListUtilizationReportsApiCall(ref gaxgrpc::ApiCall<ListUtilizationReportsRequest, ListUtilizationReportsResponse> call);

        partial void Modify_GetUtilizationReportApiCall(ref gaxgrpc::ApiCall<GetUtilizationReportRequest, UtilizationReport> call);

        partial void Modify_CreateUtilizationReportApiCall(ref gaxgrpc::ApiCall<CreateUtilizationReportRequest, lro::Operation> call);

        partial void Modify_DeleteUtilizationReportApiCall(ref gaxgrpc::ApiCall<DeleteUtilizationReportRequest, lro::Operation> call);

        partial void Modify_ListDatacenterConnectorsApiCall(ref gaxgrpc::ApiCall<ListDatacenterConnectorsRequest, ListDatacenterConnectorsResponse> call);

        partial void Modify_GetDatacenterConnectorApiCall(ref gaxgrpc::ApiCall<GetDatacenterConnectorRequest, DatacenterConnector> call);

        partial void Modify_CreateDatacenterConnectorApiCall(ref gaxgrpc::ApiCall<CreateDatacenterConnectorRequest, lro::Operation> call);

        partial void Modify_DeleteDatacenterConnectorApiCall(ref gaxgrpc::ApiCall<DeleteDatacenterConnectorRequest, lro::Operation> call);

        partial void Modify_UpgradeApplianceApiCall(ref gaxgrpc::ApiCall<UpgradeApplianceRequest, lro::Operation> call);

        partial void Modify_CreateMigratingVmApiCall(ref gaxgrpc::ApiCall<CreateMigratingVmRequest, lro::Operation> call);

        partial void Modify_ListMigratingVmsApiCall(ref gaxgrpc::ApiCall<ListMigratingVmsRequest, ListMigratingVmsResponse> call);

        partial void Modify_GetMigratingVmApiCall(ref gaxgrpc::ApiCall<GetMigratingVmRequest, MigratingVm> call);

        partial void Modify_UpdateMigratingVmApiCall(ref gaxgrpc::ApiCall<UpdateMigratingVmRequest, lro::Operation> call);

        partial void Modify_DeleteMigratingVmApiCall(ref gaxgrpc::ApiCall<DeleteMigratingVmRequest, lro::Operation> call);

        partial void Modify_StartMigrationApiCall(ref gaxgrpc::ApiCall<StartMigrationRequest, lro::Operation> call);

        partial void Modify_ResumeMigrationApiCall(ref gaxgrpc::ApiCall<ResumeMigrationRequest, lro::Operation> call);

        partial void Modify_PauseMigrationApiCall(ref gaxgrpc::ApiCall<PauseMigrationRequest, lro::Operation> call);

        partial void Modify_FinalizeMigrationApiCall(ref gaxgrpc::ApiCall<FinalizeMigrationRequest, lro::Operation> call);

        partial void Modify_CreateCloneJobApiCall(ref gaxgrpc::ApiCall<CreateCloneJobRequest, lro::Operation> call);

        partial void Modify_CancelCloneJobApiCall(ref gaxgrpc::ApiCall<CancelCloneJobRequest, lro::Operation> call);

        partial void Modify_ListCloneJobsApiCall(ref gaxgrpc::ApiCall<ListCloneJobsRequest, ListCloneJobsResponse> call);

        partial void Modify_GetCloneJobApiCall(ref gaxgrpc::ApiCall<GetCloneJobRequest, CloneJob> call);

        partial void Modify_CreateCutoverJobApiCall(ref gaxgrpc::ApiCall<CreateCutoverJobRequest, lro::Operation> call);

        partial void Modify_CancelCutoverJobApiCall(ref gaxgrpc::ApiCall<CancelCutoverJobRequest, lro::Operation> call);

        partial void Modify_ListCutoverJobsApiCall(ref gaxgrpc::ApiCall<ListCutoverJobsRequest, ListCutoverJobsResponse> call);

        partial void Modify_GetCutoverJobApiCall(ref gaxgrpc::ApiCall<GetCutoverJobRequest, CutoverJob> call);

        partial void Modify_ListGroupsApiCall(ref gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> call);

        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, Group> call);

        partial void Modify_CreateGroupApiCall(ref gaxgrpc::ApiCall<CreateGroupRequest, lro::Operation> call);

        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> call);

        partial void Modify_DeleteGroupApiCall(ref gaxgrpc::ApiCall<DeleteGroupRequest, lro::Operation> call);

        partial void Modify_AddGroupMigrationApiCall(ref gaxgrpc::ApiCall<AddGroupMigrationRequest, lro::Operation> call);

        partial void Modify_RemoveGroupMigrationApiCall(ref gaxgrpc::ApiCall<RemoveGroupMigrationRequest, lro::Operation> call);

        partial void Modify_ListTargetProjectsApiCall(ref gaxgrpc::ApiCall<ListTargetProjectsRequest, ListTargetProjectsResponse> call);

        partial void Modify_GetTargetProjectApiCall(ref gaxgrpc::ApiCall<GetTargetProjectRequest, TargetProject> call);

        partial void Modify_CreateTargetProjectApiCall(ref gaxgrpc::ApiCall<CreateTargetProjectRequest, lro::Operation> call);

        partial void Modify_UpdateTargetProjectApiCall(ref gaxgrpc::ApiCall<UpdateTargetProjectRequest, lro::Operation> call);

        partial void Modify_DeleteTargetProjectApiCall(ref gaxgrpc::ApiCall<DeleteTargetProjectRequest, lro::Operation> call);

        partial void Modify_ListReplicationCyclesApiCall(ref gaxgrpc::ApiCall<ListReplicationCyclesRequest, ListReplicationCyclesResponse> call);

        partial void Modify_GetReplicationCycleApiCall(ref gaxgrpc::ApiCall<GetReplicationCycleRequest, ReplicationCycle> call);

        partial void OnConstruction(VmMigration.VmMigrationClient grpcClient, VmMigrationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VmMigration client</summary>
        public override VmMigration.VmMigrationClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListSourcesRequest(ref ListSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSourceRequest(ref GetSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSourceRequest(ref CreateSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSourceRequest(ref UpdateSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSourceRequest(ref DeleteSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchInventoryRequest(ref FetchInventoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUtilizationReportsRequest(ref ListUtilizationReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUtilizationReportRequest(ref GetUtilizationReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUtilizationReportRequest(ref CreateUtilizationReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUtilizationReportRequest(ref DeleteUtilizationReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatacenterConnectorsRequest(ref ListDatacenterConnectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatacenterConnectorRequest(ref GetDatacenterConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDatacenterConnectorRequest(ref CreateDatacenterConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatacenterConnectorRequest(ref DeleteDatacenterConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeApplianceRequest(ref UpgradeApplianceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMigratingVmRequest(ref CreateMigratingVmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMigratingVmsRequest(ref ListMigratingVmsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMigratingVmRequest(ref GetMigratingVmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMigratingVmRequest(ref UpdateMigratingVmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMigratingVmRequest(ref DeleteMigratingVmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMigrationRequest(ref StartMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeMigrationRequest(ref ResumeMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseMigrationRequest(ref PauseMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FinalizeMigrationRequest(ref FinalizeMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCloneJobRequest(ref CreateCloneJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelCloneJobRequest(ref CancelCloneJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCloneJobsRequest(ref ListCloneJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloneJobRequest(ref GetCloneJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCutoverJobRequest(ref CreateCutoverJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelCutoverJobRequest(ref CancelCutoverJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCutoverJobsRequest(ref ListCutoverJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCutoverJobRequest(ref GetCutoverJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGroupRequest(ref CreateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGroupRequest(ref DeleteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddGroupMigrationRequest(ref AddGroupMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveGroupMigrationRequest(ref RemoveGroupMigrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetProjectsRequest(ref ListTargetProjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetProjectRequest(ref GetTargetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTargetProjectRequest(ref CreateTargetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTargetProjectRequest(ref UpdateTargetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetProjectRequest(ref DeleteTargetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReplicationCyclesRequest(ref ListReplicationCyclesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReplicationCycleRequest(ref GetReplicationCycleRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public override gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Lists Sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Source GetSource(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Source> GetSourceAsync(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSource</c>.</summary>
        public override lro::OperationsClient CreateSourceOperationsClient { get; }

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Source, OperationMetadata> CreateSource(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return new lro::Operation<Source, OperationMetadata>(_callCreateSource.Sync(request, callSettings), CreateSourceOperationsClient);
        }

        /// <summary>
        /// Creates a new Source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return new lro::Operation<Source, OperationMetadata>(await _callCreateSource.Async(request, callSettings).ConfigureAwait(false), CreateSourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSource</c>.</summary>
        public override lro::OperationsClient UpdateSourceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Source, OperationMetadata> UpdateSource(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return new lro::Operation<Source, OperationMetadata>(_callUpdateSource.Sync(request, callSettings), UpdateSourceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return new lro::Operation<Source, OperationMetadata>(await _callUpdateSource.Async(request, callSettings).ConfigureAwait(false), UpdateSourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSource</c>.</summary>
        public override lro::OperationsClient DeleteSourceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSourceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSource.Sync(request, callSettings), DeleteSourceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSourceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSource.Async(request, callSettings).ConfigureAwait(false), DeleteSourceOperationsClient);
        }

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchInventoryResponse FetchInventory(FetchInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchInventoryRequest(ref request, ref callSettings);
            return _callFetchInventory.Sync(request, callSettings);
        }

        /// <summary>
        /// List remote source's inventory of VMs.
        /// The remote source is the onprem vCenter (remote in the sense it's not in
        /// Compute Engine). The inventory describes the list of existing VMs in that
        /// source. Note that this operation lists the VMs on the remote source, as
        /// opposed to listing the MigratingVms resources in the vmmigration service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchInventoryResponse> FetchInventoryAsync(FetchInventoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchInventoryRequest(ref request, ref callSettings);
            return _callFetchInventory.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UtilizationReport"/> resources.</returns>
        public override gax::PagedEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReports(ListUtilizationReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUtilizationReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUtilizationReportsRequest, ListUtilizationReportsResponse, UtilizationReport>(_callListUtilizationReports, request, callSettings);
        }

        /// <summary>
        /// Lists Utilization Reports of the given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UtilizationReport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUtilizationReportsResponse, UtilizationReport> ListUtilizationReportsAsync(ListUtilizationReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUtilizationReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUtilizationReportsRequest, ListUtilizationReportsResponse, UtilizationReport>(_callListUtilizationReports, request, callSettings);
        }

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UtilizationReport GetUtilizationReport(GetUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUtilizationReportRequest(ref request, ref callSettings);
            return _callGetUtilizationReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UtilizationReport> GetUtilizationReportAsync(GetUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUtilizationReportRequest(ref request, ref callSettings);
            return _callGetUtilizationReport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateUtilizationReport</c>.</summary>
        public override lro::OperationsClient CreateUtilizationReportOperationsClient { get; }

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UtilizationReport, OperationMetadata> CreateUtilizationReport(CreateUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUtilizationReportRequest(ref request, ref callSettings);
            return new lro::Operation<UtilizationReport, OperationMetadata>(_callCreateUtilizationReport.Sync(request, callSettings), CreateUtilizationReportOperationsClient);
        }

        /// <summary>
        /// Creates a new UtilizationReport.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UtilizationReport, OperationMetadata>> CreateUtilizationReportAsync(CreateUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUtilizationReportRequest(ref request, ref callSettings);
            return new lro::Operation<UtilizationReport, OperationMetadata>(await _callCreateUtilizationReport.Async(request, callSettings).ConfigureAwait(false), CreateUtilizationReportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteUtilizationReport</c>.</summary>
        public override lro::OperationsClient DeleteUtilizationReportOperationsClient { get; }

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteUtilizationReport(DeleteUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUtilizationReportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteUtilizationReport.Sync(request, callSettings), DeleteUtilizationReportOperationsClient);
        }

        /// <summary>
        /// Deletes a single Utilization Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteUtilizationReportAsync(DeleteUtilizationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUtilizationReportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteUtilizationReport.Async(request, callSettings).ConfigureAwait(false), DeleteUtilizationReportOperationsClient);
        }

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectors(ListDatacenterConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatacenterConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatacenterConnectorsRequest, ListDatacenterConnectorsResponse, DatacenterConnector>(_callListDatacenterConnectors, request, callSettings);
        }

        /// <summary>
        /// Lists DatacenterConnectors in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatacenterConnector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatacenterConnectorsResponse, DatacenterConnector> ListDatacenterConnectorsAsync(ListDatacenterConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatacenterConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatacenterConnectorsRequest, ListDatacenterConnectorsResponse, DatacenterConnector>(_callListDatacenterConnectors, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DatacenterConnector GetDatacenterConnector(GetDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatacenterConnectorRequest(ref request, ref callSettings);
            return _callGetDatacenterConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DatacenterConnector> GetDatacenterConnectorAsync(GetDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatacenterConnectorRequest(ref request, ref callSettings);
            return _callGetDatacenterConnector.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDatacenterConnector</c>.</summary>
        public override lro::OperationsClient CreateDatacenterConnectorOperationsClient { get; }

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DatacenterConnector, OperationMetadata> CreateDatacenterConnector(CreateDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatacenterConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<DatacenterConnector, OperationMetadata>(_callCreateDatacenterConnector.Sync(request, callSettings), CreateDatacenterConnectorOperationsClient);
        }

        /// <summary>
        /// Creates a new DatacenterConnector in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DatacenterConnector, OperationMetadata>> CreateDatacenterConnectorAsync(CreateDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatacenterConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<DatacenterConnector, OperationMetadata>(await _callCreateDatacenterConnector.Async(request, callSettings).ConfigureAwait(false), CreateDatacenterConnectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDatacenterConnector</c>.</summary>
        public override lro::OperationsClient DeleteDatacenterConnectorOperationsClient { get; }

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDatacenterConnector(DeleteDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatacenterConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDatacenterConnector.Sync(request, callSettings), DeleteDatacenterConnectorOperationsClient);
        }

        /// <summary>
        /// Deletes a single DatacenterConnector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatacenterConnectorAsync(DeleteDatacenterConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatacenterConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDatacenterConnector.Async(request, callSettings).ConfigureAwait(false), DeleteDatacenterConnectorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeAppliance</c>.</summary>
        public override lro::OperationsClient UpgradeApplianceOperationsClient { get; }

        /// <summary>
        /// Upgrades the appliance relate to this DatacenterConnector to the in-place
        /// updateable version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UpgradeApplianceResponse, OperationMetadata> UpgradeAppliance(UpgradeApplianceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeApplianceRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeApplianceResponse, OperationMetadata>(_callUpgradeAppliance.Sync(request, callSettings), UpgradeApplianceOperationsClient);
        }

        /// <summary>
        /// Upgrades the appliance relate to this DatacenterConnector to the in-place
        /// updateable version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UpgradeApplianceResponse, OperationMetadata>> UpgradeApplianceAsync(UpgradeApplianceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeApplianceRequest(ref request, ref callSettings);
            return new lro::Operation<UpgradeApplianceResponse, OperationMetadata>(await _callUpgradeAppliance.Async(request, callSettings).ConfigureAwait(false), UpgradeApplianceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateMigratingVm</c>.</summary>
        public override lro::OperationsClient CreateMigratingVmOperationsClient { get; }

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigratingVm, OperationMetadata> CreateMigratingVm(CreateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<MigratingVm, OperationMetadata>(_callCreateMigratingVm.Sync(request, callSettings), CreateMigratingVmOperationsClient);
        }

        /// <summary>
        /// Creates a new MigratingVm in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigratingVm, OperationMetadata>> CreateMigratingVmAsync(CreateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<MigratingVm, OperationMetadata>(await _callCreateMigratingVm.Async(request, callSettings).ConfigureAwait(false), CreateMigratingVmOperationsClient);
        }

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MigratingVm"/> resources.</returns>
        public override gax::PagedEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVms(ListMigratingVmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigratingVmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMigratingVmsRequest, ListMigratingVmsResponse, MigratingVm>(_callListMigratingVms, request, callSettings);
        }

        /// <summary>
        /// Lists MigratingVms in a given Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MigratingVm"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMigratingVmsResponse, MigratingVm> ListMigratingVmsAsync(ListMigratingVmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMigratingVmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMigratingVmsRequest, ListMigratingVmsResponse, MigratingVm>(_callListMigratingVms, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MigratingVm GetMigratingVm(GetMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigratingVmRequest(ref request, ref callSettings);
            return _callGetMigratingVm.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MigratingVm> GetMigratingVmAsync(GetMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMigratingVmRequest(ref request, ref callSettings);
            return _callGetMigratingVm.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateMigratingVm</c>.</summary>
        public override lro::OperationsClient UpdateMigratingVmOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MigratingVm, OperationMetadata> UpdateMigratingVm(UpdateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<MigratingVm, OperationMetadata>(_callUpdateMigratingVm.Sync(request, callSettings), UpdateMigratingVmOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MigratingVm, OperationMetadata>> UpdateMigratingVmAsync(UpdateMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<MigratingVm, OperationMetadata>(await _callUpdateMigratingVm.Async(request, callSettings).ConfigureAwait(false), UpdateMigratingVmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMigratingVm</c>.</summary>
        public override lro::OperationsClient DeleteMigratingVmOperationsClient { get; }

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMigratingVm(DeleteMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMigratingVm.Sync(request, callSettings), DeleteMigratingVmOperationsClient);
        }

        /// <summary>
        /// Deletes a single MigratingVm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMigratingVmAsync(DeleteMigratingVmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMigratingVmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMigratingVm.Async(request, callSettings).ConfigureAwait(false), DeleteMigratingVmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartMigration</c>.</summary>
        public override lro::OperationsClient StartMigrationOperationsClient { get; }

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StartMigrationResponse, OperationMetadata> StartMigration(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<StartMigrationResponse, OperationMetadata>(_callStartMigration.Sync(request, callSettings), StartMigrationOperationsClient);
        }

        /// <summary>
        /// Starts migration for a VM. Starts the process of uploading
        /// data and creating snapshots, in replication cycles scheduled by the policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StartMigrationResponse, OperationMetadata>> StartMigrationAsync(StartMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<StartMigrationResponse, OperationMetadata>(await _callStartMigration.Async(request, callSettings).ConfigureAwait(false), StartMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeMigration</c>.</summary>
        public override lro::OperationsClient ResumeMigrationOperationsClient { get; }

        /// <summary>
        /// Resumes a migration for a VM. When called on a paused migration, will start
        /// the process of uploading data and creating snapshots; when called on a
        /// completed cut-over migration, will update the migration to active state and
        /// start the process of uploading data and creating snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResumeMigrationResponse, OperationMetadata> ResumeMigration(ResumeMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<ResumeMigrationResponse, OperationMetadata>(_callResumeMigration.Sync(request, callSettings), ResumeMigrationOperationsClient);
        }

        /// <summary>
        /// Resumes a migration for a VM. When called on a paused migration, will start
        /// the process of uploading data and creating snapshots; when called on a
        /// completed cut-over migration, will update the migration to active state and
        /// start the process of uploading data and creating snapshots.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResumeMigrationResponse, OperationMetadata>> ResumeMigrationAsync(ResumeMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<ResumeMigrationResponse, OperationMetadata>(await _callResumeMigration.Async(request, callSettings).ConfigureAwait(false), ResumeMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PauseMigration</c>.</summary>
        public override lro::OperationsClient PauseMigrationOperationsClient { get; }

        /// <summary>
        /// Pauses a migration for a VM. If cycle tasks are running they will be
        /// cancelled, preserving source task data. Further replication cycles will not
        /// be triggered while the VM is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PauseMigrationResponse, OperationMetadata> PauseMigration(PauseMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<PauseMigrationResponse, OperationMetadata>(_callPauseMigration.Sync(request, callSettings), PauseMigrationOperationsClient);
        }

        /// <summary>
        /// Pauses a migration for a VM. If cycle tasks are running they will be
        /// cancelled, preserving source task data. Further replication cycles will not
        /// be triggered while the VM is paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PauseMigrationResponse, OperationMetadata>> PauseMigrationAsync(PauseMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<PauseMigrationResponse, OperationMetadata>(await _callPauseMigration.Async(request, callSettings).ConfigureAwait(false), PauseMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FinalizeMigration</c>.</summary>
        public override lro::OperationsClient FinalizeMigrationOperationsClient { get; }

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FinalizeMigrationResponse, OperationMetadata> FinalizeMigration(FinalizeMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<FinalizeMigrationResponse, OperationMetadata>(_callFinalizeMigration.Sync(request, callSettings), FinalizeMigrationOperationsClient);
        }

        /// <summary>
        /// Marks a migration as completed, deleting migration resources that are no
        /// longer being used. Only applicable after cutover is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FinalizeMigrationResponse, OperationMetadata>> FinalizeMigrationAsync(FinalizeMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<FinalizeMigrationResponse, OperationMetadata>(await _callFinalizeMigration.Async(request, callSettings).ConfigureAwait(false), FinalizeMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCloneJob</c>.</summary>
        public override lro::OperationsClient CreateCloneJobOperationsClient { get; }

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CloneJob, OperationMetadata> CreateCloneJob(CreateCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloneJobRequest(ref request, ref callSettings);
            return new lro::Operation<CloneJob, OperationMetadata>(_callCreateCloneJob.Sync(request, callSettings), CreateCloneJobOperationsClient);
        }

        /// <summary>
        /// Initiates a Clone of a specific migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CloneJob, OperationMetadata>> CreateCloneJobAsync(CreateCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloneJobRequest(ref request, ref callSettings);
            return new lro::Operation<CloneJob, OperationMetadata>(await _callCreateCloneJob.Async(request, callSettings).ConfigureAwait(false), CreateCloneJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CancelCloneJob</c>.</summary>
        public override lro::OperationsClient CancelCloneJobOperationsClient { get; }

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CancelCloneJobResponse, OperationMetadata> CancelCloneJob(CancelCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCloneJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelCloneJobResponse, OperationMetadata>(_callCancelCloneJob.Sync(request, callSettings), CancelCloneJobOperationsClient);
        }

        /// <summary>
        /// Initiates the cancellation of a running clone job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CancelCloneJobResponse, OperationMetadata>> CancelCloneJobAsync(CancelCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCloneJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelCloneJobResponse, OperationMetadata>(await _callCancelCloneJob.Async(request, callSettings).ConfigureAwait(false), CancelCloneJobOperationsClient);
        }

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloneJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobs(ListCloneJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloneJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloneJobsRequest, ListCloneJobsResponse, CloneJob>(_callListCloneJobs, request, callSettings);
        }

        /// <summary>
        /// Lists CloneJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloneJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloneJobsResponse, CloneJob> ListCloneJobsAsync(ListCloneJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloneJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloneJobsRequest, ListCloneJobsResponse, CloneJob>(_callListCloneJobs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloneJob GetCloneJob(GetCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloneJobRequest(ref request, ref callSettings);
            return _callGetCloneJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloneJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloneJob> GetCloneJobAsync(GetCloneJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloneJobRequest(ref request, ref callSettings);
            return _callGetCloneJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCutoverJob</c>.</summary>
        public override lro::OperationsClient CreateCutoverJobOperationsClient { get; }

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CutoverJob, OperationMetadata> CreateCutoverJob(CreateCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCutoverJobRequest(ref request, ref callSettings);
            return new lro::Operation<CutoverJob, OperationMetadata>(_callCreateCutoverJob.Sync(request, callSettings), CreateCutoverJobOperationsClient);
        }

        /// <summary>
        /// Initiates a Cutover of a specific migrating VM.
        /// The returned LRO is completed when the cutover job resource is created
        /// and the job is initiated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CutoverJob, OperationMetadata>> CreateCutoverJobAsync(CreateCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCutoverJobRequest(ref request, ref callSettings);
            return new lro::Operation<CutoverJob, OperationMetadata>(await _callCreateCutoverJob.Async(request, callSettings).ConfigureAwait(false), CreateCutoverJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CancelCutoverJob</c>.</summary>
        public override lro::OperationsClient CancelCutoverJobOperationsClient { get; }

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CancelCutoverJobResponse, OperationMetadata> CancelCutoverJob(CancelCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCutoverJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelCutoverJobResponse, OperationMetadata>(_callCancelCutoverJob.Sync(request, callSettings), CancelCutoverJobOperationsClient);
        }

        /// <summary>
        /// Initiates the cancellation of a running cutover job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CancelCutoverJobResponse, OperationMetadata>> CancelCutoverJobAsync(CancelCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCutoverJobRequest(ref request, ref callSettings);
            return new lro::Operation<CancelCutoverJobResponse, OperationMetadata>(await _callCancelCutoverJob.Async(request, callSettings).ConfigureAwait(false), CancelCutoverJobOperationsClient);
        }

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CutoverJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobs(ListCutoverJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCutoverJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCutoverJobsRequest, ListCutoverJobsResponse, CutoverJob>(_callListCutoverJobs, request, callSettings);
        }

        /// <summary>
        /// Lists CutoverJobs of a given migrating VM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CutoverJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCutoverJobsResponse, CutoverJob> ListCutoverJobsAsync(ListCutoverJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCutoverJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCutoverJobsRequest, ListCutoverJobsResponse, CutoverJob>(_callListCutoverJobs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CutoverJob GetCutoverJob(GetCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCutoverJobRequest(ref request, ref callSettings);
            return _callGetCutoverJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CutoverJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CutoverJob> GetCutoverJobAsync(GetCutoverJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCutoverJobRequest(ref request, ref callSettings);
            return _callGetCutoverJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Lists Groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateGroup</c>.</summary>
        public override lro::OperationsClient CreateGroupOperationsClient { get; }

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Group, OperationMetadata> CreateGroup(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(_callCreateGroup.Sync(request, callSettings), CreateGroupOperationsClient);
        }

        /// <summary>
        /// Creates a new Group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(await _callCreateGroup.Async(request, callSettings).ConfigureAwait(false), CreateGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateGroup</c>.</summary>
        public override lro::OperationsClient UpdateGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Group, OperationMetadata> UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(_callUpdateGroup.Sync(request, callSettings), UpdateGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(await _callUpdateGroup.Async(request, callSettings).ConfigureAwait(false), UpdateGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteGroup</c>.</summary>
        public override lro::OperationsClient DeleteGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteGroup.Sync(request, callSettings), DeleteGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a single Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGroup.Async(request, callSettings).ConfigureAwait(false), DeleteGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddGroupMigration</c>.</summary>
        public override lro::OperationsClient AddGroupMigrationOperationsClient { get; }

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddGroupMigrationResponse, OperationMetadata> AddGroupMigration(AddGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddGroupMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<AddGroupMigrationResponse, OperationMetadata>(_callAddGroupMigration.Sync(request, callSettings), AddGroupMigrationOperationsClient);
        }

        /// <summary>
        /// Adds a MigratingVm to a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddGroupMigrationResponse, OperationMetadata>> AddGroupMigrationAsync(AddGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddGroupMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<AddGroupMigrationResponse, OperationMetadata>(await _callAddGroupMigration.Async(request, callSettings).ConfigureAwait(false), AddGroupMigrationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveGroupMigration</c>.</summary>
        public override lro::OperationsClient RemoveGroupMigrationOperationsClient { get; }

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RemoveGroupMigrationResponse, OperationMetadata> RemoveGroupMigration(RemoveGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveGroupMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>(_callRemoveGroupMigration.Sync(request, callSettings), RemoveGroupMigrationOperationsClient);
        }

        /// <summary>
        /// Removes a MigratingVm from a Group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>> RemoveGroupMigrationAsync(RemoveGroupMigrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveGroupMigrationRequest(ref request, ref callSettings);
            return new lro::Operation<RemoveGroupMigrationResponse, OperationMetadata>(await _callRemoveGroupMigration.Async(request, callSettings).ConfigureAwait(false), RemoveGroupMigrationOperationsClient);
        }

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetProject"/> resources.</returns>
        public override gax::PagedEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjects(ListTargetProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetProjectsRequest, ListTargetProjectsResponse, TargetProject>(_callListTargetProjects, request, callSettings);
        }

        /// <summary>
        /// Lists TargetProjects in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetProject"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTargetProjectsResponse, TargetProject> ListTargetProjectsAsync(ListTargetProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetProjectsRequest, ListTargetProjectsResponse, TargetProject>(_callListTargetProjects, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetProject GetTargetProject(GetTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetProjectRequest(ref request, ref callSettings);
            return _callGetTargetProject.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetProject> GetTargetProjectAsync(GetTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetProjectRequest(ref request, ref callSettings);
            return _callGetTargetProject.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTargetProject</c>.</summary>
        public override lro::OperationsClient CreateTargetProjectOperationsClient { get; }

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TargetProject, OperationMetadata> CreateTargetProject(CreateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<TargetProject, OperationMetadata>(_callCreateTargetProject.Sync(request, callSettings), CreateTargetProjectOperationsClient);
        }

        /// <summary>
        /// Creates a new TargetProject in a given project.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TargetProject, OperationMetadata>> CreateTargetProjectAsync(CreateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<TargetProject, OperationMetadata>(await _callCreateTargetProject.Async(request, callSettings).ConfigureAwait(false), CreateTargetProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTargetProject</c>.</summary>
        public override lro::OperationsClient UpdateTargetProjectOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TargetProject, OperationMetadata> UpdateTargetProject(UpdateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<TargetProject, OperationMetadata>(_callUpdateTargetProject.Sync(request, callSettings), UpdateTargetProjectOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TargetProject, OperationMetadata>> UpdateTargetProjectAsync(UpdateTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<TargetProject, OperationMetadata>(await _callUpdateTargetProject.Async(request, callSettings).ConfigureAwait(false), UpdateTargetProjectOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTargetProject</c>.</summary>
        public override lro::OperationsClient DeleteTargetProjectOperationsClient { get; }

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTargetProject(DeleteTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTargetProject.Sync(request, callSettings), DeleteTargetProjectOperationsClient);
        }

        /// <summary>
        /// Deletes a single TargetProject.
        /// 
        /// NOTE: TargetProject is a global resource; hence the only supported value
        /// for location is `global`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetProjectAsync(DeleteTargetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetProjectRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTargetProject.Async(request, callSettings).ConfigureAwait(false), DeleteTargetProjectOperationsClient);
        }

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public override gax::PagedEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCycles(ListReplicationCyclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationCyclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReplicationCyclesRequest, ListReplicationCyclesResponse, ReplicationCycle>(_callListReplicationCycles, request, callSettings);
        }

        /// <summary>
        /// Lists ReplicationCycles in a given MigratingVM.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReplicationCycle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReplicationCyclesResponse, ReplicationCycle> ListReplicationCyclesAsync(ListReplicationCyclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationCyclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReplicationCyclesRequest, ListReplicationCyclesResponse, ReplicationCycle>(_callListReplicationCycles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReplicationCycle GetReplicationCycle(GetReplicationCycleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationCycleRequest(ref request, ref callSettings);
            return _callGetReplicationCycle.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReplicationCycle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReplicationCycle> GetReplicationCycleAsync(GetReplicationCycleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationCycleRequest(ref request, ref callSettings);
            return _callGetReplicationCycle.Async(request, callSettings);
        }
    }

    public partial class ListSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUtilizationReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatacenterConnectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMigratingVmsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloneJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCutoverJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTargetProjectsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReplicationCyclesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSourcesResponse : gaxgrpc::IPageResponse<Source>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Source> GetEnumerator() => Sources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUtilizationReportsResponse : gaxgrpc::IPageResponse<UtilizationReport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UtilizationReport> GetEnumerator() => UtilizationReports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatacenterConnectorsResponse : gaxgrpc::IPageResponse<DatacenterConnector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DatacenterConnector> GetEnumerator() => DatacenterConnectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMigratingVmsResponse : gaxgrpc::IPageResponse<MigratingVm>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MigratingVm> GetEnumerator() => MigratingVms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCloneJobsResponse : gaxgrpc::IPageResponse<CloneJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloneJob> GetEnumerator() => CloneJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCutoverJobsResponse : gaxgrpc::IPageResponse<CutoverJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CutoverJob> GetEnumerator() => CutoverJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupsResponse : gaxgrpc::IPageResponse<Group>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Group> GetEnumerator() => Groups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTargetProjectsResponse : gaxgrpc::IPageResponse<TargetProject>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetProject> GetEnumerator() => TargetProjects.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReplicationCyclesResponse : gaxgrpc::IPageResponse<ReplicationCycle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReplicationCycle> GetEnumerator() => ReplicationCycles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VmMigration
    {
        public partial class VmMigrationClient
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

    public static partial class VmMigration
    {
        public partial class VmMigrationClient
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
