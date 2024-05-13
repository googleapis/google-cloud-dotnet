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
    // [START aiplatform_v1_generated_ScheduleService_UpdateSchedule_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedScheduleServiceClientSnippets
    {
        /// <summary>Snippet for UpdateScheduleAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateScheduleRequestObjectAsync()
        {
            // Create client
            ScheduleServiceClient scheduleServiceClient = await ScheduleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScheduleRequest request = new UpdateScheduleRequest
            {
                Schedule = new Schedule
                {
                    ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                    DisplayName = "",
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
                    State = Schedule.Types.State.Unspecified,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    NextRunTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    LastPauseTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    LastResumeTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Cron = "",
                    MaxConcurrentRunCount = 0L,
                    AllowQueueing = false,
                    CatchUp = false,
                    CreatePipelineJobRequest = new CreatePipelineJobRequest
                    {
                        ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                        PipelineJob = new PipelineJob
                        {
                            PipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                            DisplayName = "",
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
                            PipelineSpec = new wkt::Struct
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
                            State = PipelineState.Unspecified,
                            JobDetail = new PipelineJobDetail
                            {
                                PipelineContext = new Context
                                {
                                    ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                                    DisplayName = "",
                                    Etag = "",
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
                                    ParentContextsAsContextNames =
                                    {
                                        ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                                    },
                                    SchemaTitle = "",
                                    SchemaVersion = "",
                                    Metadata = new wkt::Struct
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
                                    Description = "",
                                },
                                PipelineRunContext = new Context
                                {
                                    ContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                                    DisplayName = "",
                                    Etag = "",
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
                                    ParentContextsAsContextNames =
                                    {
                                        ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                                    },
                                    SchemaTitle = "",
                                    SchemaVersion = "",
                                    Metadata = new wkt::Struct
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
                                    Description = "",
                                },
                                TaskDetails =
                                {
                                    new PipelineTaskDetail
                                    {
                                        TaskId = 0L,
                                        TaskName = "",
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
                                        ExecutorDetail = new PipelineTaskExecutorDetail
                                        {
                                            ContainerDetail = new PipelineTaskExecutorDetail.Types.ContainerDetail
                                            {
                                                MainJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                                                PreCachingCheckJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                                                FailedMainJobs = { "", },
                                                FailedPreCachingCheckJobs = { "", },
                                            },
                                            CustomJobDetail = new PipelineTaskExecutorDetail.Types.CustomJobDetail
                                            {
                                                JobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                                                FailedJobs = { "", },
                                            },
                                        },
                                        State = PipelineTaskDetail.Types.State.Unspecified,
                                        Execution = new Execution
                                        {
                                            ExecutionName = ExecutionName.FromProjectLocationMetadataStoreExecution("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[EXECUTION]"),
                                            DisplayName = "",
                                            State = Execution.Types.State.Unspecified,
                                            Etag = "",
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
                                            SchemaTitle = "",
                                            SchemaVersion = "",
                                            Metadata = new wkt::Struct
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
                                            Description = "",
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
                                        Inputs =
                                        {
                                            {
                                                "",
                                                new PipelineTaskDetail.Types.ArtifactList
                                                {
                                                    Artifacts =
                                                    {
                                                        new Artifact
                                                        {
                                                            ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                                                            DisplayName = "",
                                                            Uri = "",
                                                            Etag = "",
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
                                                            State = Artifact.Types.State.Unspecified,
                                                            SchemaTitle = "",
                                                            SchemaVersion = "",
                                                            Metadata = new wkt::Struct
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
                                                            Description = "",
                                                        },
                                                    },
                                                }
                                            },
                                        },
                                        Outputs =
                                        {
                                            {
                                                "",
                                                new PipelineTaskDetail.Types.ArtifactList
                                                {
                                                    Artifacts =
                                                    {
                                                        new Artifact
                                                        {
                                                            ArtifactName = ArtifactName.FromProjectLocationMetadataStoreArtifact("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[ARTIFACT]"),
                                                            DisplayName = "",
                                                            Uri = "",
                                                            Etag = "",
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
                                                            State = Artifact.Types.State.Unspecified,
                                                            SchemaTitle = "",
                                                            SchemaVersion = "",
                                                            Metadata = new wkt::Struct
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
                                                            Description = "",
                                                        },
                                                    },
                                                }
                                            },
                                        },
                                        ParentTaskId = 0L,
                                        PipelineTaskStatus =
                                        {
                                            new PipelineTaskDetail.Types.PipelineTaskStatus
                                            {
                                                UpdateTime = new wkt::Timestamp
                                                {
                                                    Seconds = 0L,
                                                    Nanos = 0,
                                                },
                                                State = PipelineTaskDetail.Types.State.Unspecified,
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
                                            },
                                        },
                                    },
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
                            Labels = { { "", "" }, },
                            RuntimeConfig = new PipelineJob.Types.RuntimeConfig
                            {
                                GcsOutputDirectory = "",
                                ParameterValues =
                                {
                                    {
                                        "",
                                        new wkt::Value
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
                                        }
                                    },
                                },
                                FailurePolicy = PipelineFailurePolicy.Unspecified,
                                InputArtifacts =
                                {
                                    {
                                        "",
                                        new PipelineJob.Types.RuntimeConfig.Types.InputArtifact { ArtifactId = "", }
                                    },
                                },
                            },
                            EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                            ServiceAccount = "",
                            NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                            TemplateUri = "",
                            TemplateMetadata = new PipelineTemplateMetadata { Version = "", },
                            ScheduleName = "",
                            ReservedIpRanges = { "", },
                        },
                        PipelineJobId = "",
                    },
                    MaxRunCount = 0L,
                    StartedRunCount = 0L,
                    LastScheduledRunResponse = new Schedule.Types.RunResponse
                    {
                        ScheduledRunTime = new wkt::Timestamp
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        RunResponse_ = "",
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                },
                UpdateMask = new wkt::FieldMask { Paths = { "", }, },
            };
            // Make the request
            Schedule response = await scheduleServiceClient.UpdateScheduleAsync(request);
        }
    }
    // [END aiplatform_v1_generated_ScheduleService_UpdateSchedule_async]
}
