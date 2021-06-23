// Copyright 2021 Google LLC
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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataflow.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedJobsV1Beta3ClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                View = JobView.Summary,
                ReplaceJobId = "replace_job_id4a0fad7e",
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
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                View = JobView.Summary,
                ReplaceJobId = "replace_job_id4a0fad7e",
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
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                View = JobView.Summary,
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
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                View = JobView.Summary,
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
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobRequestObject()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Job = new Job(),
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
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobRequestObjectAsync()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Job = new Job(),
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
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckActiveJobsRequestObject()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            CheckActiveJobsRequest request = new CheckActiveJobsRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            CheckActiveJobsResponse expectedResponse = new CheckActiveJobsResponse
            {
                ActiveJobsExist = false,
            };
            mockGrpcClient.Setup(x => x.CheckActiveJobs(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            CheckActiveJobsResponse response = client.CheckActiveJobs(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckActiveJobsRequestObjectAsync()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            CheckActiveJobsRequest request = new CheckActiveJobsRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            CheckActiveJobsResponse expectedResponse = new CheckActiveJobsResponse
            {
                ActiveJobsExist = false,
            };
            mockGrpcClient.Setup(x => x.CheckActiveJobsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckActiveJobsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            CheckActiveJobsResponse responseCallSettings = await client.CheckActiveJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckActiveJobsResponse responseCancellationToken = await client.CheckActiveJobsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SnapshotJobRequestObject()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            SnapshotJobRequest request = new SnapshotJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Ttl = new wkt::Duration(),
                Location = "locatione09d18d5",
                SnapshotSources = false,
                Description = "description2cf9da67",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                SourceJobId = "source_job_id1406915d",
                CreationTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                State = SnapshotState.UnknownSnapshotState,
                PubsubMetadata =
                {
                    new PubsubSnapshotMetadata(),
                },
                Description = "description2cf9da67",
                DiskSizeBytes = -5516951742914183668L,
                Region = "regionedb20d96",
            };
            mockGrpcClient.Setup(x => x.SnapshotJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.SnapshotJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SnapshotJobRequestObjectAsync()
        {
            moq::Mock<JobsV1Beta3.JobsV1Beta3Client> mockGrpcClient = new moq::Mock<JobsV1Beta3.JobsV1Beta3Client>(moq::MockBehavior.Strict);
            SnapshotJobRequest request = new SnapshotJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Ttl = new wkt::Duration(),
                Location = "locatione09d18d5",
                SnapshotSources = false,
                Description = "description2cf9da67",
            };
            Snapshot expectedResponse = new Snapshot
            {
                Id = "id74b70bb8",
                ProjectId = "project_id43ad98b0",
                SourceJobId = "source_job_id1406915d",
                CreationTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                State = SnapshotState.UnknownSnapshotState,
                PubsubMetadata =
                {
                    new PubsubSnapshotMetadata(),
                },
                Description = "description2cf9da67",
                DiskSizeBytes = -5516951742914183668L,
                Region = "regionedb20d96",
            };
            mockGrpcClient.Setup(x => x.SnapshotJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobsV1Beta3Client client = new JobsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.SnapshotJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.SnapshotJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
