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
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Scheduler.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudSchedulerClientTest
    {
        [xunit::FactAttribute]
        public void GetJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.GetJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.GetJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.GetJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.Parent, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.Parent, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.Parent, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.CreateJob(request.ParentAsLocationName, request.Job);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.CreateJobAsync(request.ParentAsLocationName, request.Job, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.UpdateJob(request.Job, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new wkt::FieldMask(),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.UpdateJobAsync(request.Job, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.UpdateJobAsync(request.Job, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            client.DeleteJob(request.JobName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteJobAsync(request.JobName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.PauseJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.PauseJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.PauseJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.PauseJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.PauseJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.PauseJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PauseJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.PauseJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PauseJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.PauseJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.PauseJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.PauseJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.ResumeJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.ResumeJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.ResumeJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.ResumeJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.ResumeJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.ResumeJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ResumeJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.ResumeJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ResumeJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.ResumeJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.ResumeJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.ResumeJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunJobRequestObject()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.RunJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunJobRequestObjectAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.RunJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.RunJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunJob()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.RunJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunJobAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.RunJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.RunJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunJobResourceNames()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job response = client.RunJob(request.JobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunJobResourceNamesAsync()
        {
            moq::Mock<CloudScheduler.CloudSchedulerClient> mockGrpcClient = new moq::Mock<CloudScheduler.CloudSchedulerClient>(moq::MockBehavior.Strict);
            RunJobRequest request = new RunJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            Job expectedResponse = new Job
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                Description = "description2cf9da67",
                PubsubTarget = new PubsubTarget(),
                AppEngineHttpTarget = new AppEngineHttpTarget(),
                HttpTarget = new HttpTarget(),
                UserUpdateTime = new wkt::Timestamp(),
                State = Job.Types.State.Disabled,
                Status = new gr::Status(),
                ScheduleTime = new wkt::Timestamp(),
                LastAttemptTime = new wkt::Timestamp(),
                RetryConfig = new RetryConfig(),
                Schedule = "schedule59559879",
                TimeZone = "time_zone73f23b20",
                AttemptDeadline = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RunJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Job>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudSchedulerClient client = new CloudSchedulerClientImpl(mockGrpcClient.Object, null);
            Job responseCallSettings = await client.RunJobAsync(request.JobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Job responseCancellationToken = await client.RunJobAsync(request.JobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
