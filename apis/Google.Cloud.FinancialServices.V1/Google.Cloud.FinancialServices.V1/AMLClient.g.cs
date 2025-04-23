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
using linq = System.Linq;
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

namespace Google.Cloud.FinancialServices.V1
{
    /// <summary>Settings for <see cref="AMLClient"/> instances.</summary>
    public sealed partial class AMLSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AMLSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AMLSettings"/>.</returns>
        public static AMLSettings GetDefault() => new AMLSettings();

        /// <summary>Constructs a new <see cref="AMLSettings"/> object with default settings.</summary>
        public AMLSettings()
        {
        }

        private AMLSettings(AMLSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            ImportRegisteredPartiesSettings = existing.ImportRegisteredPartiesSettings;
            ImportRegisteredPartiesOperationsSettings = existing.ImportRegisteredPartiesOperationsSettings.Clone();
            ExportRegisteredPartiesSettings = existing.ExportRegisteredPartiesSettings;
            ExportRegisteredPartiesOperationsSettings = existing.ExportRegisteredPartiesOperationsSettings.Clone();
            ListDatasetsSettings = existing.ListDatasetsSettings;
            GetDatasetSettings = existing.GetDatasetSettings;
            CreateDatasetSettings = existing.CreateDatasetSettings;
            CreateDatasetOperationsSettings = existing.CreateDatasetOperationsSettings.Clone();
            UpdateDatasetSettings = existing.UpdateDatasetSettings;
            UpdateDatasetOperationsSettings = existing.UpdateDatasetOperationsSettings.Clone();
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            DeleteDatasetOperationsSettings = existing.DeleteDatasetOperationsSettings.Clone();
            ListModelsSettings = existing.ListModelsSettings;
            GetModelSettings = existing.GetModelSettings;
            CreateModelSettings = existing.CreateModelSettings;
            CreateModelOperationsSettings = existing.CreateModelOperationsSettings.Clone();
            UpdateModelSettings = existing.UpdateModelSettings;
            UpdateModelOperationsSettings = existing.UpdateModelOperationsSettings.Clone();
            ExportModelMetadataSettings = existing.ExportModelMetadataSettings;
            ExportModelMetadataOperationsSettings = existing.ExportModelMetadataOperationsSettings.Clone();
            DeleteModelSettings = existing.DeleteModelSettings;
            DeleteModelOperationsSettings = existing.DeleteModelOperationsSettings.Clone();
            ListEngineConfigsSettings = existing.ListEngineConfigsSettings;
            GetEngineConfigSettings = existing.GetEngineConfigSettings;
            CreateEngineConfigSettings = existing.CreateEngineConfigSettings;
            CreateEngineConfigOperationsSettings = existing.CreateEngineConfigOperationsSettings.Clone();
            UpdateEngineConfigSettings = existing.UpdateEngineConfigSettings;
            UpdateEngineConfigOperationsSettings = existing.UpdateEngineConfigOperationsSettings.Clone();
            ExportEngineConfigMetadataSettings = existing.ExportEngineConfigMetadataSettings;
            ExportEngineConfigMetadataOperationsSettings = existing.ExportEngineConfigMetadataOperationsSettings.Clone();
            DeleteEngineConfigSettings = existing.DeleteEngineConfigSettings;
            DeleteEngineConfigOperationsSettings = existing.DeleteEngineConfigOperationsSettings.Clone();
            GetEngineVersionSettings = existing.GetEngineVersionSettings;
            ListEngineVersionsSettings = existing.ListEngineVersionsSettings;
            ListPredictionResultsSettings = existing.ListPredictionResultsSettings;
            GetPredictionResultSettings = existing.GetPredictionResultSettings;
            CreatePredictionResultSettings = existing.CreatePredictionResultSettings;
            CreatePredictionResultOperationsSettings = existing.CreatePredictionResultOperationsSettings.Clone();
            UpdatePredictionResultSettings = existing.UpdatePredictionResultSettings;
            UpdatePredictionResultOperationsSettings = existing.UpdatePredictionResultOperationsSettings.Clone();
            ExportPredictionResultMetadataSettings = existing.ExportPredictionResultMetadataSettings;
            ExportPredictionResultMetadataOperationsSettings = existing.ExportPredictionResultMetadataOperationsSettings.Clone();
            DeletePredictionResultSettings = existing.DeletePredictionResultSettings;
            DeletePredictionResultOperationsSettings = existing.DeletePredictionResultOperationsSettings.Clone();
            ListBacktestResultsSettings = existing.ListBacktestResultsSettings;
            GetBacktestResultSettings = existing.GetBacktestResultSettings;
            CreateBacktestResultSettings = existing.CreateBacktestResultSettings;
            CreateBacktestResultOperationsSettings = existing.CreateBacktestResultOperationsSettings.Clone();
            UpdateBacktestResultSettings = existing.UpdateBacktestResultSettings;
            UpdateBacktestResultOperationsSettings = existing.UpdateBacktestResultOperationsSettings.Clone();
            ExportBacktestResultMetadataSettings = existing.ExportBacktestResultMetadataSettings;
            ExportBacktestResultMetadataOperationsSettings = existing.ExportBacktestResultMetadataOperationsSettings.Clone();
            DeleteBacktestResultSettings = existing.DeleteBacktestResultSettings;
            DeleteBacktestResultOperationsSettings = existing.DeleteBacktestResultOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AMLSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.ListInstances</c>
        /// and <c>AMLClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetInstance</c>
        /// and <c>AMLClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.CreateInstance</c>
        ///  and <c>AMLClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreateInstance</c> and
        /// <c>AMLClient.CreateInstanceAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.UpdateInstance</c>
        ///  and <c>AMLClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdateInstance</c> and
        /// <c>AMLClient.UpdateInstanceAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.DeleteInstance</c>
        ///  and <c>AMLClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeleteInstance</c> and
        /// <c>AMLClient.DeleteInstanceAsync</c>.
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
        /// <c>AMLClient.ImportRegisteredParties</c> and <c>AMLClient.ImportRegisteredPartiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportRegisteredPartiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ImportRegisteredParties</c> and
        /// <c>AMLClient.ImportRegisteredPartiesAsync</c>.
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
        public lro::OperationsSettings ImportRegisteredPartiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ExportRegisteredParties</c> and <c>AMLClient.ExportRegisteredPartiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportRegisteredPartiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ExportRegisteredParties</c> and
        /// <c>AMLClient.ExportRegisteredPartiesAsync</c>.
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
        public lro::OperationsSettings ExportRegisteredPartiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.ListDatasets</c>
        /// and <c>AMLClient.ListDatasetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetDataset</c>
        /// and <c>AMLClient.GetDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.CreateDataset</c>
        /// and <c>AMLClient.CreateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreateDataset</c> and
        /// <c>AMLClient.CreateDatasetAsync</c>.
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
        public lro::OperationsSettings CreateDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.UpdateDataset</c>
        /// and <c>AMLClient.UpdateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdateDataset</c> and
        /// <c>AMLClient.UpdateDatasetAsync</c>.
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
        public lro::OperationsSettings UpdateDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.DeleteDataset</c>
        /// and <c>AMLClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeleteDataset</c> and
        /// <c>AMLClient.DeleteDatasetAsync</c>.
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
        public lro::OperationsSettings DeleteDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.ListModels</c>
        /// and <c>AMLClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetModel</c> and
        /// <c>AMLClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.CreateModel</c>
        /// and <c>AMLClient.CreateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreateModel</c> and <c>AMLClient.CreateModelAsync</c>
        /// .
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
        public lro::OperationsSettings CreateModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.UpdateModel</c>
        /// and <c>AMLClient.UpdateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdateModel</c> and <c>AMLClient.UpdateModelAsync</c>
        /// .
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
        public lro::OperationsSettings UpdateModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ExportModelMetadata</c> and <c>AMLClient.ExportModelMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportModelMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ExportModelMetadata</c> and
        /// <c>AMLClient.ExportModelMetadataAsync</c>.
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
        public lro::OperationsSettings ExportModelMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.DeleteModel</c>
        /// and <c>AMLClient.DeleteModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeleteModel</c> and <c>AMLClient.DeleteModelAsync</c>
        /// .
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
        public lro::OperationsSettings DeleteModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.ListEngineConfigs</c>
        ///  and <c>AMLClient.ListEngineConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEngineConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetEngineConfig</c>
        ///  and <c>AMLClient.GetEngineConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEngineConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.CreateEngineConfig</c> and <c>AMLClient.CreateEngineConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEngineConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreateEngineConfig</c> and
        /// <c>AMLClient.CreateEngineConfigAsync</c>.
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
        public lro::OperationsSettings CreateEngineConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.UpdateEngineConfig</c> and <c>AMLClient.UpdateEngineConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEngineConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdateEngineConfig</c> and
        /// <c>AMLClient.UpdateEngineConfigAsync</c>.
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
        public lro::OperationsSettings UpdateEngineConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ExportEngineConfigMetadata</c> and <c>AMLClient.ExportEngineConfigMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportEngineConfigMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ExportEngineConfigMetadata</c> and
        /// <c>AMLClient.ExportEngineConfigMetadataAsync</c>.
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
        public lro::OperationsSettings ExportEngineConfigMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.DeleteEngineConfig</c> and <c>AMLClient.DeleteEngineConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEngineConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeleteEngineConfig</c> and
        /// <c>AMLClient.DeleteEngineConfigAsync</c>.
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
        public lro::OperationsSettings DeleteEngineConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetEngineVersion</c>
        ///  and <c>AMLClient.GetEngineVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEngineVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ListEngineVersions</c> and <c>AMLClient.ListEngineVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEngineVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ListPredictionResults</c> and <c>AMLClient.ListPredictionResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPredictionResultsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.GetPredictionResult</c> and <c>AMLClient.GetPredictionResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPredictionResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.CreatePredictionResult</c> and <c>AMLClient.CreatePredictionResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePredictionResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreatePredictionResult</c> and
        /// <c>AMLClient.CreatePredictionResultAsync</c>.
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
        public lro::OperationsSettings CreatePredictionResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.UpdatePredictionResult</c> and <c>AMLClient.UpdatePredictionResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePredictionResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdatePredictionResult</c> and
        /// <c>AMLClient.UpdatePredictionResultAsync</c>.
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
        public lro::OperationsSettings UpdatePredictionResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ExportPredictionResultMetadata</c> and <c>AMLClient.ExportPredictionResultMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportPredictionResultMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ExportPredictionResultMetadata</c> and
        /// <c>AMLClient.ExportPredictionResultMetadataAsync</c>.
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
        public lro::OperationsSettings ExportPredictionResultMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.DeletePredictionResult</c> and <c>AMLClient.DeletePredictionResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePredictionResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeletePredictionResult</c> and
        /// <c>AMLClient.DeletePredictionResultAsync</c>.
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
        public lro::OperationsSettings DeletePredictionResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ListBacktestResults</c> and <c>AMLClient.ListBacktestResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBacktestResultsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AMLClient.GetBacktestResult</c>
        ///  and <c>AMLClient.GetBacktestResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBacktestResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.CreateBacktestResult</c> and <c>AMLClient.CreateBacktestResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBacktestResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.CreateBacktestResult</c> and
        /// <c>AMLClient.CreateBacktestResultAsync</c>.
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
        public lro::OperationsSettings CreateBacktestResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.UpdateBacktestResult</c> and <c>AMLClient.UpdateBacktestResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBacktestResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.UpdateBacktestResult</c> and
        /// <c>AMLClient.UpdateBacktestResultAsync</c>.
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
        public lro::OperationsSettings UpdateBacktestResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.ExportBacktestResultMetadata</c> and <c>AMLClient.ExportBacktestResultMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportBacktestResultMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.ExportBacktestResultMetadata</c> and
        /// <c>AMLClient.ExportBacktestResultMetadataAsync</c>.
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
        public lro::OperationsSettings ExportBacktestResultMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AMLClient.DeleteBacktestResult</c> and <c>AMLClient.DeleteBacktestResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBacktestResultSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AMLClient.DeleteBacktestResult</c> and
        /// <c>AMLClient.DeleteBacktestResultAsync</c>.
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
        public lro::OperationsSettings DeleteBacktestResultOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AMLSettings"/> object.</returns>
        public AMLSettings Clone() => new AMLSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AMLClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AMLClientBuilder : gaxgrpc::ClientBuilderBase<AMLClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AMLSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AMLClientBuilder() : base(AMLClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AMLClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AMLClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AMLClient Build()
        {
            AMLClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AMLClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AMLClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AMLClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AMLClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AMLClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AMLClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AMLClient.ChannelPool;
    }

    /// <summary>AML client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AML (Anti Money Laundering) service allows users to perform REST
    /// operations on aml.
    /// </remarks>
    public abstract partial class AMLClient
    {
        /// <summary>
        /// The default endpoint for the AML service, which is a host of "financialservices.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "financialservices.googleapis.com:443";

        /// <summary>The default AML scopes.</summary>
        /// <remarks>
        /// The default AML scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AML.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AMLClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AMLClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AMLClient"/>.</returns>
        public static stt::Task<AMLClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AMLClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AMLClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AMLClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AMLClient"/>.</returns>
        public static AMLClient Create() => new AMLClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AMLClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AMLSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AMLClient"/>.</returns>
        internal static AMLClient Create(grpccore::CallInvoker callInvoker, AMLSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AML.AMLClient grpcClient = new AML.AMLClient(callInvoker);
            return new AMLClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AML client</summary>
        public virtual AML.AMLClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
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
        /// Lists instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
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
        /// Lists instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
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
        /// Lists instances.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
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
        /// Gets an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Instance is the location for that Instance.
        /// Every location has exactly one instance.
        /// </param>
        /// <param name="instance">
        /// Required. The instance that will be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. The resource id of the instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(gagr::LocationName parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The new value of the instance fields that will be updated
        /// according to the update_mask
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Required. The new value of the instance fields that will be updated
        /// according to the update_mask
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
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
        /// Required. The new value of the instance fields that will be updated
        /// according to the update_mask
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Instance resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(Instance instance, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(instance, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instance.
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
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata> ImportRegisteredParties(ImportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(ImportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(ImportRegisteredPartiesRequest request, st::CancellationToken cancellationToken) =>
            ImportRegisteredPartiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportRegisteredParties</c>.</summary>
        public virtual lro::OperationsClient ImportRegisteredPartiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportRegisteredParties</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata> PollOnceImportRegisteredParties(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportRegisteredPartiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportRegisteredParties</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> PollOnceImportRegisteredPartiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportRegisteredPartiesOperationsClient, callSettings);

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata> ImportRegisteredParties(string name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, gaxgrpc::CallSettings callSettings = null) =>
            ImportRegisteredParties(new ImportRegisteredPartiesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PartyTables =
                {
                    partyTables ?? linq::Enumerable.Empty<string>(),
                },
                Mode = mode,
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(string name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, gaxgrpc::CallSettings callSettings = null) =>
            ImportRegisteredPartiesAsync(new ImportRegisteredPartiesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PartyTables =
                {
                    partyTables ?? linq::Enumerable.Empty<string>(),
                },
                Mode = mode,
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(string name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, st::CancellationToken cancellationToken) =>
            ImportRegisteredPartiesAsync(name, mode, lineOfBusiness, partyTables, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata> ImportRegisteredParties(InstanceName name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, gaxgrpc::CallSettings callSettings = null) =>
            ImportRegisteredParties(new ImportRegisteredPartiesRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PartyTables =
                {
                    partyTables ?? linq::Enumerable.Empty<string>(),
                },
                Mode = mode,
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(InstanceName name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, gaxgrpc::CallSettings callSettings = null) =>
            ImportRegisteredPartiesAsync(new ImportRegisteredPartiesRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PartyTables =
                {
                    partyTables ?? linq::Enumerable.Empty<string>(),
                },
                Mode = mode,
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="mode">
        /// Required. Mode of the request.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness for the specified registered parties.
        /// </param>
        /// <param name="partyTables">
        /// Optional. List of BigQuery tables. Union of tables will be taken if there
        /// is more than one table. VPC-SC restrictions apply. format:
        /// `bq://{project}.{bqDatasetID}.{bqTableID}` Use of `datasets` is preferred
        /// over the latter due to its simplicity and the reduced risk of errors
        /// `party_tables` and `datasets` must not be provided at the
        /// same time
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(InstanceName name, ImportRegisteredPartiesRequest.Types.UpdateMode mode, LineOfBusiness lineOfBusiness, scg::IEnumerable<string> partyTables, st::CancellationToken cancellationToken) =>
            ImportRegisteredPartiesAsync(name, mode, lineOfBusiness, partyTables, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata> ExportRegisteredParties(ExportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(ExportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(ExportRegisteredPartiesRequest request, st::CancellationToken cancellationToken) =>
            ExportRegisteredPartiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportRegisteredParties</c>.</summary>
        public virtual lro::OperationsClient ExportRegisteredPartiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportRegisteredParties</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata> PollOnceExportRegisteredParties(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportRegisteredPartiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportRegisteredParties</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> PollOnceExportRegisteredPartiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportRegisteredPartiesOperationsClient, callSettings);

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata> ExportRegisteredParties(string name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegisteredParties(new ExportRegisteredPartiesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(string name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegisteredPartiesAsync(new ExportRegisteredPartiesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(string name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, st::CancellationToken cancellationToken) =>
            ExportRegisteredPartiesAsync(name, dataset, lineOfBusiness, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata> ExportRegisteredParties(InstanceName name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegisteredParties(new ExportRegisteredPartiesRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(InstanceName name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, gaxgrpc::CallSettings callSettings = null) =>
            ExportRegisteredPartiesAsync(new ExportRegisteredPartiesRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                LineOfBusiness = lineOfBusiness,
            }, callSettings);

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="name">
        /// Required. The full path to the Instance resource in this API.
        /// format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataset">
        /// Required. The location to output the RegisteredParties.
        /// </param>
        /// <param name="lineOfBusiness">
        /// Required. LineOfBusiness to get RegisteredParties from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(InstanceName name, BigQueryDestination dataset, LineOfBusiness lineOfBusiness, st::CancellationToken cancellationToken) =>
            ExportRegisteredPartiesAsync(name, dataset, lineOfBusiness, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public virtual lro::OperationsClient CreateDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> PollOnceCreateDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> PollOnceCreateDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(string parent, Dataset dataset, string datasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, string datasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, string datasetId, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, datasetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(InstanceName parent, Dataset dataset, string datasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(InstanceName parent, Dataset dataset, string datasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatasetId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Dataset is the Instance.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset that will be created.
        /// </param>
        /// <param name="datasetId">
        /// Required. The resource id of the dataset
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(InstanceName parent, Dataset dataset, string datasetId, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, datasetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataset</c>.</summary>
        public virtual lro::OperationsClient UpdateDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> PollOnceUpdateDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> PollOnceUpdateDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The new value of the dataset fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Dataset resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> UpdateDataset(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataset(new UpdateDatasetRequest
            {
                UpdateMask = updateMask,
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The new value of the dataset fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Dataset resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetAsync(new UpdateDatasetRequest
            {
                UpdateMask = updateMask,
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The new value of the dataset fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Dataset resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public virtual lro::OperationsClient DeleteDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Dataset.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, st::CancellationToken cancellationToken) =>
            CreateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public virtual lro::OperationsClient CreateModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Model, OperationMetadata> PollOnceCreateModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> PollOnceCreateModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(string parent, Model model, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(string parent, Model model, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(string parent, Model model, string modelId, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, modelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(InstanceName parent, Model model, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(InstanceName parent, Model model, string modelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(modelId, nameof(modelId)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the Model is the Instance.
        /// </param>
        /// <param name="model">
        /// Required. The Model that will be created.
        /// </param>
        /// <param name="modelId">
        /// Required. The resource id of the Model
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(InstanceName parent, Model model, string modelId, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, modelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> UpdateModelAsync(UpdateModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateModel</c>.</summary>
        public virtual lro::OperationsClient UpdateModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Model, OperationMetadata> PollOnceUpdateModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> PollOnceUpdateModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="model">
        /// Required. The new value of the Model fields that will be updated according
        /// to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Model resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> UpdateModel(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModel(new UpdateModelRequest
            {
                UpdateMask = updateMask,
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="model">
        /// Required. The new value of the Model fields that will be updated according
        /// to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Model resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> UpdateModelAsync(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelAsync(new UpdateModelRequest
            {
                UpdateMask = updateMask,
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="model">
        /// Required. The new value of the Model fields that will be updated according
        /// to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Model resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> UpdateModelAsync(Model model, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(model, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelMetadataResponse, OperationMetadata> ExportModelMetadata(ExportModelMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(ExportModelMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(ExportModelMetadataRequest request, st::CancellationToken cancellationToken) =>
            ExportModelMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportModelMetadata</c>.</summary>
        public virtual lro::OperationsClient ExportModelMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportModelMetadata</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportModelMetadataResponse, OperationMetadata> PollOnceExportModelMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportModelMetadataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportModelMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> PollOnceExportModelMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportModelMetadataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelMetadataOperationsClient, callSettings);

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelMetadataResponse, OperationMetadata> ExportModelMetadata(string model, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelMetadata(new ExportModelMetadataRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(string model, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelMetadataAsync(new ExportModelMetadataRequest
            {
                Model = gax::GaxPreconditions.CheckNotNullOrEmpty(model, nameof(model)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(string model, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportModelMetadataAsync(model, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportModelMetadataResponse, OperationMetadata> ExportModelMetadata(ModelName model, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelMetadata(new ExportModelMetadataRequest
            {
                ModelAsModelName = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(ModelName model, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelMetadataAsync(new ExportModelMetadataRequest
            {
                ModelAsModelName = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="model">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(ModelName model, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportModelMetadataAsync(model, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public virtual lro::OperationsClient DeleteModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigs(ListEngineConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigsAsync(ListEngineConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
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
        /// <returns>A pageable sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
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
            return ListEngineConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
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
            return ListEngineConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
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
        /// <returns>A pageable sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigs(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
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
            return ListEngineConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EngineConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
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
            return ListEngineConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineConfig GetEngineConfig(GetEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(GetEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(GetEngineConfigRequest request, st::CancellationToken cancellationToken) =>
            GetEngineConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineConfig GetEngineConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineConfig(new GetEngineConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineConfigAsync(new GetEngineConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetEngineConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineConfig GetEngineConfig(EngineConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineConfig(new GetEngineConfigRequest
            {
                EngineConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(EngineConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineConfigAsync(new GetEngineConfigRequest
            {
                EngineConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineConfig> GetEngineConfigAsync(EngineConfigName name, st::CancellationToken cancellationToken) =>
            GetEngineConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> CreateEngineConfig(CreateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(CreateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(CreateEngineConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateEngineConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEngineConfig</c>.</summary>
        public virtual lro::OperationsClient CreateEngineConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEngineConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> PollOnceCreateEngineConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EngineConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEngineConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> PollOnceCreateEngineConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EngineConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> CreateEngineConfig(string parent, EngineConfig engineConfig, string engineConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineConfig(new CreateEngineConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EngineConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)),
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(string parent, EngineConfig engineConfig, string engineConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineConfigAsync(new CreateEngineConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EngineConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)),
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(string parent, EngineConfig engineConfig, string engineConfigId, st::CancellationToken cancellationToken) =>
            CreateEngineConfigAsync(parent, engineConfig, engineConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> CreateEngineConfig(InstanceName parent, EngineConfig engineConfig, string engineConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineConfig(new CreateEngineConfigRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EngineConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)),
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(InstanceName parent, EngineConfig engineConfig, string engineConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEngineConfigAsync(new CreateEngineConfigRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EngineConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfigId, nameof(engineConfigId)),
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineConfig is the Instance.
        /// </param>
        /// <param name="engineConfig">
        /// Required. The EngineConfig that will be created.
        /// </param>
        /// <param name="engineConfigId">
        /// Required. The resource id of the EngineConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(InstanceName parent, EngineConfig engineConfig, string engineConfigId, st::CancellationToken cancellationToken) =>
            CreateEngineConfigAsync(parent, engineConfig, engineConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> UpdateEngineConfig(UpdateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> UpdateEngineConfigAsync(UpdateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> UpdateEngineConfigAsync(UpdateEngineConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateEngineConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEngineConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateEngineConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEngineConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> PollOnceUpdateEngineConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EngineConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEngineConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> PollOnceUpdateEngineConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EngineConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The new value of the EngineConfig fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EngineConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EngineConfig, OperationMetadata> UpdateEngineConfig(EngineConfig engineConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEngineConfig(new UpdateEngineConfigRequest
            {
                UpdateMask = updateMask,
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The new value of the EngineConfig fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EngineConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> UpdateEngineConfigAsync(EngineConfig engineConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEngineConfigAsync(new UpdateEngineConfigRequest
            {
                UpdateMask = updateMask,
                EngineConfig = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The new value of the EngineConfig fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EngineConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EngineConfig, OperationMetadata>> UpdateEngineConfigAsync(EngineConfig engineConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEngineConfigAsync(engineConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata> ExportEngineConfigMetadata(ExportEngineConfigMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(ExportEngineConfigMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(ExportEngineConfigMetadataRequest request, st::CancellationToken cancellationToken) =>
            ExportEngineConfigMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportEngineConfigMetadata</c>.</summary>
        public virtual lro::OperationsClient ExportEngineConfigMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportEngineConfigMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata> PollOnceExportEngineConfigMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEngineConfigMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportEngineConfigMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> PollOnceExportEngineConfigMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEngineConfigMetadataOperationsClient, callSettings);

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata> ExportEngineConfigMetadata(string engineConfig, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportEngineConfigMetadata(new ExportEngineConfigMetadataRequest
            {
                EngineConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfig, nameof(engineConfig)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(string engineConfig, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportEngineConfigMetadataAsync(new ExportEngineConfigMetadataRequest
            {
                EngineConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(engineConfig, nameof(engineConfig)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(string engineConfig, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportEngineConfigMetadataAsync(engineConfig, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata> ExportEngineConfigMetadata(EngineConfigName engineConfig, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportEngineConfigMetadata(new ExportEngineConfigMetadataRequest
            {
                EngineConfigAsEngineConfigName = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(EngineConfigName engineConfig, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportEngineConfigMetadataAsync(new ExportEngineConfigMetadataRequest
            {
                EngineConfigAsEngineConfigName = gax::GaxPreconditions.CheckNotNull(engineConfig, nameof(engineConfig)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="engineConfig">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(EngineConfigName engineConfig, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportEngineConfigMetadataAsync(engineConfig, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEngineConfig(DeleteEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(DeleteEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(DeleteEngineConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteEngineConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEngineConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteEngineConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEngineConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEngineConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEngineConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEngineConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEngineConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEngineConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineConfig(new DeleteEngineConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineConfigAsync(new DeleteEngineConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEngineConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEngineConfig(EngineConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineConfig(new DeleteEngineConfigRequest
            {
                EngineConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(EngineConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEngineConfigAsync(new DeleteEngineConfigRequest
            {
                EngineConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(EngineConfigName name, st::CancellationToken cancellationToken) =>
            DeleteEngineConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineVersion GetEngineVersion(GetEngineVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(GetEngineVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(GetEngineVersionRequest request, st::CancellationToken cancellationToken) =>
            GetEngineVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineVersion GetEngineVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineVersion(new GetEngineVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineVersionAsync(new GetEngineVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetEngineVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EngineVersion GetEngineVersion(EngineVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineVersion(new GetEngineVersionRequest
            {
                EngineVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(EngineVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEngineVersionAsync(new GetEngineVersionRequest
            {
                EngineVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EngineVersion
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EngineVersion> GetEngineVersionAsync(EngineVersionName name, st::CancellationToken cancellationToken) =>
            GetEngineVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersions(ListEngineVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersionsAsync(ListEngineVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineVersion is the Instance.
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
        /// <returns>A pageable sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
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
            return ListEngineVersions(request, callSettings);
        }

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineVersion is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
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
            return ListEngineVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineVersion is the Instance.
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
        /// <returns>A pageable sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersions(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
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
            return ListEngineVersions(request, callSettings);
        }

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the EngineVersion is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EngineVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersionsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
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
            return ListEngineVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResults(ListPredictionResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResultsAsync(ListPredictionResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
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
        /// <returns>A pageable sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
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
            return ListPredictionResults(request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
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
            return ListPredictionResultsAsync(request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
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
        /// <returns>A pageable sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResults(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
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
            return ListPredictionResults(request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResultsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
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
            return ListPredictionResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionResult GetPredictionResult(GetPredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(GetPredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(GetPredictionResultRequest request, st::CancellationToken cancellationToken) =>
            GetPredictionResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionResult GetPredictionResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPredictionResult(new GetPredictionResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPredictionResultAsync(new GetPredictionResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetPredictionResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionResult GetPredictionResult(PredictionResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPredictionResult(new GetPredictionResultRequest
            {
                PredictionResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(PredictionResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPredictionResultAsync(new GetPredictionResultRequest
            {
                PredictionResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionResult> GetPredictionResultAsync(PredictionResultName name, st::CancellationToken cancellationToken) =>
            GetPredictionResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> CreatePredictionResult(CreatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(CreatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(CreatePredictionResultRequest request, st::CancellationToken cancellationToken) =>
            CreatePredictionResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePredictionResult</c>.</summary>
        public virtual lro::OperationsClient CreatePredictionResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> PollOnceCreatePredictionResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PredictionResult, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> PollOnceCreatePredictionResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PredictionResult, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> CreatePredictionResult(string parent, PredictionResult predictionResult, string predictionResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionResult(new CreatePredictionResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PredictionResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)),
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(string parent, PredictionResult predictionResult, string predictionResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionResultAsync(new CreatePredictionResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PredictionResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)),
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(string parent, PredictionResult predictionResult, string predictionResultId, st::CancellationToken cancellationToken) =>
            CreatePredictionResultAsync(parent, predictionResult, predictionResultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> CreatePredictionResult(InstanceName parent, PredictionResult predictionResult, string predictionResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionResult(new CreatePredictionResultRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PredictionResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)),
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(InstanceName parent, PredictionResult predictionResult, string predictionResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionResultAsync(new CreatePredictionResultRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PredictionResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResultId, nameof(predictionResultId)),
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the PredictionResult is the Instance.
        /// </param>
        /// <param name="predictionResult">
        /// Required. The PredictionResult that will be created.
        /// </param>
        /// <param name="predictionResultId">
        /// Required. The resource id of the PredictionResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(InstanceName parent, PredictionResult predictionResult, string predictionResultId, st::CancellationToken cancellationToken) =>
            CreatePredictionResultAsync(parent, predictionResult, predictionResultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> UpdatePredictionResult(UpdatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> UpdatePredictionResultAsync(UpdatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> UpdatePredictionResultAsync(UpdatePredictionResultRequest request, st::CancellationToken cancellationToken) =>
            UpdatePredictionResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePredictionResult</c>.</summary>
        public virtual lro::OperationsClient UpdatePredictionResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> PollOnceUpdatePredictionResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PredictionResult, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> PollOnceUpdatePredictionResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PredictionResult, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The new value of the PredictionResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// PredictionResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PredictionResult, OperationMetadata> UpdatePredictionResult(PredictionResult predictionResult, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePredictionResult(new UpdatePredictionResultRequest
            {
                UpdateMask = updateMask,
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The new value of the PredictionResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// PredictionResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> UpdatePredictionResultAsync(PredictionResult predictionResult, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePredictionResultAsync(new UpdatePredictionResultRequest
            {
                UpdateMask = updateMask,
                PredictionResult = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The new value of the PredictionResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// PredictionResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PredictionResult, OperationMetadata>> UpdatePredictionResultAsync(PredictionResult predictionResult, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePredictionResultAsync(predictionResult, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata> ExportPredictionResultMetadata(ExportPredictionResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(ExportPredictionResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(ExportPredictionResultMetadataRequest request, st::CancellationToken cancellationToken) =>
            ExportPredictionResultMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportPredictionResultMetadata</c>.</summary>
        public virtual lro::OperationsClient ExportPredictionResultMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportPredictionResultMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata> PollOnceExportPredictionResultMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportPredictionResultMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportPredictionResultMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> PollOnceExportPredictionResultMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportPredictionResultMetadataOperationsClient, callSettings);

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata> ExportPredictionResultMetadata(string predictionResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportPredictionResultMetadata(new ExportPredictionResultMetadataRequest
            {
                PredictionResult = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResult, nameof(predictionResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(string predictionResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportPredictionResultMetadataAsync(new ExportPredictionResultMetadataRequest
            {
                PredictionResult = gax::GaxPreconditions.CheckNotNullOrEmpty(predictionResult, nameof(predictionResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(string predictionResult, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportPredictionResultMetadataAsync(predictionResult, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata> ExportPredictionResultMetadata(PredictionResultName predictionResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportPredictionResultMetadata(new ExportPredictionResultMetadataRequest
            {
                PredictionResultAsPredictionResultName = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(PredictionResultName predictionResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportPredictionResultMetadataAsync(new ExportPredictionResultMetadataRequest
            {
                PredictionResultAsPredictionResultName = gax::GaxPreconditions.CheckNotNull(predictionResult, nameof(predictionResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="predictionResult">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(PredictionResultName predictionResult, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportPredictionResultMetadataAsync(predictionResult, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePredictionResult(DeletePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(DeletePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(DeletePredictionResultRequest request, st::CancellationToken cancellationToken) =>
            DeletePredictionResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePredictionResult</c>.</summary>
        public virtual lro::OperationsClient DeletePredictionResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePredictionResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePredictionResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePredictionResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePredictionResultOperationsClient, callSettings);

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePredictionResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionResult(new DeletePredictionResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionResultAsync(new DeletePredictionResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePredictionResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePredictionResult(PredictionResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionResult(new DeletePredictionResultRequest
            {
                PredictionResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(PredictionResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionResultAsync(new DeletePredictionResultRequest
            {
                PredictionResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the PredictionResult.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(PredictionResultName name, st::CancellationToken cancellationToken) =>
            DeletePredictionResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResults(ListBacktestResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResultsAsync(ListBacktestResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
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
        /// <returns>A pageable sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
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
            return ListBacktestResults(request, callSettings);
        }

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
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
            return ListBacktestResultsAsync(request, callSettings);
        }

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
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
        /// <returns>A pageable sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResults(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
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
            return ListBacktestResults(request, callSettings);
        }

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BacktestResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResultsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
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
            return ListBacktestResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BacktestResult GetBacktestResult(GetBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(GetBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(GetBacktestResultRequest request, st::CancellationToken cancellationToken) =>
            GetBacktestResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BacktestResult GetBacktestResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBacktestResult(new GetBacktestResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBacktestResultAsync(new GetBacktestResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetBacktestResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BacktestResult GetBacktestResult(BacktestResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBacktestResult(new GetBacktestResultRequest
            {
                BacktestResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(BacktestResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBacktestResultAsync(new GetBacktestResultRequest
            {
                BacktestResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BacktestResult> GetBacktestResultAsync(BacktestResultName name, st::CancellationToken cancellationToken) =>
            GetBacktestResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> CreateBacktestResult(CreateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(CreateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(CreateBacktestResultRequest request, st::CancellationToken cancellationToken) =>
            CreateBacktestResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBacktestResult</c>.</summary>
        public virtual lro::OperationsClient CreateBacktestResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBacktestResult</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> PollOnceCreateBacktestResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BacktestResult, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBacktestResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> PollOnceCreateBacktestResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BacktestResult, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> CreateBacktestResult(string parent, BacktestResult backtestResult, string backtestResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBacktestResult(new CreateBacktestResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BacktestResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)),
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(string parent, BacktestResult backtestResult, string backtestResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBacktestResultAsync(new CreateBacktestResultRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BacktestResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)),
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(string parent, BacktestResult backtestResult, string backtestResultId, st::CancellationToken cancellationToken) =>
            CreateBacktestResultAsync(parent, backtestResult, backtestResultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> CreateBacktestResult(InstanceName parent, BacktestResult backtestResult, string backtestResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBacktestResult(new CreateBacktestResultRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BacktestResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)),
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(InstanceName parent, BacktestResult backtestResult, string backtestResultId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBacktestResultAsync(new CreateBacktestResultRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BacktestResultId = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResultId, nameof(backtestResultId)),
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the BacktestResult is the Instance.
        /// </param>
        /// <param name="backtestResult">
        /// Required. The BacktestResult that will be created.
        /// </param>
        /// <param name="backtestResultId">
        /// Required. The resource id of the BacktestResult
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(InstanceName parent, BacktestResult backtestResult, string backtestResultId, st::CancellationToken cancellationToken) =>
            CreateBacktestResultAsync(parent, backtestResult, backtestResultId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> UpdateBacktestResult(UpdateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> UpdateBacktestResultAsync(UpdateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> UpdateBacktestResultAsync(UpdateBacktestResultRequest request, st::CancellationToken cancellationToken) =>
            UpdateBacktestResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBacktestResult</c>.</summary>
        public virtual lro::OperationsClient UpdateBacktestResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBacktestResult</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> PollOnceUpdateBacktestResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BacktestResult, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBacktestResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> PollOnceUpdateBacktestResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BacktestResult, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The new value of the BacktestResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BacktestResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BacktestResult, OperationMetadata> UpdateBacktestResult(BacktestResult backtestResult, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBacktestResult(new UpdateBacktestResultRequest
            {
                UpdateMask = updateMask,
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The new value of the BacktestResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BacktestResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> UpdateBacktestResultAsync(BacktestResult backtestResult, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBacktestResultAsync(new UpdateBacktestResultRequest
            {
                UpdateMask = updateMask,
                BacktestResult = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The new value of the BacktestResult fields that will be updated
        /// according to the update_mask.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// BacktestResult resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BacktestResult, OperationMetadata>> UpdateBacktestResultAsync(BacktestResult backtestResult, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBacktestResultAsync(backtestResult, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata> ExportBacktestResultMetadata(ExportBacktestResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(ExportBacktestResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(ExportBacktestResultMetadataRequest request, st::CancellationToken cancellationToken) =>
            ExportBacktestResultMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportBacktestResultMetadata</c>.</summary>
        public virtual lro::OperationsClient ExportBacktestResultMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportBacktestResultMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata> PollOnceExportBacktestResultMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBacktestResultMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportBacktestResultMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> PollOnceExportBacktestResultMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportBacktestResultMetadataOperationsClient, callSettings);

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata> ExportBacktestResultMetadata(string backtestResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportBacktestResultMetadata(new ExportBacktestResultMetadataRequest
            {
                BacktestResult = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResult, nameof(backtestResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(string backtestResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportBacktestResultMetadataAsync(new ExportBacktestResultMetadataRequest
            {
                BacktestResult = gax::GaxPreconditions.CheckNotNullOrEmpty(backtestResult, nameof(backtestResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(string backtestResult, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportBacktestResultMetadataAsync(backtestResult, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata> ExportBacktestResultMetadata(BacktestResultName backtestResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportBacktestResultMetadata(new ExportBacktestResultMetadataRequest
            {
                BacktestResultAsBacktestResultName = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(BacktestResultName backtestResult, BigQueryDestination structuredMetadataDestination, gaxgrpc::CallSettings callSettings = null) =>
            ExportBacktestResultMetadataAsync(new ExportBacktestResultMetadataRequest
            {
                BacktestResultAsBacktestResultName = gax::GaxPreconditions.CheckNotNull(backtestResult, nameof(backtestResult)),
                StructuredMetadataDestination = gax::GaxPreconditions.CheckNotNull(structuredMetadataDestination, nameof(structuredMetadataDestination)),
            }, callSettings);

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="backtestResult">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="structuredMetadataDestination">
        /// Required. BigQuery output where the metadata will be written.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(BacktestResultName backtestResult, BigQueryDestination structuredMetadataDestination, st::CancellationToken cancellationToken) =>
            ExportBacktestResultMetadataAsync(backtestResult, structuredMetadataDestination, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBacktestResult(DeleteBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(DeleteBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(DeleteBacktestResultRequest request, st::CancellationToken cancellationToken) =>
            DeleteBacktestResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBacktestResult</c>.</summary>
        public virtual lro::OperationsClient DeleteBacktestResultOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteBacktestResult</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteBacktestResult(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBacktestResult</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteBacktestResultAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBacktestResultOperationsClient, callSettings);

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBacktestResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBacktestResult(new DeleteBacktestResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBacktestResultAsync(new DeleteBacktestResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBacktestResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteBacktestResult(BacktestResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBacktestResult(new DeleteBacktestResultRequest
            {
                BacktestResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(BacktestResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBacktestResultAsync(new DeleteBacktestResultRequest
            {
                BacktestResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BacktestResult.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(BacktestResultName name, st::CancellationToken cancellationToken) =>
            DeleteBacktestResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AML client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AML (Anti Money Laundering) service allows users to perform REST
    /// operations on aml.
    /// </remarks>
    public sealed partial class AMLClientImpl : AMLClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<ImportRegisteredPartiesRequest, lro::Operation> _callImportRegisteredParties;

        private readonly gaxgrpc::ApiCall<ExportRegisteredPartiesRequest, lro::Operation> _callExportRegisteredParties;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<UpdateDatasetRequest, lro::Operation> _callUpdateDataset;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> _callDeleteDataset;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> _callCreateModel;

        private readonly gaxgrpc::ApiCall<UpdateModelRequest, lro::Operation> _callUpdateModel;

        private readonly gaxgrpc::ApiCall<ExportModelMetadataRequest, lro::Operation> _callExportModelMetadata;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> _callDeleteModel;

        private readonly gaxgrpc::ApiCall<ListEngineConfigsRequest, ListEngineConfigsResponse> _callListEngineConfigs;

        private readonly gaxgrpc::ApiCall<GetEngineConfigRequest, EngineConfig> _callGetEngineConfig;

        private readonly gaxgrpc::ApiCall<CreateEngineConfigRequest, lro::Operation> _callCreateEngineConfig;

        private readonly gaxgrpc::ApiCall<UpdateEngineConfigRequest, lro::Operation> _callUpdateEngineConfig;

        private readonly gaxgrpc::ApiCall<ExportEngineConfigMetadataRequest, lro::Operation> _callExportEngineConfigMetadata;

        private readonly gaxgrpc::ApiCall<DeleteEngineConfigRequest, lro::Operation> _callDeleteEngineConfig;

        private readonly gaxgrpc::ApiCall<GetEngineVersionRequest, EngineVersion> _callGetEngineVersion;

        private readonly gaxgrpc::ApiCall<ListEngineVersionsRequest, ListEngineVersionsResponse> _callListEngineVersions;

        private readonly gaxgrpc::ApiCall<ListPredictionResultsRequest, ListPredictionResultsResponse> _callListPredictionResults;

        private readonly gaxgrpc::ApiCall<GetPredictionResultRequest, PredictionResult> _callGetPredictionResult;

        private readonly gaxgrpc::ApiCall<CreatePredictionResultRequest, lro::Operation> _callCreatePredictionResult;

        private readonly gaxgrpc::ApiCall<UpdatePredictionResultRequest, lro::Operation> _callUpdatePredictionResult;

        private readonly gaxgrpc::ApiCall<ExportPredictionResultMetadataRequest, lro::Operation> _callExportPredictionResultMetadata;

        private readonly gaxgrpc::ApiCall<DeletePredictionResultRequest, lro::Operation> _callDeletePredictionResult;

        private readonly gaxgrpc::ApiCall<ListBacktestResultsRequest, ListBacktestResultsResponse> _callListBacktestResults;

        private readonly gaxgrpc::ApiCall<GetBacktestResultRequest, BacktestResult> _callGetBacktestResult;

        private readonly gaxgrpc::ApiCall<CreateBacktestResultRequest, lro::Operation> _callCreateBacktestResult;

        private readonly gaxgrpc::ApiCall<UpdateBacktestResultRequest, lro::Operation> _callUpdateBacktestResult;

        private readonly gaxgrpc::ApiCall<ExportBacktestResultMetadataRequest, lro::Operation> _callExportBacktestResultMetadata;

        private readonly gaxgrpc::ApiCall<DeleteBacktestResultRequest, lro::Operation> _callDeleteBacktestResult;

        /// <summary>
        /// Constructs a client wrapper for the AML service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AMLSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AMLClientImpl(AML.AMLClient grpcClient, AMLSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AMLSettings effectiveSettings = settings ?? AMLSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            ImportRegisteredPartiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportRegisteredPartiesOperationsSettings, logger);
            ExportRegisteredPartiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportRegisteredPartiesOperationsSettings, logger);
            CreateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatasetOperationsSettings, logger);
            UpdateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatasetOperationsSettings, logger);
            DeleteDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDatasetOperationsSettings, logger);
            CreateModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateModelOperationsSettings, logger);
            UpdateModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateModelOperationsSettings, logger);
            ExportModelMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportModelMetadataOperationsSettings, logger);
            DeleteModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelOperationsSettings, logger);
            CreateEngineConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEngineConfigOperationsSettings, logger);
            UpdateEngineConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEngineConfigOperationsSettings, logger);
            ExportEngineConfigMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportEngineConfigMetadataOperationsSettings, logger);
            DeleteEngineConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEngineConfigOperationsSettings, logger);
            CreatePredictionResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePredictionResultOperationsSettings, logger);
            UpdatePredictionResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePredictionResultOperationsSettings, logger);
            ExportPredictionResultMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportPredictionResultMetadataOperationsSettings, logger);
            DeletePredictionResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePredictionResultOperationsSettings, logger);
            CreateBacktestResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBacktestResultOperationsSettings, logger);
            UpdateBacktestResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBacktestResultOperationsSettings, logger);
            ExportBacktestResultMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportBacktestResultMetadataOperationsSettings, logger);
            DeleteBacktestResultOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBacktestResultOperationsSettings, logger);
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
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callImportRegisteredParties = clientHelper.BuildApiCall<ImportRegisteredPartiesRequest, lro::Operation>("ImportRegisteredParties", grpcClient.ImportRegisteredPartiesAsync, grpcClient.ImportRegisteredParties, effectiveSettings.ImportRegisteredPartiesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportRegisteredParties);
            Modify_ImportRegisteredPartiesApiCall(ref _callImportRegisteredParties);
            _callExportRegisteredParties = clientHelper.BuildApiCall<ExportRegisteredPartiesRequest, lro::Operation>("ExportRegisteredParties", grpcClient.ExportRegisteredPartiesAsync, grpcClient.ExportRegisteredParties, effectiveSettings.ExportRegisteredPartiesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportRegisteredParties);
            Modify_ExportRegisteredPartiesApiCall(ref _callExportRegisteredParties);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, lro::Operation>("CreateDataset", grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callUpdateDataset = clientHelper.BuildApiCall<UpdateDatasetRequest, lro::Operation>("UpdateDataset", grpcClient.UpdateDatasetAsync, grpcClient.UpdateDataset, effectiveSettings.UpdateDatasetSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDataset);
            Modify_UpdateDatasetApiCall(ref _callUpdateDataset);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, lro::Operation>("DeleteDataset", grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>("ListModels", grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>("GetModel", grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callCreateModel = clientHelper.BuildApiCall<CreateModelRequest, lro::Operation>("CreateModel", grpcClient.CreateModelAsync, grpcClient.CreateModel, effectiveSettings.CreateModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModel);
            Modify_CreateModelApiCall(ref _callCreateModel);
            _callUpdateModel = clientHelper.BuildApiCall<UpdateModelRequest, lro::Operation>("UpdateModel", grpcClient.UpdateModelAsync, grpcClient.UpdateModel, effectiveSettings.UpdateModelSettings).WithGoogleRequestParam("model.name", request => request.Model?.Name);
            Modify_ApiCall(ref _callUpdateModel);
            Modify_UpdateModelApiCall(ref _callUpdateModel);
            _callExportModelMetadata = clientHelper.BuildApiCall<ExportModelMetadataRequest, lro::Operation>("ExportModelMetadata", grpcClient.ExportModelMetadataAsync, grpcClient.ExportModelMetadata, effectiveSettings.ExportModelMetadataSettings).WithGoogleRequestParam("model", request => request.Model);
            Modify_ApiCall(ref _callExportModelMetadata);
            Modify_ExportModelMetadataApiCall(ref _callExportModelMetadata);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, lro::Operation>("DeleteModel", grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            _callListEngineConfigs = clientHelper.BuildApiCall<ListEngineConfigsRequest, ListEngineConfigsResponse>("ListEngineConfigs", grpcClient.ListEngineConfigsAsync, grpcClient.ListEngineConfigs, effectiveSettings.ListEngineConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEngineConfigs);
            Modify_ListEngineConfigsApiCall(ref _callListEngineConfigs);
            _callGetEngineConfig = clientHelper.BuildApiCall<GetEngineConfigRequest, EngineConfig>("GetEngineConfig", grpcClient.GetEngineConfigAsync, grpcClient.GetEngineConfig, effectiveSettings.GetEngineConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEngineConfig);
            Modify_GetEngineConfigApiCall(ref _callGetEngineConfig);
            _callCreateEngineConfig = clientHelper.BuildApiCall<CreateEngineConfigRequest, lro::Operation>("CreateEngineConfig", grpcClient.CreateEngineConfigAsync, grpcClient.CreateEngineConfig, effectiveSettings.CreateEngineConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEngineConfig);
            Modify_CreateEngineConfigApiCall(ref _callCreateEngineConfig);
            _callUpdateEngineConfig = clientHelper.BuildApiCall<UpdateEngineConfigRequest, lro::Operation>("UpdateEngineConfig", grpcClient.UpdateEngineConfigAsync, grpcClient.UpdateEngineConfig, effectiveSettings.UpdateEngineConfigSettings).WithGoogleRequestParam("engine_config.name", request => request.EngineConfig?.Name);
            Modify_ApiCall(ref _callUpdateEngineConfig);
            Modify_UpdateEngineConfigApiCall(ref _callUpdateEngineConfig);
            _callExportEngineConfigMetadata = clientHelper.BuildApiCall<ExportEngineConfigMetadataRequest, lro::Operation>("ExportEngineConfigMetadata", grpcClient.ExportEngineConfigMetadataAsync, grpcClient.ExportEngineConfigMetadata, effectiveSettings.ExportEngineConfigMetadataSettings).WithGoogleRequestParam("engine_config", request => request.EngineConfig);
            Modify_ApiCall(ref _callExportEngineConfigMetadata);
            Modify_ExportEngineConfigMetadataApiCall(ref _callExportEngineConfigMetadata);
            _callDeleteEngineConfig = clientHelper.BuildApiCall<DeleteEngineConfigRequest, lro::Operation>("DeleteEngineConfig", grpcClient.DeleteEngineConfigAsync, grpcClient.DeleteEngineConfig, effectiveSettings.DeleteEngineConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEngineConfig);
            Modify_DeleteEngineConfigApiCall(ref _callDeleteEngineConfig);
            _callGetEngineVersion = clientHelper.BuildApiCall<GetEngineVersionRequest, EngineVersion>("GetEngineVersion", grpcClient.GetEngineVersionAsync, grpcClient.GetEngineVersion, effectiveSettings.GetEngineVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEngineVersion);
            Modify_GetEngineVersionApiCall(ref _callGetEngineVersion);
            _callListEngineVersions = clientHelper.BuildApiCall<ListEngineVersionsRequest, ListEngineVersionsResponse>("ListEngineVersions", grpcClient.ListEngineVersionsAsync, grpcClient.ListEngineVersions, effectiveSettings.ListEngineVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEngineVersions);
            Modify_ListEngineVersionsApiCall(ref _callListEngineVersions);
            _callListPredictionResults = clientHelper.BuildApiCall<ListPredictionResultsRequest, ListPredictionResultsResponse>("ListPredictionResults", grpcClient.ListPredictionResultsAsync, grpcClient.ListPredictionResults, effectiveSettings.ListPredictionResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPredictionResults);
            Modify_ListPredictionResultsApiCall(ref _callListPredictionResults);
            _callGetPredictionResult = clientHelper.BuildApiCall<GetPredictionResultRequest, PredictionResult>("GetPredictionResult", grpcClient.GetPredictionResultAsync, grpcClient.GetPredictionResult, effectiveSettings.GetPredictionResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPredictionResult);
            Modify_GetPredictionResultApiCall(ref _callGetPredictionResult);
            _callCreatePredictionResult = clientHelper.BuildApiCall<CreatePredictionResultRequest, lro::Operation>("CreatePredictionResult", grpcClient.CreatePredictionResultAsync, grpcClient.CreatePredictionResult, effectiveSettings.CreatePredictionResultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePredictionResult);
            Modify_CreatePredictionResultApiCall(ref _callCreatePredictionResult);
            _callUpdatePredictionResult = clientHelper.BuildApiCall<UpdatePredictionResultRequest, lro::Operation>("UpdatePredictionResult", grpcClient.UpdatePredictionResultAsync, grpcClient.UpdatePredictionResult, effectiveSettings.UpdatePredictionResultSettings).WithGoogleRequestParam("prediction_result.name", request => request.PredictionResult?.Name);
            Modify_ApiCall(ref _callUpdatePredictionResult);
            Modify_UpdatePredictionResultApiCall(ref _callUpdatePredictionResult);
            _callExportPredictionResultMetadata = clientHelper.BuildApiCall<ExportPredictionResultMetadataRequest, lro::Operation>("ExportPredictionResultMetadata", grpcClient.ExportPredictionResultMetadataAsync, grpcClient.ExportPredictionResultMetadata, effectiveSettings.ExportPredictionResultMetadataSettings).WithGoogleRequestParam("prediction_result", request => request.PredictionResult);
            Modify_ApiCall(ref _callExportPredictionResultMetadata);
            Modify_ExportPredictionResultMetadataApiCall(ref _callExportPredictionResultMetadata);
            _callDeletePredictionResult = clientHelper.BuildApiCall<DeletePredictionResultRequest, lro::Operation>("DeletePredictionResult", grpcClient.DeletePredictionResultAsync, grpcClient.DeletePredictionResult, effectiveSettings.DeletePredictionResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePredictionResult);
            Modify_DeletePredictionResultApiCall(ref _callDeletePredictionResult);
            _callListBacktestResults = clientHelper.BuildApiCall<ListBacktestResultsRequest, ListBacktestResultsResponse>("ListBacktestResults", grpcClient.ListBacktestResultsAsync, grpcClient.ListBacktestResults, effectiveSettings.ListBacktestResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBacktestResults);
            Modify_ListBacktestResultsApiCall(ref _callListBacktestResults);
            _callGetBacktestResult = clientHelper.BuildApiCall<GetBacktestResultRequest, BacktestResult>("GetBacktestResult", grpcClient.GetBacktestResultAsync, grpcClient.GetBacktestResult, effectiveSettings.GetBacktestResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBacktestResult);
            Modify_GetBacktestResultApiCall(ref _callGetBacktestResult);
            _callCreateBacktestResult = clientHelper.BuildApiCall<CreateBacktestResultRequest, lro::Operation>("CreateBacktestResult", grpcClient.CreateBacktestResultAsync, grpcClient.CreateBacktestResult, effectiveSettings.CreateBacktestResultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBacktestResult);
            Modify_CreateBacktestResultApiCall(ref _callCreateBacktestResult);
            _callUpdateBacktestResult = clientHelper.BuildApiCall<UpdateBacktestResultRequest, lro::Operation>("UpdateBacktestResult", grpcClient.UpdateBacktestResultAsync, grpcClient.UpdateBacktestResult, effectiveSettings.UpdateBacktestResultSettings).WithGoogleRequestParam("backtest_result.name", request => request.BacktestResult?.Name);
            Modify_ApiCall(ref _callUpdateBacktestResult);
            Modify_UpdateBacktestResultApiCall(ref _callUpdateBacktestResult);
            _callExportBacktestResultMetadata = clientHelper.BuildApiCall<ExportBacktestResultMetadataRequest, lro::Operation>("ExportBacktestResultMetadata", grpcClient.ExportBacktestResultMetadataAsync, grpcClient.ExportBacktestResultMetadata, effectiveSettings.ExportBacktestResultMetadataSettings).WithGoogleRequestParam("backtest_result", request => request.BacktestResult);
            Modify_ApiCall(ref _callExportBacktestResultMetadata);
            Modify_ExportBacktestResultMetadataApiCall(ref _callExportBacktestResultMetadata);
            _callDeleteBacktestResult = clientHelper.BuildApiCall<DeleteBacktestResultRequest, lro::Operation>("DeleteBacktestResult", grpcClient.DeleteBacktestResultAsync, grpcClient.DeleteBacktestResult, effectiveSettings.DeleteBacktestResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBacktestResult);
            Modify_DeleteBacktestResultApiCall(ref _callDeleteBacktestResult);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_ImportRegisteredPartiesApiCall(ref gaxgrpc::ApiCall<ImportRegisteredPartiesRequest, lro::Operation> call);

        partial void Modify_ExportRegisteredPartiesApiCall(ref gaxgrpc::ApiCall<ExportRegisteredPartiesRequest, lro::Operation> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> call);

        partial void Modify_UpdateDatasetApiCall(ref gaxgrpc::ApiCall<UpdateDatasetRequest, lro::Operation> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_CreateModelApiCall(ref gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> call);

        partial void Modify_UpdateModelApiCall(ref gaxgrpc::ApiCall<UpdateModelRequest, lro::Operation> call);

        partial void Modify_ExportModelMetadataApiCall(ref gaxgrpc::ApiCall<ExportModelMetadataRequest, lro::Operation> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> call);

        partial void Modify_ListEngineConfigsApiCall(ref gaxgrpc::ApiCall<ListEngineConfigsRequest, ListEngineConfigsResponse> call);

        partial void Modify_GetEngineConfigApiCall(ref gaxgrpc::ApiCall<GetEngineConfigRequest, EngineConfig> call);

        partial void Modify_CreateEngineConfigApiCall(ref gaxgrpc::ApiCall<CreateEngineConfigRequest, lro::Operation> call);

        partial void Modify_UpdateEngineConfigApiCall(ref gaxgrpc::ApiCall<UpdateEngineConfigRequest, lro::Operation> call);

        partial void Modify_ExportEngineConfigMetadataApiCall(ref gaxgrpc::ApiCall<ExportEngineConfigMetadataRequest, lro::Operation> call);

        partial void Modify_DeleteEngineConfigApiCall(ref gaxgrpc::ApiCall<DeleteEngineConfigRequest, lro::Operation> call);

        partial void Modify_GetEngineVersionApiCall(ref gaxgrpc::ApiCall<GetEngineVersionRequest, EngineVersion> call);

        partial void Modify_ListEngineVersionsApiCall(ref gaxgrpc::ApiCall<ListEngineVersionsRequest, ListEngineVersionsResponse> call);

        partial void Modify_ListPredictionResultsApiCall(ref gaxgrpc::ApiCall<ListPredictionResultsRequest, ListPredictionResultsResponse> call);

        partial void Modify_GetPredictionResultApiCall(ref gaxgrpc::ApiCall<GetPredictionResultRequest, PredictionResult> call);

        partial void Modify_CreatePredictionResultApiCall(ref gaxgrpc::ApiCall<CreatePredictionResultRequest, lro::Operation> call);

        partial void Modify_UpdatePredictionResultApiCall(ref gaxgrpc::ApiCall<UpdatePredictionResultRequest, lro::Operation> call);

        partial void Modify_ExportPredictionResultMetadataApiCall(ref gaxgrpc::ApiCall<ExportPredictionResultMetadataRequest, lro::Operation> call);

        partial void Modify_DeletePredictionResultApiCall(ref gaxgrpc::ApiCall<DeletePredictionResultRequest, lro::Operation> call);

        partial void Modify_ListBacktestResultsApiCall(ref gaxgrpc::ApiCall<ListBacktestResultsRequest, ListBacktestResultsResponse> call);

        partial void Modify_GetBacktestResultApiCall(ref gaxgrpc::ApiCall<GetBacktestResultRequest, BacktestResult> call);

        partial void Modify_CreateBacktestResultApiCall(ref gaxgrpc::ApiCall<CreateBacktestResultRequest, lro::Operation> call);

        partial void Modify_UpdateBacktestResultApiCall(ref gaxgrpc::ApiCall<UpdateBacktestResultRequest, lro::Operation> call);

        partial void Modify_ExportBacktestResultMetadataApiCall(ref gaxgrpc::ApiCall<ExportBacktestResultMetadataRequest, lro::Operation> call);

        partial void Modify_DeleteBacktestResultApiCall(ref gaxgrpc::ApiCall<DeleteBacktestResultRequest, lro::Operation> call);

        partial void OnConstruction(AML.AMLClient grpcClient, AMLSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AML client</summary>
        public override AML.AMLClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportRegisteredPartiesRequest(ref ImportRegisteredPartiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportRegisteredPartiesRequest(ref ExportRegisteredPartiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetRequest(ref UpdateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateModelRequest(ref CreateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelRequest(ref UpdateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportModelMetadataRequest(ref ExportModelMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEngineConfigsRequest(ref ListEngineConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEngineConfigRequest(ref GetEngineConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEngineConfigRequest(ref CreateEngineConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEngineConfigRequest(ref UpdateEngineConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportEngineConfigMetadataRequest(ref ExportEngineConfigMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEngineConfigRequest(ref DeleteEngineConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEngineVersionRequest(ref GetEngineVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEngineVersionsRequest(ref ListEngineVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPredictionResultsRequest(ref ListPredictionResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPredictionResultRequest(ref GetPredictionResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePredictionResultRequest(ref CreatePredictionResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePredictionResultRequest(ref UpdatePredictionResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportPredictionResultMetadataRequest(ref ExportPredictionResultMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePredictionResultRequest(ref DeletePredictionResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBacktestResultsRequest(ref ListBacktestResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBacktestResultRequest(ref GetBacktestResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBacktestResultRequest(ref CreateBacktestResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBacktestResultRequest(ref UpdateBacktestResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportBacktestResultMetadataRequest(ref ExportBacktestResultMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBacktestResultRequest(ref DeleteBacktestResultRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists instances.
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
        /// Lists instances.
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
        /// Gets an instance.
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
        /// Gets an instance.
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
        /// Creates an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
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

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes an instance.
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
        /// Deletes an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportRegisteredParties</c>.</summary>
        public override lro::OperationsClient ImportRegisteredPartiesOperationsClient { get; }

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata> ImportRegisteredParties(ImportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportRegisteredPartiesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>(_callImportRegisteredParties.Sync(request, callSettings), ImportRegisteredPartiesOperationsClient);
        }

        /// <summary>
        /// Imports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#import-registered-parties)
        /// for information on the input schema and response for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>> ImportRegisteredPartiesAsync(ImportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportRegisteredPartiesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportRegisteredPartiesResponse, OperationMetadata>(await _callImportRegisteredParties.Async(request, callSettings).ConfigureAwait(false), ImportRegisteredPartiesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportRegisteredParties</c>.</summary>
        public override lro::OperationsClient ExportRegisteredPartiesOperationsClient { get; }

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata> ExportRegisteredParties(ExportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRegisteredPartiesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>(_callExportRegisteredParties.Sync(request, callSettings), ExportRegisteredPartiesOperationsClient);
        }

        /// <summary>
        /// Exports the list of registered parties. See
        /// [Create and manage
        /// instances](https://cloud.google.com/financial-services/anti-money-laundering/docs/create-and-manage-instances#export-registered-parties)
        /// for information on the output schema for this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>> ExportRegisteredPartiesAsync(ExportRegisteredPartiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRegisteredPartiesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportRegisteredPartiesResponse, OperationMetadata>(await _callExportRegisteredParties.Async(request, callSettings).ConfigureAwait(false), ExportRegisteredPartiesOperationsClient);
        }

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists datasets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public override lro::OperationsClient CreateDatasetOperationsClient { get; }

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Dataset, OperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(_callCreateDataset.Sync(request, callSettings), CreateDatasetOperationsClient);
        }

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(await _callCreateDataset.Async(request, callSettings).ConfigureAwait(false), CreateDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataset</c>.</summary>
        public override lro::OperationsClient UpdateDatasetOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Dataset, OperationMetadata> UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(_callUpdateDataset.Sync(request, callSettings), UpdateDatasetOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, OperationMetadata>> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(await _callUpdateDataset.Async(request, callSettings).ConfigureAwait(false), UpdateDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public override lro::OperationsClient DeleteDatasetOperationsClient { get; }

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataset.Sync(request, callSettings), DeleteDatasetOperationsClient);
        }

        /// <summary>
        /// Deletes a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataset.Async(request, callSettings).ConfigureAwait(false), DeleteDatasetOperationsClient);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public override lro::OperationsClient CreateModelOperationsClient { get; }

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Model, OperationMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(_callCreateModel.Sync(request, callSettings), CreateModelOperationsClient);
        }

        /// <summary>
        /// Creates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(await _callCreateModel.Async(request, callSettings).ConfigureAwait(false), CreateModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateModel</c>.</summary>
        public override lro::OperationsClient UpdateModelOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Model, OperationMetadata> UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(_callUpdateModel.Sync(request, callSettings), UpdateModelOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Model, OperationMetadata>> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(await _callUpdateModel.Async(request, callSettings).ConfigureAwait(false), UpdateModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportModelMetadata</c>.</summary>
        public override lro::OperationsClient ExportModelMetadataOperationsClient { get; }

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportModelMetadataResponse, OperationMetadata> ExportModelMetadata(ExportModelMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportModelMetadataResponse, OperationMetadata>(_callExportModelMetadata.Sync(request, callSettings), ExportModelMetadataOperationsClient);
        }

        /// <summary>
        /// Export governance information for a Model resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#model).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportModelMetadataResponse, OperationMetadata>> ExportModelMetadataAsync(ExportModelMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportModelMetadataResponse, OperationMetadata>(await _callExportModelMetadata.Async(request, callSettings).ConfigureAwait(false), ExportModelMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public override lro::OperationsClient DeleteModelOperationsClient { get; }

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteModel.Sync(request, callSettings), DeleteModelOperationsClient);
        }

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteModel.Async(request, callSettings).ConfigureAwait(false), DeleteModelOperationsClient);
        }

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EngineConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigs(ListEngineConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEngineConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEngineConfigsRequest, ListEngineConfigsResponse, EngineConfig>(_callListEngineConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists engine configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EngineConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> ListEngineConfigsAsync(ListEngineConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEngineConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEngineConfigsRequest, ListEngineConfigsResponse, EngineConfig>(_callListEngineConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EngineConfig GetEngineConfig(GetEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineConfigRequest(ref request, ref callSettings);
            return _callGetEngineConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EngineConfig> GetEngineConfigAsync(GetEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineConfigRequest(ref request, ref callSettings);
            return _callGetEngineConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEngineConfig</c>.</summary>
        public override lro::OperationsClient CreateEngineConfigOperationsClient { get; }

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EngineConfig, OperationMetadata> CreateEngineConfig(CreateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EngineConfig, OperationMetadata>(_callCreateEngineConfig.Sync(request, callSettings), CreateEngineConfigOperationsClient);
        }

        /// <summary>
        /// Creates an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EngineConfig, OperationMetadata>> CreateEngineConfigAsync(CreateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EngineConfig, OperationMetadata>(await _callCreateEngineConfig.Async(request, callSettings).ConfigureAwait(false), CreateEngineConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEngineConfig</c>.</summary>
        public override lro::OperationsClient UpdateEngineConfigOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EngineConfig, OperationMetadata> UpdateEngineConfig(UpdateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EngineConfig, OperationMetadata>(_callUpdateEngineConfig.Sync(request, callSettings), UpdateEngineConfigOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single EngineConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EngineConfig, OperationMetadata>> UpdateEngineConfigAsync(UpdateEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<EngineConfig, OperationMetadata>(await _callUpdateEngineConfig.Async(request, callSettings).ConfigureAwait(false), UpdateEngineConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportEngineConfigMetadata</c>.</summary>
        public override lro::OperationsClient ExportEngineConfigMetadataOperationsClient { get; }

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata> ExportEngineConfigMetadata(ExportEngineConfigMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEngineConfigMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>(_callExportEngineConfigMetadata.Sync(request, callSettings), ExportEngineConfigMetadataOperationsClient);
        }

        /// <summary>
        /// Export governance information for an EngineConfig resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#engine-config).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>> ExportEngineConfigMetadataAsync(ExportEngineConfigMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEngineConfigMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEngineConfigMetadataResponse, OperationMetadata>(await _callExportEngineConfigMetadata.Async(request, callSettings).ConfigureAwait(false), ExportEngineConfigMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEngineConfig</c>.</summary>
        public override lro::OperationsClient DeleteEngineConfigOperationsClient { get; }

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEngineConfig(DeleteEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEngineConfig.Sync(request, callSettings), DeleteEngineConfigOperationsClient);
        }

        /// <summary>
        /// Deletes an engine config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEngineConfigAsync(DeleteEngineConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEngineConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEngineConfig.Async(request, callSettings).ConfigureAwait(false), DeleteEngineConfigOperationsClient);
        }

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EngineVersion GetEngineVersion(GetEngineVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineVersionRequest(ref request, ref callSettings);
            return _callGetEngineVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single EngineVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EngineVersion> GetEngineVersionAsync(GetEngineVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEngineVersionRequest(ref request, ref callSettings);
            return _callGetEngineVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EngineVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersions(ListEngineVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEngineVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEngineVersionsRequest, ListEngineVersionsResponse, EngineVersion>(_callListEngineVersions, request, callSettings);
        }

        /// <summary>
        /// Lists EngineVersions for given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EngineVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> ListEngineVersionsAsync(ListEngineVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEngineVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEngineVersionsRequest, ListEngineVersionsResponse, EngineVersion>(_callListEngineVersions, request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictionResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResults(ListPredictionResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPredictionResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPredictionResultsRequest, ListPredictionResultsResponse, PredictionResult>(_callListPredictionResults, request, callSettings);
        }

        /// <summary>
        /// List PredictionResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> ListPredictionResultsAsync(ListPredictionResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPredictionResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPredictionResultsRequest, ListPredictionResultsResponse, PredictionResult>(_callListPredictionResults, request, callSettings);
        }

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PredictionResult GetPredictionResult(GetPredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPredictionResultRequest(ref request, ref callSettings);
            return _callGetPredictionResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PredictionResult> GetPredictionResultAsync(GetPredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPredictionResultRequest(ref request, ref callSettings);
            return _callGetPredictionResult.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePredictionResult</c>.</summary>
        public override lro::OperationsClient CreatePredictionResultOperationsClient { get; }

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PredictionResult, OperationMetadata> CreatePredictionResult(CreatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<PredictionResult, OperationMetadata>(_callCreatePredictionResult.Sync(request, callSettings), CreatePredictionResultOperationsClient);
        }

        /// <summary>
        /// Create a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PredictionResult, OperationMetadata>> CreatePredictionResultAsync(CreatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<PredictionResult, OperationMetadata>(await _callCreatePredictionResult.Async(request, callSettings).ConfigureAwait(false), CreatePredictionResultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePredictionResult</c>.</summary>
        public override lro::OperationsClient UpdatePredictionResultOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PredictionResult, OperationMetadata> UpdatePredictionResult(UpdatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<PredictionResult, OperationMetadata>(_callUpdatePredictionResult.Sync(request, callSettings), UpdatePredictionResultOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PredictionResult, OperationMetadata>> UpdatePredictionResultAsync(UpdatePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<PredictionResult, OperationMetadata>(await _callUpdatePredictionResult.Async(request, callSettings).ConfigureAwait(false), UpdatePredictionResultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportPredictionResultMetadata</c>.</summary>
        public override lro::OperationsClient ExportPredictionResultMetadataOperationsClient { get; }

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata> ExportPredictionResultMetadata(ExportPredictionResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPredictionResultMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>(_callExportPredictionResultMetadata.Sync(request, callSettings), ExportPredictionResultMetadataOperationsClient);
        }

        /// <summary>
        /// Export governance information for a PredictionResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#prediction-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>> ExportPredictionResultMetadataAsync(ExportPredictionResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPredictionResultMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportPredictionResultMetadataResponse, OperationMetadata>(await _callExportPredictionResultMetadata.Async(request, callSettings).ConfigureAwait(false), ExportPredictionResultMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePredictionResult</c>.</summary>
        public override lro::OperationsClient DeletePredictionResultOperationsClient { get; }

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePredictionResult(DeletePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePredictionResult.Sync(request, callSettings), DeletePredictionResultOperationsClient);
        }

        /// <summary>
        /// Deletes a PredictionResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePredictionResultAsync(DeletePredictionResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePredictionResultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePredictionResult.Async(request, callSettings).ConfigureAwait(false), DeletePredictionResultOperationsClient);
        }

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BacktestResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResults(ListBacktestResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBacktestResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBacktestResultsRequest, ListBacktestResultsResponse, BacktestResult>(_callListBacktestResults, request, callSettings);
        }

        /// <summary>
        /// List BacktestResults.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BacktestResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> ListBacktestResultsAsync(ListBacktestResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBacktestResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBacktestResultsRequest, ListBacktestResultsResponse, BacktestResult>(_callListBacktestResults, request, callSettings);
        }

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BacktestResult GetBacktestResult(GetBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBacktestResultRequest(ref request, ref callSettings);
            return _callGetBacktestResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BacktestResult> GetBacktestResultAsync(GetBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBacktestResultRequest(ref request, ref callSettings);
            return _callGetBacktestResult.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBacktestResult</c>.</summary>
        public override lro::OperationsClient CreateBacktestResultOperationsClient { get; }

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BacktestResult, OperationMetadata> CreateBacktestResult(CreateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<BacktestResult, OperationMetadata>(_callCreateBacktestResult.Sync(request, callSettings), CreateBacktestResultOperationsClient);
        }

        /// <summary>
        /// Create a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BacktestResult, OperationMetadata>> CreateBacktestResultAsync(CreateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<BacktestResult, OperationMetadata>(await _callCreateBacktestResult.Async(request, callSettings).ConfigureAwait(false), CreateBacktestResultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBacktestResult</c>.</summary>
        public override lro::OperationsClient UpdateBacktestResultOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BacktestResult, OperationMetadata> UpdateBacktestResult(UpdateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<BacktestResult, OperationMetadata>(_callUpdateBacktestResult.Sync(request, callSettings), UpdateBacktestResultOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BacktestResult, OperationMetadata>> UpdateBacktestResultAsync(UpdateBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<BacktestResult, OperationMetadata>(await _callUpdateBacktestResult.Async(request, callSettings).ConfigureAwait(false), UpdateBacktestResultOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportBacktestResultMetadata</c>.</summary>
        public override lro::OperationsClient ExportBacktestResultMetadataOperationsClient { get; }

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata> ExportBacktestResultMetadata(ExportBacktestResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBacktestResultMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>(_callExportBacktestResultMetadata.Sync(request, callSettings), ExportBacktestResultMetadataOperationsClient);
        }

        /// <summary>
        /// Export governance information for a BacktestResult resource. For
        /// information on the exported fields, see
        /// [AML output data
        /// model](https://cloud.google.com/financial-services/anti-money-laundering/docs/reference/schemas/aml-output-data-model#backtest-results).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>> ExportBacktestResultMetadataAsync(ExportBacktestResultMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportBacktestResultMetadataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportBacktestResultMetadataResponse, OperationMetadata>(await _callExportBacktestResultMetadata.Async(request, callSettings).ConfigureAwait(false), ExportBacktestResultMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteBacktestResult</c>.</summary>
        public override lro::OperationsClient DeleteBacktestResultOperationsClient { get; }

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteBacktestResult(DeleteBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteBacktestResult.Sync(request, callSettings), DeleteBacktestResultOperationsClient);
        }

        /// <summary>
        /// Deletes a BacktestResult.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteBacktestResultAsync(DeleteBacktestResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBacktestResultRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteBacktestResult.Async(request, callSettings).ConfigureAwait(false), DeleteBacktestResultOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEngineConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEngineVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPredictionResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBacktestResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEngineConfigsResponse : gaxgrpc::IPageResponse<EngineConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EngineConfig> GetEnumerator() => EngineConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEngineVersionsResponse : gaxgrpc::IPageResponse<EngineVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EngineVersion> GetEnumerator() => EngineVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPredictionResultsResponse : gaxgrpc::IPageResponse<PredictionResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PredictionResult> GetEnumerator() => PredictionResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBacktestResultsResponse : gaxgrpc::IPageResponse<BacktestResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BacktestResult> GetEnumerator() => BacktestResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AML
    {
        public partial class AMLClient
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

    public static partial class AML
    {
        public partial class AMLClient
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
