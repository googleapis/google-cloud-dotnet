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
    // [START aiplatform_v1_generated_JobService_UpdateModelDeploymentMonitoringJob_sync]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Rpc;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for UpdateModelDeploymentMonitoringJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateModelDeploymentMonitoringJobRequestObject()
        {
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            UpdateModelDeploymentMonitoringJobRequest request = new UpdateModelDeploymentMonitoringJobRequest
            {
                ModelDeploymentMonitoringJob = new ModelDeploymentMonitoringJob
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
                },
                UpdateMask = new wkt::FieldMask { Paths = { "", }, },
            };
            // Make the request
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> response = jobServiceClient.UpdateModelDeploymentMonitoringJob(request);

            // Poll until the returned long-running operation is complete
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ModelDeploymentMonitoringJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ModelDeploymentMonitoringJob, UpdateModelDeploymentMonitoringJobOperationMetadata> retrievedResponse = jobServiceClient.PollOnceUpdateModelDeploymentMonitoringJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ModelDeploymentMonitoringJob retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_JobService_UpdateModelDeploymentMonitoringJob_sync]
}
