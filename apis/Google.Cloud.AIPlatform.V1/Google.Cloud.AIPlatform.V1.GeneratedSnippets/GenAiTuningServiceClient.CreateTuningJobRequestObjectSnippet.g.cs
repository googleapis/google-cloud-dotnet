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
    // [START aiplatform_v1_generated_GenAiTuningService_CreateTuningJob_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedGenAiTuningServiceClientSnippets
    {
        /// <summary>Snippet for CreateTuningJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateTuningJobRequestObject()
        {
            // Create client
            GenAiTuningServiceClient genAiTuningServiceClient = GenAiTuningServiceClient.Create();
            // Initialize request argument(s)
            CreateTuningJobRequest request = new CreateTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TuningJob = new TuningJob
                {
                    TuningJobName = TuningJobName.FromProjectLocationTuningJob("[PROJECT]", "[LOCATION]", "[TUNING_JOB]"),
                    TunedModelDisplayName = "",
                    Description = "",
                    BaseModel = "",
                    SupervisedTuningSpec = new SupervisedTuningSpec
                    {
                        TrainingDatasetUri = "",
                        ValidationDatasetUri = "",
                        HyperParameters = new SupervisedHyperParameters
                        {
                            EpochCount = 0L,
                            LearningRateMultiplier = 0,
                            AdapterSize = SupervisedHyperParameters.Types.AdapterSize.Unspecified,
                        },
                    },
                    State = JobState.Unspecified,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
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
                    Labels = { { "", "" }, },
                    ExperimentAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                    TunedModel = new TunedModel
                    {
                        ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                        EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                    },
                    TuningDataStats = new TuningDataStats
                    {
                        SupervisedTuningDataStats = new SupervisedTuningDataStats
                        {
                            TuningDatasetExampleCount = 0L,
                            TotalTuningCharacterCount = 0L,
                            TotalBillableCharacterCount = 0L,
                            TuningStepCount = 0L,
                            UserInputTokenDistribution = new SupervisedTuningDatasetDistribution
                            {
                                Sum = 0L,
                                Min = 0,
                                Max = 0,
                                Mean = 0,
                                Median = 0,
                                P5 = 0,
                                P95 = 0,
                                Buckets =
                                {
                                    new SupervisedTuningDatasetDistribution.Types.DatasetBucket
                                    {
                                        Count = 0,
                                        Left = 0,
                                        Right = 0,
                                    },
                                },
                            },
                            UserOutputTokenDistribution = new SupervisedTuningDatasetDistribution
                            {
                                Sum = 0L,
                                Min = 0,
                                Max = 0,
                                Mean = 0,
                                Median = 0,
                                P5 = 0,
                                P95 = 0,
                                Buckets =
                                {
                                    new SupervisedTuningDatasetDistribution.Types.DatasetBucket
                                    {
                                        Count = 0,
                                        Left = 0,
                                        Right = 0,
                                    },
                                },
                            },
                            UserMessagePerExampleDistribution = new SupervisedTuningDatasetDistribution
                            {
                                Sum = 0L,
                                Min = 0,
                                Max = 0,
                                Mean = 0,
                                Median = 0,
                                P5 = 0,
                                P95 = 0,
                                Buckets =
                                {
                                    new SupervisedTuningDatasetDistribution.Types.DatasetBucket
                                    {
                                        Count = 0,
                                        Left = 0,
                                        Right = 0,
                                    },
                                },
                            },
                            UserDatasetExamples =
                            {
                                new Content
                                {
                                    Role = "",
                                    Parts =
                                    {
                                        new Part
                                        {
                                            Text = "",
                                            InlineData = new Blob
                                            {
                                                MimeType = "",
                                                Data = ByteString.Empty,
                                            },
                                            FileData = new FileData
                                            {
                                                MimeType = "",
                                                FileUri = "",
                                            },
                                            VideoMetadata = new VideoMetadata
                                            {
                                                StartOffset = new wkt::Duration
                                                {
                                                    Seconds = 0L,
                                                    Nanos = 0,
                                                },
                                                EndOffset = new wkt::Duration
                                                {
                                                    Seconds = 0L,
                                                    Nanos = 0,
                                                },
                                            },
                                            FunctionCall = new FunctionCall
                                            {
                                                Name = "",
                                                Args = new wkt::Struct
                                                {
                                                    Fields =
                                                    {
                                                        {
                                                            "",
                                                            new wkt::Value
                                                            {
                                                                NullValue = wkt::NullValue.NullValue,
                                                                NumberValue = 0,
                                                                StringValue = "",
                                                                BoolValue = false,
                                                                StructValue = new wkt::Struct { },
                                                                ListValue = new wkt::ListValue
                                                                {
                                                                    Values = { new wkt::Value { }, },
                                                                },
                                                            }
                                                        },
                                                    },
                                                },
                                            },
                                            FunctionResponse = new FunctionResponse
                                            {
                                                Name = "",
                                                Response = new wkt::Struct
                                                {
                                                    Fields =
                                                    {
                                                        {
                                                            "",
                                                            new wkt::Value
                                                            {
                                                                NullValue = wkt::NullValue.NullValue,
                                                                NumberValue = 0,
                                                                StringValue = "",
                                                                BoolValue = false,
                                                                StructValue = new wkt::Struct { },
                                                                ListValue = new wkt::ListValue
                                                                {
                                                                    Values = { new wkt::Value { }, },
                                                                },
                                                            }
                                                        },
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            // Make the request
            TuningJob response = genAiTuningServiceClient.CreateTuningJob(request);
        }
    }
    // [END aiplatform_v1_generated_GenAiTuningService_CreateTuningJob_sync]
}
