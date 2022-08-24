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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Batch.V1Alpha.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBatchServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
                RequestId = "request_id362c8df6",
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
                RequestId = "request_id362c8df6",
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.CreateJob(request.Parent, request.Job, request.JobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, request.JobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, request.JobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.CreateJob(request.ParentAsLocationName, request.Job, request.JobId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNamesAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "job_id38ea97d6",
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, request.JobId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, request.JobId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Uid = "uida2d37198",
                Priority = -5465821670500890439L,
                TaskGroups = { new TaskGroup(), },
                SchedulingPolicy = Job.Types.SchedulingPolicy.AsSoonAsPossible,
                Dependencies =
                {
                    new JobDependency(),
                },
                AllocationPolicy = new AllocationPolicy(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Status = new JobStatus(),
#pragma warning disable CS0612
                Notification = new JobNotification(),
#pragma warning restore CS0612
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LogsPolicy = new LogsPolicy(),
                Notifications =
                {
                    new JobNotification(),
                },
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskRequestObject()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskRequestObjectAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTask()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTaskResourceNames()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTask(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task response = client.GetTask(request.TaskName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTaskResourceNamesAsync()
        {
            moq::Mock<BatchService.BatchServiceClient> mockGrpcClient = new moq::Mock<BatchService.BatchServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            Task expectedResponse = new Task
            {
                TaskName = TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
                Status = new TaskStatus(),
            };
            mockGrpcClient.Setup(x => x.GetTaskAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Task>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchServiceClient client = new BatchServiceClientImpl(mockGrpcClient.Object, null, null);
            Task responseCallSettings = await client.GetTaskAsync(request.TaskName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Task responseCancellationToken = await client.GetTaskAsync(request.TaskName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
