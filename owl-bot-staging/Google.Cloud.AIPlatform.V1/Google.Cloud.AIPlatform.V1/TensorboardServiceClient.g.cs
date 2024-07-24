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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="TensorboardServiceClient"/> instances.</summary>
    public sealed partial class TensorboardServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TensorboardServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TensorboardServiceSettings"/>.</returns>
        public static TensorboardServiceSettings GetDefault() => new TensorboardServiceSettings();

        /// <summary>Constructs a new <see cref="TensorboardServiceSettings"/> object with default settings.</summary>
        public TensorboardServiceSettings()
        {
        }

        private TensorboardServiceSettings(TensorboardServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTensorboardSettings = existing.CreateTensorboardSettings;
            CreateTensorboardOperationsSettings = existing.CreateTensorboardOperationsSettings.Clone();
            GetTensorboardSettings = existing.GetTensorboardSettings;
            UpdateTensorboardSettings = existing.UpdateTensorboardSettings;
            UpdateTensorboardOperationsSettings = existing.UpdateTensorboardOperationsSettings.Clone();
            ListTensorboardsSettings = existing.ListTensorboardsSettings;
            DeleteTensorboardSettings = existing.DeleteTensorboardSettings;
            DeleteTensorboardOperationsSettings = existing.DeleteTensorboardOperationsSettings.Clone();
            ReadTensorboardUsageSettings = existing.ReadTensorboardUsageSettings;
            ReadTensorboardSizeSettings = existing.ReadTensorboardSizeSettings;
            CreateTensorboardExperimentSettings = existing.CreateTensorboardExperimentSettings;
            GetTensorboardExperimentSettings = existing.GetTensorboardExperimentSettings;
            UpdateTensorboardExperimentSettings = existing.UpdateTensorboardExperimentSettings;
            ListTensorboardExperimentsSettings = existing.ListTensorboardExperimentsSettings;
            DeleteTensorboardExperimentSettings = existing.DeleteTensorboardExperimentSettings;
            DeleteTensorboardExperimentOperationsSettings = existing.DeleteTensorboardExperimentOperationsSettings.Clone();
            CreateTensorboardRunSettings = existing.CreateTensorboardRunSettings;
            BatchCreateTensorboardRunsSettings = existing.BatchCreateTensorboardRunsSettings;
            GetTensorboardRunSettings = existing.GetTensorboardRunSettings;
            UpdateTensorboardRunSettings = existing.UpdateTensorboardRunSettings;
            ListTensorboardRunsSettings = existing.ListTensorboardRunsSettings;
            DeleteTensorboardRunSettings = existing.DeleteTensorboardRunSettings;
            DeleteTensorboardRunOperationsSettings = existing.DeleteTensorboardRunOperationsSettings.Clone();
            BatchCreateTensorboardTimeSeriesSettings = existing.BatchCreateTensorboardTimeSeriesSettings;
            CreateTensorboardTimeSeriesSettings = existing.CreateTensorboardTimeSeriesSettings;
            GetTensorboardTimeSeriesSettings = existing.GetTensorboardTimeSeriesSettings;
            UpdateTensorboardTimeSeriesSettings = existing.UpdateTensorboardTimeSeriesSettings;
            ListTensorboardTimeSeriesSettings = existing.ListTensorboardTimeSeriesSettings;
            DeleteTensorboardTimeSeriesSettings = existing.DeleteTensorboardTimeSeriesSettings;
            DeleteTensorboardTimeSeriesOperationsSettings = existing.DeleteTensorboardTimeSeriesOperationsSettings.Clone();
            BatchReadTensorboardTimeSeriesDataSettings = existing.BatchReadTensorboardTimeSeriesDataSettings;
            ReadTensorboardTimeSeriesDataSettings = existing.ReadTensorboardTimeSeriesDataSettings;
            ReadTensorboardBlobDataSettings = existing.ReadTensorboardBlobDataSettings;
            WriteTensorboardExperimentDataSettings = existing.WriteTensorboardExperimentDataSettings;
            WriteTensorboardRunDataSettings = existing.WriteTensorboardRunDataSettings;
            ExportTensorboardTimeSeriesDataSettings = existing.ExportTensorboardTimeSeriesDataSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(TensorboardServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.CreateTensorboard</c> and <c>TensorboardServiceClient.CreateTensorboardAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTensorboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.CreateTensorboard</c> and
        /// <c>TensorboardServiceClient.CreateTensorboardAsync</c>.
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
        public lro::OperationsSettings CreateTensorboardOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.GetTensorboard</c> and <c>TensorboardServiceClient.GetTensorboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTensorboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.UpdateTensorboard</c> and <c>TensorboardServiceClient.UpdateTensorboardAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTensorboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.UpdateTensorboard</c> and
        /// <c>TensorboardServiceClient.UpdateTensorboardAsync</c>.
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
        public lro::OperationsSettings UpdateTensorboardOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ListTensorboards</c> and <c>TensorboardServiceClient.ListTensorboardsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTensorboardsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.DeleteTensorboard</c> and <c>TensorboardServiceClient.DeleteTensorboardAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTensorboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.DeleteTensorboard</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardAsync</c>.
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
        public lro::OperationsSettings DeleteTensorboardOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ReadTensorboardUsage</c> and
        /// <c>TensorboardServiceClient.ReadTensorboardUsageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadTensorboardUsageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ReadTensorboardSize</c> and <c>TensorboardServiceClient.ReadTensorboardSizeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadTensorboardSizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.CreateTensorboardExperiment</c> and
        /// <c>TensorboardServiceClient.CreateTensorboardExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTensorboardExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.GetTensorboardExperiment</c> and
        /// <c>TensorboardServiceClient.GetTensorboardExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTensorboardExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.UpdateTensorboardExperiment</c> and
        /// <c>TensorboardServiceClient.UpdateTensorboardExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTensorboardExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ListTensorboardExperiments</c> and
        /// <c>TensorboardServiceClient.ListTensorboardExperimentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTensorboardExperimentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.DeleteTensorboardExperiment</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTensorboardExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.DeleteTensorboardExperiment</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardExperimentAsync</c>.
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
        public lro::OperationsSettings DeleteTensorboardExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.CreateTensorboardRun</c> and
        /// <c>TensorboardServiceClient.CreateTensorboardRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTensorboardRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.BatchCreateTensorboardRuns</c> and
        /// <c>TensorboardServiceClient.BatchCreateTensorboardRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTensorboardRunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.GetTensorboardRun</c> and <c>TensorboardServiceClient.GetTensorboardRunAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTensorboardRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.UpdateTensorboardRun</c> and
        /// <c>TensorboardServiceClient.UpdateTensorboardRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTensorboardRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ListTensorboardRuns</c> and <c>TensorboardServiceClient.ListTensorboardRunsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTensorboardRunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.DeleteTensorboardRun</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTensorboardRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.DeleteTensorboardRun</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardRunAsync</c>.
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
        public lro::OperationsSettings DeleteTensorboardRunOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.BatchCreateTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.BatchCreateTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.CreateTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.CreateTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.GetTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.GetTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.UpdateTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.UpdateTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ListTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.ListTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.DeleteTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTensorboardTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>TensorboardServiceClient.DeleteTensorboardTimeSeries</c> and
        /// <c>TensorboardServiceClient.DeleteTensorboardTimeSeriesAsync</c>.
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
        public lro::OperationsSettings DeleteTensorboardTimeSeriesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.BatchReadTensorboardTimeSeriesData</c> and
        /// <c>TensorboardServiceClient.BatchReadTensorboardTimeSeriesDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchReadTensorboardTimeSeriesDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ReadTensorboardTimeSeriesData</c> and
        /// <c>TensorboardServiceClient.ReadTensorboardTimeSeriesDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadTensorboardTimeSeriesDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ReadTensorboardBlobData</c> and
        /// <c>TensorboardServiceClient.ReadTensorboardBlobDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadTensorboardBlobDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.WriteTensorboardExperimentData</c> and
        /// <c>TensorboardServiceClient.WriteTensorboardExperimentDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteTensorboardExperimentDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.WriteTensorboardRunData</c> and
        /// <c>TensorboardServiceClient.WriteTensorboardRunDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteTensorboardRunDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TensorboardServiceClient.ExportTensorboardTimeSeriesData</c> and
        /// <c>TensorboardServiceClient.ExportTensorboardTimeSeriesDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportTensorboardTimeSeriesDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TensorboardServiceSettings"/> object.</returns>
        public TensorboardServiceSettings Clone() => new TensorboardServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TensorboardServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TensorboardServiceClientBuilder : gaxgrpc::ClientBuilderBase<TensorboardServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TensorboardServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TensorboardServiceClientBuilder() : base(TensorboardServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TensorboardServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TensorboardServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TensorboardServiceClient Build()
        {
            TensorboardServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TensorboardServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TensorboardServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TensorboardServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TensorboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TensorboardServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TensorboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TensorboardServiceClient.ChannelPool;
    }

    /// <summary>TensorboardService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// TensorboardService
    /// </remarks>
    public abstract partial class TensorboardServiceClient
    {
        /// <summary>
        /// The default endpoint for the TensorboardService service, which is a host of "aiplatform.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default TensorboardService scopes.</summary>
        /// <remarks>
        /// The default TensorboardService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TensorboardService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TensorboardServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TensorboardServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TensorboardServiceClient"/>.</returns>
        public static stt::Task<TensorboardServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TensorboardServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TensorboardServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TensorboardServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="TensorboardServiceClient"/>.</returns>
        public static TensorboardServiceClient Create() => new TensorboardServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TensorboardServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TensorboardServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TensorboardServiceClient"/>.</returns>
        internal static TensorboardServiceClient Create(grpccore::CallInvoker callInvoker, TensorboardServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TensorboardService.TensorboardServiceClient grpcClient = new TensorboardService.TensorboardServiceClient(callInvoker);
            return new TensorboardServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TensorboardService client</summary>
        public virtual TensorboardService.TensorboardServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Tensorboard, CreateTensorboardOperationMetadata> CreateTensorboard(CreateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(CreateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(CreateTensorboardRequest request, st::CancellationToken cancellationToken) =>
            CreateTensorboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTensorboard</c>.</summary>
        public virtual lro::OperationsClient CreateTensorboardOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTensorboard</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Tensorboard, CreateTensorboardOperationMetadata> PollOnceCreateTensorboard(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTensorboard</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> PollOnceCreateTensorboardAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Tensorboard, CreateTensorboardOperationMetadata> CreateTensorboard(string parent, Tensorboard tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboard(new CreateTensorboardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(string parent, Tensorboard tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardAsync(new CreateTensorboardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(string parent, Tensorboard tensorboard, st::CancellationToken cancellationToken) =>
            CreateTensorboardAsync(parent, tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Tensorboard, CreateTensorboardOperationMetadata> CreateTensorboard(TensorboardName parent, Tensorboard tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboard(new CreateTensorboardRequest
            {
                ParentAsTensorboardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(TensorboardName parent, Tensorboard tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardAsync(new CreateTensorboardRequest
            {
                ParentAsTensorboardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Tensorboard in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="tensorboard">
        /// Required. The Tensorboard to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(TensorboardName parent, Tensorboard tensorboard, st::CancellationToken cancellationToken) =>
            CreateTensorboardAsync(parent, tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tensorboard GetTensorboard(GetTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(GetTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(GetTensorboardRequest request, st::CancellationToken cancellationToken) =>
            GetTensorboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tensorboard GetTensorboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboard(new GetTensorboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardAsync(new GetTensorboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(string name, st::CancellationToken cancellationToken) =>
            GetTensorboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Tensorboard GetTensorboard(TensorboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboard(new GetTensorboardRequest
            {
                TensorboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(TensorboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardAsync(new GetTensorboardRequest
            {
                TensorboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Tensorboard> GetTensorboardAsync(TensorboardName name, st::CancellationToken cancellationToken) =>
            GetTensorboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata> UpdateTensorboard(UpdateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> UpdateTensorboardAsync(UpdateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> UpdateTensorboardAsync(UpdateTensorboardRequest request, st::CancellationToken cancellationToken) =>
            UpdateTensorboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTensorboard</c>.</summary>
        public virtual lro::OperationsClient UpdateTensorboardOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTensorboard</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata> PollOnceUpdateTensorboard(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTensorboard</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> PollOnceUpdateTensorboardAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The Tensorboard's `name` field is used to identify the
        /// Tensorboard to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Tensorboard resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata> UpdateTensorboard(Tensorboard tensorboard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboard(new UpdateTensorboardRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The Tensorboard's `name` field is used to identify the
        /// Tensorboard to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Tensorboard resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> UpdateTensorboardAsync(Tensorboard tensorboard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardAsync(new UpdateTensorboardRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Tensorboard = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The Tensorboard's `name` field is used to identify the
        /// Tensorboard to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Tensorboard resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> UpdateTensorboardAsync(Tensorboard tensorboard, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTensorboardAsync(tensorboard, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboards(ListTensorboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboardsAsync(ListTensorboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Tensorboards.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboards(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardsRequest request = new ListTensorboardsRequest
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
            return ListTensorboards(request, callSettings);
        }

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Tensorboards.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboardsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardsRequest request = new ListTensorboardsRequest
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
            return ListTensorboardsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Tensorboards.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboards(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardsRequest request = new ListTensorboardsRequest
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
            return ListTensorboards(request, callSettings);
        }

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list Tensorboards.
        /// Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Tensorboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboardsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardsRequest request = new ListTensorboardsRequest
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
            return ListTensorboardsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboard(DeleteTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(DeleteTensorboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(DeleteTensorboardRequest request, st::CancellationToken cancellationToken) =>
            DeleteTensorboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTensorboard</c>.</summary>
        public virtual lro::OperationsClient DeleteTensorboardOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTensorboard</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteTensorboard(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboard</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteTensorboardAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboard(new DeleteTensorboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardAsync(new DeleteTensorboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboard(TensorboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboard(new DeleteTensorboardRequest
            {
                TensorboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(TensorboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardAsync(new DeleteTensorboardRequest
            {
                TensorboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Tensorboard to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(TensorboardName name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardUsageResponse ReadTensorboardUsage(ReadTensorboardUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(ReadTensorboardUsageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(ReadTensorboardUsageRequest request, st::CancellationToken cancellationToken) =>
            ReadTensorboardUsageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardUsageResponse ReadTensorboardUsage(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardUsage(new ReadTensorboardUsageRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardUsageAsync(new ReadTensorboardUsageRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(string tensorboard, st::CancellationToken cancellationToken) =>
            ReadTensorboardUsageAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardUsageResponse ReadTensorboardUsage(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardUsage(new ReadTensorboardUsageRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardUsageAsync(new ReadTensorboardUsageRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(TensorboardName tensorboard, st::CancellationToken cancellationToken) =>
            ReadTensorboardUsageAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardSizeResponse ReadTensorboardSize(ReadTensorboardSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(ReadTensorboardSizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(ReadTensorboardSizeRequest request, st::CancellationToken cancellationToken) =>
            ReadTensorboardSizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardSizeResponse ReadTensorboardSize(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardSize(new ReadTensorboardSizeRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardSizeAsync(new ReadTensorboardSizeRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(string tensorboard, st::CancellationToken cancellationToken) =>
            ReadTensorboardSizeAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardSizeResponse ReadTensorboardSize(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardSize(new ReadTensorboardSizeRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardSizeAsync(new ReadTensorboardSizeRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The name of the Tensorboard resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(TensorboardName tensorboard, st::CancellationToken cancellationToken) =>
            ReadTensorboardSizeAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment CreateTensorboardExperiment(CreateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(CreateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(CreateTensorboardExperimentRequest request, st::CancellationToken cancellationToken) =>
            CreateTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment CreateTensorboardExperiment(string parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardExperiment(new CreateTensorboardExperimentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardExperiment = tensorboardExperiment,
                TensorboardExperimentId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperimentId, nameof(tensorboardExperimentId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(string parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardExperimentAsync(new CreateTensorboardExperimentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardExperiment = tensorboardExperiment,
                TensorboardExperimentId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperimentId, nameof(tensorboardExperimentId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(string parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, st::CancellationToken cancellationToken) =>
            CreateTensorboardExperimentAsync(parent, tensorboardExperiment, tensorboardExperimentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment CreateTensorboardExperiment(TensorboardExperimentName parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardExperiment(new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardExperiment = tensorboardExperiment,
                TensorboardExperimentId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperimentId, nameof(tensorboardExperimentId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(TensorboardExperimentName parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardExperimentAsync(new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardExperiment = tensorboardExperiment,
                TensorboardExperimentId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperimentId, nameof(tensorboardExperimentId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to create the
        /// TensorboardExperiment in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
        /// </param>
        /// <param name="tensorboardExperiment">
        /// The TensorboardExperiment to create.
        /// </param>
        /// <param name="tensorboardExperimentId">
        /// Required. The ID to use for the Tensorboard experiment, which becomes the
        /// final component of the Tensorboard experiment's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(TensorboardExperimentName parent, TensorboardExperiment tensorboardExperiment, string tensorboardExperimentId, st::CancellationToken cancellationToken) =>
            CreateTensorboardExperimentAsync(parent, tensorboardExperiment, tensorboardExperimentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment GetTensorboardExperiment(GetTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(GetTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(GetTensorboardExperimentRequest request, st::CancellationToken cancellationToken) =>
            GetTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment GetTensorboardExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardExperiment(new GetTensorboardExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardExperimentAsync(new GetTensorboardExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            GetTensorboardExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment GetTensorboardExperiment(TensorboardExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardExperiment(new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(TensorboardExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardExperimentAsync(new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(TensorboardExperimentName name, st::CancellationToken cancellationToken) =>
            GetTensorboardExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment UpdateTensorboardExperiment(UpdateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> UpdateTensorboardExperimentAsync(UpdateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> UpdateTensorboardExperimentAsync(UpdateTensorboardExperimentRequest request, st::CancellationToken cancellationToken) =>
            UpdateTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The TensorboardExperiment's `name` field is used to identify the
        /// TensorboardExperiment to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardExperiment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardExperiment UpdateTensorboardExperiment(TensorboardExperiment tensorboardExperiment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardExperiment(new UpdateTensorboardExperimentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardExperiment = gax::GaxPreconditions.CheckNotNull(tensorboardExperiment, nameof(tensorboardExperiment)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The TensorboardExperiment's `name` field is used to identify the
        /// TensorboardExperiment to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardExperiment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> UpdateTensorboardExperimentAsync(TensorboardExperiment tensorboardExperiment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardExperimentAsync(new UpdateTensorboardExperimentRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardExperiment = gax::GaxPreconditions.CheckNotNull(tensorboardExperiment, nameof(tensorboardExperiment)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The TensorboardExperiment's `name` field is used to identify the
        /// TensorboardExperiment to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardExperiment resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardExperiment> UpdateTensorboardExperimentAsync(TensorboardExperiment tensorboardExperiment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTensorboardExperimentAsync(tensorboardExperiment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperiments(ListTensorboardExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperimentsAsync(ListTensorboardExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to list
        /// TensorboardExperiments. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperiments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
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
            return ListTensorboardExperiments(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to list
        /// TensorboardExperiments. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperimentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
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
            return ListTensorboardExperimentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to list
        /// TensorboardExperiments. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperiments(TensorboardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
            {
                ParentAsTensorboardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardExperiments(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Tensorboard to list
        /// TensorboardExperiments. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperimentsAsync(TensorboardName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
            {
                ParentAsTensorboardName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardExperimentsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardExperiment(DeleteTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(DeleteTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(DeleteTensorboardExperimentRequest request, st::CancellationToken cancellationToken) =>
            DeleteTensorboardExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTensorboardExperiment</c>.</summary>
        public virtual lro::OperationsClient DeleteTensorboardExperimentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboardExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteTensorboardExperiment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardExperimentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboardExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteTensorboardExperimentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardExperimentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardExperiment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardExperiment(new DeleteTensorboardExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardExperimentAsync(new DeleteTensorboardExperimentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardExperiment(TensorboardExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardExperiment(new DeleteTensorboardExperimentRequest
            {
                TensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(TensorboardExperimentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardExperimentAsync(new DeleteTensorboardExperimentRequest
            {
                TensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardExperiment to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(TensorboardExperimentName name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardExperimentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun CreateTensorboardRun(CreateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(CreateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(CreateTensorboardRunRequest request, st::CancellationToken cancellationToken) =>
            CreateTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun CreateTensorboardRun(string parent, TensorboardRun tensorboardRun, string tensorboardRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardRun(new CreateTensorboardRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TensorboardRunId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRunId, nameof(tensorboardRunId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(string parent, TensorboardRun tensorboardRun, string tensorboardRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardRunAsync(new CreateTensorboardRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TensorboardRunId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRunId, nameof(tensorboardRunId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(string parent, TensorboardRun tensorboardRun, string tensorboardRunId, st::CancellationToken cancellationToken) =>
            CreateTensorboardRunAsync(parent, tensorboardRun, tensorboardRunId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun CreateTensorboardRun(TensorboardRunName parent, TensorboardRun tensorboardRun, string tensorboardRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardRun(new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TensorboardRunId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRunId, nameof(tensorboardRunId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(TensorboardRunName parent, TensorboardRun tensorboardRun, string tensorboardRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardRunAsync(new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TensorboardRunId = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRunId, nameof(tensorboardRunId)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRun in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun to create.
        /// </param>
        /// <param name="tensorboardRunId">
        /// Required. The ID to use for the Tensorboard run, which becomes the final
        /// component of the Tensorboard run's resource name.
        /// 
        /// This value should be 1-128 characters, and valid characters
        /// are `/[a-z][0-9]-/`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> CreateTensorboardRunAsync(TensorboardRunName parent, TensorboardRun tensorboardRun, string tensorboardRunId, st::CancellationToken cancellationToken) =>
            CreateTensorboardRunAsync(parent, tensorboardRun, tensorboardRunId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardRunsResponse BatchCreateTensorboardRuns(BatchCreateTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(BatchCreateTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(BatchCreateTensorboardRunsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardRunsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardRunsResponse BatchCreateTensorboardRuns(string parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardRuns(new BatchCreateTensorboardRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(string parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardRunsAsync(new BatchCreateTensorboardRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(string parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardRunsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardRunsResponse BatchCreateTensorboardRuns(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardRuns(new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardRunsAsync(new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardRuns in. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The parent field in the CreateTensorboardRunRequest messages must match
        /// this field.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardRuns to create.
        /// A maximum of 1000 TensorboardRuns can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardRunRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardRunsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun GetTensorboardRun(GetTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(GetTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(GetTensorboardRunRequest request, st::CancellationToken cancellationToken) =>
            GetTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun GetTensorboardRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardRun(new GetTensorboardRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardRunAsync(new GetTensorboardRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetTensorboardRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun GetTensorboardRun(TensorboardRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardRun(new GetTensorboardRunRequest
            {
                TensorboardRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(TensorboardRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardRunAsync(new GetTensorboardRunRequest
            {
                TensorboardRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> GetTensorboardRunAsync(TensorboardRunName name, st::CancellationToken cancellationToken) =>
            GetTensorboardRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun UpdateTensorboardRun(UpdateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> UpdateTensorboardRunAsync(UpdateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> UpdateTensorboardRunAsync(UpdateTensorboardRunRequest request, st::CancellationToken cancellationToken) =>
            UpdateTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun's `name` field is used to identify the
        /// TensorboardRun to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardRun resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardRun UpdateTensorboardRun(TensorboardRun tensorboardRun, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardRun(new UpdateTensorboardRunRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun's `name` field is used to identify the
        /// TensorboardRun to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardRun resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> UpdateTensorboardRunAsync(TensorboardRun tensorboardRun, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardRunAsync(new UpdateTensorboardRunRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardRun = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The TensorboardRun's `name` field is used to identify the
        /// TensorboardRun to be updated. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardRun resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardRun> UpdateTensorboardRunAsync(TensorboardRun tensorboardRun, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTensorboardRunAsync(tensorboardRun, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRuns(ListTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRunsAsync(ListTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to list
        /// TensorboardRuns. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
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
            return ListTensorboardRuns(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to list
        /// TensorboardRuns. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
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
            return ListTensorboardRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to list
        /// TensorboardRuns. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRuns(TensorboardExperimentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardRuns(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to list
        /// TensorboardRuns. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRunsAsync(TensorboardExperimentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardRun(DeleteTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(DeleteTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(DeleteTensorboardRunRequest request, st::CancellationToken cancellationToken) =>
            DeleteTensorboardRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTensorboardRun</c>.</summary>
        public virtual lro::OperationsClient DeleteTensorboardRunOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTensorboardRun</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteTensorboardRun(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardRunOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboardRun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteTensorboardRunAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardRunOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardRun(new DeleteTensorboardRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardRunAsync(new DeleteTensorboardRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardRun(TensorboardRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardRun(new DeleteTensorboardRunRequest
            {
                TensorboardRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(TensorboardRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardRunAsync(new DeleteTensorboardRunRequest
            {
                TensorboardRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardRun to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(TensorboardRunName name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardTimeSeriesResponse BatchCreateTensorboardTimeSeries(BatchCreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(BatchCreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(BatchCreateTensorboardTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardTimeSeriesResponse BatchCreateTensorboardTimeSeries(string parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardTimeSeries(new BatchCreateTensorboardTimeSeriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(string parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardTimeSeriesAsync(new BatchCreateTensorboardTimeSeriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(string parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardTimeSeriesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTensorboardTimeSeriesResponse BatchCreateTensorboardTimeSeries(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardTimeSeries(new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateTensorboardTimeSeriesAsync(new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardExperiment to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// The TensorboardRuns referenced by the parent fields in the
        /// CreateTensorboardTimeSeriesRequest messages must be sub resources of this
        /// TensorboardExperiment.
        /// </param>
        /// <param name="requests">
        /// Required. The request message specifying the TensorboardTimeSeries to
        /// create. A maximum of 1000 TensorboardTimeSeries can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(TensorboardExperimentName parent, scg::IEnumerable<CreateTensorboardTimeSeriesRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateTensorboardTimeSeriesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries CreateTensorboardTimeSeries(CreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(CreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(CreateTensorboardTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            CreateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries CreateTensorboardTimeSeries(string parent, TensorboardTimeSeries tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardTimeSeries(new CreateTensorboardTimeSeriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(string parent, TensorboardTimeSeries tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardTimeSeriesAsync(new CreateTensorboardTimeSeriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(string parent, TensorboardTimeSeries tensorboardTimeSeries, st::CancellationToken cancellationToken) =>
            CreateTensorboardTimeSeriesAsync(parent, tensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries CreateTensorboardTimeSeries(TensorboardTimeSeriesName parent, TensorboardTimeSeries tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardTimeSeries(new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(TensorboardTimeSeriesName parent, TensorboardTimeSeries tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTensorboardTimeSeriesAsync(new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to create the
        /// TensorboardTimeSeries in.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(TensorboardTimeSeriesName parent, TensorboardTimeSeries tensorboardTimeSeries, st::CancellationToken cancellationToken) =>
            CreateTensorboardTimeSeriesAsync(parent, tensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries GetTensorboardTimeSeries(GetTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(GetTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(GetTensorboardTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            GetTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries GetTensorboardTimeSeries(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardTimeSeries(new GetTensorboardTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardTimeSeriesAsync(new GetTensorboardTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(string name, st::CancellationToken cancellationToken) =>
            GetTensorboardTimeSeriesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries GetTensorboardTimeSeries(TensorboardTimeSeriesName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardTimeSeries(new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(TensorboardTimeSeriesName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTensorboardTimeSeriesAsync(new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries resource.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(TensorboardTimeSeriesName name, st::CancellationToken cancellationToken) =>
            GetTensorboardTimeSeriesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries UpdateTensorboardTimeSeries(UpdateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> UpdateTensorboardTimeSeriesAsync(UpdateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> UpdateTensorboardTimeSeriesAsync(UpdateTensorboardTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            UpdateTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries' `name` field is used to identify the
        /// TensorboardTimeSeries to be updated.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardTimeSeries resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TensorboardTimeSeries UpdateTensorboardTimeSeries(TensorboardTimeSeries tensorboardTimeSeries, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardTimeSeries(new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries' `name` field is used to identify the
        /// TensorboardTimeSeries to be updated.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardTimeSeries resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> UpdateTensorboardTimeSeriesAsync(TensorboardTimeSeries tensorboardTimeSeries, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTensorboardTimeSeriesAsync(new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The TensorboardTimeSeries' `name` field is used to identify the
        /// TensorboardTimeSeries to be updated.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// TensorboardTimeSeries resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it's in the mask. If the
        /// user does not provide a mask then all fields are overwritten if new
        /// values are specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TensorboardTimeSeries> UpdateTensorboardTimeSeriesAsync(TensorboardTimeSeries tensorboardTimeSeries, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTensorboardTimeSeriesAsync(tensorboardTimeSeries, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeries(ListTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeriesAsync(ListTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to list
        /// TensorboardTimeSeries. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
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
            return ListTensorboardTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to list
        /// TensorboardTimeSeries. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
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
            return ListTensorboardTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to list
        /// TensorboardTimeSeries. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
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
        /// <returns>A pageable sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeries(TensorboardRunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TensorboardRun to list
        /// TensorboardTimeSeries. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeriesAsync(TensorboardRunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTensorboardTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardTimeSeries(DeleteTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(DeleteTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(DeleteTensorboardTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            DeleteTensorboardTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTensorboardTimeSeries</c>.</summary>
        public virtual lro::OperationsClient DeleteTensorboardTimeSeriesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboardTimeSeries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteTensorboardTimeSeries(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardTimeSeriesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTensorboardTimeSeries</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteTensorboardTimeSeriesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTensorboardTimeSeriesOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardTimeSeries(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardTimeSeries(new DeleteTensorboardTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardTimeSeriesAsync(new DeleteTensorboardTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardTimeSeriesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardTimeSeries(TensorboardTimeSeriesName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardTimeSeries(new DeleteTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(TensorboardTimeSeriesName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTensorboardTimeSeriesAsync(new DeleteTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TensorboardTimeSeries to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(TensorboardTimeSeriesName name, st::CancellationToken cancellationToken) =>
            DeleteTensorboardTimeSeriesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReadTensorboardTimeSeriesDataResponse BatchReadTensorboardTimeSeriesData(BatchReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(BatchReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(BatchReadTensorboardTimeSeriesDataRequest request, st::CancellationToken cancellationToken) =>
            BatchReadTensorboardTimeSeriesDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReadTensorboardTimeSeriesDataResponse BatchReadTensorboardTimeSeriesData(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadTensorboardTimeSeriesData(new BatchReadTensorboardTimeSeriesDataRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(string tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadTensorboardTimeSeriesDataAsync(new BatchReadTensorboardTimeSeriesDataRequest
            {
                Tensorboard = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(string tensorboard, st::CancellationToken cancellationToken) =>
            BatchReadTensorboardTimeSeriesDataAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchReadTensorboardTimeSeriesDataResponse BatchReadTensorboardTimeSeriesData(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadTensorboardTimeSeriesData(new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(TensorboardName tensorboard, gaxgrpc::CallSettings callSettings = null) =>
            BatchReadTensorboardTimeSeriesDataAsync(new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = gax::GaxPreconditions.CheckNotNull(tensorboard, nameof(tensorboard)),
            }, callSettings);

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="tensorboard">
        /// Required. The resource name of the Tensorboard containing
        /// TensorboardTimeSeries to read data from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}`.
        /// The TensorboardTimeSeries referenced by
        /// [time_series][google.cloud.aiplatform.v1.BatchReadTensorboardTimeSeriesDataRequest.time_series]
        /// must be sub resources of this Tensorboard.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(TensorboardName tensorboard, st::CancellationToken cancellationToken) =>
            BatchReadTensorboardTimeSeriesDataAsync(tensorboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardTimeSeriesDataResponse ReadTensorboardTimeSeriesData(ReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(ReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(ReadTensorboardTimeSeriesDataRequest request, st::CancellationToken cancellationToken) =>
            ReadTensorboardTimeSeriesDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardTimeSeriesDataResponse ReadTensorboardTimeSeriesData(string tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardTimeSeriesData(new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(string tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardTimeSeriesDataAsync(new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(string tensorboardTimeSeries, st::CancellationToken cancellationToken) =>
            ReadTensorboardTimeSeriesDataAsync(tensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadTensorboardTimeSeriesDataResponse ReadTensorboardTimeSeriesData(TensorboardTimeSeriesName tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardTimeSeriesData(new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName tensorboardTimeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardTimeSeriesDataAsync(new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            }, callSettings);

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to read data from.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName tensorboardTimeSeries, st::CancellationToken cancellationToken) =>
            ReadTensorboardTimeSeriesDataAsync(tensorboardTimeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ReadTensorboardBlobData(ReadTensorboardBlobDataRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadTensorboardBlobDataStream : gaxgrpc::ServerStreamingBase<ReadTensorboardBlobDataResponse>
        {
        }

        /// <summary>
        /// Gets bytes of TensorboardBlobs.
        /// This is to allow reading blob data stored in consumer project's Cloud
        /// Storage bucket without users having to obtain Cloud Storage access
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadTensorboardBlobDataStream ReadTensorboardBlobData(ReadTensorboardBlobDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets bytes of TensorboardBlobs.
        /// This is to allow reading blob data stored in consumer project's Cloud
        /// Storage bucket without users having to obtain Cloud Storage access
        /// permission.
        /// </summary>
        /// <param name="timeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to list Blobs.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadTensorboardBlobDataStream ReadTensorboardBlobData(string timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardBlobData(new ReadTensorboardBlobDataRequest
            {
                TimeSeries = gax::GaxPreconditions.CheckNotNullOrEmpty(timeSeries, nameof(timeSeries)),
            }, callSettings);

        /// <summary>
        /// Gets bytes of TensorboardBlobs.
        /// This is to allow reading blob data stored in consumer project's Cloud
        /// Storage bucket without users having to obtain Cloud Storage access
        /// permission.
        /// </summary>
        /// <param name="timeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to list Blobs.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadTensorboardBlobDataStream ReadTensorboardBlobData(TensorboardTimeSeriesName timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            ReadTensorboardBlobData(new ReadTensorboardBlobDataRequest
            {
                TimeSeriesAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
            }, callSettings);

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardExperimentDataResponse WriteTensorboardExperimentData(WriteTensorboardExperimentDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(WriteTensorboardExperimentDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(WriteTensorboardExperimentDataRequest request, st::CancellationToken cancellationToken) =>
            WriteTensorboardExperimentDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardExperimentDataResponse WriteTensorboardExperimentData(string tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardExperimentData(new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperiment, nameof(tensorboardExperiment)),
                WriteRunDataRequests =
                {
                    gax::GaxPreconditions.CheckNotNull(writeRunDataRequests, nameof(writeRunDataRequests)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(string tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardExperimentDataAsync(new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardExperiment, nameof(tensorboardExperiment)),
                WriteRunDataRequests =
                {
                    gax::GaxPreconditions.CheckNotNull(writeRunDataRequests, nameof(writeRunDataRequests)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(string tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, st::CancellationToken cancellationToken) =>
            WriteTensorboardExperimentDataAsync(tensorboardExperiment, writeRunDataRequests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardExperimentDataResponse WriteTensorboardExperimentData(TensorboardExperimentName tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardExperimentData(new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(tensorboardExperiment, nameof(tensorboardExperiment)),
                WriteRunDataRequests =
                {
                    gax::GaxPreconditions.CheckNotNull(writeRunDataRequests, nameof(writeRunDataRequests)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(TensorboardExperimentName tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardExperimentDataAsync(new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = gax::GaxPreconditions.CheckNotNull(tensorboardExperiment, nameof(tensorboardExperiment)),
                WriteRunDataRequests =
                {
                    gax::GaxPreconditions.CheckNotNull(writeRunDataRequests, nameof(writeRunDataRequests)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardExperiment">
        /// Required. The resource name of the TensorboardExperiment to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}`
        /// </param>
        /// <param name="writeRunDataRequests">
        /// Required. Requests containing per-run TensorboardTimeSeries data to write.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(TensorboardExperimentName tensorboardExperiment, scg::IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests, st::CancellationToken cancellationToken) =>
            WriteTensorboardExperimentDataAsync(tensorboardExperiment, writeRunDataRequests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardRunDataResponse WriteTensorboardRunData(WriteTensorboardRunDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(WriteTensorboardRunDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(WriteTensorboardRunDataRequest request, st::CancellationToken cancellationToken) =>
            WriteTensorboardRunDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardRunDataResponse WriteTensorboardRunData(string tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardRunData(new WriteTensorboardRunDataRequest
            {
                TensorboardRun = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRun, nameof(tensorboardRun)),
                TimeSeriesData =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeriesData, nameof(timeSeriesData)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(string tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardRunDataAsync(new WriteTensorboardRunDataRequest
            {
                TensorboardRun = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardRun, nameof(tensorboardRun)),
                TimeSeriesData =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeriesData, nameof(timeSeriesData)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(string tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, st::CancellationToken cancellationToken) =>
            WriteTensorboardRunDataAsync(tensorboardRun, timeSeriesData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteTensorboardRunDataResponse WriteTensorboardRunData(TensorboardRunName tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardRunData(new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TimeSeriesData =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeriesData, nameof(timeSeriesData)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(TensorboardRunName tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, gaxgrpc::CallSettings callSettings = null) =>
            WriteTensorboardRunDataAsync(new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = gax::GaxPreconditions.CheckNotNull(tensorboardRun, nameof(tensorboardRun)),
                TimeSeriesData =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeriesData, nameof(timeSeriesData)),
                },
            }, callSettings);

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="tensorboardRun">
        /// Required. The resource name of the TensorboardRun to write data to.
        /// Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}`
        /// </param>
        /// <param name="timeSeriesData">
        /// Required. The TensorboardTimeSeries data to write.
        /// Values with in a time series are indexed by their step value.
        /// Repeated writes to the same step will overwrite the existing value for that
        /// step.
        /// The upper limit of data points per write request is 5000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(TensorboardRunName tensorboardRun, scg::IEnumerable<TimeSeriesData> timeSeriesData, st::CancellationToken cancellationToken) =>
            WriteTensorboardRunDataAsync(tensorboardRun, timeSeriesData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesData(ExportTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesDataAsync(ExportTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to export data
        /// from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
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
        /// <returns>A pageable sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesData(string tensorboardTimeSeries, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ExportTensorboardTimeSeriesData(request, callSettings);
        }

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to export data
        /// from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesDataAsync(string tensorboardTimeSeries, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeries = gax::GaxPreconditions.CheckNotNullOrEmpty(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ExportTensorboardTimeSeriesDataAsync(request, callSettings);
        }

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to export data
        /// from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
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
        /// <returns>A pageable sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesData(TensorboardTimeSeriesName tensorboardTimeSeries, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ExportTensorboardTimeSeriesData(request, callSettings);
        }

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="tensorboardTimeSeries">
        /// Required. The resource name of the TensorboardTimeSeries to export data
        /// from. Format:
        /// `projects/{project}/locations/{location}/tensorboards/{tensorboard}/experiments/{experiment}/runs/{run}/timeSeries/{time_series}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName tensorboardTimeSeries, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = gax::GaxPreconditions.CheckNotNull(tensorboardTimeSeries, nameof(tensorboardTimeSeries)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ExportTensorboardTimeSeriesDataAsync(request, callSettings);
        }
    }

    /// <summary>TensorboardService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// TensorboardService
    /// </remarks>
    public sealed partial class TensorboardServiceClientImpl : TensorboardServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTensorboardRequest, lro::Operation> _callCreateTensorboard;

        private readonly gaxgrpc::ApiCall<GetTensorboardRequest, Tensorboard> _callGetTensorboard;

        private readonly gaxgrpc::ApiCall<UpdateTensorboardRequest, lro::Operation> _callUpdateTensorboard;

        private readonly gaxgrpc::ApiCall<ListTensorboardsRequest, ListTensorboardsResponse> _callListTensorboards;

        private readonly gaxgrpc::ApiCall<DeleteTensorboardRequest, lro::Operation> _callDeleteTensorboard;

        private readonly gaxgrpc::ApiCall<ReadTensorboardUsageRequest, ReadTensorboardUsageResponse> _callReadTensorboardUsage;

        private readonly gaxgrpc::ApiCall<ReadTensorboardSizeRequest, ReadTensorboardSizeResponse> _callReadTensorboardSize;

        private readonly gaxgrpc::ApiCall<CreateTensorboardExperimentRequest, TensorboardExperiment> _callCreateTensorboardExperiment;

        private readonly gaxgrpc::ApiCall<GetTensorboardExperimentRequest, TensorboardExperiment> _callGetTensorboardExperiment;

        private readonly gaxgrpc::ApiCall<UpdateTensorboardExperimentRequest, TensorboardExperiment> _callUpdateTensorboardExperiment;

        private readonly gaxgrpc::ApiCall<ListTensorboardExperimentsRequest, ListTensorboardExperimentsResponse> _callListTensorboardExperiments;

        private readonly gaxgrpc::ApiCall<DeleteTensorboardExperimentRequest, lro::Operation> _callDeleteTensorboardExperiment;

        private readonly gaxgrpc::ApiCall<CreateTensorboardRunRequest, TensorboardRun> _callCreateTensorboardRun;

        private readonly gaxgrpc::ApiCall<BatchCreateTensorboardRunsRequest, BatchCreateTensorboardRunsResponse> _callBatchCreateTensorboardRuns;

        private readonly gaxgrpc::ApiCall<GetTensorboardRunRequest, TensorboardRun> _callGetTensorboardRun;

        private readonly gaxgrpc::ApiCall<UpdateTensorboardRunRequest, TensorboardRun> _callUpdateTensorboardRun;

        private readonly gaxgrpc::ApiCall<ListTensorboardRunsRequest, ListTensorboardRunsResponse> _callListTensorboardRuns;

        private readonly gaxgrpc::ApiCall<DeleteTensorboardRunRequest, lro::Operation> _callDeleteTensorboardRun;

        private readonly gaxgrpc::ApiCall<BatchCreateTensorboardTimeSeriesRequest, BatchCreateTensorboardTimeSeriesResponse> _callBatchCreateTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<CreateTensorboardTimeSeriesRequest, TensorboardTimeSeries> _callCreateTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<GetTensorboardTimeSeriesRequest, TensorboardTimeSeries> _callGetTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<UpdateTensorboardTimeSeriesRequest, TensorboardTimeSeries> _callUpdateTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<ListTensorboardTimeSeriesRequest, ListTensorboardTimeSeriesResponse> _callListTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<DeleteTensorboardTimeSeriesRequest, lro::Operation> _callDeleteTensorboardTimeSeries;

        private readonly gaxgrpc::ApiCall<BatchReadTensorboardTimeSeriesDataRequest, BatchReadTensorboardTimeSeriesDataResponse> _callBatchReadTensorboardTimeSeriesData;

        private readonly gaxgrpc::ApiCall<ReadTensorboardTimeSeriesDataRequest, ReadTensorboardTimeSeriesDataResponse> _callReadTensorboardTimeSeriesData;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadTensorboardBlobDataRequest, ReadTensorboardBlobDataResponse> _callReadTensorboardBlobData;

        private readonly gaxgrpc::ApiCall<WriteTensorboardExperimentDataRequest, WriteTensorboardExperimentDataResponse> _callWriteTensorboardExperimentData;

        private readonly gaxgrpc::ApiCall<WriteTensorboardRunDataRequest, WriteTensorboardRunDataResponse> _callWriteTensorboardRunData;

        private readonly gaxgrpc::ApiCall<ExportTensorboardTimeSeriesDataRequest, ExportTensorboardTimeSeriesDataResponse> _callExportTensorboardTimeSeriesData;

        /// <summary>
        /// Constructs a client wrapper for the TensorboardService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TensorboardServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TensorboardServiceClientImpl(TensorboardService.TensorboardServiceClient grpcClient, TensorboardServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TensorboardServiceSettings effectiveSettings = settings ?? TensorboardServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTensorboardOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTensorboardOperationsSettings, logger);
            UpdateTensorboardOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTensorboardOperationsSettings, logger);
            DeleteTensorboardOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTensorboardOperationsSettings, logger);
            DeleteTensorboardExperimentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTensorboardExperimentOperationsSettings, logger);
            DeleteTensorboardRunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTensorboardRunOperationsSettings, logger);
            DeleteTensorboardTimeSeriesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTensorboardTimeSeriesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateTensorboard = clientHelper.BuildApiCall<CreateTensorboardRequest, lro::Operation>("CreateTensorboard", grpcClient.CreateTensorboardAsync, grpcClient.CreateTensorboard, effectiveSettings.CreateTensorboardSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTensorboard);
            Modify_CreateTensorboardApiCall(ref _callCreateTensorboard);
            _callGetTensorboard = clientHelper.BuildApiCall<GetTensorboardRequest, Tensorboard>("GetTensorboard", grpcClient.GetTensorboardAsync, grpcClient.GetTensorboard, effectiveSettings.GetTensorboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTensorboard);
            Modify_GetTensorboardApiCall(ref _callGetTensorboard);
            _callUpdateTensorboard = clientHelper.BuildApiCall<UpdateTensorboardRequest, lro::Operation>("UpdateTensorboard", grpcClient.UpdateTensorboardAsync, grpcClient.UpdateTensorboard, effectiveSettings.UpdateTensorboardSettings).WithGoogleRequestParam("tensorboard.name", request => request.Tensorboard?.Name);
            Modify_ApiCall(ref _callUpdateTensorboard);
            Modify_UpdateTensorboardApiCall(ref _callUpdateTensorboard);
            _callListTensorboards = clientHelper.BuildApiCall<ListTensorboardsRequest, ListTensorboardsResponse>("ListTensorboards", grpcClient.ListTensorboardsAsync, grpcClient.ListTensorboards, effectiveSettings.ListTensorboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTensorboards);
            Modify_ListTensorboardsApiCall(ref _callListTensorboards);
            _callDeleteTensorboard = clientHelper.BuildApiCall<DeleteTensorboardRequest, lro::Operation>("DeleteTensorboard", grpcClient.DeleteTensorboardAsync, grpcClient.DeleteTensorboard, effectiveSettings.DeleteTensorboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTensorboard);
            Modify_DeleteTensorboardApiCall(ref _callDeleteTensorboard);
            _callReadTensorboardUsage = clientHelper.BuildApiCall<ReadTensorboardUsageRequest, ReadTensorboardUsageResponse>("ReadTensorboardUsage", grpcClient.ReadTensorboardUsageAsync, grpcClient.ReadTensorboardUsage, effectiveSettings.ReadTensorboardUsageSettings).WithGoogleRequestParam("tensorboard", request => request.Tensorboard);
            Modify_ApiCall(ref _callReadTensorboardUsage);
            Modify_ReadTensorboardUsageApiCall(ref _callReadTensorboardUsage);
            _callReadTensorboardSize = clientHelper.BuildApiCall<ReadTensorboardSizeRequest, ReadTensorboardSizeResponse>("ReadTensorboardSize", grpcClient.ReadTensorboardSizeAsync, grpcClient.ReadTensorboardSize, effectiveSettings.ReadTensorboardSizeSettings).WithGoogleRequestParam("tensorboard", request => request.Tensorboard);
            Modify_ApiCall(ref _callReadTensorboardSize);
            Modify_ReadTensorboardSizeApiCall(ref _callReadTensorboardSize);
            _callCreateTensorboardExperiment = clientHelper.BuildApiCall<CreateTensorboardExperimentRequest, TensorboardExperiment>("CreateTensorboardExperiment", grpcClient.CreateTensorboardExperimentAsync, grpcClient.CreateTensorboardExperiment, effectiveSettings.CreateTensorboardExperimentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTensorboardExperiment);
            Modify_CreateTensorboardExperimentApiCall(ref _callCreateTensorboardExperiment);
            _callGetTensorboardExperiment = clientHelper.BuildApiCall<GetTensorboardExperimentRequest, TensorboardExperiment>("GetTensorboardExperiment", grpcClient.GetTensorboardExperimentAsync, grpcClient.GetTensorboardExperiment, effectiveSettings.GetTensorboardExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTensorboardExperiment);
            Modify_GetTensorboardExperimentApiCall(ref _callGetTensorboardExperiment);
            _callUpdateTensorboardExperiment = clientHelper.BuildApiCall<UpdateTensorboardExperimentRequest, TensorboardExperiment>("UpdateTensorboardExperiment", grpcClient.UpdateTensorboardExperimentAsync, grpcClient.UpdateTensorboardExperiment, effectiveSettings.UpdateTensorboardExperimentSettings).WithGoogleRequestParam("tensorboard_experiment.name", request => request.TensorboardExperiment?.Name);
            Modify_ApiCall(ref _callUpdateTensorboardExperiment);
            Modify_UpdateTensorboardExperimentApiCall(ref _callUpdateTensorboardExperiment);
            _callListTensorboardExperiments = clientHelper.BuildApiCall<ListTensorboardExperimentsRequest, ListTensorboardExperimentsResponse>("ListTensorboardExperiments", grpcClient.ListTensorboardExperimentsAsync, grpcClient.ListTensorboardExperiments, effectiveSettings.ListTensorboardExperimentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTensorboardExperiments);
            Modify_ListTensorboardExperimentsApiCall(ref _callListTensorboardExperiments);
            _callDeleteTensorboardExperiment = clientHelper.BuildApiCall<DeleteTensorboardExperimentRequest, lro::Operation>("DeleteTensorboardExperiment", grpcClient.DeleteTensorboardExperimentAsync, grpcClient.DeleteTensorboardExperiment, effectiveSettings.DeleteTensorboardExperimentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTensorboardExperiment);
            Modify_DeleteTensorboardExperimentApiCall(ref _callDeleteTensorboardExperiment);
            _callCreateTensorboardRun = clientHelper.BuildApiCall<CreateTensorboardRunRequest, TensorboardRun>("CreateTensorboardRun", grpcClient.CreateTensorboardRunAsync, grpcClient.CreateTensorboardRun, effectiveSettings.CreateTensorboardRunSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTensorboardRun);
            Modify_CreateTensorboardRunApiCall(ref _callCreateTensorboardRun);
            _callBatchCreateTensorboardRuns = clientHelper.BuildApiCall<BatchCreateTensorboardRunsRequest, BatchCreateTensorboardRunsResponse>("BatchCreateTensorboardRuns", grpcClient.BatchCreateTensorboardRunsAsync, grpcClient.BatchCreateTensorboardRuns, effectiveSettings.BatchCreateTensorboardRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTensorboardRuns);
            Modify_BatchCreateTensorboardRunsApiCall(ref _callBatchCreateTensorboardRuns);
            _callGetTensorboardRun = clientHelper.BuildApiCall<GetTensorboardRunRequest, TensorboardRun>("GetTensorboardRun", grpcClient.GetTensorboardRunAsync, grpcClient.GetTensorboardRun, effectiveSettings.GetTensorboardRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTensorboardRun);
            Modify_GetTensorboardRunApiCall(ref _callGetTensorboardRun);
            _callUpdateTensorboardRun = clientHelper.BuildApiCall<UpdateTensorboardRunRequest, TensorboardRun>("UpdateTensorboardRun", grpcClient.UpdateTensorboardRunAsync, grpcClient.UpdateTensorboardRun, effectiveSettings.UpdateTensorboardRunSettings).WithGoogleRequestParam("tensorboard_run.name", request => request.TensorboardRun?.Name);
            Modify_ApiCall(ref _callUpdateTensorboardRun);
            Modify_UpdateTensorboardRunApiCall(ref _callUpdateTensorboardRun);
            _callListTensorboardRuns = clientHelper.BuildApiCall<ListTensorboardRunsRequest, ListTensorboardRunsResponse>("ListTensorboardRuns", grpcClient.ListTensorboardRunsAsync, grpcClient.ListTensorboardRuns, effectiveSettings.ListTensorboardRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTensorboardRuns);
            Modify_ListTensorboardRunsApiCall(ref _callListTensorboardRuns);
            _callDeleteTensorboardRun = clientHelper.BuildApiCall<DeleteTensorboardRunRequest, lro::Operation>("DeleteTensorboardRun", grpcClient.DeleteTensorboardRunAsync, grpcClient.DeleteTensorboardRun, effectiveSettings.DeleteTensorboardRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTensorboardRun);
            Modify_DeleteTensorboardRunApiCall(ref _callDeleteTensorboardRun);
            _callBatchCreateTensorboardTimeSeries = clientHelper.BuildApiCall<BatchCreateTensorboardTimeSeriesRequest, BatchCreateTensorboardTimeSeriesResponse>("BatchCreateTensorboardTimeSeries", grpcClient.BatchCreateTensorboardTimeSeriesAsync, grpcClient.BatchCreateTensorboardTimeSeries, effectiveSettings.BatchCreateTensorboardTimeSeriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateTensorboardTimeSeries);
            Modify_BatchCreateTensorboardTimeSeriesApiCall(ref _callBatchCreateTensorboardTimeSeries);
            _callCreateTensorboardTimeSeries = clientHelper.BuildApiCall<CreateTensorboardTimeSeriesRequest, TensorboardTimeSeries>("CreateTensorboardTimeSeries", grpcClient.CreateTensorboardTimeSeriesAsync, grpcClient.CreateTensorboardTimeSeries, effectiveSettings.CreateTensorboardTimeSeriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTensorboardTimeSeries);
            Modify_CreateTensorboardTimeSeriesApiCall(ref _callCreateTensorboardTimeSeries);
            _callGetTensorboardTimeSeries = clientHelper.BuildApiCall<GetTensorboardTimeSeriesRequest, TensorboardTimeSeries>("GetTensorboardTimeSeries", grpcClient.GetTensorboardTimeSeriesAsync, grpcClient.GetTensorboardTimeSeries, effectiveSettings.GetTensorboardTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTensorboardTimeSeries);
            Modify_GetTensorboardTimeSeriesApiCall(ref _callGetTensorboardTimeSeries);
            _callUpdateTensorboardTimeSeries = clientHelper.BuildApiCall<UpdateTensorboardTimeSeriesRequest, TensorboardTimeSeries>("UpdateTensorboardTimeSeries", grpcClient.UpdateTensorboardTimeSeriesAsync, grpcClient.UpdateTensorboardTimeSeries, effectiveSettings.UpdateTensorboardTimeSeriesSettings).WithGoogleRequestParam("tensorboard_time_series.name", request => request.TensorboardTimeSeries?.Name);
            Modify_ApiCall(ref _callUpdateTensorboardTimeSeries);
            Modify_UpdateTensorboardTimeSeriesApiCall(ref _callUpdateTensorboardTimeSeries);
            _callListTensorboardTimeSeries = clientHelper.BuildApiCall<ListTensorboardTimeSeriesRequest, ListTensorboardTimeSeriesResponse>("ListTensorboardTimeSeries", grpcClient.ListTensorboardTimeSeriesAsync, grpcClient.ListTensorboardTimeSeries, effectiveSettings.ListTensorboardTimeSeriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTensorboardTimeSeries);
            Modify_ListTensorboardTimeSeriesApiCall(ref _callListTensorboardTimeSeries);
            _callDeleteTensorboardTimeSeries = clientHelper.BuildApiCall<DeleteTensorboardTimeSeriesRequest, lro::Operation>("DeleteTensorboardTimeSeries", grpcClient.DeleteTensorboardTimeSeriesAsync, grpcClient.DeleteTensorboardTimeSeries, effectiveSettings.DeleteTensorboardTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTensorboardTimeSeries);
            Modify_DeleteTensorboardTimeSeriesApiCall(ref _callDeleteTensorboardTimeSeries);
            _callBatchReadTensorboardTimeSeriesData = clientHelper.BuildApiCall<BatchReadTensorboardTimeSeriesDataRequest, BatchReadTensorboardTimeSeriesDataResponse>("BatchReadTensorboardTimeSeriesData", grpcClient.BatchReadTensorboardTimeSeriesDataAsync, grpcClient.BatchReadTensorboardTimeSeriesData, effectiveSettings.BatchReadTensorboardTimeSeriesDataSettings).WithGoogleRequestParam("tensorboard", request => request.Tensorboard);
            Modify_ApiCall(ref _callBatchReadTensorboardTimeSeriesData);
            Modify_BatchReadTensorboardTimeSeriesDataApiCall(ref _callBatchReadTensorboardTimeSeriesData);
            _callReadTensorboardTimeSeriesData = clientHelper.BuildApiCall<ReadTensorboardTimeSeriesDataRequest, ReadTensorboardTimeSeriesDataResponse>("ReadTensorboardTimeSeriesData", grpcClient.ReadTensorboardTimeSeriesDataAsync, grpcClient.ReadTensorboardTimeSeriesData, effectiveSettings.ReadTensorboardTimeSeriesDataSettings).WithGoogleRequestParam("tensorboard_time_series", request => request.TensorboardTimeSeries);
            Modify_ApiCall(ref _callReadTensorboardTimeSeriesData);
            Modify_ReadTensorboardTimeSeriesDataApiCall(ref _callReadTensorboardTimeSeriesData);
            _callReadTensorboardBlobData = clientHelper.BuildApiCall<ReadTensorboardBlobDataRequest, ReadTensorboardBlobDataResponse>("ReadTensorboardBlobData", grpcClient.ReadTensorboardBlobData, effectiveSettings.ReadTensorboardBlobDataSettings).WithGoogleRequestParam("time_series", request => request.TimeSeries);
            Modify_ApiCall(ref _callReadTensorboardBlobData);
            Modify_ReadTensorboardBlobDataApiCall(ref _callReadTensorboardBlobData);
            _callWriteTensorboardExperimentData = clientHelper.BuildApiCall<WriteTensorboardExperimentDataRequest, WriteTensorboardExperimentDataResponse>("WriteTensorboardExperimentData", grpcClient.WriteTensorboardExperimentDataAsync, grpcClient.WriteTensorboardExperimentData, effectiveSettings.WriteTensorboardExperimentDataSettings).WithGoogleRequestParam("tensorboard_experiment", request => request.TensorboardExperiment);
            Modify_ApiCall(ref _callWriteTensorboardExperimentData);
            Modify_WriteTensorboardExperimentDataApiCall(ref _callWriteTensorboardExperimentData);
            _callWriteTensorboardRunData = clientHelper.BuildApiCall<WriteTensorboardRunDataRequest, WriteTensorboardRunDataResponse>("WriteTensorboardRunData", grpcClient.WriteTensorboardRunDataAsync, grpcClient.WriteTensorboardRunData, effectiveSettings.WriteTensorboardRunDataSettings).WithGoogleRequestParam("tensorboard_run", request => request.TensorboardRun);
            Modify_ApiCall(ref _callWriteTensorboardRunData);
            Modify_WriteTensorboardRunDataApiCall(ref _callWriteTensorboardRunData);
            _callExportTensorboardTimeSeriesData = clientHelper.BuildApiCall<ExportTensorboardTimeSeriesDataRequest, ExportTensorboardTimeSeriesDataResponse>("ExportTensorboardTimeSeriesData", grpcClient.ExportTensorboardTimeSeriesDataAsync, grpcClient.ExportTensorboardTimeSeriesData, effectiveSettings.ExportTensorboardTimeSeriesDataSettings).WithGoogleRequestParam("tensorboard_time_series", request => request.TensorboardTimeSeries);
            Modify_ApiCall(ref _callExportTensorboardTimeSeriesData);
            Modify_ExportTensorboardTimeSeriesDataApiCall(ref _callExportTensorboardTimeSeriesData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTensorboardApiCall(ref gaxgrpc::ApiCall<CreateTensorboardRequest, lro::Operation> call);

        partial void Modify_GetTensorboardApiCall(ref gaxgrpc::ApiCall<GetTensorboardRequest, Tensorboard> call);

        partial void Modify_UpdateTensorboardApiCall(ref gaxgrpc::ApiCall<UpdateTensorboardRequest, lro::Operation> call);

        partial void Modify_ListTensorboardsApiCall(ref gaxgrpc::ApiCall<ListTensorboardsRequest, ListTensorboardsResponse> call);

        partial void Modify_DeleteTensorboardApiCall(ref gaxgrpc::ApiCall<DeleteTensorboardRequest, lro::Operation> call);

        partial void Modify_ReadTensorboardUsageApiCall(ref gaxgrpc::ApiCall<ReadTensorboardUsageRequest, ReadTensorboardUsageResponse> call);

        partial void Modify_ReadTensorboardSizeApiCall(ref gaxgrpc::ApiCall<ReadTensorboardSizeRequest, ReadTensorboardSizeResponse> call);

        partial void Modify_CreateTensorboardExperimentApiCall(ref gaxgrpc::ApiCall<CreateTensorboardExperimentRequest, TensorboardExperiment> call);

        partial void Modify_GetTensorboardExperimentApiCall(ref gaxgrpc::ApiCall<GetTensorboardExperimentRequest, TensorboardExperiment> call);

        partial void Modify_UpdateTensorboardExperimentApiCall(ref gaxgrpc::ApiCall<UpdateTensorboardExperimentRequest, TensorboardExperiment> call);

        partial void Modify_ListTensorboardExperimentsApiCall(ref gaxgrpc::ApiCall<ListTensorboardExperimentsRequest, ListTensorboardExperimentsResponse> call);

        partial void Modify_DeleteTensorboardExperimentApiCall(ref gaxgrpc::ApiCall<DeleteTensorboardExperimentRequest, lro::Operation> call);

        partial void Modify_CreateTensorboardRunApiCall(ref gaxgrpc::ApiCall<CreateTensorboardRunRequest, TensorboardRun> call);

        partial void Modify_BatchCreateTensorboardRunsApiCall(ref gaxgrpc::ApiCall<BatchCreateTensorboardRunsRequest, BatchCreateTensorboardRunsResponse> call);

        partial void Modify_GetTensorboardRunApiCall(ref gaxgrpc::ApiCall<GetTensorboardRunRequest, TensorboardRun> call);

        partial void Modify_UpdateTensorboardRunApiCall(ref gaxgrpc::ApiCall<UpdateTensorboardRunRequest, TensorboardRun> call);

        partial void Modify_ListTensorboardRunsApiCall(ref gaxgrpc::ApiCall<ListTensorboardRunsRequest, ListTensorboardRunsResponse> call);

        partial void Modify_DeleteTensorboardRunApiCall(ref gaxgrpc::ApiCall<DeleteTensorboardRunRequest, lro::Operation> call);

        partial void Modify_BatchCreateTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<BatchCreateTensorboardTimeSeriesRequest, BatchCreateTensorboardTimeSeriesResponse> call);

        partial void Modify_CreateTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<CreateTensorboardTimeSeriesRequest, TensorboardTimeSeries> call);

        partial void Modify_GetTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<GetTensorboardTimeSeriesRequest, TensorboardTimeSeries> call);

        partial void Modify_UpdateTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<UpdateTensorboardTimeSeriesRequest, TensorboardTimeSeries> call);

        partial void Modify_ListTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<ListTensorboardTimeSeriesRequest, ListTensorboardTimeSeriesResponse> call);

        partial void Modify_DeleteTensorboardTimeSeriesApiCall(ref gaxgrpc::ApiCall<DeleteTensorboardTimeSeriesRequest, lro::Operation> call);

        partial void Modify_BatchReadTensorboardTimeSeriesDataApiCall(ref gaxgrpc::ApiCall<BatchReadTensorboardTimeSeriesDataRequest, BatchReadTensorboardTimeSeriesDataResponse> call);

        partial void Modify_ReadTensorboardTimeSeriesDataApiCall(ref gaxgrpc::ApiCall<ReadTensorboardTimeSeriesDataRequest, ReadTensorboardTimeSeriesDataResponse> call);

        partial void Modify_ReadTensorboardBlobDataApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadTensorboardBlobDataRequest, ReadTensorboardBlobDataResponse> call);

        partial void Modify_WriteTensorboardExperimentDataApiCall(ref gaxgrpc::ApiCall<WriteTensorboardExperimentDataRequest, WriteTensorboardExperimentDataResponse> call);

        partial void Modify_WriteTensorboardRunDataApiCall(ref gaxgrpc::ApiCall<WriteTensorboardRunDataRequest, WriteTensorboardRunDataResponse> call);

        partial void Modify_ExportTensorboardTimeSeriesDataApiCall(ref gaxgrpc::ApiCall<ExportTensorboardTimeSeriesDataRequest, ExportTensorboardTimeSeriesDataResponse> call);

        partial void OnConstruction(TensorboardService.TensorboardServiceClient grpcClient, TensorboardServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TensorboardService client</summary>
        public override TensorboardService.TensorboardServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateTensorboardRequest(ref CreateTensorboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTensorboardRequest(ref GetTensorboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTensorboardRequest(ref UpdateTensorboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTensorboardsRequest(ref ListTensorboardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTensorboardRequest(ref DeleteTensorboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadTensorboardUsageRequest(ref ReadTensorboardUsageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadTensorboardSizeRequest(ref ReadTensorboardSizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTensorboardExperimentRequest(ref CreateTensorboardExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTensorboardExperimentRequest(ref GetTensorboardExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTensorboardExperimentRequest(ref UpdateTensorboardExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTensorboardExperimentsRequest(ref ListTensorboardExperimentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTensorboardExperimentRequest(ref DeleteTensorboardExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTensorboardRunRequest(ref CreateTensorboardRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTensorboardRunsRequest(ref BatchCreateTensorboardRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTensorboardRunRequest(ref GetTensorboardRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTensorboardRunRequest(ref UpdateTensorboardRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTensorboardRunsRequest(ref ListTensorboardRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTensorboardRunRequest(ref DeleteTensorboardRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTensorboardTimeSeriesRequest(ref BatchCreateTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTensorboardTimeSeriesRequest(ref CreateTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTensorboardTimeSeriesRequest(ref GetTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTensorboardTimeSeriesRequest(ref UpdateTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTensorboardTimeSeriesRequest(ref ListTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTensorboardTimeSeriesRequest(ref DeleteTensorboardTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchReadTensorboardTimeSeriesDataRequest(ref BatchReadTensorboardTimeSeriesDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadTensorboardTimeSeriesDataRequest(ref ReadTensorboardTimeSeriesDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadTensorboardBlobDataRequest(ref ReadTensorboardBlobDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteTensorboardExperimentDataRequest(ref WriteTensorboardExperimentDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteTensorboardRunDataRequest(ref WriteTensorboardRunDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportTensorboardTimeSeriesDataRequest(ref ExportTensorboardTimeSeriesDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateTensorboard</c>.</summary>
        public override lro::OperationsClient CreateTensorboardOperationsClient { get; }

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Tensorboard, CreateTensorboardOperationMetadata> CreateTensorboard(CreateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>(_callCreateTensorboard.Sync(request, callSettings), CreateTensorboardOperationsClient);
        }

        /// <summary>
        /// Creates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>> CreateTensorboardAsync(CreateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<Tensorboard, CreateTensorboardOperationMetadata>(await _callCreateTensorboard.Async(request, callSettings).ConfigureAwait(false), CreateTensorboardOperationsClient);
        }

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Tensorboard GetTensorboard(GetTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardRequest(ref request, ref callSettings);
            return _callGetTensorboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Tensorboard> GetTensorboardAsync(GetTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardRequest(ref request, ref callSettings);
            return _callGetTensorboard.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateTensorboard</c>.</summary>
        public override lro::OperationsClient UpdateTensorboardOperationsClient { get; }

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata> UpdateTensorboard(UpdateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>(_callUpdateTensorboard.Sync(request, callSettings), UpdateTensorboardOperationsClient);
        }

        /// <summary>
        /// Updates a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>> UpdateTensorboardAsync(UpdateTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<Tensorboard, UpdateTensorboardOperationMetadata>(await _callUpdateTensorboard.Async(request, callSettings).ConfigureAwait(false), UpdateTensorboardOperationsClient);
        }

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Tensorboard"/> resources.</returns>
        public override gax::PagedEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboards(ListTensorboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTensorboardsRequest, ListTensorboardsResponse, Tensorboard>(_callListTensorboards, request, callSettings);
        }

        /// <summary>
        /// Lists Tensorboards in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Tensorboard"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> ListTensorboardsAsync(ListTensorboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTensorboardsRequest, ListTensorboardsResponse, Tensorboard>(_callListTensorboards, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteTensorboard</c>.</summary>
        public override lro::OperationsClient DeleteTensorboardOperationsClient { get; }

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboard(DeleteTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteTensorboard.Sync(request, callSettings), DeleteTensorboardOperationsClient);
        }

        /// <summary>
        /// Deletes a Tensorboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardAsync(DeleteTensorboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteTensorboard.Async(request, callSettings).ConfigureAwait(false), DeleteTensorboardOperationsClient);
        }

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadTensorboardUsageResponse ReadTensorboardUsage(ReadTensorboardUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardUsageRequest(ref request, ref callSettings);
            return _callReadTensorboardUsage.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of monthly active users for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadTensorboardUsageResponse> ReadTensorboardUsageAsync(ReadTensorboardUsageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardUsageRequest(ref request, ref callSettings);
            return _callReadTensorboardUsage.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadTensorboardSizeResponse ReadTensorboardSize(ReadTensorboardSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardSizeRequest(ref request, ref callSettings);
            return _callReadTensorboardSize.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the storage size for a given TensorBoard instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadTensorboardSizeResponse> ReadTensorboardSizeAsync(ReadTensorboardSizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardSizeRequest(ref request, ref callSettings);
            return _callReadTensorboardSize.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardExperiment CreateTensorboardExperiment(CreateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardExperimentRequest(ref request, ref callSettings);
            return _callCreateTensorboardExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardExperiment> CreateTensorboardExperimentAsync(CreateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardExperimentRequest(ref request, ref callSettings);
            return _callCreateTensorboardExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardExperiment GetTensorboardExperiment(GetTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardExperimentRequest(ref request, ref callSettings);
            return _callGetTensorboardExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardExperiment> GetTensorboardExperimentAsync(GetTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardExperimentRequest(ref request, ref callSettings);
            return _callGetTensorboardExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardExperiment UpdateTensorboardExperiment(UpdateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardExperimentRequest(ref request, ref callSettings);
            return _callUpdateTensorboardExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardExperiment> UpdateTensorboardExperimentAsync(UpdateTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardExperimentRequest(ref request, ref callSettings);
            return _callUpdateTensorboardExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public override gax::PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperiments(ListTensorboardExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardExperimentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTensorboardExperimentsRequest, ListTensorboardExperimentsResponse, TensorboardExperiment>(_callListTensorboardExperiments, request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardExperiments in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardExperiment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> ListTensorboardExperimentsAsync(ListTensorboardExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardExperimentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTensorboardExperimentsRequest, ListTensorboardExperimentsResponse, TensorboardExperiment>(_callListTensorboardExperiments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteTensorboardExperiment</c>.</summary>
        public override lro::OperationsClient DeleteTensorboardExperimentOperationsClient { get; }

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardExperiment(DeleteTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteTensorboardExperiment.Sync(request, callSettings), DeleteTensorboardExperimentOperationsClient);
        }

        /// <summary>
        /// Deletes a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardExperimentAsync(DeleteTensorboardExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteTensorboardExperiment.Async(request, callSettings).ConfigureAwait(false), DeleteTensorboardExperimentOperationsClient);
        }

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardRun CreateTensorboardRun(CreateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardRunRequest(ref request, ref callSettings);
            return _callCreateTensorboardRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardRun> CreateTensorboardRunAsync(CreateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardRunRequest(ref request, ref callSettings);
            return _callCreateTensorboardRun.Async(request, callSettings);
        }

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTensorboardRunsResponse BatchCreateTensorboardRuns(BatchCreateTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTensorboardRunsRequest(ref request, ref callSettings);
            return _callBatchCreateTensorboardRuns.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch create TensorboardRuns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTensorboardRunsResponse> BatchCreateTensorboardRunsAsync(BatchCreateTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTensorboardRunsRequest(ref request, ref callSettings);
            return _callBatchCreateTensorboardRuns.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardRun GetTensorboardRun(GetTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardRunRequest(ref request, ref callSettings);
            return _callGetTensorboardRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardRun> GetTensorboardRunAsync(GetTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardRunRequest(ref request, ref callSettings);
            return _callGetTensorboardRun.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardRun UpdateTensorboardRun(UpdateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardRunRequest(ref request, ref callSettings);
            return _callUpdateTensorboardRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardRun> UpdateTensorboardRunAsync(UpdateTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardRunRequest(ref request, ref callSettings);
            return _callUpdateTensorboardRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRuns(ListTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTensorboardRunsRequest, ListTensorboardRunsResponse, TensorboardRun>(_callListTensorboardRuns, request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardRuns in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> ListTensorboardRunsAsync(ListTensorboardRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTensorboardRunsRequest, ListTensorboardRunsResponse, TensorboardRun>(_callListTensorboardRuns, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteTensorboardRun</c>.</summary>
        public override lro::OperationsClient DeleteTensorboardRunOperationsClient { get; }

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardRun(DeleteTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteTensorboardRun.Sync(request, callSettings), DeleteTensorboardRunOperationsClient);
        }

        /// <summary>
        /// Deletes a TensorboardRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardRunAsync(DeleteTensorboardRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteTensorboardRun.Async(request, callSettings).ConfigureAwait(false), DeleteTensorboardRunOperationsClient);
        }

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTensorboardTimeSeriesResponse BatchCreateTensorboardTimeSeries(BatchCreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callBatchCreateTensorboardTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch create TensorboardTimeSeries that belong to a TensorboardExperiment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTensorboardTimeSeriesResponse> BatchCreateTensorboardTimeSeriesAsync(BatchCreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callBatchCreateTensorboardTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardTimeSeries CreateTensorboardTimeSeries(CreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callCreateTensorboardTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardTimeSeries> CreateTensorboardTimeSeriesAsync(CreateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callCreateTensorboardTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardTimeSeries GetTensorboardTimeSeries(GetTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callGetTensorboardTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardTimeSeries> GetTensorboardTimeSeriesAsync(GetTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callGetTensorboardTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TensorboardTimeSeries UpdateTensorboardTimeSeries(UpdateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callUpdateTensorboardTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TensorboardTimeSeries> UpdateTensorboardTimeSeriesAsync(UpdateTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return _callUpdateTensorboardTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public override gax::PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeries(ListTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTensorboardTimeSeriesRequest, ListTensorboardTimeSeriesResponse, TensorboardTimeSeries>(_callListTensorboardTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Lists TensorboardTimeSeries in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TensorboardTimeSeries"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> ListTensorboardTimeSeriesAsync(ListTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTensorboardTimeSeriesRequest, ListTensorboardTimeSeriesResponse, TensorboardTimeSeries>(_callListTensorboardTimeSeries, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteTensorboardTimeSeries</c>.</summary>
        public override lro::OperationsClient DeleteTensorboardTimeSeriesOperationsClient { get; }

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteTensorboardTimeSeries(DeleteTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteTensorboardTimeSeries.Sync(request, callSettings), DeleteTensorboardTimeSeriesOperationsClient);
        }

        /// <summary>
        /// Deletes a TensorboardTimeSeries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteTensorboardTimeSeriesAsync(DeleteTensorboardTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTensorboardTimeSeriesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteTensorboardTimeSeries.Async(request, callSettings).ConfigureAwait(false), DeleteTensorboardTimeSeriesOperationsClient);
        }

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchReadTensorboardTimeSeriesDataResponse BatchReadTensorboardTimeSeriesData(BatchReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReadTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return _callBatchReadTensorboardTimeSeriesData.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads multiple TensorboardTimeSeries' data. The data point number limit is
        /// 1000 for scalars, 100 for tensors and blob references. If the number of
        /// data points stored is less than the limit, all data is returned.
        /// Otherwise, the number limit of data points is randomly selected from
        /// this time series and returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchReadTensorboardTimeSeriesDataResponse> BatchReadTensorboardTimeSeriesDataAsync(BatchReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchReadTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return _callBatchReadTensorboardTimeSeriesData.Async(request, callSettings);
        }

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadTensorboardTimeSeriesDataResponse ReadTensorboardTimeSeriesData(ReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return _callReadTensorboardTimeSeriesData.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads a TensorboardTimeSeries' data. By default, if the number of data
        /// points stored is less than 1000, all data is returned. Otherwise, 1000
        /// data points is randomly selected from this time series and returned.
        /// This value can be changed by changing max_data_points, which can't be
        /// greater than 10k.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadTensorboardTimeSeriesDataResponse> ReadTensorboardTimeSeriesDataAsync(ReadTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return _callReadTensorboardTimeSeriesData.Async(request, callSettings);
        }

        internal sealed partial class ReadTensorboardBlobDataStreamImpl : ReadTensorboardBlobDataStream
        {
            /// <summary>Construct the server streaming method for <c>ReadTensorboardBlobData</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadTensorboardBlobDataStreamImpl(grpccore::AsyncServerStreamingCall<ReadTensorboardBlobDataResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadTensorboardBlobDataResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Gets bytes of TensorboardBlobs.
        /// This is to allow reading blob data stored in consumer project's Cloud
        /// Storage bucket without users having to obtain Cloud Storage access
        /// permission.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override TensorboardServiceClient.ReadTensorboardBlobDataStream ReadTensorboardBlobData(ReadTensorboardBlobDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadTensorboardBlobDataRequest(ref request, ref callSettings);
            return new ReadTensorboardBlobDataStreamImpl(_callReadTensorboardBlobData.Call(request, callSettings));
        }

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteTensorboardExperimentDataResponse WriteTensorboardExperimentData(WriteTensorboardExperimentDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteTensorboardExperimentDataRequest(ref request, ref callSettings);
            return _callWriteTensorboardExperimentData.Sync(request, callSettings);
        }

        /// <summary>
        /// Write time series data points of multiple TensorboardTimeSeries in multiple
        /// TensorboardRun's. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteTensorboardExperimentDataResponse> WriteTensorboardExperimentDataAsync(WriteTensorboardExperimentDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteTensorboardExperimentDataRequest(ref request, ref callSettings);
            return _callWriteTensorboardExperimentData.Async(request, callSettings);
        }

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteTensorboardRunDataResponse WriteTensorboardRunData(WriteTensorboardRunDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteTensorboardRunDataRequest(ref request, ref callSettings);
            return _callWriteTensorboardRunData.Sync(request, callSettings);
        }

        /// <summary>
        /// Write time series data points into multiple TensorboardTimeSeries under
        /// a TensorboardRun. If any data fail to be ingested, an error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteTensorboardRunDataResponse> WriteTensorboardRunDataAsync(WriteTensorboardRunDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteTensorboardRunDataRequest(ref request, ref callSettings);
            return _callWriteTensorboardRunData.Async(request, callSettings);
        }

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public override gax::PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesData(ExportTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ExportTensorboardTimeSeriesDataRequest, ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint>(_callExportTensorboardTimeSeriesData, request, callSettings);
        }

        /// <summary>
        /// Exports a TensorboardTimeSeries' data. Data is returned in paginated
        /// responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesDataPoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> ExportTensorboardTimeSeriesDataAsync(ExportTensorboardTimeSeriesDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportTensorboardTimeSeriesDataRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ExportTensorboardTimeSeriesDataRequest, ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint>(_callExportTensorboardTimeSeriesData, request, callSettings);
        }
    }

    public partial class ListTensorboardsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTensorboardExperimentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTensorboardRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTensorboardTimeSeriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ExportTensorboardTimeSeriesDataRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTensorboardsResponse : gaxgrpc::IPageResponse<Tensorboard>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Tensorboard> GetEnumerator() => Tensorboards.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTensorboardExperimentsResponse : gaxgrpc::IPageResponse<TensorboardExperiment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TensorboardExperiment> GetEnumerator() => TensorboardExperiments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTensorboardRunsResponse : gaxgrpc::IPageResponse<TensorboardRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TensorboardRun> GetEnumerator() => TensorboardRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTensorboardTimeSeriesResponse : gaxgrpc::IPageResponse<TensorboardTimeSeries>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TensorboardTimeSeries> GetEnumerator() => TensorboardTimeSeries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ExportTensorboardTimeSeriesDataResponse : gaxgrpc::IPageResponse<TimeSeriesDataPoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TimeSeriesDataPoint> GetEnumerator() => TimeSeriesDataPoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TensorboardService
    {
        public partial class TensorboardServiceClient
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

    public static partial class TensorboardService
    {
        public partial class TensorboardServiceClient
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
