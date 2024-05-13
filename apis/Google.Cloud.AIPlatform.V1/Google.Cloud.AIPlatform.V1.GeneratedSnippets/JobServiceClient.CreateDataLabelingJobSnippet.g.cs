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
    // [START aiplatform_v1_generated_JobService_CreateDataLabelingJob_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using Google.Type;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataLabelingJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateDataLabelingJob()
        {
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataLabelingJob dataLabelingJob = new DataLabelingJob
            {
                DataLabelingJobName = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]"),
                DisplayName = "",
                DatasetsAsDatasetNames =
                {
                    DatasetName.FromProjectLocationDataset("[PROJECT]", "[LOCATION]", "[DATASET]"),
                },
                LabelerCount = 0,
                InstructionUri = "",
                InputsSchemaUri = "",
                Inputs = new wkt::Value
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
                State = JobState.Unspecified,
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
                Labels = { { "", "" }, },
                AnnotationLabels = { { "", "" }, },
                LabelingProgress = 0,
                CurrentSpend = new Money
                {
                    CurrencyCode = "",
                    Units = 0L,
                    Nanos = 0,
                },
                SpecialistPools = { "", },
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                ActiveLearningConfig = new ActiveLearningConfig
                {
                    MaxDataItemCount = 0L,
                    MaxDataItemPercentage = 0,
                    SampleConfig = new SampleConfig
                    {
                        InitialBatchSamplePercentage = 0,
                        FollowingBatchSamplePercentage = 0,
                        SampleStrategy = SampleConfig.Types.SampleStrategy.Unspecified,
                    },
                    TrainingConfig = new TrainingConfig
                    {
                        TimeoutTrainingMilliHours = 0L,
                    },
                },
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
            };
            // Make the request
            DataLabelingJob response = jobServiceClient.CreateDataLabelingJob(parent, dataLabelingJob);
        }
    }
    // [END aiplatform_v1_generated_JobService_CreateDataLabelingJob_sync_flattened]
}
