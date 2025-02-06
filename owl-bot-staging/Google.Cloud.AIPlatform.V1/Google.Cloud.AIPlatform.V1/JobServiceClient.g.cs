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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="JobServiceClient"/> instances.</summary>
    public sealed partial class JobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="JobServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="JobServiceSettings"/>.</returns>
        public static JobServiceSettings GetDefault() => new JobServiceSettings();

        /// <summary>Constructs a new <see cref="JobServiceSettings"/> object with default settings.</summary>
        public JobServiceSettings()
        {
        }

        private JobServiceSettings(JobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCustomJobSettings = existing.CreateCustomJobSettings;
            GetCustomJobSettings = existing.GetCustomJobSettings;
            ListCustomJobsSettings = existing.ListCustomJobsSettings;
            DeleteCustomJobSettings = existing.DeleteCustomJobSettings;
            DeleteCustomJobOperationsSettings = existing.DeleteCustomJobOperationsSettings.Clone();
            CancelCustomJobSettings = existing.CancelCustomJobSettings;
            CreateDataLabelingJobSettings = existing.CreateDataLabelingJobSettings;
            GetDataLabelingJobSettings = existing.GetDataLabelingJobSettings;
            ListDataLabelingJobsSettings = existing.ListDataLabelingJobsSettings;
            DeleteDataLabelingJobSettings = existing.DeleteDataLabelingJobSettings;
            DeleteDataLabelingJobOperationsSettings = existing.DeleteDataLabelingJobOperationsSettings.Clone();
            CancelDataLabelingJobSettings = existing.CancelDataLabelingJobSettings;
            CreateHyperparameterTuningJobSettings = existing.CreateHyperparameterTuningJobSettings;
            GetHyperparameterTuningJobSettings = existing.GetHyperparameterTuningJobSettings;
            ListHyperparameterTuningJobsSettings = existing.ListHyperparameterTuningJobsSettings;
            DeleteHyperparameterTuningJobSettings = existing.DeleteHyperparameterTuningJobSettings;
            DeleteHyperparameterTuningJobOperationsSettings = existing.DeleteHyperparameterTuningJobOperationsSettings.Clone();
            CancelHyperparameterTuningJobSettings = existing.CancelHyperparameterTuningJobSettings;
            CreateNasJobSettings = existing.CreateNasJobSettings;
            GetNasJobSettings = existing.GetNasJobSettings;
            ListNasJobsSettings = existing.ListNasJobsSettings;
            DeleteNasJobSettings = existing.DeleteNasJobSettings;
            DeleteNasJobOperationsSettings = existing.DeleteNasJobOperationsSettings.Clone();
            CancelNasJobSettings = existing.CancelNasJobSettings;
            GetNasTrialDetailSettings = existing.GetNasTrialDetailSettings;
            ListNasTrialDetailsSettings = existing.ListNasTrialDetailsSettings;
            CreateBatchPredictionJobSettings = existing.CreateBatchPredictionJobSettings;
            GetBatchPredictionJobSettings = existing.GetBatchPredictionJobSettings;
            ListBatchPredictionJobsSettings = existing.ListBatchPredictionJobsSettings;
            DeleteBatchPredictionJobSettings = existing.DeleteBatchPredictionJobSettings;
            DeleteBatchPredictionJobOperationsSettings = existing.DeleteBatchPredictionJobOperationsSettings.Clone();
            CancelBatchPredictionJobSettings = existing.CancelBatchPredictionJobSettings;
            CreateModelDeploymentMonitoringJobSettings = existing.CreateModelDeploymentMonitoringJobSettings;
            SearchModelDeploymentMonitoringStatsAnomaliesSettings = existing.SearchModelDeploymentMonitoringStatsAnomaliesSettings;
            GetModelDeploymentMonitoringJobSettings = existing.GetModelDeploymentMonitoringJobSettings;
            ListModelDeploymentMonitoringJobsSettings = existing.ListModelDeploymentMonitoringJobsSettings;
            UpdateModelDeploymentMonitoringJobSettings = existing.UpdateModelDeploymentMonitoringJobSettings;
            UpdateModelDeploymentMonitoringJobOperationsSettings = existing.UpdateModelDeploymentMonitoringJobOperationsSettings.Clone();
            DeleteModelDeploymentMonitoringJobSettings = existing.DeleteModelDeploymentMonitoringJobSettings;
            DeleteModelDeploymentMonitoringJobOperationsSettings = existing.DeleteModelDeploymentMonitoringJobOperationsSettings.Clone();
            PauseModelDeploymentMonitoringJobSettings = existing.PauseModelDeploymentMonitoringJobSettings;
            ResumeModelDeploymentMonitoringJobSettings = existing.ResumeModelDeploymentMonitoringJobSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(JobServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateCustomJob</c> and <c>JobServiceClient.CreateCustomJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetCustomJob</c> and <c>JobServiceClient.GetCustomJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListCustomJobs</c> and <c>JobServiceClient.ListCustomJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteCustomJob</c> and <c>JobServiceClient.DeleteCustomJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteCustomJob</c> and
        /// <c>JobServiceClient.DeleteCustomJobAsync</c>.
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
        public lro::OperationsSettings DeleteCustomJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CancelCustomJob</c> and <c>JobServiceClient.CancelCustomJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelCustomJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateDataLabelingJob</c> and <c>JobServiceClient.CreateDataLabelingJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataLabelingJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetDataLabelingJob</c> and <c>JobServiceClient.GetDataLabelingJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataLabelingJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListDataLabelingJobs</c> and <c>JobServiceClient.ListDataLabelingJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataLabelingJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteDataLabelingJob</c> and <c>JobServiceClient.DeleteDataLabelingJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataLabelingJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteDataLabelingJob</c> and
        /// <c>JobServiceClient.DeleteDataLabelingJobAsync</c>.
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
        public lro::OperationsSettings DeleteDataLabelingJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CancelDataLabelingJob</c> and <c>JobServiceClient.CancelDataLabelingJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelDataLabelingJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateHyperparameterTuningJob</c> and
        /// <c>JobServiceClient.CreateHyperparameterTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateHyperparameterTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetHyperparameterTuningJob</c> and <c>JobServiceClient.GetHyperparameterTuningJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHyperparameterTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListHyperparameterTuningJobs</c> and
        /// <c>JobServiceClient.ListHyperparameterTuningJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListHyperparameterTuningJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteHyperparameterTuningJob</c> and
        /// <c>JobServiceClient.DeleteHyperparameterTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteHyperparameterTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteHyperparameterTuningJob</c> and
        /// <c>JobServiceClient.DeleteHyperparameterTuningJobAsync</c>.
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
        public lro::OperationsSettings DeleteHyperparameterTuningJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CancelHyperparameterTuningJob</c> and
        /// <c>JobServiceClient.CancelHyperparameterTuningJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelHyperparameterTuningJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateNasJob</c> and <c>JobServiceClient.CreateNasJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNasJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.GetNasJob</c>
        ///  and <c>JobServiceClient.GetNasJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNasJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListNasJobs</c> and <c>JobServiceClient.ListNasJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNasJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteNasJob</c> and <c>JobServiceClient.DeleteNasJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNasJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteNasJob</c> and
        /// <c>JobServiceClient.DeleteNasJobAsync</c>.
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
        public lro::OperationsSettings DeleteNasJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CancelNasJob</c> and <c>JobServiceClient.CancelNasJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelNasJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetNasTrialDetail</c> and <c>JobServiceClient.GetNasTrialDetailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNasTrialDetailSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListNasTrialDetails</c> and <c>JobServiceClient.ListNasTrialDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNasTrialDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateBatchPredictionJob</c> and <c>JobServiceClient.CreateBatchPredictionJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBatchPredictionJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetBatchPredictionJob</c> and <c>JobServiceClient.GetBatchPredictionJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBatchPredictionJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListBatchPredictionJobs</c> and <c>JobServiceClient.ListBatchPredictionJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBatchPredictionJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteBatchPredictionJob</c> and <c>JobServiceClient.DeleteBatchPredictionJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBatchPredictionJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteBatchPredictionJob</c> and
        /// <c>JobServiceClient.DeleteBatchPredictionJobAsync</c>.
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
        public lro::OperationsSettings DeleteBatchPredictionJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CancelBatchPredictionJob</c> and <c>JobServiceClient.CancelBatchPredictionJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelBatchPredictionJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.CreateModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.CreateModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.SearchModelDeploymentMonitoringStatsAnomalies</c> and
        /// <c>JobServiceClient.SearchModelDeploymentMonitoringStatsAnomaliesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchModelDeploymentMonitoringStatsAnomaliesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.GetModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.GetModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ListModelDeploymentMonitoringJobs</c> and
        /// <c>JobServiceClient.ListModelDeploymentMonitoringJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelDeploymentMonitoringJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.UpdateModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.UpdateModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.UpdateModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.UpdateModelDeploymentMonitoringJobAsync</c>.
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
        public lro::OperationsSettings UpdateModelDeploymentMonitoringJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.DeleteModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.DeleteModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.DeleteModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.DeleteModelDeploymentMonitoringJobAsync</c>.
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
        public lro::OperationsSettings DeleteModelDeploymentMonitoringJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.PauseModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.PauseModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.ResumeModelDeploymentMonitoringJob</c> and
        /// <c>JobServiceClient.ResumeModelDeploymentMonitoringJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeModelDeploymentMonitoringJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="JobServiceSettings"/> object.</returns>
        public JobServiceSettings Clone() => new JobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobServiceClientBuilder : gaxgrpc::ClientBuilderBase<JobServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public JobServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public JobServiceClientBuilder() : base(JobServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref JobServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<JobServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override JobServiceClient Build()
        {
            JobServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<JobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<JobServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private JobServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<JobServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobServiceClient.ChannelPool;
    }

    /// <summary>JobService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's jobs.
    /// </remarks>
    public abstract partial class JobServiceClient
    {
        /// <summary>
        /// The default endpoint for the JobService service, which is a host of "aiplatform.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default JobService scopes.</summary>
        /// <remarks>
        /// The default JobService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(JobService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="JobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="JobServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="JobServiceClient"/>.</returns>
        public static stt::Task<JobServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new JobServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="JobServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="JobServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        public static JobServiceClient Create() => new JobServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="JobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        internal static JobServiceClient Create(grpccore::CallInvoker callInvoker, JobServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobService.JobServiceClient grpcClient = new JobService.JobServiceClient(callInvoker);
            return new JobServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC JobService client</summary>
        public virtual JobService.JobServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob CreateCustomJob(CreateCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(CreateCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(CreateCustomJobRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob CreateCustomJob(string parent, CustomJob customJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomJob(new CreateCustomJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomJob = gax::GaxPreconditions.CheckNotNull(customJob, nameof(customJob)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(string parent, CustomJob customJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomJobAsync(new CreateCustomJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomJob = gax::GaxPreconditions.CheckNotNull(customJob, nameof(customJob)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(string parent, CustomJob customJob, st::CancellationToken cancellationToken) =>
            CreateCustomJobAsync(parent, customJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob CreateCustomJob(gagr::LocationName parent, CustomJob customJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomJob(new CreateCustomJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomJob = gax::GaxPreconditions.CheckNotNull(customJob, nameof(customJob)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(gagr::LocationName parent, CustomJob customJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomJobAsync(new CreateCustomJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomJob = gax::GaxPreconditions.CheckNotNull(customJob, nameof(customJob)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the CustomJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="customJob">
        /// Required. The CustomJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> CreateCustomJobAsync(gagr::LocationName parent, CustomJob customJob, st::CancellationToken cancellationToken) =>
            CreateCustomJobAsync(parent, customJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob GetCustomJob(GetCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(GetCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(GetCustomJobRequest request, st::CancellationToken cancellationToken) =>
            GetCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob GetCustomJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomJob(new GetCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomJobAsync(new GetCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomJob GetCustomJob(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomJob(new GetCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomJobAsync(new GetCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomJob> GetCustomJobAsync(CustomJobName name, st::CancellationToken cancellationToken) =>
            GetCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobs(ListCustomJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobsAsync(ListCustomJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the CustomJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomJobsRequest request = new ListCustomJobsRequest
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
            return ListCustomJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the CustomJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomJobsRequest request = new ListCustomJobsRequest
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
            return ListCustomJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the CustomJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomJobsRequest request = new ListCustomJobsRequest
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
            return ListCustomJobs(request, callSettings);
        }

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the CustomJobs from.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomJobsRequest request = new ListCustomJobsRequest
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
            return ListCustomJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteCustomJob(DeleteCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(DeleteCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(DeleteCustomJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCustomJob</c>.</summary>
        public virtual lro::OperationsClient DeleteCustomJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCustomJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteCustomJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCustomJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteCustomJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteCustomJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomJob(new DeleteCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomJobAsync(new DeleteCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteCustomJob(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomJob(new DeleteCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomJobAsync(new DeleteCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(CustomJobName name, st::CancellationToken cancellationToken) =>
            DeleteCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelCustomJob(CancelCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(CancelCustomJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(CancelCustomJobRequest request, st::CancellationToken cancellationToken) =>
            CancelCustomJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelCustomJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCustomJob(new CancelCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCustomJobAsync(new CancelCustomJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelCustomJob(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCustomJob(new CancelCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(CustomJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelCustomJobAsync(new CancelCustomJobRequest
            {
                CustomJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/customJobs/{custom_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelCustomJobAsync(CustomJobName name, st::CancellationToken cancellationToken) =>
            CancelCustomJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob CreateDataLabelingJob(CreateDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(CreateDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(CreateDataLabelingJobRequest request, st::CancellationToken cancellationToken) =>
            CreateDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob CreateDataLabelingJob(string parent, DataLabelingJob dataLabelingJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLabelingJob(new CreateDataLabelingJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataLabelingJob = gax::GaxPreconditions.CheckNotNull(dataLabelingJob, nameof(dataLabelingJob)),
            }, callSettings);

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(string parent, DataLabelingJob dataLabelingJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLabelingJobAsync(new CreateDataLabelingJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataLabelingJob = gax::GaxPreconditions.CheckNotNull(dataLabelingJob, nameof(dataLabelingJob)),
            }, callSettings);

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(string parent, DataLabelingJob dataLabelingJob, st::CancellationToken cancellationToken) =>
            CreateDataLabelingJobAsync(parent, dataLabelingJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob CreateDataLabelingJob(gagr::LocationName parent, DataLabelingJob dataLabelingJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLabelingJob(new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataLabelingJob = gax::GaxPreconditions.CheckNotNull(dataLabelingJob, nameof(dataLabelingJob)),
            }, callSettings);

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(gagr::LocationName parent, DataLabelingJob dataLabelingJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLabelingJobAsync(new CreateDataLabelingJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataLabelingJob = gax::GaxPreconditions.CheckNotNull(dataLabelingJob, nameof(dataLabelingJob)),
            }, callSettings);

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dataLabelingJob">
        /// Required. The DataLabelingJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(gagr::LocationName parent, DataLabelingJob dataLabelingJob, st::CancellationToken cancellationToken) =>
            CreateDataLabelingJobAsync(parent, dataLabelingJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob GetDataLabelingJob(GetDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(GetDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(GetDataLabelingJobRequest request, st::CancellationToken cancellationToken) =>
            GetDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob GetDataLabelingJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataLabelingJob(new GetDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataLabelingJobAsync(new GetDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataLabelingJob GetDataLabelingJob(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataLabelingJob(new GetDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataLabelingJobAsync(new GetDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataLabelingJob> GetDataLabelingJobAsync(DataLabelingJobName name, st::CancellationToken cancellationToken) =>
            GetDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobs(ListDataLabelingJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobsAsync(ListDataLabelingJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
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
            return ListDataLabelingJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
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
            return ListDataLabelingJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
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
            return ListDataLabelingJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the DataLabelingJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataLabelingJobsRequest request = new ListDataLabelingJobsRequest
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
            return ListDataLabelingJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataLabelingJob(DeleteDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(DeleteDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(DeleteDataLabelingJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataLabelingJob</c>.</summary>
        public virtual lro::OperationsClient DeleteDataLabelingJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataLabelingJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteDataLabelingJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataLabelingJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataLabelingJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteDataLabelingJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataLabelingJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataLabelingJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataLabelingJob(new DeleteDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataLabelingJobAsync(new DeleteDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataLabelingJob(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataLabelingJob(new DeleteDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataLabelingJobAsync(new DeleteDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(DataLabelingJobName name, st::CancellationToken cancellationToken) =>
            DeleteDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelDataLabelingJob(CancelDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(CancelDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(CancelDataLabelingJobRequest request, st::CancellationToken cancellationToken) =>
            CancelDataLabelingJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelDataLabelingJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelDataLabelingJob(new CancelDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelDataLabelingJobAsync(new CancelDataLabelingJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelDataLabelingJob(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelDataLabelingJob(new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(DataLabelingJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelDataLabelingJobAsync(new CancelDataLabelingJobRequest
            {
                DataLabelingJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DataLabelingJob.
        /// Format:
        /// `projects/{project}/locations/{location}/dataLabelingJobs/{data_labeling_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDataLabelingJobAsync(DataLabelingJobName name, st::CancellationToken cancellationToken) =>
            CancelDataLabelingJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob CreateHyperparameterTuningJob(CreateHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(CreateHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(CreateHyperparameterTuningJobRequest request, st::CancellationToken cancellationToken) =>
            CreateHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob CreateHyperparameterTuningJob(string parent, HyperparameterTuningJob hyperparameterTuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateHyperparameterTuningJob(new CreateHyperparameterTuningJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HyperparameterTuningJob = gax::GaxPreconditions.CheckNotNull(hyperparameterTuningJob, nameof(hyperparameterTuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(string parent, HyperparameterTuningJob hyperparameterTuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateHyperparameterTuningJobAsync(new CreateHyperparameterTuningJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                HyperparameterTuningJob = gax::GaxPreconditions.CheckNotNull(hyperparameterTuningJob, nameof(hyperparameterTuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(string parent, HyperparameterTuningJob hyperparameterTuningJob, st::CancellationToken cancellationToken) =>
            CreateHyperparameterTuningJobAsync(parent, hyperparameterTuningJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob CreateHyperparameterTuningJob(gagr::LocationName parent, HyperparameterTuningJob hyperparameterTuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateHyperparameterTuningJob(new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HyperparameterTuningJob = gax::GaxPreconditions.CheckNotNull(hyperparameterTuningJob, nameof(hyperparameterTuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(gagr::LocationName parent, HyperparameterTuningJob hyperparameterTuningJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateHyperparameterTuningJobAsync(new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                HyperparameterTuningJob = gax::GaxPreconditions.CheckNotNull(hyperparameterTuningJob, nameof(hyperparameterTuningJob)),
            }, callSettings);

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// HyperparameterTuningJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="hyperparameterTuningJob">
        /// Required. The HyperparameterTuningJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(gagr::LocationName parent, HyperparameterTuningJob hyperparameterTuningJob, st::CancellationToken cancellationToken) =>
            CreateHyperparameterTuningJobAsync(parent, hyperparameterTuningJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob GetHyperparameterTuningJob(GetHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(GetHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(GetHyperparameterTuningJobRequest request, st::CancellationToken cancellationToken) =>
            GetHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob GetHyperparameterTuningJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHyperparameterTuningJob(new GetHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHyperparameterTuningJobAsync(new GetHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HyperparameterTuningJob GetHyperparameterTuningJob(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHyperparameterTuningJob(new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHyperparameterTuningJobAsync(new GetHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(HyperparameterTuningJobName name, st::CancellationToken cancellationToken) =>
            GetHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobs(ListHyperparameterTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobsAsync(ListHyperparameterTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// HyperparameterTuningJobs from. Format:
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
        /// <returns>A pageable sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
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
            return ListHyperparameterTuningJobs(request, callSettings);
        }

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// HyperparameterTuningJobs from. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
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
            return ListHyperparameterTuningJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// HyperparameterTuningJobs from. Format:
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
        /// <returns>A pageable sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
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
            return ListHyperparameterTuningJobs(request, callSettings);
        }

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// HyperparameterTuningJobs from. Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHyperparameterTuningJobsRequest request = new ListHyperparameterTuningJobsRequest
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
            return ListHyperparameterTuningJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteHyperparameterTuningJob(DeleteHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(DeleteHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(DeleteHyperparameterTuningJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteHyperparameterTuningJob</c>.</summary>
        public virtual lro::OperationsClient DeleteHyperparameterTuningJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHyperparameterTuningJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteHyperparameterTuningJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHyperparameterTuningJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteHyperparameterTuningJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteHyperparameterTuningJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteHyperparameterTuningJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteHyperparameterTuningJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHyperparameterTuningJob(new DeleteHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHyperparameterTuningJobAsync(new DeleteHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteHyperparameterTuningJob(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHyperparameterTuningJob(new DeleteHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteHyperparameterTuningJobAsync(new DeleteHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(HyperparameterTuningJobName name, st::CancellationToken cancellationToken) =>
            DeleteHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelHyperparameterTuningJob(CancelHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(CancelHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(CancelHyperparameterTuningJobRequest request, st::CancellationToken cancellationToken) =>
            CancelHyperparameterTuningJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelHyperparameterTuningJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelHyperparameterTuningJob(new CancelHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelHyperparameterTuningJobAsync(new CancelHyperparameterTuningJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelHyperparameterTuningJob(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelHyperparameterTuningJob(new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(HyperparameterTuningJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelHyperparameterTuningJobAsync(new CancelHyperparameterTuningJobRequest
            {
                HyperparameterTuningJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the HyperparameterTuningJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/hyperparameterTuningJobs/{hyperparameter_tuning_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelHyperparameterTuningJobAsync(HyperparameterTuningJobName name, st::CancellationToken cancellationToken) =>
            CancelHyperparameterTuningJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob CreateNasJob(CreateNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(CreateNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(CreateNasJobRequest request, st::CancellationToken cancellationToken) =>
            CreateNasJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob CreateNasJob(string parent, NasJob nasJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateNasJob(new CreateNasJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NasJob = gax::GaxPreconditions.CheckNotNull(nasJob, nameof(nasJob)),
            }, callSettings);

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(string parent, NasJob nasJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateNasJobAsync(new CreateNasJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NasJob = gax::GaxPreconditions.CheckNotNull(nasJob, nameof(nasJob)),
            }, callSettings);

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(string parent, NasJob nasJob, st::CancellationToken cancellationToken) =>
            CreateNasJobAsync(parent, nasJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob CreateNasJob(gagr::LocationName parent, NasJob nasJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateNasJob(new CreateNasJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NasJob = gax::GaxPreconditions.CheckNotNull(nasJob, nameof(nasJob)),
            }, callSettings);

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(gagr::LocationName parent, NasJob nasJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateNasJobAsync(new CreateNasJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NasJob = gax::GaxPreconditions.CheckNotNull(nasJob, nameof(nasJob)),
            }, callSettings);

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the NasJob in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="nasJob">
        /// Required. The NasJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> CreateNasJobAsync(gagr::LocationName parent, NasJob nasJob, st::CancellationToken cancellationToken) =>
            CreateNasJobAsync(parent, nasJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob GetNasJob(GetNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(GetNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(GetNasJobRequest request, st::CancellationToken cancellationToken) =>
            GetNasJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob GetNasJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasJob(new GetNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasJobAsync(new GetNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasJob GetNasJob(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasJob(new GetNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasJobAsync(new GetNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasJob> GetNasJobAsync(NasJobName name, st::CancellationToken cancellationToken) =>
            GetNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasJobsResponse, NasJob> ListNasJobs(ListNasJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasJobsResponse, NasJob> ListNasJobsAsync(ListNasJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the NasJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasJobsResponse, NasJob> ListNasJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasJobsRequest request = new ListNasJobsRequest
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
            return ListNasJobs(request, callSettings);
        }

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the NasJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasJobsResponse, NasJob> ListNasJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasJobsRequest request = new ListNasJobsRequest
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
            return ListNasJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the NasJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasJobsResponse, NasJob> ListNasJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasJobsRequest request = new ListNasJobsRequest
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
            return ListNasJobs(request, callSettings);
        }

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the NasJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NasJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasJobsResponse, NasJob> ListNasJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasJobsRequest request = new ListNasJobsRequest
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
            return ListNasJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNasJob(DeleteNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(DeleteNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(DeleteNasJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteNasJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteNasJob</c>.</summary>
        public virtual lro::OperationsClient DeleteNasJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteNasJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteNasJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNasJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteNasJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteNasJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteNasJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNasJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNasJob(new DeleteNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNasJobAsync(new DeleteNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNasJob(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNasJob(new DeleteNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNasJobAsync(new DeleteNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(NasJobName name, st::CancellationToken cancellationToken) =>
            DeleteNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelNasJob(CancelNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(CancelNasJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(CancelNasJobRequest request, st::CancellationToken cancellationToken) =>
            CancelNasJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelNasJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelNasJob(new CancelNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelNasJobAsync(new CancelNasJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelNasJob(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelNasJob(new CancelNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(NasJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelNasJobAsync(new CancelNasJobRequest
            {
                NasJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelNasJobAsync(NasJobName name, st::CancellationToken cancellationToken) =>
            CancelNasJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasTrialDetail GetNasTrialDetail(GetNasTrialDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(GetNasTrialDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(GetNasTrialDetailRequest request, st::CancellationToken cancellationToken) =>
            GetNasTrialDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasTrialDetail GetNasTrialDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasTrialDetail(new GetNasTrialDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasTrialDetailAsync(new GetNasTrialDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetNasTrialDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NasTrialDetail GetNasTrialDetail(NasTrialDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasTrialDetail(new GetNasTrialDetailRequest
            {
                NasTrialDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(NasTrialDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNasTrialDetailAsync(new GetNasTrialDetailRequest
            {
                NasTrialDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the NasTrialDetail resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}/nasTrialDetails/{nas_trial_detail}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NasTrialDetail> GetNasTrialDetailAsync(NasTrialDetailName name, st::CancellationToken cancellationToken) =>
            GetNasTrialDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetails(ListNasTrialDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetailsAsync(ListNasTrialDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
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
        /// <returns>A pageable sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
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
            return ListNasTrialDetails(request, callSettings);
        }

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
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
            return ListNasTrialDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
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
        /// <returns>A pageable sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetails(NasJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
            {
                ParentAsNasJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNasTrialDetails(request, callSettings);
        }

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the NasJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/nasJobs/{nas_job}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetailsAsync(NasJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNasTrialDetailsRequest request = new ListNasTrialDetailsRequest
            {
                ParentAsNasJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNasTrialDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob CreateBatchPredictionJob(CreateBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(CreateBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(CreateBatchPredictionJobRequest request, st::CancellationToken cancellationToken) =>
            CreateBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob CreateBatchPredictionJob(string parent, BatchPredictionJob batchPredictionJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchPredictionJob(new CreateBatchPredictionJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BatchPredictionJob = gax::GaxPreconditions.CheckNotNull(batchPredictionJob, nameof(batchPredictionJob)),
            }, callSettings);

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(string parent, BatchPredictionJob batchPredictionJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchPredictionJobAsync(new CreateBatchPredictionJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BatchPredictionJob = gax::GaxPreconditions.CheckNotNull(batchPredictionJob, nameof(batchPredictionJob)),
            }, callSettings);

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(string parent, BatchPredictionJob batchPredictionJob, st::CancellationToken cancellationToken) =>
            CreateBatchPredictionJobAsync(parent, batchPredictionJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob CreateBatchPredictionJob(gagr::LocationName parent, BatchPredictionJob batchPredictionJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchPredictionJob(new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BatchPredictionJob = gax::GaxPreconditions.CheckNotNull(batchPredictionJob, nameof(batchPredictionJob)),
            }, callSettings);

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(gagr::LocationName parent, BatchPredictionJob batchPredictionJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateBatchPredictionJobAsync(new CreateBatchPredictionJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BatchPredictionJob = gax::GaxPreconditions.CheckNotNull(batchPredictionJob, nameof(batchPredictionJob)),
            }, callSettings);

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// BatchPredictionJob in. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="batchPredictionJob">
        /// Required. The BatchPredictionJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(gagr::LocationName parent, BatchPredictionJob batchPredictionJob, st::CancellationToken cancellationToken) =>
            CreateBatchPredictionJobAsync(parent, batchPredictionJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob GetBatchPredictionJob(GetBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(GetBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(GetBatchPredictionJobRequest request, st::CancellationToken cancellationToken) =>
            GetBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob GetBatchPredictionJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchPredictionJob(new GetBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchPredictionJobAsync(new GetBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchPredictionJob GetBatchPredictionJob(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchPredictionJob(new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBatchPredictionJobAsync(new GetBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(BatchPredictionJobName name, st::CancellationToken cancellationToken) =>
            GetBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobs(ListBatchPredictionJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobsAsync(ListBatchPredictionJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the BatchPredictionJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
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
            return ListBatchPredictionJobs(request, callSettings);
        }

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the BatchPredictionJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
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
            return ListBatchPredictionJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the BatchPredictionJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
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
            return ListBatchPredictionJobs(request, callSettings);
        }

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the BatchPredictionJobs
        /// from. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBatchPredictionJobsRequest request = new ListBatchPredictionJobsRequest
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
            return ListBatchPredictionJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(DeleteBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(DeleteBatchPredictionJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteBatchPredictionJob</c>.</summary>
        public virtual lro::OperationsClient DeleteBatchPredictionJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBatchPredictionJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteBatchPredictionJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBatchPredictionJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteBatchPredictionJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteBatchPredictionJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteBatchPredictionJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteBatchPredictionJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchPredictionJob(new DeleteBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchPredictionJobAsync(new DeleteBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteBatchPredictionJob(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchPredictionJob(new DeleteBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBatchPredictionJobAsync(new DeleteBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(BatchPredictionJobName name, st::CancellationToken cancellationToken) =>
            DeleteBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelBatchPredictionJob(CancelBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(CancelBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(CancelBatchPredictionJobRequest request, st::CancellationToken cancellationToken) =>
            CancelBatchPredictionJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelBatchPredictionJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelBatchPredictionJob(new CancelBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelBatchPredictionJobAsync(new CancelBatchPredictionJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelBatchPredictionJob(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelBatchPredictionJob(new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(BatchPredictionJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelBatchPredictionJobAsync(new CancelBatchPredictionJobRequest
            {
                BatchPredictionJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BatchPredictionJob to cancel.
        /// Format:
        /// `projects/{project}/locations/{location}/batchPredictionJobs/{batch_prediction_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelBatchPredictionJobAsync(BatchPredictionJobName name, st::CancellationToken cancellationToken) =>
            CancelBatchPredictionJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob CreateModelDeploymentMonitoringJob(CreateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(CreateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(CreateModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            CreateModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob CreateModelDeploymentMonitoringJob(string parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelDeploymentMonitoringJob(new CreateModelDeploymentMonitoringJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(string parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelDeploymentMonitoringJobAsync(new CreateModelDeploymentMonitoringJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(string parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, st::CancellationToken cancellationToken) =>
            CreateModelDeploymentMonitoringJobAsync(parent, modelDeploymentMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob CreateModelDeploymentMonitoringJob(gagr::LocationName parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelDeploymentMonitoringJob(new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(gagr::LocationName parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelDeploymentMonitoringJobAsync(new CreateModelDeploymentMonitoringJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
            }, callSettings);

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The ModelDeploymentMonitoringJob to create
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(gagr::LocationName parent, ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, st::CancellationToken cancellationToken) =>
            CreateModelDeploymentMonitoringJobAsync(parent, modelDeploymentMonitoringJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomalies(SearchModelDeploymentMonitoringStatsAnomaliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomaliesAsync(SearchModelDeploymentMonitoringStatsAnomaliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. ModelDeploymentMonitoring Job resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The DeployedModel ID of the
        /// [ModelDeploymentMonitoringObjectiveConfig.deployed_model_id].
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomalies(string modelDeploymentMonitoringJob, string deployedModelId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNullOrEmpty(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelDeploymentMonitoringStatsAnomalies(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. ModelDeploymentMonitoring Job resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The DeployedModel ID of the
        /// [ModelDeploymentMonitoringObjectiveConfig.deployed_model_id].
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomaliesAsync(string modelDeploymentMonitoringJob, string deployedModelId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNullOrEmpty(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelDeploymentMonitoringStatsAnomaliesAsync(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. ModelDeploymentMonitoring Job resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The DeployedModel ID of the
        /// [ModelDeploymentMonitoringObjectiveConfig.deployed_model_id].
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
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomalies(ModelDeploymentMonitoringJobName modelDeploymentMonitoringJob, string deployedModelId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelDeploymentMonitoringStatsAnomalies(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. ModelDeploymentMonitoring Job resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The DeployedModel ID of the
        /// [ModelDeploymentMonitoringObjectiveConfig.deployed_model_id].
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomaliesAsync(ModelDeploymentMonitoringJobName modelDeploymentMonitoringJob, string deployedModelId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchModelDeploymentMonitoringStatsAnomaliesRequest request = new SearchModelDeploymentMonitoringStatsAnomaliesRequest
            {
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchModelDeploymentMonitoringStatsAnomaliesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob GetModelDeploymentMonitoringJob(GetModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(GetModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(GetModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            GetModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob GetModelDeploymentMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelDeploymentMonitoringJob(new GetModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelDeploymentMonitoringJobAsync(new GetModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelDeploymentMonitoringJob GetModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelDeploymentMonitoringJob(new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelDeploymentMonitoringJobAsync(new GetModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, st::CancellationToken cancellationToken) =>
            GetModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobs(ListModelDeploymentMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobsAsync(ListModelDeploymentMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
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
            return ListModelDeploymentMonitoringJobs(request, callSettings);
        }

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
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
            return ListModelDeploymentMonitoringJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
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
            return ListModelDeploymentMonitoringJobs(request, callSettings);
        }

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the ModelDeploymentMonitoringJob.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelDeploymentMonitoringJobsRequest request = new ListModelDeploymentMonitoringJobsRequest
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
            return ListModelDeploymentMonitoringJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> UpdateModelDeploymentMonitoringJob(UpdateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> UpdateModelDeploymentMonitoringJobAsync(UpdateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> UpdateModelDeploymentMonitoringJobAsync(UpdateModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateModelDeploymentMonitoringJob</c>.</summary>
        public virtual lro::OperationsClient UpdateModelDeploymentMonitoringJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateModelDeploymentMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> PollOnceUpdateModelDeploymentMonitoringJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelDeploymentMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateModelDeploymentMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> PollOnceUpdateModelDeploymentMonitoringJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateModelDeploymentMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask is used to specify the fields to be overwritten
        /// in the ModelDeploymentMonitoringJob resource by the update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If the user does
        /// not provide a mask then only the non-empty fields present in the request
        /// will be overwritten. Set the update_mask to `*` to override all fields. For
        /// the objective config, the user can either provide the update mask for
        /// model_deployment_monitoring_objective_configs or any combination of its
        /// nested fields, such as:
        /// model_deployment_monitoring_objective_configs.objective_config.training_dataset.
        /// 
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `model_deployment_monitoring_schedule_config`
        /// * `model_monitoring_alert_config`
        /// * `logging_sampling_strategy`
        /// * `labels`
        /// * `log_ttl`
        /// * `enable_monitoring_pipeline_logs`
        /// .  and
        /// * `model_deployment_monitoring_objective_configs`
        /// .  or
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_dataset`
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_prediction_skew_detection_config`
        /// * `model_deployment_monitoring_objective_configs.objective_config.prediction_drift_detection_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> UpdateModelDeploymentMonitoringJob(ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelDeploymentMonitoringJob(new UpdateModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask is used to specify the fields to be overwritten
        /// in the ModelDeploymentMonitoringJob resource by the update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If the user does
        /// not provide a mask then only the non-empty fields present in the request
        /// will be overwritten. Set the update_mask to `*` to override all fields. For
        /// the objective config, the user can either provide the update mask for
        /// model_deployment_monitoring_objective_configs or any combination of its
        /// nested fields, such as:
        /// model_deployment_monitoring_objective_configs.objective_config.training_dataset.
        /// 
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `model_deployment_monitoring_schedule_config`
        /// * `model_monitoring_alert_config`
        /// * `logging_sampling_strategy`
        /// * `labels`
        /// * `log_ttl`
        /// * `enable_monitoring_pipeline_logs`
        /// .  and
        /// * `model_deployment_monitoring_objective_configs`
        /// .  or
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_dataset`
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_prediction_skew_detection_config`
        /// * `model_deployment_monitoring_objective_configs.objective_config.prediction_drift_detection_config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> UpdateModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelDeploymentMonitoringJobAsync(new UpdateModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJob = gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJob, nameof(modelDeploymentMonitoringJob)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="modelDeploymentMonitoringJob">
        /// Required. The model monitoring configuration which replaces the resource on
        /// the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask is used to specify the fields to be overwritten
        /// in the ModelDeploymentMonitoringJob resource by the update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If the user does
        /// not provide a mask then only the non-empty fields present in the request
        /// will be overwritten. Set the update_mask to `*` to override all fields. For
        /// the objective config, the user can either provide the update mask for
        /// model_deployment_monitoring_objective_configs or any combination of its
        /// nested fields, such as:
        /// model_deployment_monitoring_objective_configs.objective_config.training_dataset.
        /// 
        /// Updatable fields:
        /// 
        /// * `display_name`
        /// * `model_deployment_monitoring_schedule_config`
        /// * `model_monitoring_alert_config`
        /// * `logging_sampling_strategy`
        /// * `labels`
        /// * `log_ttl`
        /// * `enable_monitoring_pipeline_logs`
        /// .  and
        /// * `model_deployment_monitoring_objective_configs`
        /// .  or
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_dataset`
        /// * `model_deployment_monitoring_objective_configs.objective_config.training_prediction_skew_detection_config`
        /// * `model_deployment_monitoring_objective_configs.objective_config.prediction_drift_detection_config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> UpdateModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJob modelDeploymentMonitoringJob, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelDeploymentMonitoringJobAsync(modelDeploymentMonitoringJob, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelDeploymentMonitoringJob(DeleteModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(DeleteModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(DeleteModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModelDeploymentMonitoringJob</c>.</summary>
        public virtual lro::OperationsClient DeleteModelDeploymentMonitoringJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelDeploymentMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteModelDeploymentMonitoringJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelDeploymentMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModelDeploymentMonitoringJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteModelDeploymentMonitoringJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelDeploymentMonitoringJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelDeploymentMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelDeploymentMonitoringJob(new DeleteModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelDeploymentMonitoringJobAsync(new DeleteModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelDeploymentMonitoringJob(new DeleteModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelDeploymentMonitoringJobAsync(new DeleteModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model monitoring job to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, st::CancellationToken cancellationToken) =>
            DeleteModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseModelDeploymentMonitoringJob(PauseModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(PauseModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(PauseModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            PauseModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseModelDeploymentMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelDeploymentMonitoringJob(new PauseModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelDeploymentMonitoringJobAsync(new PauseModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            PauseModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelDeploymentMonitoringJob(new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseModelDeploymentMonitoringJobAsync(new PauseModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to pause.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, st::CancellationToken cancellationToken) =>
            PauseModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeModelDeploymentMonitoringJob(ResumeModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(ResumeModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(ResumeModelDeploymentMonitoringJobRequest request, st::CancellationToken cancellationToken) =>
            ResumeModelDeploymentMonitoringJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeModelDeploymentMonitoringJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModelDeploymentMonitoringJob(new ResumeModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModelDeploymentMonitoringJobAsync(new ResumeModelDeploymentMonitoringJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeModelDeploymentMonitoringJob(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModelDeploymentMonitoringJob(new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeModelDeploymentMonitoringJobAsync(new ResumeModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ModelDeploymentMonitoringJob to resume.
        /// Format:
        /// `projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeModelDeploymentMonitoringJobAsync(ModelDeploymentMonitoringJobName name, st::CancellationToken cancellationToken) =>
            ResumeModelDeploymentMonitoringJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>JobService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for creating and managing Vertex AI's jobs.
    /// </remarks>
    public sealed partial class JobServiceClientImpl : JobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCustomJobRequest, CustomJob> _callCreateCustomJob;

        private readonly gaxgrpc::ApiCall<GetCustomJobRequest, CustomJob> _callGetCustomJob;

        private readonly gaxgrpc::ApiCall<ListCustomJobsRequest, ListCustomJobsResponse> _callListCustomJobs;

        private readonly gaxgrpc::ApiCall<DeleteCustomJobRequest, lro::Operation> _callDeleteCustomJob;

        private readonly gaxgrpc::ApiCall<CancelCustomJobRequest, wkt::Empty> _callCancelCustomJob;

        private readonly gaxgrpc::ApiCall<CreateDataLabelingJobRequest, DataLabelingJob> _callCreateDataLabelingJob;

        private readonly gaxgrpc::ApiCall<GetDataLabelingJobRequest, DataLabelingJob> _callGetDataLabelingJob;

        private readonly gaxgrpc::ApiCall<ListDataLabelingJobsRequest, ListDataLabelingJobsResponse> _callListDataLabelingJobs;

        private readonly gaxgrpc::ApiCall<DeleteDataLabelingJobRequest, lro::Operation> _callDeleteDataLabelingJob;

        private readonly gaxgrpc::ApiCall<CancelDataLabelingJobRequest, wkt::Empty> _callCancelDataLabelingJob;

        private readonly gaxgrpc::ApiCall<CreateHyperparameterTuningJobRequest, HyperparameterTuningJob> _callCreateHyperparameterTuningJob;

        private readonly gaxgrpc::ApiCall<GetHyperparameterTuningJobRequest, HyperparameterTuningJob> _callGetHyperparameterTuningJob;

        private readonly gaxgrpc::ApiCall<ListHyperparameterTuningJobsRequest, ListHyperparameterTuningJobsResponse> _callListHyperparameterTuningJobs;

        private readonly gaxgrpc::ApiCall<DeleteHyperparameterTuningJobRequest, lro::Operation> _callDeleteHyperparameterTuningJob;

        private readonly gaxgrpc::ApiCall<CancelHyperparameterTuningJobRequest, wkt::Empty> _callCancelHyperparameterTuningJob;

        private readonly gaxgrpc::ApiCall<CreateNasJobRequest, NasJob> _callCreateNasJob;

        private readonly gaxgrpc::ApiCall<GetNasJobRequest, NasJob> _callGetNasJob;

        private readonly gaxgrpc::ApiCall<ListNasJobsRequest, ListNasJobsResponse> _callListNasJobs;

        private readonly gaxgrpc::ApiCall<DeleteNasJobRequest, lro::Operation> _callDeleteNasJob;

        private readonly gaxgrpc::ApiCall<CancelNasJobRequest, wkt::Empty> _callCancelNasJob;

        private readonly gaxgrpc::ApiCall<GetNasTrialDetailRequest, NasTrialDetail> _callGetNasTrialDetail;

        private readonly gaxgrpc::ApiCall<ListNasTrialDetailsRequest, ListNasTrialDetailsResponse> _callListNasTrialDetails;

        private readonly gaxgrpc::ApiCall<CreateBatchPredictionJobRequest, BatchPredictionJob> _callCreateBatchPredictionJob;

        private readonly gaxgrpc::ApiCall<GetBatchPredictionJobRequest, BatchPredictionJob> _callGetBatchPredictionJob;

        private readonly gaxgrpc::ApiCall<ListBatchPredictionJobsRequest, ListBatchPredictionJobsResponse> _callListBatchPredictionJobs;

        private readonly gaxgrpc::ApiCall<DeleteBatchPredictionJobRequest, lro::Operation> _callDeleteBatchPredictionJob;

        private readonly gaxgrpc::ApiCall<CancelBatchPredictionJobRequest, wkt::Empty> _callCancelBatchPredictionJob;

        private readonly gaxgrpc::ApiCall<CreateModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob> _callCreateModelDeploymentMonitoringJob;

        private readonly gaxgrpc::ApiCall<SearchModelDeploymentMonitoringStatsAnomaliesRequest, SearchModelDeploymentMonitoringStatsAnomaliesResponse> _callSearchModelDeploymentMonitoringStatsAnomalies;

        private readonly gaxgrpc::ApiCall<GetModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob> _callGetModelDeploymentMonitoringJob;

        private readonly gaxgrpc::ApiCall<ListModelDeploymentMonitoringJobsRequest, ListModelDeploymentMonitoringJobsResponse> _callListModelDeploymentMonitoringJobs;

        private readonly gaxgrpc::ApiCall<UpdateModelDeploymentMonitoringJobRequest, lro::Operation> _callUpdateModelDeploymentMonitoringJob;

        private readonly gaxgrpc::ApiCall<DeleteModelDeploymentMonitoringJobRequest, lro::Operation> _callDeleteModelDeploymentMonitoringJob;

        private readonly gaxgrpc::ApiCall<PauseModelDeploymentMonitoringJobRequest, wkt::Empty> _callPauseModelDeploymentMonitoringJob;

        private readonly gaxgrpc::ApiCall<ResumeModelDeploymentMonitoringJobRequest, wkt::Empty> _callResumeModelDeploymentMonitoringJob;

        /// <summary>
        /// Constructs a client wrapper for the JobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public JobServiceClientImpl(JobService.JobServiceClient grpcClient, JobServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            JobServiceSettings effectiveSettings = settings ?? JobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteCustomJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCustomJobOperationsSettings, logger);
            DeleteDataLabelingJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataLabelingJobOperationsSettings, logger);
            DeleteHyperparameterTuningJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteHyperparameterTuningJobOperationsSettings, logger);
            DeleteNasJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteNasJobOperationsSettings, logger);
            DeleteBatchPredictionJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteBatchPredictionJobOperationsSettings, logger);
            UpdateModelDeploymentMonitoringJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateModelDeploymentMonitoringJobOperationsSettings, logger);
            DeleteModelDeploymentMonitoringJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelDeploymentMonitoringJobOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateCustomJob = clientHelper.BuildApiCall<CreateCustomJobRequest, CustomJob>("CreateCustomJob", grpcClient.CreateCustomJobAsync, grpcClient.CreateCustomJob, effectiveSettings.CreateCustomJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomJob);
            Modify_CreateCustomJobApiCall(ref _callCreateCustomJob);
            _callGetCustomJob = clientHelper.BuildApiCall<GetCustomJobRequest, CustomJob>("GetCustomJob", grpcClient.GetCustomJobAsync, grpcClient.GetCustomJob, effectiveSettings.GetCustomJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomJob);
            Modify_GetCustomJobApiCall(ref _callGetCustomJob);
            _callListCustomJobs = clientHelper.BuildApiCall<ListCustomJobsRequest, ListCustomJobsResponse>("ListCustomJobs", grpcClient.ListCustomJobsAsync, grpcClient.ListCustomJobs, effectiveSettings.ListCustomJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomJobs);
            Modify_ListCustomJobsApiCall(ref _callListCustomJobs);
            _callDeleteCustomJob = clientHelper.BuildApiCall<DeleteCustomJobRequest, lro::Operation>("DeleteCustomJob", grpcClient.DeleteCustomJobAsync, grpcClient.DeleteCustomJob, effectiveSettings.DeleteCustomJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomJob);
            Modify_DeleteCustomJobApiCall(ref _callDeleteCustomJob);
            _callCancelCustomJob = clientHelper.BuildApiCall<CancelCustomJobRequest, wkt::Empty>("CancelCustomJob", grpcClient.CancelCustomJobAsync, grpcClient.CancelCustomJob, effectiveSettings.CancelCustomJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelCustomJob);
            Modify_CancelCustomJobApiCall(ref _callCancelCustomJob);
            _callCreateDataLabelingJob = clientHelper.BuildApiCall<CreateDataLabelingJobRequest, DataLabelingJob>("CreateDataLabelingJob", grpcClient.CreateDataLabelingJobAsync, grpcClient.CreateDataLabelingJob, effectiveSettings.CreateDataLabelingJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataLabelingJob);
            Modify_CreateDataLabelingJobApiCall(ref _callCreateDataLabelingJob);
            _callGetDataLabelingJob = clientHelper.BuildApiCall<GetDataLabelingJobRequest, DataLabelingJob>("GetDataLabelingJob", grpcClient.GetDataLabelingJobAsync, grpcClient.GetDataLabelingJob, effectiveSettings.GetDataLabelingJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataLabelingJob);
            Modify_GetDataLabelingJobApiCall(ref _callGetDataLabelingJob);
            _callListDataLabelingJobs = clientHelper.BuildApiCall<ListDataLabelingJobsRequest, ListDataLabelingJobsResponse>("ListDataLabelingJobs", grpcClient.ListDataLabelingJobsAsync, grpcClient.ListDataLabelingJobs, effectiveSettings.ListDataLabelingJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataLabelingJobs);
            Modify_ListDataLabelingJobsApiCall(ref _callListDataLabelingJobs);
            _callDeleteDataLabelingJob = clientHelper.BuildApiCall<DeleteDataLabelingJobRequest, lro::Operation>("DeleteDataLabelingJob", grpcClient.DeleteDataLabelingJobAsync, grpcClient.DeleteDataLabelingJob, effectiveSettings.DeleteDataLabelingJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataLabelingJob);
            Modify_DeleteDataLabelingJobApiCall(ref _callDeleteDataLabelingJob);
            _callCancelDataLabelingJob = clientHelper.BuildApiCall<CancelDataLabelingJobRequest, wkt::Empty>("CancelDataLabelingJob", grpcClient.CancelDataLabelingJobAsync, grpcClient.CancelDataLabelingJob, effectiveSettings.CancelDataLabelingJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelDataLabelingJob);
            Modify_CancelDataLabelingJobApiCall(ref _callCancelDataLabelingJob);
            _callCreateHyperparameterTuningJob = clientHelper.BuildApiCall<CreateHyperparameterTuningJobRequest, HyperparameterTuningJob>("CreateHyperparameterTuningJob", grpcClient.CreateHyperparameterTuningJobAsync, grpcClient.CreateHyperparameterTuningJob, effectiveSettings.CreateHyperparameterTuningJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateHyperparameterTuningJob);
            Modify_CreateHyperparameterTuningJobApiCall(ref _callCreateHyperparameterTuningJob);
            _callGetHyperparameterTuningJob = clientHelper.BuildApiCall<GetHyperparameterTuningJobRequest, HyperparameterTuningJob>("GetHyperparameterTuningJob", grpcClient.GetHyperparameterTuningJobAsync, grpcClient.GetHyperparameterTuningJob, effectiveSettings.GetHyperparameterTuningJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHyperparameterTuningJob);
            Modify_GetHyperparameterTuningJobApiCall(ref _callGetHyperparameterTuningJob);
            _callListHyperparameterTuningJobs = clientHelper.BuildApiCall<ListHyperparameterTuningJobsRequest, ListHyperparameterTuningJobsResponse>("ListHyperparameterTuningJobs", grpcClient.ListHyperparameterTuningJobsAsync, grpcClient.ListHyperparameterTuningJobs, effectiveSettings.ListHyperparameterTuningJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListHyperparameterTuningJobs);
            Modify_ListHyperparameterTuningJobsApiCall(ref _callListHyperparameterTuningJobs);
            _callDeleteHyperparameterTuningJob = clientHelper.BuildApiCall<DeleteHyperparameterTuningJobRequest, lro::Operation>("DeleteHyperparameterTuningJob", grpcClient.DeleteHyperparameterTuningJobAsync, grpcClient.DeleteHyperparameterTuningJob, effectiveSettings.DeleteHyperparameterTuningJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteHyperparameterTuningJob);
            Modify_DeleteHyperparameterTuningJobApiCall(ref _callDeleteHyperparameterTuningJob);
            _callCancelHyperparameterTuningJob = clientHelper.BuildApiCall<CancelHyperparameterTuningJobRequest, wkt::Empty>("CancelHyperparameterTuningJob", grpcClient.CancelHyperparameterTuningJobAsync, grpcClient.CancelHyperparameterTuningJob, effectiveSettings.CancelHyperparameterTuningJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelHyperparameterTuningJob);
            Modify_CancelHyperparameterTuningJobApiCall(ref _callCancelHyperparameterTuningJob);
            _callCreateNasJob = clientHelper.BuildApiCall<CreateNasJobRequest, NasJob>("CreateNasJob", grpcClient.CreateNasJobAsync, grpcClient.CreateNasJob, effectiveSettings.CreateNasJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNasJob);
            Modify_CreateNasJobApiCall(ref _callCreateNasJob);
            _callGetNasJob = clientHelper.BuildApiCall<GetNasJobRequest, NasJob>("GetNasJob", grpcClient.GetNasJobAsync, grpcClient.GetNasJob, effectiveSettings.GetNasJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNasJob);
            Modify_GetNasJobApiCall(ref _callGetNasJob);
            _callListNasJobs = clientHelper.BuildApiCall<ListNasJobsRequest, ListNasJobsResponse>("ListNasJobs", grpcClient.ListNasJobsAsync, grpcClient.ListNasJobs, effectiveSettings.ListNasJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNasJobs);
            Modify_ListNasJobsApiCall(ref _callListNasJobs);
            _callDeleteNasJob = clientHelper.BuildApiCall<DeleteNasJobRequest, lro::Operation>("DeleteNasJob", grpcClient.DeleteNasJobAsync, grpcClient.DeleteNasJob, effectiveSettings.DeleteNasJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNasJob);
            Modify_DeleteNasJobApiCall(ref _callDeleteNasJob);
            _callCancelNasJob = clientHelper.BuildApiCall<CancelNasJobRequest, wkt::Empty>("CancelNasJob", grpcClient.CancelNasJobAsync, grpcClient.CancelNasJob, effectiveSettings.CancelNasJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelNasJob);
            Modify_CancelNasJobApiCall(ref _callCancelNasJob);
            _callGetNasTrialDetail = clientHelper.BuildApiCall<GetNasTrialDetailRequest, NasTrialDetail>("GetNasTrialDetail", grpcClient.GetNasTrialDetailAsync, grpcClient.GetNasTrialDetail, effectiveSettings.GetNasTrialDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNasTrialDetail);
            Modify_GetNasTrialDetailApiCall(ref _callGetNasTrialDetail);
            _callListNasTrialDetails = clientHelper.BuildApiCall<ListNasTrialDetailsRequest, ListNasTrialDetailsResponse>("ListNasTrialDetails", grpcClient.ListNasTrialDetailsAsync, grpcClient.ListNasTrialDetails, effectiveSettings.ListNasTrialDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNasTrialDetails);
            Modify_ListNasTrialDetailsApiCall(ref _callListNasTrialDetails);
            _callCreateBatchPredictionJob = clientHelper.BuildApiCall<CreateBatchPredictionJobRequest, BatchPredictionJob>("CreateBatchPredictionJob", grpcClient.CreateBatchPredictionJobAsync, grpcClient.CreateBatchPredictionJob, effectiveSettings.CreateBatchPredictionJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBatchPredictionJob);
            Modify_CreateBatchPredictionJobApiCall(ref _callCreateBatchPredictionJob);
            _callGetBatchPredictionJob = clientHelper.BuildApiCall<GetBatchPredictionJobRequest, BatchPredictionJob>("GetBatchPredictionJob", grpcClient.GetBatchPredictionJobAsync, grpcClient.GetBatchPredictionJob, effectiveSettings.GetBatchPredictionJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBatchPredictionJob);
            Modify_GetBatchPredictionJobApiCall(ref _callGetBatchPredictionJob);
            _callListBatchPredictionJobs = clientHelper.BuildApiCall<ListBatchPredictionJobsRequest, ListBatchPredictionJobsResponse>("ListBatchPredictionJobs", grpcClient.ListBatchPredictionJobsAsync, grpcClient.ListBatchPredictionJobs, effectiveSettings.ListBatchPredictionJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBatchPredictionJobs);
            Modify_ListBatchPredictionJobsApiCall(ref _callListBatchPredictionJobs);
            _callDeleteBatchPredictionJob = clientHelper.BuildApiCall<DeleteBatchPredictionJobRequest, lro::Operation>("DeleteBatchPredictionJob", grpcClient.DeleteBatchPredictionJobAsync, grpcClient.DeleteBatchPredictionJob, effectiveSettings.DeleteBatchPredictionJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBatchPredictionJob);
            Modify_DeleteBatchPredictionJobApiCall(ref _callDeleteBatchPredictionJob);
            _callCancelBatchPredictionJob = clientHelper.BuildApiCall<CancelBatchPredictionJobRequest, wkt::Empty>("CancelBatchPredictionJob", grpcClient.CancelBatchPredictionJobAsync, grpcClient.CancelBatchPredictionJob, effectiveSettings.CancelBatchPredictionJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelBatchPredictionJob);
            Modify_CancelBatchPredictionJobApiCall(ref _callCancelBatchPredictionJob);
            _callCreateModelDeploymentMonitoringJob = clientHelper.BuildApiCall<CreateModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob>("CreateModelDeploymentMonitoringJob", grpcClient.CreateModelDeploymentMonitoringJobAsync, grpcClient.CreateModelDeploymentMonitoringJob, effectiveSettings.CreateModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModelDeploymentMonitoringJob);
            Modify_CreateModelDeploymentMonitoringJobApiCall(ref _callCreateModelDeploymentMonitoringJob);
            _callSearchModelDeploymentMonitoringStatsAnomalies = clientHelper.BuildApiCall<SearchModelDeploymentMonitoringStatsAnomaliesRequest, SearchModelDeploymentMonitoringStatsAnomaliesResponse>("SearchModelDeploymentMonitoringStatsAnomalies", grpcClient.SearchModelDeploymentMonitoringStatsAnomaliesAsync, grpcClient.SearchModelDeploymentMonitoringStatsAnomalies, effectiveSettings.SearchModelDeploymentMonitoringStatsAnomaliesSettings).WithGoogleRequestParam("model_deployment_monitoring_job", request => request.ModelDeploymentMonitoringJob);
            Modify_ApiCall(ref _callSearchModelDeploymentMonitoringStatsAnomalies);
            Modify_SearchModelDeploymentMonitoringStatsAnomaliesApiCall(ref _callSearchModelDeploymentMonitoringStatsAnomalies);
            _callGetModelDeploymentMonitoringJob = clientHelper.BuildApiCall<GetModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob>("GetModelDeploymentMonitoringJob", grpcClient.GetModelDeploymentMonitoringJobAsync, grpcClient.GetModelDeploymentMonitoringJob, effectiveSettings.GetModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelDeploymentMonitoringJob);
            Modify_GetModelDeploymentMonitoringJobApiCall(ref _callGetModelDeploymentMonitoringJob);
            _callListModelDeploymentMonitoringJobs = clientHelper.BuildApiCall<ListModelDeploymentMonitoringJobsRequest, ListModelDeploymentMonitoringJobsResponse>("ListModelDeploymentMonitoringJobs", grpcClient.ListModelDeploymentMonitoringJobsAsync, grpcClient.ListModelDeploymentMonitoringJobs, effectiveSettings.ListModelDeploymentMonitoringJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelDeploymentMonitoringJobs);
            Modify_ListModelDeploymentMonitoringJobsApiCall(ref _callListModelDeploymentMonitoringJobs);
            _callUpdateModelDeploymentMonitoringJob = clientHelper.BuildApiCall<UpdateModelDeploymentMonitoringJobRequest, lro::Operation>("UpdateModelDeploymentMonitoringJob", grpcClient.UpdateModelDeploymentMonitoringJobAsync, grpcClient.UpdateModelDeploymentMonitoringJob, effectiveSettings.UpdateModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("model_deployment_monitoring_job.name", request => request.ModelDeploymentMonitoringJob?.Name);
            Modify_ApiCall(ref _callUpdateModelDeploymentMonitoringJob);
            Modify_UpdateModelDeploymentMonitoringJobApiCall(ref _callUpdateModelDeploymentMonitoringJob);
            _callDeleteModelDeploymentMonitoringJob = clientHelper.BuildApiCall<DeleteModelDeploymentMonitoringJobRequest, lro::Operation>("DeleteModelDeploymentMonitoringJob", grpcClient.DeleteModelDeploymentMonitoringJobAsync, grpcClient.DeleteModelDeploymentMonitoringJob, effectiveSettings.DeleteModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModelDeploymentMonitoringJob);
            Modify_DeleteModelDeploymentMonitoringJobApiCall(ref _callDeleteModelDeploymentMonitoringJob);
            _callPauseModelDeploymentMonitoringJob = clientHelper.BuildApiCall<PauseModelDeploymentMonitoringJobRequest, wkt::Empty>("PauseModelDeploymentMonitoringJob", grpcClient.PauseModelDeploymentMonitoringJobAsync, grpcClient.PauseModelDeploymentMonitoringJob, effectiveSettings.PauseModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseModelDeploymentMonitoringJob);
            Modify_PauseModelDeploymentMonitoringJobApiCall(ref _callPauseModelDeploymentMonitoringJob);
            _callResumeModelDeploymentMonitoringJob = clientHelper.BuildApiCall<ResumeModelDeploymentMonitoringJobRequest, wkt::Empty>("ResumeModelDeploymentMonitoringJob", grpcClient.ResumeModelDeploymentMonitoringJobAsync, grpcClient.ResumeModelDeploymentMonitoringJob, effectiveSettings.ResumeModelDeploymentMonitoringJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeModelDeploymentMonitoringJob);
            Modify_ResumeModelDeploymentMonitoringJobApiCall(ref _callResumeModelDeploymentMonitoringJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCustomJobApiCall(ref gaxgrpc::ApiCall<CreateCustomJobRequest, CustomJob> call);

        partial void Modify_GetCustomJobApiCall(ref gaxgrpc::ApiCall<GetCustomJobRequest, CustomJob> call);

        partial void Modify_ListCustomJobsApiCall(ref gaxgrpc::ApiCall<ListCustomJobsRequest, ListCustomJobsResponse> call);

        partial void Modify_DeleteCustomJobApiCall(ref gaxgrpc::ApiCall<DeleteCustomJobRequest, lro::Operation> call);

        partial void Modify_CancelCustomJobApiCall(ref gaxgrpc::ApiCall<CancelCustomJobRequest, wkt::Empty> call);

        partial void Modify_CreateDataLabelingJobApiCall(ref gaxgrpc::ApiCall<CreateDataLabelingJobRequest, DataLabelingJob> call);

        partial void Modify_GetDataLabelingJobApiCall(ref gaxgrpc::ApiCall<GetDataLabelingJobRequest, DataLabelingJob> call);

        partial void Modify_ListDataLabelingJobsApiCall(ref gaxgrpc::ApiCall<ListDataLabelingJobsRequest, ListDataLabelingJobsResponse> call);

        partial void Modify_DeleteDataLabelingJobApiCall(ref gaxgrpc::ApiCall<DeleteDataLabelingJobRequest, lro::Operation> call);

        partial void Modify_CancelDataLabelingJobApiCall(ref gaxgrpc::ApiCall<CancelDataLabelingJobRequest, wkt::Empty> call);

        partial void Modify_CreateHyperparameterTuningJobApiCall(ref gaxgrpc::ApiCall<CreateHyperparameterTuningJobRequest, HyperparameterTuningJob> call);

        partial void Modify_GetHyperparameterTuningJobApiCall(ref gaxgrpc::ApiCall<GetHyperparameterTuningJobRequest, HyperparameterTuningJob> call);

        partial void Modify_ListHyperparameterTuningJobsApiCall(ref gaxgrpc::ApiCall<ListHyperparameterTuningJobsRequest, ListHyperparameterTuningJobsResponse> call);

        partial void Modify_DeleteHyperparameterTuningJobApiCall(ref gaxgrpc::ApiCall<DeleteHyperparameterTuningJobRequest, lro::Operation> call);

        partial void Modify_CancelHyperparameterTuningJobApiCall(ref gaxgrpc::ApiCall<CancelHyperparameterTuningJobRequest, wkt::Empty> call);

        partial void Modify_CreateNasJobApiCall(ref gaxgrpc::ApiCall<CreateNasJobRequest, NasJob> call);

        partial void Modify_GetNasJobApiCall(ref gaxgrpc::ApiCall<GetNasJobRequest, NasJob> call);

        partial void Modify_ListNasJobsApiCall(ref gaxgrpc::ApiCall<ListNasJobsRequest, ListNasJobsResponse> call);

        partial void Modify_DeleteNasJobApiCall(ref gaxgrpc::ApiCall<DeleteNasJobRequest, lro::Operation> call);

        partial void Modify_CancelNasJobApiCall(ref gaxgrpc::ApiCall<CancelNasJobRequest, wkt::Empty> call);

        partial void Modify_GetNasTrialDetailApiCall(ref gaxgrpc::ApiCall<GetNasTrialDetailRequest, NasTrialDetail> call);

        partial void Modify_ListNasTrialDetailsApiCall(ref gaxgrpc::ApiCall<ListNasTrialDetailsRequest, ListNasTrialDetailsResponse> call);

        partial void Modify_CreateBatchPredictionJobApiCall(ref gaxgrpc::ApiCall<CreateBatchPredictionJobRequest, BatchPredictionJob> call);

        partial void Modify_GetBatchPredictionJobApiCall(ref gaxgrpc::ApiCall<GetBatchPredictionJobRequest, BatchPredictionJob> call);

        partial void Modify_ListBatchPredictionJobsApiCall(ref gaxgrpc::ApiCall<ListBatchPredictionJobsRequest, ListBatchPredictionJobsResponse> call);

        partial void Modify_DeleteBatchPredictionJobApiCall(ref gaxgrpc::ApiCall<DeleteBatchPredictionJobRequest, lro::Operation> call);

        partial void Modify_CancelBatchPredictionJobApiCall(ref gaxgrpc::ApiCall<CancelBatchPredictionJobRequest, wkt::Empty> call);

        partial void Modify_CreateModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<CreateModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob> call);

        partial void Modify_SearchModelDeploymentMonitoringStatsAnomaliesApiCall(ref gaxgrpc::ApiCall<SearchModelDeploymentMonitoringStatsAnomaliesRequest, SearchModelDeploymentMonitoringStatsAnomaliesResponse> call);

        partial void Modify_GetModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<GetModelDeploymentMonitoringJobRequest, ModelDeploymentMonitoringJob> call);

        partial void Modify_ListModelDeploymentMonitoringJobsApiCall(ref gaxgrpc::ApiCall<ListModelDeploymentMonitoringJobsRequest, ListModelDeploymentMonitoringJobsResponse> call);

        partial void Modify_UpdateModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<UpdateModelDeploymentMonitoringJobRequest, lro::Operation> call);

        partial void Modify_DeleteModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<DeleteModelDeploymentMonitoringJobRequest, lro::Operation> call);

        partial void Modify_PauseModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<PauseModelDeploymentMonitoringJobRequest, wkt::Empty> call);

        partial void Modify_ResumeModelDeploymentMonitoringJobApiCall(ref gaxgrpc::ApiCall<ResumeModelDeploymentMonitoringJobRequest, wkt::Empty> call);

        partial void OnConstruction(JobService.JobServiceClient grpcClient, JobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC JobService client</summary>
        public override JobService.JobServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateCustomJobRequest(ref CreateCustomJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomJobRequest(ref GetCustomJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomJobsRequest(ref ListCustomJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomJobRequest(ref DeleteCustomJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelCustomJobRequest(ref CancelCustomJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataLabelingJobRequest(ref CreateDataLabelingJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataLabelingJobRequest(ref GetDataLabelingJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataLabelingJobsRequest(ref ListDataLabelingJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataLabelingJobRequest(ref DeleteDataLabelingJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelDataLabelingJobRequest(ref CancelDataLabelingJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateHyperparameterTuningJobRequest(ref CreateHyperparameterTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetHyperparameterTuningJobRequest(ref GetHyperparameterTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHyperparameterTuningJobsRequest(ref ListHyperparameterTuningJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteHyperparameterTuningJobRequest(ref DeleteHyperparameterTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelHyperparameterTuningJobRequest(ref CancelHyperparameterTuningJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNasJobRequest(ref CreateNasJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNasJobRequest(ref GetNasJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNasJobsRequest(ref ListNasJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNasJobRequest(ref DeleteNasJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelNasJobRequest(ref CancelNasJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNasTrialDetailRequest(ref GetNasTrialDetailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNasTrialDetailsRequest(ref ListNasTrialDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBatchPredictionJobRequest(ref CreateBatchPredictionJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBatchPredictionJobRequest(ref GetBatchPredictionJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBatchPredictionJobsRequest(ref ListBatchPredictionJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBatchPredictionJobRequest(ref DeleteBatchPredictionJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelBatchPredictionJobRequest(ref CancelBatchPredictionJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateModelDeploymentMonitoringJobRequest(ref CreateModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchModelDeploymentMonitoringStatsAnomaliesRequest(ref SearchModelDeploymentMonitoringStatsAnomaliesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelDeploymentMonitoringJobRequest(ref GetModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelDeploymentMonitoringJobsRequest(ref ListModelDeploymentMonitoringJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelDeploymentMonitoringJobRequest(ref UpdateModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelDeploymentMonitoringJobRequest(ref DeleteModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseModelDeploymentMonitoringJobRequest(ref PauseModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeModelDeploymentMonitoringJobRequest(ref ResumeModelDeploymentMonitoringJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomJob CreateCustomJob(CreateCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomJobRequest(ref request, ref callSettings);
            return _callCreateCustomJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomJob. A created CustomJob right away
        /// will be attempted to be run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomJob> CreateCustomJobAsync(CreateCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomJobRequest(ref request, ref callSettings);
            return _callCreateCustomJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomJob GetCustomJob(GetCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomJobRequest(ref request, ref callSettings);
            return _callGetCustomJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomJob> GetCustomJobAsync(GetCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomJobRequest(ref request, ref callSettings);
            return _callGetCustomJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobs(ListCustomJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomJobsRequest, ListCustomJobsResponse, CustomJob>(_callListCustomJobs, request, callSettings);
        }

        /// <summary>
        /// Lists CustomJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomJobsResponse, CustomJob> ListCustomJobsAsync(ListCustomJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomJobsRequest, ListCustomJobsResponse, CustomJob>(_callListCustomJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCustomJob</c>.</summary>
        public override lro::OperationsClient DeleteCustomJobOperationsClient { get; }

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteCustomJob(DeleteCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteCustomJob.Sync(request, callSettings), DeleteCustomJobOperationsClient);
        }

        /// <summary>
        /// Deletes a CustomJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteCustomJobAsync(DeleteCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteCustomJob.Async(request, callSettings).ConfigureAwait(false), DeleteCustomJobOperationsClient);
        }

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelCustomJob(CancelCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCustomJobRequest(ref request, ref callSettings);
            _callCancelCustomJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a CustomJob.
        /// Starts asynchronous cancellation on the CustomJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetCustomJob][google.cloud.aiplatform.v1.JobService.GetCustomJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the CustomJob is not deleted; instead it becomes a job with
        /// a [CustomJob.error][google.cloud.aiplatform.v1.CustomJob.error] value with
        /// a [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [CustomJob.state][google.cloud.aiplatform.v1.CustomJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelCustomJobAsync(CancelCustomJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelCustomJobRequest(ref request, ref callSettings);
            return _callCancelCustomJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataLabelingJob CreateDataLabelingJob(CreateDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataLabelingJobRequest(ref request, ref callSettings);
            return _callCreateDataLabelingJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataLabelingJob> CreateDataLabelingJobAsync(CreateDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataLabelingJobRequest(ref request, ref callSettings);
            return _callCreateDataLabelingJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataLabelingJob GetDataLabelingJob(GetDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataLabelingJobRequest(ref request, ref callSettings);
            return _callGetDataLabelingJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataLabelingJob> GetDataLabelingJobAsync(GetDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataLabelingJobRequest(ref request, ref callSettings);
            return _callGetDataLabelingJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobs(ListDataLabelingJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataLabelingJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataLabelingJobsRequest, ListDataLabelingJobsResponse, DataLabelingJob>(_callListDataLabelingJobs, request, callSettings);
        }

        /// <summary>
        /// Lists DataLabelingJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataLabelingJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataLabelingJobsResponse, DataLabelingJob> ListDataLabelingJobsAsync(ListDataLabelingJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataLabelingJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataLabelingJobsRequest, ListDataLabelingJobsResponse, DataLabelingJob>(_callListDataLabelingJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteDataLabelingJob</c>.</summary>
        public override lro::OperationsClient DeleteDataLabelingJobOperationsClient { get; }

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteDataLabelingJob(DeleteDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataLabelingJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteDataLabelingJob.Sync(request, callSettings), DeleteDataLabelingJobOperationsClient);
        }

        /// <summary>
        /// Deletes a DataLabelingJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteDataLabelingJobAsync(DeleteDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataLabelingJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteDataLabelingJob.Async(request, callSettings).ConfigureAwait(false), DeleteDataLabelingJobOperationsClient);
        }

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelDataLabelingJob(CancelDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDataLabelingJobRequest(ref request, ref callSettings);
            _callCancelDataLabelingJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a DataLabelingJob. Success of cancellation is not guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelDataLabelingJobAsync(CancelDataLabelingJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDataLabelingJobRequest(ref request, ref callSettings);
            return _callCancelDataLabelingJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HyperparameterTuningJob CreateHyperparameterTuningJob(CreateHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHyperparameterTuningJobRequest(ref request, ref callSettings);
            return _callCreateHyperparameterTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HyperparameterTuningJob> CreateHyperparameterTuningJobAsync(CreateHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateHyperparameterTuningJobRequest(ref request, ref callSettings);
            return _callCreateHyperparameterTuningJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HyperparameterTuningJob GetHyperparameterTuningJob(GetHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHyperparameterTuningJobRequest(ref request, ref callSettings);
            return _callGetHyperparameterTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a HyperparameterTuningJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HyperparameterTuningJob> GetHyperparameterTuningJobAsync(GetHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHyperparameterTuningJobRequest(ref request, ref callSettings);
            return _callGetHyperparameterTuningJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobs(ListHyperparameterTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHyperparameterTuningJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHyperparameterTuningJobsRequest, ListHyperparameterTuningJobsResponse, HyperparameterTuningJob>(_callListHyperparameterTuningJobs, request, callSettings);
        }

        /// <summary>
        /// Lists HyperparameterTuningJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="HyperparameterTuningJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListHyperparameterTuningJobsResponse, HyperparameterTuningJob> ListHyperparameterTuningJobsAsync(ListHyperparameterTuningJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHyperparameterTuningJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHyperparameterTuningJobsRequest, ListHyperparameterTuningJobsResponse, HyperparameterTuningJob>(_callListHyperparameterTuningJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteHyperparameterTuningJob</c>.</summary>
        public override lro::OperationsClient DeleteHyperparameterTuningJobOperationsClient { get; }

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteHyperparameterTuningJob(DeleteHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHyperparameterTuningJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteHyperparameterTuningJob.Sync(request, callSettings), DeleteHyperparameterTuningJobOperationsClient);
        }

        /// <summary>
        /// Deletes a HyperparameterTuningJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteHyperparameterTuningJobAsync(DeleteHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteHyperparameterTuningJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteHyperparameterTuningJob.Async(request, callSettings).ConfigureAwait(false), DeleteHyperparameterTuningJobOperationsClient);
        }

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelHyperparameterTuningJob(CancelHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelHyperparameterTuningJobRequest(ref request, ref callSettings);
            _callCancelHyperparameterTuningJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a HyperparameterTuningJob.
        /// Starts asynchronous cancellation on the HyperparameterTuningJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetHyperparameterTuningJob][google.cloud.aiplatform.v1.JobService.GetHyperparameterTuningJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the HyperparameterTuningJob is not deleted; instead it becomes a job with
        /// a
        /// [HyperparameterTuningJob.error][google.cloud.aiplatform.v1.HyperparameterTuningJob.error]
        /// value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
        /// corresponding to `Code.CANCELLED`, and
        /// [HyperparameterTuningJob.state][google.cloud.aiplatform.v1.HyperparameterTuningJob.state]
        /// is set to `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelHyperparameterTuningJobAsync(CancelHyperparameterTuningJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelHyperparameterTuningJobRequest(ref request, ref callSettings);
            return _callCancelHyperparameterTuningJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NasJob CreateNasJob(CreateNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNasJobRequest(ref request, ref callSettings);
            return _callCreateNasJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NasJob> CreateNasJobAsync(CreateNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNasJobRequest(ref request, ref callSettings);
            return _callCreateNasJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NasJob GetNasJob(GetNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNasJobRequest(ref request, ref callSettings);
            return _callGetNasJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a NasJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NasJob> GetNasJobAsync(GetNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNasJobRequest(ref request, ref callSettings);
            return _callGetNasJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NasJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListNasJobsResponse, NasJob> ListNasJobs(ListNasJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNasJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNasJobsRequest, ListNasJobsResponse, NasJob>(_callListNasJobs, request, callSettings);
        }

        /// <summary>
        /// Lists NasJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NasJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNasJobsResponse, NasJob> ListNasJobsAsync(ListNasJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNasJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNasJobsRequest, ListNasJobsResponse, NasJob>(_callListNasJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteNasJob</c>.</summary>
        public override lro::OperationsClient DeleteNasJobOperationsClient { get; }

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteNasJob(DeleteNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNasJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteNasJob.Sync(request, callSettings), DeleteNasJobOperationsClient);
        }

        /// <summary>
        /// Deletes a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteNasJobAsync(DeleteNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNasJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteNasJob.Async(request, callSettings).ConfigureAwait(false), DeleteNasJobOperationsClient);
        }

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelNasJob(CancelNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelNasJobRequest(ref request, ref callSettings);
            _callCancelNasJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a NasJob.
        /// Starts asynchronous cancellation on the NasJob. The server
        /// makes a best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetNasJob][google.cloud.aiplatform.v1.JobService.GetNasJob] or
        /// other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On successful cancellation,
        /// the NasJob is not deleted; instead it becomes a job with
        /// a [NasJob.error][google.cloud.aiplatform.v1.NasJob.error] value with a
        /// [google.rpc.Status.code][google.rpc.Status.code] of 1, corresponding to
        /// `Code.CANCELLED`, and
        /// [NasJob.state][google.cloud.aiplatform.v1.NasJob.state] is set to
        /// `CANCELLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelNasJobAsync(CancelNasJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelNasJobRequest(ref request, ref callSettings);
            return _callCancelNasJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NasTrialDetail GetNasTrialDetail(GetNasTrialDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNasTrialDetailRequest(ref request, ref callSettings);
            return _callGetNasTrialDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a NasTrialDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NasTrialDetail> GetNasTrialDetailAsync(GetNasTrialDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNasTrialDetailRequest(ref request, ref callSettings);
            return _callGetNasTrialDetail.Async(request, callSettings);
        }

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetails(ListNasTrialDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNasTrialDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNasTrialDetailsRequest, ListNasTrialDetailsResponse, NasTrialDetail>(_callListNasTrialDetails, request, callSettings);
        }

        /// <summary>
        /// List top NasTrialDetails of a NasJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NasTrialDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNasTrialDetailsResponse, NasTrialDetail> ListNasTrialDetailsAsync(ListNasTrialDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNasTrialDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNasTrialDetailsRequest, ListNasTrialDetailsResponse, NasTrialDetail>(_callListNasTrialDetails, request, callSettings);
        }

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPredictionJob CreateBatchPredictionJob(CreateBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBatchPredictionJobRequest(ref request, ref callSettings);
            return _callCreateBatchPredictionJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a BatchPredictionJob. A BatchPredictionJob once created will
        /// right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPredictionJob> CreateBatchPredictionJobAsync(CreateBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBatchPredictionJobRequest(ref request, ref callSettings);
            return _callCreateBatchPredictionJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchPredictionJob GetBatchPredictionJob(GetBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBatchPredictionJobRequest(ref request, ref callSettings);
            return _callGetBatchPredictionJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a BatchPredictionJob
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchPredictionJob> GetBatchPredictionJobAsync(GetBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBatchPredictionJobRequest(ref request, ref callSettings);
            return _callGetBatchPredictionJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobs(ListBatchPredictionJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchPredictionJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBatchPredictionJobsRequest, ListBatchPredictionJobsResponse, BatchPredictionJob>(_callListBatchPredictionJobs, request, callSettings);
        }

        /// <summary>
        /// Lists BatchPredictionJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BatchPredictionJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBatchPredictionJobsResponse, BatchPredictionJob> ListBatchPredictionJobsAsync(ListBatchPredictionJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchPredictionJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBatchPredictionJobsRequest, ListBatchPredictionJobsResponse, BatchPredictionJob>(_callListBatchPredictionJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteBatchPredictionJob</c>.</summary>
        public override lro::OperationsClient DeleteBatchPredictionJobOperationsClient { get; }

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBatchPredictionJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteBatchPredictionJob.Sync(request, callSettings), DeleteBatchPredictionJobOperationsClient);
        }

        /// <summary>
        /// Deletes a BatchPredictionJob. Can only be called on jobs that already
        /// finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteBatchPredictionJobAsync(DeleteBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBatchPredictionJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteBatchPredictionJob.Async(request, callSettings).ConfigureAwait(false), DeleteBatchPredictionJobOperationsClient);
        }

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelBatchPredictionJob(CancelBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelBatchPredictionJobRequest(ref request, ref callSettings);
            _callCancelBatchPredictionJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a BatchPredictionJob.
        /// 
        /// Starts asynchronous cancellation on the BatchPredictionJob. The server
        /// makes the best effort to cancel the job, but success is not
        /// guaranteed. Clients can use
        /// [JobService.GetBatchPredictionJob][google.cloud.aiplatform.v1.JobService.GetBatchPredictionJob]
        /// or other methods to check whether the cancellation succeeded or whether the
        /// job completed despite cancellation. On a successful cancellation,
        /// the BatchPredictionJob is not deleted;instead its
        /// [BatchPredictionJob.state][google.cloud.aiplatform.v1.BatchPredictionJob.state]
        /// is set to `CANCELLED`. Any files already outputted by the job are not
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelBatchPredictionJobAsync(CancelBatchPredictionJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelBatchPredictionJobRequest(ref request, ref callSettings);
            return _callCancelBatchPredictionJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelDeploymentMonitoringJob CreateModelDeploymentMonitoringJob(CreateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callCreateModelDeploymentMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a ModelDeploymentMonitoringJob. It will run periodically on a
        /// configured interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelDeploymentMonitoringJob> CreateModelDeploymentMonitoringJobAsync(CreateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callCreateModelDeploymentMonitoringJob.Async(request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.</returns>
        public override gax::PagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomalies(SearchModelDeploymentMonitoringStatsAnomaliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelDeploymentMonitoringStatsAnomaliesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesRequest, SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies>(_callSearchModelDeploymentMonitoringStatsAnomalies, request, callSettings);
        }

        /// <summary>
        /// Searches Model Monitoring Statistics generated within a given time window.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ModelMonitoringStatsAnomalies"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies> SearchModelDeploymentMonitoringStatsAnomaliesAsync(SearchModelDeploymentMonitoringStatsAnomaliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchModelDeploymentMonitoringStatsAnomaliesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchModelDeploymentMonitoringStatsAnomaliesRequest, SearchModelDeploymentMonitoringStatsAnomaliesResponse, ModelMonitoringStatsAnomalies>(_callSearchModelDeploymentMonitoringStatsAnomalies, request, callSettings);
        }

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelDeploymentMonitoringJob GetModelDeploymentMonitoringJob(GetModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callGetModelDeploymentMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelDeploymentMonitoringJob> GetModelDeploymentMonitoringJobAsync(GetModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callGetModelDeploymentMonitoringJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobs(ListModelDeploymentMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelDeploymentMonitoringJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelDeploymentMonitoringJobsRequest, ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob>(_callListModelDeploymentMonitoringJobs, request, callSettings);
        }

        /// <summary>
        /// Lists ModelDeploymentMonitoringJobs in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelDeploymentMonitoringJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob> ListModelDeploymentMonitoringJobsAsync(ListModelDeploymentMonitoringJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelDeploymentMonitoringJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelDeploymentMonitoringJobsRequest, ListModelDeploymentMonitoringJobsResponse, ModelDeploymentMonitoringJob>(_callListModelDeploymentMonitoringJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateModelDeploymentMonitoringJob</c>.</summary>
        public override lro::OperationsClient UpdateModelDeploymentMonitoringJobOperationsClient { get; }

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> UpdateModelDeploymentMonitoringJob(UpdateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>(_callUpdateModelDeploymentMonitoringJob.Sync(request, callSettings), UpdateModelDeploymentMonitoringJobOperationsClient);
        }

        /// <summary>
        /// Updates a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>> UpdateModelDeploymentMonitoringJobAsync(UpdateModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata>(await _callUpdateModelDeploymentMonitoringJob.Async(request, callSettings).ConfigureAwait(false), UpdateModelDeploymentMonitoringJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteModelDeploymentMonitoringJob</c>.</summary>
        public override lro::OperationsClient DeleteModelDeploymentMonitoringJobOperationsClient { get; }

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteModelDeploymentMonitoringJob(DeleteModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteModelDeploymentMonitoringJob.Sync(request, callSettings), DeleteModelDeploymentMonitoringJobOperationsClient);
        }

        /// <summary>
        /// Deletes a ModelDeploymentMonitoringJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteModelDeploymentMonitoringJobAsync(DeleteModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteModelDeploymentMonitoringJob.Async(request, callSettings).ConfigureAwait(false), DeleteModelDeploymentMonitoringJobOperationsClient);
        }

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PauseModelDeploymentMonitoringJob(PauseModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            _callPauseModelDeploymentMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses a ModelDeploymentMonitoringJob. If the job is running, the server
        /// makes a best effort to cancel the job. Will mark
        /// [ModelDeploymentMonitoringJob.state][google.cloud.aiplatform.v1.ModelDeploymentMonitoringJob.state]
        /// to 'PAUSED'.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PauseModelDeploymentMonitoringJobAsync(PauseModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callPauseModelDeploymentMonitoringJob.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResumeModelDeploymentMonitoringJob(ResumeModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            _callResumeModelDeploymentMonitoringJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused ModelDeploymentMonitoringJob. It will start to run from
        /// next scheduled time. A deleted ModelDeploymentMonitoringJob can't be
        /// resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResumeModelDeploymentMonitoringJobAsync(ResumeModelDeploymentMonitoringJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeModelDeploymentMonitoringJobRequest(ref request, ref callSettings);
            return _callResumeModelDeploymentMonitoringJob.Async(request, callSettings);
        }
    }

    public partial class ListCustomJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataLabelingJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListHyperparameterTuningJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNasJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNasTrialDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBatchPredictionJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchModelDeploymentMonitoringStatsAnomaliesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelDeploymentMonitoringJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomJobsResponse : gaxgrpc::IPageResponse<CustomJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomJob> GetEnumerator() => CustomJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataLabelingJobsResponse : gaxgrpc::IPageResponse<DataLabelingJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataLabelingJob> GetEnumerator() => DataLabelingJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListHyperparameterTuningJobsResponse : gaxgrpc::IPageResponse<HyperparameterTuningJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<HyperparameterTuningJob> GetEnumerator() => HyperparameterTuningJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNasJobsResponse : gaxgrpc::IPageResponse<NasJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NasJob> GetEnumerator() => NasJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNasTrialDetailsResponse : gaxgrpc::IPageResponse<NasTrialDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NasTrialDetail> GetEnumerator() => NasTrialDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBatchPredictionJobsResponse : gaxgrpc::IPageResponse<BatchPredictionJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BatchPredictionJob> GetEnumerator() => BatchPredictionJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchModelDeploymentMonitoringStatsAnomaliesResponse : gaxgrpc::IPageResponse<ModelMonitoringStatsAnomalies>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelMonitoringStatsAnomalies> GetEnumerator() => MonitoringStats.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelDeploymentMonitoringJobsResponse : gaxgrpc::IPageResponse<ModelDeploymentMonitoringJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelDeploymentMonitoringJob> GetEnumerator() =>
            ModelDeploymentMonitoringJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class JobService
    {
        public partial class JobServiceClient
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

    public static partial class JobService
    {
        public partial class JobServiceClient
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
