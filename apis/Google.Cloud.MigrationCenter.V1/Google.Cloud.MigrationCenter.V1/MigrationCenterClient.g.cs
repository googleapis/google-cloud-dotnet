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

namespace Google.Cloud.MigrationCenter.V1
{
    /// <summary>Settings for <see cref="MigrationCenterClient"/> instances.</summary>
    public sealed partial class MigrationCenterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MigrationCenterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MigrationCenterSettings"/>.</returns>
        public static MigrationCenterSettings GetDefault() => new MigrationCenterSettings();

        /// <summary>Constructs a new <see cref="MigrationCenterSettings"/> object with default settings.</summary>
        public MigrationCenterSettings()
        {
        }

        private MigrationCenterSettings(MigrationCenterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAssetsSettings = existing.ListAssetsSettings;
            GetAssetSettings = existing.GetAssetSettings;
            UpdateAssetSettings = existing.UpdateAssetSettings;
            BatchUpdateAssetsSettings = existing.BatchUpdateAssetsSettings;
            DeleteAssetSettings = existing.DeleteAssetSettings;
            BatchDeleteAssetsSettings = existing.BatchDeleteAssetsSettings;
            ReportAssetFramesSettings = existing.ReportAssetFramesSettings;
            AggregateAssetsValuesSettings = existing.AggregateAssetsValuesSettings;
            CreateImportJobSettings = existing.CreateImportJobSettings;
            CreateImportJobOperationsSettings = existing.CreateImportJobOperationsSettings.Clone();
            ListImportJobsSettings = existing.ListImportJobsSettings;
            GetImportJobSettings = existing.GetImportJobSettings;
            DeleteImportJobSettings = existing.DeleteImportJobSettings;
            DeleteImportJobOperationsSettings = existing.DeleteImportJobOperationsSettings.Clone();
            UpdateImportJobSettings = existing.UpdateImportJobSettings;
            UpdateImportJobOperationsSettings = existing.UpdateImportJobOperationsSettings.Clone();
            ValidateImportJobSettings = existing.ValidateImportJobSettings;
            ValidateImportJobOperationsSettings = existing.ValidateImportJobOperationsSettings.Clone();
            RunImportJobSettings = existing.RunImportJobSettings;
            RunImportJobOperationsSettings = existing.RunImportJobOperationsSettings.Clone();
            GetImportDataFileSettings = existing.GetImportDataFileSettings;
            ListImportDataFilesSettings = existing.ListImportDataFilesSettings;
            CreateImportDataFileSettings = existing.CreateImportDataFileSettings;
            CreateImportDataFileOperationsSettings = existing.CreateImportDataFileOperationsSettings.Clone();
            DeleteImportDataFileSettings = existing.DeleteImportDataFileSettings;
            DeleteImportDataFileOperationsSettings = existing.DeleteImportDataFileOperationsSettings.Clone();
            ListGroupsSettings = existing.ListGroupsSettings;
            GetGroupSettings = existing.GetGroupSettings;
            CreateGroupSettings = existing.CreateGroupSettings;
            CreateGroupOperationsSettings = existing.CreateGroupOperationsSettings.Clone();
            UpdateGroupSettings = existing.UpdateGroupSettings;
            UpdateGroupOperationsSettings = existing.UpdateGroupOperationsSettings.Clone();
            DeleteGroupSettings = existing.DeleteGroupSettings;
            DeleteGroupOperationsSettings = existing.DeleteGroupOperationsSettings.Clone();
            AddAssetsToGroupSettings = existing.AddAssetsToGroupSettings;
            AddAssetsToGroupOperationsSettings = existing.AddAssetsToGroupOperationsSettings.Clone();
            RemoveAssetsFromGroupSettings = existing.RemoveAssetsFromGroupSettings;
            RemoveAssetsFromGroupOperationsSettings = existing.RemoveAssetsFromGroupOperationsSettings.Clone();
            ListErrorFramesSettings = existing.ListErrorFramesSettings;
            GetErrorFrameSettings = existing.GetErrorFrameSettings;
            ListSourcesSettings = existing.ListSourcesSettings;
            GetSourceSettings = existing.GetSourceSettings;
            CreateSourceSettings = existing.CreateSourceSettings;
            CreateSourceOperationsSettings = existing.CreateSourceOperationsSettings.Clone();
            UpdateSourceSettings = existing.UpdateSourceSettings;
            UpdateSourceOperationsSettings = existing.UpdateSourceOperationsSettings.Clone();
            DeleteSourceSettings = existing.DeleteSourceSettings;
            DeleteSourceOperationsSettings = existing.DeleteSourceOperationsSettings.Clone();
            ListPreferenceSetsSettings = existing.ListPreferenceSetsSettings;
            GetPreferenceSetSettings = existing.GetPreferenceSetSettings;
            CreatePreferenceSetSettings = existing.CreatePreferenceSetSettings;
            CreatePreferenceSetOperationsSettings = existing.CreatePreferenceSetOperationsSettings.Clone();
            UpdatePreferenceSetSettings = existing.UpdatePreferenceSetSettings;
            UpdatePreferenceSetOperationsSettings = existing.UpdatePreferenceSetOperationsSettings.Clone();
            DeletePreferenceSetSettings = existing.DeletePreferenceSetSettings;
            DeletePreferenceSetOperationsSettings = existing.DeletePreferenceSetOperationsSettings.Clone();
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            UpdateSettingsOperationsSettings = existing.UpdateSettingsOperationsSettings.Clone();
            CreateReportConfigSettings = existing.CreateReportConfigSettings;
            CreateReportConfigOperationsSettings = existing.CreateReportConfigOperationsSettings.Clone();
            GetReportConfigSettings = existing.GetReportConfigSettings;
            ListReportConfigsSettings = existing.ListReportConfigsSettings;
            DeleteReportConfigSettings = existing.DeleteReportConfigSettings;
            DeleteReportConfigOperationsSettings = existing.DeleteReportConfigOperationsSettings.Clone();
            CreateReportSettings = existing.CreateReportSettings;
            CreateReportOperationsSettings = existing.CreateReportOperationsSettings.Clone();
            GetReportSettings = existing.GetReportSettings;
            ListReportsSettings = existing.ListReportsSettings;
            DeleteReportSettings = existing.DeleteReportSettings;
            DeleteReportOperationsSettings = existing.DeleteReportOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MigrationCenterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListAssets</c> and <c>MigrationCenterClient.ListAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetAsset</c> and <c>MigrationCenterClient.GetAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.UpdateAsset</c> and <c>MigrationCenterClient.UpdateAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.BatchUpdateAssets</c> and <c>MigrationCenterClient.BatchUpdateAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeleteAsset</c> and <c>MigrationCenterClient.DeleteAssetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.BatchDeleteAssets</c> and <c>MigrationCenterClient.BatchDeleteAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ReportAssetFrames</c> and <c>MigrationCenterClient.ReportAssetFramesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportAssetFramesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.AggregateAssetsValues</c> and <c>MigrationCenterClient.AggregateAssetsValuesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregateAssetsValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.CreateImportJob</c> and <c>MigrationCenterClient.CreateImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateImportJob</c> and
        /// <c>MigrationCenterClient.CreateImportJobAsync</c>.
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
        public lro::OperationsSettings CreateImportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListImportJobs</c> and <c>MigrationCenterClient.ListImportJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListImportJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetImportJob</c> and <c>MigrationCenterClient.GetImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeleteImportJob</c> and <c>MigrationCenterClient.DeleteImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteImportJob</c> and
        /// <c>MigrationCenterClient.DeleteImportJobAsync</c>.
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
        public lro::OperationsSettings DeleteImportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.UpdateImportJob</c> and <c>MigrationCenterClient.UpdateImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.UpdateImportJob</c> and
        /// <c>MigrationCenterClient.UpdateImportJobAsync</c>.
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
        public lro::OperationsSettings UpdateImportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ValidateImportJob</c> and <c>MigrationCenterClient.ValidateImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.ValidateImportJob</c> and
        /// <c>MigrationCenterClient.ValidateImportJobAsync</c>.
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
        public lro::OperationsSettings ValidateImportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.RunImportJob</c> and <c>MigrationCenterClient.RunImportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunImportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.RunImportJob</c> and
        /// <c>MigrationCenterClient.RunImportJobAsync</c>.
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
        public lro::OperationsSettings RunImportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetImportDataFile</c> and <c>MigrationCenterClient.GetImportDataFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetImportDataFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListImportDataFiles</c> and <c>MigrationCenterClient.ListImportDataFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListImportDataFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.CreateImportDataFile</c> and <c>MigrationCenterClient.CreateImportDataFileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateImportDataFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateImportDataFile</c> and
        /// <c>MigrationCenterClient.CreateImportDataFileAsync</c>.
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
        public lro::OperationsSettings CreateImportDataFileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeleteImportDataFile</c> and <c>MigrationCenterClient.DeleteImportDataFileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteImportDataFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteImportDataFile</c> and
        /// <c>MigrationCenterClient.DeleteImportDataFileAsync</c>.
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
        public lro::OperationsSettings DeleteImportDataFileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListGroups</c> and <c>MigrationCenterClient.ListGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetGroup</c> and <c>MigrationCenterClient.GetGroupAsync</c>.
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
        /// <c>MigrationCenterClient.CreateGroup</c> and <c>MigrationCenterClient.CreateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateGroup</c> and
        /// <c>MigrationCenterClient.CreateGroupAsync</c>.
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
        /// <c>MigrationCenterClient.UpdateGroup</c> and <c>MigrationCenterClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.UpdateGroup</c> and
        /// <c>MigrationCenterClient.UpdateGroupAsync</c>.
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
        /// <c>MigrationCenterClient.DeleteGroup</c> and <c>MigrationCenterClient.DeleteGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteGroup</c> and
        /// <c>MigrationCenterClient.DeleteGroupAsync</c>.
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
        /// <c>MigrationCenterClient.AddAssetsToGroup</c> and <c>MigrationCenterClient.AddAssetsToGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAssetsToGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.AddAssetsToGroup</c> and
        /// <c>MigrationCenterClient.AddAssetsToGroupAsync</c>.
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
        public lro::OperationsSettings AddAssetsToGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.RemoveAssetsFromGroup</c> and <c>MigrationCenterClient.RemoveAssetsFromGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAssetsFromGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.RemoveAssetsFromGroup</c> and
        /// <c>MigrationCenterClient.RemoveAssetsFromGroupAsync</c>.
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
        public lro::OperationsSettings RemoveAssetsFromGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListErrorFrames</c> and <c>MigrationCenterClient.ListErrorFramesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListErrorFramesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetErrorFrame</c> and <c>MigrationCenterClient.GetErrorFrameAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetErrorFrameSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListSources</c> and <c>MigrationCenterClient.ListSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetSource</c> and <c>MigrationCenterClient.GetSourceAsync</c>.
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
        /// <c>MigrationCenterClient.CreateSource</c> and <c>MigrationCenterClient.CreateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateSource</c> and
        /// <c>MigrationCenterClient.CreateSourceAsync</c>.
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
        /// <c>MigrationCenterClient.UpdateSource</c> and <c>MigrationCenterClient.UpdateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.UpdateSource</c> and
        /// <c>MigrationCenterClient.UpdateSourceAsync</c>.
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
        /// <c>MigrationCenterClient.DeleteSource</c> and <c>MigrationCenterClient.DeleteSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteSource</c> and
        /// <c>MigrationCenterClient.DeleteSourceAsync</c>.
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
        /// <c>MigrationCenterClient.ListPreferenceSets</c> and <c>MigrationCenterClient.ListPreferenceSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPreferenceSetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetPreferenceSet</c> and <c>MigrationCenterClient.GetPreferenceSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPreferenceSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.CreatePreferenceSet</c> and <c>MigrationCenterClient.CreatePreferenceSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePreferenceSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreatePreferenceSet</c> and
        /// <c>MigrationCenterClient.CreatePreferenceSetAsync</c>.
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
        public lro::OperationsSettings CreatePreferenceSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.UpdatePreferenceSet</c> and <c>MigrationCenterClient.UpdatePreferenceSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePreferenceSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.UpdatePreferenceSet</c> and
        /// <c>MigrationCenterClient.UpdatePreferenceSetAsync</c>.
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
        public lro::OperationsSettings UpdatePreferenceSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeletePreferenceSet</c> and <c>MigrationCenterClient.DeletePreferenceSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePreferenceSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeletePreferenceSet</c> and
        /// <c>MigrationCenterClient.DeletePreferenceSetAsync</c>.
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
        public lro::OperationsSettings DeletePreferenceSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetSettings</c> and <c>MigrationCenterClient.GetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.UpdateSettings</c> and <c>MigrationCenterClient.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.UpdateSettings</c> and
        /// <c>MigrationCenterClient.UpdateSettingsAsync</c>.
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
        public lro::OperationsSettings UpdateSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.CreateReportConfig</c> and <c>MigrationCenterClient.CreateReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateReportConfig</c> and
        /// <c>MigrationCenterClient.CreateReportConfigAsync</c>.
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
        public lro::OperationsSettings CreateReportConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetReportConfig</c> and <c>MigrationCenterClient.GetReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListReportConfigs</c> and <c>MigrationCenterClient.ListReportConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeleteReportConfig</c> and <c>MigrationCenterClient.DeleteReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteReportConfig</c> and
        /// <c>MigrationCenterClient.DeleteReportConfigAsync</c>.
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
        public lro::OperationsSettings DeleteReportConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.CreateReport</c> and <c>MigrationCenterClient.CreateReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.CreateReport</c> and
        /// <c>MigrationCenterClient.CreateReportAsync</c>.
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
        public lro::OperationsSettings CreateReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.GetReport</c> and <c>MigrationCenterClient.GetReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.ListReports</c> and <c>MigrationCenterClient.ListReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MigrationCenterClient.DeleteReport</c> and <c>MigrationCenterClient.DeleteReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MigrationCenterClient.DeleteReport</c> and
        /// <c>MigrationCenterClient.DeleteReportAsync</c>.
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
        public lro::OperationsSettings DeleteReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MigrationCenterSettings"/> object.</returns>
        public MigrationCenterSettings Clone() => new MigrationCenterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MigrationCenterClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MigrationCenterClientBuilder : gaxgrpc::ClientBuilderBase<MigrationCenterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MigrationCenterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MigrationCenterClientBuilder() : base(MigrationCenterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MigrationCenterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MigrationCenterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MigrationCenterClient Build()
        {
            MigrationCenterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MigrationCenterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MigrationCenterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MigrationCenterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MigrationCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MigrationCenterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MigrationCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MigrationCenterClient.ChannelPool;
    }

    /// <summary>MigrationCenter client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class MigrationCenterClient
    {
        /// <summary>
        /// The default endpoint for the MigrationCenter service, which is a host of "migrationcenter.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "migrationcenter.googleapis.com:443";

        /// <summary>The default MigrationCenter scopes.</summary>
        /// <remarks>
        /// The default MigrationCenter scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MigrationCenter.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MigrationCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MigrationCenterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MigrationCenterClient"/>.</returns>
        public static stt::Task<MigrationCenterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MigrationCenterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MigrationCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MigrationCenterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MigrationCenterClient"/>.</returns>
        public static MigrationCenterClient Create() => new MigrationCenterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MigrationCenterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MigrationCenterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MigrationCenterClient"/>.</returns>
        internal static MigrationCenterClient Create(grpccore::CallInvoker callInvoker, MigrationCenterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MigrationCenter.MigrationCenterClient grpcClient = new MigrationCenter.MigrationCenterClient(callInvoker);
            return new MigrationCenterClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MigrationCenter client</summary>
        public virtual MigrationCenter.MigrationCenterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListAssetsRequest`.
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
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssets(request, callSettings);
        }

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListAssetsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListAssetsRequest`.
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
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssets(request, callSettings);
        }

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListAssetsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssetsRequest request = new ListAssetsRequest
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
            return ListAssetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(GetAssetRequest request, st::CancellationToken cancellationToken) =>
            GetAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(string name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset GetAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAsset(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetAsync(new GetAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> GetAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            GetAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="asset">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Asset UpdateAsset(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsset(new UpdateAssetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="asset">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssetAsync(new UpdateAssetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Asset = gax::GaxPreconditions.CheckNotNull(asset, nameof(asset)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="asset">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Asset> UpdateAssetAsync(Asset asset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAssetAsync(asset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAssetsResponse BatchUpdateAssets(BatchUpdateAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(BatchUpdateAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(BatchUpdateAssetsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAssetsResponse BatchUpdateAssets(string parent, scg::IEnumerable<UpdateAssetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAssets(new BatchUpdateAssetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(string parent, scg::IEnumerable<UpdateAssetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAssetsAsync(new BatchUpdateAssetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(string parent, scg::IEnumerable<UpdateAssetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAssetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateAssetsResponse BatchUpdateAssets(gagr::LocationName parent, scg::IEnumerable<UpdateAssetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAssets(new BatchUpdateAssetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(gagr::LocationName parent, scg::IEnumerable<UpdateAssetRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateAssetsAsync(new BatchUpdateAssetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset update.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the resources to update.
        /// A maximum of 1000 assets can be modified in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(gagr::LocationName parent, scg::IEnumerable<UpdateAssetRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateAssetsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(DeleteAssetRequest request, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAsset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAsset(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsset(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(AssetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssetAsync(new DeleteAssetRequest
            {
                AssetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssetAsync(AssetName name, st::CancellationToken cancellationToken) =>
            DeleteAssetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAssets(BatchDeleteAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(BatchDeleteAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(BatchDeleteAssetsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAssets(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAssets(new BatchDeleteAssetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAssetsAsync(new BatchDeleteAssetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeleteAssetsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteAssets(gagr::LocationName parent, scg::IEnumerable<AssetName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAssets(new BatchDeleteAssetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssetNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(gagr::LocationName parent, scg::IEnumerable<AssetName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteAssetsAsync(new BatchDeleteAssetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssetNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for batch asset delete.
        /// </param>
        /// <param name="names">
        /// Required. The IDs of the assets to delete.
        /// A maximum of 1000 assets can be deleted in a batch.
        /// Format: projects/{project}/locations/{location}/assets/{name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteAssetsAsync(gagr::LocationName parent, scg::IEnumerable<AssetName> names, st::CancellationToken cancellationToken) =>
            BatchDeleteAssetsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports a set of frames.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportAssetFramesResponse ReportAssetFrames(ReportAssetFramesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports a set of frames.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportAssetFramesResponse> ReportAssetFramesAsync(ReportAssetFramesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports a set of frames.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportAssetFramesResponse> ReportAssetFramesAsync(ReportAssetFramesRequest request, st::CancellationToken cancellationToken) =>
            ReportAssetFramesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Aggregates the requested fields based on provided function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AggregateAssetsValuesResponse AggregateAssetsValues(AggregateAssetsValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates the requested fields based on provided function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateAssetsValuesResponse> AggregateAssetsValuesAsync(AggregateAssetsValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates the requested fields based on provided function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateAssetsValuesResponse> AggregateAssetsValuesAsync(AggregateAssetsValuesRequest request, st::CancellationToken cancellationToken) =>
            AggregateAssetsValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> CreateImportJob(CreateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(CreateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(CreateImportJobRequest request, st::CancellationToken cancellationToken) =>
            CreateImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateImportJob</c>.</summary>
        public virtual lro::OperationsClient CreateImportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> PollOnceCreateImportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> PollOnceCreateImportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> CreateImportJob(string parent, ImportJob importJob, string importJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportJob(new CreateImportJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(string parent, ImportJob importJob, string importJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportJobAsync(new CreateImportJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(string parent, ImportJob importJob, string importJobId, st::CancellationToken cancellationToken) =>
            CreateImportJobAsync(parent, importJob, importJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> CreateImportJob(gagr::LocationName parent, ImportJob importJob, string importJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportJob(new CreateImportJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(gagr::LocationName parent, ImportJob importJob, string importJobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportJobAsync(new CreateImportJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportJobId = gax::GaxPreconditions.CheckNotNullOrEmpty(importJobId, nameof(importJobId)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="importJob">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importJobId">
        /// Required. ID of the import job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(gagr::LocationName parent, ImportJob importJob, string importJobId, st::CancellationToken cancellationToken) =>
            CreateImportJobAsync(parent, importJob, importJobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportJobsResponse, ImportJob> ListImportJobs(ListImportJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> ListImportJobsAsync(ListImportJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListImportJobsRequest`.
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
        /// <returns>A pageable sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportJobsResponse, ImportJob> ListImportJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportJobsRequest request = new ListImportJobsRequest
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
            return ListImportJobs(request, callSettings);
        }

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListImportJobsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> ListImportJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportJobsRequest request = new ListImportJobsRequest
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
            return ListImportJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListImportJobsRequest`.
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
        /// <returns>A pageable sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportJobsResponse, ImportJob> ListImportJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportJobsRequest request = new ListImportJobsRequest
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
            return ListImportJobs(request, callSettings);
        }

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListImportJobsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ImportJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> ListImportJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportJobsRequest request = new ListImportJobsRequest
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
            return ListImportJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportJob GetImportJob(GetImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(GetImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(GetImportJobRequest request, st::CancellationToken cancellationToken) =>
            GetImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportJob GetImportJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportJob(new GetImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportJobAsync(new GetImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportJob GetImportJob(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportJob(new GetImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportJobAsync(new GetImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportJob> GetImportJobAsync(ImportJobName name, st::CancellationToken cancellationToken) =>
            GetImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportJob(DeleteImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(DeleteImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(DeleteImportJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteImportJob</c>.</summary>
        public virtual lro::OperationsClient DeleteImportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteImportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteImportJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteImportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteImportJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportJob(new DeleteImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportJobAsync(new DeleteImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportJob(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportJob(new DeleteImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportJobAsync(new DeleteImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(ImportJobName name, st::CancellationToken cancellationToken) =>
            DeleteImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> UpdateImportJob(UpdateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> UpdateImportJobAsync(UpdateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> UpdateImportJobAsync(UpdateImportJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateImportJob</c>.</summary>
        public virtual lro::OperationsClient UpdateImportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> PollOnceUpdateImportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportJob, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> PollOnceUpdateImportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportJob, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="importJob">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportJob, OperationMetadata> UpdateImportJob(ImportJob importJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateImportJob(new UpdateImportJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="importJob">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> UpdateImportJobAsync(ImportJob importJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateImportJobAsync(new UpdateImportJobRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ImportJob = gax::GaxPreconditions.CheckNotNull(importJob, nameof(importJob)),
            }, callSettings);

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="importJob">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Asset` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportJob, OperationMetadata>> UpdateImportJobAsync(ImportJob importJob, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateImportJobAsync(importJob, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ValidateImportJob(ValidateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(ValidateImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(ValidateImportJobRequest request, st::CancellationToken cancellationToken) =>
            ValidateImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ValidateImportJob</c>.</summary>
        public virtual lro::OperationsClient ValidateImportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ValidateImportJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceValidateImportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ValidateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ValidateImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceValidateImportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ValidateImportJobOperationsClient, callSettings);

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ValidateImportJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            ValidateImportJob(new ValidateImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ValidateImportJobAsync(new ValidateImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(string name, st::CancellationToken cancellationToken) =>
            ValidateImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ValidateImportJob(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ValidateImportJob(new ValidateImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ValidateImportJobAsync(new ValidateImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to validate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(ImportJobName name, st::CancellationToken cancellationToken) =>
            ValidateImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> RunImportJob(RunImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(RunImportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(RunImportJobRequest request, st::CancellationToken cancellationToken) =>
            RunImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunImportJob</c>.</summary>
        public virtual lro::OperationsClient RunImportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceRunImportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunImportJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunImportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceRunImportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunImportJobOperationsClient, callSettings);

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> RunImportJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunImportJob(new RunImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunImportJobAsync(new RunImportJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(string name, st::CancellationToken cancellationToken) =>
            RunImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> RunImportJob(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunImportJob(new RunImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(ImportJobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunImportJobAsync(new RunImportJobRequest
            {
                ImportJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the import job to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(ImportJobName name, st::CancellationToken cancellationToken) =>
            RunImportJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportDataFile GetImportDataFile(GetImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(GetImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(GetImportDataFileRequest request, st::CancellationToken cancellationToken) =>
            GetImportDataFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportDataFile GetImportDataFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportDataFile(new GetImportDataFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportDataFileAsync(new GetImportDataFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(string name, st::CancellationToken cancellationToken) =>
            GetImportDataFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportDataFile GetImportDataFile(ImportDataFileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportDataFile(new GetImportDataFileRequest
            {
                ImportDataFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(ImportDataFileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetImportDataFileAsync(new GetImportDataFileRequest
            {
                ImportDataFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportDataFile> GetImportDataFileAsync(ImportDataFileName name, st::CancellationToken cancellationToken) =>
            GetImportDataFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFiles(ListImportDataFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFilesAsync(ListImportDataFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the `ImportDataFiles` resource.
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
        /// <returns>A pageable sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
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
            return ListImportDataFiles(request, callSettings);
        }

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the `ImportDataFiles` resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
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
            return ListImportDataFilesAsync(request, callSettings);
        }

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the `ImportDataFiles` resource.
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
        /// <returns>A pageable sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFiles(ImportJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
            {
                ParentAsImportJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListImportDataFiles(request, callSettings);
        }

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the `ImportDataFiles` resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ImportDataFile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFilesAsync(ImportJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImportDataFilesRequest request = new ListImportDataFilesRequest
            {
                ParentAsImportJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListImportDataFilesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataFile, OperationMetadata> CreateImportDataFile(CreateImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(CreateImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(CreateImportDataFileRequest request, st::CancellationToken cancellationToken) =>
            CreateImportDataFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateImportDataFile</c>.</summary>
        public virtual lro::OperationsClient CreateImportDataFileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateImportDataFile</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportDataFile, OperationMetadata> PollOnceCreateImportDataFile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataFile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateImportDataFileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateImportDataFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> PollOnceCreateImportDataFileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataFile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateImportDataFileOperationsClient, callSettings);

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataFile, OperationMetadata> CreateImportDataFile(string parent, ImportDataFile importDataFile, string importDataFileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportDataFile(new CreateImportDataFileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportDataFileId = gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)),
                ImportDataFile = gax::GaxPreconditions.CheckNotNull(importDataFile, nameof(importDataFile)),
            }, callSettings);

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(string parent, ImportDataFile importDataFile, string importDataFileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportDataFileAsync(new CreateImportDataFileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ImportDataFileId = gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)),
                ImportDataFile = gax::GaxPreconditions.CheckNotNull(importDataFile, nameof(importDataFile)),
            }, callSettings);

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(string parent, ImportDataFile importDataFile, string importDataFileId, st::CancellationToken cancellationToken) =>
            CreateImportDataFileAsync(parent, importDataFile, importDataFileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataFile, OperationMetadata> CreateImportDataFile(ImportJobName parent, ImportDataFile importDataFile, string importDataFileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportDataFile(new CreateImportDataFileRequest
            {
                ParentAsImportJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportDataFileId = gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)),
                ImportDataFile = gax::GaxPreconditions.CheckNotNull(importDataFile, nameof(importDataFile)),
            }, callSettings);

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(ImportJobName parent, ImportDataFile importDataFile, string importDataFileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateImportDataFileAsync(new CreateImportDataFileRequest
            {
                ParentAsImportJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ImportDataFileId = gax::GaxPreconditions.CheckNotNullOrEmpty(importDataFileId, nameof(importDataFileId)),
                ImportDataFile = gax::GaxPreconditions.CheckNotNull(importDataFile, nameof(importDataFile)),
            }, callSettings);

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent of the ImportDataFile.
        /// </param>
        /// <param name="importDataFile">
        /// Required. The resource being created.
        /// </param>
        /// <param name="importDataFileId">
        /// Required. The ID of the new data file.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(ImportJobName parent, ImportDataFile importDataFile, string importDataFileId, st::CancellationToken cancellationToken) =>
            CreateImportDataFileAsync(parent, importDataFile, importDataFileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportDataFile(DeleteImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(DeleteImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(DeleteImportDataFileRequest request, st::CancellationToken cancellationToken) =>
            DeleteImportDataFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteImportDataFile</c>.</summary>
        public virtual lro::OperationsClient DeleteImportDataFileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteImportDataFile</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteImportDataFile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteImportDataFileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteImportDataFile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteImportDataFileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteImportDataFileOperationsClient, callSettings);

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportDataFile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportDataFile(new DeleteImportDataFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportDataFileAsync(new DeleteImportDataFileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteImportDataFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteImportDataFile(ImportDataFileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportDataFile(new DeleteImportDataFileRequest
            {
                ImportDataFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(ImportDataFileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteImportDataFileAsync(new DeleteImportDataFileRequest
            {
                ImportDataFileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ImportDataFile to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(ImportDataFileName name, st::CancellationToken cancellationToken) =>
            DeleteImportDataFileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListGroupsRequest`.
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
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListGroupsRequest`.
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
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListGroupsRequest`.
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
        /// Lists all groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListGroupsRequest`.
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
        /// Gets the details of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, st::CancellationToken cancellationToken) =>
            GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> CreateGroup(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new group in a given project and location.
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
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(string parent, Group group, string groupId, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(parent, group, groupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="group">
        /// Required. The group resource being created.
        /// </param>
        /// <param name="groupId">
        /// Required. User specified ID for the group. It will become the last
        /// component of the group name. The ID must be unique within the project, must
        /// conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> CreateGroupAsync(gagr::LocationName parent, Group group, string groupId, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(parent, group, groupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a group.
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
        /// Updates the parameters of a group.
        /// </summary>
        /// <param name="group">
        /// Required. The group resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Group` resource by the update.
        /// The values specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> UpdateGroup(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroup(new UpdateGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a group.
        /// </summary>
        /// <param name="group">
        /// Required. The group resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Group` resource by the update.
        /// The values specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroupAsync(new UpdateGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a group.
        /// </summary>
        /// <param name="group">
        /// Required. The group resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Group` resource by the update.
        /// The values specified in the `update_mask` are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> UpdateGroupAsync(Group group, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(group, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a group.
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
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> AddAssetsToGroup(AddAssetsToGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(AddAssetsToGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(AddAssetsToGroupRequest request, st::CancellationToken cancellationToken) =>
            AddAssetsToGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddAssetsToGroup</c>.</summary>
        public virtual lro::OperationsClient AddAssetsToGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddAssetsToGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Group, OperationMetadata> PollOnceAddAssetsToGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAssetsToGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddAssetsToGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> PollOnceAddAssetsToGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAssetsToGroupOperationsClient, callSettings);

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> AddAssetsToGroup(string group, gaxgrpc::CallSettings callSettings = null) =>
            AddAssetsToGroup(new AddAssetsToGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(string group, gaxgrpc::CallSettings callSettings = null) =>
            AddAssetsToGroupAsync(new AddAssetsToGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(string group, st::CancellationToken cancellationToken) =>
            AddAssetsToGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> AddAssetsToGroup(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            AddAssetsToGroup(new AddAssetsToGroupRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            AddAssetsToGroupAsync(new AddAssetsToGroupRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(GroupName group, st::CancellationToken cancellationToken) =>
            AddAssetsToGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> RemoveAssetsFromGroup(RemoveAssetsFromGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(RemoveAssetsFromGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(RemoveAssetsFromGroupRequest request, st::CancellationToken cancellationToken) =>
            RemoveAssetsFromGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveAssetsFromGroup</c>.</summary>
        public virtual lro::OperationsClient RemoveAssetsFromGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RemoveAssetsFromGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Group, OperationMetadata> PollOnceRemoveAssetsFromGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAssetsFromGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveAssetsFromGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> PollOnceRemoveAssetsFromGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Group, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAssetsFromGroupOperationsClient, callSettings);

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> RemoveAssetsFromGroup(string group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssetsFromGroup(new RemoveAssetsFromGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(string group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssetsFromGroupAsync(new RemoveAssetsFromGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNullOrEmpty(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(string group, st::CancellationToken cancellationToken) =>
            RemoveAssetsFromGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Group, OperationMetadata> RemoveAssetsFromGroup(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssetsFromGroup(new RemoveAssetsFromGroupRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(GroupName group, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAssetsFromGroupAsync(new RemoveAssetsFromGroupRequest
            {
                GroupAsGroupName = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="group">
        /// Required. Group reference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(GroupName group, st::CancellationToken cancellationToken) =>
            RemoveAssetsFromGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFrames(ListErrorFramesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFramesAsync(ListErrorFramesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (the source) for `ListErrorFramesRequest`.
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
        /// <returns>A pageable sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFrames(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListErrorFramesRequest request = new ListErrorFramesRequest
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
            return ListErrorFrames(request, callSettings);
        }

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (the source) for `ListErrorFramesRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFramesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListErrorFramesRequest request = new ListErrorFramesRequest
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
            return ListErrorFramesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (the source) for `ListErrorFramesRequest`.
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
        /// <returns>A pageable sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFrames(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListErrorFramesRequest request = new ListErrorFramesRequest
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
            return ListErrorFrames(request, callSettings);
        }

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value (the source) for `ListErrorFramesRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorFrame"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFramesAsync(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListErrorFramesRequest request = new ListErrorFramesRequest
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
            return ListErrorFramesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorFrame GetErrorFrame(GetErrorFrameRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(GetErrorFrameRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(GetErrorFrameRequest request, st::CancellationToken cancellationToken) =>
            GetErrorFrameAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorFrame GetErrorFrame(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetErrorFrame(new GetErrorFrameRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetErrorFrameAsync(new GetErrorFrameRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(string name, st::CancellationToken cancellationToken) =>
            GetErrorFrameAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorFrame GetErrorFrame(ErrorFrameName name, gaxgrpc::CallSettings callSettings = null) =>
            GetErrorFrame(new GetErrorFrameRequest
            {
                ErrorFrameName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(ErrorFrameName name, gaxgrpc::CallSettings callSettings = null) =>
            GetErrorFrameAsync(new GetErrorFrameRequest
            {
                ErrorFrameName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the frame to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/sources/{source}/errorFrames/{error_frame}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorFrame> GetErrorFrameAsync(ErrorFrameName name, st::CancellationToken cancellationToken) =>
            GetErrorFrameAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListSourcesRequest`.
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
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListSourcesRequest`.
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
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListSourcesRequest`.
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
        /// Lists all the sources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListSourcesRequest`.
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
        /// Gets the details of a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, st::CancellationToken cancellationToken) =>
            GetSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> CreateSource(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new source in a given project and location.
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
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(string parent, Source source, string sourceId, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, sourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
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
        /// Creates a new source in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="source">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sourceId">
        /// Required. User specified ID for the source. It will become the last
        /// component of the source name. The ID must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The ID must match the regular expression:
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> CreateSourceAsync(gagr::LocationName parent, Source source, string sourceId, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, sourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> UpdateSource(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a source.
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
        /// Updates the parameters of a source.
        /// </summary>
        /// <param name="source">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Source` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Source, OperationMetadata> UpdateSource(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSource(new UpdateSourceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a source.
        /// </summary>
        /// <param name="source">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Source` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSourceAsync(new UpdateSourceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a source.
        /// </summary>
        /// <param name="source">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Source` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Source, OperationMetadata>> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSourceAsync(source, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(DeleteSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a source.
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
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSource(new DeleteSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSourceAsync(new DeleteSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSource(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSource(new DeleteSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSourceAsync(new DeleteSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a source.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSourceAsync(SourceName name, st::CancellationToken cancellationToken) =>
            DeleteSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSets(ListPreferenceSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSetsAsync(ListPreferenceSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListPreferenceSetsRequest`.
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
        /// <returns>A pageable sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
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
            return ListPreferenceSets(request, callSettings);
        }

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListPreferenceSetsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
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
            return ListPreferenceSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListPreferenceSetsRequest`.
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
        /// <returns>A pageable sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
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
            return ListPreferenceSets(request, callSettings);
        }

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListPreferenceSetsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PreferenceSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreferenceSetsRequest request = new ListPreferenceSetsRequest
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
            return ListPreferenceSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreferenceSet GetPreferenceSet(GetPreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(GetPreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(GetPreferenceSetRequest request, st::CancellationToken cancellationToken) =>
            GetPreferenceSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreferenceSet GetPreferenceSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreferenceSet(new GetPreferenceSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreferenceSetAsync(new GetPreferenceSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetPreferenceSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreferenceSet GetPreferenceSet(PreferenceSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreferenceSet(new GetPreferenceSetRequest
            {
                PreferenceSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(PreferenceSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreferenceSetAsync(new GetPreferenceSetRequest
            {
                PreferenceSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreferenceSet> GetPreferenceSetAsync(PreferenceSetName name, st::CancellationToken cancellationToken) =>
            GetPreferenceSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> CreatePreferenceSet(CreatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(CreatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(CreatePreferenceSetRequest request, st::CancellationToken cancellationToken) =>
            CreatePreferenceSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePreferenceSet</c>.</summary>
        public virtual lro::OperationsClient CreatePreferenceSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePreferenceSet</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> PollOnceCreatePreferenceSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreferenceSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePreferenceSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> PollOnceCreatePreferenceSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreferenceSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> CreatePreferenceSet(string parent, PreferenceSet preferenceSet, string preferenceSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreferenceSet(new CreatePreferenceSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PreferenceSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(string parent, PreferenceSet preferenceSet, string preferenceSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreferenceSetAsync(new CreatePreferenceSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PreferenceSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(string parent, PreferenceSet preferenceSet, string preferenceSetId, st::CancellationToken cancellationToken) =>
            CreatePreferenceSetAsync(parent, preferenceSet, preferenceSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> CreatePreferenceSet(gagr::LocationName parent, PreferenceSet preferenceSet, string preferenceSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreferenceSet(new CreatePreferenceSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PreferenceSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(gagr::LocationName parent, PreferenceSet preferenceSet, string preferenceSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreferenceSetAsync(new CreatePreferenceSetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PreferenceSetId = gax::GaxPreconditions.CheckNotNullOrEmpty(preferenceSetId, nameof(preferenceSetId)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being created.
        /// </param>
        /// <param name="preferenceSetId">
        /// Required. User specified ID for the preference set. It will become the last
        /// component of the preference set name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression
        /// `[a-z]([a-z0-9-]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(gagr::LocationName parent, PreferenceSet preferenceSet, string preferenceSetId, st::CancellationToken cancellationToken) =>
            CreatePreferenceSetAsync(parent, preferenceSet, preferenceSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> UpdatePreferenceSet(UpdatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> UpdatePreferenceSetAsync(UpdatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> UpdatePreferenceSetAsync(UpdatePreferenceSetRequest request, st::CancellationToken cancellationToken) =>
            UpdatePreferenceSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePreferenceSet</c>.</summary>
        public virtual lro::OperationsClient UpdatePreferenceSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePreferenceSet</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> PollOnceUpdatePreferenceSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreferenceSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePreferenceSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> PollOnceUpdatePreferenceSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreferenceSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PreferenceSet` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreferenceSet, OperationMetadata> UpdatePreferenceSet(PreferenceSet preferenceSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePreferenceSet(new UpdatePreferenceSetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PreferenceSet` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> UpdatePreferenceSetAsync(PreferenceSet preferenceSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePreferenceSetAsync(new UpdatePreferenceSetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                PreferenceSet = gax::GaxPreconditions.CheckNotNull(preferenceSet, nameof(preferenceSet)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="preferenceSet">
        /// Required. The preference set resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `PreferenceSet` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> UpdatePreferenceSetAsync(PreferenceSet preferenceSet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePreferenceSetAsync(preferenceSet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePreferenceSet(DeletePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(DeletePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(DeletePreferenceSetRequest request, st::CancellationToken cancellationToken) =>
            DeletePreferenceSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePreferenceSet</c>.</summary>
        public virtual lro::OperationsClient DeletePreferenceSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePreferenceSet</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePreferenceSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePreferenceSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePreferenceSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePreferenceSetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePreferenceSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreferenceSet(new DeletePreferenceSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreferenceSetAsync(new DeletePreferenceSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePreferenceSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePreferenceSet(PreferenceSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreferenceSet(new DeletePreferenceSetRequest
            {
                PreferenceSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(PreferenceSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreferenceSetAsync(new DeletePreferenceSetRequest
            {
                PreferenceSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the group resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(PreferenceSetName name, st::CancellationToken cancellationToken) =>
            DeletePreferenceSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSettings</c>.</summary>
        public virtual lro::OperationsClient UpdateSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> PollOnceUpdateSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Settings, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> PollOnceUpdateSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Settings, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSettingsOperationsClient, callSettings);

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The project settings resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Settings` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
            }, callSettings);

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The project settings resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Settings` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
            }, callSettings);

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The project settings resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `Settings` resource by the update.
        /// The values specified in the `update_mask` field are relative to the
        /// resource, not the full request.
        /// A field will be overwritten if it is in the mask.
        /// A single * value in the mask lets you to overwrite all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReportConfig, OperationMetadata> CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(CreateReportConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReportConfig</c>.</summary>
        public virtual lro::OperationsClient CreateReportConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReportConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReportConfig, OperationMetadata> PollOnceCreateReportConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReportConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReportConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> PollOnceCreateReportConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReportConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReportConfig, OperationMetadata> CreateReportConfig(string parent, ReportConfig reportConfig, string reportConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(string parent, ReportConfig reportConfig, string reportConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(string parent, ReportConfig reportConfig, string reportConfigId, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, reportConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReportConfig, OperationMetadata> CreateReportConfig(gagr::LocationName parent, ReportConfig reportConfig, string reportConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, string reportConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportConfigId, nameof(reportConfigId)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The report config set resource being created.
        /// </param>
        /// <param name="reportConfigId">
        /// Required. User specified ID for the report config. It will become the last
        /// component of the report config name. The ID must be unique within the
        /// project, must conform with RFC-1034, is restricted to lower-cased letters,
        /// and has a maximum length of 63 characters. The ID must match the regular
        /// expression: [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, string reportConfigId, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, reportConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportConfigsRequest`.
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportConfigsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportConfigsRequest`.
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportConfigsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(DeleteReportConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReportConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteReportConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteReportConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteReportConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReportConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReportConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteReportConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReportConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, st::CancellationToken cancellationToken) =>
            CreateReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReport</c>.</summary>
        public virtual lro::OperationsClient CreateReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Report, OperationMetadata> PollOnceCreateReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Report, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> PollOnceCreateReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Report, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportOperationsClient, callSettings);

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(string parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(string parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(string parent, Report report, string reportId, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, reportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(ReportConfigName parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(ReportConfigName parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="report">
        /// Required. The report resource being created.
        /// </param>
        /// <param name="reportId">
        /// Required. User specified id for the report. It will become the last
        /// component of the report name. The id must be unique within the project,
        /// must conform with RFC-1034, is restricted to lower-cased letters, and has a
        /// maximum length of 63 characters. The id must match the regular expression:
        /// [a-z]([a-z0-9-]{0,61}[a-z0-9])?.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(ReportConfigName parent, Report report, string reportId, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, reportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, st::CancellationToken cancellationToken) =>
            GetReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportsRequest`.
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
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
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
            return ListReports(request, callSettings);
        }

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
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
            return ListReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportsRequest`.
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
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReports(request, callSettings);
        }

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for `ListReportsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReport(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(DeleteReportRequest request, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReport</c>.</summary>
        public virtual lro::OperationsClient DeleteReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReportOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReport(new DeleteReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportAsync(new DeleteReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReport(new DeleteReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportAsync(new DeleteReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MigrationCenter client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class MigrationCenterClientImpl : MigrationCenterClient
    {
        private readonly gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> _callListAssets;

        private readonly gaxgrpc::ApiCall<GetAssetRequest, Asset> _callGetAsset;

        private readonly gaxgrpc::ApiCall<UpdateAssetRequest, Asset> _callUpdateAsset;

        private readonly gaxgrpc::ApiCall<BatchUpdateAssetsRequest, BatchUpdateAssetsResponse> _callBatchUpdateAssets;

        private readonly gaxgrpc::ApiCall<DeleteAssetRequest, wkt::Empty> _callDeleteAsset;

        private readonly gaxgrpc::ApiCall<BatchDeleteAssetsRequest, wkt::Empty> _callBatchDeleteAssets;

        private readonly gaxgrpc::ApiCall<ReportAssetFramesRequest, ReportAssetFramesResponse> _callReportAssetFrames;

        private readonly gaxgrpc::ApiCall<AggregateAssetsValuesRequest, AggregateAssetsValuesResponse> _callAggregateAssetsValues;

        private readonly gaxgrpc::ApiCall<CreateImportJobRequest, lro::Operation> _callCreateImportJob;

        private readonly gaxgrpc::ApiCall<ListImportJobsRequest, ListImportJobsResponse> _callListImportJobs;

        private readonly gaxgrpc::ApiCall<GetImportJobRequest, ImportJob> _callGetImportJob;

        private readonly gaxgrpc::ApiCall<DeleteImportJobRequest, lro::Operation> _callDeleteImportJob;

        private readonly gaxgrpc::ApiCall<UpdateImportJobRequest, lro::Operation> _callUpdateImportJob;

        private readonly gaxgrpc::ApiCall<ValidateImportJobRequest, lro::Operation> _callValidateImportJob;

        private readonly gaxgrpc::ApiCall<RunImportJobRequest, lro::Operation> _callRunImportJob;

        private readonly gaxgrpc::ApiCall<GetImportDataFileRequest, ImportDataFile> _callGetImportDataFile;

        private readonly gaxgrpc::ApiCall<ListImportDataFilesRequest, ListImportDataFilesResponse> _callListImportDataFiles;

        private readonly gaxgrpc::ApiCall<CreateImportDataFileRequest, lro::Operation> _callCreateImportDataFile;

        private readonly gaxgrpc::ApiCall<DeleteImportDataFileRequest, lro::Operation> _callDeleteImportDataFile;

        private readonly gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;

        private readonly gaxgrpc::ApiCall<GetGroupRequest, Group> _callGetGroup;

        private readonly gaxgrpc::ApiCall<CreateGroupRequest, lro::Operation> _callCreateGroup;

        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> _callUpdateGroup;

        private readonly gaxgrpc::ApiCall<DeleteGroupRequest, lro::Operation> _callDeleteGroup;

        private readonly gaxgrpc::ApiCall<AddAssetsToGroupRequest, lro::Operation> _callAddAssetsToGroup;

        private readonly gaxgrpc::ApiCall<RemoveAssetsFromGroupRequest, lro::Operation> _callRemoveAssetsFromGroup;

        private readonly gaxgrpc::ApiCall<ListErrorFramesRequest, ListErrorFramesResponse> _callListErrorFrames;

        private readonly gaxgrpc::ApiCall<GetErrorFrameRequest, ErrorFrame> _callGetErrorFrame;

        private readonly gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> _callListSources;

        private readonly gaxgrpc::ApiCall<GetSourceRequest, Source> _callGetSource;

        private readonly gaxgrpc::ApiCall<CreateSourceRequest, lro::Operation> _callCreateSource;

        private readonly gaxgrpc::ApiCall<UpdateSourceRequest, lro::Operation> _callUpdateSource;

        private readonly gaxgrpc::ApiCall<DeleteSourceRequest, lro::Operation> _callDeleteSource;

        private readonly gaxgrpc::ApiCall<ListPreferenceSetsRequest, ListPreferenceSetsResponse> _callListPreferenceSets;

        private readonly gaxgrpc::ApiCall<GetPreferenceSetRequest, PreferenceSet> _callGetPreferenceSet;

        private readonly gaxgrpc::ApiCall<CreatePreferenceSetRequest, lro::Operation> _callCreatePreferenceSet;

        private readonly gaxgrpc::ApiCall<UpdatePreferenceSetRequest, lro::Operation> _callUpdatePreferenceSet;

        private readonly gaxgrpc::ApiCall<DeletePreferenceSetRequest, lro::Operation> _callDeletePreferenceSet;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, lro::Operation> _callUpdateSettings;

        private readonly gaxgrpc::ApiCall<CreateReportConfigRequest, lro::Operation> _callCreateReportConfig;

        private readonly gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> _callGetReportConfig;

        private readonly gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> _callListReportConfigs;

        private readonly gaxgrpc::ApiCall<DeleteReportConfigRequest, lro::Operation> _callDeleteReportConfig;

        private readonly gaxgrpc::ApiCall<CreateReportRequest, lro::Operation> _callCreateReport;

        private readonly gaxgrpc::ApiCall<GetReportRequest, Report> _callGetReport;

        private readonly gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> _callListReports;

        private readonly gaxgrpc::ApiCall<DeleteReportRequest, lro::Operation> _callDeleteReport;

        /// <summary>
        /// Constructs a client wrapper for the MigrationCenter service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MigrationCenterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MigrationCenterClientImpl(MigrationCenter.MigrationCenterClient grpcClient, MigrationCenterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MigrationCenterSettings effectiveSettings = settings ?? MigrationCenterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateImportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateImportJobOperationsSettings, logger);
            DeleteImportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteImportJobOperationsSettings, logger);
            UpdateImportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateImportJobOperationsSettings, logger);
            ValidateImportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ValidateImportJobOperationsSettings, logger);
            RunImportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunImportJobOperationsSettings, logger);
            CreateImportDataFileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateImportDataFileOperationsSettings, logger);
            DeleteImportDataFileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteImportDataFileOperationsSettings, logger);
            CreateGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGroupOperationsSettings, logger);
            UpdateGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateGroupOperationsSettings, logger);
            DeleteGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGroupOperationsSettings, logger);
            AddAssetsToGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddAssetsToGroupOperationsSettings, logger);
            RemoveAssetsFromGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveAssetsFromGroupOperationsSettings, logger);
            CreateSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSourceOperationsSettings, logger);
            UpdateSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSourceOperationsSettings, logger);
            DeleteSourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSourceOperationsSettings, logger);
            CreatePreferenceSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePreferenceSetOperationsSettings, logger);
            UpdatePreferenceSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePreferenceSetOperationsSettings, logger);
            DeletePreferenceSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePreferenceSetOperationsSettings, logger);
            UpdateSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSettingsOperationsSettings, logger);
            CreateReportConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReportConfigOperationsSettings, logger);
            DeleteReportConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReportConfigOperationsSettings, logger);
            CreateReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReportOperationsSettings, logger);
            DeleteReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReportOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListAssets = clientHelper.BuildApiCall<ListAssetsRequest, ListAssetsResponse>("ListAssets", grpcClient.ListAssetsAsync, grpcClient.ListAssets, effectiveSettings.ListAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssets);
            Modify_ListAssetsApiCall(ref _callListAssets);
            _callGetAsset = clientHelper.BuildApiCall<GetAssetRequest, Asset>("GetAsset", grpcClient.GetAssetAsync, grpcClient.GetAsset, effectiveSettings.GetAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAsset);
            Modify_GetAssetApiCall(ref _callGetAsset);
            _callUpdateAsset = clientHelper.BuildApiCall<UpdateAssetRequest, Asset>("UpdateAsset", grpcClient.UpdateAssetAsync, grpcClient.UpdateAsset, effectiveSettings.UpdateAssetSettings).WithGoogleRequestParam("asset.name", request => request.Asset?.Name);
            Modify_ApiCall(ref _callUpdateAsset);
            Modify_UpdateAssetApiCall(ref _callUpdateAsset);
            _callBatchUpdateAssets = clientHelper.BuildApiCall<BatchUpdateAssetsRequest, BatchUpdateAssetsResponse>("BatchUpdateAssets", grpcClient.BatchUpdateAssetsAsync, grpcClient.BatchUpdateAssets, effectiveSettings.BatchUpdateAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateAssets);
            Modify_BatchUpdateAssetsApiCall(ref _callBatchUpdateAssets);
            _callDeleteAsset = clientHelper.BuildApiCall<DeleteAssetRequest, wkt::Empty>("DeleteAsset", grpcClient.DeleteAssetAsync, grpcClient.DeleteAsset, effectiveSettings.DeleteAssetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAsset);
            Modify_DeleteAssetApiCall(ref _callDeleteAsset);
            _callBatchDeleteAssets = clientHelper.BuildApiCall<BatchDeleteAssetsRequest, wkt::Empty>("BatchDeleteAssets", grpcClient.BatchDeleteAssetsAsync, grpcClient.BatchDeleteAssets, effectiveSettings.BatchDeleteAssetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteAssets);
            Modify_BatchDeleteAssetsApiCall(ref _callBatchDeleteAssets);
            _callReportAssetFrames = clientHelper.BuildApiCall<ReportAssetFramesRequest, ReportAssetFramesResponse>("ReportAssetFrames", grpcClient.ReportAssetFramesAsync, grpcClient.ReportAssetFrames, effectiveSettings.ReportAssetFramesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReportAssetFrames);
            Modify_ReportAssetFramesApiCall(ref _callReportAssetFrames);
            _callAggregateAssetsValues = clientHelper.BuildApiCall<AggregateAssetsValuesRequest, AggregateAssetsValuesResponse>("AggregateAssetsValues", grpcClient.AggregateAssetsValuesAsync, grpcClient.AggregateAssetsValues, effectiveSettings.AggregateAssetsValuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAggregateAssetsValues);
            Modify_AggregateAssetsValuesApiCall(ref _callAggregateAssetsValues);
            _callCreateImportJob = clientHelper.BuildApiCall<CreateImportJobRequest, lro::Operation>("CreateImportJob", grpcClient.CreateImportJobAsync, grpcClient.CreateImportJob, effectiveSettings.CreateImportJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateImportJob);
            Modify_CreateImportJobApiCall(ref _callCreateImportJob);
            _callListImportJobs = clientHelper.BuildApiCall<ListImportJobsRequest, ListImportJobsResponse>("ListImportJobs", grpcClient.ListImportJobsAsync, grpcClient.ListImportJobs, effectiveSettings.ListImportJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListImportJobs);
            Modify_ListImportJobsApiCall(ref _callListImportJobs);
            _callGetImportJob = clientHelper.BuildApiCall<GetImportJobRequest, ImportJob>("GetImportJob", grpcClient.GetImportJobAsync, grpcClient.GetImportJob, effectiveSettings.GetImportJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetImportJob);
            Modify_GetImportJobApiCall(ref _callGetImportJob);
            _callDeleteImportJob = clientHelper.BuildApiCall<DeleteImportJobRequest, lro::Operation>("DeleteImportJob", grpcClient.DeleteImportJobAsync, grpcClient.DeleteImportJob, effectiveSettings.DeleteImportJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteImportJob);
            Modify_DeleteImportJobApiCall(ref _callDeleteImportJob);
            _callUpdateImportJob = clientHelper.BuildApiCall<UpdateImportJobRequest, lro::Operation>("UpdateImportJob", grpcClient.UpdateImportJobAsync, grpcClient.UpdateImportJob, effectiveSettings.UpdateImportJobSettings).WithGoogleRequestParam("import_job.name", request => request.ImportJob?.Name);
            Modify_ApiCall(ref _callUpdateImportJob);
            Modify_UpdateImportJobApiCall(ref _callUpdateImportJob);
            _callValidateImportJob = clientHelper.BuildApiCall<ValidateImportJobRequest, lro::Operation>("ValidateImportJob", grpcClient.ValidateImportJobAsync, grpcClient.ValidateImportJob, effectiveSettings.ValidateImportJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callValidateImportJob);
            Modify_ValidateImportJobApiCall(ref _callValidateImportJob);
            _callRunImportJob = clientHelper.BuildApiCall<RunImportJobRequest, lro::Operation>("RunImportJob", grpcClient.RunImportJobAsync, grpcClient.RunImportJob, effectiveSettings.RunImportJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunImportJob);
            Modify_RunImportJobApiCall(ref _callRunImportJob);
            _callGetImportDataFile = clientHelper.BuildApiCall<GetImportDataFileRequest, ImportDataFile>("GetImportDataFile", grpcClient.GetImportDataFileAsync, grpcClient.GetImportDataFile, effectiveSettings.GetImportDataFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetImportDataFile);
            Modify_GetImportDataFileApiCall(ref _callGetImportDataFile);
            _callListImportDataFiles = clientHelper.BuildApiCall<ListImportDataFilesRequest, ListImportDataFilesResponse>("ListImportDataFiles", grpcClient.ListImportDataFilesAsync, grpcClient.ListImportDataFiles, effectiveSettings.ListImportDataFilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListImportDataFiles);
            Modify_ListImportDataFilesApiCall(ref _callListImportDataFiles);
            _callCreateImportDataFile = clientHelper.BuildApiCall<CreateImportDataFileRequest, lro::Operation>("CreateImportDataFile", grpcClient.CreateImportDataFileAsync, grpcClient.CreateImportDataFile, effectiveSettings.CreateImportDataFileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateImportDataFile);
            Modify_CreateImportDataFileApiCall(ref _callCreateImportDataFile);
            _callDeleteImportDataFile = clientHelper.BuildApiCall<DeleteImportDataFileRequest, lro::Operation>("DeleteImportDataFile", grpcClient.DeleteImportDataFileAsync, grpcClient.DeleteImportDataFile, effectiveSettings.DeleteImportDataFileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteImportDataFile);
            Modify_DeleteImportDataFileApiCall(ref _callDeleteImportDataFile);
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
            _callAddAssetsToGroup = clientHelper.BuildApiCall<AddAssetsToGroupRequest, lro::Operation>("AddAssetsToGroup", grpcClient.AddAssetsToGroupAsync, grpcClient.AddAssetsToGroup, effectiveSettings.AddAssetsToGroupSettings).WithGoogleRequestParam("group", request => request.Group);
            Modify_ApiCall(ref _callAddAssetsToGroup);
            Modify_AddAssetsToGroupApiCall(ref _callAddAssetsToGroup);
            _callRemoveAssetsFromGroup = clientHelper.BuildApiCall<RemoveAssetsFromGroupRequest, lro::Operation>("RemoveAssetsFromGroup", grpcClient.RemoveAssetsFromGroupAsync, grpcClient.RemoveAssetsFromGroup, effectiveSettings.RemoveAssetsFromGroupSettings).WithGoogleRequestParam("group", request => request.Group);
            Modify_ApiCall(ref _callRemoveAssetsFromGroup);
            Modify_RemoveAssetsFromGroupApiCall(ref _callRemoveAssetsFromGroup);
            _callListErrorFrames = clientHelper.BuildApiCall<ListErrorFramesRequest, ListErrorFramesResponse>("ListErrorFrames", grpcClient.ListErrorFramesAsync, grpcClient.ListErrorFrames, effectiveSettings.ListErrorFramesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListErrorFrames);
            Modify_ListErrorFramesApiCall(ref _callListErrorFrames);
            _callGetErrorFrame = clientHelper.BuildApiCall<GetErrorFrameRequest, ErrorFrame>("GetErrorFrame", grpcClient.GetErrorFrameAsync, grpcClient.GetErrorFrame, effectiveSettings.GetErrorFrameSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetErrorFrame);
            Modify_GetErrorFrameApiCall(ref _callGetErrorFrame);
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
            _callListPreferenceSets = clientHelper.BuildApiCall<ListPreferenceSetsRequest, ListPreferenceSetsResponse>("ListPreferenceSets", grpcClient.ListPreferenceSetsAsync, grpcClient.ListPreferenceSets, effectiveSettings.ListPreferenceSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPreferenceSets);
            Modify_ListPreferenceSetsApiCall(ref _callListPreferenceSets);
            _callGetPreferenceSet = clientHelper.BuildApiCall<GetPreferenceSetRequest, PreferenceSet>("GetPreferenceSet", grpcClient.GetPreferenceSetAsync, grpcClient.GetPreferenceSet, effectiveSettings.GetPreferenceSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPreferenceSet);
            Modify_GetPreferenceSetApiCall(ref _callGetPreferenceSet);
            _callCreatePreferenceSet = clientHelper.BuildApiCall<CreatePreferenceSetRequest, lro::Operation>("CreatePreferenceSet", grpcClient.CreatePreferenceSetAsync, grpcClient.CreatePreferenceSet, effectiveSettings.CreatePreferenceSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePreferenceSet);
            Modify_CreatePreferenceSetApiCall(ref _callCreatePreferenceSet);
            _callUpdatePreferenceSet = clientHelper.BuildApiCall<UpdatePreferenceSetRequest, lro::Operation>("UpdatePreferenceSet", grpcClient.UpdatePreferenceSetAsync, grpcClient.UpdatePreferenceSet, effectiveSettings.UpdatePreferenceSetSettings).WithGoogleRequestParam("preference_set.name", request => request.PreferenceSet?.Name);
            Modify_ApiCall(ref _callUpdatePreferenceSet);
            Modify_UpdatePreferenceSetApiCall(ref _callUpdatePreferenceSet);
            _callDeletePreferenceSet = clientHelper.BuildApiCall<DeletePreferenceSetRequest, lro::Operation>("DeletePreferenceSet", grpcClient.DeletePreferenceSetAsync, grpcClient.DeletePreferenceSet, effectiveSettings.DeletePreferenceSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePreferenceSet);
            Modify_DeletePreferenceSetApiCall(ref _callDeletePreferenceSet);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, lro::Operation>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            _callCreateReportConfig = clientHelper.BuildApiCall<CreateReportConfigRequest, lro::Operation>("CreateReportConfig", grpcClient.CreateReportConfigAsync, grpcClient.CreateReportConfig, effectiveSettings.CreateReportConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReportConfig);
            Modify_CreateReportConfigApiCall(ref _callCreateReportConfig);
            _callGetReportConfig = clientHelper.BuildApiCall<GetReportConfigRequest, ReportConfig>("GetReportConfig", grpcClient.GetReportConfigAsync, grpcClient.GetReportConfig, effectiveSettings.GetReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReportConfig);
            Modify_GetReportConfigApiCall(ref _callGetReportConfig);
            _callListReportConfigs = clientHelper.BuildApiCall<ListReportConfigsRequest, ListReportConfigsResponse>("ListReportConfigs", grpcClient.ListReportConfigsAsync, grpcClient.ListReportConfigs, effectiveSettings.ListReportConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReportConfigs);
            Modify_ListReportConfigsApiCall(ref _callListReportConfigs);
            _callDeleteReportConfig = clientHelper.BuildApiCall<DeleteReportConfigRequest, lro::Operation>("DeleteReportConfig", grpcClient.DeleteReportConfigAsync, grpcClient.DeleteReportConfig, effectiveSettings.DeleteReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReportConfig);
            Modify_DeleteReportConfigApiCall(ref _callDeleteReportConfig);
            _callCreateReport = clientHelper.BuildApiCall<CreateReportRequest, lro::Operation>("CreateReport", grpcClient.CreateReportAsync, grpcClient.CreateReport, effectiveSettings.CreateReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReport);
            Modify_CreateReportApiCall(ref _callCreateReport);
            _callGetReport = clientHelper.BuildApiCall<GetReportRequest, Report>("GetReport", grpcClient.GetReportAsync, grpcClient.GetReport, effectiveSettings.GetReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReport);
            Modify_GetReportApiCall(ref _callGetReport);
            _callListReports = clientHelper.BuildApiCall<ListReportsRequest, ListReportsResponse>("ListReports", grpcClient.ListReportsAsync, grpcClient.ListReports, effectiveSettings.ListReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReports);
            Modify_ListReportsApiCall(ref _callListReports);
            _callDeleteReport = clientHelper.BuildApiCall<DeleteReportRequest, lro::Operation>("DeleteReport", grpcClient.DeleteReportAsync, grpcClient.DeleteReport, effectiveSettings.DeleteReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReport);
            Modify_DeleteReportApiCall(ref _callDeleteReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAssetsApiCall(ref gaxgrpc::ApiCall<ListAssetsRequest, ListAssetsResponse> call);

        partial void Modify_GetAssetApiCall(ref gaxgrpc::ApiCall<GetAssetRequest, Asset> call);

        partial void Modify_UpdateAssetApiCall(ref gaxgrpc::ApiCall<UpdateAssetRequest, Asset> call);

        partial void Modify_BatchUpdateAssetsApiCall(ref gaxgrpc::ApiCall<BatchUpdateAssetsRequest, BatchUpdateAssetsResponse> call);

        partial void Modify_DeleteAssetApiCall(ref gaxgrpc::ApiCall<DeleteAssetRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteAssetsApiCall(ref gaxgrpc::ApiCall<BatchDeleteAssetsRequest, wkt::Empty> call);

        partial void Modify_ReportAssetFramesApiCall(ref gaxgrpc::ApiCall<ReportAssetFramesRequest, ReportAssetFramesResponse> call);

        partial void Modify_AggregateAssetsValuesApiCall(ref gaxgrpc::ApiCall<AggregateAssetsValuesRequest, AggregateAssetsValuesResponse> call);

        partial void Modify_CreateImportJobApiCall(ref gaxgrpc::ApiCall<CreateImportJobRequest, lro::Operation> call);

        partial void Modify_ListImportJobsApiCall(ref gaxgrpc::ApiCall<ListImportJobsRequest, ListImportJobsResponse> call);

        partial void Modify_GetImportJobApiCall(ref gaxgrpc::ApiCall<GetImportJobRequest, ImportJob> call);

        partial void Modify_DeleteImportJobApiCall(ref gaxgrpc::ApiCall<DeleteImportJobRequest, lro::Operation> call);

        partial void Modify_UpdateImportJobApiCall(ref gaxgrpc::ApiCall<UpdateImportJobRequest, lro::Operation> call);

        partial void Modify_ValidateImportJobApiCall(ref gaxgrpc::ApiCall<ValidateImportJobRequest, lro::Operation> call);

        partial void Modify_RunImportJobApiCall(ref gaxgrpc::ApiCall<RunImportJobRequest, lro::Operation> call);

        partial void Modify_GetImportDataFileApiCall(ref gaxgrpc::ApiCall<GetImportDataFileRequest, ImportDataFile> call);

        partial void Modify_ListImportDataFilesApiCall(ref gaxgrpc::ApiCall<ListImportDataFilesRequest, ListImportDataFilesResponse> call);

        partial void Modify_CreateImportDataFileApiCall(ref gaxgrpc::ApiCall<CreateImportDataFileRequest, lro::Operation> call);

        partial void Modify_DeleteImportDataFileApiCall(ref gaxgrpc::ApiCall<DeleteImportDataFileRequest, lro::Operation> call);

        partial void Modify_ListGroupsApiCall(ref gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> call);

        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, Group> call);

        partial void Modify_CreateGroupApiCall(ref gaxgrpc::ApiCall<CreateGroupRequest, lro::Operation> call);

        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, lro::Operation> call);

        partial void Modify_DeleteGroupApiCall(ref gaxgrpc::ApiCall<DeleteGroupRequest, lro::Operation> call);

        partial void Modify_AddAssetsToGroupApiCall(ref gaxgrpc::ApiCall<AddAssetsToGroupRequest, lro::Operation> call);

        partial void Modify_RemoveAssetsFromGroupApiCall(ref gaxgrpc::ApiCall<RemoveAssetsFromGroupRequest, lro::Operation> call);

        partial void Modify_ListErrorFramesApiCall(ref gaxgrpc::ApiCall<ListErrorFramesRequest, ListErrorFramesResponse> call);

        partial void Modify_GetErrorFrameApiCall(ref gaxgrpc::ApiCall<GetErrorFrameRequest, ErrorFrame> call);

        partial void Modify_ListSourcesApiCall(ref gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> call);

        partial void Modify_GetSourceApiCall(ref gaxgrpc::ApiCall<GetSourceRequest, Source> call);

        partial void Modify_CreateSourceApiCall(ref gaxgrpc::ApiCall<CreateSourceRequest, lro::Operation> call);

        partial void Modify_UpdateSourceApiCall(ref gaxgrpc::ApiCall<UpdateSourceRequest, lro::Operation> call);

        partial void Modify_DeleteSourceApiCall(ref gaxgrpc::ApiCall<DeleteSourceRequest, lro::Operation> call);

        partial void Modify_ListPreferenceSetsApiCall(ref gaxgrpc::ApiCall<ListPreferenceSetsRequest, ListPreferenceSetsResponse> call);

        partial void Modify_GetPreferenceSetApiCall(ref gaxgrpc::ApiCall<GetPreferenceSetRequest, PreferenceSet> call);

        partial void Modify_CreatePreferenceSetApiCall(ref gaxgrpc::ApiCall<CreatePreferenceSetRequest, lro::Operation> call);

        partial void Modify_UpdatePreferenceSetApiCall(ref gaxgrpc::ApiCall<UpdatePreferenceSetRequest, lro::Operation> call);

        partial void Modify_DeletePreferenceSetApiCall(ref gaxgrpc::ApiCall<DeletePreferenceSetRequest, lro::Operation> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, lro::Operation> call);

        partial void Modify_CreateReportConfigApiCall(ref gaxgrpc::ApiCall<CreateReportConfigRequest, lro::Operation> call);

        partial void Modify_GetReportConfigApiCall(ref gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> call);

        partial void Modify_ListReportConfigsApiCall(ref gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> call);

        partial void Modify_DeleteReportConfigApiCall(ref gaxgrpc::ApiCall<DeleteReportConfigRequest, lro::Operation> call);

        partial void Modify_CreateReportApiCall(ref gaxgrpc::ApiCall<CreateReportRequest, lro::Operation> call);

        partial void Modify_GetReportApiCall(ref gaxgrpc::ApiCall<GetReportRequest, Report> call);

        partial void Modify_ListReportsApiCall(ref gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> call);

        partial void Modify_DeleteReportApiCall(ref gaxgrpc::ApiCall<DeleteReportRequest, lro::Operation> call);

        partial void OnConstruction(MigrationCenter.MigrationCenterClient grpcClient, MigrationCenterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MigrationCenter client</summary>
        public override MigrationCenter.MigrationCenterClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListAssetsRequest(ref ListAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssetRequest(ref GetAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAssetRequest(ref UpdateAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateAssetsRequest(ref BatchUpdateAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssetRequest(ref DeleteAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteAssetsRequest(ref BatchDeleteAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportAssetFramesRequest(ref ReportAssetFramesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregateAssetsValuesRequest(ref AggregateAssetsValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateImportJobRequest(ref CreateImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListImportJobsRequest(ref ListImportJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetImportJobRequest(ref GetImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteImportJobRequest(ref DeleteImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateImportJobRequest(ref UpdateImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateImportJobRequest(ref ValidateImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunImportJobRequest(ref RunImportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetImportDataFileRequest(ref GetImportDataFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListImportDataFilesRequest(ref ListImportDataFilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateImportDataFileRequest(ref CreateImportDataFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteImportDataFileRequest(ref DeleteImportDataFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGroupRequest(ref CreateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGroupRequest(ref DeleteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddAssetsToGroupRequest(ref AddAssetsToGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAssetsFromGroupRequest(ref RemoveAssetsFromGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListErrorFramesRequest(ref ListErrorFramesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetErrorFrameRequest(ref GetErrorFrameRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSourcesRequest(ref ListSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSourceRequest(ref GetSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSourceRequest(ref CreateSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSourceRequest(ref UpdateSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSourceRequest(ref DeleteSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPreferenceSetsRequest(ref ListPreferenceSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPreferenceSetRequest(ref GetPreferenceSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePreferenceSetRequest(ref CreatePreferenceSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePreferenceSetRequest(ref UpdatePreferenceSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePreferenceSetRequest(ref DeletePreferenceSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReportConfigRequest(ref CreateReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportConfigRequest(ref GetReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportConfigsRequest(ref ListReportConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReportConfigRequest(ref DeleteReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReportRequest(ref CreateReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportRequest(ref GetReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportsRequest(ref ListReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReportRequest(ref DeleteReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Asset"/> resources.</returns>
        public override gax::PagedEnumerable<ListAssetsResponse, Asset> ListAssets(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssetsRequest, ListAssetsResponse, Asset>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Lists all the assets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Asset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssetsResponse, Asset> ListAssetsAsync(ListAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssetsRequest, ListAssetsResponse, Asset>(_callListAssets, request, callSettings);
        }

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Asset GetAsset(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetRequest(ref request, ref callSettings);
            return _callGetAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Asset> GetAssetAsync(GetAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetRequest(ref request, ref callSettings);
            return _callGetAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Asset UpdateAsset(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return _callUpdateAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Asset> UpdateAssetAsync(UpdateAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssetRequest(ref request, ref callSettings);
            return _callUpdateAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateAssetsResponse BatchUpdateAssets(BatchUpdateAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAssetsRequest(ref request, ref callSettings);
            return _callBatchUpdateAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a list of assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateAssetsResponse> BatchUpdateAssetsAsync(BatchUpdateAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateAssetsRequest(ref request, ref callSettings);
            return _callBatchUpdateAssets.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAsset(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            _callDeleteAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an asset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAssetAsync(DeleteAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssetRequest(ref request, ref callSettings);
            return _callDeleteAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteAssets(BatchDeleteAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteAssetsRequest(ref request, ref callSettings);
            _callBatchDeleteAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes list of Assets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteAssetsAsync(BatchDeleteAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteAssetsRequest(ref request, ref callSettings);
            return _callBatchDeleteAssets.Async(request, callSettings);
        }

        /// <summary>
        /// Reports a set of frames.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportAssetFramesResponse ReportAssetFrames(ReportAssetFramesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportAssetFramesRequest(ref request, ref callSettings);
            return _callReportAssetFrames.Sync(request, callSettings);
        }

        /// <summary>
        /// Reports a set of frames.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportAssetFramesResponse> ReportAssetFramesAsync(ReportAssetFramesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportAssetFramesRequest(ref request, ref callSettings);
            return _callReportAssetFrames.Async(request, callSettings);
        }

        /// <summary>
        /// Aggregates the requested fields based on provided function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AggregateAssetsValuesResponse AggregateAssetsValues(AggregateAssetsValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateAssetsValuesRequest(ref request, ref callSettings);
            return _callAggregateAssetsValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Aggregates the requested fields based on provided function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AggregateAssetsValuesResponse> AggregateAssetsValuesAsync(AggregateAssetsValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateAssetsValuesRequest(ref request, ref callSettings);
            return _callAggregateAssetsValues.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateImportJob</c>.</summary>
        public override lro::OperationsClient CreateImportJobOperationsClient { get; }

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportJob, OperationMetadata> CreateImportJob(CreateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<ImportJob, OperationMetadata>(_callCreateImportJob.Sync(request, callSettings), CreateImportJobOperationsClient);
        }

        /// <summary>
        /// Creates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportJob, OperationMetadata>> CreateImportJobAsync(CreateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<ImportJob, OperationMetadata>(await _callCreateImportJob.Async(request, callSettings).ConfigureAwait(false), CreateImportJobOperationsClient);
        }

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImportJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListImportJobsResponse, ImportJob> ListImportJobs(ListImportJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImportJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListImportJobsRequest, ListImportJobsResponse, ImportJob>(_callListImportJobs, request, callSettings);
        }

        /// <summary>
        /// Lists all import jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImportJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListImportJobsResponse, ImportJob> ListImportJobsAsync(ListImportJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImportJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListImportJobsRequest, ListImportJobsResponse, ImportJob>(_callListImportJobs, request, callSettings);
        }

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportJob GetImportJob(GetImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImportJobRequest(ref request, ref callSettings);
            return _callGetImportJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportJob> GetImportJobAsync(GetImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImportJobRequest(ref request, ref callSettings);
            return _callGetImportJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteImportJob</c>.</summary>
        public override lro::OperationsClient DeleteImportJobOperationsClient { get; }

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteImportJob(DeleteImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteImportJob.Sync(request, callSettings), DeleteImportJobOperationsClient);
        }

        /// <summary>
        /// Deletes an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportJobAsync(DeleteImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteImportJob.Async(request, callSettings).ConfigureAwait(false), DeleteImportJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateImportJob</c>.</summary>
        public override lro::OperationsClient UpdateImportJobOperationsClient { get; }

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportJob, OperationMetadata> UpdateImportJob(UpdateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<ImportJob, OperationMetadata>(_callUpdateImportJob.Sync(request, callSettings), UpdateImportJobOperationsClient);
        }

        /// <summary>
        /// Updates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportJob, OperationMetadata>> UpdateImportJobAsync(UpdateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<ImportJob, OperationMetadata>(await _callUpdateImportJob.Async(request, callSettings).ConfigureAwait(false), UpdateImportJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ValidateImportJob</c>.</summary>
        public override lro::OperationsClient ValidateImportJobOperationsClient { get; }

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> ValidateImportJob(ValidateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callValidateImportJob.Sync(request, callSettings), ValidateImportJobOperationsClient);
        }

        /// <summary>
        /// Validates an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ValidateImportJobAsync(ValidateImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callValidateImportJob.Async(request, callSettings).ConfigureAwait(false), ValidateImportJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RunImportJob</c>.</summary>
        public override lro::OperationsClient RunImportJobOperationsClient { get; }

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> RunImportJob(RunImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callRunImportJob.Sync(request, callSettings), RunImportJobOperationsClient);
        }

        /// <summary>
        /// Runs an import job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> RunImportJobAsync(RunImportJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunImportJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callRunImportJob.Async(request, callSettings).ConfigureAwait(false), RunImportJobOperationsClient);
        }

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportDataFile GetImportDataFile(GetImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImportDataFileRequest(ref request, ref callSettings);
            return _callGetImportDataFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportDataFile> GetImportDataFileAsync(GetImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImportDataFileRequest(ref request, ref callSettings);
            return _callGetImportDataFile.Async(request, callSettings);
        }

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImportDataFile"/> resources.</returns>
        public override gax::PagedEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFiles(ListImportDataFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImportDataFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListImportDataFilesRequest, ListImportDataFilesResponse, ImportDataFile>(_callListImportDataFiles, request, callSettings);
        }

        /// <summary>
        /// List import data files.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImportDataFile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListImportDataFilesResponse, ImportDataFile> ListImportDataFilesAsync(ListImportDataFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImportDataFilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListImportDataFilesRequest, ListImportDataFilesResponse, ImportDataFile>(_callListImportDataFiles, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateImportDataFile</c>.</summary>
        public override lro::OperationsClient CreateImportDataFileOperationsClient { get; }

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDataFile, OperationMetadata> CreateImportDataFile(CreateImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateImportDataFileRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataFile, OperationMetadata>(_callCreateImportDataFile.Sync(request, callSettings), CreateImportDataFileOperationsClient);
        }

        /// <summary>
        /// Creates an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDataFile, OperationMetadata>> CreateImportDataFileAsync(CreateImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateImportDataFileRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataFile, OperationMetadata>(await _callCreateImportDataFile.Async(request, callSettings).ConfigureAwait(false), CreateImportDataFileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteImportDataFile</c>.</summary>
        public override lro::OperationsClient DeleteImportDataFileOperationsClient { get; }

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteImportDataFile(DeleteImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteImportDataFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteImportDataFile.Sync(request, callSettings), DeleteImportDataFileOperationsClient);
        }

        /// <summary>
        /// Delete an import data file.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteImportDataFileAsync(DeleteImportDataFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteImportDataFileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteImportDataFile.Async(request, callSettings).ConfigureAwait(false), DeleteImportDataFileOperationsClient);
        }

        /// <summary>
        /// Lists all groups in a given project and location.
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
        /// Lists all groups in a given project and location.
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
        /// Gets the details of a group.
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
        /// Gets the details of a group.
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
        /// Creates a new group in a given project and location.
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
        /// Creates a new group in a given project and location.
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
        /// Updates the parameters of a group.
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
        /// Updates the parameters of a group.
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
        /// Deletes a group.
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
        /// Deletes a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteGroup.Async(request, callSettings).ConfigureAwait(false), DeleteGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddAssetsToGroup</c>.</summary>
        public override lro::OperationsClient AddAssetsToGroupOperationsClient { get; }

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Group, OperationMetadata> AddAssetsToGroup(AddAssetsToGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssetsToGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(_callAddAssetsToGroup.Sync(request, callSettings), AddAssetsToGroupOperationsClient);
        }

        /// <summary>
        /// Adds assets to a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Group, OperationMetadata>> AddAssetsToGroupAsync(AddAssetsToGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAssetsToGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(await _callAddAssetsToGroup.Async(request, callSettings).ConfigureAwait(false), AddAssetsToGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveAssetsFromGroup</c>.</summary>
        public override lro::OperationsClient RemoveAssetsFromGroupOperationsClient { get; }

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Group, OperationMetadata> RemoveAssetsFromGroup(RemoveAssetsFromGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssetsFromGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(_callRemoveAssetsFromGroup.Sync(request, callSettings), RemoveAssetsFromGroupOperationsClient);
        }

        /// <summary>
        /// Removes assets from a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Group, OperationMetadata>> RemoveAssetsFromGroupAsync(RemoveAssetsFromGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAssetsFromGroupRequest(ref request, ref callSettings);
            return new lro::Operation<Group, OperationMetadata>(await _callRemoveAssetsFromGroup.Async(request, callSettings).ConfigureAwait(false), RemoveAssetsFromGroupOperationsClient);
        }

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ErrorFrame"/> resources.</returns>
        public override gax::PagedEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFrames(ListErrorFramesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListErrorFramesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListErrorFramesRequest, ListErrorFramesResponse, ErrorFrame>(_callListErrorFrames, request, callSettings);
        }

        /// <summary>
        /// Lists all error frames in a given source and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ErrorFrame"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListErrorFramesResponse, ErrorFrame> ListErrorFramesAsync(ListErrorFramesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListErrorFramesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListErrorFramesRequest, ListErrorFramesResponse, ErrorFrame>(_callListErrorFrames, request, callSettings);
        }

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ErrorFrame GetErrorFrame(GetErrorFrameRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetErrorFrameRequest(ref request, ref callSettings);
            return _callGetErrorFrame.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of an error frame.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ErrorFrame> GetErrorFrameAsync(GetErrorFrameRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetErrorFrameRequest(ref request, ref callSettings);
            return _callGetErrorFrame.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the sources in a given project and location.
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
        /// Lists all the sources in a given project and location.
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
        /// Gets the details of a source.
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
        /// Gets the details of a source.
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
        /// Creates a new source in a given project and location.
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
        /// Creates a new source in a given project and location.
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
        /// Updates the parameters of a source.
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
        /// Updates the parameters of a source.
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
        /// Deletes a source.
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
        /// Deletes a source.
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
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PreferenceSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSets(ListPreferenceSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreferenceSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPreferenceSetsRequest, ListPreferenceSetsResponse, PreferenceSet>(_callListPreferenceSets, request, callSettings);
        }

        /// <summary>
        /// Lists all the preference sets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PreferenceSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPreferenceSetsResponse, PreferenceSet> ListPreferenceSetsAsync(ListPreferenceSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreferenceSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPreferenceSetsRequest, ListPreferenceSetsResponse, PreferenceSet>(_callListPreferenceSets, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreferenceSet GetPreferenceSet(GetPreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPreferenceSetRequest(ref request, ref callSettings);
            return _callGetPreferenceSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreferenceSet> GetPreferenceSetAsync(GetPreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPreferenceSetRequest(ref request, ref callSettings);
            return _callGetPreferenceSet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePreferenceSet</c>.</summary>
        public override lro::OperationsClient CreatePreferenceSetOperationsClient { get; }

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PreferenceSet, OperationMetadata> CreatePreferenceSet(CreatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<PreferenceSet, OperationMetadata>(_callCreatePreferenceSet.Sync(request, callSettings), CreatePreferenceSetOperationsClient);
        }

        /// <summary>
        /// Creates a new preference set in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> CreatePreferenceSetAsync(CreatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<PreferenceSet, OperationMetadata>(await _callCreatePreferenceSet.Async(request, callSettings).ConfigureAwait(false), CreatePreferenceSetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePreferenceSet</c>.</summary>
        public override lro::OperationsClient UpdatePreferenceSetOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PreferenceSet, OperationMetadata> UpdatePreferenceSet(UpdatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<PreferenceSet, OperationMetadata>(_callUpdatePreferenceSet.Sync(request, callSettings), UpdatePreferenceSetOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PreferenceSet, OperationMetadata>> UpdatePreferenceSetAsync(UpdatePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<PreferenceSet, OperationMetadata>(await _callUpdatePreferenceSet.Async(request, callSettings).ConfigureAwait(false), UpdatePreferenceSetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePreferenceSet</c>.</summary>
        public override lro::OperationsClient DeletePreferenceSetOperationsClient { get; }

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePreferenceSet(DeletePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePreferenceSet.Sync(request, callSettings), DeletePreferenceSetOperationsClient);
        }

        /// <summary>
        /// Deletes a preference set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePreferenceSetAsync(DeletePreferenceSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePreferenceSetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePreferenceSet.Async(request, callSettings).ConfigureAwait(false), DeletePreferenceSetOperationsClient);
        }

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of regional settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSettings</c>.</summary>
        public override lro::OperationsClient UpdateSettingsOperationsClient { get; }

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Settings, OperationMetadata> UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Settings, OperationMetadata>(_callUpdateSettings.Sync(request, callSettings), UpdateSettingsOperationsClient);
        }

        /// <summary>
        /// Updates the regional-level project settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Settings, OperationMetadata>(await _callUpdateSettings.Async(request, callSettings).ConfigureAwait(false), UpdateSettingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateReportConfig</c>.</summary>
        public override lro::OperationsClient CreateReportConfigOperationsClient { get; }

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReportConfig, OperationMetadata> CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ReportConfig, OperationMetadata>(_callCreateReportConfig.Sync(request, callSettings), CreateReportConfigOperationsClient);
        }

        /// <summary>
        /// Creates a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReportConfig, OperationMetadata>> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ReportConfig, OperationMetadata>(await _callCreateReportConfig.Async(request, callSettings).ConfigureAwait(false), CreateReportConfigOperationsClient);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteReportConfig</c>.</summary>
        public override lro::OperationsClient DeleteReportConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteReportConfig.Sync(request, callSettings), DeleteReportConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteReportConfig.Async(request, callSettings).ConfigureAwait(false), DeleteReportConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateReport</c>.</summary>
        public override lro::OperationsClient CreateReportOperationsClient { get; }

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Report, OperationMetadata> CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return new lro::Operation<Report, OperationMetadata>(_callCreateReport.Sync(request, callSettings), CreateReportOperationsClient);
        }

        /// <summary>
        /// Creates a report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return new lro::Operation<Report, OperationMetadata>(await _callCreateReport.Async(request, callSettings).ConfigureAwait(false), CreateReportOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Report GetReport(GetReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportRequest(ref request, ref callSettings);
            return _callGetReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Report> GetReportAsync(GetReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportRequest(ref request, ref callSettings);
            return _callGetReport.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
        }

        /// <summary>
        /// Lists Reports in a given ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteReport</c>.</summary>
        public override lro::OperationsClient DeleteReportOperationsClient { get; }

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteReport(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteReport.Sync(request, callSettings), DeleteReportOperationsClient);
        }

        /// <summary>
        /// Deletes a Report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReportAsync(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteReport.Async(request, callSettings).ConfigureAwait(false), DeleteReportOperationsClient);
        }
    }

    public partial class ListAssetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListImportJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListImportDataFilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListErrorFramesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPreferenceSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssetsResponse : gaxgrpc::IPageResponse<Asset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Asset> GetEnumerator() => Assets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListImportJobsResponse : gaxgrpc::IPageResponse<ImportJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ImportJob> GetEnumerator() => ImportJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListImportDataFilesResponse : gaxgrpc::IPageResponse<ImportDataFile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ImportDataFile> GetEnumerator() => ImportDataFiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupsResponse : gaxgrpc::IPageResponse<Group>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Group> GetEnumerator() => Groups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListErrorFramesResponse : gaxgrpc::IPageResponse<ErrorFrame>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ErrorFrame> GetEnumerator() => ErrorFrames.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSourcesResponse : gaxgrpc::IPageResponse<Source>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Source> GetEnumerator() => Sources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPreferenceSetsResponse : gaxgrpc::IPageResponse<PreferenceSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PreferenceSet> GetEnumerator() => PreferenceSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReportConfigsResponse : gaxgrpc::IPageResponse<ReportConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportConfig> GetEnumerator() => ReportConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReportsResponse : gaxgrpc::IPageResponse<Report>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Report> GetEnumerator() => Reports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class MigrationCenter
    {
        public partial class MigrationCenterClient
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

    public static partial class MigrationCenter
    {
        public partial class MigrationCenterClient
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
