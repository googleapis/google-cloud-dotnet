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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dataproc.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedJobControllerClientTest
    {
        [xunit::FactAttribute]
        public void SubmitJobRequestObject()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                Region = "regionedb20d96",
                RequestId = "request_id362c8df6",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.SubmitJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.SubmitJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SubmitJobRequestObjectAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                Region = "regionedb20d96",
                RequestId = "request_id362c8df6",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.SubmitJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.SubmitJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.SubmitJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SubmitJob()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.SubmitJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.SubmitJob(request.ProjectId, request.Region, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SubmitJobAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Job = new Job(),
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.SubmitJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.SubmitJobAsync(request.ProjectId, request.Region, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.SubmitJobAsync(request.ProjectId, request.Region, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.ProjectId, request.Region, request.JobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.ProjectId, request.Region, request.JobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.ProjectId, request.Region, request.JobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobRequestObject()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Region = "regionedb20d96",
                JobId = "job_id38ea97d6",
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobRequestObjectAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "project_id43ad98b0",
                Region = "regionedb20d96",
                JobId = "job_id38ea97d6",
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelJobRequestObject()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CancelJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CancelJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelJobRequestObjectAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CancelJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CancelJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CancelJob()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CancelJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CancelJob(request.ProjectId, request.Region, request.JobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CancelJobAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            Job expectedResponse = new Job
            {
                Reference = new JobReference(),
                Placement = new JobPlacement(),
                HadoopJob = new HadoopJob(),
                SparkJob = new SparkJob(),
                PysparkJob = new PySparkJob(),
                HiveJob = new HiveJob(),
                PigJob = new PigJob(),
                Status = new JobStatus(),
                YarnApplications =
                {
                    new YarnApplication(),
                },
                SparkSqlJob = new SparkSqlJob(),
                StatusHistory = { new JobStatus(), },
                DriverControlFilesUri = "driver_control_files_uribe41e88b",
                DriverOutputResourceUri = "driver_output_resource_urie2b470d7",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Scheduling = new JobScheduling(),
                SparkRJob = new SparkRJob(),
                JobUuid = "job_uuid7530ffdd",
                PrestoJob = new PrestoJob(),
                Done = true,
            };
            mockGrpcClient.Setup(x => x.CancelJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CancelJobAsync(request.ProjectId, request.Region, request.JobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CancelJobAsync(request.ProjectId, request.Region, request.JobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.ProjectId, request.Region, request.JobId);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<JobController.JobControllerClient> mockGrpcClient = new moq::Mock<JobController.JobControllerClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                Region = "regionedb20d96",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            JobControllerClient client = new JobControllerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.ProjectId, request.Region, request.JobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.ProjectId, request.Region, request.JobId, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
