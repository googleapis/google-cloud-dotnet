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

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_JobService_CreateModelDeploymentMonitoringJob_async_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateModelDeploymentMonitoringJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateModelDeploymentMonitoringJobAsync()
        {
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ModelDeploymentMonitoringJob modelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob
            {
                ModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
                DisplayName = "",
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                State = JobState.Unspecified,
                ScheduleState = ModelDeploymentMonitoringJob.Types.MonitoringScheduleState.Unspecified,
                ModelDeploymentMonitoringObjectiveConfigs =
                {
                    new ModelDeploymentMonitoringObjectiveConfig
                    {
                        DeployedModelId = "",
                        ObjectiveConfig = new ModelMonitoringObjectiveConfig
                        {
                            TrainingDataset = new ModelMonitoringObjectiveConfig.Types.TrainingDataset
                            {
                                DataFormat = "",
                                DatasetAsDatasetName = DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                                GcsSource = new GcsSource { Uris = { "", }, },
                                BigquerySource = new BigQuerySource { InputUri = "", },
                                TargetField = "",
                                LoggingSamplingStrategy = new SamplingStrategy
                                {
                                    RandomSampleConfig = new SamplingStrategy.Types.RandomSampleConfig { SampleRate = 0, },
                                },
                            },
                            TrainingPredictionSkewDetectionConfig = new ModelMonitoringObjectiveConfig.Types.TrainingPredictionSkewDetectionConfig
                            {
                                SkewThresholds =
                                {
                                    {
                                        "",
                                        new ThresholdConfig { Value = 0, }
                                    },
                                },
                                AttributionScoreSkewThresholds =
                                {
                                    {
                                        "",
                                        new ThresholdConfig { Value = 0, }
                                    },
                                },
                                DefaultSkewThreshold = new ThresholdConfig { Value = 0, },
                            },
                            PredictionDriftDetectionConfig = new ModelMonitoringObjectiveConfig.Types.PredictionDriftDetectionConfig
                            {
                                DriftThresholds =
                                {
                                    {
                                        "",
                                        new ThresholdConfig { Value = 0, }
                                    },
                                },
                                AttributionScoreDriftThresholds =
                                {
                                    {
                                        "",
                                        new ThresholdConfig { Value = 0, }
                                    },
                                },
                                DefaultDriftThreshold = new ThresholdConfig { Value = 0, },
                            },
                            ExplanationConfig = new ModelMonitoringObjectiveConfig.Types.ExplanationConfig
                            {
                                EnableFeatureAttributes = false,
                                ExplanationBaseline = new ModelMonitoringObjectiveConfig.Types.ExplanationConfig.Types.ExplanationBaseline
                                {
                                    PredictionFormat = ModelMonitoringObjectiveConfig.Types.ExplanationConfig.Types.ExplanationBaseline.Types.PredictionFormat.Unspecified,
                                    Gcs = new GcsDestination
                                    {
                                        OutputUriPrefix = "",
                                    },
                                    Bigquery = new BigQueryDestination { OutputUri = "", },
                                },
                            },
                        },
                    },
                },
                ModelDeploymentMonitoringScheduleConfig = new ModelDeploymentMonitoringScheduleConfig
                {
                    MonitorInterval = new wkt::Duration
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    MonitorWindow = new wkt::Duration
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                },
                LoggingSamplingStrategy = new SamplingStrategy
                {
                    RandomSampleConfig = new SamplingStrategy.Types.RandomSampleConfig { SampleRate = 0, },
                },
                PredictInstanceSchemaUri = "",
                BigqueryTables =
                {
                    new ModelDeploymentMonitoringBigQueryTable
                    {
                        LogSource = ModelDeploymentMonitoringBigQueryTable.Types.LogSource.Unspecified,
                        LogType = ModelDeploymentMonitoringBigQueryTable.Types.LogType.Unspecified,
                        BigqueryTablePath = "",
                        RequestResponseLoggingSchemaVersion = "",
                    },
                },
                Labels = { { "", "" }, },
                CreateTime = new wkt::Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                UpdateTime = new wkt::Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                NextScheduleTime = new wkt::Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                ModelMonitoringAlertConfig = new ModelMonitoringAlertConfig
                {
                    EmailAlertConfig = new ModelMonitoringAlertConfig.Types.EmailAlertConfig { UserEmails = { "", }, },
                    EnableLogging = false,
                    NotificationChannelsAsNotificationChannelNames =
                    {
                        NotificationChannelName.FromProjectNotificationChannel("[PROJECT]", "[NOTIFICATION_CHANNEL]"),
                    },
                },
                AnalysisInstanceSchemaUri = "",
                LogTtl = new wkt::Duration
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                SamplePredictInstance = new wkt::Value
                {
                    NullValue = wkt::NullValue.NullValue,
                    NumberValue = 0,
                    StringValue = "",
                    BoolValue = false,
                    StructValue = new wkt::Struct
                    {
                        Fields =
                        {
                            {
                                "",
                                new wkt::Value { }
                            },
                        },
                    },
                    ListValue = new wkt::ListValue
                    {
                        Values = { new wkt::Value { }, },
                    },
                },
                StatsAnomaliesBaseDirectory = new GcsDestination
                {
                    OutputUriPrefix = "",
                },
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                EnableMonitoringPipelineLogs = false,
                Error = new Status
                {
                    Code = 0,
                    Message = "",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "",
                            Value = ByteString.Empty,
                        },
                    },
                },
                LatestMonitoringPipelineMetadata = new ModelDeploymentMonitoringJob.Types.LatestMonitoringPipelineMetadata
                {
                    RunTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Status = new Status
                    {
                        Code = 0,
                        Message = "",
                        Details =
                        {
                            new wkt::Any
                            {
                                TypeUrl = "",
                                Value = ByteString.Empty,
                            },
                        },
                    },
                },
            };
            // Make the request
            ModelDeploymentMonitoringJob response = await jobServiceClient.CreateModelDeploymentMonitoringJobAsync(parent, modelDeploymentMonitoringJob);
        }
    }
    // [END aiplatform_v1_generated_JobService_CreateModelDeploymentMonitoringJob_async_flattened]
}
