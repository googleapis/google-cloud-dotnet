// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataflow.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTemplatesServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobFromTemplateRequestObject()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            CreateJobFromTemplateRequest request = new CreateJobFromTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                GcsPath = "gcs_path83b28bb9",
                Parameters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                JobName = "job_namedc176648",
                Environment = new RuntimeEnvironment(),
                Location = "locatione09d18d5",
            };
            Job expectedResponse = new Job
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                Name = "name1c9368b0",
                Type = JobType.Unknown,
                Environment = new Environment(),
                Steps = { new Step(), },
                CurrentState = JobState.Unknown,
                CurrentStateTime = new wkt::Timestamp(),
                RequestedState = JobState.Stopped,
                ExecutionInfo = new JobExecutionInfo(),
                CreateTime = new wkt::Timestamp(),
                ReplaceJobId = "replace_job_id4a0fad7e",
                TransformNameMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientRequestId = "client_request_ide162ec50",
                ReplacedByJobId = "replaced_by_job_ida56afc22",
                TempFiles =
                {
                    "temp_filescb023328",
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Location = "locatione09d18d5",
                PipelineDescription = new PipelineDescription(),
                StageStates =
                {
                    new ExecutionStageState(),
                },
                JobMetadata = new JobMetadata(),
                StartTime = new wkt::Timestamp(),
                CreatedFromSnapshotId = "created_from_snapshot_id9b426c65",
                StepsLocation = "steps_location41e078c5",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.CreateJobFromTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.CreateJobFromTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobFromTemplateRequestObjectAsync()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            CreateJobFromTemplateRequest request = new CreateJobFromTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                GcsPath = "gcs_path83b28bb9",
                Parameters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                JobName = "job_namedc176648",
                Environment = new RuntimeEnvironment(),
                Location = "locatione09d18d5",
            };
            Job expectedResponse = new Job
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                Name = "name1c9368b0",
                Type = JobType.Unknown,
                Environment = new Environment(),
                Steps = { new Step(), },
                CurrentState = JobState.Unknown,
                CurrentStateTime = new wkt::Timestamp(),
                RequestedState = JobState.Stopped,
                ExecutionInfo = new JobExecutionInfo(),
                CreateTime = new wkt::Timestamp(),
                ReplaceJobId = "replace_job_id4a0fad7e",
                TransformNameMapping =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                ClientRequestId = "client_request_ide162ec50",
                ReplacedByJobId = "replaced_by_job_ida56afc22",
                TempFiles =
                {
                    "temp_filescb023328",
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Location = "locatione09d18d5",
                PipelineDescription = new PipelineDescription(),
                StageStates =
                {
                    new ExecutionStageState(),
                },
                JobMetadata = new JobMetadata(),
                StartTime = new wkt::Timestamp(),
                CreatedFromSnapshotId = "created_from_snapshot_id9b426c65",
                StepsLocation = "steps_location41e078c5",
                SatisfiesPzs = false,
            };
            mockGrpcClient.Setup(x => x.CreateJobFromTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.CreateJobFromTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobFromTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LaunchTemplateRequestObject()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            LaunchTemplateRequest request = new LaunchTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                ValidateOnly = true,
                GcsPath = "gcs_path83b28bb9",
                LaunchParameters = new LaunchTemplateParameters(),
                Location = "locatione09d18d5",
                DynamicTemplate = new DynamicTemplateLaunchParams(),
            };
            LaunchTemplateResponse expectedResponse = new LaunchTemplateResponse { Job = new Job(), };
            mockGrpcClient.Setup(x => x.LaunchTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            LaunchTemplateResponse response = client.LaunchTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LaunchTemplateRequestObjectAsync()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            LaunchTemplateRequest request = new LaunchTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                ValidateOnly = true,
                GcsPath = "gcs_path83b28bb9",
                LaunchParameters = new LaunchTemplateParameters(),
                Location = "locatione09d18d5",
                DynamicTemplate = new DynamicTemplateLaunchParams(),
            };
            LaunchTemplateResponse expectedResponse = new LaunchTemplateResponse { Job = new Job(), };
            mockGrpcClient.Setup(x => x.LaunchTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LaunchTemplateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            LaunchTemplateResponse responseCallSettings = await client.LaunchTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LaunchTemplateResponse responseCancellationToken = await client.LaunchTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTemplateRequestObject()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            GetTemplateRequest request = new GetTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                GcsPath = "gcs_path83b28bb9",
                View = GetTemplateRequest.Types.TemplateView.MetadataOnly,
                Location = "locatione09d18d5",
            };
            GetTemplateResponse expectedResponse = new GetTemplateResponse
            {
                Status = new gr::Status(),
                Metadata = new TemplateMetadata(),
                TemplateType = GetTemplateResponse.Types.TemplateType.Flex,
                RuntimeMetadata = new RuntimeMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetTemplate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            GetTemplateResponse response = client.GetTemplate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTemplateRequestObjectAsync()
        {
            moq::Mock<TemplatesService.TemplatesServiceClient> mockGrpcClient = new moq::Mock<TemplatesService.TemplatesServiceClient>(moq::MockBehavior.Strict);
            GetTemplateRequest request = new GetTemplateRequest
            {
                ProjectId = "project_id43ad98b0",
                GcsPath = "gcs_path83b28bb9",
                View = GetTemplateRequest.Types.TemplateView.MetadataOnly,
                Location = "locatione09d18d5",
            };
            GetTemplateResponse expectedResponse = new GetTemplateResponse
            {
                Status = new gr::Status(),
                Metadata = new TemplateMetadata(),
                TemplateType = GetTemplateResponse.Types.TemplateType.Flex,
                RuntimeMetadata = new RuntimeMetadata(),
            };
            mockGrpcClient.Setup(x => x.GetTemplateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetTemplateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TemplatesServiceClient client = new TemplatesServiceClientImpl(mockGrpcClient.Object, null, null);
            GetTemplateResponse responseCallSettings = await client.GetTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetTemplateResponse responseCancellationToken = await client.GetTemplateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
